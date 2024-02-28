using OtoTamirTakip.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoTamirTakip.Entities
{
	public class Kullanici : IEntity
	{
		private int _ID;

		public int ID
		{
			get { return _ID; }
			set { _ID = value; }
		}
		private string _KullaniciAdi;

		public string KulaniciAdi
		{
			get { return _KullaniciAdi; }
			set { _KullaniciAdi = value; }
		}
		private string _Sifre;

		public string Sifre
		{
			get { return _Sifre; }
			set { _Sifre = value; }
		}
		private bool _isAdmin;

		public bool isAdmin
		{
			get { return _isAdmin; }
			set { _isAdmin = value; }
		}
		private bool _Kullanimdami;

		public bool Kullanimdami
		{
			get { return _Kullanimdami; }
			set { _Kullanimdami = value; }
		}


	}
}
