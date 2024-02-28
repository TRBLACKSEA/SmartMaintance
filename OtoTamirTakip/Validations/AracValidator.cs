using FluentValidation;
using OtoTamirTakip.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoTamirTakip.Validations
{
	public class AracValidator : AbstractValidator<Arac>
	{
		public AracValidator()
		{
			RuleFor(q => q.AracModel).NotEmpty().WithMessage("Araç Modeli Boş Geçilemez");
			RuleFor(q => q.SaseNo).NotEmpty().WithMessage("Şase Numarası Boş Geçilemez");
		}
	}
}
