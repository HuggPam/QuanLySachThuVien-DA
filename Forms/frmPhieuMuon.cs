using Microsoft.EntityFrameworkCore;
using QuanLyThuVien.Data;
using QuanLyThuVien.Reports;
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
    public partial class frmPhieuMuon : Form
    {
        QLTVContext context = new QLTVContext();
        int id;
        public frmPhieuMuon()
        {
            InitializeComponent();
        }

        private void frmPhieuMuon_Load(object sender, EventArgs e)
        {
            context = new QLTVContext();
            dgvPhieuMuon.AutoGenerateColumns = false;
            List<DanhSachPhieuMuon> danhSachPhieuMuon = new List<DanhSachPhieuMuon>();
            danhSachPhieuMuon = context.PhieuMuon.Select(p => new DanhSachPhieuMuon
            {
                ID = p.ID,
                NgayMuon = p.NgayMuon,
                TenNhanVien = p.NhanVien.TenNhanVien,
                TenThanhVien = p.ThanhVien.TenThanhVien,
                TrangThai = p.TrangThai,
                ChiTiet = "Xem chi tiết",
            }).ToList();
            dgvPhieuMuon.DataSource = danhSachPhieuMuon;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnLapPhieuMuon_Click(object sender, EventArgs e)
        {
            using (frmPhieuMuon_ChiTiet chiTiet = new frmPhieuMuon_ChiTiet())
            {
                chiTiet.ShowDialog();
                frmPhieuMuon_Load(null, null);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(dgvPhieuMuon.CurrentRow.Cells["colID"].Value.ToString());
            using (frmPhieuMuon_ChiTiet chiTiet = new frmPhieuMuon_ChiTiet(id))
            {
                chiTiet.ShowDialog();
                frmPhieuMuon_Load(null, null);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa phiếu mượn ?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dgvPhieuMuon.CurrentRow.Cells["colID"].Value.ToString());
                PhieuMuon pm = context.PhieuMuon.Find(id);
                if (pm != null)
                {
                    context.PhieuMuon.Remove(pm);
                }
                context.SaveChanges();
                frmPhieuMuon_Load(sender, e);
            }
        }

        private void dgvPhieuMuon_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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
                        case 0: e.Value = "Đang mượn"; break;
                        case 1: e.Value = "Đã hoàn thành"; break;
                        case 2: e.Value = "Quá hạn"; break;
                    }
                    e.FormattingApplied = true;
                }
            }
            int trangThai = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells["colTrangThai"].Value ?? 0);

            dgv.Rows[e.RowIndex].DefaultCellStyle.Font = new Font(dgv.Font, FontStyle.Regular);

            if (trangThai == 0)
            {
                dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightYellow;
                dgv.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
                dgv.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.Khaki;
                dgv.Rows[e.RowIndex].DefaultCellStyle.SelectionForeColor = Color.Black;
            }
            else if (trangThai == 1)
            {
                dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
                dgv.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
                dgv.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.MediumSeaGreen;
                dgv.Rows[e.RowIndex].DefaultCellStyle.SelectionForeColor = Color.White;
            }
            else if (trangThai == 2)
            {
                dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightCoral;
                dgv.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
                dgv.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.IndianRed;
                dgv.Rows[e.RowIndex].DefaultCellStyle.SelectionForeColor = Color.White;
            }
        }

        private void dgvPhieuMuon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPhieuMuon.Columns[e.ColumnIndex].Name == "colChiTiet" && e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(dgvPhieuMuon.Rows[e.RowIndex].Cells["colID"].Value);
                using (frmPhieuMuon_ChiTiet chiTiet = new frmPhieuMuon_ChiTiet(id))
                {
                    chiTiet.chiXem = true;
                    chiTiet.ShowDialog();
                    frmPhieuMuon_Load(null, null);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn thoát chương trình không?", "Thông báo",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }

        private void btnInPhieuMuon_Click(object sender, EventArgs e)
        {
            if (dgvPhieuMuon.CurrentRow != null)
            {
                int idPhieu = Convert.ToInt32(dgvPhieuMuon.CurrentRow.Cells["colID"].Value);
                using (frmInPhieuMuon fIn = new frmInPhieuMuon(idPhieu))
                {
                    fIn.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một phiếu mượn trên bảng để in!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
