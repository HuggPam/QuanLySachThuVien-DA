using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.Data
{
    public class PhieuThu
    {
        public int ID { get; set; }
        public decimal SoTienThu { get; set; }
        public DateTime NgayThu { get; set; }
        public int LoaiThu { get; set; }
        public int ThanhVienID { get; set; }    
        public virtual ThanhVien ThanhVien { get; set; } = null!;
        public int NhanVienID { get; set; }
        public virtual NhanVien NhanVien { get; set; } = null!;

        [Required]
        [StringLength(255)]
        public string LyDoThu { get; set; } = null!;
    }
}
