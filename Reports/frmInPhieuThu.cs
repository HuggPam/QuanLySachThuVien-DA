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
    public partial class frmInPhieuThu : Form
    {
        QLTVContext context = new QLTVContext();
        int _maPhieu;
        string reportsFolder = Application.StartupPath.Replace("bin\\Debug\\net8.0-windows", "Reports");
        public frmInPhieuThu(int maPhieu)
        {
            InitializeComponent();
            _maPhieu = maPhieu;
            reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            reportViewer1.Dock = DockStyle.Fill;
            this.Controls.Add(reportViewer1);
        }

        private void frmInPhieuThu_Load(object sender, EventArgs e)
        {
            var phieu = context.PhieuThu
                .Include(p => p.ThanhVien)
                .Include(p => p.NhanVien)
                .FirstOrDefault(p => p.ID == _maPhieu);

            if (phieu != null)
            {

                QLTVDataSet.ThongKeDoanhThuDataTable dataTable = new QLTVDataSet.ThongKeDoanhThuDataTable();
                dataTable.AddThongKeDoanhThuRow(
                    phieu.ID,
                    phieu.SoTienThu,
                    phieu.NgayThu,
                    phieu.LoaiThu, 
                    phieu.ThanhVien.TenThanhVien,
                    phieu.NhanVien.TenNhanVien,
                    phieu.LyDoThu
                );

                ReportDataSource rds = new ReportDataSource("InPhieuThu", (DataTable)dataTable);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.LocalReport.ReportPath = Path.Combine(reportsFolder, "rptInPhieuThu.rdlc");

                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;
                reportViewer1.RefreshReport();
            }
        }
    }
}
