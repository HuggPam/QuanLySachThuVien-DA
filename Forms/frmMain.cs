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
    public partial class frmMain : Form
    {
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
            // 1. Xóa sạch những gì đang hiện ở vùng nội dung
            if (formHienTai != null)
            {
                formHienTai.Close();
            }

            formHienTai = formCon;

            // 2. Thiết lập để Form con "biến thành" một Control bình thường
            formCon.TopLevel = false;
            formCon.FormBorderStyle = FormBorderStyle.None; // Bỏ khung viền (X, _, [])
            formCon.Dock = DockStyle.Fill; // Tràn đầy vùng pnlContent

            // 3. Thêm vào Panel và hiển thị
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

        }

        private void nhàXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel3_Click(object sender, EventArgs e)
        {

        }
    }
}
