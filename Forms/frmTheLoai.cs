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
    public partial class frmTheLoai : Form
    {
        QLTVContext context = new QLTVContext();
        bool xuLyThem = false;
        int id;
        public frmTheLoai()
        {
            InitializeComponent();
        }
        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuy.Enabled = giaTri;
            txtTenTheLoai.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmTheLoai_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);

            List<TheLoai> danhSachTheLoai = context.TheLoai.ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = danhSachTheLoai;

            txtTenTheLoai.DataBindings.Clear();
            txtTenTheLoai.DataBindings.Add("Text", bindingSource, "TenTheLoai", false, DataSourceUpdateMode.Never);

            dgvTheLoai.DataSource = bindingSource;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            txtTenTheLoai.Clear();
            txtTenTheLoai.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dgvTheLoai.CurrentRow.Cells["ID"].Value.ToString());
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmTheLoai_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa thể loại này?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dgvTheLoai.CurrentRow.Cells["ID"].Value.ToString());
                TheLoai tl = context.TheLoai.Find(id);
                if (tl != null)
                {
                    context.TheLoai.Remove(tl);
                }
                context.SaveChanges();

                frmTheLoai_Load(sender, e);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenTheLoai.Text))
            {
                MessageBox.Show("Vui lòng nhập tên thể loại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenTheLoai.Focus();
                return;
            }
            if (xuLyThem) //Thêm
            {
                TheLoai tl = new TheLoai();
                tl.TenTheLoai = txtTenTheLoai.Text.Trim();
                context.TheLoai.Add(tl);
            }
            else //Sửa
            {
                TheLoai tl = context.TheLoai.Find(id);
                if (tl != null)
                {
                    tl.TenTheLoai = txtTenTheLoai.Text.Trim();
                    context.TheLoai.Update(tl);
                }
            }
            context.SaveChanges();
            MessageBox.Show("Đã lưu dữ liệu thành công!", "Thông báo");
            frmTheLoai_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn thoát chương trình không?", "Thông báo",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
