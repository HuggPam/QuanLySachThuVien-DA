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
    public class Sach
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [StringLength(20)]
        public string MaSach { get; set; }

        [Required]
        [StringLength(200)]
        public string TenSach { get; set; }

        public string TacGia { get; set; }
        public int NamXuatBan { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }

        // --- KHÓA NGOẠI ---
        [StringLength(20)]
        public string MaTheLoai { get; set; } = null!;

        [ForeignKey("MaTheLoai")]
        public virtual TheLoai TheLoai { get; set; } = null!;

        public virtual ObservableCollectionListSource<ChiTietPhieuMuon> ChiTietPhieuMuon { get; set; } = new();
    }
}
