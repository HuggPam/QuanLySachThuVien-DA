namespace QuanLyThuVien.Forms
{
    partial class frmPhieuMuon
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
            groupBox1 = new GroupBox();
            dgvPhieuMuon = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colNhanVien = new DataGridViewTextBoxColumn();
            colThanhVien = new DataGridViewTextBoxColumn();
            colNgayMuon = new DataGridViewTextBoxColumn();
            colTrangThai = new DataGridViewTextBoxColumn();
            colChiTiet = new DataGridViewLinkColumn();
            btnInPhieuMuon = new Button();
            btnTimKIem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnLapPhieuMuon = new Button();
            btnXuat = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            txtTimKiem = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhieuMuon).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvPhieuMuon);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 43);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1085, 336);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách phiếu mượn";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // dgvPhieuMuon
            // 
            dgvPhieuMuon.AllowUserToAddRows = false;
            dgvPhieuMuon.AllowUserToDeleteRows = false;
            dgvPhieuMuon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhieuMuon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPhieuMuon.Columns.AddRange(new DataGridViewColumn[] { colID, colNhanVien, colThanhVien, colNgayMuon, colTrangThai, colChiTiet });
            dgvPhieuMuon.Dock = DockStyle.Fill;
            dgvPhieuMuon.Location = new Point(3, 23);
            dgvPhieuMuon.Name = "dgvPhieuMuon";
            dgvPhieuMuon.RowHeadersVisible = false;
            dgvPhieuMuon.RowHeadersWidth = 51;
            dgvPhieuMuon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPhieuMuon.Size = new Size(1079, 310);
            dgvPhieuMuon.TabIndex = 0;
            dgvPhieuMuon.CellContentClick += dgvPhieuMuon_CellContentClick;
            dgvPhieuMuon.CellFormatting += dgvPhieuMuon_CellFormatting;
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
            // colNgayMuon
            // 
            colNgayMuon.DataPropertyName = "NgayMuon";
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            colNgayMuon.DefaultCellStyle = dataGridViewCellStyle1;
            colNgayMuon.HeaderText = "Ngày mượn";
            colNgayMuon.MinimumWidth = 6;
            colNgayMuon.Name = "colNgayMuon";
            // 
            // colTrangThai
            // 
            colTrangThai.DataPropertyName = "TrangThai";
            colTrangThai.HeaderText = "Trạng thái";
            colTrangThai.MinimumWidth = 6;
            colTrangThai.Name = "colTrangThai";
            // 
            // colChiTiet
            // 
            colChiTiet.DataPropertyName = "ChiTiet";
            colChiTiet.HeaderText = "Chi tiết";
            colChiTiet.LinkColor = Color.Blue;
            colChiTiet.MinimumWidth = 6;
            colChiTiet.Name = "colChiTiet";
            // 
            // btnInPhieuMuon
            // 
            btnInPhieuMuon.Anchor = AnchorStyles.Bottom;
            btnInPhieuMuon.Location = new Point(399, 20);
            btnInPhieuMuon.Name = "btnInPhieuMuon";
            btnInPhieuMuon.Size = new Size(159, 29);
            btnInPhieuMuon.TabIndex = 14;
            btnInPhieuMuon.Text = "In phiéu mượn...";
            btnInPhieuMuon.UseVisualStyleBackColor = true;
            btnInPhieuMuon.Click += btnInPhieuMuon_Click;
            // 
            // btnTimKIem
            // 
            btnTimKIem.Anchor = AnchorStyles.Top;
            btnTimKIem.Location = new Point(786, 7);
            btnTimKIem.Name = "btnTimKIem";
            btnTimKIem.Size = new Size(117, 29);
            btnTimKIem.TabIndex = 12;
            btnTimKIem.Text = "Tìm kiếm";
            btnTimKIem.UseVisualStyleBackColor = true;
            btnTimKIem.Click += btnTimKIem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Bottom;
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(678, 20);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 11;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.Bottom;
            btnSua.Location = new Point(571, 20);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 10;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnLapPhieuMuon
            // 
            btnLapPhieuMuon.Anchor = AnchorStyles.Bottom;
            btnLapPhieuMuon.ForeColor = Color.Blue;
            btnLapPhieuMuon.Location = new Point(187, 20);
            btnLapPhieuMuon.Name = "btnLapPhieuMuon";
            btnLapPhieuMuon.Size = new Size(199, 29);
            btnLapPhieuMuon.TabIndex = 9;
            btnLapPhieuMuon.Text = "Lập phếu mượn mới...";
            btnLapPhieuMuon.UseVisualStyleBackColor = true;
            btnLapPhieuMuon.Click += btnLapPhieuMuon_Click;
            // 
            // btnXuat
            // 
            btnXuat.Anchor = AnchorStyles.Bottom;
            btnXuat.Location = new Point(785, 20);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(94, 29);
            btnXuat.TabIndex = 1;
            btnXuat.Text = "Xuất Excel..";
            btnXuat.UseVisualStyleBackColor = true;
            btnXuat.Click += btnXuat_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnInPhieuMuon);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnXuat);
            panel1.Controls.Add(btnLapPhieuMuon);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 379);
            panel1.Name = "panel1";
            panel1.Size = new Size(1085, 71);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtTimKiem);
            panel2.Controls.Add(btnTimKIem);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1085, 43);
            panel2.TabIndex = 1;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.Top;
            txtTimKiem.Location = new Point(152, 8);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(616, 27);
            txtTimKiem.TabIndex = 13;
            // 
            // frmPhieuMuon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1085, 450);
            Controls.Add(groupBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmPhieuMuon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phiếu mượn";
            Load += frmPhieuMuon_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPhieuMuon).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dgvPhieuMuon;
        private Button btnInPhieuMuon;
        private Button btnTimKIem;
        private Button btnXoa;
        private Button btnSua;
        private Button btnLapPhieuMuon;
        private Button btnXuat;
        private Panel panel1;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colNhanVien;
        private DataGridViewTextBoxColumn colThanhVien;
        private DataGridViewTextBoxColumn colNgayMuon;
        private DataGridViewTextBoxColumn colTrangThai;
        private DataGridViewLinkColumn colChiTiet;
        private Panel panel2;
        private TextBox txtTimKiem;
    }
}