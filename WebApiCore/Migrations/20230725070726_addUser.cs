using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace WebApiCore.Migrations
{
    /// <inheritdoc />
    public partial class addUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayDatHang",
                table: "DonHang",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 25, 7, 7, 25, 947, DateTimeKind.Utc).AddTicks(8834),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 7, 22, 17, 43, 56, 717, DateTimeKind.Utc).AddTicks(1106));

            migrationBuilder.CreateTable(
                name: "NguoiDung",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    PassWord = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: true),
                    HoTen = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NguoiDung", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_NguoiDung_UserName",
                table: "NguoiDung",
                column: "UserName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NguoiDung");

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayDatHang",
                table: "DonHang",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 22, 17, 43, 56, 717, DateTimeKind.Utc).AddTicks(1106),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 7, 25, 7, 7, 25, 947, DateTimeKind.Utc).AddTicks(8834));
        }
    }
}
