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
using BC = BCrypt.Net.BCrypt;

namespace QuanLyThuVien.Forms
{
    public partial class frmDoiMatKhau : Form
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMatKhauCu.Text) ||
                string.IsNullOrWhiteSpace(txtMatKhauMoi.Text) ||
                string.IsNullOrWhiteSpace(txtXacNhan.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtMatKhauMoi.Text != txtXacNhan.Text)
            {
                MessageBox.Show("Mật khẩu mới và xác nhận mật khẩu không khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtXacNhan.Focus();
                txtXacNhan.SelectAll();
                return;
            }

            using (var context = new QLTVContext())
            {
                int maNV = Program.MaNhanVienDangNhap;
                var nv = context.NhanVien.Find(maNV);

                if (nv != null)
                {
                    bool matKhauCuDung = false;

                    if (nv.MatKhau != null && nv.MatKhau.StartsWith("$2"))
                    {
                        matKhauCuDung = BC.Verify(txtMatKhauCu.Text, nv.MatKhau);
                    }
                    else
                    {
                        matKhauCuDung = (txtMatKhauCu.Text == nv.MatKhau);
                    }

                    if (!matKhauCuDung)
                    {
                        MessageBox.Show("Mật khẩu hiện tại không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMatKhauCu.Focus();
                        txtMatKhauCu.SelectAll();
                        return;
                    }

                    nv.MatKhau = BC.HashPassword(txtMatKhauMoi.Text);

                    context.NhanVien.Update(nv);
                    MessageBox.Show("Đổi mật khẩu thành công! Hệ thống sẽ tự động đăng xuất, vui lòng đăng nhập lại.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    context.SaveChanges();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Lỗi hệ thống: Không tìm thấy tài khoản của bạn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {

        }
    }
}
