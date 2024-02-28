using OtoTamirTakip.Context;
using OtoTamirTakip.Entities;
using OtoTamirTakip.Repository;
using OtoTamirTakip.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoTamirTakip.DAL
{
	public class KullanıcıDAL: EntityRepository<OtoTamirTakipContext, Kullanici, KullanıcıValidator>
	{
	}
}
