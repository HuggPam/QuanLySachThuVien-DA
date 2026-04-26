namespace QuanLyThuVien.Forms
{
    partial class frmGoiThanhVien
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            numGiaHan = new NumericUpDown();
            numHieuLuc = new NumericUpDown();
            numGiaTien = new NumericUpDown();
            numHanMuon = new NumericUpDown();
            numSoSach = new NumericUpDown();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            lbl1 = new Label();
            lbl = new Label();
            label2 = new Label();
            txtTenGoi = new TextBox();
            btnHuy = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox2 = new GroupBox();
            dgvGoiThanhVien = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colTenGoi = new DataGridViewTextBoxColumn();
            colSoSach = new DataGridViewTextBoxColumn();
            colHanMuon = new DataGridViewTextBoxColumn();
            colGiaHan = new DataGridViewTextBoxColumn();
            colHieuLuc = new DataGridViewTextBoxColumn();
            colGiaTien = new DataGridViewTextBoxColumn();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numGiaHan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numHieuLuc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numGiaTien).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numHanMuon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSoSach).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGoiThanhVien).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(numGiaHan);
            groupBox1.Controls.Add(numHieuLuc);
            groupBox1.Controls.Add(numGiaTien);
            groupBox1.Controls.Add(numHanMuon);
            groupBox1.Controls.Add(numSoSach);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(lbl1);
            groupBox1.Controls.Add(lbl);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtTenGoi);
            groupBox1.Controls.Add(btnHuy);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(785, 192);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin gói thành viên";
            // 
            // numGiaHan
            // 
            numGiaHan.Anchor = AnchorStyles.Top;
            numGiaHan.Location = new Point(146, 96);
            numGiaHan.Name = "numGiaHan";
            numGiaHan.Size = new Size(202, 27);
            numGiaHan.TabIndex = 54;
            numGiaHan.ThousandsSeparator = true;
            // 
            // numHieuLuc
            // 
            numHieuLuc.Anchor = AnchorStyles.Top;
            numHieuLuc.Location = new Point(146, 63);
            numHieuLuc.Name = "numHieuLuc";
            numHieuLuc.Size = new Size(202, 27);
            numHieuLuc.TabIndex = 53;
            numHieuLuc.ThousandsSeparator = true;
            // 
            // numGiaTien
            // 
            numGiaTien.Anchor = AnchorStyles.Top;
            numGiaTien.Location = new Point(522, 99);
            numGiaTien.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numGiaTien.Name = "numGiaTien";
            numGiaTien.Size = new Size(150, 27);
            numGiaTien.TabIndex = 52;
            numGiaTien.ThousandsSeparator = true;
            // 
            // numHanMuon
            // 
            numHanMuon.Anchor = AnchorStyles.Top;
            numHanMuon.Location = new Point(522, 66);
            numHanMuon.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numHanMuon.Name = "numHanMuon";
            numHanMuon.Size = new Size(150, 27);
            numHanMuon.TabIndex = 51;
            numHanMuon.ThousandsSeparator = true;
            // 
            // numSoSach
            // 
            numSoSach.Anchor = AnchorStyles.Top;
            numSoSach.Location = new Point(522, 32);
            numSoSach.Name = "numSoSach";
            numSoSach.Size = new Size(150, 27);
            numSoSach.TabIndex = 50;
            numSoSach.ThousandsSeparator = true;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Location = new Point(426, 34);
            label8.Name = "label8";
            label8.Size = new Size(62, 20);
            label8.TabIndex = 46;
            label8.Text = "Số sách:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Location = new Point(426, 34);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 45;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Location = new Point(426, 104);
            label6.Name = "label6";
            label6.Size = new Size(63, 20);
            label6.TabIndex = 44;
            label6.Text = "Giá tiền:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Location = new Point(426, 68);
            label5.Name = "label5";
            label5.Size = new Size(82, 20);
            label5.TabIndex = 43;
            label5.Text = "Hạn mượn:";
            // 
            // lbl1
            // 
            lbl1.Anchor = AnchorStyles.Top;
            lbl1.AutoSize = true;
            lbl1.Location = new Point(73, 101);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(62, 20);
            lbl1.TabIndex = 42;
            lbl1.Text = "Gia hạn:";
            // 
            // lbl
            // 
            lbl.Anchor = AnchorStyles.Top;
            lbl.AutoSize = true;
            lbl.Location = new Point(73, 65);
            lbl.Name = "lbl";
            lbl.Size = new Size(67, 20);
            lbl.TabIndex = 41;
            lbl.Text = "Hiệu lực:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(73, 30);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 40;
            label2.Text = "Tên gói:";
            // 
            // txtTenGoi
            // 
            txtTenGoi.Anchor = AnchorStyles.Top;
            txtTenGoi.Location = new Point(146, 27);
            txtTenGoi.MaxLength = 100;
            txtTenGoi.Name = "txtTenGoi";
            txtTenGoi.Size = new Size(202, 27);
            txtTenGoi.TabIndex = 39;
            // 
            // btnHuy
            // 
            btnHuy.Anchor = AnchorStyles.Top;
            btnHuy.Location = new Point(539, 142);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 38;
            btnHuy.Text = "Hủy bỏ";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnLuu
            // 
            btnLuu.Anchor = AnchorStyles.Top;
            btnLuu.Location = new Point(431, 142);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 36;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Top;
            btnXoa.Location = new Point(323, 142);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 35;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.Top;
            btnSua.Location = new Point(215, 142);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 34;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Top;
            btnThem.Location = new Point(107, 142);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 33;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvGoiThanhVien);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 192);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(785, 258);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách gói thành viên";
            // 
            // dgvGoiThanhVien
            // 
            dgvGoiThanhVien.AllowUserToAddRows = false;
            dgvGoiThanhVien.AllowUserToDeleteRows = false;
            dgvGoiThanhVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGoiThanhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGoiThanhVien.Columns.AddRange(new DataGridViewColumn[] { colID, colTenGoi, colSoSach, colHanMuon, colGiaHan, colHieuLuc, colGiaTien });
            dgvGoiThanhVien.Dock = DockStyle.Fill;
            dgvGoiThanhVien.Location = new Point(3, 23);
            dgvGoiThanhVien.Name = "dgvGoiThanhVien";
            dgvGoiThanhVien.RowHeadersVisible = false;
            dgvGoiThanhVien.RowHeadersWidth = 51;
            dgvGoiThanhVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGoiThanhVien.Size = new Size(779, 232);
            dgvGoiThanhVien.TabIndex = 2;
            // 
            // colID
            // 
            colID.DataPropertyName = "ID";
            colID.FillWeight = 50F;
            colID.HeaderText = "ID";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            // 
            // colTenGoi
            // 
            colTenGoi.DataPropertyName = "TenGoi";
            colTenGoi.HeaderText = "Tên gói";
            colTenGoi.MinimumWidth = 6;
            colTenGoi.Name = "colTenGoi";
            // 
            // colSoSach
            // 
            colSoSach.DataPropertyName = "SoSachDuocMuon";
            colSoSach.HeaderText = "Số sách";
            colSoSach.MinimumWidth = 6;
            colSoSach.Name = "colSoSach";
            // 
            // colHanMuon
            // 
            colHanMuon.DataPropertyName = "SoNgayMuonToiDa";
            colHanMuon.HeaderText = "Hạn mượn";
            colHanMuon.MinimumWidth = 6;
            colHanMuon.Name = "colHanMuon";
            // 
            // colGiaHan
            // 
            colGiaHan.DataPropertyName = "SoLanGiaHanToiDa";
            colGiaHan.HeaderText = "Gia hạn";
            colGiaHan.MinimumWidth = 6;
            colGiaHan.Name = "colGiaHan";
            // 
            // colHieuLuc
            // 
            colHieuLuc.DataPropertyName = "SoThangHieuLuc";
            colHieuLuc.HeaderText = "Hiệu lực";
            colHieuLuc.MinimumWidth = 6;
            colHieuLuc.Name = "colHieuLuc";
            // 
            // colGiaTien
            // 
            colGiaTien.DataPropertyName = "GiaTien";
            dataGridViewCellStyle2.Format = "#,##0 VNĐ";
            dataGridViewCellStyle2.NullValue = null;
            colGiaTien.DefaultCellStyle = dataGridViewCellStyle2;
            colGiaTien.HeaderText = "Giá tiền";
            colGiaTien.MinimumWidth = 6;
            colGiaTien.Name = "colGiaTien";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // frmGoiThanhVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(785, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmGoiThanhVien";
            Text = "Gói thành viên";
            Load += frmGoiThanhVien_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numGiaHan).EndInit();
            ((System.ComponentModel.ISupportInitialize)numHieuLuc).EndInit();
            ((System.ComponentModel.ISupportInitialize)numGiaTien).EndInit();
            ((System.ComponentModel.ISupportInitialize)numHanMuon).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSoSach).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGoiThanhVien).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private NumericUpDown numGiaHan;
        private NumericUpDown numHieuLuc;
        private NumericUpDown numGiaTien;
        private NumericUpDown numHanMuon;
        private NumericUpDown numSoSach;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label lbl1;
        private Label lbl;
        private Label label2;
        private TextBox txtTenGoi;
        private Button btnHuy;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupBox2;
        private DataGridView dgvGoiThanhVien;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colTenGoi;
        private DataGridViewTextBoxColumn colSoSach;
        private DataGridViewTextBoxColumn colHanMuon;
        private DataGridViewTextBoxColumn colGiaHan;
        private DataGridViewTextBoxColumn colHieuLuc;
        private DataGridViewTextBoxColumn colGiaTien;
    }
}