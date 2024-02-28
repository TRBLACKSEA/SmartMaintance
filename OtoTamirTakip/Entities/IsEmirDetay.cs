using OtoTamirTakip.Entities;
using OtoTamirTakip.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoTamirTakip.Entities
{
	public class IsEmirDetay : IEntity
	{
		private int _ID;

		public int ID
		{
			get { return _ID; }
			set { _ID = value; }
		}
		private string _SiraNo;

		public string SiraNo
		{
			get { return _SiraNo; }
			set { _SiraNo = value; }
		}
		private int _Adet;

		public int Adet
		{
			get { return _Adet; }
			set { _Adet = value; }
		}
		private string _ParcaAdi;

		public string ParcaAdi
		{
			get { return _ParcaAdi; }
			set { _ParcaAdi = value; }
		}

		private decimal _BirimFiyat;

		public decimal BirimFiyat
		{
			get { return _BirimFiyat; }
			set { _BirimFiyat = value; }
		}
		private decimal _Tutari;

		public decimal Tutari
		{
			get { return _Tutari; }
			set { _Tutari = value; }
		}
		private string _IsEmriNo;

		public string IsEmriNo
		{
			get { return _IsEmriNo; }
			set { _IsEmriNo = value; }
		}
		private int _IsEmirID;

		public int IsEmirID
		{
			get { return _IsEmirID; }
			set { _IsEmirID = value; }
		}

		private IsEmri _IsEmri;

		public IsEmri IsEmri
		{
			get { return _IsEmri; }
			set { _IsEmri = value; }
		}

	}
}
