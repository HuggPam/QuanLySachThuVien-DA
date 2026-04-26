namespace QuanLyThuVien.Forms
{
    partial class frmTacGia
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
            txtGhiChu = new TextBox();
            label2 = new Label();
            txtTenTacGia = new TextBox();
            btnHuy = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            colTenTheLoai = new DataGridViewTextBoxColumn();
            dgvTacGia = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colTenTacGia = new DataGridViewTextBoxColumn();
            colGhiChu = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTacGia).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(30, 33);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên tác giả:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtGhiChu);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtTenTacGia);
            groupBox1.Controls.Add(btnHuy);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(799, 214);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin tác giả";
            // 
            // txtGhiChu
            // 
            txtGhiChu.AcceptsReturn = true;
            txtGhiChu.Anchor = AnchorStyles.Top;
            txtGhiChu.Location = new Point(120, 72);
            txtGhiChu.Multiline = true;
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.ScrollBars = ScrollBars.Vertical;
            txtGhiChu.Size = new Size(616, 83);
            txtGhiChu.TabIndex = 12;
            txtGhiChu.TextChanged += txtGhiChu_TextChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(30, 75);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 11;
            label2.Text = "Ghi chú:";
            // 
            // txtTenTacGia
            // 
            txtTenTacGia.Anchor = AnchorStyles.Top;
            txtTenTacGia.Location = new Point(120, 30);
            txtTenTacGia.Name = "txtTenTacGia";
            txtTenTacGia.Size = new Size(616, 27);
            txtTenTacGia.TabIndex = 10;
            // 
            // btnHuy
            // 
            btnHuy.Anchor = AnchorStyles.Top;
            btnHuy.Location = new Point(572, 169);
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
            btnLuu.Location = new Point(466, 169);
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
            btnXoa.Location = new Point(360, 169);
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
            btnSua.Location = new Point(254, 169);
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
            btnThem.Location = new Point(148, 169);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // colTenTheLoai
            // 
            colTenTheLoai.DataPropertyName = "TenTheLoai";
            colTenTheLoai.HeaderText = "Tên thể loại";
            colTenTheLoai.MinimumWidth = 6;
            colTenTheLoai.Name = "colTenTheLoai";
            colTenTheLoai.Width = 125;
            // 
            // dgvTacGia
            // 
            dgvTacGia.AllowUserToAddRows = false;
            dgvTacGia.AllowUserToDeleteRows = false;
            dgvTacGia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTacGia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTacGia.Columns.AddRange(new DataGridViewColumn[] { colID, colTenTacGia, colGhiChu });
            dgvTacGia.Dock = DockStyle.Fill;
            dgvTacGia.Location = new Point(0, 214);
            dgvTacGia.MultiSelect = false;
            dgvTacGia.Name = "dgvTacGia";
            dgvTacGia.RowHeadersVisible = false;
            dgvTacGia.RowHeadersWidth = 51;
            dgvTacGia.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTacGia.Size = new Size(799, 264);
            dgvTacGia.TabIndex = 11;
            // 
            // colID
            // 
            colID.DataPropertyName = "ID";
            colID.HeaderText = "ID";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            // 
            // colTenTacGia
            // 
            colTenTacGia.DataPropertyName = "TenTacGia";
            colTenTacGia.HeaderText = "Tên tác giả";
            colTenTacGia.MinimumWidth = 6;
            colTenTacGia.Name = "colTenTacGia";
            // 
            // colGhiChu
            // 
            colGhiChu.DataPropertyName = "GhiChu";
            colGhiChu.HeaderText = "Ghi chú";
            colGhiChu.MinimumWidth = 6;
            colGhiChu.Name = "colGhiChu";
            // 
            // groupBox2
            // 
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 214);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(799, 264);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách tác giả";
            // 
            // frmTacGia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(799, 478);
            Controls.Add(dgvTacGia);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmTacGia";
            Text = "Tác giả";
            Load += frmTacGia_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTacGia).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtTenTacGia;
        private Button btnHuy;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private DataGridViewTextBoxColumn colTenTheLoai;
        private Label label2;
        private TextBox txtGhiChu;
        private DataGridView dgvTacGia;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colTenTacGia;
        private DataGridViewTextBoxColumn colGhiChu;
        private GroupBox groupBox2;
    }
}