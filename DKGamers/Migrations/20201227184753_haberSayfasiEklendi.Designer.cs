﻿// <auto-generated />
using DKGamers.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DKGamers.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20201227184753_haberSayfasiEklendi")]
    partial class haberSayfasiEklendi
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("DKGamers.Models.Haber", b =>
                {
                    b.Property<int>("HaberID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("HaberBaslik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HaberIcerik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HaberResim")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HaberID");

                    b.ToTable("Haber");

                    b.HasData(
                        new
                        {
                            HaberID = 1,
                            HaberBaslik = "Steam, 2020'nin En Çok Satan Oyunlarını Açıkladı",
                            HaberIcerik = "Dünyanın en büyük dijital oyun mağazası olan Steam, 2020'nin en iyileri listesini yayınladıListeye göre brüt gelirler ölçülen 2020'nin en çok satan 12 Steam oyunu;\n– Dota 2,\n– Grand Theft Auto V,\n– Red Dead Redemption 2,\n– Cyberpunk 2077,\n– Playerunknown’s Battlegrounds,\n– Doom Eternal,\n– Monster Hunter World,\n– Rainbow Six: Siege,\n– Destiny 2,\n– Fall Guys: Ultimate Knockout,\n– Counter - Strike: Global Offensive ve\n– Among Us oldu.",
                            HaberResim = "haber1.png"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}