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
        public string GhiChu { get; set; }
    }
}
