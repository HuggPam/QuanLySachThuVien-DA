using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien.Forms
{

    public partial class frmXemAnh : Form
    {
        private bool isZoomed = false;
        private Size originalSize;
        public frmXemAnh(Image img)
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            if (img != null)
            {
                picBigHinh.Image = img;
                picBigHinh.SizeMode = PictureBoxSizeMode.Zoom;
                picBigHinh.BackColor = Color.Black;

                picBigHinh.Width = (int)(Screen.PrimaryScreen.Bounds.Width * 0.85);
                picBigHinh.Height = (int)(Screen.PrimaryScreen.Bounds.Height * 0.85);
                originalSize = picBigHinh.Size;
            }
        }
        private void CanhGiuaHinh()
        {
            picBigHinh.Left = (this.Width - picBigHinh.Width) / 2;
            picBigHinh.Top = (this.Height - picBigHinh.Height) / 2;
        }

        private void frmXemAnh_Load(object sender, EventArgs e)
        {
            CanhGiuaHinh();
        }

        private void frmXemAnh_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picBigHinh_Click_1(object sender, EventArgs e)
        {
            if (!isZoomed)
            {
                picBigHinh.Width = (int)(originalSize.Width * 1.2);
                picBigHinh.Height = (int)(originalSize.Height * 1.2);
                isZoomed = true;
            }
            else
            {
                picBigHinh.Size = originalSize;
                isZoomed = false;
            }
            CanhGiuaHinh();
        }
    }
}
