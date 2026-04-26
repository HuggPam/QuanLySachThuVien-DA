using Microsoft.Reporting.WinForms;
using QuanLyThuVien.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien.Reports
{
    public partial class frmThongKeHoatDong : Form
    {
        QLTVContext context = new QLTVContext();
        QLTVDataSet.ThongKeHoatDongDataTable dataTable = new QLTVDataSet.ThongKeHoatDongDataTable();
        string reportsFolder = Application.StartupPath.Replace("bin\\Debug\\net8.0-windows", "Reports");
        public frmThongKeHoatDong()
        {
            InitializeComponent();
            reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            reportViewer1.Padding = new Padding(0, 100, 0, 0);
            reportViewer1.Dock = DockStyle.Fill;
            this.Controls.Add(reportViewer1);
        }

        public void LayThanhVienVaoComboBox()
        {
            cboThanhVien.DataSource = context.ThanhVien.ToList();
            cboThanhVien.DisplayMember = "TenThanhVien";
            cboThanhVien.ValueMember = "ID";
            cboThanhVien.SelectedIndex = -1;
        }

        public void LayTrangThaiVaoComboBox()
        {
            var ds = new[] {
            new { ID = 0, Ten = "Đang mượn" },
            new { ID = 1, Ten = "Đã hoàn thành" }
    }.ToList();
            cboTrangThai.DataSource = ds;
            cboTrangThai.DisplayMember = "Ten";
            cboTrangThai.ValueMember = "ID";
            cboTrangThai.SelectedIndex = -1;
        }

        private void frmThongKeHoatDong_Load(object sender, EventArgs e)
        {
            LayTrangThaiVaoComboBox();
            LayThanhVienVaoComboBox();
            var danhSachPhieuMuon = context.PhieuMuon.Select(r => new DanhSachPhieuMuon
            {
                ID = r.ID,
                NhanVienID = r.NhanVienID,
                TenNhanVien = r.NhanVien.TenNhanVien,
                ThanhVienID = r.ThanhVienID,
                TenThanhVien = r.ThanhVien.TenThanhVien,
                NgayMuon = r.NgayMuon,
                TrangThai = r.TrangThai,
                ChiTiet = string.Join(", ", r.ChiTietPhieuMuon.Select(c => c.Sach.TenSach))
            }).ToList();

            dataTable.Clear();
            foreach (var row in danhSachPhieuMuon)
            {
                dataTable.AddThongKeHoatDongRow(
                    row.ID,
                    row.NhanVienID,
                    row.TenNhanVien,
                    row.ThanhVienID,
                    row.TenThanhVien,
                    row.NgayMuon,
                    row.TrangThai,
                    row.ChiTiet
                );
            }
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "ThongKeHoatDong";
            rds.Value = dataTable;

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);

            reportViewer1.LocalReport.ReportPath = Path.Combine(reportsFolder, "rptThongKeHoatDong.rdlc");

            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
            reportViewer1.RefreshReport();
        }

        private void btnLocKetQua_Click(object sender, EventArgs e)
        {
            var query = context.PhieuMuon.AsQueryable();

            DateTime tuNgay = dtpTuNgay.Value.Date;
            DateTime denNgay = dtpDenNgay.Value.Date.AddDays(1).AddTicks(-1);
            query = query.Where(r => r.NgayMuon >= tuNgay && r.NgayMuon <= denNgay);

            string moTaThanhVien = "Tất cả thành viên";
            string moTaTrangThai = "Tất cả trạng thái";

            if (cboThanhVien.SelectedIndex != -1)
            {
                int maTV = (int)cboThanhVien.SelectedValue;
                moTaThanhVien = "Thành viên: " + cboThanhVien.Text;
                query = query.Where(r => r.ThanhVienID == maTV);
            }

            if (cboTrangThai.SelectedIndex != -1)
            {
                int status = (int)cboTrangThai.SelectedValue;
                moTaTrangThai = "Trạng thái: " + cboTrangThai.Text;
                query = query.Where(r => r.TrangThai == status);
            }

            var danhSach = query.Select(r => new DanhSachPhieuMuon
            {
                ID = r.ID,
                TenNhanVien = r.NhanVien.TenNhanVien,
                TenThanhVien = r.ThanhVien.TenThanhVien,
                NgayMuon = r.NgayMuon,
                TrangThai = r.TrangThai,
                ChiTiet = string.Join(", ", r.ChiTietPhieuMuon.Select(c => c.Sach.TenSach))
            }).ToList();

            dataTable.Clear();
            foreach (var row in danhSach)
            {
                dataTable.AddThongKeHoatDongRow(row.ID, row.NhanVienID, row.TenNhanVien, row.ThanhVienID, row.TenThanhVien, row.NgayMuon, row.TrangThai, row.ChiTiet);
            }

            ReportDataSource rds = new ReportDataSource("ThongKeHoatDong", (DataTable)dataTable);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.ReportPath = Path.Combine(reportsFolder, "rptThongKeHoatDong.rdlc");

            string thongTinLoc = $"({moTaThanhVien} - {moTaTrangThai} - Từ ngày {dtpTuNgay.Text} đến {dtpDenNgay.Text})";
            ReportParameter rp = new ReportParameter("MoTaKetQuaHienThi", thongTinLoc);
            reportViewer1.LocalReport.SetParameters(rp);

            reportViewer1.RefreshReport();
        }

        private void btnHienTatCa_Click(object sender, EventArgs e)
        {
            frmThongKeHoatDong_Load(sender, e);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
