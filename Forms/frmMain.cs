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

            pnlContent.Controls.Add(formCon);
            pnlContent.Tag = formCon;
            formCon.BringToFront();
            formCon.Show();
        }

        private void btnThanhVien_Click(object sender, EventArgs e)
        {
            MoFormCon(new frmThanhVien());
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            ChuaDangNhap();
            DangNhap();
        }

        private void btnMuonTra_Click(object sender, EventArgs e)
        {
            MoFormCon(new frmPhieuMuon());
        }

        private void btnSach_Click(object sender, EventArgs e)
        {
            MoFormCon(new frmSach());
        }

        private void pnlSidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            MoFormCon(new frmNhanVien());
        }

        private void btnGoi_Click(object sender, EventArgs e)
        {
            MoFormCon(new frmGoiThanhVien());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MoFormCon(new frmTacGia());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MoFormCon(new frmNhaXuatBan());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MoFormCon(new frmPhieuThu());
        }

        private void btnTheLoai_Click(object sender, EventArgs e)
        {
            MoFormCon(new frmTheLoai());
        }

        private void thểToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MoFormCon(new frmTheLoai());
        }

        private void nhàXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MoFormCon(new frmNhaXuatBan());
        }

        private void toolStripStatusLabel3_Click(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {
            if (formHienTai != null)
            {
                formHienTai.Close();
                formHienTai = null;
            }
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
            if (dangNhap == null || dangNhap.IsDisposed)
                dangNhap = new frmDangNhap();
            if (dangNhap.ShowDialog() == DialogResult.OK)
            {
                string tenDangNhap = dangNhap.txtTenDangNhap.Text;
                string matKhau = dangNhap.txtMatKhau.Text;
                if (tenDangNhap.Trim() == "")
                {
                    MessageBox.Show("Tên đăng nhập không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dangNhap.txtTenDangNhap.Focus();
                    goto LamLai;
                }
                else if (matKhau.Trim() == "")
                {
                    MessageBox.Show("Mật khẩu không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dangNhap.txtMatKhau.Focus();
                    goto LamLai;
                }
                else
                {
                    var nhanVien = context.NhanVien.Where(r => r.TenDangNhap == tenDangNhap).SingleOrDefault();
                    if (nhanVien == null)
                    {
                        MessageBox.Show("Tên đăng nhập không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dangNhap.txtTenDangNhap.Focus();
                        goto LamLai;
                    }
                    else
                    {
                        if (matKhau == nhanVien.MatKhau)
                        {
                            tenNhanVien = nhanVien.TenNhanVien;
                            if (nhanVien.QuyenHan == true)
                                QuyenQuanLy();
                            else if (nhanVien.QuyenHan == false)
                                QuyenThuThu();
                            else
                                ChuaDangNhap();
                        }
                        else
                        {
                            MessageBox.Show("Mật khẩu không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            dangNhap.txtMatKhau.Focus();
                            goto LamLai;
                        }
                    }
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
            btnPhieuThu.Enabled = false;

            mnuBaoCaoThongKe.Enabled = false;
            mnuDoiMatKhau.Enabled = false;
            mnuQuanLy.Enabled = false;
            mnuDangXuat.Enabled = false;
            mnuDangNhap.Enabled = true;

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
            btnPhieuThu.Enabled = true;

            mnuBaoCaoThongKe.Enabled = true;
            mnuDoiMatKhau.Enabled = true;
            mnuQuanLy.Enabled = true;
            mnuDangXuat.Enabled = true;
            mnuDangNhap.Enabled = false;

            lblTrangThai.Text = "Quản lý: " + tenNhanVien;
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
            btnPhieuThu.Enabled = true;

            mnuBaoCaoThongKe.Enabled = true;
            mnuDoiMatKhau.Enabled = true;
            mnuQuanLy.Enabled = true;
            mnuDangXuat.Enabled = true;
            mnuDangNhap.Enabled = false;

            lblTrangThai.Text = "Thủ thư: " + tenNhanVien;
        }

        private void mnuDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap();
        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
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
    }
}
