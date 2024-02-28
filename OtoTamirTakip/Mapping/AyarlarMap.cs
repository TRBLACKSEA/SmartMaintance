using OtoTamirTakip.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoTamirTakip.Mapping
{
	public class AyarlarMap : EntityTypeConfiguration<Ayarlar>
	{
		public AyarlarMap()
		{
			this.HasKey(q => q.ID);
			this.Property(q => q.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
			this.Property(q => q.Ad).HasMaxLength(100);
			this.Property(q => q.Adres).HasMaxLength(500);
			this.Property(q => q.Telefon).HasMaxLength(11);
			this.Property(q => q.Mail).HasMaxLength(30);

			this.ToTable("Ayarlar");
			this.Property(q => q.ID).HasColumnName("ID");
			this.Property(q => q.Adres).HasColumnName("Adres");
			this.Property(q => q.Telefon).HasColumnName("Telefon");
			this.Property(q => q.Mail).HasColumnName("Mail");
		}
	}
}
