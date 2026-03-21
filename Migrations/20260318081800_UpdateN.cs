using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyThuVien.Migrations
{
    /// <inheritdoc />
    public partial class UpdateN : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietPhieuMuon_Sach_MaSach",
                table: "ChiTietPhieuMuon");

            migrationBuilder.DropForeignKey(
                name: "FK_PhieuMuon_ThanhVien_MaThanhVien",
                table: "PhieuMuon");

            migrationBuilder.DropForeignKey(
                name: "FK_PhieuThu_ThanhVien_MaThanhVien",
                table: "PhieuThu");

            migrationBuilder.DropForeignKey(
                name: "FK_Sach_TheLoai_MaTheLoai",
                table: "Sach");

            migrationBuilder.DropForeignKey(
                name: "FK_ThanhVien_GoiThanhVien_MaGoi",
                table: "ThanhVien");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TheLoai",
                table: "TheLoai");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ThanhVien",
                table: "ThanhVien");

            migrationBuilder.DropIndex(
                name: "IX_ThanhVien_MaGoi",
                table: "ThanhVien");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sach",
                table: "Sach");

            migrationBuilder.DropIndex(
                name: "IX_Sach_MaTheLoai",
                table: "Sach");

            migrationBuilder.DropIndex(
                name: "IX_PhieuThu_MaThanhVien",
                table: "PhieuThu");

            migrationBuilder.DropIndex(
                name: "IX_PhieuMuon_MaThanhVien",
                table: "PhieuMuon");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GoiThanhVien",
                table: "GoiThanhVien");

            migrationBuilder.DropIndex(
                name: "IX_ChiTietPhieuMuon_MaSach",
                table: "ChiTietPhieuMuon");

            migrationBuilder.DropColumn(
                name: "MaTheLoai",
                table: "TheLoai");

            migrationBuilder.DropColumn(
                name: "MaThanhVien",
                table: "ThanhVien");

            migrationBuilder.DropColumn(
                name: "MaGoi",
                table: "ThanhVien");

            migrationBuilder.DropColumn(
                name: "MaSach",
                table: "Sach");

            migrationBuilder.DropColumn(
                name: "MaTheLoai",
                table: "Sach");

            migrationBuilder.DropColumn(
                name: "TacGia",
                table: "Sach");

            migrationBuilder.DropColumn(
                name: "MaThanhVien",
                table: "PhieuThu");

            migrationBuilder.DropColumn(
                name: "MaThanhVien",
                table: "PhieuMuon");

            migrationBuilder.DropColumn(
                name: "MaGoi",
                table: "GoiThanhVien");

            migrationBuilder.DropColumn(
                name: "MaSach",
                table: "ChiTietPhieuMuon");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "TheLoai",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "ThanhVien",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "GoiThanhVienID",
                table: "ThanhVien",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "Sach",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "NhaXuatBanID",
                table: "Sach",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TacGiaID",
                table: "Sach",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TheLoaiID",
                table: "Sach",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NhanVienID",
                table: "PhieuThu",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ThanhVienID",
                table: "PhieuThu",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NhanVienID",
                table: "PhieuMuon",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ThanhVienID",
                table: "PhieuMuon",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "GoiThanhVien",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "SachID",
                table: "ChiTietPhieuMuon",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TheLoai",
                table: "TheLoai",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ThanhVien",
                table: "ThanhVien",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sach",
                table: "Sach",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GoiThanhVien",
                table: "GoiThanhVien",
                column: "ID");

            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoTen = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SoDienThoai = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    MatKhau = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quyen = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVien", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "NhaXuatBan",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenNhaXuatBan = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoDienThoai = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhaXuatBan", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TacGia",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenTacGia = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TacGia", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ThanhVien_GoiThanhVienID",
                table: "ThanhVien",
                column: "GoiThanhVienID");

            migrationBuilder.CreateIndex(
                name: "IX_Sach_NhaXuatBanID",
                table: "Sach",
                column: "NhaXuatBanID");

            migrationBuilder.CreateIndex(
                name: "IX_Sach_TacGiaID",
                table: "Sach",
                column: "TacGiaID");

            migrationBuilder.CreateIndex(
                name: "IX_Sach_TheLoaiID",
                table: "Sach",
                column: "TheLoaiID");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuThu_NhanVienID",
                table: "PhieuThu",
                column: "NhanVienID");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuThu_ThanhVienID",
                table: "PhieuThu",
                column: "ThanhVienID");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuMuon_NhanVienID",
                table: "PhieuMuon",
                column: "NhanVienID");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuMuon_ThanhVienID",
                table: "PhieuMuon",
                column: "ThanhVienID");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietPhieuMuon_SachID",
                table: "ChiTietPhieuMuon",
                column: "SachID");

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietPhieuMuon_Sach_SachID",
                table: "ChiTietPhieuMuon",
                column: "SachID",
                principalTable: "Sach",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PhieuMuon_NhanVien_NhanVienID",
                table: "PhieuMuon",
                column: "NhanVienID",
                principalTable: "NhanVien",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PhieuMuon_ThanhVien_ThanhVienID",
                table: "PhieuMuon",
                column: "ThanhVienID",
                principalTable: "ThanhVien",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PhieuThu_NhanVien_NhanVienID",
                table: "PhieuThu",
                column: "NhanVienID",
                principalTable: "NhanVien",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PhieuThu_ThanhVien_ThanhVienID",
                table: "PhieuThu",
                column: "ThanhVienID",
                principalTable: "ThanhVien",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sach_NhaXuatBan_NhaXuatBanID",
                table: "Sach",
                column: "NhaXuatBanID",
                principalTable: "NhaXuatBan",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sach_TacGia_TacGiaID",
                table: "Sach",
                column: "TacGiaID",
                principalTable: "TacGia",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sach_TheLoai_TheLoaiID",
                table: "Sach",
                column: "TheLoaiID",
                principalTable: "TheLoai",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ThanhVien_GoiThanhVien_GoiThanhVienID",
                table: "ThanhVien",
                column: "GoiThanhVienID",
                principalTable: "GoiThanhVien",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietPhieuMuon_Sach_SachID",
                table: "ChiTietPhieuMuon");

            migrationBuilder.DropForeignKey(
                name: "FK_PhieuMuon_NhanVien_NhanVienID",
                table: "PhieuMuon");

            migrationBuilder.DropForeignKey(
                name: "FK_PhieuMuon_ThanhVien_ThanhVienID",
                table: "PhieuMuon");

            migrationBuilder.DropForeignKey(
                name: "FK_PhieuThu_NhanVien_NhanVienID",
                table: "PhieuThu");

            migrationBuilder.DropForeignKey(
                name: "FK_PhieuThu_ThanhVien_ThanhVienID",
                table: "PhieuThu");

            migrationBuilder.DropForeignKey(
                name: "FK_Sach_NhaXuatBan_NhaXuatBanID",
                table: "Sach");

            migrationBuilder.DropForeignKey(
                name: "FK_Sach_TacGia_TacGiaID",
                table: "Sach");

            migrationBuilder.DropForeignKey(
                name: "FK_Sach_TheLoai_TheLoaiID",
                table: "Sach");

            migrationBuilder.DropForeignKey(
                name: "FK_ThanhVien_GoiThanhVien_GoiThanhVienID",
                table: "ThanhVien");

            migrationBuilder.DropTable(
                name: "NhanVien");

            migrationBuilder.DropTable(
                name: "NhaXuatBan");

            migrationBuilder.DropTable(
                name: "TacGia");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TheLoai",
                table: "TheLoai");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ThanhVien",
                table: "ThanhVien");

            migrationBuilder.DropIndex(
                name: "IX_ThanhVien_GoiThanhVienID",
                table: "ThanhVien");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sach",
                table: "Sach");

            migrationBuilder.DropIndex(
                name: "IX_Sach_NhaXuatBanID",
                table: "Sach");

            migrationBuilder.DropIndex(
                name: "IX_Sach_TacGiaID",
                table: "Sach");

            migrationBuilder.DropIndex(
                name: "IX_Sach_TheLoaiID",
                table: "Sach");

            migrationBuilder.DropIndex(
                name: "IX_PhieuThu_NhanVienID",
                table: "PhieuThu");

            migrationBuilder.DropIndex(
                name: "IX_PhieuThu_ThanhVienID",
                table: "PhieuThu");

            migrationBuilder.DropIndex(
                name: "IX_PhieuMuon_NhanVienID",
                table: "PhieuMuon");

            migrationBuilder.DropIndex(
                name: "IX_PhieuMuon_ThanhVienID",
                table: "PhieuMuon");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GoiThanhVien",
                table: "GoiThanhVien");

            migrationBuilder.DropIndex(
                name: "IX_ChiTietPhieuMuon_SachID",
                table: "ChiTietPhieuMuon");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "TheLoai");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "ThanhVien");

            migrationBuilder.DropColumn(
                name: "GoiThanhVienID",
                table: "ThanhVien");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "Sach");

            migrationBuilder.DropColumn(
                name: "NhaXuatBanID",
                table: "Sach");

            migrationBuilder.DropColumn(
                name: "TacGiaID",
                table: "Sach");

            migrationBuilder.DropColumn(
                name: "TheLoaiID",
                table: "Sach");

            migrationBuilder.DropColumn(
                name: "NhanVienID",
                table: "PhieuThu");

            migrationBuilder.DropColumn(
                name: "ThanhVienID",
                table: "PhieuThu");

            migrationBuilder.DropColumn(
                name: "NhanVienID",
                table: "PhieuMuon");

            migrationBuilder.DropColumn(
                name: "ThanhVienID",
                table: "PhieuMuon");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "GoiThanhVien");

            migrationBuilder.DropColumn(
                name: "SachID",
                table: "ChiTietPhieuMuon");

            migrationBuilder.AddColumn<string>(
                name: "MaTheLoai",
                table: "TheLoai",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MaThanhVien",
                table: "ThanhVien",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MaGoi",
                table: "ThanhVien",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MaSach",
                table: "Sach",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MaTheLoai",
                table: "Sach",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TacGia",
                table: "Sach",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MaThanhVien",
                table: "PhieuThu",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MaThanhVien",
                table: "PhieuMuon",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MaGoi",
                table: "GoiThanhVien",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MaSach",
                table: "ChiTietPhieuMuon",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TheLoai",
                table: "TheLoai",
                column: "MaTheLoai");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ThanhVien",
                table: "ThanhVien",
                column: "MaThanhVien");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sach",
                table: "Sach",
                column: "MaSach");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GoiThanhVien",
                table: "GoiThanhVien",
                column: "MaGoi");

            migrationBuilder.CreateIndex(
                name: "IX_ThanhVien_MaGoi",
                table: "ThanhVien",
                column: "MaGoi");

            migrationBuilder.CreateIndex(
                name: "IX_Sach_MaTheLoai",
                table: "Sach",
                column: "MaTheLoai");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuThu_MaThanhVien",
                table: "PhieuThu",
                column: "MaThanhVien");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuMuon_MaThanhVien",
                table: "PhieuMuon",
                column: "MaThanhVien");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietPhieuMuon_MaSach",
                table: "ChiTietPhieuMuon",
                column: "MaSach");

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietPhieuMuon_Sach_MaSach",
                table: "ChiTietPhieuMuon",
                column: "MaSach",
                principalTable: "Sach",
                principalColumn: "MaSach",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PhieuMuon_ThanhVien_MaThanhVien",
                table: "PhieuMuon",
                column: "MaThanhVien",
                principalTable: "ThanhVien",
                principalColumn: "MaThanhVien",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PhieuThu_ThanhVien_MaThanhVien",
                table: "PhieuThu",
                column: "MaThanhVien",
                principalTable: "ThanhVien",
                principalColumn: "MaThanhVien",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sach_TheLoai_MaTheLoai",
                table: "Sach",
                column: "MaTheLoai",
                principalTable: "TheLoai",
                principalColumn: "MaTheLoai",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ThanhVien_GoiThanhVien_MaGoi",
                table: "ThanhVien",
                column: "MaGoi",
                principalTable: "GoiThanhVien",
                principalColumn: "MaGoi",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
