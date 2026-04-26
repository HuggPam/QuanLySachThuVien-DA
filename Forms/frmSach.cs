using ClosedXML.Excel;
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
    public partial class frmSach : Form
    {
        QLTVContext context = new QLTVContext();
        bool xuLyThem = false;
        int id;
        string imagesFolder = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\..\Images"));
        public frmSach()
        {
            InitializeComponent();
        }

        private void frmSach_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);

            numNamXuatBan.Maximum = DateTime.Now.Year;
            numNamXuatBan.Minimum = 1000;

            LayTheLoaiVaoComboBox();
            LayTacGiaVaoComboBox();
            LayNhaXuatBanVaoComboBox();
            dgvSach.AutoGenerateColumns = false;
            List<DanhSachSach> danhSachSach = new List<DanhSachSach>();
            danhSachSach = context.Sach.Select(s => new DanhSachSach

            {
                ID = s.ID,
                TenSach = s.TenSach,
                NamXuatBan = s.NamXuatBan,
                SoLuong = s.SoLuong,
                DonGia = s.DonGia,
                HinhAnh = s.HinhAnh,
                TheLoaiID = s.TheLoaiID,
                TenTheLoai = s.TheLoai.TenTheLoai,
                TacGiaID = s.TacGiaID,
                TenTacGia = s.TacGia.TenTacGia,
                NhaXuatBanID = s.NhaXuatBanID,
                TenNhaXuatBan = s.NhaXuatBan.TenNhaXuatBan
            }).ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = danhSachSach;
            cboTheLoai.DataBindings.Clear();
            cboTheLoai.DataBindings.Add("SelectedValue", bindingSource, "TheLoaiID", false, DataSourceUpdateMode.Never);
            cboTacGia.DataBindings.Clear();
            cboTacGia.DataBindings.Add("SelectedValue", bindingSource, "TacGiaID", false, DataSourceUpdateMode.Never);
            cboNhaXuatBan.DataBindings.Clear();
            cboNhaXuatBan.DataBindings.Add("SelectedValue", bindingSource, "NhaXuatBanID", false, DataSourceUpdateMode.Never);
            txtTenSach.DataBindings.Clear();
            txtTenSach.DataBindings.Add("Text", bindingSource, "TenSach", false, DataSourceUpdateMode.Never);
            numNamXuatBan.DataBindings.Clear();
            numNamXuatBan.DataBindings.Add("Value", bindingSource, "NamXuatBan", false, DataSourceUpdateMode.Never);
            numSoLuong.DataBindings.Clear();
            numSoLuong.DataBindings.Add("Value", bindingSource, "SoLuong", false, DataSourceUpdateMode.Never);
            numDonGia.DataBindings.Clear();
            numDonGia.DataBindings.Add("Value", bindingSource, "DonGia", false, DataSourceUpdateMode.Never);
            picHinhAnh.DataBindings.Clear();
            Binding hinhAnhBinding = new Binding("ImageLocation", bindingSource, "HinhAnh", true, DataSourceUpdateMode.Never);
            hinhAnhBinding.Format += (s, ev) =>
            {
                if (ev.Value != null && !string.IsNullOrWhiteSpace(ev.Value.ToString()))
                {
                    ev.Value = Path.Combine(imagesFolder, ev.Value.ToString());
                }
                else
                {
                    ev.Value = null;
                }
            };
            picHinhAnh.DataBindings.Add(hinhAnhBinding);

            dgvSach.DataSource = bindingSource;
        }
        private void BatTatChucNang(bool giaTri)
        {
            txtTenSach.Enabled = giaTri;
            btnLuu.Enabled = giaTri;
            btnHuy.Enabled = giaTri;
            cboNhaXuatBan.Enabled = giaTri;
            cboTacGia.Enabled = giaTri;
            cboTheLoai.Enabled = giaTri;
            numSoLuong.Enabled = giaTri;
            numDonGia.Enabled = giaTri;
            numNamXuatBan.Enabled = giaTri;
            btnDoiAnh.Enabled = giaTri;
            //picHinhAnh.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnTimKiem.Enabled = !giaTri;
            btnNhap.Enabled = !giaTri;
            btnXuat.Enabled = !giaTri;
        }

        public void LayTheLoaiVaoComboBox()
        {
            cboTheLoai.DataSource = context.TheLoai.ToList();
            cboTheLoai.DisplayMember = "TenTheLoai";
            cboTheLoai.ValueMember = "ID";
        }

        public void LayTacGiaVaoComboBox()
        {
            cboTacGia.DataSource = context.TacGia.ToList();
            cboTacGia.DisplayMember = "TenTacGia";
            cboTacGia.ValueMember = "ID";
        }

        public void LayNhaXuatBanVaoComboBox()
        {
            cboNhaXuatBan.DataSource = context.NhaXuatBan.ToList();
            cboNhaXuatBan.DisplayMember = "TenNhaXuatBan";
            cboNhaXuatBan.ValueMember = "ID";
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmSach_Load(sender, e);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            txtTenSach.Clear();
            picHinhAnh.Image = null;
            numNamXuatBan.Value = DateTime.Now.Year;
            numSoLuong.Value = 0;
            numDonGia.Value = 0;
            cboTheLoai.SelectedIndex = 0;
            cboTacGia.SelectedIndex = 0;
            cboNhaXuatBan.SelectedIndex = 0;
            txtTenSach.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa " + txtTenSach.Text + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dgvSach.CurrentRow.Cells["colID"].Value.ToString());
                Sach s = context.Sach.Find(id);
                if (s != null)
                {
                    context.Sach.Remove(s);
                }
                context.SaveChanges();
                frmSach_Load(sender, e);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboTheLoai.Text))
            {
                MessageBox.Show("Vui lòng chọn thể loại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboTheLoai.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(cboTacGia.Text))
            {
                MessageBox.Show("Vui lòng chọn tác giả.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboTacGia.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(cboNhaXuatBan.Text))
            {
                MessageBox.Show("Vui lòng chọn nhà xuất bản.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboNhaXuatBan.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(txtTenSach.Text))
            {
                MessageBox.Show("Vui lòng nhập tên sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenSach.Focus();
                return;
            }
            else if (numSoLuong.Value <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numSoLuong.Focus();
                return;
            }
            else if (numDonGia.Value <= 0)
            {
                MessageBox.Show("Đơn giá sách phải lớn hơn 0.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numDonGia.Focus();
                return;
            }
            else
            {
                string tenHinh = null;
                if (picHinhAnh.ImageLocation != null)
                {
                    tenHinh = Path.GetFileName(picHinhAnh.ImageLocation);
                }
                if (xuLyThem)
                {
                    Sach s = new Sach();
                    s.TenSach = txtTenSach.Text.Trim();
                    s.NamXuatBan = (int)numNamXuatBan.Value;
                    s.SoLuong = (int)numSoLuong.Value;
                    s.DonGia = numDonGia.Value;
                    s.TheLoaiID = Convert.ToInt32(cboTheLoai.SelectedValue);
                    s.TacGiaID = Convert.ToInt32(cboTacGia.SelectedValue);
                    s.NhaXuatBanID = Convert.ToInt32(cboNhaXuatBan.SelectedValue);
                    s.HinhAnh = tenHinh;
                    context.Sach.Add(s);

                    context.SaveChanges();
                    MessageBox.Show("Đã thêm dữ liệu thành công!", "Thông báo");
                }
                else
                {
                    Sach s = context.Sach.Find(id);
                    if (s != null)
                    {
                        s.TenSach = txtTenSach.Text.Trim();
                        s.NamXuatBan = (int)numNamXuatBan.Value;
                        s.SoLuong = (int)numSoLuong.Value;
                        s.DonGia = numDonGia.Value;
                        s.TheLoaiID = Convert.ToInt32(cboTheLoai.SelectedValue);
                        s.TacGiaID = Convert.ToInt32(cboTacGia.SelectedValue);
                        s.NhaXuatBanID = Convert.ToInt32(cboNhaXuatBan.SelectedValue);
                        s.HinhAnh = tenHinh;

                        context.SaveChanges();
                        MessageBox.Show("Đã cập nhật dữ liệu thành công!", "Thông báo");
                    }
                }
                frmSach_Load(sender, e);
            }
        }

        private void btnDoiAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn ảnh bìa sách";
            openFileDialog.Filter = "Tập tin hình ảnh|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string ext = Path.GetExtension(openFileDialog.FileName);
                string newFileName = "sach_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ext;
                string fileSavePath = Path.Combine(imagesFolder, newFileName);
                File.Copy(openFileDialog.FileName, fileSavePath, true);
                picHinhAnh.ImageLocation = fileSavePath;
            }

        }

        private void picHinhAnh_Click(object sender, EventArgs e)
        {
            if (picHinhAnh.Image != null)
            {
                this.Opacity = 0.3;
                frmXemAnh formXem = new frmXemAnh(picHinhAnh.Image);
                formXem.ShowDialog();
                this.Opacity = 1.0;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dgvSach.CurrentRow.Cells["colID"].Value.ToString());
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Nhập dữ liệu Sách từ tập tin Excel";
            openFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    using (XLWorkbook workbook = new XLWorkbook(openFileDialog.FileName))
                    {
                        IXLWorksheet worksheet = workbook.Worksheet(1);
                        bool firstRow = true;
                        string readRange = "1:1";

                        foreach (IXLRow row in worksheet.RowsUsed())
                        {
                            if (firstRow)
                            {
                                readRange = string.Format("{0}:{1}", 1, row.LastCellUsed().Address.ColumnNumber);
                                foreach (IXLCell cell in row.Cells(readRange))
                                {
                                    table.Columns.Add(cell.Value.ToString().Trim());
                                }
                                firstRow = false;
                            }
                            else
                            {
                                table.Rows.Add();
                                int cellIndex = 0;
                                foreach (IXLCell cell in row.Cells(readRange))
                                {
                                    table.Rows[table.Rows.Count - 1][cellIndex] = cell.Value.ToString();
                                    cellIndex++;
                                }
                            }
                        }

                        if (table.Rows.Count > 0)
                        {
                            using (var db = new QLTVContext())
                            {
                                int soSachThemMoi = 0;

                                foreach (DataRow r in table.Rows)
                                {
                                    string tenSach = r["TenSach"].ToString().Trim();
                                    string tenTacGia = r["TenTacGia"].ToString().Trim();
                                    string tenNhaXuatBan = r["TenNhaXuatBan"].ToString().Trim();
                                    string tenTheLoai = r["TenTheLoai"].ToString().Trim();
                                    int.TryParse(r["SoLuong"].ToString(), out int soLuong);
                                    decimal.TryParse(r["DonGia"].ToString(), out decimal donGia);
                                    int.TryParse(r["NamXuatBan"].ToString(), out int namXB);

                                    if (string.IsNullOrEmpty(tenSach)) continue;

                                    var tacGia = db.TacGia.FirstOrDefault(t => t.TenTacGia.ToLower() == tenTacGia.ToLower());
                                    if (tacGia == null)
                                    {
                                        tacGia = new TacGia
                                        {
                                            TenTacGia = tenTacGia,
                                            GhiChu = ""
                                        };
                                        db.TacGia.Add(tacGia);
                                        db.SaveChanges();
                                    }
                                    var nxb = db.NhaXuatBan.FirstOrDefault(n => n.TenNhaXuatBan.ToLower() == tenNhaXuatBan.ToLower());
                                    if (nxb == null)
                                    {
                                        nxb = new NhaXuatBan { TenNhaXuatBan = tenNhaXuatBan };
                                        db.NhaXuatBan.Add(nxb);
                                        db.SaveChanges();
                                    }

                                    var theLoai = db.TheLoai.FirstOrDefault(tl => tl.TenTheLoai.ToLower() == tenTheLoai.ToLower());
                                    if (theLoai == null)
                                    {
                                        theLoai = new TheLoai { TenTheLoai = tenTheLoai };
                                        db.TheLoai.Add(theLoai);
                                        db.SaveChanges();
                                    }

                                    var sachDb = db.Sach.FirstOrDefault(s => s.TenSach.ToLower() == tenSach.ToLower() && s.TacGiaID == tacGia.ID);
                                    if (sachDb != null)
                                    {
                                        sachDb.SoLuong += soLuong;
                                        db.Sach.Update(sachDb);
                                    }
                                    else
                                    {
                                        Sach sachMoi = new Sach
                                        {
                                            TenSach = tenSach,
                                            TacGiaID = tacGia.ID,
                                            NhaXuatBanID = nxb.ID,
                                            TheLoaiID = theLoai.ID,
                                            SoLuong = soLuong,
                                            DonGia = donGia,
                                            NamXuatBan = namXB,
                                            HinhAnh = ""
                                        };
                                        db.Sach.Add(sachMoi);
                                        soSachThemMoi++;
                                    }
                                }

                                db.SaveChanges();
                                MessageBox.Show($"Đã xử lý {table.Rows.Count} dòng. Thêm mới {soSachThemMoi} đầu sách.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }

                        if (firstRow)
                            MessageBox.Show("Tập tin Excel rỗng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex)
                {
                    string errorMsg = ex.Message;
                    if (ex.InnerException != null) errorMsg += "\n" + ex.InnerException.Message;

                    MessageBox.Show("Lỗi khi đọc file Excel:\n" + errorMsg, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnTaiFileMau_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "MauNhapSach.xlsx";
            saveFileDialog.Filter = "Excel Files|*.xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (var workbook = new XLWorkbook())
                    {
                        var worksheet = workbook.Worksheets.Add("Sheet1");
                        worksheet.Cell(1, 1).Value = "TenSach";
                        worksheet.Cell(1, 2).Value = "TenTheLoai";
                        worksheet.Cell(1, 3).Value = "TenTacGia";
                        worksheet.Cell(1, 4).Value = "TenNhaXuatBan";
                        worksheet.Cell(1, 5).Value = "NamXuatBan";
                        worksheet.Cell(1, 6).Value = "SoLuong";
                        worksheet.Cell(1, 7).Value = "DonGia";
                        worksheet.Cell(1, 8).Value = "HinhAnh";

                        var headerRange = worksheet.Range("A1:H1");
                        headerRange.Style.Font.Bold = true;
                        headerRange.Style.Fill.BackgroundColor = XLColor.LightGray;
                        worksheet.Columns().AdjustToContents();

                        workbook.SaveAs(saveFileDialog.FileName);
                        MessageBox.Show("Tải file mẫu thành công!", "Thông báo");
                    }
                }
                catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất dữ liệu Sách ra tập tin Excel";
            saveFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";
            // Đổi tên file mặc định cho ngầu và đúng chuẩn
            saveFileDialog.FileName = "DanhSach_Sach_" + DateTime.Now.ToString("dd_MM_yyyy") + ".xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    table.Columns.AddRange(new DataColumn[] {
                new DataColumn("ID", typeof(int)),
                new DataColumn("TenSach", typeof(string)),
                new DataColumn("TenTheLoai", typeof(string)),
                new DataColumn("TenTacGia", typeof(string)),
                new DataColumn("TenNhaXuatBan", typeof(string)),
                new DataColumn("NamXuatBan", typeof(int)),
                new DataColumn("SoLuong", typeof(int)),
                new DataColumn("DonGia", typeof(decimal)),
                new DataColumn("HinhAnh", typeof(string))
            });

                    using (var db = new QLTVContext())
                    {
                        var danhSachSach = db.Sach
                            .Include(s => s.TheLoai)
                            .Include(s => s.TacGia)
                            .Include(s => s.NhaXuatBan)
                            .ToList();

                        if (danhSachSach != null && danhSachSach.Count > 0)
                        {
                            foreach (var s in danhSachSach)
                            {
                                table.Rows.Add(
                                    s.ID,
                                    s.TenSach,
                                    s.TheLoai != null ? s.TheLoai.TenTheLoai : "",
                                    s.TacGia != null ? s.TacGia.TenTacGia : "",
                                    s.NhaXuatBan != null ? s.NhaXuatBan.TenNhaXuatBan : "",
                                    s.NamXuatBan,
                                    s.SoLuong,
                                    s.DonGia,
                                    s.HinhAnh ?? ""
                                );
                            }
                        }
                        using (XLWorkbook wb = new XLWorkbook())
                        {
                            var sheet = wb.Worksheets.Add(table, "DanhSachSach");
                            var headerRow = sheet.Row(1);
                            headerRow.Style.Font.Bold = true;
                            headerRow.Style.Fill.BackgroundColor = XLColor.LightBlue;
                            sheet.Columns().AdjustToContents();
                            wb.SaveAs(saveFileDialog.FileName);
                            MessageBox.Show("Đã xuất dữ liệu ra tập tin Excel thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xuất file Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim().ToLower();

            using (var db = new QLTVContext())
            {
                var query = db.Sach
                    .Include(s => s.TheLoai)
                    .Include(s => s.TacGia)
                    .Include(s => s.NhaXuatBan)
                    .AsQueryable();

                if (!string.IsNullOrEmpty(tuKhoa))
                {
                    query = query.Where(s =>
                        s.TenSach.ToLower().Contains(tuKhoa) ||
                        s.TheLoai.TenTheLoai.ToLower().Contains(tuKhoa) ||
                        s.TacGia.TenTacGia.ToLower().Contains(tuKhoa)
                    );
                }
                var ketQuaTimKiem = query.Select(s => new DanhSachSach
                {
                    ID = s.ID,
                    TenSach = s.TenSach,
                    NamXuatBan = s.NamXuatBan,
                    SoLuong = s.SoLuong,
                    DonGia = s.DonGia,
                    HinhAnh = s.HinhAnh,
                    TheLoaiID = s.TheLoaiID,
                    TenTheLoai = s.TheLoai.TenTheLoai,
                    TacGiaID = s.TacGiaID,
                    TenTacGia = s.TacGia.TenTacGia,
                    NhaXuatBanID = s.NhaXuatBanID,
                    TenNhaXuatBan = s.NhaXuatBan.TenNhaXuatBan
                }).ToList();
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = ketQuaTimKiem;
                dgvSach.DataSource = bindingSource;
                cboTheLoai.DataBindings.Clear();
                cboTheLoai.DataBindings.Add("SelectedValue", bindingSource, "TheLoaiID", false, DataSourceUpdateMode.Never);
                cboTacGia.DataBindings.Clear();
                cboTacGia.DataBindings.Add("SelectedValue", bindingSource, "TacGiaID", false, DataSourceUpdateMode.Never);
                cboNhaXuatBan.DataBindings.Clear();
                cboNhaXuatBan.DataBindings.Add("SelectedValue", bindingSource, "NhaXuatBanID", false, DataSourceUpdateMode.Never);
                txtTenSach.DataBindings.Clear();
                txtTenSach.DataBindings.Add("Text", bindingSource, "TenSach", false, DataSourceUpdateMode.Never);
                numNamXuatBan.DataBindings.Clear();
                numNamXuatBan.DataBindings.Add("Value", bindingSource, "NamXuatBan", false, DataSourceUpdateMode.Never);
                numSoLuong.DataBindings.Clear();
                numSoLuong.DataBindings.Add("Value", bindingSource, "SoLuong", false, DataSourceUpdateMode.Never);
                numDonGia.DataBindings.Clear();
                numDonGia.DataBindings.Add("Value", bindingSource, "DonGia", false, DataSourceUpdateMode.Never);
                picHinhAnh.DataBindings.Clear();
                Binding hinhAnhBinding = new Binding("ImageLocation", bindingSource, "HinhAnh", true, DataSourceUpdateMode.Never);
                hinhAnhBinding.Format += (s, ev) =>
                {
                    if (ev.Value != null && !string.IsNullOrWhiteSpace(ev.Value.ToString()))
                    {
                        ev.Value = Path.Combine(imagesFolder, ev.Value.ToString());
                    }
                    else
                    {
                        ev.Value = null;
                    }
                };
                picHinhAnh.DataBindings.Add(hinhAnhBinding);

                if (ketQuaTimKiem.Count == 0 && !string.IsNullOrEmpty(tuKhoa))
                {
                    MessageBox.Show("Không tìm thấy sách nào khớp với từ khóa!", "Kết quả tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
