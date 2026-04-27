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
            var listSach = context.Sach.Where(s => s.SoLuong > 0).ToList();
            cboSach.DataSource = listSach;
            cboSach.DisplayMember = "TenSach";
            cboSach.ValueMember = "ID";
            cboSach.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboSach.AutoCompleteSource = AutoCompleteSource.CustomSource;

            AutoCompleteStringCollection dataSach = new AutoCompleteStringCollection();
            foreach (var s in listSach)
            {
                dataSach.Add(s.TenSach);
            }
            cboSach.AutoCompleteCustomSource = dataSach;
        }
        public void LayNhanVienVaoComboBox()
        {
            var nhanVienHienTai = context.NhanVien.Where(nv => nv.ID == Program.MaNhanVienDangNhap).ToList();
            cboNhanVien.DataSource = context.NhanVien.ToList();
            cboNhanVien.DisplayMember = "TenNhanVien";
            cboNhanVien.ValueMember = "ID";
            cboNhanVien.Enabled = false;
        }
        public void LayThanhVienVaoComboBox()
        {
            var tkHoatDong = context.ThanhVien.Where(tv => tv.TrangThai == 0).ToList();
            cboThanhVien.DataSource = tkHoatDong;
            cboThanhVien.DisplayMember = "TenThanhVien";
            cboThanhVien.ValueMember = "ID";
            cboThanhVien.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboThanhVien.AutoCompleteSource = AutoCompleteSource.CustomSource;

            AutoCompleteStringCollection dataThanhVien = new AutoCompleteStringCollection();
            foreach (var tv in tkHoatDong)
            {
                dataThanhVien.Add(tv.TenThanhVien);
            }
            cboThanhVien.AutoCompleteCustomSource = dataThanhVien;
        }

        public void BatTatChucNang()
        {
            bool coSachTrongDanhSach = dgvPhieuMuonChiTiet.Rows.Count > 0;
            btnLuuPhieuMuon.Enabled = coSachTrongDanhSach && !chiXem;
            btnXoa.Enabled = coSachTrongDanhSach && !chiXem;
            btnXacNhan.Enabled = coSachTrongDanhSach && !chiXem;
            btnXacNhan.Enabled = (!chiXem && id == 0);
            cboSach.Enabled = (!chiXem && id == 0);
            cboThanhVien.Enabled = (!chiXem && id == 0);
            if (!coSachTrongDanhSach)
            {
                cboSach.SelectedIndex = -1;
            }
            if (!chiXem && id != 0)
            {
                btnTraSach.Visible = true;
                btnGiaHan.Visible = true;
                var chiTiet = dgvPhieuMuonChiTiet.CurrentRow?.DataBoundItem as DanhSachChiTietPhieuMuon;
                btnTraSach.Enabled = (chiTiet != null && chiTiet.TrangThaiTra == 0);
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
            cboNhanVien.SelectedValue = (int)Program.MaNhanVienDangNhap;
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
                    GhiChu = p.GhiChu,
                    TrangThaiTra = p.TrangThaiTra,
                    TienPhat = p.TienPhat,
                    DonGia = p.Sach.DonGia,
                }).ToList();
                phieuMuonChiTiet = new BindingList<DanhSachChiTietPhieuMuon>(pm);
            }
            dgvPhieuMuonChiTiet.DataSource = phieuMuonChiTiet;
            BatTatChucNang();
            cboThanhVien_SelectedIndexChanged(null, null);
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (cboThanhVien.SelectedValue == null || string.IsNullOrWhiteSpace(cboSach.Text) || cboSach.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn thành viên và sách để mượn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboSach.Focus();
                return;
            }
            int maThanhVien = (int)cboThanhVien.SelectedValue;
            var tv = context.ThanhVien
                .Include(t => t.GoiThanhVien)
                .Include(t => t.PhieuMuon)
                .ThenInclude(pm => pm.ChiTietPhieuMuon)
                .FirstOrDefault(t => t.ID == maThanhVien);

            if (tv != null)
            {
                bool dangCoSachQuaHan = tv.PhieuMuon
                    .SelectMany(pm => pm.ChiTietPhieuMuon)
                    .Any(ct => ct.TrangThaiTra == 0 && ct.HanTra.Date < DateTime.Now.Date);
                if (dangCoSachQuaHan)
                {
                    MessageBox.Show("Thành viên này đang có sách mượn QUÁ HẠN chưa trả!\nVui lòng trả sách cũ để được mượn tiếp.", "Từ chối cho mượn", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return; //không cho mượn thêm
                }
                int hanMuc = tv.GoiThanhVien.SoSachDuocMuon;
                int dangMuon = tv.PhieuMuon
                    .SelectMany(pm => pm.ChiTietPhieuMuon)
                    .Count(ct => ct.NgayTra == null);

                int dangThem = phieuMuonChiTiet.Count;

                if (dangMuon + dangThem >= hanMuc)
                {
                    MessageBox.Show($"Không thể thêm sách!\n" +
                                    $"- Hạn mức gói: {hanMuc} cuốn.\n" +
                                    $"- Đã mượn: {dangMuon} cuốn.\n" +
                                    $"- Đang thêm: {dangThem} cuốn.\n" +
                                    $"Vui lòng trả sách cũ trước khi mượn mới!",
                                    "Cảnh báo hạn mức", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
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
            {
                MessageBox.Show("Vui lòng chọn thủ thư lập phiếu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboNhanVien.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(cboThanhVien.Text))
            {
                MessageBox.Show("Vui lòng chọn thành viên mượn sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboThanhVien.Focus();
                return;
            }
            else if (phieuMuonChiTiet.Count == 0)
            {
                MessageBox.Show("Danh sách mượn đang trống! Vui lòng thêm ít nhất 1 cuốn sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (id != 0) // Sửa phiếu mượn
                {
                    PhieuMuon pm = context.PhieuMuon.Find(id);
                    if (pm != null)
                    {
                        pm.NhanVienID = Convert.ToInt32(cboNhanVien.SelectedValue);
                        pm.ThanhVienID = Convert.ToInt32(cboThanhVien.SelectedValue);

                        var old = context.ChiTietPhieuMuon.Where(r => r.PhieuMuonID == id).ToList();

                        foreach (var oldItem in old)
                        {
                            if (oldItem.TrangThaiTra == 0) // Nếu sách cũ đang mượn thì trả lại kho
                            {
                                var sachCu = context.Sach.Find(oldItem.SachID);
                                if (sachCu != null) sachCu.SoLuong += 1;
                            }
                        }
                        context.ChiTietPhieuMuon.RemoveRange(old);

                        bool conSachChuaTra = false;

                        foreach (var item in phieuMuonChiTiet.ToList())
                        {
                            ChiTietPhieuMuon ct = new ChiTietPhieuMuon();
                            ct.PhieuMuonID = id;
                            ct.SachID = item.SachID;
                            ct.HanTra = item.HanTra;
                            ct.NgayTra = item.NgayTra;
                            ct.SoLanGiaHan = item.SoLanGiaHan;
                            ct.GhiChu = item.GhiChu;
                            ct.TrangThaiTra = item.TrangThaiTra;
                            ct.TienPhat = item.TienPhat;

                            context.ChiTietPhieuMuon.Add(ct);

                            if (item.TrangThaiTra == 0)
                            {
                                conSachChuaTra = true;
                                // -1 số lượng sách trong kho khi thêm mới
                                var sachMoi = context.Sach.Find(item.SachID);
                                if (sachMoi != null) sachMoi.SoLuong -= 1;
                            }
                        }

                        if (!conSachChuaTra && phieuMuonChiTiet.Count > 0)
                        {
                            pm.TrangThai = 1;
                        }
                        else
                        {
                            pm.TrangThai = 0;
                        }

                        context.PhieuMuon.Update(pm);
                        context.SaveChanges();
                    }
                }
                else
                {
                    PhieuMuon pm = new PhieuMuon();
                    pm.NhanVienID = Convert.ToInt32(cboNhanVien.SelectedValue);
                    pm.ThanhVienID = Convert.ToInt32(cboThanhVien.SelectedValue);
                    pm.NgayMuon = DateTime.Now;
                    pm.TrangThai = 0; // Thêm mới thì mặc định là 0 (Đang mượn)

                    context.PhieuMuon.Add(pm);
                    context.SaveChanges();

                    foreach (var item in phieuMuonChiTiet.ToList())
                    {
                        ChiTietPhieuMuon ct = new ChiTietPhieuMuon();
                        ct.PhieuMuonID = pm.ID;
                        ct.SachID = item.SachID;
                        ct.HanTra = item.HanTra;
                        ct.NgayTra = item.NgayTra;
                        ct.SoLanGiaHan = item.SoLanGiaHan;
                        ct.GhiChu = item.GhiChu;
                        ct.TrangThaiTra = item.TrangThaiTra;
                        ct.TienPhat = item.TienPhat;

                        context.ChiTietPhieuMuon.Add(ct);
                        // -1 số lượng sách trong kho khi thêm mới phiếu mượn
                        var sachDb = context.Sach.Find(item.SachID);
                        if (sachDb != null && sachDb.SoLuong > 0)
                        {
                            sachDb.SoLuong -= 1;
                        }
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
                if (cboThanhVien.SelectedValue == null || !(cboThanhVien.SelectedValue is int)) return;

                int maThanhVien = (int)cboThanhVien.SelectedValue;

                var tv = context.ThanhVien
                    .Include(t => t.GoiThanhVien)
                    .Include(t => t.PhieuMuon)
                    .ThenInclude(pm => pm.ChiTietPhieuMuon)
                    .FirstOrDefault(t => t.ID == maThanhVien);

                if (tv != null)
                {
                    int soNgayDuocMuon = tv.GoiThanhVien.SoNgayMuonToiDa;
                    dtpHanTra.Value = DateTime.Now.AddDays(soNgayDuocMuon);

                    int dangMuon = tv.PhieuMuon
                        .SelectMany(pm => pm.ChiTietPhieuMuon)
                        .Count(ct => ct.NgayTra == null);

                    int hanMuc = tv.GoiThanhVien.SoSachDuocMuon;

                    if (dangMuon >= hanMuc)
                    {
                        lblThongBao.Text = $"Đã mượn {dangMuon}/{hanMuc} cuốn";
                        lblThongBao.ForeColor = Color.Red;

                        cboSach.Enabled = false;
                        btnXacNhan.Enabled = false;
                    }
                    else
                    {
                        lblThongBao.Text = $"Đã mượn {dangMuon}/{hanMuc} cuốn";
                        lblThongBao.ForeColor = Color.Green;

                        cboSach.Enabled = (!chiXem && id == 0);
                        btnXacNhan.Enabled = (!chiXem && id == 0);
                    }
                }
            }

        }

        private void dgvPhieuMuonChiTiet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTraSach_Click(object sender, EventArgs e)
        {
            var chiTiet = dgvPhieuMuonChiTiet.CurrentRow?.DataBoundItem as DanhSachChiTietPhieuMuon;
            if (chiTiet == null)
            {
                MessageBox.Show("Vui lòng chọn một cuốn sách để trả!");
                return;
            }

            using (TinhTrangTraSach frm = new TinhTrangTraSach())
            {
                frm.TenSachHienTai = chiTiet.TenSach;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    // 1. Cập nhật Trạng thái và Ngày trả
                    int tinhTrang = frm.TinhTrangDuocChon;
                    chiTiet.TrangThaiTra = tinhTrang;
                    chiTiet.NgayTra = DateTime.Now;

                    // 2. Tính tiền phạt
                    decimal phiPhatSinh = 0;
                    decimal giaGoc = chiTiet.DonGia;

                    if (tinhTrang == 2) phiPhatSinh = giaGoc; // 2: Mất sách
                    else if (tinhTrang == 3) phiPhatSinh = giaGoc * 0.5m; // 3: Hư hỏng

                    if (chiTiet.NgayTra.Value.Date > chiTiet.HanTra.Date)
                    {
                        int soNgayTre = (chiTiet.NgayTra.Value.Date - chiTiet.HanTra.Date).Days;
                        phiPhatSinh += (soNgayTre * 5000);
                    }

                    chiTiet.TienPhat = phiPhatSinh;

                    try
                    {
                        var chiTietDb = context.ChiTietPhieuMuon.FirstOrDefault(x => x.ID == chiTiet.ID);

                        if (chiTietDb != null)
                        {
                            chiTietDb.NgayTra = chiTiet.NgayTra;
                            chiTietDb.TrangThaiTra = chiTiet.TrangThaiTra;
                            chiTietDb.TienPhat = chiTiet.TienPhat;

                            var sachDb = context.Sach.FirstOrDefault(s => s.ID == chiTiet.SachID);
                            if (sachDb != null)
                            {
                                // 1 (Bình thường) hoặc 3 (Hư hỏng) thì sách quay về kho -> Cộng 1
                                // Mất sách (2) thì bỏ qua
                                if (tinhTrang == 1 || tinhTrang == 3)
                                {
                                    sachDb.SoLuong += 1;
                                }
                            }

                            var phieuMuonCha = context.PhieuMuon.FirstOrDefault(p => p.ID == chiTiet.PhieuMuonID);
                            int soLoiCongThem = 0;

                            if (chiTiet.TrangThaiTra == 2 || chiTiet.TrangThaiTra == 3) soLoiCongThem += 1;

                            if (chiTiet.NgayTra.Value.Date > chiTiet.HanTra.Date)
                            {
                                bool daTungPhatTre = context.ChiTietPhieuMuon.Any(ct =>
                                    ct.PhieuMuonID == chiTiet.PhieuMuonID &&
                                    ct.ID != chiTiet.ID &&
                                    ct.NgayTra.HasValue &&
                                    ct.NgayTra.Value.Date > ct.HanTra.Date);

                                if (!daTungPhatTre) soLoiCongThem += 1;
                            }

                            if (soLoiCongThem > 0 && phieuMuonCha != null)
                            {
                                var thanhVien = context.ThanhVien.FirstOrDefault(tv => tv.ID == phieuMuonCha.ThanhVienID);
                                if (thanhVien != null)
                                {
                                    thanhVien.SoLanViPham += soLoiCongThem;
                                    thanhVien.NgayViPham = DateTime.Now;
                                    if (thanhVien.SoLanViPham >= 4) thanhVien.TrangThai = 1;
                                    context.ThanhVien.Update(thanhVien);
                                }
                            }

                            var tatCaChiTiet = context.ChiTietPhieuMuon.Where(ct => ct.PhieuMuonID == chiTiet.PhieuMuonID).ToList();
                            bool conSachChuaTra = tatCaChiTiet.Any(ct => ct.TrangThaiTra == 0);

                            if (!conSachChuaTra && phieuMuonCha != null)
                            {
                                phieuMuonCha.TrangThai = 1;
                            }

                            context.SaveChanges();
                            MessageBox.Show("Trả sách thành công!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi lưu dữ liệu: " + ex.Message);
                    }
                    phieuMuonChiTiet.ResetBindings();
                    BatTatChucNang();
                }
            }
        }

        private void KiemTraNutTraSach()
        {
            var chiTiet = dgvPhieuMuonChiTiet.CurrentRow?.DataBoundItem as DanhSachChiTietPhieuMuon;

            if (chiTiet != null && !chiXem)
            {
                btnTraSach.Enabled = (chiTiet.TrangThaiTra == 0);
                if (chiTiet.TrangThaiTra == 0 && chiTiet.HanTra.Date >= DateTime.Now.Date)
                {
                    int maxGiaHan = 0;
                    if (cboThanhVien.SelectedValue != null && cboThanhVien.SelectedValue is int)
                    {
                        int maThanhVien = (int)cboThanhVien.SelectedValue;
                        var tv = context.ThanhVien.Include(t => t.GoiThanhVien).FirstOrDefault(t => t.ID == maThanhVien);
                        if (tv != null && tv.GoiThanhVien != null)
                        {
                            maxGiaHan = tv.GoiThanhVien.SoLanGiaHanToiDa;
                        }
                    }
                    btnGiaHan.Enabled = (chiTiet.SoLanGiaHan < maxGiaHan);
                }
                else
                {
                    btnGiaHan.Enabled = false;
                }
            }
            else
            {
                btnTraSach.Enabled = false;
                btnGiaHan.Enabled = false;
            }
        }

        private void dgvPhieuMuonChiTiet_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            DataGridView dgv = sender as DataGridView;

            string tenCotTrangThai = "colTrangThaiTra";

            // Đổi số thành chữ
            if (dgv.Columns[e.ColumnIndex].Name == tenCotTrangThai && e.Value != null)
            {
                string strValue = e.Value.ToString();

                switch (strValue)
                {
                    case "0": e.Value = "Đang mượn"; break;
                    case "1": e.Value = "Bình thường"; break;
                    case "2": e.Value = "Làm mất"; break;
                    case "3": e.Value = "Hư hỏng"; break;
                }
                e.FormattingApplied = true;
            }

            if (dgv.Rows[e.RowIndex].Cells["colTrangThaiTra"].Value != null && dgv.Rows[e.RowIndex].Cells["colHanTra"].Value != null)
            {
                int trangThaiTra = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells["colTrangThaiTra"].Value);
                DateTime hanTra = Convert.ToDateTime(dgv.Rows[e.RowIndex].Cells["colHanTra"].Value);
                if (trangThaiTra == 0 && DateTime.Now.Date > hanTra.Date)
                {
                    dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightCoral; 
                    dgv.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;   
                    dgv.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.IndianRed;
                }
                else
                {
                    dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                    dgv.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
                    dgv.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = SystemColors.Highlight;
                }
            }

        }

        private void dgvPhieuMuonChiTiet_SelectionChanged(object sender, EventArgs e)
        {
            KiemTraNutTraSach();
        }

        private void btnInPhieuMuon_Click(object sender, EventArgs e)
        {

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmPhieuMuon_ChiTiet_Load(sender, e);
        }

        private void btnGiaHan_Click(object sender, EventArgs e)
        {
            var chiTiet = dgvPhieuMuonChiTiet.CurrentRow?.DataBoundItem as DanhSachChiTietPhieuMuon;

            if (chiTiet == null)
            {
                MessageBox.Show("Vui lòng chọn một cuốn sách để gia hạn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maThanhVien = Convert.ToInt32(cboThanhVien.SelectedValue);
            var tv = context.ThanhVien
                            .Include(t => t.GoiThanhVien)
                            .FirstOrDefault(t => t.ID == maThanhVien);

            if (tv == null || tv.GoiThanhVien == null)
            {
                MessageBox.Show("Không thể lấy thông tin gói thành viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int maxGiaHan = tv.GoiThanhVien.SoLanGiaHanToiDa;
            string tenGoi = tv.GoiThanhVien.TenGoi;

            if (chiTiet.SoLanGiaHan >= maxGiaHan)
            {
                MessageBox.Show($"Cuốn sách này đã hết số lần gia hạn cho phép đối với {tenGoi} (Tối đa {maxGiaHan} lần)!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr = MessageBox.Show($"Bạn có chắc muốn gia hạn cuốn sách '{chiTiet.TenSach}' thêm 7 ngày không?\n\n- Số lần đã gia hạn: {chiTiet.SoLanGiaHan}/{maxGiaHan} ({tenGoi})", "Xác nhận gia hạn", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                try
                {
                    var chiTietDb = context.ChiTietPhieuMuon.FirstOrDefault(x => x.ID == chiTiet.ID);
                    if (chiTietDb != null)
                    {
                        chiTietDb.HanTra = chiTietDb.HanTra.AddDays(7);
                        chiTietDb.SoLanGiaHan += 1;

                        context.SaveChanges();

                        chiTiet.HanTra = chiTietDb.HanTra;
                        chiTiet.SoLanGiaHan = chiTietDb.SoLanGiaHan;
                        phieuMuonChiTiet.ResetBindings();

                        MessageBox.Show($"Gia hạn thành công!\n\nHạn trả mới là: {chiTiet.HanTra.ToString("dd/MM/yyyy")}", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        KiemTraNutTraSach();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lưu dữ liệu gia hạn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}