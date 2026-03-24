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
            btnXacNhan.Enabled = coSachTrongDanhSach && !chiXem;
            if (!coSachTrongDanhSach)
            {
                cboSach.SelectedIndex = -1;
            }
            if (!chiXem && id != 0)
            {
                btnTraSach.Visible = true;
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
                if (id != 0)
                {
                    PhieuMuon pm = context.PhieuMuon.Find(id);
                    if (pm != null)
                    {
                        pm.NhanVienID = Convert.ToInt32(cboNhanVien.SelectedValue);
                        pm.ThanhVienID = Convert.ToInt32(cboThanhVien.SelectedValue);

                        var old = context.ChiTietPhieuMuon.Where(r => r.PhieuMuonID == id).ToList();
                        context.ChiTietPhieuMuon.RemoveRange(old);

                        // --- [THÊM LOGIC KIỂM TRA TRẠNG THÁI CHA] ---
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
                            }
                        }

                        // Cập nhật trạng thái bảng Cha
                        if (!conSachChuaTra && phieuMuonChiTiet.Count > 0)
                        {
                            pm.TrangThai = 1; // 1: Đã hoàn thành
                        }
                        else
                        {
                            pm.TrangThai = 0; // 0: Đang mượn
                        }

                        context.PhieuMuon.Update(pm);
                        // --------------------------------------------

                        context.SaveChanges();
                    }
                }
                else
                {
                    PhieuMuon pm = new PhieuMuon();
                    pm.NhanVienID = Convert.ToInt32(cboNhanVien.SelectedValue);
                    pm.ThanhVienID = Convert.ToInt32(cboThanhVien.SelectedValue);
                    pm.NgayMuon = DateTime.Now;
                    pm.TrangThai = 0; // Thêm mới thì mặc định bảng cha là 0 (Đang mượn)

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
                        ct.TrangThaiTra = item.TrangThaiTra; // Sẽ mặc định là 0
                        ct.TienPhat = item.TienPhat;

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
                        lblThongBao.Text = $"⚠️ Đã mượn {dangMuon}/{hanMuc} cuốn";
                        lblThongBao.ForeColor = Color.Red;

                        cboSach.Enabled = false;
                        btnXacNhan.Enabled = false;
                    }
                    else
                    {
                        lblThongBao.Text = $"✅ Đã mượn {dangMuon}/{hanMuc} cuốn";
                        lblThongBao.ForeColor = Color.Green;

                        cboSach.Enabled = true;
                        btnXacNhan.Enabled = true;
                    }
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

        private void btnTraSach_Click(object sender, EventArgs e)
        {
            var chiTiet = dgvPhieuMuonChiTiet.CurrentRow?.DataBoundItem as DanhSachChiTietPhieuMuon;
            if (chiTiet == null)
            {
                MessageBox.Show("Vui lòng chọn một cuốn sách để trả!");
                return;
            }

            // Mở Form phụ lên
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

                    if (tinhTrang == 2)
                    {
                        phiPhatSinh = giaGoc; // 2: Phạt mất sách
                    }
                    else if (tinhTrang == 3)
                    {
                        phiPhatSinh = giaGoc * 0.5m;  // 3: Phạt hư hỏng
                    }
                    if (chiTiet.NgayTra.Value.Date > chiTiet.HanTra.Date)
                    {
                        int soNgayTre = (chiTiet.NgayTra.Value.Date - chiTiet.HanTra.Date).Days;
                        phiPhatSinh += (soNgayTre * 5000); // 5k 1 ngày trễ
                    }

                    chiTiet.TienPhat = phiPhatSinh;

                    // 3. Refresh lại Grid để cập nhật số liệu
                    try
                    {
                        using (var db = new QLTVContext()) // Đổi tên Context này cho đúng với đồ án của bạn
                        {
                            // 1. Tìm lại đúng cái dòng chi tiết phiếu mượn đó dưới Database
                            var chiTietDb = db.ChiTietPhieuMuon
                                              .FirstOrDefault(x => x.ID == chiTiet.ID);

                            if (chiTietDb != null)
                            {
                                // 2. Gán dữ liệu mới vào
                                chiTietDb.NgayTra = chiTiet.NgayTra;
                                chiTietDb.TrangThaiTra = chiTiet.TrangThaiTra;
                                chiTietDb.TienPhat = chiTiet.TienPhat;

                                // 3. LƯU XUỐNG SQL
                                db.SaveChanges();
                                if (chiTietDb != null)
                                {
                                    chiTietDb.NgayTra = chiTiet.NgayTra;
                                    chiTietDb.TrangThaiTra = chiTiet.TrangThaiTra;
                                    chiTietDb.TienPhat = chiTiet.TienPhat;

                                    // 1. TÌM PHIẾU MƯỢN CHA TRƯỚC (Để dùng cho cả 2 mục đích bên dưới)
                                    var phieuMuonCha = db.PhieuMuon.FirstOrDefault(p => p.ID == chiTiet.PhieuMuonID);

                                    // 2. LOGIC CỘNG LỖI VI PHẠM
                                    int soLoiCongThem = 0;
                                    if (chiTiet.TrangThaiTra == 2 || chiTiet.TrangThaiTra == 3) soLoiCongThem += 1;

                                    if (chiTiet.NgayTra.Value.Date > chiTiet.HanTra.Date)
                                    {
                                        bool daTungPhatTre = db.ChiTietPhieuMuon.Any(ct =>
                                            ct.PhieuMuonID == chiTiet.PhieuMuonID &&
                                            ct.ID != chiTiet.ID &&
                                            ct.NgayTra.HasValue &&
                                            ct.NgayTra.Value.Date > ct.HanTra.Date);

                                        if (!daTungPhatTre) soLoiCongThem += 1;
                                    }

                                    if (soLoiCongThem > 0 && phieuMuonCha != null)
                                    {
                                        var thanhVien = db.ThanhVien.FirstOrDefault(tv => tv.ID == phieuMuonCha.ThanhVienID);
                                        if (thanhVien != null)
                                        {
                                            thanhVien.SoLanViPham += soLoiCongThem;
                                            thanhVien.NgayViPham = DateTime.Now;
                                            if (thanhVien.SoLanViPham >= 4) thanhVien.TrangThai = 1; // Khóa thẻ
                                            db.ThanhVien.Update(thanhVien);
                                        }
                                    }

                                    // 3. LOGIC CẬP NHẬT TRẠNG THÁI PHIẾU (MÀU XANH)
                                    var tatCaChiTiet = db.ChiTietPhieuMuon.Where(ct => ct.PhieuMuonID == chiTiet.PhieuMuonID).ToList();
                                    bool conSachChuaTra = tatCaChiTiet.Any(ct => ct.TrangThaiTra == 0);

                                    if (!conSachChuaTra && phieuMuonCha != null)
                                    {
                                        phieuMuonCha.TrangThai = 1; // Đã hoàn thành
                                    }

                                    // 4. LƯU TẤT CẢ XUỐNG SQL MỘT LẦN DUY NHẤT
                                    db.SaveChanges();
                                    MessageBox.Show("Trả sách thành công!");
                                }
                            }
                        }


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi lưu dữ liệu: " + ex.Message);
                    }
                    // =====================================================

                    // Cuối cùng mới làm mới lại Grid
                    phieuMuonChiTiet.ResetBindings();
                }
            }
        }

        private void KiemTraNutTraSach()
        {
            // 1. Lấy dòng đang được chọn
            var chiTiet = dgvPhieuMuonChiTiet.CurrentRow?.DataBoundItem as DanhSachChiTietPhieuMuon;

            if (chiTiet != null && !chiXem)
            {
                // 2. Nếu TrangThaiTra == 0 (Đang mượn) thì hiện nút, ngược lại thì khóa
                // (Luke kiểm tra xem tên nút của mình là btnTraSach hay gì nhé)
                btnTraSach.Enabled = (chiTiet.TrangThaiTra == 0);
            }
            else
            {
                btnTraSach.Enabled = false;
            }
        }

        private void dgvPhieuMuonChiTiet_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            DataGridView dgv = sender as DataGridView;

            // --- CHỖ NÀY: Thay "colTrangThai" bằng đúng cái (Name) của cột Trạng Thái ---
            string tenCotTrangThai = "colTrangThaiTra";

            // 1. Đổi số thành chữ
            if (dgv.Columns[e.ColumnIndex].Name == tenCotTrangThai && e.Value != null)
            {
                // Dùng ToString() cho an toàn tuyệt đối
                string strValue = e.Value.ToString();

                switch (strValue)
                {
                    case "0": e.Value = "Đang mượn"; break;
                    case "1": e.Value = "Trả bình thường"; break;
                    case "2": e.Value = "Làm mất"; break;
                    case "3": e.Value = "Hư hỏng"; break;
                }
                e.FormattingApplied = true;
            }
        }

        private void dgvPhieuMuonChiTiet_SelectionChanged(object sender, EventArgs e)
        {
            KiemTraNutTraSach();
        }
    }
}