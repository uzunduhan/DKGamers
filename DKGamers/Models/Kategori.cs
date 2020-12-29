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
        public string KategoriAdi { get; set; }
        public string OyunTuru { get; set; }
        public List<OyunKategorisi> OyunKategorileri { get; set; }
    }
}