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
    public partial class frmPhieuMuon_ChiTiet : Form
    {
        QLTVContext context = new QLTVContext();
        int id;
        public bool chiXem = false;
        BindingList<DanhSachChiTietPhieuMuon> phieuMuonChiTiet = new BindingList<DanhSachChiTietPhieuMuon>();
        public frmPhieuMuon_ChiTiet(int maPhieuMuon = 0)
        {
            InitializeComponent();
            id = maPhieuMuon;
        }

        public void LaySachVaoComboBox()
        {
            cboSach.DataSource = context.Sach.Where(s => s.SoLuong > 0).ToList();
            cboSach.DisplayMember = "TenSach";
            cboSach.ValueMember = "ID";
        }
        public void LayNhanVienVaoComboBox()
        {
            cboNhanVien.DataSource = context.NhanVien.ToList();
            cboNhanVien.DisplayMember = "TenNhanVien";
            cboNhanVien.ValueMember = "ID";
        }
        public void LayThanhVienVaoComboBox()
        {
            cboThanhVien.DataSource = context.ThanhVien.ToList();
            cboThanhVien.DisplayMember = "TenThanhVien";
            cboThanhVien.ValueMember = "ID";
        }

        public void BatTatChucNang()
        {
            bool coSachTrongDanhSach = dgvPhieuMuonChiTiet.Rows.Count > 0;
            btnLuuPhieuMuon.Enabled = coSachTrongDanhSach && !chiXem;
            btnXoa.Enabled = coSachTrongDanhSach && !chiXem;
            if (!coSachTrongDanhSach)
            {
                cboSach.SelectedIndex = -1;
            }
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void cboSach_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmPhieuMuon_ChiTiet_Load(object sender, EventArgs e)
        {
            LaySachVaoComboBox();
            LayNhanVienVaoComboBox();
            LayThanhVienVaoComboBox();
            if (chiXem == true)
            {
                btnLuuPhieuMuon.Enabled = false;
                btnXacNhan.Enabled = false;
                btnXoa.Enabled = false;
                cboSach.Enabled = false;
                cboNhanVien.Enabled = false;
                cboThanhVien.Enabled = false;
                txtGhiChu.ReadOnly = true;
            }
            dgvPhieuMuonChiTiet.AutoGenerateColumns = false;
            if (id != 0)
            {
                var phieuMuon = context.PhieuMuon.Where(p => p.ID == id).SingleOrDefault();
                if (phieuMuon != null)
                {
                    cboNhanVien.SelectedValue = phieuMuon.NhanVienID;
                    cboThanhVien.SelectedValue = phieuMuon.ThanhVienID;
                }

                var pm = context.ChiTietPhieuMuon.Where(p => p.PhieuMuonID == id).Select(p => new DanhSachChiTietPhieuMuon
                {
                    ID = p.ID,
                    PhieuMuonID = p.PhieuMuonID,
                    SachID = p.SachID,
                    TenSach = p.Sach.TenSach,
                    NgayTra = p.NgayTra,
                    HanTra = p.HanTra,
                    SoLanGiaHan = p.SoLanGiaHan,
                    GhiChu = p.GhiChu
                }).ToList();
                phieuMuonChiTiet = new BindingList<DanhSachChiTietPhieuMuon>(pm);
            }
            dgvPhieuMuonChiTiet.DataSource = phieuMuonChiTiet;
            BatTatChucNang();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboSach.Text) || cboSach.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn sách để mượn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int maSach = Convert.ToInt32(cboSach.SelectedValue);
            var chiTiet = phieuMuonChiTiet.FirstOrDefault(x => x.SachID == maSach);

            if (chiTiet != null)
            {
                MessageBox.Show("Cuốn sách này đã có trong danh sách mượn!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DanhSachChiTietPhieuMuon ct = new DanhSachChiTietPhieuMuon
                {
                    ID = 0,
                    PhieuMuonID = id,
                    SachID = maSach,
                    TenSach = cboSach.Text,
                    HanTra = dtpHanTra.Value,
                    NgayTra = null,
                    SoLanGiaHan = 0,
                    GhiChu = txtGhiChu.Text
                };

                phieuMuonChiTiet.Add(ct);
                BatTatChucNang();
                cboSach.SelectedIndex = -1;
                txtGhiChu.Clear();
            }
        }

        private void cboNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLuuPhieuMuon_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboNhanVien.Text))
                MessageBox.Show("Vui lòng chọn thủ thư lập phiếu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(cboThanhVien.Text))
                MessageBox.Show("Vui lòng chọn thành viên mượn sách.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (phieuMuonChiTiet.Count == 0)
                MessageBox.Show("Danh sách mượn đang trống! Vui lòng thêm ít nhất 1 cuốn sách.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (id != 0)
                {
                    PhieuMuon pm = context.PhieuMuon.Find(id);
                    if (pm != null)
                    {
                        pm.NhanVienID = Convert.ToInt32(cboNhanVien.SelectedValue);
                        pm.ThanhVienID = Convert.ToInt32(cboThanhVien.SelectedValue);

                        context.PhieuMuon.Update(pm);
                        var old = context.ChiTietPhieuMuon.Where(r => r.PhieuMuonID == id).ToList();
                        context.ChiTietPhieuMuon.RemoveRange(old);

                        foreach (var item in phieuMuonChiTiet.ToList())
                        {
                            ChiTietPhieuMuon ct = new ChiTietPhieuMuon();
                            ct.PhieuMuonID = id;
                            ct.SachID = item.SachID;
                            ct.HanTra = item.HanTra;
                            ct.NgayTra = item.NgayTra;
                            ct.SoLanGiaHan = item.SoLanGiaHan;
                            ct.GhiChu = item.GhiChu;

                            context.ChiTietPhieuMuon.Add(ct);
                        }
                        context.SaveChanges();
                    }
                }
                else // TRƯỜNG HỢP B: LẬP PHIẾU MỚI
                {
                    PhieuMuon pm = new PhieuMuon();
                    pm.NhanVienID = Convert.ToInt32(cboNhanVien.SelectedValue);
                    pm.ThanhVienID = Convert.ToInt32(cboThanhVien.SelectedValue);
                    pm.NgayMuon = DateTime.Now;

                    context.PhieuMuon.Add(pm);
                    context.SaveChanges(); // Đẻ ID mới

                    // Lấy ID mới đẻ gán cho chi tiết
                    foreach (var item in phieuMuonChiTiet.ToList())
                    {
                        ChiTietPhieuMuon ct = new ChiTietPhieuMuon();
                        ct.PhieuMuonID = pm.ID;
                        ct.SachID = item.SachID;
                        ct.HanTra = item.HanTra;
                        ct.NgayTra = item.NgayTra;
                        ct.SoLanGiaHan = item.SoLanGiaHan;
                        ct.GhiChu = item.GhiChu;

                        context.ChiTietPhieuMuon.Add(ct);
                    }
                    context.SaveChanges();
                }

                MessageBox.Show("Đã lưu phiếu mượn thành công!", "Hoàn tất", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int maSach = Convert.ToInt32(dgvPhieuMuonChiTiet.CurrentRow.Cells["colID"].Value.ToString());
            var chiTiet = phieuMuonChiTiet.FirstOrDefault(x => x.SachID == maSach);
            if (chiTiet != null)
            {
                phieuMuonChiTiet.Remove(chiTiet);
            }
            BatTatChucNang();
        }

        private void cboThanhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboThanhVien.SelectedValue != null && cboThanhVien.SelectedValue is int)
            {
                int maThanhVien = (int)cboThanhVien.SelectedValue;
                var tv = context.ThanhVien
                    .Include(t => t.GoiThanhVien)
                    .FirstOrDefault(t => t.ID == maThanhVien);

                if (tv != null)
                {
                    int soNgayDuocMuon = tv.GoiThanhVien.SoNgayMuonToiDa;
                    dtpHanTra.Value = DateTime.Now.AddDays(soNgayDuocMuon);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvPhieuMuonChiTiet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
