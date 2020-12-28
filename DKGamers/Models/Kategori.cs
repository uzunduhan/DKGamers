using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DKGamers.Models
{
    public class Kategori
    {
        [Key]
        public int KategoriID { get; set; }
        public string OyunKategori { get; set; }
        public string OyunTuru { get; set; }
        public Oyun Oyun { get; set; }
    }
}
