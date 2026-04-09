namespace QuanLyThuVien.Reports
{
    partial class frmThongKeHoatDong
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
            reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            cboThanhVien = new ComboBox();
            cboTrangThai = new ComboBox();
            dtpTuNgay = new DateTimePicker();
            btnLocKetQua = new Button();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            dtpDenNgay = new DateTimePicker();
            label3 = new Label();
            btnHienTatCa = new Button();
            SuspendLayout();
            // 
            // reportViewer1
            // 
            reportViewer1.Dock = DockStyle.Fill;
            reportViewer1.Location = new Point(0, 0);
            reportViewer1.Name = "ReportViewer";
            reportViewer1.ServerReport.BearerToken = null;
            reportViewer1.Size = new Size(396, 246);
            reportViewer1.TabIndex = 0;
            // 
            // cboThanhVien
            // 
            cboThanhVien.FormattingEnabled = true;
            cboThanhVien.Location = new Point(138, 12);
            cboThanhVien.Name = "cboThanhVien";
            cboThanhVien.Size = new Size(183, 28);
            cboThanhVien.TabIndex = 0;
            // 
            // cboTrangThai
            // 
            cboTrangThai.FormattingEnabled = true;
            cboTrangThai.Location = new Point(447, 10);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(187, 28);
            cboTrangThai.TabIndex = 1;
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.CustomFormat = "dd/MM/yyyy";
            dtpTuNgay.Format = DateTimePickerFormat.Custom;
            dtpTuNgay.Location = new Point(138, 50);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(183, 27);
            dtpTuNgay.TabIndex = 2;
            // 
            // btnLocKetQua
            // 
            btnLocKetQua.Location = new Point(663, 11);
            btnLocKetQua.Name = "btnLocKetQua";
            btnLocKetQua.Size = new Size(94, 29);
            btnLocKetQua.TabIndex = 6;
            btnLocKetQua.Text = "Lọc kết quả";
            btnLocKetQua.UseVisualStyleBackColor = true;
            btnLocKetQua.Click += btnLocKetQua_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 55);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 7;
            label1.Text = "Từ ngày:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 18);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 8;
            label2.Text = "Thành viên:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(366, 55);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 11;
            label4.Text = "Đến ngày:";
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.CustomFormat = "dd/MM/yyyy";
            dtpDenNgay.Format = DateTimePickerFormat.Custom;
            dtpDenNgay.Location = new Point(447, 50);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(187, 27);
            dtpDenNgay.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(363, 11);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 9;
            label3.Text = "Trạng thái:";
            // 
            // btnHienTatCa
            // 
            btnHienTatCa.Location = new Point(663, 55);
            btnHienTatCa.Name = "btnHienTatCa";
            btnHienTatCa.Size = new Size(94, 29);
            btnHienTatCa.TabIndex = 12;
            btnHienTatCa.Text = "Hiện tất cả";
            btnHienTatCa.UseVisualStyleBackColor = true;
            btnHienTatCa.Click += btnHienTatCa_Click;
            // 
            // frmThongKeHoatDong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(btnHienTatCa);
            Controls.Add(dtpDenNgay);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLocKetQua);
            Controls.Add(dtpTuNgay);
            Controls.Add(cboTrangThai);
            Controls.Add(cboThanhVien);
            Name = "frmThongKeHoatDong";
            Text = "Thống kê hoạt động";
            Load += frmThongKeHoatDong_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private ComboBox cboThanhVien;
        private ComboBox cboTrangThai;
        private DateTimePicker dtpTuNgay;
        private Button btnLocKetQua;
        private Label label1;
        private Label label2;
        private Label label4;
        private DateTimePicker dtpDenNgay;
        private Label label3;
        private Button btnHienTatCa;
    }
}