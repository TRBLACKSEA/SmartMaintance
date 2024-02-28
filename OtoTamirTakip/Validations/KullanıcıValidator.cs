using FluentValidation;
using OtoTamirTakip.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoTamirTakip.Validations
{
	public class KullanıcıValidator : AbstractValidator<Kullanici>
	{
		public KullanıcıValidator()
		{
			RuleFor(q => q.KulaniciAdi).NotEmpty().WithMessage("Kullanıcı Adı Boş Geçilemez");
			RuleFor(q => q.Sifre).NotEmpty().WithMessage("Kullanıcı Şifresi Boş Geçilemez");
		}
	}
}
