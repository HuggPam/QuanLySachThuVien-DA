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
                public int ID { get; set; }

                [Required]
                [StringLength(200)]
                public string TenSach { get; set; }
                public int NamXuatBan { get; set; }
                public int SoLuong { get; set; }
                public decimal DonGia { get; set; }
                public string? HinhAnh { get; set; }
                
                public int TheLoaiID { get; set; }
                public virtual TheLoai TheLoai { get; set; } = null!;

                public int TacGiaID { get; set; }
                public virtual TacGia TacGia { get; set; } = null!;
        
                public int NhaXuatBanID { get; set; }
                public virtual NhaXuatBan NhaXuatBan { get; set; } = null!;

                public virtual ObservableCollectionListSource<ChiTietPhieuMuon> ChiTietPhieuMuon { get; set; } = new();
            }

            [NotMapped]
            public class DanhSachSach
            {
                public int ID { get; set; }
                public string TenSach { get; set; }
                public int NamXuatBan { get; set; }
                public int SoLuong { get; set; }
                public decimal DonGia { get; set; }
                public string? HinhAnh { get; set; }

                public int TheLoaiID { get; set; }
                public int TacGiaID { get; set; }
                public int NhaXuatBanID { get; set; }

                public string TenTheLoai { get; set; }
                public string TenTacGia { get; set; }
                public string TenNhaXuatBan { get; set; }
            }
    }
