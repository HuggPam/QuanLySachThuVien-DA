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
    public partial class frmNhaXuatBan : Form
    {
        QLTVContext context = new QLTVContext();
        bool xuLyThem = false;
        int id;
        public frmNhaXuatBan()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenTheLoai_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmNhaXuatBan_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            List<NhaXuatBan> danhSachNhaXuatBan = new List<NhaXuatBan>();
            danhSachNhaXuatBan = context.NhaXuatBan.ToList();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = danhSachNhaXuatBan;
            txtTenNhaXuatBan.DataBindings.Clear();
            txtTenNhaXuatBan.DataBindings.Add("Text", bindingSource, "TenNhaXuatBan", false, DataSourceUpdateMode.Never);
            txtDienThoai.DataBindings.Clear();
            txtDienThoai.DataBindings.Add("Text", bindingSource, "DienThoai", false, DataSourceUpdateMode.Never);
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", bindingSource, "DiaChi", false, DataSourceUpdateMode.Never);
            dgvNhaXuatBan.DataSource = bindingSource;
        }

        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuy.Enabled = giaTri;
            txtTenNhaXuatBan.Enabled = giaTri;
            txtDienThoai.Enabled = giaTri;
            txtDiaChi.Enabled = giaTri;

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
            txtTenNhaXuatBan.Clear();
            txtDienThoai.Clear();
            txtDiaChi.Clear();
            txtTenNhaXuatBan.Focus();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dgvNhaXuatBan.CurrentRow.Cells["colID"].Value.ToString());
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenNhaXuatBan.Text))
            {
                MessageBox.Show("Vui lòng nhập tên nhà xuất bản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenNhaXuatBan.Focus();
                return;
            }
            else
            {
                if (xuLyThem)
                {
                    NhaXuatBan nxb = new NhaXuatBan();
                    nxb.TenNhaXuatBan = txtTenNhaXuatBan.Text;
                    nxb.DienThoai = txtDienThoai.Text;
                    nxb.DiaChi = txtDiaChi.Text;
                    context.NhaXuatBan.Add(nxb);
                    context.SaveChanges();
                    MessageBox.Show("Đã thêm dữ liệu thành công!", "Thông báo");
                }
                else
                {
                    NhaXuatBan nxb = context.NhaXuatBan.Find(id);
                    if (nxb != null)
                    {
                        nxb.TenNhaXuatBan = txtTenNhaXuatBan.Text;
                        nxb.DienThoai = txtDienThoai.Text;
                        nxb.DiaChi = txtDiaChi.Text;
                        context.NhaXuatBan.Update(nxb);
                        context.SaveChanges();
                        MessageBox.Show("Đã cập nhật dữ liệu thành công!", "Thông báo");
                    }
                }
                frmNhaXuatBan_Load(sender, e);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa " + txtTenNhaXuatBan.Text + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dgvNhaXuatBan.CurrentRow.Cells["colID"].Value.ToString());
                NhaXuatBan nxb = context.NhaXuatBan.Find(id);
                if (nxb != null)
                {
                    context.NhaXuatBan.Remove(nxb);
                }
                context.SaveChanges();
                frmNhaXuatBan_Load(sender, e);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmNhaXuatBan_Load(sender, e);

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn thoát chương trình không?", "Thông báo",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void dgvNhaXuatBan_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
        }
    }
}
