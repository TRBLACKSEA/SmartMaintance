using OtoTamirTakip.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoTamirTakip.Entities
{
	public class Ayarlar : IEntity
	{
		private int _ID;

		public int ID
		{
			get { return _ID; }
			set { _ID = value; }
		}
		private string _Ad;

		public string Ad
		{
			get { return _Ad; }
			set { _Ad = value; }
		}
		private string _Adres;

		public string Adres
		{
			get { return _Adres; }
			set { _Adres = value; }
		}
		private string _Telefon;

		public string Telefon
		{
			get { return _Telefon; }
			set { _Telefon = value; }
		}
		private string _Mail;

		public string Mail
		{
			get { return _Mail; }
			set { _Mail = value; }
		}

	}
}
