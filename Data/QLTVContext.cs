using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace QuanLyThuVien.Data
{
    public class QLTVContext : DbContext
    {
        public DbSet<TheLoai> TheLoai { get; set; }
        public DbSet<Sach> Sach { get; set; }
        public DbSet<GoiThanhVien> GoiThanhVien { get; set; }
        public DbSet<ThanhVien> ThanhVien { get; set; }
        public DbSet<NhanVien> NhanVien { get; set; }
        public DbSet<TacGia> TacGia { get; set; }
        public DbSet<NhaXuatBan> NhaXuatBan { get; set; }
        public DbSet<PhieuMuon> PhieuMuon { get; set; }
        public DbSet<ChiTietPhieuMuon> ChiTietPhieuMuon { get; set; }
        public DbSet<PhieuThu> PhieuThu { get; set; }
        public DbSet<NhatKyHoatDong> NhatKyHoatDong { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["QLTVConnection"].ConnectionString;
                optionsBuilder.UseSqlServer(connectionString);
            }
        }
    }
}
