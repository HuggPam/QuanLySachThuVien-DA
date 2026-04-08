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
            this.Padding = new Padding(0, 60, 0, 0);
            reportViewer1.Dock = DockStyle.Fill;
            this.Controls.Add(reportViewer1);
        }

        private void frmThongKeDoanhThu_Load(object sender, EventArgs e)
        {
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
    }
}
