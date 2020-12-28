using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DKGamers.Models
{
    public class Oyun
    {
        [Key]
        public int OyunID { get; set; }
        public string Resim { get; set; }
        public string OyunAdi { get; set; }
        public string Aciklama { get; set; }

        //public string Yorum { get; set; }
        public int BegenilmeSayisi { get; set; }
        public ICollection <Kategori> Kategori { get; set; }
    }
}
