using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiCore.Migrations
{
    /// <inheritdoc />
    public partial class update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DonHang",
                columns: table => new
                {
                    MaDonHang = table.Column<Guid>(type: "uuid", nullable: false),
                    NgayDatHang = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValue: new DateTime(2023, 7, 22, 17, 43, 56, 717, DateTimeKind.Utc).AddTicks(1106)),
                    NgayGiao = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    TinhTrangDonHang = table.Column<int>(type: "integer", nullable: false),
                    NguoiNhan = table.Column<string>(type: "text", nullable: true),
                    DiaChi = table.Column<string>(type: "text", nullable: true),
                    SoDienThoai = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonHang", x => x.MaDonHang);
                });

            migrationBuilder.CreateTable(
                name: "DonHangChiTiet",
                columns: table => new
                {
                    MaHangHoa = table.Column<Guid>(type: "uuid", nullable: false),
                    MaDonHang = table.Column<Guid>(type: "uuid", nullable: false),
                    SoLuong = table.Column<int>(type: "integer", nullable: false),
                    DonGia = table.Column<double>(type: "double precision", nullable: false),
                    GiamGia = table.Column<byte>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonHangChiTiet", x => new { x.MaDonHang, x.MaHangHoa });
                    table.ForeignKey(
                        name: "FK_DonHangCT_DonHang",
                        column: x => x.MaDonHang,
                        principalTable: "DonHang",
                        principalColumn: "MaDonHang",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DonHangCT_HangHoa",
                        column: x => x.MaHangHoa,
                        principalTable: "HangHoa",
                        principalColumn: "MaHangHoa",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DonHangChiTiet_MaHangHoa",
                table: "DonHangChiTiet",
                column: "MaHangHoa");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DonHangChiTiet");

            migrationBuilder.DropTable(
                name: "DonHang");
        }
    }
}
