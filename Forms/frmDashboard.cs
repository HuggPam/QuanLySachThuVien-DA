using QuanLyThuVien.Data;
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
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            LoadThongKe();
            LoadSachCuonNgang();
            LoadSachHot();
        }

        private void LoadThongKe()
        {
            using (var db = new QLTVContext())
            {
                int tongSach = db.Sach.Sum(s => (int?)s.SoLuong) ?? 0;
                lblTongSach.Text = tongSach.ToString();

                int tongTV = db.ThanhVien.Count();
                lblTongThanhVien.Text = tongTV.ToString();

                int biKhoa = db.ThanhVien.Where(tv => tv.TrangThai == 1).Count();
                lblBiKhoa.Text = biKhoa.ToString();

                decimal doanhThu = db.PhieuThu.Sum(p => (decimal?)p.SoTienThu) ?? 0;
                lblDoanhThu.Text = doanhThu.ToString("#,##0 VNĐ");
            }
        }

        private void LoadSachCuonNgang()
        {
            flpSach.Controls.Clear();
            flpSach.WrapContents = false;
            flpSach.AutoScroll = true;

            string imagesFolder = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\..\Images"));

            using (var db = new QLTVContext())
            {
                var dsSach = db.Sach.OrderByDescending(s => s.ID).Take(10).Select(s => new
                               {
                                   ID = s.ID,
                                   TenSach = s.TenSach,
                                   HinhAnh = s.HinhAnh,
                                   SoLuong = s.SoLuong,
                                   TenTacGia = s.TacGia.TenTacGia
                               })
                               .ToList();

                foreach (var sach in dsSach)
                {
                    Panel pnlCardSach = new Panel();
                    pnlCardSach.Width = 170;
                    pnlCardSach.Height = 310;
                    pnlCardSach.Margin = new Padding(20, 5, 20, 5);
                    pnlCardSach.BorderStyle = BorderStyle.None;
                    pnlCardSach.BackColor = this.BackColor;

                    Panel pnlText = new Panel();
                    pnlText.Dock = DockStyle.Bottom; 
                    pnlText.Height = 55; 

                    Label lblTacGia = new Label();
                    lblTacGia.Text = sach.TenTacGia;
                    lblTacGia.Dock = DockStyle.Bottom;
                    lblTacGia.Height = 25;
                    lblTacGia.TextAlign = ContentAlignment.TopCenter;
                    lblTacGia.Font = new Font("Segoe UI", 8, FontStyle.Regular); 
                    lblTacGia.ForeColor = Color.DimGray;
                    lblTacGia.AutoEllipsis = true; 

                    Label lblTen = new Label();
                    lblTen.Text = sach.TenSach;
                    lblTen.Dock = DockStyle.Top;
                    lblTen.Height = 30;
                    lblTen.TextAlign = ContentAlignment.BottomCenter;
                    lblTen.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                    lblTen.AutoEllipsis = true; 

                    pnlText.Controls.Add(lblTen);
                    pnlText.Controls.Add(lblTacGia);

                    PictureBox picBox = new PictureBox();
                    picBox.Dock = DockStyle.Fill;
                    picBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    picBox.BackColor = Color.White;

                    try
                    {
                        if (!string.IsNullOrEmpty(sach.HinhAnh))
                        {
                            string duongDanAnh = Path.Combine(imagesFolder, sach.HinhAnh);
                            if (File.Exists(duongDanAnh))
                            {
                                picBox.Image = Image.FromFile(duongDanAnh);
                            }
                        }
                    }
                    catch { }

                    if (sach.SoLuong <= 0)
                    {
                        Label lblHetHang = new Label();
                        lblHetHang.Text = "HẾT HÀNG";
                        lblHetHang.BackColor = Color.FromArgb(220, 53, 69);
                        lblHetHang.ForeColor = Color.White;
                        lblHetHang.Font = new Font("Segoe UI", 8, FontStyle.Bold);
                        lblHetHang.AutoSize = true;
                        lblHetHang.Padding = new Padding(3);
                        lblHetHang.Location = new Point(5, 5);
                        picBox.Controls.Add(lblHetHang);
                    }

                    pnlCardSach.Controls.Add(picBox);  
                    pnlCardSach.Controls.Add(pnlText); 
                    flpSach.Controls.Add(pnlCardSach); 
                }
            }
        }

        private void LoadSachHot()
        {
            flpSachHot.Controls.Clear();
            flpSachHot.WrapContents = false;
            flpSachHot.AutoScroll = true;

            string imagesFolder = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\..\Images"));

            using (var db = new QLTVContext())
            {
                var dsSachHot = db.Sach
                                  .Select(s => new
                                  {
                                      ID = s.ID,
                                      TenSach = s.TenSach,
                                      HinhAnh = s.HinhAnh,
                                      TenTacGia = s.TacGia.TenTacGia,
                                      SoLuong = s.SoLuong,
                                      LuotMuon = db.ChiTietPhieuMuon.Count(ct => ct.SachID == s.ID)
                                  })
                                  .Where(s => s.LuotMuon > 0) 
                                  .OrderByDescending(s => s.LuotMuon) 
                                  .Take(10) 
                                  .ToList();

                foreach (var sach in dsSachHot)
                {
                    Panel pnlCardSach = new Panel();
                    pnlCardSach.Width = 170;
                    pnlCardSach.Height = 310;
                    pnlCardSach.Margin = new Padding(20, 5, 20, 5);
                    pnlCardSach.BorderStyle = BorderStyle.None;
                    pnlCardSach.BackColor = this.BackColor;

                    Panel pnlText = new Panel();
                    pnlText.Dock = DockStyle.Bottom;
                    pnlText.Height = 65; 

                    Label lblLuotMuon = new Label();
                    lblLuotMuon.Text = $"🔥 {sach.LuotMuon} lượt mượn";
                    lblLuotMuon.Dock = DockStyle.Bottom;
                    lblLuotMuon.Height = 20;
                    lblLuotMuon.TextAlign = ContentAlignment.TopCenter;
                    lblLuotMuon.Font = new Font("Segoe UI", 8, FontStyle.Bold);
                    lblLuotMuon.ForeColor = Color.FromArgb(220, 53, 69);

                    Label lblTacGia = new Label();
                    lblTacGia.Text = sach.TenTacGia;
                    lblTacGia.Dock = DockStyle.Bottom;
                    lblTacGia.Height = 20;
                    lblTacGia.TextAlign = ContentAlignment.TopCenter;
                    lblTacGia.Font = new Font("Segoe UI", 8, FontStyle.Regular);
                    lblTacGia.ForeColor = Color.DimGray;
                    lblTacGia.AutoEllipsis = true;

                    Label lblTen = new Label();
                    lblTen.Text = sach.TenSach;
                    lblTen.Dock = DockStyle.Top;
                    lblTen.Height = 25;
                    lblTen.TextAlign = ContentAlignment.BottomCenter;
                    lblTen.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                    lblTen.AutoEllipsis = true;

                    pnlText.Controls.Add(lblTen);
                    pnlText.Controls.Add(lblTacGia);
                    pnlText.Controls.Add(lblLuotMuon);

                    PictureBox picBox = new PictureBox();
                    picBox.Dock = DockStyle.Fill;
                    picBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    picBox.BackColor = Color.White;

                    try
                    {
                        if (!string.IsNullOrEmpty(sach.HinhAnh))
                        {
                            string duongDanAnh = Path.Combine(imagesFolder, sach.HinhAnh);
                            if (File.Exists(duongDanAnh))
                            {
                                picBox.Image = Image.FromFile(duongDanAnh);
                            }
                        }
                    }
                    catch { }

                    if (sach.SoLuong <= 0)
                    {
                        Label lblHetHang = new Label();
                        lblHetHang.Text = "HẾT HÀNG";
                        lblHetHang.BackColor = Color.FromArgb(220, 53, 69);
                        lblHetHang.ForeColor = Color.White;
                        lblHetHang.Font = new Font("Segoe UI", 8, FontStyle.Bold);
                        lblHetHang.AutoSize = true;
                        lblHetHang.Padding = new Padding(3);
                        lblHetHang.Location = new Point(5, 5);
                        picBox.Controls.Add(lblHetHang);
                    }

                    pnlCardSach.Controls.Add(picBox);
                    pnlCardSach.Controls.Add(pnlText);

                    flpSachHot.Controls.Add(pnlCardSach);
                }
            }
        }

        private void lblDoanhThu_Click(object sender, EventArgs e)
        {

        }
    }
}