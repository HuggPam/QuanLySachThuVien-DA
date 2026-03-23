using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyThuVien.Migrations
{
    /// <inheritdoc />
    public partial class BoSung : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "KhoaThe",
                table: "ThanhVien",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SoLanViPham",
                table: "ThanhVien",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SoLanGiaHanToiDa",
                table: "GoiThanhVien",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SoNgayMuonToiDa",
                table: "GoiThanhVien",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "GhiChu",
                table: "ChiTietPhieuMuon",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KhoaThe",
                table: "ThanhVien");

            migrationBuilder.DropColumn(
                name: "SoLanViPham",
                table: "ThanhVien");

            migrationBuilder.DropColumn(
                name: "SoLanGiaHanToiDa",
                table: "GoiThanhVien");

            migrationBuilder.DropColumn(
                name: "SoNgayMuonToiDa",
                table: "GoiThanhVien");

            migrationBuilder.AlterColumn<string>(
                name: "GhiChu",
                table: "ChiTietPhieuMuon",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
