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
    public partial class frmThongKeDoanhThu : Form
    {
        QLTVContext context = new QLTVContext();
        QLTVDataSet.ThongKeDoanhThuDataTable dataTable = new QLTVDataSet.ThongKeDoanhThuDataTable();
        string reportsFolder = Application.StartupPath.Replace("bin\\Debug\\net8.0-windows", "Reports");
        public frmThongKeDoanhThu()
        {
            InitializeComponent();
            reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            reportViewer1.Padding = new Padding(0, 80, 0, 0);
            reportViewer1.Dock = DockStyle.Fill;
            this.Controls.Add(reportViewer1);
        }

        private void frmThongKeDoanhThu_Load(object sender, EventArgs e)
        {
            LayLoaiThuVaoComboBox();
            var danhSachPhieuThu = context.PhieuThu.Select(p => new DanhSachPhieuThu
            {
                ID = p.ID,
                TenThanhVien = p.ThanhVien.TenThanhVien,
                NgayThu = p.NgayThu,
                LoaiThu = p.LoaiThu,
                SoTienThu = p.SoTienThu,
                TenNhanVien = p.NhanVien.TenNhanVien,
                LyDoThu = p.LyDoThu
            }).OrderByDescending(x => x.NgayThu).ToList();

            dataTable.Clear();
            foreach (var row in danhSachPhieuThu)
            {
                dataTable.AddThongKeDoanhThuRow(
                    row.ID,
                    row.SoTienThu,
                    row.NgayThu,
                    row.LoaiThu,
                    row.TenThanhVien,
                    row.TenNhanVien,
                    row.LyDoThu
                );
            }
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "ThongKeDoanhThu";
            rds.Value = dataTable;

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);

            reportViewer1.LocalReport.ReportPath = Path.Combine(reportsFolder, "rptThongKeDoanhThu.rdlc");

            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
            reportViewer1.RefreshReport();
        }

        private void btnLocKetQua_Click(object sender, EventArgs e)
        {
            DateTime tuNgay = dtpTuNgay.Value.Date;
            DateTime denNgay = dtpDenNgay.Value.Date.AddDays(1).AddTicks(-1);

            var query = context.PhieuThu.AsQueryable();

            query = query.Where(p => p.NgayThu >= tuNgay && p.NgayThu <= denNgay);

            string moTaLoaiThu = "Tất cả loại thu";

            int loaiChon = (int)cboLoaiThu.SelectedValue;
            if (loaiChon != -1)
            {
                query = query.Where(p => p.LoaiThu == loaiChon);
                moTaLoaiThu = "Loại thu: " + cboLoaiThu.Text;
            }

            var dsReport = query.Select(p => new DanhSachPhieuThu
            {
                ID = p.ID,
                TenThanhVien = p.ThanhVien.TenThanhVien,
                NgayThu = p.NgayThu,
                LoaiThu = p.LoaiThu,
                SoTienThu = p.SoTienThu,
                TenNhanVien = p.NhanVien.TenNhanVien,
                LyDoThu = p.LyDoThu
            }).OrderByDescending(x => x.NgayThu).ToList();

            dataTable.Clear();
            foreach (var row in dsReport)
            {
                dataTable.AddThongKeDoanhThuRow(row.ID, row.SoTienThu, row.NgayThu, row.LoaiThu, row.TenThanhVien, row.TenNhanVien, row.LyDoThu);
            }

            ReportDataSource rds = new ReportDataSource("ThongKeDoanhThu", (DataTable)dataTable);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.ReportPath = Path.Combine(reportsFolder, "rptThongKeDoanhThu.rdlc");

            string thongTinLoc = $"({moTaLoaiThu} - Từ {dtpTuNgay.Text} đến {dtpDenNgay.Text})";
            ReportParameter rp = new ReportParameter("MoTaKetQuaHienThi", thongTinLoc);
            reportViewer1.LocalReport.SetParameters(rp);

            reportViewer1.RefreshReport();
        }

        private void btnHienTatCa_Click(object sender, EventArgs e)
        {
            frmThongKeDoanhThu_Load(sender, e);
        }

        private void LayLoaiThuVaoComboBox()
        {
            var ds = new[] {
        new { ID = -1, Ten = "Tất cả loại thu" },
        new { ID = 0, Ten = "Thu tiền phạt" },
        new { ID = 1, Ten = "Lệ phí thẻ" },
        new { ID = 2, Ten = "Bồi thường hỏng sách" },
        new { ID = 3, Ten = "Bồi thường mất sách" }
    }.ToList();

            cboLoaiThu.DataSource = ds;
            cboLoaiThu.DisplayMember = "Ten";
            cboLoaiThu.ValueMember = "ID";
        }
    }
}
