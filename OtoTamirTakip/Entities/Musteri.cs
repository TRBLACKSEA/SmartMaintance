using OtoTamirTakip.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoTamirTakip.Entities
{
	public class Musteri : IEntity
	{
		private int _ID;

		public int ID
		{
			get { return _ID; }
			set { _ID = value; }
		}
		private string _Adi;

		public string  Adi
		{
			get { return _Adi; }
			set { _Adi = value; }
		}
		private string _TcNo;

		public string TcNo
		{
			get { return _TcNo; }
			set { _TcNo = value; }
		}
		private string _Adres;

		public string Adres
		{
			get { return _Adres; }
			set { _Adres = value; }
		}
		private string _Tel;

		public string Tel
		{
			get { return _Tel; }
			set { _Tel= value; }
		}
		private string _Mail;

		public string Mail
		{
			get { return _Mail; }
			set { _Mail = value; }
		}
		
		private List<Arac> _MusteriAraclari;

		public List<Arac> MusteriAraclari
		{
			get { return _MusteriAraclari; }
			set { _MusteriAraclari = value; }
		}
		private bool _Kullanimdami;

		public bool Kullanimdami
		{
			get { return _Kullanimdami; }
			set { _Kullanimdami = value; }
		}

	}
}
