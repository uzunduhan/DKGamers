using Microsoft.EntityFrameworkCore.Migrations;

namespace DKGamers.Migrations
{
    public partial class deneme2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "KategoriOyun",
                columns: table => new
                {
                    KategorilerKategoriID = table.Column<int>(type: "int", nullable: false),
                    OyunlarOyunID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KategoriOyun", x => new { x.KategorilerKategoriID, x.OyunlarOyunID });
                    table.ForeignKey(
                        name: "FK_KategoriOyun_Kategori_KategorilerKategoriID",
                        column: x => x.KategorilerKategoriID,
                        principalTable: "Kategori",
                        principalColumn: "KategoriID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KategoriOyun_Oyun_OyunlarOyunID",
                        column: x => x.OyunlarOyunID,
                        principalTable: "Oyun",
                        principalColumn: "OyunID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_KategoriOyun_OyunlarOyunID",
                table: "KategoriOyun",
                column: "OyunlarOyunID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KategoriOyun");

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
    }
}
