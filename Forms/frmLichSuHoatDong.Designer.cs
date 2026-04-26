namespace QuanLyThuVien.Forms
{
    partial class frmLichSuHoatDong
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
            panel1 = new Panel();
            dtpDenNgay = new DateTimePicker();
            label4 = new Label();
            label1 = new Label();
            btnLocKetQua = new Button();
            dtpTuNgay = new DateTimePicker();
            btnHienTatCa = new Button();
            panel2 = new Panel();
            dgvLichSu = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colTenNhanVien = new DataGridViewTextBoxColumn();
            colTieuDe = new DataGridViewTextBoxColumn();
            colNoiDung = new DataGridViewTextBoxColumn();
            colThoiGian = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLichSu).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dtpDenNgay);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnLocKetQua);
            panel1.Controls.Add(dtpTuNgay);
            panel1.Controls.Add(btnHienTatCa);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(966, 86);
            panel1.TabIndex = 0;
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.Anchor = AnchorStyles.Top;
            dtpDenNgay.CustomFormat = "dd/MM/yyyy";
            dtpDenNgay.Format = DateTimePickerFormat.Custom;
            dtpDenNgay.Location = new Point(423, 26);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(187, 27);
            dtpDenNgay.TabIndex = 21;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Location = new Point(342, 26);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 22;
            label4.Text = "Đến ngày:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(74, 26);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 20;
            label1.Text = "Từ ngày:";
            // 
            // btnLocKetQua
            // 
            btnLocKetQua.Anchor = AnchorStyles.Top;
            btnLocKetQua.Location = new Point(633, 26);
            btnLocKetQua.Name = "btnLocKetQua";
            btnLocKetQua.Size = new Size(126, 29);
            btnLocKetQua.TabIndex = 19;
            btnLocKetQua.Text = "Lọc kết quả";
            btnLocKetQua.UseVisualStyleBackColor = true;
            btnLocKetQua.Click += btnLocKetQua_Click;
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.Anchor = AnchorStyles.Top;
            dtpTuNgay.CustomFormat = "dd/MM/yyyy";
            dtpTuNgay.Format = DateTimePickerFormat.Custom;
            dtpTuNgay.Location = new Point(145, 26);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(183, 27);
            dtpTuNgay.TabIndex = 18;
            // 
            // btnHienTatCa
            // 
            btnHienTatCa.Anchor = AnchorStyles.Top;
            btnHienTatCa.Location = new Point(776, 26);
            btnHienTatCa.Name = "btnHienTatCa";
            btnHienTatCa.Size = new Size(112, 29);
            btnHienTatCa.TabIndex = 23;
            btnHienTatCa.Text = "Hiện tất cả";
            btnHienTatCa.UseVisualStyleBackColor = true;
            btnHienTatCa.Click += btnHienTatCa_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvLichSu);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 86);
            panel2.Name = "panel2";
            panel2.Size = new Size(966, 364);
            panel2.TabIndex = 1;
            // 
            // dgvLichSu
            // 
            dgvLichSu.AllowUserToAddRows = false;
            dgvLichSu.AllowUserToDeleteRows = false;
            dgvLichSu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLichSu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLichSu.Columns.AddRange(new DataGridViewColumn[] { colID, colTenNhanVien, colTieuDe, colNoiDung, colThoiGian });
            dgvLichSu.Dock = DockStyle.Fill;
            dgvLichSu.Location = new Point(0, 0);
            dgvLichSu.Name = "dgvLichSu";
            dgvLichSu.RowHeadersVisible = false;
            dgvLichSu.RowHeadersWidth = 51;
            dgvLichSu.Size = new Size(966, 364);
            dgvLichSu.TabIndex = 0;
            // 
            // colID
            // 
            colID.DataPropertyName = "ID";
            colID.FillWeight = 30F;
            colID.HeaderText = "ID";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            // 
            // colTenNhanVien
            // 
            colTenNhanVien.DataPropertyName = "TenNhanVien";
            colTenNhanVien.HeaderText = "Nhân viên";
            colTenNhanVien.MinimumWidth = 6;
            colTenNhanVien.Name = "colTenNhanVien";
            // 
            // colTieuDe
            // 
            colTieuDe.DataPropertyName = "TieuDe";
            colTieuDe.HeaderText = "Hoạt động";
            colTieuDe.MinimumWidth = 6;
            colTieuDe.Name = "colTieuDe";
            // 
            // colNoiDung
            // 
            colNoiDung.DataPropertyName = "NoiDung";
            dataGridViewCellStyle1.Format = "dd/MM/yyyy HH:mm";
            dataGridViewCellStyle1.NullValue = null;
            colNoiDung.DefaultCellStyle = dataGridViewCellStyle1;
            colNoiDung.FillWeight = 200F;
            colNoiDung.HeaderText = "Chi tiết";
            colNoiDung.MinimumWidth = 6;
            colNoiDung.Name = "colNoiDung";
            // 
            // colThoiGian
            // 
            colThoiGian.DataPropertyName = "ThoiGian";
            colThoiGian.HeaderText = "Thời gian";
            colThoiGian.MinimumWidth = 6;
            colThoiGian.Name = "colThoiGian";
            // 
            // frmLichSuHoatDong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(966, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmLichSuHoatDong";
            Text = "Lich sử hoạt động";
            Load += frmLichSuHoatDong_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLichSu).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dgvLichSu;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colTenNhanVien;
        private DataGridViewTextBoxColumn colTieuDe;
        private DataGridViewTextBoxColumn colNoiDung;
        private DataGridViewTextBoxColumn colThoiGian;
        private DateTimePicker dtpDenNgay;
        private Label label4;
        private Label label1;
        private Button btnLocKetQua;
        private DateTimePicker dtpTuNgay;
        private Button btnHienTatCa;
    }
}