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
            TuDongCapNhatQuaHan();
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
            if (MessageBox.Show("Xác nhận xóa phiếu mượn này?\n\nLưu ý: Các sách chưa trả trong phiếu này sẽ được tự động hoàn lại vào kho.", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    id = Convert.ToInt32(dgvPhieuMuon.CurrentRow.Cells["colID"].Value.ToString());
                    var pm = context.PhieuMuon.Include(p => p.ChiTietPhieuMuon).FirstOrDefault(p => p.ID == id);
                    if (pm != null)
                    {
                        foreach (var ct in pm.ChiTietPhieuMuon)
                        {
                            if (ct.TrangThaiTra == 0)
                            {
                                var sach = context.Sach.Find(ct.SachID);
                                if (sach != null)
                                {
                                    sach.SoLuong += 1;
                                }
                            }
                        }
                        context.ChiTietPhieuMuon.RemoveRange(pm.ChiTietPhieuMuon);
                        context.PhieuMuon.Remove(pm);
                        context.SaveChanges();
                        MessageBox.Show("Đã xóa phiếu mượn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmPhieuMuon_Load(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

        private void TuDongCapNhatQuaHan()
        {
            using (var db = new QLTVContext())
            {
                var phieuDangMuon = db.PhieuMuon
                                      .Include(p => p.ChiTietPhieuMuon)
                                      .Where(p => p.TrangThai == 0).ToList();

                bool coThayDoi = false;
                foreach (var pm in phieuDangMuon)
                {
                    bool isQuaHan = pm.ChiTietPhieuMuon.Any(ct => ct.TrangThaiTra == 0 && DateTime.Now.Date > ct.HanTra.Date);
                    if (isQuaHan)
                    {
                        pm.TrangThai = 2;
                        coThayDoi = true;
                    }
                }
                if (coThayDoi)
                {
                    db.SaveChanges();
                }
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất danh sách Phiếu mượn ra tập tin Excel";
            saveFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";
            saveFileDialog.FileName = "DanhSach_PhieuMuon_" + DateTime.Now.ToString("dd_MM_yyyy") + ".xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    table.Columns.AddRange(new DataColumn[] {
                new DataColumn("Mã Phiếu", typeof(int)),
                new DataColumn("Người lập phiếu (Thủ thư)", typeof(string)),
                new DataColumn("Người mượn (Thành viên)", typeof(string)),
                new DataColumn("Ngày mượn", typeof(string)),
                new DataColumn("Trạng thái", typeof(string))
            });

                    using (var db = new QLTVContext())
                    {
                        var dsPhieuMuon = db.PhieuMuon
                                            .Include(p => p.NhanVien)
                                            .Include(p => p.ThanhVien)
                                            .ToList();

                        if (dsPhieuMuon != null && dsPhieuMuon.Count > 0)
                        {
                            foreach (var pm in dsPhieuMuon)
                            {
                                string tenTrangThai = "";
                                switch (pm.TrangThai)
                                {
                                    case 0: tenTrangThai = "Đang mượn"; break;
                                    case 1: tenTrangThai = "Đã hoàn thành"; break;
                                    case 2: tenTrangThai = "Quá hạn"; break;
                                }

                                table.Rows.Add(
                                    pm.ID,
                                    pm.NhanVien != null ? pm.NhanVien.TenNhanVien : "Không rõ",
                                    pm.ThanhVien != null ? pm.ThanhVien.TenThanhVien : "Không rõ",
                                    pm.NgayMuon.ToString("dd/MM/yyyy HH:mm"), 
                                    tenTrangThai
                                );
                            }
                        }
                        using (XLWorkbook wb = new XLWorkbook())
                        {
                            var sheet = wb.Worksheets.Add(table, "PhieuMuon");
                            var headerRow = sheet.Row(1);
                            headerRow.Style.Font.Bold = true;
                            headerRow.Style.Fill.BackgroundColor = XLColor.Khaki;
                            sheet.Columns().AdjustToContents();
                            wb.SaveAs(saveFileDialog.FileName);
                            MessageBox.Show("Đã xuất danh sách Phiếu mượn ra tập tin Excel thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnTimKIem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim().ToLower();
            List<int> trangThaiHopLe = new List<int>();

            if ("đang mượn".Contains(tuKhoa)) trangThaiHopLe.Add(0);
            if ("đã hoàn thành".Contains(tuKhoa) || "hoàn thành".Contains(tuKhoa)) trangThaiHopLe.Add(1);
            if ("quá hạn".Contains(tuKhoa)) trangThaiHopLe.Add(2);

            using (var db = new QLTVContext())
            {
                var query = db.PhieuMuon
                              .Include(p => p.NhanVien)
                              .Include(p => p.ThanhVien)
                              .AsQueryable();

                if (!string.IsNullOrEmpty(tuKhoa))
                {
                    query = query.Where(p =>
                        (p.NhanVien != null && p.NhanVien.TenNhanVien.ToLower().Contains(tuKhoa)) ||
                        (p.ThanhVien != null && p.ThanhVien.TenThanhVien.ToLower().Contains(tuKhoa)) ||
                        trangThaiHopLe.Contains(p.TrangThai) 
                    );
                }

                var ketQuaTimKiem = query.Select(p => new DanhSachPhieuMuon
                {
                    ID = p.ID,
                    NgayMuon = p.NgayMuon,
                    TenNhanVien = p.NhanVien != null ? p.NhanVien.TenNhanVien : "",
                    TenThanhVien = p.ThanhVien != null ? p.ThanhVien.TenThanhVien : "",
                    TrangThai = p.TrangThai,
                    ChiTiet = "Xem chi tiết"
                }).OrderByDescending(x => x.NgayMuon).ToList();

                dgvPhieuMuon.DataSource = ketQuaTimKiem;

                if (ketQuaTimKiem.Count == 0 && !string.IsNullOrEmpty(tuKhoa))
                {
                    MessageBox.Show("Không tìm thấy kết quả nào khớp với từ khóa!", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
