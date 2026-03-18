using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.Data
{
    public class NhanVien
    {
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string HoTen { get; set; }

        [StringLength(15)]
        public string SoDienThoai { get; set; }

        [Required]
        public string MatKhau { get; set; }

        public bool Quyen { get; set; }

        public virtual ObservableCollectionListSource<PhieuMuon> PhieuMuon { get; set; } = new();
        public virtual ObservableCollectionListSource<PhieuThu> PhieuThu { get; set; } = new();
    }
}
