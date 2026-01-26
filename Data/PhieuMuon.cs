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
    public class PhieuMuon
    {
        [Key]
        public int ID { get; set; }

        public DateTime NgayMuon { get; set; }

        // --- KHÓA NGOẠI  ---
        [StringLength(20)]
        public string MaThanhVien { get; set; } = null!;

        [ForeignKey("MaThanhVien")]
        public virtual ThanhVien ThanhVen { get; set; } = null!;

        public virtual ObservableCollectionListSource<ChiTietPhieuMuon> ChiTietPhieuMuon { get; set; } = new();
    }
}
