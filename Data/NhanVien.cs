using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.Data
{
    [Index(nameof(TenDangNhap), IsUnique = true)]
    public class NhanVien
    {
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string TenNhanVien { get; set; }

        [StringLength(15)]
        public string? DienThoai { get; set; }
        public string? DiaChi { get; set; }

        [Required]
        public string TenDangNhap { get; set; }

        [Required]
        public string MatKhau { get; set; }

        public bool QuyenHan { get; set; }

        public virtual ObservableCollectionListSource<PhieuMuon> PhieuMuon { get; set; } = new();
        public virtual ObservableCollectionListSource<PhieuThu> PhieuThu { get; set; } = new();
    }
}
