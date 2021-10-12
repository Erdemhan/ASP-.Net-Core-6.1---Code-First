using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webAPI.Models;


namespace webAPI
{
    public class DBContext : DbContext
    {
        DbSet<Ogrenci> Ogrenciler { get; set; }
        DbSet<OgretimUyesi> Hocalar { get; set; }
        DbSet<Ders> Dersler { get; set; }

        public DBContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ders>()
                .HasMany(d => d.dOgrenciler)
                .WithMany(o => o.aldigiDersler);
            modelBuilder.Entity<Ders>()
                .HasOne(d => d.dHoca)
                .WithMany(h => h.verdigiDersler);

        }

    }
}
