using Microsoft.EntityFrameworkCore;
using QuanLyThuVien.Data;
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
    public partial class frmThanhVien : Form
    {
        QLTVContext context = new QLTVContext();
        bool xuLyThem = false;
        int id;
        public frmThanhVien()
        {
            InitializeComponent();
        }

        private void frmThanhVien_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            dgvThanhVien.AutoGenerateColumns = false;
            List<ThanhVien> danhSachThanhVien = new List<ThanhVien>();
            danhSachThanhVien = context.ThanhVien.ToList();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = danhSachThanhVien;
            txtTenThanhVien.DataBindings.Clear();
            txtTenThanhVien.DataBindings.Add("Text", bindingSource, "TenThanhVien", false, DataSourceUpdateMode.Never);
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", bindingSource, "DiaChi", false, DataSourceUpdateMode.Never);
            txtDienThoai.DataBindings.Clear();
            txtDienThoai.DataBindings.Add("Text", bindingSource, "DiaChi", false, DataSourceUpdateMode.Never);
            dtpNgaySinh.DataBindings.Clear();
            dtpNgaySinh.DataBindings.Add("Value", bindingSource, "NgaySinh", false, DataSourceUpdateMode.Never);
            cboGoiThanhVien.DataBindings.Clear();
            cboGoiThanhVien.DataBindings.Add("SelectedValue", bindingSource, "GoiThanhVienID", false, DataSourceUpdateMode.Never);
            dtpNgayDangKy.DataBindings.Clear();
            dtpNgayDangKy.DataBindings.Add("Value", bindingSource, "NgayDangKy", false, DataSourceUpdateMode.Never);
            dgvThanhVien.DataSource = bindingSource;
            dtpNgayHetHan.DataBindings.Clear();
            dtpNgayHetHan.DataBindings.Add("Value", bindingSource, "NgayHetHan", false, DataSourceUpdateMode.Never);
        }
        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuy.Enabled = giaTri;
            txtTenThanhVien.Enabled = giaTri;
            dtpNgaySinh.Enabled = giaTri;
            txtDienThoai.Enabled = giaTri;
            txtDiaChi.Enabled = giaTri;
            cboGoiThanhVien.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnTimKiem.Enabled = !giaTri;
            btnNhap.Enabled = !giaTri;
            btnXuat.Enabled = !giaTri;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            txtTenThanhVien.Clear();
            txtDienThoai.Clear();
            txtDiaChi.Clear();
            dtpNgaySinh.Value = DateTime.Now;
            cboGoiThanhVien.SelectedIndex = 0;
            dtpNgayDangKy.Value = DateTime.Now;
            txtTenThanhVien.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dgvThanhVien.CurrentRow.Cells["ID"].Value.ToString());
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenThanhVien.Text))
            {
                MessageBox.Show("Vui lòng nhập họ và tên thành viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenThanhVien.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtDienThoai.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDienThoai.Focus();
            }
            else if (dtpNgaySinh.Value.Date >= DateTime.Now.Date)
            {
                MessageBox.Show("Ngày sinh không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpNgaySinh.Focus();
            }
            else
            {
                if (xuLyThem)
                {
                    ThanhVien tv = new ThanhVien();
                    tv.TenThanhVien = txtTenThanhVien.Text.Trim();
                    tv.DienThoai = txtDienThoai.Text.Trim();
                    tv.DiaChi = txtDiaChi.Text.Trim();
                    tv.NgaySinh = dtpNgaySinh.Value.Date;

                    tv.NgayDangKy = dtpNgayDangKy.Value.Date;
                    tv.NgayHetHan = dtpNgayHetHan.Value.Date;

                    tv.GoiThanhVienID = Convert.ToInt32(cboGoiThanhVien.SelectedValue);

                    context.ThanhVien.Add(tv);
                }
                else
                {
                    ThanhVien tv = context.ThanhVien.Find(id);
                    if (tv != null)
                    {
                        tv.TenThanhVien = txtTenThanhVien.Text.Trim();
                        tv.DienThoai = txtDienThoai.Text.Trim();
                        tv.DiaChi = txtDiaChi.Text.Trim();
                        tv.NgaySinh = dtpNgaySinh.Value.Date;

                        tv.NgayDangKy = dtpNgayDangKy.Value.Date;
                        tv.NgayHetHan = dtpNgayHetHan.Value.Date;
                        tv.GoiThanhVienID = Convert.ToInt32(cboGoiThanhVien.SelectedValue);

                        context.ThanhVien.Update(tv);

                    }
                }
                context.SaveChanges();
                MessageBox.Show("Lưu dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmThanhVien_Load(sender, e);
            }

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmThanhVien_Load(sender, e);

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn thoát chương trình không?", "Thông báo",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }
    }
}
