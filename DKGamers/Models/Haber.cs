using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DKGamers.Models
{
    public class Haber
    {
        [Key]
        public int HaberID { get; set; }
        public string HaberResim { get; set; }
        public string HaberBaslik { get; set; }
        public string HaberIcerik { get; set; }
        //public int AuthorID { get; set; }
        //public Haber Author { get; set; }
    }
}
