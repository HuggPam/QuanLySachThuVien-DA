using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien.Forms
{
    public partial class TinhTrangTraSach : Form
    {
        public int TinhTrangDuocChon;
        public string TenSachHienTai;
        public TinhTrangTraSach()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void TinhTrangTraSach_Load(object sender, EventArgs e)
        {
            lblTenSach.Text = " " + TenSachHienTai;
            lblTenSach.ForeColor = Color.Blue;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            // Gán giá trị dựa theo lựa chọn
            if (radBinhThuong.Checked) TinhTrangDuocChon = 1;
            else if (radMatSach.Checked) TinhTrangDuocChon = 2;
            else if (radHuHong.Checked) TinhTrangDuocChon = 3;

            this.DialogResult = DialogResult.OK;
            this.Close();   
        }
    }
}
