namespace QuanLyThuVien.Forms
{
    partial class frmNhaXuatBan
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtDienThoai = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtDiaChi = new TextBox();
            txtTenNhaXuatBan = new TextBox();
            btnHuy = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            groupBox2 = new GroupBox();
            dgvNhaXuatBan = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colTenTenNhaXuatBan = new DataGridViewTextBoxColumn();
            colDienThoai = new DataGridViewTextBoxColumn();
            colDiaChi = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhaXuatBan).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(74, 30);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên NXB:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtDienThoai);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(txtTenNhaXuatBan);
            groupBox1.Controls.Add(btnHuy);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(907, 132);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhà xuất bản";
            // 
            // txtDienThoai
            // 
            txtDienThoai.Anchor = AnchorStyles.Top;
            txtDienThoai.Location = new Point(458, 27);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(135, 27);
            txtDienThoai.TabIndex = 19;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Location = new Point(371, 30);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 18;
            label3.Text = "Điện thoại:";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(74, 80);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 17;
            label2.Text = "Địa chỉ:";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Anchor = AnchorStyles.Top;
            txtDiaChi.Location = new Point(142, 77);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(451, 27);
            txtDiaChi.TabIndex = 16;
            txtDiaChi.TextChanged += textBox1_TextChanged;
            // 
            // txtTenNhaXuatBan
            // 
            txtTenNhaXuatBan.Anchor = AnchorStyles.Top;
            txtTenNhaXuatBan.Location = new Point(148, 26);
            txtTenNhaXuatBan.Name = "txtTenNhaXuatBan";
            txtTenNhaXuatBan.Size = new Size(217, 27);
            txtTenNhaXuatBan.TabIndex = 10;
            txtTenNhaXuatBan.TextChanged += txtTenTheLoai_TextChanged;
            // 
            // btnHuy
            // 
            btnHuy.Anchor = AnchorStyles.Top;
            btnHuy.Location = new Point(714, 55);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 8;
            btnHuy.Text = "Hủy bỏ";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnLuu
            // 
            btnLuu.Anchor = AnchorStyles.Top;
            btnLuu.Location = new Point(714, 20);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 6;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Top;
            btnXoa.Location = new Point(662, 90);
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
            btnSua.Location = new Point(614, 55);
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
            btnThem.Location = new Point(614, 20);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvNhaXuatBan);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 132);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(907, 318);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách nhà xuất bản";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // dgvNhaXuatBan
            // 
            dgvNhaXuatBan.AllowUserToAddRows = false;
            dgvNhaXuatBan.AllowUserToDeleteRows = false;
            dgvNhaXuatBan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhaXuatBan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhaXuatBan.Columns.AddRange(new DataGridViewColumn[] { colID, colTenTenNhaXuatBan, colDienThoai, colDiaChi });
            dgvNhaXuatBan.Dock = DockStyle.Fill;
            dgvNhaXuatBan.Location = new Point(3, 23);
            dgvNhaXuatBan.MultiSelect = false;
            dgvNhaXuatBan.Name = "dgvNhaXuatBan";
            dgvNhaXuatBan.RowHeadersVisible = false;
            dgvNhaXuatBan.RowHeadersWidth = 51;
            dgvNhaXuatBan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNhaXuatBan.Size = new Size(901, 292);
            dgvNhaXuatBan.TabIndex = 0;
            dgvNhaXuatBan.CellFormatting += dgvNhaXuatBan_CellFormatting;
            // 
            // colID
            // 
            colID.DataPropertyName = "ID";
            colID.HeaderText = "ID";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            // 
            // colTenTenNhaXuatBan
            // 
            colTenTenNhaXuatBan.DataPropertyName = "TenNhaXuatBan";
            colTenTenNhaXuatBan.HeaderText = "Tên NXB";
            colTenTenNhaXuatBan.MinimumWidth = 6;
            colTenTenNhaXuatBan.Name = "colTenTenNhaXuatBan";
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
            // frmNhaXuatBan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(907, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmNhaXuatBan";
            Text = "Nhà xuất bản";
            Load += frmNhaXuatBan_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNhaXuatBan).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtTenNhaXuatBan;
        private Button btnHuy;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private GroupBox groupBox2;
        private TextBox txtDienThoai;
        private Label label3;
        private Label label2;
        private TextBox txtDiaChi;
        private DataGridView dgvNhaXuatBan;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colTenTenNhaXuatBan;
        private DataGridViewTextBoxColumn colDienThoai;
        private DataGridViewTextBoxColumn colDiaChi;
    }
}