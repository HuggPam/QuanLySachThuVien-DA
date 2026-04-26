using Microsoft.EntityFrameworkCore;
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
    public partial class frmInPhieuMuon : Form
    {
        QLTVContext context = new QLTVContext();
        QLTVDataSet.InPhieuMuonDataTable dataTable = new QLTVDataSet.InPhieuMuonDataTable();
        string reportsFolder = Application.StartupPath.Replace("bin\\Debug\\net8.0-windows", "Reports");
        int _maPhieu;
        public frmInPhieuMuon(int maPhieu)
        {
            InitializeComponent();
            _maPhieu = maPhieu;
            reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            reportViewer1.Dock = DockStyle.Fill;
            this.Controls.Add(reportViewer1);
        }

        private void frmInPhieuMuon_Load(object sender, EventArgs e)
        {
            var phieu = context.PhieuMuon
                .Include(p => p.ThanhVien)
                .ThenInclude(tv => tv.GoiThanhVien)
                .Include(p => p.NhanVien)
                .FirstOrDefault(p => p.ID == _maPhieu);

            if (phieu != null)
            {
                var chiTiet = context.ChiTietPhieuMuon
                    .Where(ct => ct.PhieuMuonID == _maPhieu)
                    .Select(ct => new
                    {
                        ID = ct.ID,
                        TenSach = ct.Sach.TenSach,
                        HanTra = ct.HanTra,
                        NgayTra = ct.NgayTra,
                        DonGia = ct.Sach.DonGia,
                        GhiChu = ct.GhiChu,
                        TrangThaiTra = ct.TrangThaiTra 
                    }).ToList();

                dataTable.Clear();

                foreach (var item in chiTiet)
                {
                    string chuoiTrangThai = "";
                    if (item.TrangThaiTra == 1) chuoiTrangThai = "Đã trả";
                    else if (item.TrangThaiTra == 2) chuoiTrangThai = "Mất sách";
                    else if (item.TrangThaiTra == 3) chuoiTrangThai = "Hỏng sách";
                    else 
                    {
                        if (item.NgayTra == null && item.HanTra < DateTime.Now)
                            chuoiTrangThai = "Trễ hạn";
                        else
                            chuoiTrangThai = "Đang mượn";
                    }

                    dataTable.AddInPhieuMuonRow(
                        item.ID,
                        _maPhieu,
                        item.TenSach,
                        item.HanTra,
                        item.DonGia,
                        item.GhiChu ?? "",
                        item.NgayTra ?? DateTime.MinValue,
                        0, 
                        chuoiTrangThai,
                        0 
                    );
                }

                ReportDataSource rds = new ReportDataSource("InPhieuMuon", (DataTable)dataTable);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.LocalReport.ReportPath = Path.Combine(reportsFolder, "rptInPhieuMuon.rdlc");


                List<ReportParameter> param = new List<ReportParameter>
                {
                    new ReportParameter("NgayLap", $"Ngày {phieu.NgayMuon.ToString("dd")} Tháng {phieu.NgayMuon.ToString("MM")} Năm {phieu.NgayMuon.Year}"),
                    new ReportParameter("TenThanhVien", phieu.ThanhVien.TenThanhVien),
                    new ReportParameter("GoiThanhVien", phieu.ThanhVien.GoiThanhVien?.TenGoi ?? ""),
                    new ReportParameter("DiaChi", phieu.ThanhVien.DiaChi ?? ""),
                    new ReportParameter("SoDienThoai", phieu.ThanhVien.DienThoai ?? ""),
                };

                reportViewer1.LocalReport.SetParameters(param);
                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;
                string checkPath = Path.Combine(reportsFolder, "rptInPhieuMuon.rdlc");
                reportViewer1.RefreshReport();
            }
        }
    }
}
