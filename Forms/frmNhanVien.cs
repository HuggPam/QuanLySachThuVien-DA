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
    public partial class frmNhanVien : Form
    {
        QLTVContext context = new QLTVContext();
        bool xuLyThem = false;
        int id;
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuy.Enabled = giaTri;
            txtTenNhanVien.Enabled = giaTri;
            txtDienThoai.Enabled = giaTri;
            txtDiaChi.Enabled = giaTri;
            txtTenDangNhap.Enabled = giaTri;
            txtMatKhau.Enabled = giaTri;
            cboQuyenHan.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnTimKiem.Enabled = !giaTri;
        }

        private void LayQuyenHanVaoComboBox()
        {
            var dsQuyenHan = new[] {
                new { Ten = "Quản lý", GiaTri = true },
                new { Ten = "Thủ thư", GiaTri = false }
            }.ToList();

            cboQuyenHan.DataSource = dsQuyenHan;
            cboQuyenHan.DisplayMember = "Ten";
            cboQuyenHan.ValueMember = "GiaTri";
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            LayQuyenHanVaoComboBox();
            dgvNhanVien.AutoGenerateColumns = false;
            List<NhanVien> danhSachNhanVien = new List<NhanVien>();
            danhSachNhanVien = context.NhanVien.ToList();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = danhSachNhanVien;
            txtTenNhanVien.DataBindings.Clear();
            txtTenNhanVien.DataBindings.Add("Text", bindingSource, "TenNhanVien", false, DataSourceUpdateMode.Never);
            txtDienThoai.DataBindings.Clear();
            txtDienThoai.DataBindings.Add("Text", bindingSource, "DienThoai", false, DataSourceUpdateMode.Never);
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", bindingSource, "DiaChi", false, DataSourceUpdateMode.Never);
            txtTenDangNhap.DataBindings.Clear();
            txtTenDangNhap.DataBindings.Add("Text", bindingSource, "TenDangNhap", false, DataSourceUpdateMode.Never);
            cboQuyenHan.DataBindings.Clear();
            cboQuyenHan.DataBindings.Add("SelectedIndex", bindingSource, "QuyenHan", false, DataSourceUpdateMode.Never);
            dgvNhanVien.DataSource = bindingSource;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            txtTenNhanVien.Clear();
            txtDienThoai.Clear();
            txtDiaChi.Clear();
            txtTenDangNhap.Clear();
            txtMatKhau.Clear();
            cboQuyenHan.SelectedIndex = 1;
            txtTenNhanVien.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenNhanVien.Text))
            {
                MessageBox.Show("Vui lòng nhập họ và tên nhân viên?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenNhanVien.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenDangNhap.Focus();
                return;
            }

            string tenDN = txtTenDangNhap.Text.Trim();
            bool trungTen = xuLyThem
                ? context.NhanVien.Any(nv => nv.TenDangNhap == tenDN)
                : context.NhanVien.Any(nv => nv.TenDangNhap == tenDN && nv.ID != id);
            if (trungTen)
            {
                MessageBox.Show("Tên đăng nhập này đã tồn tại, vui lòng chọn tên khác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenDangNhap.Focus();
                return;
            }
            else
            {
                if (xuLyThem)
                {
                    if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
                        MessageBox.Show("Vui lòng nhập mật khẩu?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        NhanVien nv = new NhanVien();
                        nv.TenNhanVien = txtTenNhanVien.Text.Trim();
                        nv.DienThoai = txtDienThoai.Text.Trim();
                        nv.DiaChi = txtDiaChi.Text.Trim();
                        nv.TenDangNhap = tenDN;
                        nv.MatKhau = BC.HashPassword(txtMatKhau.Text);
                        nv.QuyenHan = cboQuyenHan.SelectedIndex == 0 ? true : false;
                        context.NhanVien.Add(nv);
                        context.SaveChanges();
                        MessageBox.Show("Đã thêm dữ liệu thành công!", "Thông báo");
                    }
                }
                else
                {
                    NhanVien nv = context.NhanVien.Find(id);
                    if (nv != null)
                    {
                        nv.TenNhanVien = txtTenNhanVien.Text;
                        nv.DienThoai = txtDienThoai.Text;
                        nv.DiaChi = txtDiaChi.Text;
                        nv.TenDangNhap = txtTenDangNhap.Text;
                        nv.QuyenHan = cboQuyenHan.SelectedIndex == 0 ? true : false;
                        context.NhanVien.Update(nv);
                        if (string.IsNullOrEmpty(txtMatKhau.Text))
                            context.Entry(nv).Property(x => x.MatKhau).IsModified = false;
                        else
                            nv.MatKhau = BC.HashPassword(txtMatKhau.Text);
                        context.SaveChanges();
                        MessageBox.Show("Đã cập nhật dữ liệu thành công!", "Thông báo");
                    }
                }
                frmNhanVien_Load(sender, e);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dgvNhanVien.CurrentRow.Cells["colID"].Value.ToString());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa " + txtTenNhanVien.Text + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dgvNhanVien.CurrentRow.Cells["colID"].Value.ToString());
                NhanVien nv = context.NhanVien.Find(id);
                if (nv != null)
                {
                    context.NhanVien.Remove(nv);
                }
                context.SaveChanges();
                frmNhanVien_Load(sender, e);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmNhanVien_Load(sender, e);
        }


        private void dgvNhanVien_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv.Columns[e.ColumnIndex].Name == "colQuyenHan" && e.Value != null)
            {
                if (e.Value is bool)
                {
                    bool laAdmin = (bool)e.Value;

                    if (laAdmin == true)
                    {
                        e.Value = "Admin";
                    }
                    else
                    {
                        e.Value = "Thủ thư";
                    }
                    e.FormattingApplied = true;
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim().ToLower();

            using (var db = new QLTVContext())
            {
                var query = db.NhanVien.AsQueryable();
                if (!string.IsNullOrEmpty(tuKhoa))
                {
                    query = query.Where(nv => nv.TenNhanVien.ToLower().Contains(tuKhoa));
                }

                var ketQuaTimKiem = query.ToList();
                BindingSource bsTimKiem = new BindingSource();
                bsTimKiem.DataSource = ketQuaTimKiem;
                txtTenNhanVien.DataBindings.Clear();
                txtTenNhanVien.DataBindings.Add("Text", bsTimKiem, "TenNhanVien", false, DataSourceUpdateMode.Never);
                txtDienThoai.DataBindings.Clear();
                txtDienThoai.DataBindings.Add("Text", bsTimKiem, "DienThoai", false, DataSourceUpdateMode.Never);
                txtDiaChi.DataBindings.Clear();
                txtDiaChi.DataBindings.Add("Text", bsTimKiem, "DiaChi", false, DataSourceUpdateMode.Never);
                txtTenDangNhap.DataBindings.Clear();
                txtTenDangNhap.DataBindings.Add("Text", bsTimKiem, "TenDangNhap", false, DataSourceUpdateMode.Never);
                cboQuyenHan.DataBindings.Clear();
                cboQuyenHan.DataBindings.Add("SelectedIndex", bsTimKiem, "QuyenHan", false, DataSourceUpdateMode.Never);
                dgvNhanVien.DataSource = bsTimKiem;

                if (ketQuaTimKiem.Count == 0 && !string.IsNullOrEmpty(tuKhoa))
                {
                    MessageBox.Show("Không tìm thấy nhân viên nào khớp với tên này!", "Kết quả tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
