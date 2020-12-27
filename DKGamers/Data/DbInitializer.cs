using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DKGamers.Models;

namespace DKGamers.Data
{
    public static class DbInitializer
    {
     
            public static void Seed(this ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Haber>().HasData(
                    new Haber() { HaberID = 1, HaberBaslik = "Steam, 2020'nin En Çok Satan Oyunlarını Açıkladı", HaberResim = "haber1.png", HaberIcerik = "Dünyanın en büyük dijital oyun mağazası olan Steam, 2020'nin en iyileri listesini yayınladı"+
                                                                                                                                                       "Listeye göre brüt gelirler ölçülen 2020'nin en çok satan 12 Steam oyunu;\n– Dota 2,\n– Grand Theft Auto V,\n– Red Dead Redemption 2,\n– Cyberpunk 2077,\n– Playerunknown’s Battlegrounds,\n– Doom Eternal,\n– Monster Hunter World,\n– " +
                                                                                                                                                       "Rainbow Six: Siege,\n– Destiny 2,\n– Fall Guys: Ultimate Knockout,\n– Counter - Strike: Global Offensive ve\n– Among Us oldu."}
                    //new Haber() { CategoryId = 2, Name = "Eldivenler", ImageUrl = "eldiven.jpg" },
                    //new Haber() { CategoryId = 3, Name = "Dezenfektanlar", ImageUrl = "dezenfektan.jpg" },
                    //new Haber() { CategoryId = 4, Name = "Siperlikler", ImageUrl = "siperlik.jpg" }
            );
       

            }
        }
    }


