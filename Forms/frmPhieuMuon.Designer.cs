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
            groupBox1 = new GroupBox();
            dgvPhieuMuon = new DataGridView();
            btnInPhieuMuon = new Button();
            btnThoat = new Button();
            btnTimKIem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnLapPhieuMuon = new Button();
            btnXuat = new Button();
            colID = new DataGridViewTextBoxColumn();
            colNhanVien = new DataGridViewTextBoxColumn();
            colThanhVien = new DataGridViewTextBoxColumn();
            colNgayMuon = new DataGridViewTextBoxColumn();
            colTrangThai = new DataGridViewTextBoxColumn();
            colChiTiet = new DataGridViewLinkColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhieuMuon).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvPhieuMuon);
            groupBox1.Location = new Point(2, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1086, 350);
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
            dgvPhieuMuon.Location = new Point(0, 26);
            dgvPhieuMuon.Name = "dgvPhieuMuon";
            dgvPhieuMuon.RowHeadersVisible = false;
            dgvPhieuMuon.RowHeadersWidth = 51;
            dgvPhieuMuon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPhieuMuon.Size = new Size(1080, 318);
            dgvPhieuMuon.TabIndex = 0;
            dgvPhieuMuon.CellContentClick += dgvPhieuMuon_CellContentClick;
            dgvPhieuMuon.CellFormatting += dgvPhieuMuon_CellFormatting;
            // 
            // btnInPhieuMuon
            // 
            btnInPhieuMuon.Location = new Point(241, 383);
            btnInPhieuMuon.Name = "btnInPhieuMuon";
            btnInPhieuMuon.Size = new Size(129, 29);
            btnInPhieuMuon.TabIndex = 14;
            btnInPhieuMuon.Text = "In phiéu mượn...";
            btnInPhieuMuon.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(639, 383);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 13;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnTimKIem
            // 
            btnTimKIem.Location = new Point(760, 383);
            btnTimKIem.Name = "btnTimKIem";
            btnTimKIem.Size = new Size(94, 29);
            btnTimKIem.TabIndex = 12;
            btnTimKIem.Text = "Tìm kiếm...";
            btnTimKIem.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(518, 383);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 11;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(397, 383);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 10;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnLapPhieuMuon
            // 
            btnLapPhieuMuon.ForeColor = Color.Blue;
            btnLapPhieuMuon.Location = new Point(49, 383);
            btnLapPhieuMuon.Name = "btnLapPhieuMuon";
            btnLapPhieuMuon.Size = new Size(165, 29);
            btnLapPhieuMuon.TabIndex = 9;
            btnLapPhieuMuon.Text = "Lập phếu mượn mới...";
            btnLapPhieuMuon.UseVisualStyleBackColor = true;
            btnLapPhieuMuon.Click += btnLapPhieuMuon_Click;
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(881, 383);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(94, 29);
            btnXuat.TabIndex = 1;
            btnXuat.Text = "Xuất Excel..";
            btnXuat.UseVisualStyleBackColor = true;
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
            // frmPhieuMuon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1085, 450);
            Controls.Add(btnXuat);
            Controls.Add(btnInPhieuMuon);
            Controls.Add(btnThoat);
            Controls.Add(btnTimKIem);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnLapPhieuMuon);
            Controls.Add(groupBox1);
            Name = "frmPhieuMuon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phiếu mượn";
            Load += frmPhieuMuon_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPhieuMuon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dgvPhieuMuon;
        private Button btnInPhieuMuon;
        private Button btnThoat;
        private Button btnTimKIem;
        private Button btnXoa;
        private Button btnSua;
        private Button btnLapPhieuMuon;
        private Button btnXuat;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colNhanVien;
        private DataGridViewTextBoxColumn colThanhVien;
        private DataGridViewTextBoxColumn colNgayMuon;
        private DataGridViewTextBoxColumn colTrangThai;
        private DataGridViewLinkColumn colChiTiet;
    }
}