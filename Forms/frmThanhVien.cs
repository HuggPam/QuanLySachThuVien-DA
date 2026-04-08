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
            context = new QLTVContext();
            TuDongGiamLoi();
            BatTatChucNang(false);
            cboTrangThai.Enabled = false;
            LayGoiThanhVienVaoComboBox();
            LayTenTrangThaiChoComboBox();

            dgvThanhVien.AutoGenerateColumns = false;
            List<DanhSachThanhVien> danhSachThanhVien = new List<DanhSachThanhVien>();
            danhSachThanhVien = context.ThanhVien.Select(t => new DanhSachThanhVien
            {
                ID = t.ID,
                TenThanhVien = t.TenThanhVien,
                NgaySinh = t.NgaySinh,
                DiaChi = t.DiaChi,
                DienThoai = t.DienThoai,
                NgayDangKy = t.NgayDangKy,
                NgayHetHan = t.NgayHetHan,
                GoiThanhVienID = t.GoiThanhVienID,
                TenGoi = t.GoiThanhVien.TenGoi,
                SoLanViPham = t.SoLanViPham,
                TrangThai = t.TrangThai,
            }).ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = danhSachThanhVien;
            txtTenThanhVien.DataBindings.Clear();
            txtTenThanhVien.DataBindings.Add("Text", bindingSource, "TenThanhVien", false, DataSourceUpdateMode.Never);
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", bindingSource, "DiaChi", false, DataSourceUpdateMode.Never);
            txtDienThoai.DataBindings.Clear();
            txtDienThoai.DataBindings.Add("Text", bindingSource, "DienThoai", false, DataSourceUpdateMode.Never);
            dtpNgaySinh.DataBindings.Clear();
            dtpNgaySinh.DataBindings.Add("Value", bindingSource, "NgaySinh", false, DataSourceUpdateMode.Never);
            cboGoiThanhVien.DataBindings.Clear();
            cboGoiThanhVien.DataBindings.Add("SelectedValue", bindingSource, "GoiThanhVienID", false, DataSourceUpdateMode.Never);
            dtpNgayDangKy.DataBindings.Clear();
            dtpNgayDangKy.DataBindings.Add("Value", bindingSource, "NgayDangKy", false, DataSourceUpdateMode.Never);
            dgvThanhVien.DataSource = bindingSource;
            dtpNgayHetHan.DataBindings.Clear();
            dtpNgayHetHan.DataBindings.Add("Value", bindingSource, "NgayHetHan", false, DataSourceUpdateMode.Never);
            numViPham.DataBindings.Clear();
            numViPham.DataBindings.Add("Value", bindingSource, "SoLanViPham", false, DataSourceUpdateMode.Never);
            cboTrangThai.DataBindings.Clear();
            cboTrangThai.DataBindings.Add("SelectedIndex", bindingSource, "TrangThai", false, DataSourceUpdateMode.Never);
            dgvThanhVien.DataSource = bindingSource;
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

        public void LayGoiThanhVienVaoComboBox()
        {
            cboGoiThanhVien.DataSource = context.GoiThanhVien.ToList();
            cboGoiThanhVien.DisplayMember = "TenGoi";
            cboGoiThanhVien.ValueMember = "ID";
        }

        public void LayTenTrangThaiChoComboBox()
        {
            var danhSachTrangThai = new[] {
                new { ID = 0, Name = "Hoạt động" },
                new { ID = 1, Name = "Bị khóa" },
                new { ID = 2, Name = "Hết hạn" },
                new { ID = 3, Name = "Ngưng sử dụng" }
};
            cboTrangThai.DataSource = danhSachTrangThai;
            cboTrangThai.DisplayMember = "Name";
            cboTrangThai.ValueMember = "ID";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            txtTenThanhVien.Clear();
            txtDienThoai.Clear();
            txtDiaChi.Clear();
            numViPham.Value = 0;
            cboTrangThai.SelectedIndex = 0;
            dtpNgaySinh.Value = DateTime.Now;
            cboGoiThanhVien.SelectedIndex = 0;
            dtpNgayDangKy.Value = DateTime.Now;
            txtTenThanhVien.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            BatTatChucNang(true);
            cboTrangThai.Enabled = true;
            id = Convert.ToInt32(dgvThanhVien.CurrentRow.Cells["colID"].Value.ToString());
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
                return;
            }
            else if (string.IsNullOrWhiteSpace(txtDienThoai.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDienThoai.Focus();
                return;
            }
            else if (dtpNgaySinh.Value.Date >= DateTime.Now.Date)
            {
                MessageBox.Show("Ngày sinh không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpNgaySinh.Focus();
                return;
            }
            else
            {
                int maGoiChon = Convert.ToInt32(cboGoiThanhVien.SelectedValue);
                var goiChon = context.GoiThanhVien.Find(maGoiChon);

                if (xuLyThem) //Thẻ mới
                {
                    ThanhVien tv = new ThanhVien();
                    tv.TenThanhVien = txtTenThanhVien.Text.Trim();
                    tv.DienThoai = txtDienThoai.Text.Trim();
                    tv.DiaChi = txtDiaChi.Text.Trim();
                    tv.NgaySinh = dtpNgaySinh.Value.Date;
                    tv.NgayDangKy = dtpNgayDangKy.Value.Date;

                    tv.GoiThanhVienID = maGoiChon;

                    // Tính ngày hết hạn dựa vào Gói
                    if (goiChon != null)
                    {
                        tv.NgayHetHan = tv.NgayDangKy.AddMonths(goiChon.SoThangHieuLuc);
                    }

                    context.ThanhVien.Add(tv);
                    context.SaveChanges();

                    // Tự động lập Phiếu thu khi đăng ký thẻ mới
                    if (goiChon != null && goiChon.GiaTien > 0)
                    {
                        PhieuThu pt = new PhieuThu();
                        pt.ThanhVienID = tv.ID;
                        pt.NhanVienID = Program.MaNhanVienDangNhap;
                        pt.SoTienThu = goiChon.GiaTien;
                        pt.NgayThu = DateTime.Now;
                        pt.LoaiThu = 1;
                        pt.LyDoThu = $"Thu phí đăng ký gói: {goiChon.TenGoi}";

                        context.PhieuThu.Add(pt);
                        context.SaveChanges();
                    }

                    MessageBox.Show("Đã thêm Thành viên và tự động xuất Phiếu thu thành công!", "Thông báo");
                }
                else //Sửa thông tin hoặc nâng cấp gói
                {
                    ThanhVien tv = context.ThanhVien.Find(id);
                    if (tv != null)
                    {
                        int maGoiCu = tv.GoiThanhVienID; // Lấy Gói cũ để so sánh

                        tv.TenThanhVien = txtTenThanhVien.Text.Trim();
                        tv.DienThoai = txtDienThoai.Text.Trim();
                        tv.DiaChi = txtDiaChi.Text.Trim();
                        tv.NgaySinh = dtpNgaySinh.Value.Date;
                        tv.NgayDangKy = dtpNgayDangKy.Value.Date;
                        tv.SoLanViPham = (int)numViPham.Value;
                        tv.TrangThai = cboTrangThai.SelectedIndex;

                        if (maGoiCu != maGoiChon && goiChon != null)
                        {
                            // Có thay đổi Gói -> Cập nhật Gói và tính lại Ngày Hết Hạn từ hôm nay
                            tv.GoiThanhVienID = maGoiChon;
                            tv.NgayHetHan = DateTime.Now.Date.AddMonths(goiChon.SoThangHieuLuc);

                            // Tự động lập Phiếu thu
                            if (goiChon.GiaTien > 0)
                            {
                                PhieuThu pt = new PhieuThu();
                                pt.ThanhVienID = tv.ID;
                                pt.NhanVienID = Program.MaNhanVienDangNhap;
                                pt.SoTienThu = goiChon.GiaTien;
                                pt.NgayThu = DateTime.Now;
                                pt.LoaiThu = 1;
                                pt.LyDoThu = $"Thu phí Nâng cấp lên gói: {goiChon.TenGoi}";

                                context.PhieuThu.Add(pt);
                            }
                        }
                        else
                        {
                            // Không đổi gói, chỉ sửa tên tuổi -> Lấy ngày hết hạn như cũ
                            tv.GoiThanhVienID = maGoiChon;
                            tv.NgayHetHan = dtpNgayHetHan.Value.Date;
                        }

                        context.ThanhVien.Update(tv);
                        context.SaveChanges();
                        MessageBox.Show("Đã cập nhật dữ liệu thành công!", "Thông báo");
                    }
                }
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

        private void dgvThanhVien_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridView dgv = sender as DataGridView;
            if (dgv.Columns[e.ColumnIndex].Name == "colTrangThai")
            {
                if (e.Value != null)
                {
                    int tt = (int)e.Value;
                    switch (tt)
                    {
                        case 0: e.Value = "Hoạt động"; break;
                        case 1: e.Value = "Bị khóa"; break;
                        case 2: e.Value = "Hết hạn"; break;
                        case 3: e.Value = "Ngưng sử dụng"; break;
                    }
                    e.FormattingApplied = true;
                }
            }

            int trangThai = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells["colTrangThai"].Value ?? 0);
            int viPham = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells["colSoLanViPham"].Value ?? 0);

            dgv.Rows[e.RowIndex].DefaultCellStyle.Font = new Font(dgv.Font, FontStyle.Regular);

            if (trangThai == 1)
            {
                dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Gainsboro;
                dgv.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;

                dgv.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.DarkGray;
                dgv.Rows[e.RowIndex].DefaultCellStyle.SelectionForeColor = Color.White;
            }
            else if (trangThai == 2)
            {
                dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Thistle;
                dgv.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;

                dgv.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.Plum;
                dgv.Rows[e.RowIndex].DefaultCellStyle.SelectionForeColor = Color.White;
            }
            else if (trangThai == 3)
            {
                dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.CadetBlue;
                dgv.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;

                dgv.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.Teal;
                dgv.Rows[e.RowIndex].DefaultCellStyle.SelectionForeColor = Color.White;
            }
            else
            {
                if (viPham == 3)
                {
                    dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                    dgv.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;

                    dgv.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.DarkRed;
                    dgv.Rows[e.RowIndex].DefaultCellStyle.SelectionForeColor = Color.White;
                }
                else if (viPham == 2)
                {
                    dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Orange;
                    dgv.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;

                    dgv.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.DarkOrange;
                    dgv.Rows[e.RowIndex].DefaultCellStyle.SelectionForeColor = Color.White;
                }
                else if (viPham == 1)
                {
                    dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
                    dgv.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;

                    dgv.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.Gold;
                    dgv.Rows[e.RowIndex].DefaultCellStyle.SelectionForeColor = Color.White;
                }
                else
                {
                    dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                    dgv.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
                }
            }
        }

        private void cboTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cboTrangThai.Focused) return;
            if (cboTrangThai.SelectedIndex == 0)
            {
                int soLoi = (int)numViPham.Value;
                if (soLoi >= 4)
                {
                    numViPham.Value = 3;
                    MessageBox.Show("Thành viên đã được mở khóa!", "Thông báo");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa " + txtTenThanhVien.Text + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dgvThanhVien.CurrentRow.Cells["colID"].Value.ToString());
                ThanhVien tv = context.ThanhVien.Find(id);
                if (tv != null)
                {
                    context.ThanhVien.Remove(tv);
                }
                context.SaveChanges();
                frmThanhVien_Load(sender, e);
            }
        }

        private void numViPham_ValueChanged(object sender, EventArgs e)
        {
            if (!numViPham.Focused) return;
            if (numViPham.Value > 3)
            {
                if (cboTrangThai.SelectedIndex != 1)
                {
                    cboTrangThai.SelectedIndex = 1; // 1 là ID của "Bị khóa"
                }
            }
        }
        private void TuDongGiamLoi()
        {
            using (var db = new QLTVContext())
            {
                var dsThanhVien = db.ThanhVien.Where(t => t.SoLanViPham > 0 && t.TrangThai == 0).ToList();

                foreach (var tv in dsThanhVien)
                {
                    if (tv.NgayViPham != null)
                    {
                        int soNgayTuanThu = (DateTime.Now - tv.NgayViPham.Value).Days;
                        if (soNgayTuanThu >= 90) // 3 tháng tuân thủ
                        {
                            tv.SoLanViPham -= 1;
                            tv.NgayViPham = (tv.SoLanViPham > 0) ? DateTime.Now : null;
                        }
                    }
                }
                db.SaveChanges();
            }
        }
    }
}
