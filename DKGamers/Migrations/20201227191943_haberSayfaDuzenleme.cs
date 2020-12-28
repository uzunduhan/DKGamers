using Microsoft.EntityFrameworkCore.Migrations;

namespace DKGamers.Migrations
{
    public partial class haberSayfaDuzenleme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Haber",
                keyColumn: "HaberID",
                keyValue: 1,
                column: "HaberIcerik",
                value: "Dünyanın en büyük dijital oyun mağazası olan Steam, 2020'nin en iyileri listesini yayınladıListeye göre brüt gelirler ölçülen 2020'nin en çok satan 12 Steam oyunu;<br/>– Dota 2,<br/>– Grand Theft Auto V,<br/>– Red Dead Redemption 2,<br/>– Cyberpunk 2077,<br/>– Playerunknown’s Battlegrounds,<br/>– Doom Eternal,<br/>– Monster Hunter World,<br/>– Rainbow Six: Siege,<br/>– Destiny 2,<br/>– Fall Guys: Ultimate Knockout,<br/>– Counter - Strike: Global Offensive ve<br/>– Among Us oldu.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Haber",
                keyColumn: "HaberID",
                keyValue: 1,
                column: "HaberIcerik",
                value: "Dünyanın en büyük dijital oyun mağazası olan Steam, 2020'nin en iyileri listesini yayınladıListeye göre brüt gelirler ölçülen 2020'nin en çok satan 12 Steam oyunu;\n– Dota 2,\n– Grand Theft Auto V,\n– Red Dead Redemption 2,\n– Cyberpunk 2077,\n– Playerunknown’s Battlegrounds,\n– Doom Eternal,\n– Monster Hunter World,\n– Rainbow Six: Siege,\n– Destiny 2,\n– Fall Guys: Ultimate Knockout,\n– Counter - Strike: Global Offensive ve\n– Among Us oldu.");
        }
    }
}
