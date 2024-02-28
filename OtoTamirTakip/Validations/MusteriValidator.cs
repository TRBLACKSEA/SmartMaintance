using FluentValidation;
using OtoTamirTakip.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoTamirTakip.Validations
{
	public class MusteriValidator : AbstractValidator<Musteri>
	{
		public MusteriValidator()
		{
			RuleFor(q => q.Adi).NotEmpty().WithMessage("İsim/Ünvan Boş Geçilemez");
			RuleFor(q => q.TcNo).NotEmpty().WithMessage("Tc No Boş Geçilemez").MaximumLength(11).WithMessage("Tc No 11 Haneden Fazla Olamaz");
			RuleFor(q => q.Tel).MaximumLength(11).WithMessage("Kullanıcı Telefonu 11 Haneden Fazla Olamaz");
		}
	}
}
