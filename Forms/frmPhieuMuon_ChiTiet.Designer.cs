namespace QuanLyThuVien.Forms
{
    partial class frmPhieuMuon_ChiTiet
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            lblThongBao = new Label();
            cboThanhVien = new ComboBox();
            cboNhanVien = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            txtGhiChu = new TextBox();
            groupBox2 = new GroupBox();
            dgvPhieuMuonChiTiet = new DataGridView();
            label6 = new Label();
            dtpHanTra = new DateTimePicker();
            btnXoa = new Button();
            btnXacNhan = new Button();
            cboSach = new ComboBox();
            label4 = new Label();
            panel3 = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            btnGiaHan = new Button();
            btnHuyBo = new Button();
            btnLuuPhieuMuon = new Button();
            btnDong = new Button();
            btnTraSach = new Button();
            colID = new DataGridViewTextBoxColumn();
            colTenSach = new DataGridViewTextBoxColumn();
            colGhiChu = new DataGridViewTextBoxColumn();
            colGiaHan = new DataGridViewTextBoxColumn();
            colHanTra = new DataGridViewTextBoxColumn();
            colNgayTra = new DataGridViewTextBoxColumn();
            colTienPhat = new DataGridViewTextBoxColumn();
            colTrangThaiTra = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhieuMuonChiTiet).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblThongBao);
            groupBox1.Controls.Add(cboThanhVien);
            groupBox1.Controls.Add(cboNhanVien);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(992, 93);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin phiếu mượn";
            // 
            // lblThongBao
            // 
            lblThongBao.Anchor = AnchorStyles.Top;
            lblThongBao.AutoSize = true;
            lblThongBao.Font = new Font("Segoe UI", 8F);
            lblThongBao.Location = new Point(803, 49);
            lblThongBao.Name = "lblThongBao";
            lblThongBao.Size = new Size(110, 19);
            lblThongBao.TabIndex = 6;
            lblThongBao.Text = "Trạng thái mượn";
            // 
            // cboThanhVien
            // 
            cboThanhVien.Anchor = AnchorStyles.Top;
            cboThanhVien.FormattingEnabled = true;
            cboThanhVien.Location = new Point(575, 43);
            cboThanhVien.Name = "cboThanhVien";
            cboThanhVien.Size = new Size(206, 28);
            cboThanhVien.TabIndex = 4;
            cboThanhVien.SelectedIndexChanged += cboThanhVien_SelectedIndexChanged;
            // 
            // cboNhanVien
            // 
            cboNhanVien.Anchor = AnchorStyles.Top;
            cboNhanVien.FormattingEnabled = true;
            cboNhanVien.Location = new Point(151, 43);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(237, 28);
            cboNhanVien.TabIndex = 3;
            cboNhanVien.SelectedIndexChanged += cboNhanVien_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(486, 46);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 1;
            label2.Text = "Thành viên:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(58, 43);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 0;
            label1.Text = "Thủ thư lập:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Location = new Point(69, 86);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 2;
            label3.Text = "Ghi chú:";
            // 
            // txtGhiChu
            // 
            txtGhiChu.AcceptsReturn = true;
            txtGhiChu.Anchor = AnchorStyles.Top;
            txtGhiChu.Location = new Point(142, 83);
            txtGhiChu.Multiline = true;
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.ScrollBars = ScrollBars.Vertical;
            txtGhiChu.Size = new Size(782, 40);
            txtGhiChu.TabIndex = 13;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvPhieuMuonChiTiet);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(dtpHanTra);
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnXacNhan);
            groupBox2.Controls.Add(txtGhiChu);
            groupBox2.Controls.Add(cboSach);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(panel3);
            groupBox2.Controls.Add(panel1);
            groupBox2.Controls.Add(panel2);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 93);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(992, 442);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chi tiết phiếu mượn";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // dgvPhieuMuonChiTiet
            // 
            dgvPhieuMuonChiTiet.AllowUserToAddRows = false;
            dgvPhieuMuonChiTiet.AllowUserToDeleteRows = false;
            dgvPhieuMuonChiTiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhieuMuonChiTiet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPhieuMuonChiTiet.Columns.AddRange(new DataGridViewColumn[] { colID, colTenSach, colGhiChu, colGiaHan, colHanTra, colNgayTra, colTienPhat, colTrangThaiTra });
            dgvPhieuMuonChiTiet.Dock = DockStyle.Fill;
            dgvPhieuMuonChiTiet.Location = new Point(3, 132);
            dgvPhieuMuonChiTiet.Name = "dgvPhieuMuonChiTiet";
            dgvPhieuMuonChiTiet.RowHeadersVisible = false;
            dgvPhieuMuonChiTiet.RowHeadersWidth = 51;
            dgvPhieuMuonChiTiet.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPhieuMuonChiTiet.Size = new Size(986, 251);
            dgvPhieuMuonChiTiet.TabIndex = 14;
            dgvPhieuMuonChiTiet.CellContentClick += dgvPhieuMuonChiTiet_CellContentClick;
            dgvPhieuMuonChiTiet.CellFormatting += dgvPhieuMuonChiTiet_CellFormatting;
            dgvPhieuMuonChiTiet.SelectionChanged += dgvPhieuMuonChiTiet_SelectionChanged;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Location = new Point(421, 42);
            label6.Name = "label6";
            label6.Size = new Size(61, 20);
            label6.TabIndex = 18;
            label6.Text = "Hạn trả:";
            // 
            // dtpHanTra
            // 
            dtpHanTra.Anchor = AnchorStyles.Top;
            dtpHanTra.CustomFormat = "dd/MM/yyyy";
            dtpHanTra.Enabled = false;
            dtpHanTra.Format = DateTimePickerFormat.Custom;
            dtpHanTra.Location = new Point(488, 40);
            dtpHanTra.Name = "dtpHanTra";
            dtpHanTra.Size = new Size(159, 27);
            dtpHanTra.TabIndex = 17;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Top;
            btnXoa.Location = new Point(814, 39);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 16;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnXacNhan
            // 
            btnXacNhan.Anchor = AnchorStyles.Top;
            btnXacNhan.Location = new Point(698, 38);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(94, 29);
            btnXacNhan.TabIndex = 15;
            btnXacNhan.Text = "Xác nhận";
            btnXacNhan.UseVisualStyleBackColor = true;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // cboSach
            // 
            cboSach.Anchor = AnchorStyles.Top;
            cboSach.FormattingEnabled = true;
            cboSach.Location = new Point(142, 40);
            cboSach.Name = "cboSach";
            cboSach.Size = new Size(242, 28);
            cboSach.TabIndex = 1;
            cboSach.SelectedIndexChanged += cboSach_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Location = new Point(69, 45);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 0;
            label4.Text = "Sách:";
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 132);
            panel3.Name = "panel3";
            panel3.Size = new Size(986, 251);
            panel3.TabIndex = 21;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(986, 109);
            panel1.TabIndex = 19;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnGiaHan);
            panel2.Controls.Add(btnHuyBo);
            panel2.Controls.Add(btnLuuPhieuMuon);
            panel2.Controls.Add(btnDong);
            panel2.Controls.Add(btnTraSach);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(3, 383);
            panel2.Name = "panel2";
            panel2.Size = new Size(986, 56);
            panel2.TabIndex = 20;
            // 
            // btnGiaHan
            // 
            btnGiaHan.Location = new Point(772, 11);
            btnGiaHan.Name = "btnGiaHan";
            btnGiaHan.Size = new Size(94, 29);
            btnGiaHan.TabIndex = 22;
            btnGiaHan.Text = "Gia hạn";
            btnGiaHan.UseVisualStyleBackColor = true;
            btnGiaHan.Visible = false;
            btnGiaHan.Click += btnGiaHan_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(481, 11);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(94, 29);
            btnHuyBo.TabIndex = 21;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnLuuPhieuMuon
            // 
            btnLuuPhieuMuon.Anchor = AnchorStyles.Top;
            btnLuuPhieuMuon.Location = new Point(327, 11);
            btnLuuPhieuMuon.Name = "btnLuuPhieuMuon";
            btnLuuPhieuMuon.Size = new Size(144, 29);
            btnLuuPhieuMuon.TabIndex = 17;
            btnLuuPhieuMuon.Text = "Lưu phiếu mượn...";
            btnLuuPhieuMuon.UseVisualStyleBackColor = true;
            btnLuuPhieuMuon.Click += btnLuuPhieuMuon_Click;
            // 
            // btnDong
            // 
            btnDong.Location = new Point(581, 11);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(94, 29);
            btnDong.TabIndex = 20;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = true;
            btnDong.Click += btnDong_Click;
            // 
            // btnTraSach
            // 
            btnTraSach.Anchor = AnchorStyles.Top;
            btnTraSach.Location = new Point(872, 11);
            btnTraSach.Name = "btnTraSach";
            btnTraSach.Size = new Size(94, 29);
            btnTraSach.TabIndex = 19;
            btnTraSach.Text = "Trả sách";
            btnTraSach.UseVisualStyleBackColor = true;
            btnTraSach.Visible = false;
            btnTraSach.Click += btnTraSach_Click;
            // 
            // colID
            // 
            colID.DataPropertyName = "SachID";
            colID.FillWeight = 50F;
            colID.HeaderText = "ID";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            // 
            // colTenSach
            // 
            colTenSach.DataPropertyName = "TenSach";
            colTenSach.HeaderText = "Tên sách";
            colTenSach.MinimumWidth = 6;
            colTenSach.Name = "colTenSach";
            // 
            // colGhiChu
            // 
            colGhiChu.DataPropertyName = "GhiChu";
            colGhiChu.HeaderText = "Ghi chú";
            colGhiChu.MinimumWidth = 6;
            colGhiChu.Name = "colGhiChu";
            // 
            // colGiaHan
            // 
            colGiaHan.DataPropertyName = "SoLanGiaHan";
            colGiaHan.HeaderText = "Gia hạn";
            colGiaHan.MinimumWidth = 6;
            colGiaHan.Name = "colGiaHan";
            // 
            // colHanTra
            // 
            colHanTra.DataPropertyName = "HanTra";
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            dataGridViewCellStyle1.NullValue = null;
            colHanTra.DefaultCellStyle = dataGridViewCellStyle1;
            colHanTra.HeaderText = "Hạn trả";
            colHanTra.MinimumWidth = 6;
            colHanTra.Name = "colHanTra";
            // 
            // colNgayTra
            // 
            colNgayTra.DataPropertyName = "NgayTra";
            dataGridViewCellStyle2.Format = "dd/MM/yyyy";
            colNgayTra.DefaultCellStyle = dataGridViewCellStyle2;
            colNgayTra.HeaderText = "Ngày trả";
            colNgayTra.MinimumWidth = 6;
            colNgayTra.Name = "colNgayTra";
            // 
            // colTienPhat
            // 
            colTienPhat.DataPropertyName = "TienPhat";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "#,##0 VNĐ";
            dataGridViewCellStyle3.NullValue = null;
            colTienPhat.DefaultCellStyle = dataGridViewCellStyle3;
            colTienPhat.HeaderText = "Tiền phạt";
            colTienPhat.MinimumWidth = 6;
            colTienPhat.Name = "colTienPhat";
            // 
            // colTrangThaiTra
            // 
            colTrangThaiTra.DataPropertyName = "TrangThaiTra";
            colTrangThaiTra.HeaderText = "Trạng thái";
            colTrangThaiTra.MinimumWidth = 6;
            colTrangThaiTra.Name = "colTrangThaiTra";
            // 
            // frmPhieuMuon_ChiTiet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(992, 535);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmPhieuMuon_ChiTiet";
            Text = "Phiéu mượn chi tiết";
            Load += frmPhieuMuon_ChiTiet_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhieuMuonChiTiet).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cboThanhVien;
        private ComboBox cboNhanVien;
        private TextBox txtGhiChu;
        private GroupBox groupBox2;
        private ComboBox cboSach;
        private Label label4;
        private DataGridView dgvPhieuMuonChiTiet;
        private Button btnXoa;
        private Button btnXacNhan;
        private Button btnLuuPhieuMuon;
        private Label label6;
        private DateTimePicker dtpHanTra;
        private Label lblThongBao;
        private Button btnTraSach;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button btnHuyBo;
        private Button btnDong;
        private Button btnGiaHan;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colTenSach;
        private DataGridViewTextBoxColumn colGhiChu;
        private DataGridViewTextBoxColumn colGiaHan;
        private DataGridViewTextBoxColumn colHanTra;
        private DataGridViewTextBoxColumn colNgayTra;
        private DataGridViewTextBoxColumn colTienPhat;
        private DataGridViewTextBoxColumn colTrangThaiTra;
    }
}