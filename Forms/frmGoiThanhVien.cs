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
    public partial class frmGoiThanhVien : Form
    {
        QLTVContext context = new QLTVContext();
        bool xuLyThem = false;
        int id;
        public frmGoiThanhVien()
        {
            InitializeComponent();
        }
        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuy.Enabled = giaTri;
            txtTenGoi.Enabled = giaTri;
            numSoSach.Enabled = giaTri;
            numHieuLuc.Enabled = giaTri;
            numHanMuon.Enabled = giaTri;
            numGiaTien.Enabled = giaTri;
            numGiaHan.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }

        private void frmGoiThanhVien_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            List<GoiThanhVien> danhSachGoi = new List<GoiThanhVien>();
            danhSachGoi = context.GoiThanhVien.ToList();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = danhSachGoi;
            txtTenGoi.DataBindings.Clear();
            txtTenGoi.DataBindings.Add("Text", bindingSource, "TenGoi", false, DataSourceUpdateMode.Never);
            numGiaHan.DataBindings.Clear();
            numGiaHan.DataBindings.Add("Value", bindingSource, "SoLanGiaHanToiDa", false, DataSourceUpdateMode.Never);
            numGiaTien.DataBindings.Clear();
            numGiaTien.DataBindings.Add("Value", bindingSource, "GiaTien", false, DataSourceUpdateMode.Never);
            numHanMuon.DataBindings.Clear();
            numHanMuon.DataBindings.Add("Value", bindingSource, "SoNgayMuonToiDa", false, DataSourceUpdateMode.Never);
            numHieuLuc.DataBindings.Clear();
            numHieuLuc.DataBindings.Add("Value", bindingSource, "SoThangHieuLuc", false, DataSourceUpdateMode.Never);
            numSoSach.DataBindings.Clear();
            numSoSach.DataBindings.Add("Value", bindingSource, "SoSachDuocMuon", false, DataSourceUpdateMode.Never);
            dgvGoiThanhVien.DataSource = bindingSource;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            txtTenGoi.Clear();
            numSoSach.Value = 0;
            numGiaTien.Value = 0;
            numGiaHan.Value = 0;
            numHieuLuc.Value = 0;
            numHanMuon.Value = 0;
            txtTenGoi.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa gói này?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dgvGoiThanhVien.CurrentRow.Cells["colID"].Value.ToString());
                GoiThanhVien g = context.GoiThanhVien.Find(id);
                if (g != null)
                {
                    context.GoiThanhVien.Remove(g);
                }
                context.SaveChanges();
                frmGoiThanhVien_Load(sender, e);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dgvGoiThanhVien.CurrentRow.Cells["colID"].Value.ToString());
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmGoiThanhVien_Load(sender, e);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenGoi.Text))
            {
                MessageBox.Show("Vui lòng nhập tên gói thành viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenGoi.Focus();
                return;
            }
            else if (numHieuLuc.Value <= 0)
            {
                MessageBox.Show("Số tháng hiệu lực phải lớn hơn 0.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numHieuLuc.Focus();
                return;
            }
            else if (numSoSach.Value <= 0)
            {
                MessageBox.Show("Số sách được mượn phải lớn hơn 0.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numSoSach.Focus();
                return;
            }
            else if (numGiaHan.Value <= 0)
            {
                MessageBox.Show("Số lần gia hạn phải lớn hơn 0.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numGiaHan.Focus();
                return;
            }
            else if (numGiaTien.Value <= 0)
            {
                MessageBox.Show("Giá tiền phải lớn hơn 0.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numGiaTien.Focus();
                return;
            }
            else if (numHanMuon.Value <= 0)
            {
                MessageBox.Show("Số ngày mượn sách phải lớn hơn 0.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numHanMuon.Focus();
                return;
            }
            else
            {
                if (xuLyThem)
                {
                    GoiThanhVien g = new GoiThanhVien();
                    g.TenGoi = txtTenGoi.Text;
                    g.SoThangHieuLuc = (int)numHieuLuc.Value;
                    g.SoLanGiaHanToiDa = (int)numGiaHan.Value;
                    g.SoNgayMuonToiDa = (int)numHanMuon.Value;
                    g.SoSachDuocMuon = (int)numSoSach.Value;
                    g.GiaTien = numGiaTien.Value;

                    context.GoiThanhVien.Add(g);
                    context.SaveChanges();
                    MessageBox.Show("Đã thêm gói thành viên thành công!", "Thông báo");
                }
                else
                {
                    GoiThanhVien g = context.GoiThanhVien.Find(id);
                    if (g != null)
                    {
                        g.TenGoi = txtTenGoi.Text;
                        g.SoThangHieuLuc = (int)numHieuLuc.Value;
                        g.SoLanGiaHanToiDa = (int)numGiaHan.Value;
                        g.SoNgayMuonToiDa = (int)numHanMuon.Value;
                        g.SoSachDuocMuon = (int)numSoSach.Value;
                        g.GiaTien = numGiaTien.Value;

                        context.GoiThanhVien.Update(g);
                        context.SaveChanges();
                        MessageBox.Show("Đã cập nhật gói thành viên thành công!", "Thông báo");
                    }
                }
            }
            frmGoiThanhVien_Load(sender, e);
        }
    }   
}
