using FluentValidation;
using OtoTamirTakip.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoTamirTakip.Validations
{
	public class IsEmriDetayValidator : AbstractValidator<IsEmirDetay>
	{
		public IsEmriDetayValidator()
		{
			RuleFor(q => q.ParcaAdi).NotEmpty().WithMessage("Parça Adı Boş Geçilemez");

		}
	}
}
