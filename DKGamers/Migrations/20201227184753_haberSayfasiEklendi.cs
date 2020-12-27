using Microsoft.EntityFrameworkCore.Migrations;

namespace DKGamers.Migrations
{
    public partial class haberSayfasiEklendi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Haber",
                columns: table => new
                {
                    HaberID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HaberResim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HaberBaslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HaberIcerik = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Haber", x => x.HaberID);
                });

            migrationBuilder.InsertData(
                table: "Haber",
                columns: new[] { "HaberID", "HaberBaslik", "HaberIcerik", "HaberResim" },
                values: new object[] { 1, "Steam, 2020'nin En Çok Satan Oyunlarını Açıkladı", "Dünyanın en büyük dijital oyun mağazası olan Steam, 2020'nin en iyileri listesini yayınladıListeye göre brüt gelirler ölçülen 2020'nin en çok satan 12 Steam oyunu;\n– Dota 2,\n– Grand Theft Auto V,\n– Red Dead Redemption 2,\n– Cyberpunk 2077,\n– Playerunknown’s Battlegrounds,\n– Doom Eternal,\n– Monster Hunter World,\n– Rainbow Six: Siege,\n– Destiny 2,\n– Fall Guys: Ultimate Knockout,\n– Counter - Strike: Global Offensive ve\n– Among Us oldu.", "haber1.png" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Haber");
        }
    }
}
