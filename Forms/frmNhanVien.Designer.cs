namespace QuanLyThuVien.Forms
{
    partial class frmNhanVien
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
            label8 = new Label();
            label7 = new Label();
            cboQuyenHan = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            btnHuy = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtTimKiem = new TextBox();
            txtTenDangNhap = new TextBox();
            txtMatKhau = new TextBox();
            txtDiaChi = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtDienThoai = new TextBox();
            btnTimKiem = new Button();
            txtTenNhanVien = new TextBox();
            btnLuu = new Button();
            groupBox2 = new GroupBox();
            dgvNhanVien = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colTenNhanVien = new DataGridViewTextBoxColumn();
            colDienThoai = new DataGridViewTextBoxColumn();
            colDiaChi = new DataGridViewTextBoxColumn();
            colTenDangNhap = new DataGridViewTextBoxColumn();
            colQuyenHan = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            SuspendLayout();
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Location = new Point(416, 38);
            label8.Name = "label8";
            label8.Size = new Size(110, 20);
            label8.TabIndex = 25;
            label8.Text = "Tên đăng nhập:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Location = new Point(416, 38);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 24;
            // 
            // cboQuyenHan
            // 
            cboQuyenHan.Anchor = AnchorStyles.Top;
            cboQuyenHan.DropDownStyle = ComboBoxStyle.DropDownList;
            cboQuyenHan.FormattingEnabled = true;
            cboQuyenHan.Location = new Point(532, 104);
            cboQuyenHan.Name = "cboQuyenHan";
            cboQuyenHan.Size = new Size(208, 28);
            cboQuyenHan.TabIndex = 23;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Location = new Point(416, 108);
            label6.Name = "label6";
            label6.Size = new Size(82, 20);
            label6.TabIndex = 22;
            label6.Text = "Quyền hạn:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Location = new Point(416, 72);
            label5.Name = "label5";
            label5.Size = new Size(73, 20);
            label5.TabIndex = 20;
            label5.Text = "Mật khẩu:";
            // 
            // btnHuy
            // 
            btnHuy.Anchor = AnchorStyles.Top;
            btnHuy.Location = new Point(864, 68);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 8;
            btnHuy.Text = "Hủy bỏ";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Top;
            btnXoa.Location = new Point(764, 103);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.Top;
            btnSua.Location = new Point(764, 68);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 4;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Top;
            btnThem.Location = new Point(764, 33);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(88, 38);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 0;
            label1.Text = "Họ và tên:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtTimKiem);
            groupBox1.Controls.Add(txtTenDangNhap);
            groupBox1.Controls.Add(txtMatKhau);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtDienThoai);
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(txtTenNhanVien);
            groupBox1.Controls.Add(btnHuy);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(cboQuyenHan);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1065, 182);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhân viên";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.Top;
            txtTimKiem.Location = new Point(88, 143);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(870, 27);
            txtTimKiem.TabIndex = 30;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Anchor = AnchorStyles.Top;
            txtTenDangNhap.Location = new Point(532, 35);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(208, 27);
            txtTenDangNhap.TabIndex = 29;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Anchor = AnchorStyles.Top;
            txtMatKhau.Location = new Point(532, 70);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(208, 27);
            txtMatKhau.TabIndex = 28;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Anchor = AnchorStyles.Top;
            txtDiaChi.Location = new Point(170, 70);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(209, 27);
            txtDiaChi.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(88, 72);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 26;
            label2.Text = "Địa chỉ:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Location = new Point(88, 107);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 18;
            label3.Text = "Điện thoại:";
            // 
            // txtDienThoai
            // 
            txtDienThoai.Anchor = AnchorStyles.Top;
            txtDienThoai.Location = new Point(170, 104);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(209, 27);
            txtDienThoai.TabIndex = 16;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Anchor = AnchorStyles.Top;
            btnTimKiem.Location = new Point(864, 103);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 29);
            btnTimKiem.TabIndex = 13;
            btnTimKiem.Text = "Tìm kiếm ";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtTenNhanVien
            // 
            txtTenNhanVien.Anchor = AnchorStyles.Top;
            txtTenNhanVien.Location = new Point(170, 34);
            txtTenNhanVien.Name = "txtTenNhanVien";
            txtTenNhanVien.Size = new Size(209, 27);
            txtTenNhanVien.TabIndex = 10;
            // 
            // btnLuu
            // 
            btnLuu.Anchor = AnchorStyles.Top;
            btnLuu.Location = new Point(864, 33);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 6;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvNhanVien);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 182);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1065, 268);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách nhân viên";
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.AllowUserToAddRows = false;
            dgvNhanVien.AllowUserToDeleteRows = false;
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Columns.AddRange(new DataGridViewColumn[] { colID, colTenNhanVien, colDienThoai, colDiaChi, colTenDangNhap, colQuyenHan });
            dgvNhanVien.Dock = DockStyle.Fill;
            dgvNhanVien.Location = new Point(3, 23);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.RowHeadersVisible = false;
            dgvNhanVien.RowHeadersWidth = 51;
            dgvNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNhanVien.Size = new Size(1059, 242);
            dgvNhanVien.TabIndex = 0;
            dgvNhanVien.CellContentClick += dgvNhanVien_CellContentClick;
            dgvNhanVien.CellFormatting += dgvNhanVien_CellFormatting;
            // 
            // colID
            // 
            colID.DataPropertyName = "ID";
            colID.HeaderText = "ID";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            // 
            // colTenNhanVien
            // 
            colTenNhanVien.DataPropertyName = "TenNhanVien";
            colTenNhanVien.HeaderText = "Họ và tên";
            colTenNhanVien.MinimumWidth = 6;
            colTenNhanVien.Name = "colTenNhanVien";
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
            // colTenDangNhap
            // 
            colTenDangNhap.DataPropertyName = "TenDangNhap";
            colTenDangNhap.HeaderText = "Tên đăng nhập";
            colTenDangNhap.MinimumWidth = 6;
            colTenDangNhap.Name = "colTenDangNhap";
            // 
            // colQuyenHan
            // 
            colQuyenHan.DataPropertyName = "QuyenHan";
            colQuyenHan.HeaderText = "Quyền hạn";
            colQuyenHan.MinimumWidth = 6;
            colQuyenHan.Name = "colQuyenHan";
            // 
            // frmNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1065, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmNhanVien";
            Text = "Nhân viên";
            Load += frmNhanVien_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label8;
        private Label label7;
        private ComboBox cboQuyenHan;
        private Label label6;
        private Label label5;
        private Button btnHuy;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Label label1;
        private GroupBox groupBox1;
        private Label label3;
        private TextBox txtDienThoai;
        private Button btnTimKiem;
        private TextBox txtTenNhanVien;
        private Button btnLuu;
        private GroupBox groupBox2;
        private TextBox txtDiaChi;
        private Label label2;
        private TextBox txtTenDangNhap;
        private TextBox txtMatKhau;
        private DataGridView dgvNhanVien;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colTenNhanVien;
        private DataGridViewTextBoxColumn colDienThoai;
        private DataGridViewTextBoxColumn colDiaChi;
        private DataGridViewTextBoxColumn colTenDangNhap;
        private DataGridViewTextBoxColumn colQuyenHan;
        private TextBox txtTimKiem;
    }
}