using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.Data
{
    public class TacGia
    {
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string TenTacGia { get; set; } = null!;

        public string GhiChu { get; set; }

        public virtual ObservableCollectionListSource<Sach> Sach { get; set; } = new();
    }
}
