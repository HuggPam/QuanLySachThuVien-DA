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
            btnTheLoai = new Button();
            button3 = new Button();
            btnPhieuThu = new Button();
            btnNhanVien = new Button();
            btnNXB = new Button();
            lblTitle = new Label();
            btnMuonTra = new Button();
            btnGoi = new Button();
            btnSach = new Button();
            btnThanhVien = new Button();
            pnlContent = new Panel();
            menuStrip1 = new MenuStrip();
            mnuHeThong = new ToolStripMenuItem();
            đăngNhậpToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            đổiMậtKhẩuToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            mnuQuanLy = new ToolStripMenuItem();
            thểToolStripMenuItem = new ToolStripMenuItem();
            mnuBaoCaoThongKe = new ToolStripMenuItem();
            mnuTroGiup = new ToolStripMenuItem();
            tácGiảToolStripMenuItem = new ToolStripMenuItem();
            nhàXuấtToolStripMenuItem = new ToolStripMenuItem();
            sáchToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            góiThànhViênToolStripMenuItem = new ToolStripMenuItem();
            thànhViênToolStripMenuItem = new ToolStripMenuItem();
            nhânViênToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            phiếuMượnToolStripMenuItem = new ToolStripMenuItem();
            phiếuThuToolStripMenuItem = new ToolStripMenuItem();
            thốngToolStripMenuItem = new ToolStripMenuItem();
            thốngKêDoanhToolStripMenuItem = new ToolStripMenuItem();
            hướngDẫnSửDụngToolStripMenuItem = new ToolStripMenuItem();
            thôngTinPhầnMềmToolStripMenuItem = new ToolStripMenuItem();
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
            pnlSidebar.Controls.Add(btnTheLoai);
            pnlSidebar.Controls.Add(button3);
            pnlSidebar.Controls.Add(btnPhieuThu);
            pnlSidebar.Controls.Add(btnNhanVien);
            pnlSidebar.Controls.Add(btnNXB);
            pnlSidebar.Controls.Add(lblTitle);
            pnlSidebar.Controls.Add(btnMuonTra);
            pnlSidebar.Controls.Add(btnGoi);
            pnlSidebar.Controls.Add(btnSach);
            pnlSidebar.Controls.Add(btnThanhVien);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(200, 574);
            pnlSidebar.TabIndex = 0;
            pnlSidebar.Paint += pnlSidebar_Paint;
            // 
            // btnTheLoai
            // 
            btnTheLoai.FlatAppearance.BorderSize = 0;
            btnTheLoai.FlatStyle = FlatStyle.Flat;
            btnTheLoai.Font = new Font("Times New Roman", 10F);
            btnTheLoai.ForeColor = Color.FromArgb(73, 75, 116);
            btnTheLoai.Location = new Point(0, 292);
            btnTheLoai.Name = "btnTheLoai";
            btnTheLoai.Size = new Size(197, 48);
            btnTheLoai.TabIndex = 10;
            btnTheLoai.Text = "Thể loại";
            btnTheLoai.TextAlign = ContentAlignment.MiddleLeft;
            btnTheLoai.UseVisualStyleBackColor = true;
            btnTheLoai.Click += btnTheLoai_Click;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Times New Roman", 10F);
            button3.ForeColor = Color.FromArgb(73, 75, 116);
            button3.Location = new Point(-3, 349);
            button3.Name = "button3";
            button3.Size = new Size(197, 48);
            button3.TabIndex = 9;
            button3.Text = "Tác giả";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btnPhieuThu
            // 
            btnPhieuThu.FlatAppearance.BorderSize = 0;
            btnPhieuThu.FlatStyle = FlatStyle.Flat;
            btnPhieuThu.Font = new Font("Times New Roman", 10F);
            btnPhieuThu.ForeColor = Color.FromArgb(73, 75, 116);
            btnPhieuThu.Location = new Point(3, 520);
            btnPhieuThu.Name = "btnPhieuThu";
            btnPhieuThu.Size = new Size(197, 48);
            btnPhieuThu.TabIndex = 8;
            btnPhieuThu.Text = "Phiếu thu";
            btnPhieuThu.TextAlign = ContentAlignment.MiddleLeft;
            btnPhieuThu.UseVisualStyleBackColor = true;
            btnPhieuThu.Click += button2_Click;
            // 
            // btnNhanVien
            // 
            btnNhanVien.FlatAppearance.BorderSize = 0;
            btnNhanVien.FlatStyle = FlatStyle.Flat;
            btnNhanVien.Font = new Font("Times New Roman", 10F);
            btnNhanVien.ForeColor = Color.FromArgb(73, 75, 116);
            btnNhanVien.Location = new Point(0, 121);
            btnNhanVien.Name = "btnNhanVien";
            btnNhanVien.Size = new Size(197, 48);
            btnNhanVien.TabIndex = 7;
            btnNhanVien.Text = "Nhân viên";
            btnNhanVien.TextAlign = ContentAlignment.MiddleLeft;
            btnNhanVien.UseVisualStyleBackColor = true;
            btnNhanVien.Click += btnNhanVien_Click;
            // 
            // btnNXB
            // 
            btnNXB.FlatAppearance.BorderSize = 0;
            btnNXB.FlatStyle = FlatStyle.Flat;
            btnNXB.Font = new Font("Times New Roman", 10F);
            btnNXB.ForeColor = Color.FromArgb(73, 75, 116);
            btnNXB.Location = new Point(-3, 406);
            btnNXB.Name = "btnNXB";
            btnNXB.Size = new Size(197, 48);
            btnNXB.TabIndex = 6;
            btnNXB.Text = "Nhà xuất bản";
            btnNXB.TextAlign = ContentAlignment.MiddleLeft;
            btnNXB.UseVisualStyleBackColor = true;
            btnNXB.Click += button1_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Black", 10F);
            lblTitle.ForeColor = Color.FromArgb(162, 163, 183);
            lblTitle.Location = new Point(12, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(178, 23);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "QUẢN LÝ THƯ VIỆN";
            // 
            // btnMuonTra
            // 
            btnMuonTra.FlatAppearance.BorderSize = 0;
            btnMuonTra.FlatStyle = FlatStyle.Flat;
            btnMuonTra.Font = new Font("Times New Roman", 10F);
            btnMuonTra.ForeColor = Color.FromArgb(73, 75, 116);
            btnMuonTra.Location = new Point(0, 463);
            btnMuonTra.Name = "btnMuonTra";
            btnMuonTra.Size = new Size(197, 48);
            btnMuonTra.TabIndex = 4;
            btnMuonTra.Text = "Mượn Trả sách";
            btnMuonTra.TextAlign = ContentAlignment.MiddleLeft;
            btnMuonTra.UseVisualStyleBackColor = true;
            btnMuonTra.Click += btnMuonTra_Click;
            // 
            // btnGoi
            // 
            btnGoi.FlatAppearance.BorderSize = 0;
            btnGoi.FlatStyle = FlatStyle.Flat;
            btnGoi.Font = new Font("Times New Roman", 10F);
            btnGoi.ForeColor = Color.FromArgb(73, 75, 116);
            btnGoi.Location = new Point(0, 178);
            btnGoi.Name = "btnGoi";
            btnGoi.Size = new Size(197, 48);
            btnGoi.TabIndex = 3;
            btnGoi.Text = "Gói thành viên";
            btnGoi.TextAlign = ContentAlignment.MiddleLeft;
            btnGoi.UseVisualStyleBackColor = true;
            btnGoi.Click += btnGoi_Click;
            // 
            // btnSach
            // 
            btnSach.FlatAppearance.BorderSize = 0;
            btnSach.FlatStyle = FlatStyle.Flat;
            btnSach.Font = new Font("Times New Roman", 10F);
            btnSach.ForeColor = Color.FromArgb(73, 75, 116);
            btnSach.Location = new Point(3, 235);
            btnSach.Name = "btnSach";
            btnSach.Size = new Size(197, 48);
            btnSach.TabIndex = 1;
            btnSach.Text = "Thư viện";
            btnSach.TextAlign = ContentAlignment.MiddleLeft;
            btnSach.UseVisualStyleBackColor = true;
            btnSach.Click += btnSach_Click;
            // 
            // btnThanhVien
            // 
            btnThanhVien.FlatAppearance.BorderSize = 0;
            btnThanhVien.FlatStyle = FlatStyle.Flat;
            btnThanhVien.Font = new Font("Times New Roman", 10F);
            btnThanhVien.ForeColor = Color.FromArgb(73, 75, 116);
            btnThanhVien.Location = new Point(0, 64);
            btnThanhVien.Name = "btnThanhVien";
            btnThanhVien.Size = new Size(197, 48);
            btnThanhVien.TabIndex = 0;
            btnThanhVien.Text = "Thành viên";
            btnThanhVien.TextAlign = ContentAlignment.MiddleLeft;
            btnThanhVien.UseVisualStyleBackColor = true;
            btnThanhVien.Click += btnThanhVien_Click;
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
            mnuHeThong.DropDownItems.AddRange(new ToolStripItem[] { đăngNhậpToolStripMenuItem, đăngXuấtToolStripMenuItem, đổiMậtKhẩuToolStripMenuItem, toolStripSeparator1, thoátToolStripMenuItem });
            mnuHeThong.Font = new Font("Times New Roman", 10F);
            mnuHeThong.Name = "mnuHeThong";
            mnuHeThong.ShortcutKeys = Keys.Alt | Keys.F4;
            mnuHeThong.Size = new Size(85, 23);
            mnuHeThong.Text = "Hệ thống";
            // 
            // đăngNhậpToolStripMenuItem
            // 
            đăngNhậpToolStripMenuItem.Name = "đăngNhậpToolStripMenuItem";
            đăngNhậpToolStripMenuItem.Size = new Size(224, 26);
            đăngNhậpToolStripMenuItem.Text = "Đăng nhập…";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(224, 26);
            đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            đổiMậtKhẩuToolStripMenuItem.Size = new Size(224, 26);
            đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu…";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(221, 6);
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
            thoátToolStripMenuItem.Size = new Size(224, 26);
            thoátToolStripMenuItem.Text = "Thoát";
            // 
            // mnuQuanLy
            // 
            mnuQuanLy.DropDownItems.AddRange(new ToolStripItem[] { thểToolStripMenuItem, tácGiảToolStripMenuItem, nhàXuấtToolStripMenuItem, sáchToolStripMenuItem, toolStripSeparator2, góiThànhViênToolStripMenuItem, thànhViênToolStripMenuItem, nhânViênToolStripMenuItem, toolStripSeparator3, phiếuMượnToolStripMenuItem, phiếuThuToolStripMenuItem });
            mnuQuanLy.Font = new Font("Times New Roman", 10F);
            mnuQuanLy.Name = "mnuQuanLy";
            mnuQuanLy.Size = new Size(75, 23);
            mnuQuanLy.Text = "Quản lý";
            // 
            // thểToolStripMenuItem
            // 
            thểToolStripMenuItem.Name = "thểToolStripMenuItem";
            thểToolStripMenuItem.Size = new Size(202, 26);
            thểToolStripMenuItem.Text = "Thể loại...";
            thểToolStripMenuItem.Click += thểToolStripMenuItem_Click;
            // 
            // mnuBaoCaoThongKe
            // 
            mnuBaoCaoThongKe.DropDownItems.AddRange(new ToolStripItem[] { thốngToolStripMenuItem, thốngKêDoanhToolStripMenuItem });
            mnuBaoCaoThongKe.Font = new Font("Times New Roman", 10F);
            mnuBaoCaoThongKe.Name = "mnuBaoCaoThongKe";
            mnuBaoCaoThongKe.Size = new Size(157, 23);
            mnuBaoCaoThongKe.Text = "Báo cáo – Thống kê";
            // 
            // mnuTroGiup
            // 
            mnuTroGiup.DropDownItems.AddRange(new ToolStripItem[] { hướngDẫnSửDụngToolStripMenuItem, thôngTinPhầnMềmToolStripMenuItem });
            mnuTroGiup.Font = new Font("Times New Roman", 10F);
            mnuTroGiup.Name = "mnuTroGiup";
            mnuTroGiup.Size = new Size(79, 23);
            mnuTroGiup.Text = "Trợ giúp";
            // 
            // tácGiảToolStripMenuItem
            // 
            tácGiảToolStripMenuItem.Name = "tácGiảToolStripMenuItem";
            tácGiảToolStripMenuItem.Size = new Size(202, 26);
            tácGiảToolStripMenuItem.Text = "Tác giả...";
            // 
            // nhàXuấtToolStripMenuItem
            // 
            nhàXuấtToolStripMenuItem.Name = "nhàXuấtToolStripMenuItem";
            nhàXuấtToolStripMenuItem.Size = new Size(202, 26);
            nhàXuấtToolStripMenuItem.Text = "Nhà xuất bản...";
            nhàXuấtToolStripMenuItem.Click += nhàXuấtToolStripMenuItem_Click;
            // 
            // sáchToolStripMenuItem
            // 
            sáchToolStripMenuItem.Name = "sáchToolStripMenuItem";
            sáchToolStripMenuItem.Size = new Size(202, 26);
            sáchToolStripMenuItem.Text = "Sách...";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(199, 6);
            // 
            // góiThànhViênToolStripMenuItem
            // 
            góiThànhViênToolStripMenuItem.Name = "góiThànhViênToolStripMenuItem";
            góiThànhViênToolStripMenuItem.Size = new Size(202, 26);
            góiThànhViênToolStripMenuItem.Text = "Gói thành viên...";
            // 
            // thànhViênToolStripMenuItem
            // 
            thànhViênToolStripMenuItem.Name = "thànhViênToolStripMenuItem";
            thànhViênToolStripMenuItem.Size = new Size(202, 26);
            thànhViênToolStripMenuItem.Text = "Thành viên...";
            // 
            // nhânViênToolStripMenuItem
            // 
            nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            nhânViênToolStripMenuItem.Size = new Size(202, 26);
            nhânViênToolStripMenuItem.Text = "Nhân viên...";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(199, 6);
            // 
            // phiếuMượnToolStripMenuItem
            // 
            phiếuMượnToolStripMenuItem.Name = "phiếuMượnToolStripMenuItem";
            phiếuMượnToolStripMenuItem.Size = new Size(202, 26);
            phiếuMượnToolStripMenuItem.Text = "Phiếu mượn...";
            // 
            // phiếuThuToolStripMenuItem
            // 
            phiếuThuToolStripMenuItem.Name = "phiếuThuToolStripMenuItem";
            phiếuThuToolStripMenuItem.Size = new Size(202, 26);
            phiếuThuToolStripMenuItem.Text = "Phiếu thu...";
            // 
            // thốngToolStripMenuItem
            // 
            thốngToolStripMenuItem.Name = "thốngToolStripMenuItem";
            thốngToolStripMenuItem.Size = new Size(237, 26);
            thốngToolStripMenuItem.Text = "Thống kê hoạt động...";
            // 
            // thốngKêDoanhToolStripMenuItem
            // 
            thốngKêDoanhToolStripMenuItem.Name = "thốngKêDoanhToolStripMenuItem";
            thốngKêDoanhToolStripMenuItem.Size = new Size(237, 26);
            thốngKêDoanhToolStripMenuItem.Text = "Thống kê doanh...";
            // 
            // hướngDẫnSửDụngToolStripMenuItem
            // 
            hướngDẫnSửDụngToolStripMenuItem.Name = "hướngDẫnSửDụngToolStripMenuItem";
            hướngDẫnSửDụngToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.F1;
            hướngDẫnSửDụngToolStripMenuItem.Size = new Size(285, 26);
            hướngDẫnSửDụngToolStripMenuItem.Text = "Hướng dẫn sử dụng";
            // 
            // thôngTinPhầnMềmToolStripMenuItem
            // 
            thôngTinPhầnMềmToolStripMenuItem.Name = "thôngTinPhầnMềmToolStripMenuItem";
            thôngTinPhầnMềmToolStripMenuItem.Size = new Size(285, 26);
            thôngTinPhầnMềmToolStripMenuItem.Text = "Thông tin phần mềm...";
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
            toolStripStatusLabel1.Size = new Size(1165, 20);
            toolStripStatusLabel1.Spring = true;
            // 
            // lblLienKet
            // 
            lblLienKet.IsLink = true;
            lblLienKet.Name = "lblLienKet";
            lblLienKet.Size = new Size(81, 20);
            lblLienKet.Text = "© 2024 FIT";
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
        private Button btnNXB;
        private Button button3;
        private Button btnPhieuThu;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuHeThong;
        private ToolStripMenuItem đăngNhậpToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private ToolStripMenuItem mnuQuanLy;
        private ToolStripMenuItem mnuBaoCaoThongKe;
        private ToolStripMenuItem mnuTroGiup;
        private Button btnTheLoai;
        private ToolStripMenuItem thểToolStripMenuItem;
        private ToolStripMenuItem tácGiảToolStripMenuItem;
        private ToolStripMenuItem nhàXuấtToolStripMenuItem;
        private ToolStripMenuItem sáchToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem góiThànhViênToolStripMenuItem;
        private ToolStripMenuItem thànhViênToolStripMenuItem;
        private ToolStripMenuItem nhânViênToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem phiếuMượnToolStripMenuItem;
        private ToolStripMenuItem phiếuThuToolStripMenuItem;
        private ToolStripMenuItem thốngToolStripMenuItem;
        private ToolStripMenuItem thốngKêDoanhToolStripMenuItem;
        private ToolStripMenuItem hướngDẫnSửDụngToolStripMenuItem;
        private ToolStripMenuItem thôngTinPhầnMềmToolStripMenuItem;
        private Panel pnlFooter;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblTrangThai;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel lblLienKet;
    }
}