using OtoTamirTakip.Entities;
using OtoTamirTakip.Mapping;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoTamirTakip.Context
{
	public class OtoTamirTakipContext : DbContext
	{
		public OtoTamirTakipContext():base("OtoTamirTakipContext")
		{

		}
		public DbSet<IsEmri> IsEmirleri { get; set; }
		public DbSet<Ayarlar> Ayarlar { get; set; }
		public DbSet<IsEmirDetay> IsEmriDetaylari { get; set; }
		public DbSet<Musteri> Musteriler { get; set; }
		public DbSet<Arac> Araclar { get; set; }
		public DbSet<Kullanici> Kullanicilar { get; set; }
		public DbSet<BeniHatirlaKullanicisi> BeniHatirlaKullanicilari { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{

			modelBuilder.Entity<IsEmri>().HasMany(q => q.IsEmirDetaylari).WithRequired(q => q.IsEmri).HasForeignKey(q => q.IsEmirID);
			modelBuilder.Entity<Arac>().HasMany(q => q.IsEmirleri).WithRequired(q => q.Arac).HasForeignKey(q => q.AracID);
			modelBuilder.Entity<Musteri>().HasMany(q => q.MusteriAraclari).WithRequired(q => q.Musteri).HasForeignKey(q => q.MusteriID);

			modelBuilder.Configurations.Add(new IsEmriMap());
			modelBuilder.Configurations.Add(new IsEmriDetayMap());
			modelBuilder.Configurations.Add(new AyarlarMap());
			modelBuilder.Configurations.Add(new MusteriMap());
			modelBuilder.Configurations.Add(new AracMap());
			modelBuilder.Configurations.Add(new KullaniciMap());
			modelBuilder.Configurations.Add(new BeniHatirlaKullanicisiMap());

		}
		
	}
}
