using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyThuVien.Migrations
{
    /// <inheritdoc />
    public partial class CapNhatCode : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MaGoi",
                table: "ThanhViens",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayDangKy",
                table: "ThanhViens",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayHetHan",
                table: "ThanhViens",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "GoiThanhViens",
                columns: table => new
                {
                    MaGoi = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    TenGoi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SoThangHieuLuc = table.Column<int>(type: "int", nullable: false),
                    SoSachDuocMuon = table.Column<int>(type: "int", nullable: false),
                    GiaTien = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoiThanhViens", x => x.MaGoi);
                });

            migrationBuilder.CreateTable(
                name: "PhieuThus",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaThanhVien = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    SoTienThu = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NgayThu = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LyDoThu = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhieuThus", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PhieuThus_ThanhViens_MaThanhVien",
                        column: x => x.MaThanhVien,
                        principalTable: "ThanhViens",
                        principalColumn: "MaThanhVien",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ThanhViens_MaGoi",
                table: "ThanhViens",
                column: "MaGoi");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuThus_MaThanhVien",
                table: "PhieuThus",
                column: "MaThanhVien");

            migrationBuilder.AddForeignKey(
                name: "FK_ThanhViens_GoiThanhViens_MaGoi",
                table: "ThanhViens",
                column: "MaGoi",
                principalTable: "GoiThanhViens",
                principalColumn: "MaGoi",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ThanhViens_GoiThanhViens_MaGoi",
                table: "ThanhViens");

            migrationBuilder.DropTable(
                name: "GoiThanhViens");

            migrationBuilder.DropTable(
                name: "PhieuThus");

            migrationBuilder.DropIndex(
                name: "IX_ThanhViens_MaGoi",
                table: "ThanhViens");

            migrationBuilder.DropColumn(
                name: "MaGoi",
                table: "ThanhViens");

            migrationBuilder.DropColumn(
                name: "NgayDangKy",
                table: "ThanhViens");

            migrationBuilder.DropColumn(
                name: "NgayHetHan",
                table: "ThanhViens");
        }
    }
}
