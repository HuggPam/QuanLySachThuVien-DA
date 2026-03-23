using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyThuVien.Migrations
{
    /// <inheritdoc />
    public partial class uhhhhhh : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KhoaThe",
                table: "ThanhVien");

            migrationBuilder.AddColumn<int>(
                name: "TrangThai",
                table: "ThanhVien",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TrangThai",
                table: "PhieuMuon",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "HanTra",
                table: "ChiTietPhieuMuon",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "SoLanGiaHan",
                table: "ChiTietPhieuMuon",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TrangThai",
                table: "ThanhVien");

            migrationBuilder.DropColumn(
                name: "TrangThai",
                table: "PhieuMuon");

            migrationBuilder.DropColumn(
                name: "HanTra",
                table: "ChiTietPhieuMuon");

            migrationBuilder.DropColumn(
                name: "SoLanGiaHan",
                table: "ChiTietPhieuMuon");

            migrationBuilder.AddColumn<bool>(
                name: "KhoaThe",
                table: "ThanhVien",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
