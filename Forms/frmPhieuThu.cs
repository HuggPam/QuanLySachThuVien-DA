using ClosedXML.Excel;
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
    public partial class frmPhieuThu : Form
    {
        QLTVContext context = new QLTVContext();
        bool xuLyThem = false;
        int id;
        bool dangDoDuLieu = false;
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
            txtNhanVien.Text = Program.TenNhanVienDangNhap;
            txtNhanVien.ReadOnly = true;

            dgvPhieuThu.AutoGenerateColumns = false;

            var ds = context.PhieuThu.Select(p => new DanhSachPhieuThu
            {
                ID = p.ID,
                TenNhanVien = p.NhanVien.TenNhanVien,
                TenThanhVien = p.ThanhVien.TenThanhVien,
                NgayThu = p.NgayThu,
                LoaiThu = p.LoaiThu,
                SoTienThu = p.SoTienThu,
                LyDoThu = p.LyDoThu,
            }).OrderByDescending(x => x.NgayThu).ToList();

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
                var ds = db.ThanhVien.Select(t => new { t.ID, t.TenThanhVien }).ToList();

                cboThanhVien.DataSource = ds;
                cboThanhVien.DisplayMember = "TenThanhVien";
                cboThanhVien.ValueMember = "ID";
                cboThanhVien.SelectedIndex = -1;
            }

        }
        private void LayLoaiThuVaoComboBox()
        {
            var loaiThu = new[] {
                new { ID = 0, Ten = "Thu tiền phạt" },
                new { ID = 1, Ten = "Lệ phí gia hạn thẻ" },
                new { ID = 2, Ten = "Bồi thường hỏng sách" },
                new { ID = 3, Ten = "Bồi thường mất sách" }
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
            else if (numSoTienThu.Value <= 0)
            {
                MessageBox.Show("Số tiền thu không được bằng 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numSoTienThu.Focus();
                return;
            }
            else
            {
                if (xuLyThem) // Thêm phiếu thu mới
                {
                    int maTV = (int)cboThanhVien.SelectedValue;
                    int loaiDuocChon = cboLoaiThu.SelectedIndex;

                    PhieuThu pt = new PhieuThu();
                    pt.ThanhVienID = maTV;
                    pt.NhanVienID = Program.MaNhanVienDangNhap;
                    pt.SoTienThu = numSoTienThu.Value;
                    pt.NgayThu = dtpNgayThu.Value;
                    pt.LoaiThu = loaiDuocChon;
                    pt.LyDoThu = txtLyDo.Text;
                    context.PhieuThu.Add(pt);

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
                    else if (loaiDuocChon == 2 || loaiDuocChon == 3)
                    {
                        int status = (loaiDuocChon == 2) ? 3 : 2;
                        var dsViPham = context.ChiTietPhieuMuon
                            .Where(ct => ct.PhieuMuon.ThanhVienID == maTV && ct.TrangThaiTra == status && ct.TienPhat > 0)
                            .ToList();

                        foreach (var ct in dsViPham) ct.TienPhat = 0;
                    }

                    context.SaveChanges();
                    MessageBox.Show("Đã lưu phiếu thu và tự động cập nhật hệ thống thành công!", "Thông báo");
                }
                else // Sửa phiếu thu
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

                frmPhieuThu_Load(sender, e);
                BatTatChucNang(false);
                xuLyThem = false;
            }
        }

        private void cboLoaiThu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dangDoDuLieu) return;
            if (cboThanhVien.SelectedValue == null) return;

            int maTV;
            if (!int.TryParse(cboThanhVien.SelectedValue.ToString(), out maTV)) return;

            int loaiDuocChon = cboLoaiThu.SelectedIndex;

            using (var db = new QLTVContext())
            {
                numSoTienThu.Value = 0;
                txtLyDo.Clear();

                // 0 là thu tiền phạt trễ hạn, 1 là gia hạn thẻ, 2 là bồi thường hỏng sách, 3 là bồi thường mất sách
                if (loaiDuocChon == 0)
                {
                    // Chỉ lấy những cuốn sách "Trả bình thường" (TrangThaiTra = 1) nhưng bị trễ (TienPhat > 0)
                    var tongTienPhat = db.ChiTietPhieuMuon.Where(ct => ct.PhieuMuon.ThanhVienID == maTV && ct.TrangThaiTra == 1 && ct.TienPhat > 0).Sum(ct => (decimal?)ct.TienPhat) ?? 0;

                    numSoTienThu.Value = tongTienPhat;

                    if (tongTienPhat > 0)
                        txtLyDo.Text = "Thu tiền phạt trả sách muộn.";
                    else
                        txtLyDo.Text = "Thành viên này không nợ tiền phạt trễ hạn.";
                }
                else if (loaiDuocChon == 1)
                {
                    var thanhVien = db.ThanhVien.Include(tv => tv.GoiThanhVien).FirstOrDefault(tv => tv.ID == maTV);
                    if (thanhVien != null && thanhVien.GoiThanhVien != null)
                    {
                        numSoTienThu.Value = thanhVien.GoiThanhVien.GiaTien;
                        txtLyDo.Text = $"Thu phí gia hạn: {thanhVien.GoiThanhVien.TenGoi}";
                    }
                    else
                    {
                        txtLyDo.Text = "Thành viên này chưa có gói thành viên hoặc bị lỗi dữ liệu.";
                    }
                }

                else if (loaiDuocChon == 2 || loaiDuocChon == 3)
                {
                    int status = (loaiDuocChon == 2) ? 3 : 2;

                    var dsSachViPham = db.ChiTietPhieuMuon.Include(ct => ct.Sach).Where(ct => ct.PhieuMuon.ThanhVienID == maTV && ct.TrangThaiTra == status && ct.TienPhat > 0).ToList();

                    if (dsSachViPham.Count > 0)
                    {
                        numSoTienThu.Value = dsSachViPham.Sum(ct => ct.TienPhat);

                        string tenSach = string.Join(", ", dsSachViPham.Select(s => s.Sach.TenSach));
                        txtLyDo.Text = (loaiDuocChon == 3 ? "Bồi thường mất sách: " : "Bồi thường hỏng sách: ") + tenSach;
                    }
                    else
                    {
                        txtLyDo.Text = (loaiDuocChon == 3 ? "Thành viên không nợ tiền mất sách." : "Thành viên không nợ tiền hỏng sách.");
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


            string tenCotLoaiThu = "colLoaiThu";

            if (dgv.Columns[e.ColumnIndex].Name == tenCotLoaiThu && e.Value != null)
            {
                string strValue = e.Value.ToString();

                // Doi so thanh chu
                switch (strValue)
                {
                    case "0": e.Value = "Thu tiền phạt"; break;
                    case "1": e.Value = "Lệ phí thẻ"; break;
                    case "2": e.Value = "Bồi thường hỏng sách"; break;
                    case "3": e.Value = "Bồi thường mất sách"; break;
                }
                e.FormattingApplied = true;
            }
        }

        private void txtNhanVien_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dgvPhieuThu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && !xuLyThem)
            {
                dangDoDuLieu = true;

                id = Convert.ToInt32(dgvPhieuThu.Rows[e.RowIndex].Cells[0].Value);

                PhieuThu pt = context.PhieuThu.Find(id);
                if (pt != null)
                {
                    cboThanhVien.SelectedValue = pt.ThanhVienID;
                    cboLoaiThu.SelectedIndex = pt.LoaiThu;
                    numSoTienThu.Value = pt.SoTienThu;
                    dtpNgayThu.Value = pt.NgayThu;
                    txtLyDo.Text = pt.LyDoThu;
                }

                dangDoDuLieu = false;
            }
        }

        private void btnInPhieuThu_Click(object sender, EventArgs e)
        {
            if (dgvPhieuThu.CurrentRow != null)
            {
                int idPhieu = Convert.ToInt32(dgvPhieuThu.CurrentRow.Cells["colID"].Value);
                using (frmInPhieuThu fIn = new frmInPhieuThu(idPhieu))
                {
                    fIn.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một phiếu mượn trên bảng để in!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất danh sách Phiếu thu ra tập tin Excel";
            saveFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";
            saveFileDialog.FileName = "DanhSach_PhieuThu_" + DateTime.Now.ToString("dd_MM_yyyy") + ".xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    table.Columns.AddRange(new DataColumn[] {
                new DataColumn("Mã Phiếu", typeof(int)),
                new DataColumn("Nhân viên lập", typeof(string)),
                new DataColumn("Thành viên nộp", typeof(string)),
                new DataColumn("Ngày thu", typeof(string)),
                new DataColumn("Loại thu", typeof(string)),
                new DataColumn("Số tiền thu", typeof(decimal)),
                new DataColumn("Lý do thu", typeof(string))
            });

                    using (var db = new QLTVContext())
                    {
                        var dsPhieuThu = db.PhieuThu
                                           .Include(p => p.NhanVien)
                                           .Include(p => p.ThanhVien)
                                           .OrderByDescending(p => p.NgayThu)
                                           .ToList();

                        if (dsPhieuThu != null && dsPhieuThu.Count > 0)
                        {
                            foreach (var pt in dsPhieuThu)
                            {
                                string tenLoaiThu = "";
                                switch (pt.LoaiThu)
                                {
                                    case 0: tenLoaiThu = "Thu tiền phạt"; break;
                                    case 1: tenLoaiThu = "Lệ phí thẻ"; break;
                                    case 2: tenLoaiThu = "Bồi thường hỏng sách"; break;
                                    case 3: tenLoaiThu = "Bồi thường mất sách"; break;
                                }

                                table.Rows.Add(
                                    pt.ID,
                                    pt.NhanVien != null ? pt.NhanVien.TenNhanVien : "Không rõ",
                                    pt.ThanhVien != null ? pt.ThanhVien.TenThanhVien : "Không rõ",
                                    pt.NgayThu.ToString("dd/MM/yyyy HH:mm"),
                                    tenLoaiThu,
                                    pt.SoTienThu,
                                    pt.LyDoThu
                                );
                            }
                        }
                        using (XLWorkbook wb = new XLWorkbook())
                        {
                            var sheet = wb.Worksheets.Add(table, "PhieuThu");
                            var headerRow = sheet.Row(1);
                            headerRow.Style.Font.Bold = true;
                            headerRow.Style.Fill.BackgroundColor = XLColor.LightSalmon;
                            sheet.Column(6).Style.NumberFormat.Format = "#,##0";
                            sheet.Columns().AdjustToContents();
                            wb.SaveAs(saveFileDialog.FileName);
                            MessageBox.Show("Đã xuất danh sách Phiếu thu ra tập tin Excel thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    string errorMsg = ex.Message;
                    if (ex.InnerException != null) errorMsg += "\nChi tiết: " + ex.InnerException.Message;
                    MessageBox.Show("Lỗi khi xuất file Excel:\n" + errorMsg, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim().ToLower();
            List<int> loaiThuHopLe = new List<int>();

            if ("thu tiền phạt".Contains(tuKhoa)) loaiThuHopLe.Add(0);
            if ("lệ phí gia hạn thẻ".Contains(tuKhoa) || "lệ phí thẻ".Contains(tuKhoa)) loaiThuHopLe.Add(1);
            if ("bồi thường hỏng sách".Contains(tuKhoa) || "hỏng".Contains(tuKhoa)) loaiThuHopLe.Add(2);
            if ("bồi thường mất sách".Contains(tuKhoa) || "mất".Contains(tuKhoa)) loaiThuHopLe.Add(3);

            using (var db = new QLTVContext())
            {
                var query = db.PhieuThu
                              .Include(p => p.NhanVien)
                              .Include(p => p.ThanhVien)
                              .AsQueryable();

                if (!string.IsNullOrEmpty(tuKhoa))
                {
                    query = query.Where(p =>
                        (p.NhanVien != null && p.NhanVien.TenNhanVien.ToLower().Contains(tuKhoa)) ||
                        (p.ThanhVien != null && p.ThanhVien.TenThanhVien.ToLower().Contains(tuKhoa)) ||
                        loaiThuHopLe.Contains(p.LoaiThu)
                    );
                }

                var ketQuaTimKiem = query.Select(p => new DanhSachPhieuThu
                {
                    ID = p.ID,
                    TenNhanVien = p.NhanVien.TenNhanVien,
                    TenThanhVien = p.ThanhVien.TenThanhVien,
                    NgayThu = p.NgayThu,
                    LoaiThu = p.LoaiThu,
                    SoTienThu = p.SoTienThu,
                    LyDoThu = p.LyDoThu
                }).OrderByDescending(x => x.NgayThu).ToList();

                dgvPhieuThu.DataSource = ketQuaTimKiem;

                if (ketQuaTimKiem.Count == 0 && !string.IsNullOrEmpty(tuKhoa))
                {
                    MessageBox.Show("Không tìm thấy phiếu thu nào khớp với từ khóa!", "Kết quả tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
