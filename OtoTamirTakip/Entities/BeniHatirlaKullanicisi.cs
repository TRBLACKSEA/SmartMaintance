using OtoTamirTakip.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoTamirTakip.Entities
{
	public class BeniHatirlaKullanicisi : IEntity
	{
		private int _ID;

		public int ID
		{
			get { return _ID; }
			set { _ID = value; }
		}
		private int _KullaniciID;

		public int KullaniciID
		{
			get { return _KullaniciID; }
			set { _KullaniciID = value; }
		}


	}
}
