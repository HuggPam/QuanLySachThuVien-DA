using DocumentFormat.OpenXml.InkML;
using Microsoft.EntityFrameworkCore;
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

namespace QuanLyThuVien.Forms
{
    public partial class frmLichSuHoatDong : Form
    {
        QLTVContext context = new QLTVContext();
        public frmLichSuHoatDong()
        {
            InitializeComponent();
        }

        private void frmLichSuHoatDong_Load(object sender, EventArgs e)
        {
            dgvLichSu.AutoGenerateColumns = false;

            using (var db = new QLTVContext())
            {
                var dsLichSu = db.NhatKyHoatDong
                                 .Include(n => n.NhanVien)
                                 .OrderByDescending(n => n.ThoiGian)
                                 .Select(n => new
                                 {
                                     ID = n.ID,
                                     TenNhanVien = n.NhanVien != null ? n.NhanVien.TenNhanVien : "Hệ thống",
                                     TieuDe = n.TieuDe,
                                     NoiDung = n.NoiDung,
                                     ThoiGian = n.ThoiGian.ToString("dd/MM/yyyy HH:mm")
                                 }).ToList();

                dgvLichSu.DataSource = dsLichSu;
            }
        }

        private void btnLocKetQua_Click(object sender, EventArgs e)
        {
            DateTime tuNgay = dtpTuNgay.Value.Date;
            DateTime denNgay = dtpDenNgay.Value.Date.AddDays(1).AddTicks(-1);

            var query = context.NhatKyHoatDong.AsQueryable();

            query = query.Where(n => n.ThoiGian >= tuNgay && n.ThoiGian <= denNgay);

            var dsLichSu = query.Select(n => new
            {
                ID = n.ID,
                TenNhanVien = n.NhanVien != null ? n.NhanVien.TenNhanVien : "Hệ thống",
                TieuDe = n.TieuDe,
                NoiDung = n.NoiDung,
                ThoiGian = n.ThoiGian
            })
            .OrderByDescending(x => x.ThoiGian)
            .ToList();
            dgvLichSu.DataSource = dsLichSu.Select(x => new
            {
                x.ID,
                x.TenNhanVien,
                x.TieuDe,
                x.NoiDung,
                ThoiGian = x.ThoiGian.ToString("dd/MM/yyyy HH:mm")
            }).ToList();

            if (dsLichSu.Count == 0)
            {
                MessageBox.Show($"Không có hoạt động nào từ {dtpTuNgay.Text} đến {dtpDenNgay.Text}", "Thông báo");
            }
        }

        private void btnHienTatCa_Click(object sender, EventArgs e)
        {
            frmLichSuHoatDong_Load(sender, e);
        }
    }
}
