using DKGamers.Data;
using DKGamers.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace DKGamers.Data
{
    public class Context : DbContext
    {
        public DbSet<Haber> Haber { get; set; }
        public DbSet<Oyun> Oyun { get; set; }
        public DbSet<Kategori> Kategori { get; set; }
        public DbSet<Yorum> Yorum { get; set; }
        public DbSet<Favori> Favori { get; set; }


        public DbSet<OyunKategorisi> OyunKategorisi { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-NJEA2TT\SQLEXPRESS; Database=DKGamersDB; trusted_connection=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
            modelBuilder.Entity<OyunKategorisi>().HasKey(ok => new { ok.OyunID, ok.KategoriID });
        }
    }
}