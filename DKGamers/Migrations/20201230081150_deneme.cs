using Microsoft.EntityFrameworkCore.Migrations;

namespace DKGamers.Migrations
{
    public partial class deneme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OyunKategorisi");

            migrationBuilder.AddColumn<int>(
                name: "KategoriID1",
                table: "Kategori",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OyunID",
                table: "Kategori",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Kategori_KategoriID1",
                table: "Kategori",
                column: "KategoriID1");

            migrationBuilder.CreateIndex(
                name: "IX_Kategori_OyunID",
                table: "Kategori",
                column: "OyunID");

            migrationBuilder.AddForeignKey(
                name: "FK_Kategori_Kategori_KategoriID1",
                table: "Kategori",
                column: "KategoriID1",
                principalTable: "Kategori",
                principalColumn: "KategoriID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Kategori_Oyun_OyunID",
                table: "Kategori",
                column: "OyunID",
                principalTable: "Oyun",
                principalColumn: "OyunID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kategori_Kategori_KategoriID1",
                table: "Kategori");

            migrationBuilder.DropForeignKey(
                name: "FK_Kategori_Oyun_OyunID",
                table: "Kategori");

            migrationBuilder.DropIndex(
                name: "IX_Kategori_KategoriID1",
                table: "Kategori");

            migrationBuilder.DropIndex(
                name: "IX_Kategori_OyunID",
                table: "Kategori");

            migrationBuilder.DropColumn(
                name: "KategoriID1",
                table: "Kategori");

            migrationBuilder.DropColumn(
                name: "OyunID",
                table: "Kategori");

            migrationBuilder.CreateTable(
                name: "OyunKategorisi",
                columns: table => new
                {
                    OyunID = table.Column<int>(type: "int", nullable: false),
                    KategoriID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OyunKategorisi", x => new { x.OyunID, x.KategoriID });
                    table.ForeignKey(
                        name: "FK_OyunKategorisi_Kategori_KategoriID",
                        column: x => x.KategoriID,
                        principalTable: "Kategori",
                        principalColumn: "KategoriID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OyunKategorisi_Oyun_OyunID",
                        column: x => x.OyunID,
                        principalTable: "Oyun",
                        principalColumn: "OyunID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "OyunKategorisi",
                columns: new[] { "KategoriID", "OyunID" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 10, 23 },
                    { 9, 23 },
                    { 4, 23 },
                    { 3, 23 },
                    { 2, 23 },
                    { 1, 23 },
                    { 6, 22 },
                    { 5, 22 },
                    { 2, 22 },
                    { 1, 22 },
                    { 10, 21 },
                    { 9, 21 },
                    { 6, 21 },
                    { 5, 21 },
                    { 6, 20 },
                    { 5, 20 },
                    { 6, 19 },
                    { 5, 19 },
                    { 2, 19 },
                    { 1, 19 },
                    { 10, 18 },
                    { 9, 18 },
                    { 6, 18 },
                    { 11, 23 },
                    { 12, 23 },
                    { 1, 24 },
                    { 3, 24 },
                    { 6, 30 },
                    { 5, 30 },
                    { 12, 29 },
                    { 10, 29 },
                    { 8, 29 },
                    { 2, 29 },
                    { 12, 28 },
                    { 11, 28 },
                    { 4, 28 },
                    { 3, 28 },
                    { 2, 28 },
                    { 5, 18 },
                    { 1, 28 },
                    { 11, 27 }
                });

            migrationBuilder.InsertData(
                table: "OyunKategorisi",
                columns: new[] { "KategoriID", "OyunID" },
                values: new object[,]
                {
                    { 10, 27 },
                    { 9, 27 },
                    { 4, 27 },
                    { 3, 27 },
                    { 4, 26 },
                    { 2, 26 },
                    { 11, 25 },
                    { 3, 25 },
                    { 1, 25 },
                    { 11, 24 },
                    { 12, 27 },
                    { 10, 17 },
                    { 9, 17 },
                    { 6, 17 },
                    { 10, 8 },
                    { 9, 8 },
                    { 8, 8 },
                    { 7, 8 },
                    { 2, 8 },
                    { 1, 8 },
                    { 10, 7 },
                    { 9, 7 },
                    { 8, 7 },
                    { 7, 7 },
                    { 2, 7 },
                    { 5, 9 },
                    { 1, 7 },
                    { 2, 5 },
                    { 1, 5 },
                    { 11, 4 },
                    { 3, 4 },
                    { 1, 4 },
                    { 8, 3 },
                    { 7, 3 },
                    { 2, 3 },
                    { 1, 3 },
                    { 2, 2 },
                    { 1, 2 },
                    { 1, 6 },
                    { 9, 30 },
                    { 6, 9 },
                    { 8, 9 }
                });

            migrationBuilder.InsertData(
                table: "OyunKategorisi",
                columns: new[] { "KategoriID", "OyunID" },
                values: new object[,]
                {
                    { 5, 17 },
                    { 10, 16 },
                    { 9, 16 },
                    { 6, 16 },
                    { 5, 16 },
                    { 10, 15 },
                    { 9, 15 },
                    { 8, 15 },
                    { 7, 15 },
                    { 6, 15 },
                    { 5, 15 },
                    { 7, 9 },
                    { 9, 14 },
                    { 7, 13 },
                    { 8, 12 },
                    { 4, 12 },
                    { 10, 11 },
                    { 9, 11 },
                    { 8, 11 },
                    { 7, 11 },
                    { 9, 10 },
                    { 7, 10 },
                    { 10, 9 },
                    { 9, 9 },
                    { 9, 13 },
                    { 10, 30 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OyunKategorisi_KategoriID",
                table: "OyunKategorisi",
                column: "KategoriID");
        }
    }
}
