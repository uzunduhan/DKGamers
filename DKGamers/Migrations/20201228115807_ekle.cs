﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace DKGamers.Migrations
{
    public partial class ekle : Migration
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

            migrationBuilder.CreateTable(
                name: "Kategori",
                columns: table => new
                {
                    KategoriID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OyunKategori = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OyunTuru = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BegenilmeSayisi = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oyun", x => x.OyunID);
                });

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
                table: "Haber",
                columns: new[] { "HaberID", "HaberBaslik", "HaberIcerik", "HaberResim" },
                values: new object[,]
                {
                    { 5, "Steam, 2020'nin En Çok Satan Oyunlarını Açıkladı", "Dünyanın en büyük dijital oyun mağazası olan Steam, 2020'nin en iyileri listesini yayınladı.Listeye göre brüt gelirler ölçülen 2020'nin en çok satan 12 Steam oyunu;– Dota 2,- Grand Theft Auto V,– Red Dead Redemption 2,– Cyberpunk 2077,– Playerunknown’s Battlegrounds,– Doom Eternal,– Monster Hunter World,– Rainbow Six: Siege,– Destiny 2,– Fall Guys: Ultimate Knockout,– Counter - Strike: Global Offensive ve – Among Us oldu.", "haber5.png" },
                    { 4, "CD PROJEKT RED'e Cyberpunk 2077 Yüzünden İlk Dava Açıldı", "Video oyun sektörünün son dönemlerdeki en çok tartışılan ismi, CD PROJEKT RED. Bunun nedeniyse, kısa bir süre önce piyasaya sürülen Cyberpunk 2077. Oyunda yaşanan sorunlar, şirketin oldukça ağır bir şekilde eleştirilmesine yol açtı. Ancak şirket, sadece eleştirileri yutmak zorunda kalmayacak. Çünkü Rosen Law isimli bir şirket, CD PROJEKT RED'den davacı oldu.Rosen Law isimli hukuk şirketi tarafından açılan davaya göre CD PROJEKT RED,   Cyberpunk 2077'yi piyasaya sürmeden önce, oyuncuları ve yatırımcıları yanlış yönlendirdi. Şirket aslında, oyunun ne halde olduğunu biliyordu ancak bunu gizledi. Bu sayede de Cyberpunk 2077'nin hype'lanmaya devam etmesine neden olan CD PROJEKT RED, bir nevi haksız kazanç elde etmiş oldu.Rosen Law tarafından açılan davanın şu an için bilindik bir katılımcısı yok.Ancak şirket,özellikle de yatırımcıların bu davaya dahil olmaları gerektiğini,hisse senedi değerlerinin ortada olduğunu ifade ediyor.Ayrıca dileyen oyuncuların da davaya dahil olabileceğini söyleyen hukuk şirketi,davaya dahil olmak isteyenlere de bir çevrimiçi form sunuyor.Yaşanan olay,CD PROJEKT RED için bir ilk niteliğinde.Ancak bu durum, son olmayabilir.Çünkü geliştirici şirketin ana vatanı olan Polonya'da da yatırımcılar, şirkete karşı yaptırım planları üzerinde yoğunlaşmış durumdalar. Tüm bu olayların nasıl sonuçlanacağı bilinmiyor ancak CD PROJEKT RED'i oldukça zorlu günlerin beklediğini şimdiden söyleyebiliriz.", "haber4.jpg" },
                    { 3, "The Forest'ın Devam Oyunu Sons Of The Forest İçin Yeni Fragman Yayınlandı", "Macera türündeki Sons Of The Forest oyunu için dikkat çekici yeni bir oynanış videosu daha yayınlandı. Hatırı sayılır bir hayran kitlesine sahip olan The Forest oyununun devamı niteliğinde karşımıza çıkacak olan Sons Of The Forest, hem görsel yöndeki gelişimi hem de oynanış dinamikleri ile türü seven oyuncuları yine memnun edeceğe benziyor.Endnight Games ekibi tarafından geliştirilen Sons Of The Forest, 2021 yılında çıkacak.Net bir çıkış tarihi belli olmayan oyun Unity grafik motoru kullanılarak geliştiriliyor.Görsel olarak oldukça hoş gözüken oyunun yapım ekibi hem işleme hem de ışıklandırma gibi noktalarda önemli geliştirmeler yapıldığını belirtmiş.Bu sayede oyunun değişken hava şartlarının çok daha iyi gözükeceği gelen bilgiler arasında.Zaten yayınlanan oynanış videosuna baktığımızda da karlı alanların ve değişen hava şartlarının gerçekten de güzel gözüktüğünü fark ediyoruz.İlk oyunda olduğu gibi inşa etme dinamiklerinin oldukça önemli olduğu Sons Of The Forest oyununda yeni inşa seçenekleri ve düşman çeşitleri de bulunacak.Oyunda yakın dövüş dinamiklerine daha fazla ağırlık verilecek.", "haber3.jpg" },
                    { 2, "Steam'de Anlık Oyuncu Sayısında Rekor Kırıldı", "Koronavirüsün de etkisiyle hafta sonunu evde geçiren milyonlarca oyun sever, Steam’e akın etti. Ünlü oyun platformunda 24 milyon 804 bin 148 kullanıcı aynı anda aktif oldu. 25 milyona yakın kullanıcının Steam’de aktif olmasında en büyük etkenlerinden biri, uygulamanın bilgisayar açılınca otomatik aktif olması. Ancak Steam, anlık oyuncu sayısında da 7 milyonu görerek kendi rekorunu bir kez daha kırdı.25 milyon kullanıcı içinde Steam’de oyun oynayan 7 milyon kişinin oynadıkları oyunların başında Counter - Strike: Global Offensive(1.062.017 kullanıcı), Cyberpunk 2077(1.047.602 kullanıcı) ve Playerunknown’s Battlegrounds(648.889 kullanıcı) bulunuyor.Tek oyunculu bir oyun olmasına rağmen neredeyse CS:GO ile aynı oyuncu sayısına erişen Cyberpunk 2077 ise anlık olarak 654.963 oyuncu sayısına ulaştı.Steam’in bundan önceki rekoru koronavirüsün dünya çapında yayılmaya başladığı aylarda gelmişti.Mart 2020‘de 22 milyon anlık kullanıcıya erişen Steam, üst üste 3 defa rekor kırmıştı.", "haber2.jpg" },
                    { 1, "The Game Awards 2020 Kazananları Açıklandı", "Dünyanın en büyük video oyun ödül organizasyonlarından bir tanesi olan The Game Awards 2020 etkinlikleri, Türkiye saati ile gece 03:00 sularında gerçekleşti. 2020'nin en'lerinin seçildiği seçildiği etkinlikler kapsamında da herkesin tahmin edebileceği bazı oyunlar, çeşitli ödüllere layık görüldü.İşte The Game Awards 2020'nin tüm kazananları:Yılın Oyunu: The Last of Us: Part II Oyuncunun Sesi: Ghost of Tsushima En İyi Oyun Yönetmenliği: The Last of Us: Part II En İyi Anlatı: The Last of Us: Part II En İyi Sanat Yönetmenliği: Ghost of Tsushima En İyi Ses Tasarımı: The Last of Us: Part II En İyi Müzik: Final Fantasy VII RemakeKarakterler Bazında En İyi Performans: The Last of Us: Part II En Çok Etkileyen Oyun: Tell Me Why Devam Etmekte Olan En İyi Oyun: No Man's Sky En İyi Indie Oyun: Hades En İyi Mobil Oyun: Among Us En İyi Topluluk Desteği Veren Oyun: Fall Guys: Ultimate Knockout En İyi Sanal Gerçeklik / Artırılmış Gerçeklik Oyunu: Half - Life: Alyx En İyi Erişilebilirlikte Yenilik Oyunu: The Last of Us: Part II En İyi Aksiyon Oyunu: Hades En İyi Aksiyon/Macera Oyunu: The Last of Us: Part II En İyi RPG Oyunu: Final Fantasy VII Remake En İyi Dövüş Oyunu: Mortal Kombat 11 Ultimate En İyi Aile Oyunu: Animal Crossing: New Horizons En İyi Simülasyon / Strateji Oyunu: Microsoft Flight Simulator En İyi Spor / Yarış Oyunu: Tony Hawk’s Pro Skater 1 + 2 En İyi Çok Oyunculu Oyun: Among Us En Çok Beklenen Oyun: Elden Ring En İyi İçerik Üreticisi: Valkyrae En İyi Çıkış Yapan Oyun: Phasmophobia En İyi E - spor Oyunu: League of Legends En İyi E - spor Takımı: G2 EsportsEn İyi E - spor Etkinliği: League of Legends", "haber1.jpg" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OyunKategorisi_KategoriID",
                table: "OyunKategorisi",
                column: "KategoriID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Haber");

            migrationBuilder.DropTable(
                name: "OyunKategorisi");

            migrationBuilder.DropTable(
                name: "Kategori");

            migrationBuilder.DropTable(
                name: "Oyun");
        }
    }
}
