namespace QuanLyThuVien.Forms
{
    partial class frmPhieuThu
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            dgvPhieuThu = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colNhanVien = new DataGridViewTextBoxColumn();
            colThanhVien = new DataGridViewTextBoxColumn();
            colNgayThu = new DataGridViewTextBoxColumn();
            colLoaiThu = new DataGridViewTextBoxColumn();
            colSoTienThu = new DataGridViewTextBoxColumn();
            colLyDo = new DataGridViewTextBoxColumn();
            btnXuat = new Button();
            btnInPhieuThu = new Button();
            btnTimKiem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnLapPhieuThu = new Button();
            groupBox2 = new GroupBox();
            txtTimKiem = new TextBox();
            cboLoaiThu = new ComboBox();
            label6 = new Label();
            dtpNgayThu = new DateTimePicker();
            label5 = new Label();
            txtLyDo = new TextBox();
            label4 = new Label();
            numSoTienThu = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtNhanVien = new TextBox();
            cboThanhVien = new ComboBox();
            btnLuu = new Button();
            btnHuy = new Button();
            panel1 = new Panel();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhieuThu).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSoTienThu).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvPhieuThu);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 165);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1311, 207);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách phiếu mượn";
            // 
            // dgvPhieuThu
            // 
            dgvPhieuThu.AllowUserToAddRows = false;
            dgvPhieuThu.AllowUserToDeleteRows = false;
            dgvPhieuThu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhieuThu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPhieuThu.Columns.AddRange(new DataGridViewColumn[] { colID, colNhanVien, colThanhVien, colNgayThu, colLoaiThu, colSoTienThu, colLyDo });
            dgvPhieuThu.Dock = DockStyle.Fill;
            dgvPhieuThu.Location = new Point(3, 23);
            dgvPhieuThu.Name = "dgvPhieuThu";
            dgvPhieuThu.RowHeadersVisible = false;
            dgvPhieuThu.RowHeadersWidth = 51;
            dgvPhieuThu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPhieuThu.Size = new Size(1305, 181);
            dgvPhieuThu.TabIndex = 0;
            dgvPhieuThu.CellClick += dgvPhieuThu_CellClick;
            dgvPhieuThu.CellFormatting += dgvPhieuThu_CellFormatting;
            // 
            // colID
            // 
            colID.DataPropertyName = "ID";
            colID.FillWeight = 50F;
            colID.HeaderText = "ID";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            // 
            // colNhanVien
            // 
            colNhanVien.DataPropertyName = "TenNhanVien";
            colNhanVien.HeaderText = "Thủ thư";
            colNhanVien.MinimumWidth = 6;
            colNhanVien.Name = "colNhanVien";
            // 
            // colThanhVien
            // 
            colThanhVien.DataPropertyName = "TenThanhVien";
            colThanhVien.HeaderText = "Thành viên";
            colThanhVien.MinimumWidth = 6;
            colThanhVien.Name = "colThanhVien";
            // 
            // colNgayThu
            // 
            colNgayThu.DataPropertyName = "NgayThu";
            dataGridViewCellStyle5.Format = "dd/MM/yyyy";
            dataGridViewCellStyle5.NullValue = null;
            colNgayThu.DefaultCellStyle = dataGridViewCellStyle5;
            colNgayThu.HeaderText = "Ngày thu";
            colNgayThu.MinimumWidth = 6;
            colNgayThu.Name = "colNgayThu";
            // 
            // colLoaiThu
            // 
            colLoaiThu.DataPropertyName = "LoaiThu";
            colLoaiThu.HeaderText = "Loại thu";
            colLoaiThu.MinimumWidth = 6;
            colLoaiThu.Name = "colLoaiThu";
            // 
            // colSoTienThu
            // 
            colSoTienThu.DataPropertyName = "SoTienThu";
            dataGridViewCellStyle6.Format = "#,##0 VNĐ";
            dataGridViewCellStyle6.NullValue = null;
            colSoTienThu.DefaultCellStyle = dataGridViewCellStyle6;
            colSoTienThu.FillWeight = 80F;
            colSoTienThu.HeaderText = "Số tiền thu";
            colSoTienThu.MinimumWidth = 6;
            colSoTienThu.Name = "colSoTienThu";
            // 
            // colLyDo
            // 
            colLyDo.DataPropertyName = "LyDoThu";
            colLyDo.HeaderText = "Lý do";
            colLyDo.MinimumWidth = 6;
            colLyDo.Name = "colLyDo";
            // 
            // btnXuat
            // 
            btnXuat.Anchor = AnchorStyles.Bottom;
            btnXuat.Location = new Point(1045, 27);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(94, 29);
            btnXuat.TabIndex = 16;
            btnXuat.Text = "Xuất Excel..";
            btnXuat.UseVisualStyleBackColor = true;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnInPhieuThu
            // 
            btnInPhieuThu.Anchor = AnchorStyles.Bottom;
            btnInPhieuThu.Location = new Point(883, 27);
            btnInPhieuThu.Name = "btnInPhieuThu";
            btnInPhieuThu.Size = new Size(129, 29);
            btnInPhieuThu.TabIndex = 22;
            btnInPhieuThu.Text = "In phiéu thu...";
            btnInPhieuThu.UseVisualStyleBackColor = true;
            btnInPhieuThu.Click += btnInPhieuThu_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Anchor = AnchorStyles.Top;
            btnTimKiem.Location = new Point(930, 116);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(150, 29);
            btnTimKiem.TabIndex = 20;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Bottom;
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(375, 399);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 19;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.Bottom;
            btnSua.Location = new Point(502, 399);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 18;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnLapPhieuThu
            // 
            btnLapPhieuThu.Anchor = AnchorStyles.Bottom;
            btnLapPhieuThu.ForeColor = Color.Blue;
            btnLapPhieuThu.Location = new Point(161, 27);
            btnLapPhieuThu.Name = "btnLapPhieuThu";
            btnLapPhieuThu.Size = new Size(181, 29);
            btnLapPhieuThu.TabIndex = 17;
            btnLapPhieuThu.Text = "Lập phiếu thu mới";
            btnLapPhieuThu.UseVisualStyleBackColor = true;
            btnLapPhieuThu.Click += btnLapPhieuThu_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtTimKiem);
            groupBox2.Controls.Add(cboLoaiThu);
            groupBox2.Controls.Add(btnTimKiem);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(dtpNgayThu);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtLyDo);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(numSoTienThu);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(txtNhanVien);
            groupBox2.Controls.Add(cboThanhVien);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1311, 165);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin phiếu thu";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.Top;
            txtTimKiem.Location = new Point(193, 118);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(724, 27);
            txtTimKiem.TabIndex = 26;
            // 
            // cboLoaiThu
            // 
            cboLoaiThu.Anchor = AnchorStyles.Top;
            cboLoaiThu.FormattingEnabled = true;
            cboLoaiThu.Location = new Point(930, 73);
            cboLoaiThu.Name = "cboLoaiThu";
            cboLoaiThu.Size = new Size(150, 28);
            cboLoaiThu.TabIndex = 20;
            cboLoaiThu.SelectedIndexChanged += cboLoaiThu_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Location = new Point(852, 77);
            label6.Name = "label6";
            label6.Size = new Size(65, 20);
            label6.TabIndex = 19;
            label6.Text = "Loại thu:";
            // 
            // dtpNgayThu
            // 
            dtpNgayThu.Anchor = AnchorStyles.Top;
            dtpNgayThu.CustomFormat = "dd/MM/yyyy";
            dtpNgayThu.Enabled = false;
            dtpNgayThu.Format = DateTimePickerFormat.Custom;
            dtpNgayThu.Location = new Point(288, 74);
            dtpNgayThu.Name = "dtpNgayThu";
            dtpNgayThu.Size = new Size(202, 27);
            dtpNgayThu.TabIndex = 18;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Location = new Point(199, 77);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 8;
            label5.Text = "Ngày thu:";
            // 
            // txtLyDo
            // 
            txtLyDo.Anchor = AnchorStyles.Top;
            txtLyDo.Location = new Point(609, 74);
            txtLyDo.Name = "txtLyDo";
            txtLyDo.Size = new Size(202, 27);
            txtLyDo.TabIndex = 7;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Location = new Point(525, 77);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 6;
            label4.Text = "Lý dó thu:";
            // 
            // numSoTienThu
            // 
            numSoTienThu.Anchor = AnchorStyles.Top;
            numSoTienThu.Location = new Point(930, 36);
            numSoTienThu.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numSoTienThu.Name = "numSoTienThu";
            numSoTienThu.Size = new Size(150, 27);
            numSoTienThu.TabIndex = 5;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Location = new Point(852, 38);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 4;
            label3.Text = "Số tiền:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(525, 38);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 3;
            label2.Text = "Nhân viên:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(199, 38);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 2;
            label1.Text = "Thành viên:";
            // 
            // txtNhanVien
            // 
            txtNhanVien.Anchor = AnchorStyles.Top;
            txtNhanVien.Location = new Point(609, 35);
            txtNhanVien.Name = "txtNhanVien";
            txtNhanVien.Size = new Size(202, 27);
            txtNhanVien.TabIndex = 1;
            txtNhanVien.TextChanged += txtNhanVien_TextChanged;
            // 
            // cboThanhVien
            // 
            cboThanhVien.Anchor = AnchorStyles.Top;
            cboThanhVien.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboThanhVien.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboThanhVien.FormattingEnabled = true;
            cboThanhVien.Location = new Point(288, 35);
            cboThanhVien.Name = "cboThanhVien";
            cboThanhVien.Size = new Size(202, 28);
            cboThanhVien.TabIndex = 0;
            cboThanhVien.SelectedIndexChanged += cboThanhVien_SelectedIndexChanged;
            // 
            // btnLuu
            // 
            btnLuu.Anchor = AnchorStyles.Bottom;
            btnLuu.Location = new Point(629, 399);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 23;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnHuy
            // 
            btnHuy.Anchor = AnchorStyles.Bottom;
            btnHuy.Location = new Point(756, 27);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 24;
            btnHuy.Text = "Hủy bỏ";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnInPhieuThu);
            panel1.Controls.Add(btnXuat);
            panel1.Controls.Add(btnHuy);
            panel1.Controls.Add(btnLapPhieuThu);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 372);
            panel1.Name = "panel1";
            panel1.Size = new Size(1311, 78);
            panel1.TabIndex = 25;
            // 
            // frmPhieuThu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1311, 450);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(btnLuu);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(panel1);
            Name = "frmPhieuThu";
            Text = "Phiếu thu";
            Load += frmPhieuThu_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPhieuThu).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSoTienThu).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dgvPhieuThu;
        private Button btnXuat;
        private Button btnInPhieuThu;
        private Button btnTimKiem;
        private Button btnXoa;
        private Button btnSua;
        private Button btnLapPhieuThu;
        private GroupBox groupBox2;
        private Label label2;
        private Label label1;
        private TextBox txtNhanVien;
        private ComboBox cboThanhVien;
        private TextBox txtLyDo;
        private Label label4;
        private NumericUpDown numSoTienThu;
        private Label label3;
        private Label label5;
        private DateTimePicker dtpNgayThu;
        private Button btnLuu;
        private ComboBox cboLoaiThu;
        private Label label6;
        private Button btnHuy;
        private Panel panel1;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colNhanVien;
        private DataGridViewTextBoxColumn colThanhVien;
        private DataGridViewTextBoxColumn colNgayThu;
        private DataGridViewTextBoxColumn colLoaiThu;
        private DataGridViewTextBoxColumn colSoTienThu;
        private DataGridViewTextBoxColumn colLyDo;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private TextBox txtTimKiem;
        private Button button1;
        private Label label8;
        private Label label7;
    }
}