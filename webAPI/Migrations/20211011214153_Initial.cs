using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace webAPI.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hocalar",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    persNo = table.Column<int>(type: "int", nullable: false),
                    ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    soyad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hocalar", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Ogrenciler",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ogrNo = table.Column<int>(type: "int", nullable: false),
                    ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    soyad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogrenciler", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Dersler",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dersKodu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    kontenjan = table.Column<int>(type: "int", nullable: false),
                    dHocaid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dersler", x => x.id);
                    table.ForeignKey(
                        name: "FK_Dersler_Hocalar_dHocaid",
                        column: x => x.dHocaid,
                        principalTable: "Hocalar",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DersOgrenci",
                columns: table => new
                {
                    aldigiDerslerid = table.Column<int>(type: "int", nullable: false),
                    dOgrencilerid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DersOgrenci", x => new { x.aldigiDerslerid, x.dOgrencilerid });
                    table.ForeignKey(
                        name: "FK_DersOgrenci_Dersler_aldigiDerslerid",
                        column: x => x.aldigiDerslerid,
                        principalTable: "Dersler",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DersOgrenci_Ogrenciler_dOgrencilerid",
                        column: x => x.dOgrencilerid,
                        principalTable: "Ogrenciler",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dersler_dHocaid",
                table: "Dersler",
                column: "dHocaid");

            migrationBuilder.CreateIndex(
                name: "IX_DersOgrenci_dOgrencilerid",
                table: "DersOgrenci",
                column: "dOgrencilerid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DersOgrenci");

            migrationBuilder.DropTable(
                name: "Dersler");

            migrationBuilder.DropTable(
                name: "Ogrenciler");

            migrationBuilder.DropTable(
                name: "Hocalar");
        }
    }
}
