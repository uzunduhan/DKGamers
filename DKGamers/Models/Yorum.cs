using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using DKGamers.Identity;

namespace DKGamers.Models
{
    public class Yorum
    {
        [Key]
        public int YorumID { get; set; }
        [StringLength(100, MinimumLength = 10, ErrorMessage = "Yapacağınız yorum en az 10, en fazla 100 karakter olmalıdır")]
        public string YapilanYorum { get; set; }
        [StringLength(100, MinimumLength = 10, ErrorMessage = "Yapacağınız yorum en az 10, en fazla 100 karakter olmalıdır")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime OlusturulmaTarihi { get; set; }
        public int OyunID { get; set; }
        public Oyun Oyun { get; set; }
        public string KullaniciAdi { get; set; }
    }
}