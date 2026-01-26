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
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [StringLength(20)]
        public string MaThanhVien { get; set; }

        [Required]
        [StringLength(100)]
        public string TenThanhVien { get; set; }

        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }

        public virtual ObservableCollectionListSource<PhieuMuon> PhieuMuon { get; set; } = new();
    }
}
