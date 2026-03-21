using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace QuanLyThuVien.Data
{
    public class ThanhVien
    {
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string TenThanhVien { get; set; }

        public DateTime NgaySinh { get; set; }
        public string? DiaChi { get; set; }
        public string? DienThoai { get; set; }

        public DateTime NgayDangKy { get; set; }
        public DateTime NgayHetHan { get; set; }

        public int GoiThanhVienID { get; set; }
        public virtual GoiThanhVien GoiThanhVien { get; set; } = null!;

        public virtual ObservableCollectionListSource<PhieuMuon> PhieuMuon { get; set; } = new();
        public virtual ObservableCollectionListSource<PhieuThu> PhieuThu { get; set; } = new();
    }
}
