using finalproje1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace finalproje1
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {
            Database.SetInitializer(new KullaniciOlustur());
        }   

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SiteUser>().ToTable("SiteUsers"); //siteuser tablosu oluştur
            modelBuilder.Entity<ActiveUser>().ToTable("ActiveUsers"); //siteuser tablosu oluştur
            modelBuilder.Entity<PasiveUser>().ToTable("PasiveUsers"); //siteuser tablosu oluştur
        }

        public DbSet<SiteUser> SiteUsers { get; set; } //siteuser tablosunu class ile kullan
        public DbSet<ActiveUser> ActiveUsers { get; set; } //siteuser tablosunu class ile kullan
        public DbSet<PasiveUser> PasiveUsers { get; set; } //siteuser tablosunu class ile kullan

        public System.Data.Entity.DbSet<finalproje1.Models.DeleteUsers> DeleteUsers { get; set; }
    }

}