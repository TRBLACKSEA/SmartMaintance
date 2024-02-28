using FluentValidation;
using OtoTamirTakip.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoTamirTakip.Tools
{
	public class ValidatorTool
	{
		public static bool Validate(IValidator validator,IEntity entity)
		{
			bool result = true;
            var context = new ValidationContext<object>(entity);
            var validationResult = validator.Validate(context);
            if (!validationResult.IsValid)
            {
                string message = null;
                foreach (var error in validationResult.Errors)
                {
                    message += error.ErrorMessage + System.Environment.NewLine;
                }
                MessageBox.Show(message);
                result = false;
            }
            return result;
		}
	}
}
