using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DKGamers.Models;

namespace DKGamers.Identity
{
    public class Kullanici : IdentityUser
    {
        public IList<Yorum> Yorumlar { get; set; }
    }
}