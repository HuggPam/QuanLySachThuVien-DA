using System;
using QuanLyThuVien.Forms;
using QuanLyThuVien.Reports;
namespace QuanLyThuVien
{
    internal static class Program
    {
        public static int MaNhanVienDangNhap;
        public static string TenNhanVienDangNhap;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new frmMain());
        }
    }
}