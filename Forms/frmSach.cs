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
    public partial class frmSach : Form
    {
        QLTVContext context = new QLTVContext();
        bool xuLyThem = false;
        int id;
        string imagesFolder = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\..\Images"));
        public frmSach()
        {
            InitializeComponent();
        }

        private void frmSach_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);

            numNamXuatBan.Maximum = DateTime.Now.Year;
            numNamXuatBan.Minimum = 1000;

            LayTheLoaiVaoComboBox();
            LayTacGiaVaoComboBox();
            LayNhaXuatBanVaoComboBox();
            dgvSach.AutoGenerateColumns = false;
            List<DanhSachSach> danhSachSach = new List<DanhSachSach>();
            danhSachSach = context.Sach.Select(s => new DanhSachSach

            {
                ID = s.ID,
                TenSach = s.TenSach,
                NamXuatBan = s.NamXuatBan,
                SoLuong = s.SoLuong,
                DonGia = s.DonGia,
                HinhAnh = s.HinhAnh,
                TheLoaiID = s.TheLoaiID,
                TenTheLoai = s.TheLoai.TenTheLoai,
                TacGiaID = s.TacGiaID,
                TenTacGia = s.TacGia.TenTacGia,
                NhaXuatBanID = s.NhaXuatBanID,
                TenNhaXuatBan = s.NhaXuatBan.TenNhaXuatBan
            }).ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = danhSachSach;
            cboTheLoai.DataBindings.Clear();
            cboTheLoai.DataBindings.Add("SelectedValue", bindingSource, "TheLoaiID", false, DataSourceUpdateMode.Never);
            cboTacGia.DataBindings.Clear();
            cboTacGia.DataBindings.Add("SelectedValue", bindingSource, "TacGiaID", false, DataSourceUpdateMode.Never);
            cboNhaXuatBan.DataBindings.Clear();
            cboNhaXuatBan.DataBindings.Add("SelectedValue", bindingSource, "NhaXuatBanID", false, DataSourceUpdateMode.Never);
            txtTenSach.DataBindings.Clear();
            txtTenSach.DataBindings.Add("Text", bindingSource, "TenSach", false, DataSourceUpdateMode.Never);
            numNamXuatBan.DataBindings.Clear();
            numNamXuatBan.DataBindings.Add("Value", bindingSource, "NamXuatBan", false, DataSourceUpdateMode.Never);
            numSoLuong.DataBindings.Clear();
            numSoLuong.DataBindings.Add("Value", bindingSource, "SoLuong", false, DataSourceUpdateMode.Never);
            numDonGia.DataBindings.Clear();
            numDonGia.DataBindings.Add("Value", bindingSource, "DonGia", false, DataSourceUpdateMode.Never);
            picHinhAnh.DataBindings.Clear();
            Binding hinhAnhBinding = new Binding("ImageLocation", bindingSource, "HinhAnh", true, DataSourceUpdateMode.Never);
            hinhAnhBinding.Format += (s, ev) =>
            {
                if (ev.Value != null && !string.IsNullOrWhiteSpace(ev.Value.ToString()))
                {
                    ev.Value = Path.Combine(imagesFolder, ev.Value.ToString());
                }
                else
                {
                    ev.Value = null;
                }
            };
            picHinhAnh.DataBindings.Add(hinhAnhBinding);

            dgvSach.DataSource = bindingSource;
        }
        private void BatTatChucNang(bool giaTri)
        {
            txtTenSach.Enabled = giaTri;
            btnLuu.Enabled = giaTri;
            btnHuy.Enabled = giaTri;
            cboNhaXuatBan.Enabled = giaTri;
            cboTacGia.Enabled = giaTri;
            cboTheLoai.Enabled = giaTri;
            numSoLuong.Enabled = giaTri;
            numDonGia.Enabled = giaTri;
            numNamXuatBan.Enabled = giaTri;
            //picHinhAnh.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnDoiAnh.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnTimKiem.Enabled = !giaTri;
            btnNhap.Enabled = !giaTri;
            btnXuat.Enabled = !giaTri;
        }

        public void LayTheLoaiVaoComboBox()
        {
            cboTheLoai.DataSource = context.TheLoai.ToList();
            cboTheLoai.DisplayMember = "TenTheLoai";
            cboTheLoai.ValueMember = "ID";
        }

        public void LayTacGiaVaoComboBox()
        {
            cboTacGia.DataSource = context.TacGia.ToList();
            cboTacGia.DisplayMember = "TenTacGia";
            cboTacGia.ValueMember = "ID";
        }

        public void LayNhaXuatBanVaoComboBox()
        {
            cboNhaXuatBan.DataSource = context.NhaXuatBan.ToList();
            cboNhaXuatBan.DisplayMember = "TenNhaXuatBan";
            cboNhaXuatBan.ValueMember = "ID";
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn thoát chương trình không?", "Thông báo",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmSach_Load(sender, e);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            txtTenSach.Clear();
            picHinhAnh.Image = null;
            numNamXuatBan.Value = DateTime.Now.Year;
            numSoLuong.Value = 0;
            numDonGia.Value = 0;
            cboTheLoai.SelectedIndex = 0;
            cboTacGia.SelectedIndex = 0;
            cboNhaXuatBan.SelectedIndex = 0;
            txtTenSach.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa " + txtTenSach.Text + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dgvSach.CurrentRow.Cells["colID"].Value.ToString());
                Sach s = context.Sach.Find(id);
                if (s != null)
                {
                    context.Sach.Remove(s);
                }
                context.SaveChanges();
                frmSach_Load(sender, e);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboTheLoai.Text))
                MessageBox.Show("Vui lòng chọn thể loại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(cboTacGia.Text))
                MessageBox.Show("Vui lòng chọn tác giả.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(cboNhaXuatBan.Text))
                MessageBox.Show("Vui lòng chọn nhà xuất bản.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(txtTenSach.Text))
                MessageBox.Show("Vui lòng nhập tên sách.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (numSoLuong.Value <= 0)
                MessageBox.Show("Số lượng phải lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (numDonGia.Value <= 0)
                MessageBox.Show("Đơn giá sách phải lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string tenHinh = null;
                if (picHinhAnh.ImageLocation != null)
                {
                    tenHinh = Path.GetFileName(picHinhAnh.ImageLocation);
                }
                if (xuLyThem)
                {
                    Sach s = new Sach();
                    s.TenSach = txtTenSach.Text.Trim();
                    s.NamXuatBan = (int)numNamXuatBan.Value;
                    s.SoLuong = (int)numSoLuong.Value;
                    s.DonGia = numDonGia.Value;
                    s.TheLoaiID = Convert.ToInt32(cboTheLoai.SelectedValue);
                    s.TacGiaID = Convert.ToInt32(cboTacGia.SelectedValue);
                    s.NhaXuatBanID = Convert.ToInt32(cboNhaXuatBan.SelectedValue);
                    s.HinhAnh = tenHinh;
                    context.Sach.Add(s);

                    context.SaveChanges();
                    MessageBox.Show("Đã thêm dữ liệu thành công!", "Thông báo");
                }
                else
                {
                    Sach s = context.Sach.Find(id);
                    if (s != null)
                    {
                        s.TenSach = txtTenSach.Text.Trim();
                        s.NamXuatBan = (int)numNamXuatBan.Value;
                        s.SoLuong = (int)numSoLuong.Value;
                        s.DonGia = numDonGia.Value;
                        s.TheLoaiID = Convert.ToInt32(cboTheLoai.SelectedValue);
                        s.TacGiaID = Convert.ToInt32(cboTacGia.SelectedValue);
                        s.NhaXuatBanID = Convert.ToInt32(cboNhaXuatBan.SelectedValue);
                        s.HinhAnh = tenHinh;

                        context.SaveChanges();
                        MessageBox.Show("Đã cập nhật dữ liệu thành công!", "Thông báo");
                    }
                }
                frmSach_Load(sender, e);
            }
        }

        private void btnDoiAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn ảnh bìa sách";
            openFileDialog.Filter = "Tập tin hình ảnh|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string ext = Path.GetExtension(openFileDialog.FileName);
                string newFileName = "sach_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ext;
                string fileSavePath = Path.Combine(imagesFolder, newFileName);
                File.Copy(openFileDialog.FileName, fileSavePath, true);
                picHinhAnh.ImageLocation = fileSavePath;
            }

        }

        private void picHinhAnh_Click(object sender, EventArgs e)
        {
            if (picHinhAnh.Image != null)
            {
                this.Opacity = 0.3;
                frmXemAnh formXem = new frmXemAnh(picHinhAnh.Image);
                formXem.ShowDialog();
                this.Opacity = 1.0;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dgvSach.CurrentRow.Cells["colID"].Value.ToString());
        }
    }
}
