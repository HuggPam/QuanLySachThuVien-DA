namespace QuanLyThuVien.Forms
{
    partial class frmDoiMatKhau
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
            txtMatKhauCu = new TextBox();
            txtMatKhauMoi = new TextBox();
            txtXacNhan = new TextBox();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            btnHuy = new Button();
            btnLuu = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtMatKhauCu
            // 
            txtMatKhauCu.Location = new Point(167, 108);
            txtMatKhauCu.Name = "txtMatKhauCu";
            txtMatKhauCu.PasswordChar = '*';
            txtMatKhauCu.Size = new Size(252, 27);
            txtMatKhauCu.TabIndex = 0;
            txtMatKhauCu.UseSystemPasswordChar = true;
            // 
            // txtMatKhauMoi
            // 
            txtMatKhauMoi.Location = new Point(167, 168);
            txtMatKhauMoi.Name = "txtMatKhauMoi";
            txtMatKhauMoi.PasswordChar = '*';
            txtMatKhauMoi.Size = new Size(252, 27);
            txtMatKhauMoi.TabIndex = 1;
            txtMatKhauMoi.UseSystemPasswordChar = true;
            // 
            // txtXacNhan
            // 
            txtXacNhan.Location = new Point(167, 228);
            txtXacNhan.Name = "txtXacNhan";
            txtXacNhan.PasswordChar = '*';
            txtXacNhan.Size = new Size(252, 27);
            txtXacNhan.TabIndex = 2;
            txtXacNhan.UseSystemPasswordChar = true;
            txtXacNhan.TextChanged += textBox3_TextChanged;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(325, 292);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 3;
            btnHuy.Text = "Thoát";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(167, 292);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(124, 29);
            btnLuu.TabIndex = 4;
            btnLuu.Text = "Đổi mật khẩu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 111);
            label1.Name = "label1";
            label1.Size = new Size(126, 20);
            label1.TabIndex = 5;
            label1.Text = "Mật khẩu hiện tại:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 173);
            label2.Name = "label2";
            label2.Size = new Size(103, 20);
            label2.TabIndex = 6;
            label2.Text = "Mật khẩu mới:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(80, 235);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 7;
            label3.Text = "Xác nhận:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label4.Location = new Point(156, 34);
            label4.Name = "label4";
            label4.Size = new Size(202, 35);
            label4.TabIndex = 8;
            label4.Text = "ĐỔI MẬT KHẨU";
            // 
            // frmDoiMatKhau
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(508, 345);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLuu);
            Controls.Add(btnHuy);
            Controls.Add(txtXacNhan);
            Controls.Add(txtMatKhauMoi);
            Controls.Add(txtMatKhauCu);
            Name = "frmDoiMatKhau";
            Text = "Đổi mật khẩu";
            Load += frmDoiMatKhau_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMatKhauCu;
        private TextBox txtMatKhauMoi;
        private TextBox txtXacNhan;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private Button btnHuy;
        private Button btnLuu;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}