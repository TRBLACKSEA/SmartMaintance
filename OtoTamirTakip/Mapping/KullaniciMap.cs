using OtoTamirTakip.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoTamirTakip.Mapping
{
	public class KullaniciMap : EntityTypeConfiguration<Kullanici>
	{
		public KullaniciMap()
		{
			this.HasKey(q => q.ID);
			this.Property(q => q.ID).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
			this.Property(q => q.KulaniciAdi).HasMaxLength(50);
			this.Property(q => q.Sifre).HasMaxLength(30);

			this.ToTable("Kullanicilar");
			this.Property(q => q.ID).HasColumnName("ID");
			this.Property(q => q.KulaniciAdi).HasColumnName("KulaniciAdi");
			this.Property(q => q.Sifre).HasColumnName("Sifre");
			this.Property(q => q.isAdmin).HasColumnName("isAdmin");
			this.Property(q => q.Kullanimdami).HasColumnName("Kullanimdami");
		}
	}
}
