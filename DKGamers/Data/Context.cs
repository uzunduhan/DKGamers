
using DKGamers.Data;
using DKGamers.Identity;
using DKGamers.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace DKGamers.Data
{
    public class Context : IdentityDbContext<Kullanici>
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

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
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
            modelBuilder.Entity<OyunKategorisi>().HasKey(ok => new { ok.OyunID, ok.KategoriID });

            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole { Id = "1", Name = "admin", NormalizedName = "ADMIN".ToUpper() });
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole { Id = "2", Name = "user", NormalizedName = "USER".ToUpper() });

            var hasher = new PasswordHasher<Kullanici>();


            modelBuilder.Entity<Kullanici>().HasData(
                new Kullanici
                {
                    Id = "8e117364-e21d-4613-a6d7-9423e041cdb9",
                    UserName = "b181210057@sakarya.edu.tr",
                    Email = "b181210057@sakarya.edu.tr",
                    NormalizedEmail = "b181210057@sakarya.edu.tr".ToUpper(),
                    NormalizedUserName = "b181210057@sakarya.edu.tr".ToUpper(),
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "123")
                }
            );


            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "1",
                    UserId = "8e117364-e21d-4613-a6d7-9423e041cdb9"
                }
            );


            modelBuilder.Entity<Kullanici>().HasData(
                new Kullanici
                {
                    Id = "8e117364-e21d-4713-a6d7-9423d041edb9",
                    UserName = "b181210051@sakarya.edu.tr",
                    Email = "b181210051@sakarya.edu.tr",
                    NormalizedEmail = "b181210051@sakarya.edu.tr".ToUpper(),
                    NormalizedUserName = "b181210051@sakarya.edu.tr".ToUpper(),
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "123")
                }
            );


            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "1",
                    UserId = "8e117364-e21d-4713-a6d7-9423d041edb9"
                }
            );

            modelBuilder.Entity<Kullanici>().HasData(
                new Kullanici
                {
                    Id = "8e117364-e21d-5613-a6d7-9413e041cdb9",
                    UserName = "bayram57",
                    Email = "bayram@outlook.com",
                    NormalizedEmail = "bayram@outlook.com".ToUpper(),
                    NormalizedUserName = "bayram57".ToUpper(),
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "bayram1905")
                }
            );


            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "2",
                    UserId = "8e117364-e21d-5613-a6d7-9413e041cdb9"
                }
            );

            modelBuilder.Entity<Kullanici>().HasData(
                new Kullanici
                {
                    Id = "8e217364-e21d-5613-a6d7-9413e041cdb9",
                    UserName = "batuhan34",
                    Email = "batuhan34@outlook.com",
                    NormalizedEmail = "batuhan34@outlook.com".ToUpper(),
                    NormalizedUserName = "batuhan34".ToUpper(),
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "34batuhan34")
                }
            );


            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "2",
                    UserId = "8e217364-e21d-5613-a6d7-9413e041cdb9"
                }
            );

            modelBuilder.Entity<Kullanici>().HasData(
               new Kullanici
               {
                   Id = "8e317364-e21d-5613-a6d7-9413e041cdb9",
                   UserName = "berk77",
                   Email = "berk77@outlook.com",
                   NormalizedEmail = "berk77@outlook.com".ToUpper(),
                   NormalizedUserName = "berk77".ToUpper(),
                   EmailConfirmed = true,
                   PasswordHash = hasher.HashPassword(null, "77berk77")
               }
           );


            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "2",
                    UserId = "8e317364-e21d-5613-a6d7-9413e041cdb9"
                }
            );
        }
    }
}