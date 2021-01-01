using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DKGamers.Migrations.Identity
{
    public partial class ekle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kategori",
                columns: table => new
                {
                    KategoriID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategoriAdi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategori", x => x.KategoriID);
                });

            migrationBuilder.CreateTable(
                name: "Oyun",
                columns: table => new
                {
                    OyunID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Resim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OyunAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PiyasayaSurulmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Yayinci = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gelistirici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BegenilmeSayisi = table.Column<int>(type: "int", nullable: false),
                    GoruntulenmeSayisi = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oyun", x => x.OyunID);
                });

            migrationBuilder.CreateTable(
                name: "OyunKategorisi",
                columns: table => new
                {
                    OyunID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OyunID1 = table.Column<int>(type: "int", nullable: false),
                    KategoriID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OyunKategorisi", x => x.OyunID);
                    table.ForeignKey(
                        name: "FK_OyunKategorisi_Kategori_KategoriID",
                        column: x => x.KategoriID,
                        principalTable: "Kategori",
                        principalColumn: "KategoriID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OyunKategorisi_Oyun_OyunID1",
                        column: x => x.OyunID1,
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
                    KullaniciAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KullaniciId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yorum", x => x.YorumID);
                    table.ForeignKey(
                        name: "FK_Yorum_AspNetUsers_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Yorum_Oyun_OyunID",
                        column: x => x.OyunID,
                        principalTable: "Oyun",
                        principalColumn: "OyunID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OyunKategorisi_KategoriID",
                table: "OyunKategorisi",
                column: "KategoriID");

            migrationBuilder.CreateIndex(
                name: "IX_OyunKategorisi_OyunID1",
                table: "OyunKategorisi",
                column: "OyunID1");

            migrationBuilder.CreateIndex(
                name: "IX_Yorum_KullaniciId",
                table: "Yorum",
                column: "KullaniciId");

            migrationBuilder.CreateIndex(
                name: "IX_Yorum_OyunID",
                table: "Yorum",
                column: "OyunID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OyunKategorisi");

            migrationBuilder.DropTable(
                name: "Yorum");

            migrationBuilder.DropTable(
                name: "Kategori");

            migrationBuilder.DropTable(
                name: "Oyun");
        }
    }
}
