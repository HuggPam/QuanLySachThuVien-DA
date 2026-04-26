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
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // reportViewer1
            // 
            reportViewer1.Anchor = AnchorStyles.Top;
            reportViewer1.Location = new Point(0, 0);
            reportViewer1.Name = "ReportViewer";
            reportViewer1.ServerReport.BearerToken = null;
            reportViewer1.Size = new Size(396, 246);
            reportViewer1.TabIndex = 0;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Location = new Point(309, 15);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 16;
            label4.Text = "Đến ngày:";
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.Anchor = AnchorStyles.Top;
            dtpDenNgay.CustomFormat = "dd/MM/yyyy";
            dtpDenNgay.Format = DateTimePickerFormat.Custom;
            dtpDenNgay.Location = new Point(390, 12);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(187, 27);
            dtpDenNgay.TabIndex = 15;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(41, 15);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 14;
            label1.Text = "Từ ngày:";
            // 
            // btnLocKetQua
            // 
            btnLocKetQua.Anchor = AnchorStyles.Top;
            btnLocKetQua.Location = new Point(863, 13);
            btnLocKetQua.Name = "btnLocKetQua";
            btnLocKetQua.Size = new Size(126, 29);
            btnLocKetQua.TabIndex = 13;
            btnLocKetQua.Text = "Lọc kết quả";
            btnLocKetQua.UseVisualStyleBackColor = true;
            btnLocKetQua.Click += btnLocKetQua_Click;
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.Anchor = AnchorStyles.Top;
            dtpTuNgay.CustomFormat = "dd/MM/yyyy";
            dtpTuNgay.Format = DateTimePickerFormat.Custom;
            dtpTuNgay.Location = new Point(112, 12);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(183, 27);
            dtpTuNgay.TabIndex = 12;
            // 
            // btnHienTatCa
            // 
            btnHienTatCa.Anchor = AnchorStyles.Top;
            btnHienTatCa.Location = new Point(995, 13);
            btnHienTatCa.Name = "btnHienTatCa";
            btnHienTatCa.Size = new Size(112, 29);
            btnHienTatCa.TabIndex = 17;
            btnHienTatCa.Text = "Hiện tất cả";
            btnHienTatCa.UseVisualStyleBackColor = true;
            btnHienTatCa.Click += btnHienTatCa_Click;
            // 
            // cboLoaiThu
            // 
            cboLoaiThu.Anchor = AnchorStyles.Top;
            cboLoaiThu.FormattingEnabled = true;
            cboLoaiThu.Location = new Point(663, 12);
            cboLoaiThu.Name = "cboLoaiThu";
            cboLoaiThu.Size = new Size(183, 28);
            cboLoaiThu.TabIndex = 18;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(592, 15);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 19;
            label2.Text = "Loại thu:";
            // 
            // panel1
            // 
            panel1.Controls.Add(dtpDenNgay);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cboLoaiThu);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnLocKetQua);
            panel1.Controls.Add(dtpTuNgay);
            panel1.Controls.Add(btnHienTatCa);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1145, 60);
            panel1.TabIndex = 20;
            // 
            // frmThongKeDoanhThu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1145, 450);
            Controls.Add(panel1);
            Name = "frmThongKeDoanhThu";
            Text = "Thống kê doanh thu";
            Load += frmThongKeDoanhThu_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
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
        private Panel panel1;
    }
}