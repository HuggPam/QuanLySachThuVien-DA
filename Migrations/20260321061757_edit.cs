using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyThuVien.Migrations
{
    /// <inheritdoc />
    public partial class edit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SoDienThoai",
                table: "ThanhVien",
                newName: "DienThoai");

            migrationBuilder.RenameColumn(
                name: "SoDienThoai",
                table: "NhaXuatBan",
                newName: "DienThoai");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DienThoai",
                table: "ThanhVien",
                newName: "SoDienThoai");

            migrationBuilder.RenameColumn(
                name: "DienThoai",
                table: "NhaXuatBan",
                newName: "SoDienThoai");
        }
    }
}
