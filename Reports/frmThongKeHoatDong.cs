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
            this.Padding = new Padding(0, 60, 0, 0);
            reportViewer1.Dock = DockStyle.Fill;
            this.Controls.Add(reportViewer1); 
        }

        private void frmThongKeHoatDong_Load(object sender, EventArgs e)
        {
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
    }
}
