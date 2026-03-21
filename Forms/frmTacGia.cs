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
    public partial class frmTacGia : Form
    {
        QLTVContext context = new QLTVContext();
        bool xuLyThem = false;
        int id;
        public frmTacGia()
        {
            InitializeComponent();
        }

        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuy.Enabled = giaTri;
            txtTenTacGia.Enabled = giaTri;
            txtGhiChu.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn thoát chương trình không?", "Thông báo",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            txtTenTacGia.Clear();
            txtGhiChu.Clear();
            txtTenTacGia.Focus();
        }

        private void frmTacGia_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);

            List<TacGia> danhSachTacGia = context.TacGia.ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = danhSachTacGia;

            txtTenTacGia.DataBindings.Clear();
            txtTenTacGia.DataBindings.Add("Text", bindingSource, "TenTacGia", false, DataSourceUpdateMode.Never);
            txtGhiChu.DataBindings.Clear();
            txtGhiChu.DataBindings.Add("Text", bindingSource, "GhiChu", false, DataSourceUpdateMode.Never);

            dgvTacGia.DataSource = bindingSource;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dgvTacGia.CurrentRow.Cells["colID"].Value.ToString());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa tác giả này?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dgvTacGia.CurrentRow.Cells["ID"].Value.ToString());
                TheLoai tg = context.TheLoai.Find(id);
                if (tg != null)
                {
                    context.TheLoai.Remove(tg);
                }
                context.SaveChanges();

                frmTacGia_Load(sender, e);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmTacGia_Load(sender, e);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenTacGia.Text))
            {
                MessageBox.Show("Vui lòng nhập tên tác giả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenTacGia.Focus();
                return;
            }
            if (xuLyThem) //Thêm
            {
                TacGia tg = new TacGia();
                tg.TenTacGia = txtTenTacGia.Text.Trim();
                tg.GhiChu = txtGhiChu.Text.Trim();
                context.TacGia.Add(tg);
                context.SaveChanges();
                MessageBox.Show("Đã thêm dữ liệu thành công!", "Thông báo");
            }
            else //Sửa
            {
                TacGia tg = context.TacGia.Find(id);
                if (tg != null)
                {
                    tg.TenTacGia = txtTenTacGia.Text.Trim();
                    tg.GhiChu = txtGhiChu.Text.Trim();
                    context.TacGia.Update(tg);
                    context.SaveChanges();
                    MessageBox.Show("Đã cập nhật dữ liệu thành công!", "Thông báo");
                }
            }
            frmTacGia_Load(sender, e);
        }

        private void txtGhiChu_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
