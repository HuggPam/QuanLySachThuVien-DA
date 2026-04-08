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
            pnlSidebar = new Panel();
            btnPhieuThu = new Button();
            btnMuonTra = new Button();
            btnNhaXuatBan = new Button();
            btnTacGia = new Button();
            btnTheLoai = new Button();
            btnSach = new Button();
            btnGoi = new Button();
            btnThanhVien = new Button();
            btnNhanVien = new Button();
            lblTitle = new Label();
            pnlContent = new Panel();
            menuStrip1 = new MenuStrip();
            mnuHeThong = new ToolStripMenuItem();
            mnuDangNhap = new ToolStripMenuItem();
            mnuDangXuat = new ToolStripMenuItem();
            mnuDoiMatKhau = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            mnuThoat = new ToolStripMenuItem();
            mnuQuanLy = new ToolStripMenuItem();
            mnuTheLoai = new ToolStripMenuItem();
            mnuTacGia = new ToolStripMenuItem();
            mnuNhaXuatBan = new ToolStripMenuItem();
            mnuSach = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            btnGoiThanhVien = new ToolStripMenuItem();
            mnuThanhVien = new ToolStripMenuItem();
            mnuNhanVien = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            mnuPhieuMuon = new ToolStripMenuItem();
            mnuPhieuThu = new ToolStripMenuItem();
            mnuBaoCaoThongKe = new ToolStripMenuItem();
            mnuThongKeHoatDong = new ToolStripMenuItem();
            mnuThongKeDoanhThu = new ToolStripMenuItem();
            mnuTroGiup = new ToolStripMenuItem();
            mnuHuongDanSuDung = new ToolStripMenuItem();
            mnuThongTinPhanMem = new ToolStripMenuItem();
            pnlFooter = new Panel();
            statusStrip1 = new StatusStrip();
            lblTrangThai = new ToolStripStatusLabel();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            lblLienKet = new ToolStripStatusLabel();
            pnlSidebar.SuspendLayout();
            pnlContent.SuspendLayout();
            menuStrip1.SuspendLayout();
            pnlFooter.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(30, 30, 45);
            pnlSidebar.Controls.Add(btnPhieuThu);
            pnlSidebar.Controls.Add(btnMuonTra);
            pnlSidebar.Controls.Add(btnNhaXuatBan);
            pnlSidebar.Controls.Add(btnTacGia);
            pnlSidebar.Controls.Add(btnTheLoai);
            pnlSidebar.Controls.Add(btnSach);
            pnlSidebar.Controls.Add(btnGoi);
            pnlSidebar.Controls.Add(btnThanhVien);
            pnlSidebar.Controls.Add(btnNhanVien);
            pnlSidebar.Controls.Add(lblTitle);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(200, 574);
            pnlSidebar.TabIndex = 0;
            pnlSidebar.Paint += pnlSidebar_Paint;
            // 
            // btnPhieuThu
            // 
            btnPhieuThu.Dock = DockStyle.Top;
            btnPhieuThu.FlatAppearance.BorderSize = 0;
            btnPhieuThu.FlatStyle = FlatStyle.Flat;
            btnPhieuThu.Font = new Font("Times New Roman", 10F);
            btnPhieuThu.ForeColor = Color.FromArgb(73, 75, 116);
            btnPhieuThu.Location = new Point(0, 407);
            btnPhieuThu.Name = "btnPhieuThu";
            btnPhieuThu.Size = new Size(200, 48);
            btnPhieuThu.TabIndex = 8;
            btnPhieuThu.Text = "Phiếu thu";
            btnPhieuThu.TextAlign = ContentAlignment.MiddleLeft;
            btnPhieuThu.UseVisualStyleBackColor = true;
            btnPhieuThu.Click += button2_Click;
            // 
            // btnMuonTra
            // 
            btnMuonTra.Dock = DockStyle.Top;
            btnMuonTra.FlatAppearance.BorderSize = 0;
            btnMuonTra.FlatStyle = FlatStyle.Flat;
            btnMuonTra.Font = new Font("Times New Roman", 10F);
            btnMuonTra.ForeColor = Color.FromArgb(73, 75, 116);
            btnMuonTra.Location = new Point(0, 359);
            btnMuonTra.Name = "btnMuonTra";
            btnMuonTra.Size = new Size(200, 48);
            btnMuonTra.TabIndex = 4;
            btnMuonTra.Text = "Mượn Trả sách";
            btnMuonTra.TextAlign = ContentAlignment.MiddleLeft;
            btnMuonTra.UseVisualStyleBackColor = true;
            btnMuonTra.Click += btnMuonTra_Click;
            // 
            // btnNhaXuatBan
            // 
            btnNhaXuatBan.Dock = DockStyle.Top;
            btnNhaXuatBan.FlatAppearance.BorderSize = 0;
            btnNhaXuatBan.FlatStyle = FlatStyle.Flat;
            btnNhaXuatBan.Font = new Font("Times New Roman", 10F);
            btnNhaXuatBan.ForeColor = Color.FromArgb(73, 75, 116);
            btnNhaXuatBan.Location = new Point(0, 311);
            btnNhaXuatBan.Name = "btnNhaXuatBan";
            btnNhaXuatBan.Size = new Size(200, 48);
            btnNhaXuatBan.TabIndex = 6;
            btnNhaXuatBan.Text = "Nhà xuất bản";
            btnNhaXuatBan.TextAlign = ContentAlignment.MiddleLeft;
            btnNhaXuatBan.UseVisualStyleBackColor = true;
            btnNhaXuatBan.Click += button1_Click;
            // 
            // btnTacGia
            // 
            btnTacGia.Dock = DockStyle.Top;
            btnTacGia.FlatAppearance.BorderSize = 0;
            btnTacGia.FlatStyle = FlatStyle.Flat;
            btnTacGia.Font = new Font("Times New Roman", 10F);
            btnTacGia.ForeColor = Color.FromArgb(73, 75, 116);
            btnTacGia.Location = new Point(0, 263);
            btnTacGia.Name = "btnTacGia";
            btnTacGia.Size = new Size(200, 48);
            btnTacGia.TabIndex = 9;
            btnTacGia.Text = "Tác giả";
            btnTacGia.TextAlign = ContentAlignment.MiddleLeft;
            btnTacGia.UseVisualStyleBackColor = true;
            btnTacGia.Click += button3_Click;
            // 
            // btnTheLoai
            // 
            btnTheLoai.Dock = DockStyle.Top;
            btnTheLoai.FlatAppearance.BorderSize = 0;
            btnTheLoai.FlatStyle = FlatStyle.Flat;
            btnTheLoai.Font = new Font("Times New Roman", 10F);
            btnTheLoai.ForeColor = Color.FromArgb(73, 75, 116);
            btnTheLoai.Location = new Point(0, 215);
            btnTheLoai.Name = "btnTheLoai";
            btnTheLoai.Size = new Size(200, 48);
            btnTheLoai.TabIndex = 10;
            btnTheLoai.Text = "Thể loại";
            btnTheLoai.TextAlign = ContentAlignment.MiddleLeft;
            btnTheLoai.UseVisualStyleBackColor = true;
            btnTheLoai.Click += btnTheLoai_Click;
            // 
            // btnSach
            // 
            btnSach.Dock = DockStyle.Top;
            btnSach.FlatAppearance.BorderSize = 0;
            btnSach.FlatStyle = FlatStyle.Flat;
            btnSach.Font = new Font("Times New Roman", 10F);
            btnSach.ForeColor = Color.FromArgb(73, 75, 116);
            btnSach.Location = new Point(0, 167);
            btnSach.Name = "btnSach";
            btnSach.Size = new Size(200, 48);
            btnSach.TabIndex = 1;
            btnSach.Text = "Thư viện";
            btnSach.TextAlign = ContentAlignment.MiddleLeft;
            btnSach.UseVisualStyleBackColor = true;
            btnSach.Click += btnSach_Click;
            // 
            // btnGoi
            // 
            btnGoi.Dock = DockStyle.Top;
            btnGoi.FlatAppearance.BorderSize = 0;
            btnGoi.FlatStyle = FlatStyle.Flat;
            btnGoi.Font = new Font("Times New Roman", 10F);
            btnGoi.ForeColor = Color.FromArgb(73, 75, 116);
            btnGoi.Location = new Point(0, 119);
            btnGoi.Name = "btnGoi";
            btnGoi.Size = new Size(200, 48);
            btnGoi.TabIndex = 3;
            btnGoi.Text = "Gói thành viên";
            btnGoi.TextAlign = ContentAlignment.MiddleLeft;
            btnGoi.UseVisualStyleBackColor = true;
            btnGoi.Click += btnGoi_Click;
            // 
            // btnThanhVien
            // 
            btnThanhVien.Dock = DockStyle.Top;
            btnThanhVien.FlatAppearance.BorderSize = 0;
            btnThanhVien.FlatStyle = FlatStyle.Flat;
            btnThanhVien.Font = new Font("Times New Roman", 10F);
            btnThanhVien.ForeColor = Color.FromArgb(73, 75, 116);
            btnThanhVien.Location = new Point(0, 71);
            btnThanhVien.Name = "btnThanhVien";
            btnThanhVien.Size = new Size(200, 48);
            btnThanhVien.TabIndex = 0;
            btnThanhVien.Text = "Thành viên";
            btnThanhVien.TextAlign = ContentAlignment.MiddleLeft;
            btnThanhVien.UseVisualStyleBackColor = true;
            btnThanhVien.Click += btnThanhVien_Click;
            // 
            // btnNhanVien
            // 
            btnNhanVien.Dock = DockStyle.Top;
            btnNhanVien.FlatAppearance.BorderSize = 0;
            btnNhanVien.FlatStyle = FlatStyle.Flat;
            btnNhanVien.Font = new Font("Times New Roman", 10F);
            btnNhanVien.ForeColor = Color.FromArgb(73, 75, 116);
            btnNhanVien.Location = new Point(0, 23);
            btnNhanVien.Name = "btnNhanVien";
            btnNhanVien.Size = new Size(200, 48);
            btnNhanVien.TabIndex = 7;
            btnNhanVien.Text = "Nhân viên";
            btnNhanVien.TextAlign = ContentAlignment.MiddleLeft;
            btnNhanVien.UseVisualStyleBackColor = true;
            btnNhanVien.Click += btnNhanVien_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI Black", 10F);
            lblTitle.ForeColor = Color.FromArgb(162, 163, 183);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(178, 23);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "QUẢN LÝ THƯ VIỆN";
            lblTitle.Click += lblTitle_Click;
            // 
            // pnlContent
            // 
            pnlContent.BackColor = SystemColors.Control;
            pnlContent.Controls.Add(menuStrip1);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Font = new Font("Times New Roman", 9F);
            pnlContent.Location = new Point(200, 0);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1182, 574);
            pnlContent.TabIndex = 0;
            pnlContent.Paint += pnlContent_Paint;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(30, 30, 45);
            menuStrip1.Font = new Font("Times New Roman", 9F);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuHeThong, mnuQuanLy, mnuBaoCaoThongKe, mnuTroGiup });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1182, 27);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuHeThong
            // 
            mnuHeThong.DropDownItems.AddRange(new ToolStripItem[] { mnuDangNhap, mnuDangXuat, mnuDoiMatKhau, toolStripSeparator1, mnuThoat });
            mnuHeThong.Font = new Font("Times New Roman", 10F);
            mnuHeThong.ForeColor = Color.FromArgb(162, 163, 183);
            mnuHeThong.Name = "mnuHeThong";
            mnuHeThong.ShortcutKeys = Keys.Alt | Keys.F4;
            mnuHeThong.Size = new Size(85, 23);
            mnuHeThong.Text = "&Hệ thống";
            // 
            // mnuDangNhap
            // 
            mnuDangNhap.ForeColor = Color.FromArgb(162, 163, 183);
            mnuDangNhap.Name = "mnuDangNhap";
            mnuDangNhap.Size = new Size(199, 26);
            mnuDangNhap.Text = "Đăng &nhập…";
            mnuDangNhap.Click += mnuDangNhap_Click;
            // 
            // mnuDangXuat
            // 
            mnuDangXuat.ForeColor = Color.FromArgb(162, 163, 183);
            mnuDangXuat.Name = "mnuDangXuat";
            mnuDangXuat.Size = new Size(199, 26);
            mnuDangXuat.Text = "Đăng &xuất";
            mnuDangXuat.Click += mnuDangXuat_Click;
            // 
            // mnuDoiMatKhau
            // 
            mnuDoiMatKhau.ForeColor = Color.FromArgb(162, 163, 183);
            mnuDoiMatKhau.Name = "mnuDoiMatKhau";
            mnuDoiMatKhau.Size = new Size(199, 26);
            mnuDoiMatKhau.Text = "Đổi &mật khẩu…";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(196, 6);
            // 
            // mnuThoat
            // 
            mnuThoat.ForeColor = Color.FromArgb(162, 163, 183);
            mnuThoat.Name = "mnuThoat";
            mnuThoat.ShortcutKeys = Keys.Alt | Keys.F4;
            mnuThoat.Size = new Size(199, 26);
            mnuThoat.Text = "&Thoát";
            // 
            // mnuQuanLy
            // 
            mnuQuanLy.DropDownItems.AddRange(new ToolStripItem[] { mnuTheLoai, mnuTacGia, mnuNhaXuatBan, mnuSach, toolStripSeparator2, btnGoiThanhVien, mnuThanhVien, mnuNhanVien, toolStripSeparator3, mnuPhieuMuon, mnuPhieuThu });
            mnuQuanLy.Font = new Font("Times New Roman", 10F);
            mnuQuanLy.ForeColor = Color.FromArgb(162, 163, 183);
            mnuQuanLy.Name = "mnuQuanLy";
            mnuQuanLy.Size = new Size(75, 23);
            mnuQuanLy.Text = "&Quản lý";
            // 
            // mnuTheLoai
            // 
            mnuTheLoai.ForeColor = Color.FromArgb(162, 163, 183);
            mnuTheLoai.Name = "mnuTheLoai";
            mnuTheLoai.Size = new Size(202, 26);
            mnuTheLoai.Text = "Thể &loại...";
            mnuTheLoai.Click += thểToolStripMenuItem_Click;
            // 
            // mnuTacGia
            // 
            mnuTacGia.ForeColor = Color.FromArgb(162, 163, 183);
            mnuTacGia.Name = "mnuTacGia";
            mnuTacGia.Size = new Size(202, 26);
            mnuTacGia.Text = "Tá&c giả...";
            mnuTacGia.Click += tácGiảToolStripMenuItem_Click;
            // 
            // mnuNhaXuatBan
            // 
            mnuNhaXuatBan.ForeColor = Color.FromArgb(162, 163, 183);
            mnuNhaXuatBan.Name = "mnuNhaXuatBan";
            mnuNhaXuatBan.Size = new Size(202, 26);
            mnuNhaXuatBan.Text = "Nhà &xuất bản...";
            mnuNhaXuatBan.Click += nhàXuấtToolStripMenuItem_Click;
            // 
            // mnuSach
            // 
            mnuSach.ForeColor = Color.FromArgb(162, 163, 183);
            mnuSach.Name = "mnuSach";
            mnuSach.Size = new Size(202, 26);
            mnuSach.Text = "&Sách...";
            mnuSach.Click += mnuSach_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(199, 6);
            // 
            // btnGoiThanhVien
            // 
            btnGoiThanhVien.ForeColor = Color.FromArgb(162, 163, 183);
            btnGoiThanhVien.Name = "btnGoiThanhVien";
            btnGoiThanhVien.Size = new Size(202, 26);
            btnGoiThanhVien.Text = "&Gói thành viên...";
            btnGoiThanhVien.Click += btnGoiThanhVien_Click;
            // 
            // mnuThanhVien
            // 
            mnuThanhVien.ForeColor = Color.FromArgb(162, 163, 183);
            mnuThanhVien.Name = "mnuThanhVien";
            mnuThanhVien.Size = new Size(202, 26);
            mnuThanhVien.Text = "&Thành viên...";
            mnuThanhVien.Click += mnuThanhVien_Click;
            // 
            // mnuNhanVien
            // 
            mnuNhanVien.ForeColor = Color.FromArgb(162, 163, 183);
            mnuNhanVien.Name = "mnuNhanVien";
            mnuNhanVien.Size = new Size(202, 26);
            mnuNhanVien.Text = "&Nhân viên...";
            mnuNhanVien.Click += mnuNhanVien_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(199, 6);
            // 
            // mnuPhieuMuon
            // 
            mnuPhieuMuon.ForeColor = Color.FromArgb(162, 163, 183);
            mnuPhieuMuon.Name = "mnuPhieuMuon";
            mnuPhieuMuon.Size = new Size(202, 26);
            mnuPhieuMuon.Text = "Phiếu &mượn...";
            mnuPhieuMuon.Click += mnuPhieuMuon_Click;
            // 
            // mnuPhieuThu
            // 
            mnuPhieuThu.ForeColor = Color.FromArgb(162, 163, 183);
            mnuPhieuThu.Name = "mnuPhieuThu";
            mnuPhieuThu.Size = new Size(202, 26);
            mnuPhieuThu.Text = "Phiếu &thu...";
            mnuPhieuThu.Click += mnuPhieuThu_Click;
            // 
            // mnuBaoCaoThongKe
            // 
            mnuBaoCaoThongKe.DropDownItems.AddRange(new ToolStripItem[] { mnuThongKeHoatDong, mnuThongKeDoanhThu });
            mnuBaoCaoThongKe.Font = new Font("Times New Roman", 10F);
            mnuBaoCaoThongKe.ForeColor = Color.FromArgb(162, 163, 183);
            mnuBaoCaoThongKe.Name = "mnuBaoCaoThongKe";
            mnuBaoCaoThongKe.Size = new Size(157, 23);
            mnuBaoCaoThongKe.Text = "&Báo cáo – Thống kê";
            // 
            // mnuThongKeHoatDong
            // 
            mnuThongKeHoatDong.ForeColor = Color.FromArgb(162, 163, 183);
            mnuThongKeHoatDong.Name = "mnuThongKeHoatDong";
            mnuThongKeHoatDong.Size = new Size(237, 26);
            mnuThongKeHoatDong.Text = "Thống kê &hoạt động...";
            // 
            // mnuThongKeDoanhThu
            // 
            mnuThongKeDoanhThu.ForeColor = Color.FromArgb(162, 163, 183);
            mnuThongKeDoanhThu.Name = "mnuThongKeDoanhThu";
            mnuThongKeDoanhThu.Size = new Size(237, 26);
            mnuThongKeDoanhThu.Text = "Thống kê &doanh thu...";
            // 
            // mnuTroGiup
            // 
            mnuTroGiup.DropDownItems.AddRange(new ToolStripItem[] { mnuHuongDanSuDung, mnuThongTinPhanMem });
            mnuTroGiup.Font = new Font("Times New Roman", 10F);
            mnuTroGiup.ForeColor = Color.FromArgb(162, 163, 183);
            mnuTroGiup.Name = "mnuTroGiup";
            mnuTroGiup.Size = new Size(79, 23);
            mnuTroGiup.Text = "&Trợ giúp";
            // 
            // mnuHuongDanSuDung
            // 
            mnuHuongDanSuDung.ForeColor = Color.FromArgb(162, 163, 183);
            mnuHuongDanSuDung.Name = "mnuHuongDanSuDung";
            mnuHuongDanSuDung.ShortcutKeys = Keys.Control | Keys.F1;
            mnuHuongDanSuDung.Size = new Size(285, 26);
            mnuHuongDanSuDung.Text = "&Hướng dẫn sử dụng";
            // 
            // mnuThongTinPhanMem
            // 
            mnuThongTinPhanMem.ForeColor = Color.FromArgb(162, 163, 183);
            mnuThongTinPhanMem.Name = "mnuThongTinPhanMem";
            mnuThongTinPhanMem.Size = new Size(285, 26);
            mnuThongTinPhanMem.Text = "&Thông tin phần mềm...";
            // 
            // pnlFooter
            // 
            pnlFooter.Controls.Add(statusStrip1);
            pnlFooter.Dock = DockStyle.Bottom;
            pnlFooter.Location = new Point(0, 574);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(1382, 29);
            pnlFooter.TabIndex = 1;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblTrangThai, toolStripStatusLabel1, lblLienKet });
            statusStrip1.Location = new Point(0, 3);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1382, 26);
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
            toolStripStatusLabel1.Size = new Size(1126, 20);
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
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1382, 603);
            Controls.Add(pnlContent);
            Controls.Add(pnlSidebar);
            Controls.Add(pnlFooter);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(1400, 650);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý thư viện";
            WindowState = FormWindowState.Minimized;
            Load += frmMain_Load;
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            pnlContent.ResumeLayout(false);
            pnlContent.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pnlFooter.ResumeLayout(false);
            pnlFooter.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlSidebar;
        private Panel pnlContent;
        private Button btnThanhVien;
        private Button btnMuonTra;
        private Button btnGoi;
        private Button btnSach;
        private Label lblTitle;
        private Button btnNhanVien;
        private Button btnNhaXuatBan;
        private Button btnTacGia;
        private Button btnPhieuThu;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuHeThong;
        private ToolStripMenuItem mnuDangNhap;
        private ToolStripMenuItem mnuDangXuat;
        private ToolStripMenuItem mnuDoiMatKhau;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem mnuThoat;
        private ToolStripMenuItem mnuQuanLy;
        private ToolStripMenuItem mnuBaoCaoThongKe;
        private ToolStripMenuItem mnuTroGiup;
        private Button btnTheLoai;
        private ToolStripMenuItem mnuTheLoai;
        private ToolStripMenuItem mnuTacGia;
        private ToolStripMenuItem mnuNhaXuatBan;
        private ToolStripMenuItem mnuSach;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem btnGoiThanhVien;
        private ToolStripMenuItem mnuThanhVien;
        private ToolStripMenuItem mnuNhanVien;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem mnuPhieuMuon;
        private ToolStripMenuItem mnuPhieuThu;
        private ToolStripMenuItem mnuThongKeHoatDong;
        private ToolStripMenuItem mnuThongKeDoanhThu;
        private ToolStripMenuItem mnuHuongDanSuDung;
        private ToolStripMenuItem mnuThongTinPhanMem;
        private Panel pnlFooter;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblTrangThai;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel lblLienKet;
    }
}