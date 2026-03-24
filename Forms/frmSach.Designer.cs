namespace QuanLyThuVien.Forms
{
    partial class frmSach
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
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            btnHuy = new Button();
            btnThoat = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            btnSua = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            picHinhAnh = new PictureBox();
            btnDoiAnh = new Button();
            numDonGia = new NumericUpDown();
            numSoLuong = new NumericUpDown();
            numNamXuatBan = new NumericUpDown();
            cboNhaXuatBan = new ComboBox();
            cboTacGia = new ComboBox();
            cboTheLoai = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            btnTimKiem = new Button();
            btnNhap = new Button();
            btnXuat = new Button();
            txtTenSach = new TextBox();
            groupBox2 = new GroupBox();
            dgvSach = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colTenSach = new DataGridViewTextBoxColumn();
            colTheLoai = new DataGridViewTextBoxColumn();
            colTacGia = new DataGridViewTextBoxColumn();
            colNhaXuatBan = new DataGridViewTextBoxColumn();
            colNamXuatBan = new DataGridViewTextBoxColumn();
            colSoLuong = new DataGridViewTextBoxColumn();
            colDonGia = new DataGridViewTextBoxColumn();
            colHinhAnh = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDonGia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numNamXuatBan).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSach).BeginInit();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(364, 68);
            label8.Name = "label8";
            label8.Size = new Size(105, 20);
            label8.TabIndex = 25;
            label8.Text = "Năm xuất bản:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(364, 68);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(364, 138);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 22;
            label6.Text = "Đơn giá";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(364, 102);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 20;
            label5.Text = "Số lượng:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 135);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 20;
            label4.Text = "Nhà xuất bản:";
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(441, 177);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 8;
            btnHuy.Text = "Hủy bỏ";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(549, 177);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(333, 177);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 6;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(225, 177);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(9, 177);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(117, 177);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 4;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 30);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên sách:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(picHinhAnh);
            groupBox1.Controls.Add(btnDoiAnh);
            groupBox1.Controls.Add(numDonGia);
            groupBox1.Controls.Add(numSoLuong);
            groupBox1.Controls.Add(numNamXuatBan);
            groupBox1.Controls.Add(cboNhaXuatBan);
            groupBox1.Controls.Add(cboTacGia);
            groupBox1.Controls.Add(cboTheLoai);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(btnNhap);
            groupBox1.Controls.Add(btnXuat);
            groupBox1.Controls.Add(txtTenSach);
            groupBox1.Controls.Add(btnHuy);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(979, 223);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sách";
            // 
            // picHinhAnh
            // 
            picHinhAnh.Location = new Point(642, 22);
            picHinhAnh.Name = "picHinhAnh";
            picHinhAnh.Size = new Size(217, 141);
            picHinhAnh.SizeMode = PictureBoxSizeMode.Zoom;
            picHinhAnh.TabIndex = 32;
            picHinhAnh.TabStop = false;
            picHinhAnh.Click += picHinhAnh_Click;
            // 
            // btnDoiAnh
            // 
            btnDoiAnh.Location = new Point(875, 136);
            btnDoiAnh.Name = "btnDoiAnh";
            btnDoiAnh.Size = new Size(94, 29);
            btnDoiAnh.TabIndex = 33;
            btnDoiAnh.Text = "Đổi ảnh bìa";
            btnDoiAnh.UseVisualStyleBackColor = true;
            btnDoiAnh.Click += btnDoiAnh_Click;
            // 
            // numDonGia
            // 
            numDonGia.Location = new Point(475, 136);
            numDonGia.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numDonGia.Name = "numDonGia";
            numDonGia.Size = new Size(150, 27);
            numDonGia.TabIndex = 31;
            numDonGia.ThousandsSeparator = true;
            // 
            // numSoLuong
            // 
            numSoLuong.Location = new Point(475, 100);
            numSoLuong.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(150, 27);
            numSoLuong.TabIndex = 30;
            numSoLuong.ThousandsSeparator = true;
            // 
            // numNamXuatBan
            // 
            numNamXuatBan.Location = new Point(475, 66);
            numNamXuatBan.Name = "numNamXuatBan";
            numNamXuatBan.Size = new Size(150, 27);
            numNamXuatBan.TabIndex = 29;
            numNamXuatBan.ThousandsSeparator = true;
            // 
            // cboNhaXuatBan
            // 
            cboNhaXuatBan.FormattingEnabled = true;
            cboNhaXuatBan.Location = new Point(117, 132);
            cboNhaXuatBan.Name = "cboNhaXuatBan";
            cboNhaXuatBan.Size = new Size(209, 28);
            cboNhaXuatBan.TabIndex = 28;
            // 
            // cboTacGia
            // 
            cboTacGia.FormattingEnabled = true;
            cboTacGia.Location = new Point(117, 96);
            cboTacGia.Name = "cboTacGia";
            cboTacGia.Size = new Size(209, 28);
            cboTacGia.TabIndex = 27;
            // 
            // cboTheLoai
            // 
            cboTheLoai.FormattingEnabled = true;
            cboTheLoai.Location = new Point(117, 60);
            cboTheLoai.Name = "cboTheLoai";
            cboTheLoai.Size = new Size(209, 28);
            cboTheLoai.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 99);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 18;
            label3.Text = "Tác giả:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 64);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 17;
            label2.Text = "Thể loại:";
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(657, 177);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 29);
            btnTimKiem.TabIndex = 13;
            btnTimKiem.Text = "Tìm kiếm ";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(765, 177);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(94, 29);
            btnNhap.TabIndex = 14;
            btnNhap.Text = "Nhập ";
            btnNhap.UseVisualStyleBackColor = true;
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(875, 177);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(94, 29);
            btnXuat.TabIndex = 15;
            btnXuat.Text = "Xuất";
            btnXuat.UseVisualStyleBackColor = true;
            // 
            // txtTenSach
            // 
            txtTenSach.Location = new Point(117, 27);
            txtTenSach.Name = "txtTenSach";
            txtTenSach.Size = new Size(508, 27);
            txtTenSach.TabIndex = 10;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvSach);
            groupBox2.Location = new Point(1, 255);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1005, 260);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh mục sách";
            // 
            // dgvSach
            // 
            dgvSach.AllowUserToAddRows = false;
            dgvSach.AllowUserToDeleteRows = false;
            dgvSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSach.Columns.AddRange(new DataGridViewColumn[] { colID, colTenSach, colTheLoai, colTacGia, colNhaXuatBan, colNamXuatBan, colSoLuong, colDonGia, colHinhAnh });
            dgvSach.Location = new Point(0, 26);
            dgvSach.MultiSelect = false;
            dgvSach.Name = "dgvSach";
            dgvSach.RowHeadersVisible = false;
            dgvSach.RowHeadersWidth = 51;
            dgvSach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSach.Size = new Size(1005, 234);
            dgvSach.TabIndex = 0;
            // 
            // colID
            // 
            colID.DataPropertyName = "ID";
            colID.FillWeight = 50F;
            colID.HeaderText = "ID";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            // 
            // colTenSach
            // 
            colTenSach.DataPropertyName = "TenSach";
            colTenSach.FillWeight = 83.728035F;
            colTenSach.HeaderText = "Tên sách";
            colTenSach.MinimumWidth = 6;
            colTenSach.Name = "colTenSach";
            // 
            // colTheLoai
            // 
            colTheLoai.DataPropertyName = "TenTheLoai";
            colTheLoai.FillWeight = 83.728035F;
            colTheLoai.HeaderText = "Thể loại";
            colTheLoai.MinimumWidth = 6;
            colTheLoai.Name = "colTheLoai";
            // 
            // colTacGia
            // 
            colTacGia.DataPropertyName = "TenTacGia";
            colTacGia.FillWeight = 83.728035F;
            colTacGia.HeaderText = "Tác giả";
            colTacGia.MinimumWidth = 6;
            colTacGia.Name = "colTacGia";
            // 
            // colNhaXuatBan
            // 
            colNhaXuatBan.DataPropertyName = "TenNhaXuatBan";
            colNhaXuatBan.FillWeight = 83.728035F;
            colNhaXuatBan.HeaderText = "Nhà xuất bản";
            colNhaXuatBan.MinimumWidth = 6;
            colNhaXuatBan.Name = "colNhaXuatBan";
            // 
            // colNamXuatBan
            // 
            colNamXuatBan.DataPropertyName = "NamXuatBan";
            colNamXuatBan.FillWeight = 83.728035F;
            colNamXuatBan.HeaderText = "Năm xuất bản";
            colNamXuatBan.MinimumWidth = 6;
            colNamXuatBan.Name = "colNamXuatBan";
            // 
            // colSoLuong
            // 
            colSoLuong.DataPropertyName = "SoLuong";
            colSoLuong.FillWeight = 83.728035F;
            colSoLuong.HeaderText = "Số lượng";
            colSoLuong.MinimumWidth = 6;
            colSoLuong.Name = "colSoLuong";
            // 
            // colDonGia
            // 
            colDonGia.DataPropertyName = "DonGia";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N0";
            colDonGia.DefaultCellStyle = dataGridViewCellStyle1;
            colDonGia.HeaderText = "Đơn giá";
            colDonGia.MinimumWidth = 6;
            colDonGia.Name = "colDonGia";
            // 
            // colHinhAnh
            // 
            colHinhAnh.DataPropertyName = "HinhAnh";
            colHinhAnh.FillWeight = 83.728035F;
            colHinhAnh.HeaderText = "Hình ảnh";
            colHinhAnh.MinimumWidth = 6;
            colHinhAnh.Name = "colHinhAnh";
            colHinhAnh.Visible = false;
            // 
            // frmSach
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 511);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "frmSach";
            Text = "Sách";
            Load += frmSach_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDonGia).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            ((System.ComponentModel.ISupportInitialize)numNamXuatBan).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSach).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button btnHuy;
        private Button btnThoat;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnThem;
        private Button btnSua;
        private Label label1;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Button btnTimKiem;
        private Button btnNhap;
        private Button btnXuat;
        private TextBox txtTenSach;
        private GroupBox groupBox2;
        private NumericUpDown numDonGia;
        private NumericUpDown numSoLuong;
        private NumericUpDown numNamXuatBan;
        private ComboBox cboNhaXuatBan;
        private ComboBox cboTacGia;
        private ComboBox cboTheLoai;
        private Button btnDoiAnh;
        private PictureBox picHinhAnh;
        private DataGridView dgvSach;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colTenSach;
        private DataGridViewTextBoxColumn colTheLoai;
        private DataGridViewTextBoxColumn colTacGia;
        private DataGridViewTextBoxColumn colNhaXuatBan;
        private DataGridViewTextBoxColumn colNamXuatBan;
        private DataGridViewTextBoxColumn colSoLuong;
        private DataGridViewTextBoxColumn colDonGia;
        private DataGridViewTextBoxColumn colHinhAnh;
    }
}