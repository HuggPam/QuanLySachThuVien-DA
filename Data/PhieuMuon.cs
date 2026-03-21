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
        public int ID { get; set; }
        public DateTime NgayMuon { get; set; }
        public int ThanhVienID { get; set; }
        public virtual ThanhVien ThanhVen { get; set; } = null!;
        public int NhanVienID { get; set; }
        public virtual NhanVien NhanVien { get; set; } = null!;

        public virtual ObservableCollectionListSource<ChiTietPhieuMuon> ChiTietPhieuMuon { get; set; } = new();
    }
}
