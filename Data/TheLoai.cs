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
    public class TheLoai
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [StringLength(20)]
        public string MaTheLoai { get; set; }

        [Required]
        [StringLength(100)]
        public string TenTheLoai { get; set; }

        public virtual ObservableCollectionListSource<Sach> Sach { get; set; } = new();
    }
}
