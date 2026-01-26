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
        [Key]
        public int ID { get; set; }

        public int PhieuMuonID { get; set; }

        [ForeignKey("PhieuMuonID")]
        public virtual PhieuMuon PhieuMuon { get; set; }

        // --- KHÓA NGOẠI  ---
        [StringLength(20)]
        public string MaSach { get; set; }

        [ForeignKey("MaSach")]
        public virtual Sach Sach { get; set; }

        public DateTime? NgayTra { get; set; }
        public string GhiChu { get; set; }
    }
}
