namespace QuanLyThuVien.Forms
{
    partial class frmThanhVien
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
            txtDiaChi = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtDienThoai = new TextBox();
            btnTimKiem = new Button();
            btnNhap = new Button();
            btnXuat = new Button();
            txtTenThanhVien = new TextBox();
            groupBox2 = new GroupBox();
            dgvThanhVien = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colTenThanhVien = new DataGridViewTextBoxColumn();
            colNgaySinh = new DataGridViewTextBoxColumn();
            colDienThoai = new DataGridViewTextBoxColumn();
            colDiaChi = new DataGridViewTextBoxColumn();
            colGoiThanhVien = new DataGridViewTextBoxColumn();
            colNgayDangKy = new DataGridViewTextBoxColumn();
            colNgayHetHan = new DataGridViewTextBoxColumn();
            btnHuy = new Button();
            btnThoat = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            groupBox1 = new GroupBox();
            label8 = new Label();
            label7 = new Label();
            cboGoiThanhVien = new ComboBox();
            dtpNgayHetHan = new DateTimePicker();
            label6 = new Label();
            dtpNgayDangKy = new DateTimePicker();
            label5 = new Label();
            dtpNgaySinh = new DateTimePicker();
            label4 = new Label();
            btnLuu = new Button();
            label1 = new Label();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvThanhVien).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(111, 132);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(563, 27);
            txtDiaChi.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 99);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 18;
            label3.Text = "Điện thoại:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 64);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 17;
            label2.Text = "Ngày sinh:";
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(111, 96);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(209, 27);
            txtDienThoai.TabIndex = 16;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(921, 40);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 29);
            btnTimKiem.TabIndex = 13;
            btnTimKiem.Text = "Tìm kiếm ";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(921, 75);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(94, 29);
            btnNhap.TabIndex = 14;
            btnNhap.Text = "Nhập ";
            btnNhap.UseVisualStyleBackColor = true;
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(921, 110);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(94, 29);
            btnXuat.TabIndex = 15;
            btnXuat.Text = "Xuất";
            btnXuat.UseVisualStyleBackColor = true;
            // 
            // txtTenThanhVien
            // 
            txtTenThanhVien.Location = new Point(111, 26);
            txtTenThanhVien.Name = "txtTenThanhVien";
            txtTenThanhVien.Size = new Size(209, 27);
            txtTenThanhVien.TabIndex = 10;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvThanhVien);
            groupBox2.Location = new Point(-3, 198);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1057, 260);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách thành viên";
            // 
            // dgvThanhVien
            // 
            dgvThanhVien.AllowUserToAddRows = false;
            dgvThanhVien.AllowUserToDeleteRows = false;
            dgvThanhVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvThanhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvThanhVien.Columns.AddRange(new DataGridViewColumn[] { colID, colTenThanhVien, colNgaySinh, colDienThoai, colDiaChi, colGoiThanhVien, colNgayDangKy, colNgayHetHan });
            dgvThanhVien.Location = new Point(3, 26);
            dgvThanhVien.Name = "dgvThanhVien";
            dgvThanhVien.RowHeadersVisible = false;
            dgvThanhVien.RowHeadersWidth = 51;
            dgvThanhVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvThanhVien.Size = new Size(1054, 228);
            dgvThanhVien.TabIndex = 0;
            // 
            // colID
            // 
            colID.DataPropertyName = "ID";
            colID.HeaderText = "ID";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            // 
            // colTenThanhVien
            // 
            colTenThanhVien.DataPropertyName = "TenThanhVien";
            colTenThanhVien.HeaderText = "Họ và tên";
            colTenThanhVien.MinimumWidth = 6;
            colTenThanhVien.Name = "colTenThanhVien";
            // 
            // colNgaySinh
            // 
            colNgaySinh.DataPropertyName = "NgaySinh";
            colNgaySinh.HeaderText = "Ngày sinh";
            colNgaySinh.MinimumWidth = 6;
            colNgaySinh.Name = "colNgaySinh";
            // 
            // colDienThoai
            // 
            colDienThoai.DataPropertyName = "DienThoai";
            colDienThoai.HeaderText = "Điện thoại";
            colDienThoai.MinimumWidth = 6;
            colDienThoai.Name = "colDienThoai";
            // 
            // colDiaChi
            // 
            colDiaChi.DataPropertyName = "DiaChi";
            colDiaChi.HeaderText = "Địa chỉ";
            colDiaChi.MinimumWidth = 6;
            colDiaChi.Name = "colDiaChi";
            // 
            // colGoiThanhVien
            // 
            colGoiThanhVien.DataPropertyName = "TenGoi";
            colGoiThanhVien.HeaderText = "Gói thành viên";
            colGoiThanhVien.MinimumWidth = 6;
            colGoiThanhVien.Name = "colGoiThanhVien";
            // 
            // colNgayDangKy
            // 
            colNgayDangKy.DataPropertyName = "NgayDangKy";
            colNgayDangKy.HeaderText = "Ngày đăng ký";
            colNgayDangKy.MinimumWidth = 6;
            colNgayDangKy.Name = "colNgayDangKy";
            // 
            // colNgayHetHan
            // 
            colNgayHetHan.DataPropertyName = "NgayHetHan";
            colNgayHetHan.HeaderText = "Ngày hết hạn";
            colNgayHetHan.MinimumWidth = 6;
            colNgayHetHan.Name = "colNgayHetHan";
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(798, 75);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 8;
            btnHuy.Text = "Hủy bỏ";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(798, 110);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(698, 110);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(698, 75);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 4;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(698, 40);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(cboGoiThanhVien);
            groupBox1.Controls.Add(dtpNgayHetHan);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(dtpNgayDangKy);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(dtpNgaySinh);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtDienThoai);
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(btnNhap);
            groupBox1.Controls.Add(btnXuat);
            groupBox1.Controls.Add(txtTenThanhVien);
            groupBox1.Controls.Add(btnHuy);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1030, 180);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin thành viên";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(357, 30);
            label8.Name = "label8";
            label8.Size = new Size(107, 20);
            label8.TabIndex = 25;
            label8.Text = "Gói thành viên:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(357, 30);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 24;
            // 
            // cboGoiThanhVien
            // 
            cboGoiThanhVien.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGoiThanhVien.FormattingEnabled = true;
            cboGoiThanhVien.Location = new Point(466, 26);
            cboGoiThanhVien.Name = "cboGoiThanhVien";
            cboGoiThanhVien.Size = new Size(208, 28);
            cboGoiThanhVien.TabIndex = 23;
            // 
            // dtpNgayHetHan
            // 
            dtpNgayHetHan.Enabled = false;
            dtpNgayHetHan.Location = new Point(466, 96);
            dtpNgayHetHan.Name = "dtpNgayHetHan";
            dtpNgayHetHan.Size = new Size(208, 27);
            dtpNgayHetHan.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(357, 100);
            label6.Name = "label6";
            label6.Size = new Size(100, 20);
            label6.TabIndex = 22;
            label6.Text = "Ngày hết hạn:";
            // 
            // dtpNgayDangKy
            // 
            dtpNgayDangKy.Enabled = false;
            dtpNgayDangKy.Location = new Point(466, 61);
            dtpNgayDangKy.Name = "dtpNgayDangKy";
            dtpNgayDangKy.Size = new Size(208, 27);
            dtpNgayDangKy.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(357, 64);
            label5.Name = "label5";
            label5.Size = new Size(103, 20);
            label5.TabIndex = 20;
            label5.Text = "Ngày đăng ký:";
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.Location = new Point(112, 61);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(208, 27);
            dtpNgaySinh.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 135);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 20;
            label4.Text = "Địa chỉ:";
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(798, 40);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 6;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 30);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 0;
            label1.Text = "Họ và tên:";
            // 
            // frmThanhVien
            // 
            AccessibleRole = AccessibleRole.None;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1054, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmThanhVien";
            Text = "Thành viên";
            Load += frmThanhVien_Load;
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvThanhVien).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtDiaChi;
        private Label label3;
        private Label label2;
        private TextBox txtDienThoai;
        private Button btnTimKiem;
        private Button btnNhap;
        private Button btnXuat;
        private TextBox txtTenThanhVien;
        private GroupBox groupBox2;
        private Button btnHuy;
        private Button btnThoat;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private GroupBox groupBox1;
        private Button btnLuu;
        private Label label1;
        private DateTimePicker dtpNgaySinh;
        private Label label4;
        private Label label7;
        private ComboBox cboGoiThanhVien;
        private DateTimePicker dtpNgayHetHan;
        private Label label6;
        private DateTimePicker dtpNgayDangKy;
        private Label label5;
        private Label label8;
        private DataGridView dgvThanhVien;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colTenThanhVien;
        private DataGridViewTextBoxColumn colNgaySinh;
        private DataGridViewTextBoxColumn colDienThoai;
        private DataGridViewTextBoxColumn colDiaChi;
        private DataGridViewTextBoxColumn colGoiThanhVien;
        private DataGridViewTextBoxColumn colNgayDangKy;
        private DataGridViewTextBoxColumn colNgayHetHan;
    }
}