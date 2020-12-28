using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DKGamers.Models
{
    public class OyunKategorisi
    {
        public int OyunID { get; set; }
        public Oyun Oyunlar { get; set; }

        public int KategoriID { get; set; }
        public Kategori Kategoriler { get; set; }
    }
}