using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.Data
{
    public class ChiTietPhieuMuon
    {
        public int ID { get; set; }
        public int PhieuMuonID { get; set; }
        public virtual PhieuMuon PhieuMuon { get; set; } = null!;

        public int SachID { get; set; }
        public virtual Sach Sach { get; set; } = null!;

        public DateTime? NgayTra { get; set; }
        public DateTime HanTra { get; set; }
        public int SoLanGiaHan { get; set; } = 0;
        public string? GhiChu { get; set; }
    }
    [NotMapped]
    public class DanhSachChiTietPhieuMuon
    {
        public int ID { get; set; }
        public int PhieuMuonID { get; set; }
        public int SachID { get; set; }
        public string TenSach { get; set; } = null!;
        public DateTime? NgayTra { get; set; }
        public DateTime HanTra { get; set; }
        public int SoLanGiaHan { get; set; }
        public string? GhiChu { get; set; }
    }
}
