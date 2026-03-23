using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.Data
{
    public class GoiThanhVien
    {
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string TenGoi { get; set; } = null!;

        public int SoThangHieuLuc { get; set; }
        public int SoLanGiaHanToiDa { get; set; }   
        public int SoNgayMuonToiDa { get; set; }
        public int SoSachDuocMuon { get; set; }
        public decimal GiaTien { get; set; }

        public virtual ObservableCollectionListSource<ThanhVien> ThanhVien { get; set; } = new();
    }
}
