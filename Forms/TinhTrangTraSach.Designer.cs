namespace QuanLyThuVien.Forms
{
    partial class TinhTrangTraSach
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
            lblTenSach = new Label();
            radBinhThuong = new RadioButton();
            radHuHong = new RadioButton();
            radMatSach = new RadioButton();
            btnXacNhan = new Button();
            SuspendLayout();
            // 
            // lblTenSach
            // 
            lblTenSach.AutoSize = true;
            lblTenSach.Location = new Point(12, 9);
            lblTenSach.Name = "lblTenSach";
            lblTenSach.Size = new Size(65, 20);
            lblTenSach.TabIndex = 0;
            lblTenSach.Text = "Tên sách";
            // 
            // radBinhThuong
            // 
            radBinhThuong.AutoSize = true;
            radBinhThuong.Location = new Point(107, 63);
            radBinhThuong.Name = "radBinhThuong";
            radBinhThuong.Size = new Size(111, 24);
            radBinhThuong.TabIndex = 1;
            radBinhThuong.TabStop = true;
            radBinhThuong.Text = "Bình thường";
            radBinhThuong.UseVisualStyleBackColor = true;
            // 
            // radHuHong
            // 
            radHuHong.AutoSize = true;
            radHuHong.Location = new Point(107, 153);
            radHuHong.Name = "radHuHong";
            radHuHong.Size = new Size(88, 24);
            radHuHong.TabIndex = 2;
            radHuHong.TabStop = true;
            radHuHong.Text = "Hư hỏng";
            radHuHong.UseVisualStyleBackColor = true;
            // 
            // radMatSach
            // 
            radMatSach.AutoSize = true;
            radMatSach.Location = new Point(107, 108);
            radMatSach.Name = "radMatSach";
            radMatSach.Size = new Size(88, 24);
            radMatSach.TabIndex = 3;
            radMatSach.TabStop = true;
            radMatSach.Text = "Làm mất";
            radMatSach.UseVisualStyleBackColor = true;
            // 
            // btnXacNhan
            // 
            btnXacNhan.Location = new Point(107, 199);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(94, 29);
            btnXacNhan.TabIndex = 4;
            btnXacNhan.Text = "Xác nhận";
            btnXacNhan.UseVisualStyleBackColor = true;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // TinhTrangTraSach
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(315, 311);
            Controls.Add(btnXacNhan);
            Controls.Add(radMatSach);
            Controls.Add(radHuHong);
            Controls.Add(radBinhThuong);
            Controls.Add(lblTenSach);
            Name = "TinhTrangTraSach";
            Text = "Tình trạng sách";
            Load += TinhTrangTraSach_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTenSach;
        private RadioButton radBinhThuong;
        private RadioButton radHuHong;
        private RadioButton radMatSach;
        private Button btnXacNhan;
    }
}