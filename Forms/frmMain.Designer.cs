namespace QuanLyThuVien.Forms
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            pnlSidebar = new Panel();
            btnGiaoDich = new FontAwesome.Sharp.IconButton();
            btnMuonTra = new FontAwesome.Sharp.IconButton();
            btnNhaXuatBan = new FontAwesome.Sharp.IconButton();
            btnTacGia = new FontAwesome.Sharp.IconButton();
            btnTheLoai = new FontAwesome.Sharp.IconButton();
            btnSach = new FontAwesome.Sharp.IconButton();
            btnGoi = new FontAwesome.Sharp.IconButton();
            btnThanhVien = new FontAwesome.Sharp.IconButton();
            btnNhanVien = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            lblTitle = new Label();
            pnlContent = new Panel();
            menuStrip1 = new MenuStrip();
            mnuHeThong = new ToolStripMenuItem();
            mnuDangNhap = new ToolStripMenuItem();
            mnuDangXuat = new ToolStripMenuItem();
            mnuDoiMatKhau = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            mnuDoiMauTheme = new ToolStripMenuItem();
            mnuThoat = new ToolStripMenuItem();
            mnuTroGiup = new ToolStripMenuItem();
            mnuHuongDanSuDung = new ToolStripMenuItem();
            mnuThongTinPhanMem = new ToolStripMenuItem();
            mnuBaoCaoThongKe = new ToolStripMenuItem();
            mnuThongKeHoatDong = new ToolStripMenuItem();
            mnuThongKeDoanhThu = new ToolStripMenuItem();
            mnuNhatKyHoatDong = new ToolStripMenuItem();
            pnlFooter = new Panel();
            statusStrip1 = new StatusStrip();
            lblTrangThai = new ToolStripStatusLabel();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            lblLienKet = new ToolStripStatusLabel();
            pnlNavbar = new Panel();
            pnlSidebar.SuspendLayout();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            pnlFooter.SuspendLayout();
            statusStrip1.SuspendLayout();
            pnlNavbar.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(128, 128, 255);
            pnlSidebar.Controls.Add(btnGiaoDich);
            pnlSidebar.Controls.Add(btnMuonTra);
            pnlSidebar.Controls.Add(btnNhaXuatBan);
            pnlSidebar.Controls.Add(btnTacGia);
            pnlSidebar.Controls.Add(btnTheLoai);
            pnlSidebar.Controls.Add(btnSach);
            pnlSidebar.Controls.Add(btnGoi);
            pnlSidebar.Controls.Add(btnThanhVien);
            pnlSidebar.Controls.Add(btnNhanVien);
            pnlSidebar.Controls.Add(panel1);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(281, 762);
            pnlSidebar.TabIndex = 0;
            pnlSidebar.Paint += pnlSidebar_Paint;
            // 
            // btnGiaoDich
            // 
            btnGiaoDich.Dock = DockStyle.Top;
            btnGiaoDich.FlatAppearance.BorderSize = 0;
            btnGiaoDich.FlatStyle = FlatStyle.Flat;
            btnGiaoDich.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGiaoDich.ForeColor = Color.White;
            btnGiaoDich.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckDollar;
            btnGiaoDich.IconColor = Color.White;
            btnGiaoDich.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGiaoDich.IconSize = 26;
            btnGiaoDich.ImageAlign = ContentAlignment.MiddleLeft;
            btnGiaoDich.Location = new Point(0, 606);
            btnGiaoDich.Name = "btnGiaoDich";
            btnGiaoDich.Padding = new Padding(30, 0, 0, 0);
            btnGiaoDich.Size = new Size(281, 69);
            btnGiaoDich.TabIndex = 19;
            btnGiaoDich.Text = "GIAO DỊCH";
            btnGiaoDich.TextAlign = ContentAlignment.MiddleLeft;
            btnGiaoDich.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGiaoDich.UseVisualStyleBackColor = true;
            btnGiaoDich.Click += btnGiaoDich_Click;
            // 
            // btnMuonTra
            // 
            btnMuonTra.Dock = DockStyle.Top;
            btnMuonTra.FlatAppearance.BorderSize = 0;
            btnMuonTra.FlatStyle = FlatStyle.Flat;
            btnMuonTra.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnMuonTra.ForeColor = Color.White;
            btnMuonTra.IconChar = FontAwesome.Sharp.IconChar.PuzzlePiece;
            btnMuonTra.IconColor = Color.White;
            btnMuonTra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMuonTra.IconSize = 26;
            btnMuonTra.ImageAlign = ContentAlignment.MiddleLeft;
            btnMuonTra.Location = new Point(0, 537);
            btnMuonTra.Name = "btnMuonTra";
            btnMuonTra.Padding = new Padding(30, 0, 0, 0);
            btnMuonTra.Size = new Size(281, 69);
            btnMuonTra.TabIndex = 18;
            btnMuonTra.Text = "MƯỢN TRẢ SÁCH";
            btnMuonTra.TextAlign = ContentAlignment.MiddleLeft;
            btnMuonTra.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMuonTra.UseVisualStyleBackColor = true;
            btnMuonTra.Click += btnMuonTra_Click;
            // 
            // btnNhaXuatBan
            // 
            btnNhaXuatBan.Dock = DockStyle.Top;
            btnNhaXuatBan.FlatAppearance.BorderSize = 0;
            btnNhaXuatBan.FlatStyle = FlatStyle.Flat;
            btnNhaXuatBan.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNhaXuatBan.ForeColor = Color.White;
            btnNhaXuatBan.IconChar = FontAwesome.Sharp.IconChar.Repeat;
            btnNhaXuatBan.IconColor = Color.White;
            btnNhaXuatBan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNhaXuatBan.IconSize = 26;
            btnNhaXuatBan.ImageAlign = ContentAlignment.MiddleLeft;
            btnNhaXuatBan.Location = new Point(0, 468);
            btnNhaXuatBan.Name = "btnNhaXuatBan";
            btnNhaXuatBan.Padding = new Padding(30, 0, 0, 0);
            btnNhaXuatBan.Size = new Size(281, 69);
            btnNhaXuatBan.TabIndex = 17;
            btnNhaXuatBan.Text = "NHÀ XUẤT BẢN";
            btnNhaXuatBan.TextAlign = ContentAlignment.MiddleLeft;
            btnNhaXuatBan.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNhaXuatBan.UseVisualStyleBackColor = true;
            btnNhaXuatBan.Click += btnNhaXuatBan_Click;
            // 
            // btnTacGia
            // 
            btnTacGia.Dock = DockStyle.Top;
            btnTacGia.FlatAppearance.BorderSize = 0;
            btnTacGia.FlatStyle = FlatStyle.Flat;
            btnTacGia.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnTacGia.ForeColor = Color.White;
            btnTacGia.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            btnTacGia.IconColor = Color.White;
            btnTacGia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnTacGia.IconSize = 26;
            btnTacGia.ImageAlign = ContentAlignment.MiddleLeft;
            btnTacGia.Location = new Point(0, 399);
            btnTacGia.Name = "btnTacGia";
            btnTacGia.Padding = new Padding(30, 0, 0, 0);
            btnTacGia.Size = new Size(281, 69);
            btnTacGia.TabIndex = 16;
            btnTacGia.Text = "TÁC GIẢ";
            btnTacGia.TextAlign = ContentAlignment.MiddleLeft;
            btnTacGia.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTacGia.UseVisualStyleBackColor = true;
            btnTacGia.Click += btnTacGia_Click;
            // 
            // btnTheLoai
            // 
            btnTheLoai.Dock = DockStyle.Top;
            btnTheLoai.FlatAppearance.BorderSize = 0;
            btnTheLoai.FlatStyle = FlatStyle.Flat;
            btnTheLoai.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnTheLoai.ForeColor = Color.White;
            btnTheLoai.IconChar = FontAwesome.Sharp.IconChar.Buffer;
            btnTheLoai.IconColor = Color.White;
            btnTheLoai.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnTheLoai.IconSize = 26;
            btnTheLoai.ImageAlign = ContentAlignment.MiddleLeft;
            btnTheLoai.Location = new Point(0, 330);
            btnTheLoai.Name = "btnTheLoai";
            btnTheLoai.Padding = new Padding(30, 0, 0, 0);
            btnTheLoai.Size = new Size(281, 69);
            btnTheLoai.TabIndex = 15;
            btnTheLoai.Text = "THỂ LOẠI";
            btnTheLoai.TextAlign = ContentAlignment.MiddleLeft;
            btnTheLoai.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTheLoai.UseVisualStyleBackColor = true;
            btnTheLoai.Click += btnTheLoai_Click_1;
            // 
            // btnSach
            // 
            btnSach.Dock = DockStyle.Top;
            btnSach.FlatAppearance.BorderSize = 0;
            btnSach.FlatStyle = FlatStyle.Flat;
            btnSach.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSach.ForeColor = Color.White;
            btnSach.IconChar = FontAwesome.Sharp.IconChar.Book;
            btnSach.IconColor = Color.White;
            btnSach.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSach.IconSize = 26;
            btnSach.ImageAlign = ContentAlignment.MiddleLeft;
            btnSach.Location = new Point(0, 261);
            btnSach.Name = "btnSach";
            btnSach.Padding = new Padding(30, 0, 0, 0);
            btnSach.Size = new Size(281, 69);
            btnSach.TabIndex = 14;
            btnSach.Text = "THƯ VIỆN";
            btnSach.TextAlign = ContentAlignment.MiddleLeft;
            btnSach.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSach.UseVisualStyleBackColor = true;
            btnSach.Click += btnSach_Click;
            // 
            // btnGoi
            // 
            btnGoi.Dock = DockStyle.Top;
            btnGoi.FlatAppearance.BorderSize = 0;
            btnGoi.FlatStyle = FlatStyle.Flat;
            btnGoi.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGoi.ForeColor = Color.White;
            btnGoi.IconChar = FontAwesome.Sharp.IconChar.Sketch;
            btnGoi.IconColor = Color.White;
            btnGoi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGoi.IconSize = 28;
            btnGoi.ImageAlign = ContentAlignment.MiddleLeft;
            btnGoi.Location = new Point(0, 192);
            btnGoi.Name = "btnGoi";
            btnGoi.Padding = new Padding(30, 0, 0, 0);
            btnGoi.Size = new Size(281, 69);
            btnGoi.TabIndex = 13;
            btnGoi.Text = "GÓI THÀNH VIÊN";
            btnGoi.TextAlign = ContentAlignment.MiddleLeft;
            btnGoi.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGoi.UseVisualStyleBackColor = true;
            btnGoi.Click += btnGoi_Click;
            // 
            // btnThanhVien
            // 
            btnThanhVien.Dock = DockStyle.Top;
            btnThanhVien.FlatAppearance.BorderSize = 0;
            btnThanhVien.FlatStyle = FlatStyle.Flat;
            btnThanhVien.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnThanhVien.ForeColor = Color.White;
            btnThanhVien.IconChar = FontAwesome.Sharp.IconChar.UserLarge;
            btnThanhVien.IconColor = Color.White;
            btnThanhVien.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnThanhVien.IconSize = 26;
            btnThanhVien.ImageAlign = ContentAlignment.MiddleLeft;
            btnThanhVien.Location = new Point(0, 123);
            btnThanhVien.Name = "btnThanhVien";
            btnThanhVien.Padding = new Padding(30, 0, 0, 0);
            btnThanhVien.Size = new Size(281, 69);
            btnThanhVien.TabIndex = 11;
            btnThanhVien.Text = "THÀNH VIÊN";
            btnThanhVien.TextAlign = ContentAlignment.MiddleLeft;
            btnThanhVien.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThanhVien.UseVisualStyleBackColor = true;
            btnThanhVien.Click += btnThanhVien_Click_1;
            // 
            // btnNhanVien
            // 
            btnNhanVien.Dock = DockStyle.Top;
            btnNhanVien.FlatAppearance.BorderSize = 0;
            btnNhanVien.FlatStyle = FlatStyle.Flat;
            btnNhanVien.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNhanVien.ForeColor = Color.White;
            btnNhanVien.IconChar = FontAwesome.Sharp.IconChar.DiceD6;
            btnNhanVien.IconColor = Color.White;
            btnNhanVien.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNhanVien.IconSize = 26;
            btnNhanVien.ImageAlign = ContentAlignment.MiddleLeft;
            btnNhanVien.Location = new Point(0, 54);
            btnNhanVien.Name = "btnNhanVien";
            btnNhanVien.Padding = new Padding(30, 0, 0, 0);
            btnNhanVien.Size = new Size(281, 69);
            btnNhanVien.TabIndex = 0;
            btnNhanVien.Text = "NHÂN VIÊN";
            btnNhanVien.TextAlign = ContentAlignment.MiddleLeft;
            btnNhanVien.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNhanVien.UseVisualStyleBackColor = true;
            btnNhanVien.Click += btnNhanVien_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(lblTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(281, 54);
            panel1.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI Black", 13F);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Padding = new Padding(25, 10, 0, 0);
            lblTitle.Size = new Size(253, 40);
            lblTitle.TabIndex = 14;
            lblTitle.Text = "QUẢN LÝ THƯ VIỆN";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.Click += lblTitle_Click_1;
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.White;
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            pnlContent.ForeColor = Color.White;
            pnlContent.Location = new Point(281, 54);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1160, 679);
            pnlContent.TabIndex = 0;
            pnlContent.Paint += pnlContent_Paint;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.White;
            menuStrip1.Dock = DockStyle.Fill;
            menuStrip1.Font = new Font("Times New Roman", 9F);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuHeThong, mnuTroGiup, mnuBaoCaoThongKe });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1160, 54);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuHeThong
            // 
            mnuHeThong.Alignment = ToolStripItemAlignment.Right;
            mnuHeThong.DropDownItems.AddRange(new ToolStripItem[] { mnuDangNhap, mnuDangXuat, mnuDoiMatKhau, toolStripSeparator1, mnuDoiMauTheme, mnuThoat });
            mnuHeThong.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            mnuHeThong.ForeColor = Color.Black;
            mnuHeThong.Image = (Image)resources.GetObject("mnuHeThong.Image");
            mnuHeThong.Name = "mnuHeThong";
            mnuHeThong.Padding = new Padding(20);
            mnuHeThong.ShortcutKeys = Keys.Alt | Keys.F4;
            mnuHeThong.Size = new Size(64, 50);
            // 
            // mnuDangNhap
            // 
            mnuDangNhap.ForeColor = Color.Black;
            mnuDangNhap.Name = "mnuDangNhap";
            mnuDangNhap.Size = new Size(200, 26);
            mnuDangNhap.Text = "Đăng &nhập…";
            mnuDangNhap.Click += mnuDangNhap_Click;
            // 
            // mnuDangXuat
            // 
            mnuDangXuat.BackColor = SystemColors.Control;
            mnuDangXuat.ForeColor = Color.Black;
            mnuDangXuat.Name = "mnuDangXuat";
            mnuDangXuat.Size = new Size(200, 26);
            mnuDangXuat.Text = "Đăng &xuất";
            mnuDangXuat.Click += mnuDangXuat_Click;
            // 
            // mnuDoiMatKhau
            // 
            mnuDoiMatKhau.BackColor = SystemColors.Control;
            mnuDoiMatKhau.ForeColor = Color.Black;
            mnuDoiMatKhau.Name = "mnuDoiMatKhau";
            mnuDoiMatKhau.Size = new Size(200, 26);
            mnuDoiMatKhau.Text = "Đổi &mật khẩu…";
            mnuDoiMatKhau.Click += mnuDoiMatKhau_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.BackColor = SystemColors.Control;
            toolStripSeparator1.ForeColor = Color.Black;
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(197, 6);
            // 
            // mnuDoiMauTheme
            // 
            mnuDoiMauTheme.BackColor = SystemColors.Control;
            mnuDoiMauTheme.ForeColor = Color.Black;
            mnuDoiMauTheme.Name = "mnuDoiMauTheme";
            mnuDoiMauTheme.Size = new Size(200, 26);
            mnuDoiMauTheme.Text = "Đổi màu Theme";
            mnuDoiMauTheme.Click += càiĐặtToolStripMenuItem_Click;
            // 
            // mnuThoat
            // 
            mnuThoat.BackColor = SystemColors.Control;
            mnuThoat.ForeColor = Color.Black;
            mnuThoat.Name = "mnuThoat";
            mnuThoat.ShortcutKeys = Keys.Alt | Keys.F4;
            mnuThoat.Size = new Size(200, 26);
            mnuThoat.Text = "&Thoát";
            mnuThoat.Click += mnuThoat_Click;
            // 
            // mnuTroGiup
            // 
            mnuTroGiup.Alignment = ToolStripItemAlignment.Right;
            mnuTroGiup.BackColor = Color.Transparent;
            mnuTroGiup.DropDownItems.AddRange(new ToolStripItem[] { mnuHuongDanSuDung, mnuThongTinPhanMem });
            mnuTroGiup.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            mnuTroGiup.ForeColor = Color.Black;
            mnuTroGiup.Image = (Image)resources.GetObject("mnuTroGiup.Image");
            mnuTroGiup.Name = "mnuTroGiup";
            mnuTroGiup.Padding = new Padding(20);
            mnuTroGiup.Size = new Size(64, 50);
            // 
            // mnuHuongDanSuDung
            // 
            mnuHuongDanSuDung.ForeColor = Color.Black;
            mnuHuongDanSuDung.Name = "mnuHuongDanSuDung";
            mnuHuongDanSuDung.ShortcutKeys = Keys.Control | Keys.F1;
            mnuHuongDanSuDung.Size = new Size(285, 26);
            mnuHuongDanSuDung.Text = "&Hướng dẫn sử dụng";
            mnuHuongDanSuDung.Click += mnuHuongDanSuDung_Click;
            // 
            // mnuThongTinPhanMem
            // 
            mnuThongTinPhanMem.ForeColor = Color.Black;
            mnuThongTinPhanMem.Name = "mnuThongTinPhanMem";
            mnuThongTinPhanMem.Size = new Size(285, 26);
            mnuThongTinPhanMem.Text = "&Thông tin phần mềm...";
            mnuThongTinPhanMem.Click += mnuThongTinPhanMem_Click;
            // 
            // mnuBaoCaoThongKe
            // 
            mnuBaoCaoThongKe.Alignment = ToolStripItemAlignment.Right;
            mnuBaoCaoThongKe.DropDownItems.AddRange(new ToolStripItem[] { mnuThongKeHoatDong, mnuThongKeDoanhThu, mnuNhatKyHoatDong });
            mnuBaoCaoThongKe.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            mnuBaoCaoThongKe.ForeColor = Color.Black;
            mnuBaoCaoThongKe.Image = (Image)resources.GetObject("mnuBaoCaoThongKe.Image");
            mnuBaoCaoThongKe.Name = "mnuBaoCaoThongKe";
            mnuBaoCaoThongKe.Padding = new Padding(20);
            mnuBaoCaoThongKe.Size = new Size(64, 50);
            // 
            // mnuThongKeHoatDong
            // 
            mnuThongKeHoatDong.ForeColor = Color.Black;
            mnuThongKeHoatDong.Name = "mnuThongKeHoatDong";
            mnuThongKeHoatDong.Size = new Size(243, 26);
            mnuThongKeHoatDong.Text = "Thống kê &hoạt động...";
            mnuThongKeHoatDong.Click += mnuThongKeHoatDong_Click;
            // 
            // mnuThongKeDoanhThu
            // 
            mnuThongKeDoanhThu.ForeColor = Color.Black;
            mnuThongKeDoanhThu.Name = "mnuThongKeDoanhThu";
            mnuThongKeDoanhThu.Size = new Size(243, 26);
            mnuThongKeDoanhThu.Text = "Thống kê &doanh thu...";
            mnuThongKeDoanhThu.Click += mnuThongKeDoanhThu_Click;
            // 
            // mnuNhatKyHoatDong
            // 
            mnuNhatKyHoatDong.Name = "mnuNhatKyHoatDong";
            mnuNhatKyHoatDong.Size = new Size(243, 26);
            mnuNhatKyHoatDong.Text = "&Nhật ký hoạt động...";
            mnuNhatKyHoatDong.Click += mnuNhatKyHoatDong_Click;
            // 
            // pnlFooter
            // 
            pnlFooter.BackColor = Color.White;
            pnlFooter.Controls.Add(statusStrip1);
            pnlFooter.Dock = DockStyle.Bottom;
            pnlFooter.Location = new Point(281, 733);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(1160, 29);
            pnlFooter.TabIndex = 1;
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = Color.Transparent;
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblTrangThai, toolStripStatusLabel1, lblLienKet });
            statusStrip1.Location = new Point(0, 3);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.RenderMode = ToolStripRenderMode.ManagerRenderMode;
            statusStrip1.Size = new Size(1160, 26);
            statusStrip1.SizingGrip = false;
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            statusStrip1.ItemClicked += statusStrip1_ItemClicked;
            // 
            // lblTrangThai
            // 
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(121, 20);
            lblTrangThai.Text = "Chưa đăng nhập.";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(943, 20);
            toolStripStatusLabel1.Spring = true;
            // 
            // lblLienKet
            // 
            lblLienKet.IsLink = true;
            lblLienKet.Name = "lblLienKet";
            lblLienKet.Size = new Size(81, 20);
            lblLienKet.Text = "© 2024 FIT";
            lblLienKet.Click += lblLienKet_Click;
            // 
            // pnlNavbar
            // 
            pnlNavbar.BackColor = Color.FromArgb(249, 99, 50);
            pnlNavbar.Controls.Add(menuStrip1);
            pnlNavbar.Dock = DockStyle.Top;
            pnlNavbar.Location = new Point(281, 0);
            pnlNavbar.Name = "pnlNavbar";
            pnlNavbar.Size = new Size(1160, 54);
            pnlNavbar.TabIndex = 1;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1441, 762);
            Controls.Add(pnlContent);
            Controls.Add(pnlFooter);
            Controls.Add(pnlNavbar);
            Controls.Add(pnlSidebar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(1400, 650);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý thư viện";
            WindowState = FormWindowState.Maximized;
            FormClosing += frmMain_FormClosing;
            Load += frmMain_Load;
            pnlSidebar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pnlFooter.ResumeLayout(false);
            pnlFooter.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            pnlNavbar.ResumeLayout(false);
            pnlNavbar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlSidebar;
        private Panel pnlContent;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuHeThong;
        private ToolStripMenuItem mnuDangNhap;
        private ToolStripMenuItem mnuDangXuat;
        private ToolStripMenuItem mnuDoiMatKhau;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem mnuThoat;
        private ToolStripMenuItem mnuBaoCaoThongKe;
        private ToolStripMenuItem mnuTroGiup;
        private ToolStripMenuItem mnuThongKeHoatDong;
        private ToolStripMenuItem mnuThongKeDoanhThu;
        private ToolStripMenuItem mnuHuongDanSuDung;
        private ToolStripMenuItem mnuThongTinPhanMem;
        private Panel pnlFooter;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblTrangThai;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel lblLienKet;
        private Panel panel1;
        private Panel pnlNavbar;
        private FontAwesome.Sharp.IconButton btnNhanVien;
        private FontAwesome.Sharp.IconButton btnThanhVien;
        private FontAwesome.Sharp.IconButton btnGoi;
        private ToolStripMenuItem mnuDoiMauTheme;
        private Label lblTitle;
        private FontAwesome.Sharp.IconButton btnSach;
        private FontAwesome.Sharp.IconButton btnTheLoai;
        private FontAwesome.Sharp.IconButton btnTacGia;
        private FontAwesome.Sharp.IconButton btnNhaXuatBan;
        private FontAwesome.Sharp.IconButton btnMuonTra;
        private FontAwesome.Sharp.IconButton btnGiaoDich;
        private ToolStripMenuItem mnuNhatKyHoatDong;
    }
}