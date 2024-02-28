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
	public class MusteriMap :EntityTypeConfiguration<Musteri>
	{
		public MusteriMap()
		{
			this.HasKey(q => q.ID);
			this.Property(q => q.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
			this.Property(q => q.Adi).HasMaxLength(50);
			this.Property(q => q.TcNo).HasMaxLength(11);
			this.Property(q => q.Adres).HasMaxLength(300);
			this.Property(q => q.Tel).HasMaxLength(11);
			this.Property(q => q.Mail).HasMaxLength(50);

			this.ToTable("Musteriler");
			this.Property(q => q.ID).HasColumnName("MusteriID");
			this.Property(q => q.Adi).HasColumnName("Adi");
			this.Property(q => q.TcNo).HasColumnName("TcNo");
			this.Property(q => q.Adres).HasColumnName("Adres");
			this.Property(q => q.Tel).HasColumnName("Tel");
			this.Property(q => q.Mail).HasColumnName("Mail");
			this.Property(q => q.Kullanimdami).HasColumnName("Kullanimdami");
			
		}
	}
}
