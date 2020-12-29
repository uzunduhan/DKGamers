using Microsoft.EntityFrameworkCore.Migrations;

namespace DKGamers.Migrations
{
    public partial class tabloSatirAdlariDuzenlendiVeOyunaTablosunaEklemeYapildi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OyunKategori",
                table: "Kategori",
                newName: "KategoriAdi");

            migrationBuilder.AddColumn<string>(
                name: "Gelistirici",
                table: "Oyun",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Yayinlayici",
                table: "Oyun",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Haber",
                keyColumn: "HaberID",
                keyValue: 5,
                column: "HaberIcerik",
                value: "Dünyanın en büyük dijital oyun mağazası olan Steam, 2020'nin en iyileri listesini yayınladı.\nListeye göre brüt gelirler ölçülen 2020'nin en çok satan 12 Steam oyunu;– Dota 2,- Grand Theft Auto V,– Red Dead Redemption 2,– Cyberpunk 2077,– Playerunknown’s Battlegrounds,– Doom Eternal,– Monster Hunter World,– Rainbow Six: Siege,– Destiny 2,– Fall Guys: Ultimate Knockout,– Counter - Strike: Global Offensive ve – Among Us oldu.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gelistirici",
                table: "Oyun");

            migrationBuilder.DropColumn(
                name: "Yayinlayici",
                table: "Oyun");

            migrationBuilder.RenameColumn(
                name: "KategoriAdi",
                table: "Kategori",
                newName: "OyunKategori");

            migrationBuilder.UpdateData(
                table: "Haber",
                keyColumn: "HaberID",
                keyValue: 5,
                column: "HaberIcerik",
                value: "Dünyanın en büyük dijital oyun mağazası olan Steam, 2020'nin en iyileri listesini yayınladı.Listeye göre brüt gelirler ölçülen 2020'nin en çok satan 12 Steam oyunu;– Dota 2,- Grand Theft Auto V,– Red Dead Redemption 2,– Cyberpunk 2077,– Playerunknown’s Battlegrounds,– Doom Eternal,– Monster Hunter World,– Rainbow Six: Siege,– Destiny 2,– Fall Guys: Ultimate Knockout,– Counter - Strike: Global Offensive ve – Among Us oldu.");
        }
    }
}
