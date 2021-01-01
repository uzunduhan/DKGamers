using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DKGamers.Migrations
{
    public partial class adminSayfasiEklendiVeDigerSayfalarDuzenlendi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Favori",
                columns: table => new
                {
                    FavoriID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OyunID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favori", x => x.FavoriID);
                    table.ForeignKey(
                        name: "FK_Favori_Oyun_OyunID",
                        column: x => x.OyunID,
                        principalTable: "Oyun",
                        principalColumn: "OyunID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Yorum",
                columns: table => new
                {
                    YorumID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YapilanYorum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OlusturulmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OyunID = table.Column<int>(type: "int", nullable: false),
                    KullaniciAdi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yorum", x => x.YorumID);
                    table.ForeignKey(
                        name: "FK_Yorum_Oyun_OyunID",
                        column: x => x.OyunID,
                        principalTable: "Oyun",
                        principalColumn: "OyunID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Favori_OyunID",
                table: "Favori",
                column: "OyunID");

            migrationBuilder.CreateIndex(
                name: "IX_Yorum_OyunID",
                table: "Yorum",
                column: "OyunID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Favori");

            migrationBuilder.DropTable(
                name: "Yorum");
        }
    }
}
