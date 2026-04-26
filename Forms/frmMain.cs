using QuanLyThuVien.Data;
using QuanLyThuVien.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BC = BCrypt.Net.BCrypt;

namespace QuanLyThuVien.Forms
{
    public partial class frmMain : Form
    {
        QLTVContext context = new QLTVContext();
        frmDangNhap dangNhap = null;
        public string tenNhanVien = "";
        public FontAwesome.Sharp.IconButton btnClick;
        public frmMain()
        {
            InitializeComponent();
        }

        private void pnlContent_Paint(object sender, PaintEventArgs e)
        {

        }
        private Form formHienTai = null;
        private void MoFormCon(Form formCon)
        {
            if (formHienTai != null)
            {
                formHienTai.Close();
            }

            formHienTai = formCon;

            formCon.TopLevel = false;
            formCon.FormBorderStyle = FormBorderStyle.None;
            formCon.Dock = DockStyle.Fill;
            formCon.ForeColor = Color.Black;

            pnlContent.Controls.Add(formCon);
            pnlContent.Tag = formCon;
            formCon.BringToFront();
            formCon.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Color mauTheme = Properties.Settings.Default.MauTheme;
            pnlSidebar.BackColor = mauTheme;
            ChuaDangNhap();
            DangNhap();
            this.Activate();
        }

        private void pnlSidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void thểToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MoFormCon(new frmTheLoai());
        }

        private void nhàXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MoFormCon(new frmNhaXuatBan());
        }

        private void tácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MoFormCon(new frmTacGia());
        }

        private void mnuSach_Click(object sender, EventArgs e)
        {
            MoFormCon(new frmSach());
        }

        private void btnGoiThanhVien_Click(object sender, EventArgs e)
        {
            MoFormCon(new frmGoiThanhVien());
        }

        private void mnuThanhVien_Click(object sender, EventArgs e)
        {
            MoFormCon(new frmThanhVien());
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            MoFormCon(new frmNhanVien());
        }

        private void mnuPhieuMuon_Click(object sender, EventArgs e)
        {
            MoFormCon(new frmPhieuMuon());
        }

        private void mnuPhieuThu_Click(object sender, EventArgs e)
        {
            MoFormCon(new frmPhieuThu());
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void lblLienKet_Click(object sender, EventArgs e)
        {
            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = "explorer.exe";
            info.Arguments = "https://lib.agu.edu.vn/";
            Process.Start(info);
        }

        private void DangNhap()
        {
        LamLai:
            if (dangNhap != null && !dangNhap.IsDisposed)
            {
                dangNhap.Dispose();
            }
            dangNhap = new frmDangNhap();

            if (dangNhap.ShowDialog() == DialogResult.OK)
            {
                string tenDangNhap = dangNhap.txtTenDangNhap.Text.Trim();
                string matKhau = dangNhap.txtMatKhau.Text.Trim();
                var nhanVien = context.NhanVien.Where(r => r.TenDangNhap == tenDangNhap).SingleOrDefault();
                bool matKhauDung = false;

                if (nhanVien != null)
                {
                    if (nhanVien.MatKhau != null && nhanVien.MatKhau.StartsWith("$2"))
                    {
                        matKhauDung = BC.Verify(matKhau, nhanVien.MatKhau);
                    }
                    else
                    {
                        matKhauDung = (matKhau == nhanVien.MatKhau);
                    }
                }

                if (nhanVien != null && matKhauDung == true)
                {
                    tenNhanVien = nhanVien.TenNhanVien;
                    Program.MaNhanVienDangNhap = nhanVien.ID;
                    Program.TenNhanVienDangNhap = nhanVien.TenNhanVien;

                    if (nhanVien.QuyenHan == true)
                        QuyenQuanLy();
                    else if (nhanVien.QuyenHan == false)
                        QuyenThuThu();
                    else
                        ChuaDangNhap();

                    using (var dbLog = new QLTVContext())
                    {
                        NhatKyHoatDong log = new NhatKyHoatDong();
                        log.NhanVienID = nhanVien.ID;
                        log.TieuDe = "Đăng nhập";
                        log.NoiDung = $"Nhân viên {nhanVien.TenNhanVien} vừa đăng nhập vào hệ thống.";
                        log.ThoiGian = DateTime.Now;

                        dbLog.NhatKyHoatDong.Add(log);
                        dbLog.SaveChanges();
                    }
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dangNhap.txtMatKhau.Clear();
                    dangNhap.txtTenDangNhap.Focus();

                    goto LamLai;
                }
            }
        }

        public void ChuaDangNhap()
        {
            if (formHienTai != null)
            {
                formHienTai.Close();
            }

            btnThanhVien.Enabled = false;
            btnNhanVien.Enabled = false;
            btnGoi.Enabled = false;
            btnSach.Enabled = false;
            btnTheLoai.Enabled = false;
            btnTacGia.Enabled = false;
            btnNhaXuatBan.Enabled = false;
            btnMuonTra.Enabled = false;
            btnGiaoDich.Enabled = false;

            mnuBaoCaoThongKe.Enabled = false;
            mnuDoiMatKhau.Enabled = false;
            mnuDangXuat.Enabled = false;
            mnuDangNhap.Enabled = true;
            pnlSidebar.Visible = false;

            lblTrangThai.Text = "Chưa đăng nhập.";
        }

        public void QuyenQuanLy()
        {
            btnThanhVien.Enabled = true;
            btnNhanVien.Visible = true;
            btnNhanVien.Enabled = true;
            btnGoi.Enabled = true;
            btnSach.Enabled = true;
            btnTheLoai.Enabled = true;
            btnTacGia.Enabled = true;
            btnNhaXuatBan.Enabled = true;
            btnMuonTra.Enabled = true;
            btnGiaoDich.Enabled = true;

            mnuBaoCaoThongKe.Enabled = true;
            mnuDoiMatKhau.Enabled = true;
            mnuDangXuat.Enabled = true;
            mnuDangNhap.Enabled = false;
            pnlSidebar.Visible = true;
            mnuNhatKyHoatDong.Visible = true;

            lblTrangThai.Text = "Quản lý: " + tenNhanVien;
            MoFormCon(new frmDashboard());
        }

        public void QuyenThuThu()
        {
            btnThanhVien.Enabled = true;
            btnNhanVien.Visible = false;
            btnGoi.Enabled = true;
            btnSach.Enabled = true;
            btnTheLoai.Enabled = true;
            btnTacGia.Enabled = true;
            btnNhaXuatBan.Enabled = true;
            btnMuonTra.Enabled = true;
            btnGiaoDich.Enabled = true;

            mnuBaoCaoThongKe.Enabled = true;
            mnuDoiMatKhau.Enabled = true;
            mnuDangXuat.Enabled = true;
            mnuDangNhap.Enabled = false;
            pnlSidebar.Visible = true;
            mnuNhatKyHoatDong.Visible = false;

            lblTrangThai.Text = "Thủ thư: " + tenNhanVien;
            MoFormCon(new frmDashboard());
        }

        private void TatNut()
        {
            if (btnClick != null)
            {
                btnClick.BackColor = pnlSidebar.BackColor;
                btnClick.ForeColor = Color.White;
                btnClick.IconColor = Color.White;
            }
        }

        private void AnNut(object senderBtn)
        {
            if (senderBtn != null)
            {
                if (btnClick != (FontAwesome.Sharp.IconButton)senderBtn)
                {
                    TatNut();
                    btnClick = (FontAwesome.Sharp.IconButton)senderBtn;
                    btnClick.BackColor = Color.White;
                    btnClick.ForeColor = pnlSidebar.BackColor;
                    btnClick.IconColor = pnlSidebar.BackColor;
                }
            }
        }

        private void mnuDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap();
        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            using (var dbLog = new QLTVContext())
            {
                NhatKyHoatDong log = new NhatKyHoatDong();
                log.NhanVienID = Program.MaNhanVienDangNhap;
                log.TieuDe = "Đăng xuất";
                log.NoiDung = $"Nhân viên {Program.TenNhanVienDangNhap} đã đăng xuất.";
                log.ThoiGian = DateTime.Now;

                dbLog.NhatKyHoatDong.Add(log);
                dbLog.SaveChanges();
            }
            foreach (Form child in MdiChildren)
            {
                child.Close();
            }
            ChuaDangNhap();
        }

        private void mnuThongKeHoatDong_Click(object sender, EventArgs e)
        {
            MoFormCon(new frmThongKeHoatDong());
        }

        private void mnuThongKeDoanhThu_Click(object sender, EventArgs e)
        {
            MoFormCon(new frmThongKeDoanhThu());
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            foreach (Form child in MdiChildren)
            {
                child.Close();
            }
            ChuaDangNhap();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnNhanVien_Click_1(object sender, EventArgs e)
        {
            AnNut(sender);
            MoFormCon(new frmNhanVien());
        }

        private void btnThanhVien_Click_1(object sender, EventArgs e)
        {
            AnNut(sender);
            MoFormCon(new frmThanhVien());
        }

        private void btnGoi_Click(object sender, EventArgs e)
        {
            AnNut(sender);
            MoFormCon(new frmGoiThanhVien());
        }

        private void càiĐặtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog bangMau = new ColorDialog();
            bangMau.AllowFullOpen = true;
            bangMau.Color = pnlSidebar.BackColor;
            if (bangMau.ShowDialog() == DialogResult.OK)
            {
                Color mauMoi = bangMau.Color;
                pnlSidebar.BackColor = mauMoi;
                foreach (Control ctrl in pnlSidebar.Controls)
                {
                    if (ctrl is FontAwesome.Sharp.IconButton && ctrl != btnClick)
                    {
                        ctrl.BackColor = mauMoi;
                    }
                }
                if (btnClick != null)
                {
                    btnClick.ForeColor = mauMoi;
                    btnClick.IconColor = mauMoi;
                }
                Properties.Settings.Default.MauTheme = mauMoi;
                Properties.Settings.Default.Save();
            }
        }

        private void lblTitle_Click_1(object sender, EventArgs e)
        {
            if (formHienTai != null)
            {
                MoFormCon(new frmDashboard());
                TatNut();
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (pnlSidebar.Visible == true)
            {
                pnlSidebar.Visible = false;
            }
            else
            {
                pnlSidebar.Visible = true;
            }
        }

        private void btnTheLoai_Click_1(object sender, EventArgs e)
        {
            AnNut(sender);
            MoFormCon(new frmTheLoai());
        }

        private void btnSach_Click(object sender, EventArgs e)
        {
            AnNut(sender);
            MoFormCon(new frmSach());
        }

        private void btnTacGia_Click(object sender, EventArgs e)
        {
            AnNut(sender);
            MoFormCon(new frmTacGia());
        }

        private void btnNhaXuatBan_Click(object sender, EventArgs e)
        {
            AnNut(sender);
            MoFormCon(new frmNhaXuatBan());
        }

        private void btnMuonTra_Click(object sender, EventArgs e)
        {
            AnNut(sender);
            MoFormCon(new frmPhieuMuon());
        }

        private void btnGiaoDich_Click(object sender, EventArgs e)
        {
            AnNut(sender);
            MoFormCon(new frmPhieuThu());
        }

        private void mnuDoiMatKhau_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau frm = new frmDoiMatKhau();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                Application.Restart();
            }
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn thoát chương trình không?", "Thông báo",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }

        private void mnuNhatKyHoatDong_Click(object sender, EventArgs e)
        {
            MoFormCon(new frmLichSuHoatDong());
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Program.MaNhanVienDangNhap != 0)
            {
                using (var dbLog = new QuanLyThuVien.Data.QLTVContext())
                {
                    var log = new QuanLyThuVien.Data.NhatKyHoatDong
                    {
                        NhanVienID = Program.MaNhanVienDangNhap,
                        TieuDe = "Đăng xuất",
                        NoiDung = $"Nhân viên {Program.TenNhanVienDangNhap} đã đóng ứng dụng.",
                        ThoiGian = DateTime.Now
                    };
                    dbLog.NhatKyHoatDong.Add(log);
                    dbLog.SaveChanges();
                }
            }
        }

        private void mnuHuongDanSuDung_Click(object sender, EventArgs e)
        {
            string duongDan = Path.Combine(Application.StartupPath, "Docs", "HuongDanSuDung.html");

            if (File.Exists(duongDan))
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = duongDan,
                    UseShellExecute = true
                });
            }
            else
            {
                MessageBox.Show("Không tìm thấy file hướng dẫn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mnuThongTinPhanMem_Click(object sender, EventArgs e)
        {
            string duongDan = Path.Combine(Application.StartupPath, "Docs", "ThongTinPhanMem.html");

            if (File.Exists(duongDan))
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = duongDan,
                    UseShellExecute = true
                });
            }
            else
            {
                MessageBox.Show("Không tìm thấy file thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
