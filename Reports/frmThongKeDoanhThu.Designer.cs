namespace QuanLyThuVien.Reports
{
    partial class frmThongKeDoanhThu
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
            label4 = new Label();
            dtpDenNgay = new DateTimePicker();
            label1 = new Label();
            btnLocKetQua = new Button();
            dtpTuNgay = new DateTimePicker();
            btnHienTatCa = new Button();
            cboLoaiThu = new ComboBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // reportViewer1
            // 
            reportViewer1.Location = new Point(0, 0);
            reportViewer1.Name = "ReportViewer";
            reportViewer1.ServerReport.BearerToken = null;
            reportViewer1.Size = new Size(396, 246);
            reportViewer1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(299, 15);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 16;
            label4.Text = "Đến ngày:";
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.CustomFormat = "dd/MM/yyyy";
            dtpDenNgay.Format = DateTimePickerFormat.Custom;
            dtpDenNgay.Location = new Point(380, 12);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(187, 27);
            dtpDenNgay.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 15);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 14;
            label1.Text = "Từ ngày:";
            // 
            // btnLocKetQua
            // 
            btnLocKetQua.Location = new Point(853, 13);
            btnLocKetQua.Name = "btnLocKetQua";
            btnLocKetQua.Size = new Size(94, 29);
            btnLocKetQua.TabIndex = 13;
            btnLocKetQua.Text = "Lọc kết quả";
            btnLocKetQua.UseVisualStyleBackColor = true;
            btnLocKetQua.Click += btnLocKetQua_Click;
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.CustomFormat = "dd/MM/yyyy";
            dtpTuNgay.Format = DateTimePickerFormat.Custom;
            dtpTuNgay.Location = new Point(102, 12);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(183, 27);
            dtpTuNgay.TabIndex = 12;
            // 
            // btnHienTatCa
            // 
            btnHienTatCa.Location = new Point(953, 13);
            btnHienTatCa.Name = "btnHienTatCa";
            btnHienTatCa.Size = new Size(94, 29);
            btnHienTatCa.TabIndex = 17;
            btnHienTatCa.Text = "Hiện tất cả";
            btnHienTatCa.UseVisualStyleBackColor = true;
            btnHienTatCa.Click += btnHienTatCa_Click;
            // 
            // cboLoaiThu
            // 
            cboLoaiThu.FormattingEnabled = true;
            cboLoaiThu.Location = new Point(653, 12);
            cboLoaiThu.Name = "cboLoaiThu";
            cboLoaiThu.Size = new Size(183, 28);
            cboLoaiThu.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(582, 15);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 19;
            label2.Text = "Loại thu:";
            // 
            // frmThongKeDoanhThu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1073, 450);
            Controls.Add(label2);
            Controls.Add(cboLoaiThu);
            Controls.Add(btnHienTatCa);
            Controls.Add(label4);
            Controls.Add(dtpDenNgay);
            Controls.Add(label1);
            Controls.Add(btnLocKetQua);
            Controls.Add(dtpTuNgay);
            Name = "frmThongKeDoanhThu";
            Text = "Thống kê doanh thu";
            Load += frmThongKeDoanhThu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Label label4;
        private DateTimePicker dtpDenNgay;
        private Label label1;
        private Button btnLocKetQua;
        private DateTimePicker dtpTuNgay;
        private Button btnHienTatCa;
        private ComboBox cboLoaiThu;
        private Label label2;
    }
}