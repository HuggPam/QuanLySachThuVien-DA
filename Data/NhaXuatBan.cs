using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.Data
{
    public class NhaXuatBan
    {
        public int ID { get; set; }

        [Required]
        [StringLength(255)]
        public string TenNhaXuatBan { get; set; } = null!;
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public virtual ObservableCollectionListSource<Sach> Sach { get; set; } = new();
    }
}
