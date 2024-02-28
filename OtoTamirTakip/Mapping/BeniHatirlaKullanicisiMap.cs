using OtoTamirTakip.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoTamirTakip.Mapping
{
	public class BeniHatirlaKullanicisiMap : EntityTypeConfiguration<BeniHatirlaKullanicisi>
	{
		public BeniHatirlaKullanicisiMap()
		{
			this.HasKey(q => q.ID);
			this.Property(q => q.ID).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

			this.ToTable("BeniHatirlaKullanicisi");
			this.Property(q => q.ID).HasColumnName("ID");
			this.Property(q => q.KullaniciID).HasColumnName("KullaniciID");
		}
	}
}
