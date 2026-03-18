using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyThuVien.Migrations
{
    /// <inheritdoc />
    public partial class Sua : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietPhieuMuons_PhieuMuons_PhieuMuonID",
                table: "ChiTietPhieuMuons");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietPhieuMuons_Sachs_MaSach",
                table: "ChiTietPhieuMuons");

            migrationBuilder.DropForeignKey(
                name: "FK_PhieuMuons_ThanhViens_MaThanhVien",
                table: "PhieuMuons");

            migrationBuilder.DropForeignKey(
                name: "FK_PhieuThus_ThanhViens_MaThanhVien",
                table: "PhieuThus");

            migrationBuilder.DropForeignKey(
                name: "FK_Sachs_TheLoais_MaTheLoai",
                table: "Sachs");

            migrationBuilder.DropForeignKey(
                name: "FK_ThanhViens_GoiThanhViens_MaGoi",
                table: "ThanhViens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TheLoais",
                table: "TheLoais");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ThanhViens",
                table: "ThanhViens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sachs",
                table: "Sachs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PhieuThus",
                table: "PhieuThus");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PhieuMuons",
                table: "PhieuMuons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GoiThanhViens",
                table: "GoiThanhViens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChiTietPhieuMuons",
                table: "ChiTietPhieuMuons");

            migrationBuilder.RenameTable(
                name: "TheLoais",
                newName: "TheLoai");

            migrationBuilder.RenameTable(
                name: "ThanhViens",
                newName: "ThanhVien");

            migrationBuilder.RenameTable(
                name: "Sachs",
                newName: "Sach");

            migrationBuilder.RenameTable(
                name: "PhieuThus",
                newName: "PhieuThu");

            migrationBuilder.RenameTable(
                name: "PhieuMuons",
                newName: "PhieuMuon");

            migrationBuilder.RenameTable(
                name: "GoiThanhViens",
                newName: "GoiThanhVien");

            migrationBuilder.RenameTable(
                name: "ChiTietPhieuMuons",
                newName: "ChiTietPhieuMuon");

            migrationBuilder.RenameIndex(
                name: "IX_ThanhViens_MaGoi",
                table: "ThanhVien",
                newName: "IX_ThanhVien_MaGoi");

            migrationBuilder.RenameIndex(
                name: "IX_Sachs_MaTheLoai",
                table: "Sach",
                newName: "IX_Sach_MaTheLoai");

            migrationBuilder.RenameIndex(
                name: "IX_PhieuThus_MaThanhVien",
                table: "PhieuThu",
                newName: "IX_PhieuThu_MaThanhVien");

            migrationBuilder.RenameIndex(
                name: "IX_PhieuMuons_MaThanhVien",
                table: "PhieuMuon",
                newName: "IX_PhieuMuon_MaThanhVien");

            migrationBuilder.RenameIndex(
                name: "IX_ChiTietPhieuMuons_PhieuMuonID",
                table: "ChiTietPhieuMuon",
                newName: "IX_ChiTietPhieuMuon_PhieuMuonID");

            migrationBuilder.RenameIndex(
                name: "IX_ChiTietPhieuMuons_MaSach",
                table: "ChiTietPhieuMuon",
                newName: "IX_ChiTietPhieuMuon_MaSach");

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
                name: "PK_PhieuThu",
                table: "PhieuThu",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PhieuMuon",
                table: "PhieuMuon",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GoiThanhVien",
                table: "GoiThanhVien",
                column: "MaGoi");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChiTietPhieuMuon",
                table: "ChiTietPhieuMuon",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietPhieuMuon_PhieuMuon_PhieuMuonID",
                table: "ChiTietPhieuMuon",
                column: "PhieuMuonID",
                principalTable: "PhieuMuon",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietPhieuMuon_PhieuMuon_PhieuMuonID",
                table: "ChiTietPhieuMuon");

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

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sach",
                table: "Sach");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PhieuThu",
                table: "PhieuThu");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PhieuMuon",
                table: "PhieuMuon");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GoiThanhVien",
                table: "GoiThanhVien");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChiTietPhieuMuon",
                table: "ChiTietPhieuMuon");

            migrationBuilder.RenameTable(
                name: "TheLoai",
                newName: "TheLoais");

            migrationBuilder.RenameTable(
                name: "ThanhVien",
                newName: "ThanhViens");

            migrationBuilder.RenameTable(
                name: "Sach",
                newName: "Sachs");

            migrationBuilder.RenameTable(
                name: "PhieuThu",
                newName: "PhieuThus");

            migrationBuilder.RenameTable(
                name: "PhieuMuon",
                newName: "PhieuMuons");

            migrationBuilder.RenameTable(
                name: "GoiThanhVien",
                newName: "GoiThanhViens");

            migrationBuilder.RenameTable(
                name: "ChiTietPhieuMuon",
                newName: "ChiTietPhieuMuons");

            migrationBuilder.RenameIndex(
                name: "IX_ThanhVien_MaGoi",
                table: "ThanhViens",
                newName: "IX_ThanhViens_MaGoi");

            migrationBuilder.RenameIndex(
                name: "IX_Sach_MaTheLoai",
                table: "Sachs",
                newName: "IX_Sachs_MaTheLoai");

            migrationBuilder.RenameIndex(
                name: "IX_PhieuThu_MaThanhVien",
                table: "PhieuThus",
                newName: "IX_PhieuThus_MaThanhVien");

            migrationBuilder.RenameIndex(
                name: "IX_PhieuMuon_MaThanhVien",
                table: "PhieuMuons",
                newName: "IX_PhieuMuons_MaThanhVien");

            migrationBuilder.RenameIndex(
                name: "IX_ChiTietPhieuMuon_PhieuMuonID",
                table: "ChiTietPhieuMuons",
                newName: "IX_ChiTietPhieuMuons_PhieuMuonID");

            migrationBuilder.RenameIndex(
                name: "IX_ChiTietPhieuMuon_MaSach",
                table: "ChiTietPhieuMuons",
                newName: "IX_ChiTietPhieuMuons_MaSach");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TheLoais",
                table: "TheLoais",
                column: "MaTheLoai");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ThanhViens",
                table: "ThanhViens",
                column: "MaThanhVien");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sachs",
                table: "Sachs",
                column: "MaSach");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PhieuThus",
                table: "PhieuThus",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PhieuMuons",
                table: "PhieuMuons",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GoiThanhViens",
                table: "GoiThanhViens",
                column: "MaGoi");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChiTietPhieuMuons",
                table: "ChiTietPhieuMuons",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietPhieuMuons_PhieuMuons_PhieuMuonID",
                table: "ChiTietPhieuMuons",
                column: "PhieuMuonID",
                principalTable: "PhieuMuons",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietPhieuMuons_Sachs_MaSach",
                table: "ChiTietPhieuMuons",
                column: "MaSach",
                principalTable: "Sachs",
                principalColumn: "MaSach",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PhieuMuons_ThanhViens_MaThanhVien",
                table: "PhieuMuons",
                column: "MaThanhVien",
                principalTable: "ThanhViens",
                principalColumn: "MaThanhVien",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PhieuThus_ThanhViens_MaThanhVien",
                table: "PhieuThus",
                column: "MaThanhVien",
                principalTable: "ThanhViens",
                principalColumn: "MaThanhVien",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sachs_TheLoais_MaTheLoai",
                table: "Sachs",
                column: "MaTheLoai",
                principalTable: "TheLoais",
                principalColumn: "MaTheLoai",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ThanhViens_GoiThanhViens_MaGoi",
                table: "ThanhViens",
                column: "MaGoi",
                principalTable: "GoiThanhViens",
                principalColumn: "MaGoi",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
