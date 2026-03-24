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
    public partial class frmPhieuThu : Form
    {
        QLTVContext context = new QLTVContext();
        bool xuLyThem = false;
        int id;
        public frmPhieuThu()
        {
            InitializeComponent();
        }

        private void frmPhieuThu_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            LayThanhVienVaoComboBox();
            LayLoaiThuVaoComboBox();

            dtpNgayThu.Value = DateTime.Now;
            txtNhanVien.Text = "Thủ Thư Lan"; // Tạm thời fix cứng
            txtNhanVien.ReadOnly = true;

            dgvPhieuThu.AutoGenerateColumns = false;

            // SỬA TẠI ĐÂY: Lấy từ bảng PhieuThu và dùng đúng class DanhSachPhieuThu
            var ds = context.PhieuThu.Select(p => new DanhSachPhieuThu
            {
                ID = p.ID,
                TenNhanVien = p.NhanVien.TenNhanVien,
                TenThanhVien = p.ThanhVien.TenThanhVien, // Kiểm tra lại tên cột bên bảng ThanhVien nhé
                NgayThu = p.NgayThu,
                LoaiThu = p.LoaiThu,
                SoTienThu = p.SoTienThu,
                LyDoThu = p.LyDoThu,
            }).OrderByDescending(x => x.NgayThu).ToList();

            // Gán dữ liệu vào Grid
            dgvPhieuThu.DataSource = ds;
        }

        private void BatTatChucNang(bool giaTri)
        {
            txtNhanVien.Enabled = giaTri;
            btnLuu.Enabled = giaTri;
            btnHuy.Enabled = giaTri;
            cboLoaiThu.Enabled = giaTri;
            cboThanhVien.Enabled = giaTri;
            numSoTienThu.Enabled = giaTri;
            txtLyDo.Enabled = giaTri;

            btnLapPhieuThu.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnTimKiem.Enabled = !giaTri;
            btnXuat.Enabled = !giaTri;
        }
        private void LayThanhVienVaoComboBox()
        {
            using (var db = new QLTVContext())
            {
                // Lấy danh sách thành viên từ Database
                var ds = db.ThanhVien
                           .Select(t => new { t.ID, t.TenThanhVien })
                           .ToList();

                // Đổ vào ComboBox
                cboThanhVien.DataSource = ds;
                cboThanhVien.DisplayMember = "TenThanhVien"; // Hiển thị tên cho thủ thư nhìn
                cboThanhVien.ValueMember = "ID";      // Lưu ID ngầm bên dưới

                // Reset lựa chọn về trống để thủ thư tự gõ
                cboThanhVien.SelectedIndex = -1;
            }

        }
        private void LayLoaiThuVaoComboBox()
        {
            var loaiThu = new[] {
            new { ID = 0, Ten = "Thu tiền phạt" },        // Index 0
            new { ID = 1, Ten = "Lệ phí gia hạn thẻ" },  // Index 1
            new { ID = 2, Ten = "Bồi thường hỏng sách" }, // Index 2
            new { ID = 3, Ten = "Bồi thường mất sách" },  // Index 3 (Sửa lại ID 3 ở đây)
            }.ToList();

            cboLoaiThu.DataSource = loaiThu;
            cboLoaiThu.DisplayMember = "Ten";
            cboLoaiThu.ValueMember = "ID";
        }

        private void btnLapPhieuThu_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            txtLyDo.Clear();
            dtpNgayThu.Value = DateTime.Now;
            numSoTienThu.Value = 0;
            cboLoaiThu.SelectedIndex = 0;
            cboThanhVien.SelectedIndex = -1;
            cboThanhVien.Focus();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmPhieuThu_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn thoát chương trình không?", "Thông báo",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dgvPhieuThu.CurrentRow.Cells["colID"].Value.ToString());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa phiếu thu?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dgvPhieuThu.CurrentRow.Cells["colID"].Value.ToString());
                PhieuThu pt = context.PhieuThu.Find(id);
                if (pt != null)
                {
                    context.PhieuThu.Remove(pt);
                }
                context.SaveChanges();
                frmPhieuThu_Load(sender, e);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cboThanhVien.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn thành viên đóng tiền!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboThanhVien.Focus();
                return;
            }
            // Có thể kiểm tra thêm số tiền
            else if (numSoTienThu.Value <= 0)
            {
                MessageBox.Show("Số tiền thu không được bằng 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numSoTienThu.Focus();
                return;
            }
            else
            {
                if (xuLyThem) // TRƯỜNG HỢP THÊM MỚI PHIẾU THU
                {
                    int maTV = (int)cboThanhVien.SelectedValue;
                    int loaiDuocChon = cboLoaiThu.SelectedIndex;

                    // 1. TẠO PHIẾU THU LƯU VÀO DB
                    PhieuThu pt = new PhieuThu();
                    pt.ThanhVienID = maTV;
                    pt.NhanVienID = 1; // Tạm thời fix cứng hoặc lấy từ Session
                    pt.SoTienThu = numSoTienThu.Value;
                    pt.NgayThu = dtpNgayThu.Value;
                    pt.LoaiThu = loaiDuocChon;
                    pt.LyDoThu = txtLyDo.Text;

                    context.PhieuThu.Add(pt);

                    // =======================================================
                    // 2. LOGIC TỰ ĐỘNG XÓA NỢ VÀ GIA HẠN THẺ 
                    // =======================================================
                    if (loaiDuocChon == 0) // Đóng phạt trễ hạn -> Xóa nợ trễ hạn
                    {
                        var dsNo = context.ChiTietPhieuMuon.Where(ct => ct.PhieuMuon.ThanhVienID == maTV && ct.TrangThaiTra == 1 && ct.TienPhat > 0).ToList();
                        foreach (var ct in dsNo) ct.TienPhat = 0;
                    }
                    else if (loaiDuocChon == 1) // Gia hạn thẻ -> Cộng thêm tháng sử dụng
                    {
                        var tv = context.ThanhVien.Include(t => t.GoiThanhVien).FirstOrDefault(t => t.ID == maTV);
                        if (tv != null && tv.GoiThanhVien != null)
                        {
                            DateTime mocThoiGian = (tv.NgayHetHan > DateTime.Now)
                         ? tv.NgayHetHan
                         : DateTime.Now; ;

                            tv.NgayHetHan = mocThoiGian.AddMonths(tv.GoiThanhVien.SoThangHieuLuc);
                            context.ThanhVien.Update(tv);
                        }
                    }
                    else if (loaiDuocChon == 2 || loaiDuocChon == 3) // Đóng bồi thường -> Xóa nợ sách hỏng/mất
                    {
                        int status = (loaiDuocChon == 2) ? 3 : 2;
                        var dsViPham = context.ChiTietPhieuMuon.Where(ct => ct.PhieuMuon.ThanhVienID == maTV && ct.TrangThaiTra == status && ct.TienPhat > 0).ToList();
                        foreach (var ct in dsViPham) ct.TienPhat = 0;
                    }
                    // =======================================================

                    // 3. LƯU XUỐNG SQL
                    context.SaveChanges();
                    MessageBox.Show("Đã lưu phiếu thu và tự động cập nhật hệ thống thành công!", "Thông báo");
                }
                else // TRƯỜNG HỢP CẬP NHẬT (SỬA PHIẾU THU)
                {
                    PhieuThu pt = context.PhieuThu.Find(id);
                    if (pt != null)
                    {
                        pt.ThanhVienID = (int)cboThanhVien.SelectedValue;
                        pt.SoTienThu = numSoTienThu.Value;
                        pt.NgayThu = dtpNgayThu.Value;
                        pt.LoaiThu = cboLoaiThu.SelectedIndex;
                        pt.LyDoThu = txtLyDo.Text;

                        context.PhieuThu.Update(pt);
                        context.SaveChanges();
                        MessageBox.Show("Đã cập nhật phiếu thu thành công!", "Thông báo");
                    }
                }

                // Gọi lại hàm Load để F5 danh sách
                frmPhieuThu_Load(sender, e);
                BatTatChucNang(false);
                xuLyThem = false;
            }
        }

        private void cboLoaiThu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboThanhVien.SelectedValue == null) return;

            // Ép kiểu ID thành viên an toàn
            int maTV;
            if (!int.TryParse(cboThanhVien.SelectedValue.ToString(), out maTV)) return;

            int loaiDuocChon = cboLoaiThu.SelectedIndex;

            using (var db = new QLTVContext())
            {
                // Reset lại ô số tiền và lý do để không bị dính dữ liệu cũ khi đổi qua lại giữa các loại
                numSoTienThu.Value = 0;
                txtLyDo.Clear();

                // -------------------------------------------------------------
                // TRƯỜNG HỢP 0: THU TIỀN PHẠT TRỄ HẠN
                // -------------------------------------------------------------
                if (loaiDuocChon == 0)
                {
                    // Chỉ lấy những cuốn sách "Trả bình thường" (TrangThaiTra = 1) nhưng bị trễ (TienPhat > 0)
                    var tongTienPhat = db.ChiTietPhieuMuon
                        .Where(ct => ct.PhieuMuon.ThanhVienID == maTV && ct.TrangThaiTra == 1 && ct.TienPhat > 0)
                        .Sum(ct => (decimal?)ct.TienPhat) ?? 0;

                    numSoTienThu.Value = tongTienPhat;

                    if (tongTienPhat > 0)
                        txtLyDo.Text = "Thu tiền phạt trả sách muộn.";
                    else
                        txtLyDo.Text = "Thành viên này không nợ tiền phạt trễ hạn.";
                }

                // -------------------------------------------------------------
                // TRƯỜNG HỢP 1: LỆ PHÍ GIA HẠN THẺ
                // -------------------------------------------------------------
                else if (loaiDuocChon == 1)
                {
                    // Tìm thành viên đang chọn và kéo luôn thông tin Gói của họ ra
                    var thanhVien = db.ThanhVien
                                      .Include(tv => tv.GoiThanhVien)
                                      .FirstOrDefault(tv => tv.ID == maTV);

                    if (thanhVien != null && thanhVien.GoiThanhVien != null)
                    {
                        // Hút giá tiền của gói lên ô số tiền
                        numSoTienThu.Value = thanhVien.GoiThanhVien.GiaTien;
                        txtLyDo.Text = $"Thu phí gia hạn: {thanhVien.GoiThanhVien.TenGoi}";
                    }
                    else
                    {
                        txtLyDo.Text = "Thành viên này chưa có gói thành viên hoặc bị lỗi dữ liệu.";
                    }
                }

                // -------------------------------------------------------------
                // TRƯỜNG HỢP 2 & 3: BỒI THƯỜNG HỎNG SÁCH & MẤT SÁCH
                // -------------------------------------------------------------
                else if (loaiDuocChon == 2 || loaiDuocChon == 3)
                {
                    // Mapping ID ComboBox của Luke: Index 2 (Hỏng) -> Status 3. Index 3 (Mất) -> Status 2.
                    int status = (loaiDuocChon == 2) ? 3 : 2;

                    // Dùng .Include(ct => ct.Sach) để không bị lỗi Null khi lấy Tên sách
                    var dsSachViPham = db.ChiTietPhieuMuon
                        .Include(ct => ct.Sach)
                        .Where(ct => ct.PhieuMuon.ThanhVienID == maTV && ct.TrangThaiTra == status && ct.TienPhat > 0)
                        .ToList();

                    if (dsSachViPham.Count > 0)
                    {
                        // Cộng tổng tiền bồi thường
                        numSoTienThu.Value = dsSachViPham.Sum(ct => ct.TienPhat);

                        // Lấy danh sách tên sách nối lại với nhau bằng dấu phẩy
                        string tenSach = string.Join(", ", dsSachViPham.Select(s => s.Sach.TenSach));
                        txtLyDo.Text = (loaiDuocChon == 3 ? "Bồi thường mất sách: " : "Bồi thường hư hỏng sách: ") + tenSach;
                    }
                    else
                    {
                        txtLyDo.Text = (loaiDuocChon == 3 ? "Thành viên không nợ tiền mất sách." : "Thành viên không nợ tiền hư hỏng sách.");
                    }
                }
            }
        }

        private void cboThanhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (xuLyThem)
            {
                cboLoaiThu_SelectedIndexChanged(sender, e);
            }
        }

        private void dgvPhieuThu_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            DataGridView dgv = sender as DataGridView;

            // LƯU Ý: Luke thay chữ "colLoaiThu" bằng đúng cái Tên (Name) của cột Loại thu trên lưới của bạn nhé!
            string tenCotLoaiThu = "colLoaiThu";

            if (dgv.Columns[e.ColumnIndex].Name == tenCotLoaiThu && e.Value != null)
            {
                string strValue = e.Value.ToString();

                // Dịch số thành chữ y như cái ComboBox
                switch (strValue)
                {
                    case "0": e.Value = "Thu tiền phạt"; break;
                    case "1": e.Value = "Lệ phí thẻ"; break; // Dùng chung cho Đăng ký/Gia hạn/Nâng cấp
                    case "2": e.Value = "Bồi thường hỏng sách"; break;
                    case "3": e.Value = "Bồi thường mất sách"; break;
                }

                // Báo cho lưới biết là "Tôi đã format xong rồi, hiển thị chữ lên đi"
                e.FormattingApplied = true;
            }
        }
    }
}
