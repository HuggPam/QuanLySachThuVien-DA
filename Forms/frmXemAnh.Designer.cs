namespace QuanLyThuVien.Forms
{
    partial class frmXemAnh
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
            picBigHinh = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picBigHinh).BeginInit();
            SuspendLayout();
            // 
            // picBigHinh
            // 
            picBigHinh.Location = new Point(0, 0);
            picBigHinh.Name = "picBigHinh";
            picBigHinh.Size = new Size(125, 62);
            picBigHinh.TabIndex = 0;
            picBigHinh.TabStop = false;
            picBigHinh.Click += picBigHinh_Click_1;
            // 
            // frmXemAnh
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(picBigHinh);
            Cursor = Cursors.Hand;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmXemAnh";
            Opacity = 0.92D;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Xem ảnh bìa";
            WindowState = FormWindowState.Maximized;
            Load += frmXemAnh_Load;
            Click += frmXemAnh_Click_1;
            ((System.ComponentModel.ISupportInitialize)picBigHinh).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picBigHinh;
    }
}