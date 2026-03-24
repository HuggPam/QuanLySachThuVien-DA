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
            label22 = new Label();
            label21 = new Label();
            label20 = new Label();
            label19 = new Label();
            label17 = new Label();
            dgvThanhVien = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colTenThanhVien = new DataGridViewTextBoxColumn();
            colNgaySinh = new DataGridViewTextBoxColumn();
            colDienThoai = new DataGridViewTextBoxColumn();
            colDiaChi = new DataGridViewTextBoxColumn();
            colGoiThanhVien = new DataGridViewTextBoxColumn();
            colNgayDangKy = new DataGridViewTextBoxColumn();
            colNgayHetHan = new DataGridViewTextBoxColumn();
            colSoLanViPham = new DataGridViewTextBoxColumn();
            colTrangThai = new DataGridViewTextBoxColumn();
            label16 = new Label();
            label13 = new Label();
            label15 = new Label();
            label9 = new Label();
            label14 = new Label();
            label11 = new Label();
            label12 = new Label();
            btnHuy = new Button();
            btnThoat = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            groupBox1 = new GroupBox();
            cboTrangThai = new ComboBox();
            label18 = new Label();
            numViPham = new NumericUpDown();
            label10 = new Label();
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
            ((System.ComponentModel.ISupportInitialize)numViPham).BeginInit();
            SuspendLayout();
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(111, 132);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(209, 27);
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
            btnTimKiem.Location = new Point(934, 63);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 29);
            btnTimKiem.TabIndex = 13;
            btnTimKiem.Text = "Tìm kiếm ";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(934, 96);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(94, 29);
            btnNhap.TabIndex = 14;
            btnNhap.Text = "Nhập ";
            btnNhap.UseVisualStyleBackColor = true;
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(934, 130);
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
            groupBox2.Controls.Add(label22);
            groupBox2.Controls.Add(label21);
            groupBox2.Controls.Add(label20);
            groupBox2.Controls.Add(label19);
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(dgvThanhVien);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label12);
            groupBox2.Location = new Point(-4, 231);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1115, 308);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách thành viên";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(512, 273);
            label22.Name = "label22";
            label22.Size = new Size(128, 20);
            label22.TabIndex = 26;
            label22.Text = "Ngừng hoạt động";
            label22.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label21
            // 
            label21.BackColor = Color.CadetBlue;
            label21.Location = new Point(494, 276);
            label21.Name = "label21";
            label21.Size = new Size(15, 15);
            label21.TabIndex = 25;
            label21.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(324, 273);
            label20.Name = "label20";
            label20.Size = new Size(61, 20);
            label20.TabIndex = 24;
            label20.Text = "Hết hạn";
            label20.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label19
            // 
            label19.BackColor = Color.Thistle;
            label19.Location = new Point(307, 276);
            label19.Name = "label19";
            label19.Size = new Size(15, 15);
            label19.TabIndex = 23;
            label19.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(412, 273);
            label17.Name = "label17";
            label17.Size = new Size(68, 20);
            label17.TabIndex = 22;
            label17.Text = "Khóa thẻ";
            label17.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgvThanhVien
            // 
            dgvThanhVien.AllowUserToAddRows = false;
            dgvThanhVien.AllowUserToDeleteRows = false;
            dgvThanhVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvThanhVien.ColumnHeadersHeight = 50;
            dgvThanhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvThanhVien.Columns.AddRange(new DataGridViewColumn[] { colID, colTenThanhVien, colNgaySinh, colDienThoai, colDiaChi, colGoiThanhVien, colNgayDangKy, colNgayHetHan, colSoLanViPham, colTrangThai });
            dgvThanhVien.Location = new Point(3, 26);
            dgvThanhVien.Name = "dgvThanhVien";
            dgvThanhVien.RowHeadersVisible = false;
            dgvThanhVien.RowHeadersWidth = 51;
            dgvThanhVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvThanhVien.Size = new Size(1113, 228);
            dgvThanhVien.TabIndex = 0;
            dgvThanhVien.CellFormatting += dgvThanhVien_CellFormatting;
            // 
            // colID
            // 
            colID.DataPropertyName = "ID";
            colID.FillWeight = 50F;
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
            colDiaChi.FillWeight = 80F;
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
            // colSoLanViPham
            // 
            colSoLanViPham.DataPropertyName = "SoLanViPham";
            colSoLanViPham.HeaderText = "Số lần vi phạm";
            colSoLanViPham.MinimumWidth = 6;
            colSoLanViPham.Name = "colSoLanViPham";
            colSoLanViPham.Visible = false;
            // 
            // colTrangThai
            // 
            colTrangThai.DataPropertyName = "TrangThai";
            colTrangThai.HeaderText = "Trạng thái";
            colTrangThai.MinimumWidth = 6;
            colTrangThai.Name = "colTrangThai";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(228, 273);
            label16.Name = "label16";
            label16.Size = new Size(74, 20);
            label16.TabIndex = 21;
            label16.Text = "Báo động";
            label16.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            label13.BackColor = Color.Gainsboro;
            label13.Location = new Point(395, 276);
            label13.Name = "label13";
            label13.Size = new Size(15, 15);
            label13.TabIndex = 18;
            label13.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(130, 273);
            label15.Name = "label15";
            label15.Size = new Size(70, 20);
            label15.TabIndex = 20;
            label15.Text = "Cảnh cáo";
            label15.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            label9.BackColor = Color.Gold;
            label9.Location = new Point(16, 276);
            label9.Name = "label9";
            label9.Size = new Size(15, 15);
            label9.TabIndex = 15;
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(34, 273);
            label14.Name = "label14";
            label14.Size = new Size(72, 20);
            label14.TabIndex = 19;
            label14.Text = "Nhắc nhở";
            label14.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            label11.BackColor = Color.Orange;
            label11.Location = new Point(113, 276);
            label11.Name = "label11";
            label11.Size = new Size(15, 15);
            label11.TabIndex = 16;
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            label12.BackColor = Color.Red;
            label12.Location = new Point(210, 276);
            label12.Name = "label12";
            label12.Size = new Size(15, 15);
            label12.TabIndex = 17;
            label12.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(811, 97);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 8;
            btnHuy.Text = "Hủy bỏ";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(811, 132);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(711, 132);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(711, 97);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 4;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(711, 62);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboTrangThai);
            groupBox1.Controls.Add(label18);
            groupBox1.Controls.Add(numViPham);
            groupBox1.Controls.Add(label10);
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
            groupBox1.Location = new Point(31, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1050, 213);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin thành viên";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // cboTrangThai
            // 
            cboTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTrangThai.FormattingEnabled = true;
            cboTrangThai.Location = new Point(111, 173);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(208, 28);
            cboTrangThai.TabIndex = 33;
            cboTrangThai.SelectedIndexChanged += cboTrangThai_SelectedIndexChanged;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(29, 177);
            label18.Name = "label18";
            label18.Size = new Size(78, 20);
            label18.TabIndex = 32;
            label18.Text = "Trạng thái:";
            // 
            // numViPham
            // 
            numViPham.Enabled = false;
            numViPham.Location = new Point(466, 132);
            numViPham.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numViPham.Name = "numViPham";
            numViPham.ReadOnly = true;
            numViPham.Size = new Size(208, 27);
            numViPham.TabIndex = 30;
            numViPham.ValueChanged += numViPham_ValueChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(357, 135);
            label10.Name = "label10";
            label10.Size = new Size(67, 20);
            label10.TabIndex = 28;
            label10.Text = "Vi phạm:";
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
            dtpNgayHetHan.CustomFormat = "dd/MM/yyyy";
            dtpNgayHetHan.Enabled = false;
            dtpNgayHetHan.Format = DateTimePickerFormat.Custom;
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
            dtpNgayDangKy.CustomFormat = "dd/MM/yyyy";
            dtpNgayDangKy.Enabled = false;
            dtpNgayDangKy.Format = DateTimePickerFormat.Custom;
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
            btnLuu.Location = new Point(811, 62);
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
            ClientSize = new Size(1113, 583);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmThanhVien";
            Text = "Thành viên";
            Load += frmThanhVien_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvThanhVien).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numViPham).EndInit();
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
        private Label label10;
        private Label label9;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private NumericUpDown numViPham;
        private ComboBox cboTrangThai;
        private Label label18;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colTenThanhVien;
        private DataGridViewTextBoxColumn colNgaySinh;
        private DataGridViewTextBoxColumn colDienThoai;
        private DataGridViewTextBoxColumn colDiaChi;
        private DataGridViewTextBoxColumn colGoiThanhVien;
        private DataGridViewTextBoxColumn colNgayDangKy;
        private DataGridViewTextBoxColumn colNgayHetHan;
        private DataGridViewTextBoxColumn colSoLanViPham;
        private DataGridViewTextBoxColumn colTrangThai;
        private Label label20;
        private Label label19;
        private Label label22;
        private Label label21;
    }
}