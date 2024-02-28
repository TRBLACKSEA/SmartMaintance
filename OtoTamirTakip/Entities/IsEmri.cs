using OtoTamirTakip.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoTamirTakip.Entities
{
	public class IsEmri : IEntity
	{
		private int _ID;

		public int ID
		{
			get { return _ID; }
			set { _ID = value; }
		}

		private int _MusteriID;

		public int MusteriID
		{
			get { return _MusteriID; }
			set { _MusteriID = value; }
		}


		private int _AracID;

		public int AracID
		{
			get { return _AracID; }
			set { _AracID = value; }
		}
		private Arac _Arac;

		public Arac Arac
		{
			get { return _Arac; }
			set { _Arac = value; }
		}


		private DateTime? _GelisTarihi;

		public DateTime? GelisTarihi
		{
			get { return _GelisTarihi; }
			set { _GelisTarihi = value; }
		}
		private DateTime? _BaslamaTarihi;

		public DateTime? BaslamaTarihi
		{
			get { return _BaslamaTarihi; }
			set { _BaslamaTarihi = value; }
		}
		private DateTime? _TeslimTarihi;

		public DateTime? TeslimTarihi
		{
			get { return _TeslimTarihi; }
			set { _TeslimTarihi = value; }
		}
		private string _OdemeSekli;

		public string OdemeSekli
		{
			get { return _OdemeSekli; }
			set { _OdemeSekli = value; }
		}
		private string _IsEmriNo;

		public string IsEmriNo
		{
			get { return _IsEmriNo; }
			set { _IsEmriNo = value; }
		}
		private string _AracKM;

		public string AracKM
		{
			get { return _AracKM; }
			set { _AracKM = value; }
		}

		private bool _Kasko;

		public bool Kasko
		{
			get { return _Kasko; }
			set { _Kasko = value; }
		}
		private bool _Trafik;

		public bool Trafik
		{
			get { return _Trafik; }
			set { _Trafik = value; }
		}
		private bool _MusOd;

		public bool MusOd
		{
			get { return _MusOd; }
			set { _MusOd = value; }
		}
		private decimal _ToplamTutar;

		public decimal ToplamTutar
		{
			get { return _ToplamTutar; }
			set { _ToplamTutar = value; }
		}

		private List<IsEmirDetay> _IsEmirDetaylari;

		public List<IsEmirDetay> IsEmirDetaylari
		{
			get { return _IsEmirDetaylari; }
			set { _IsEmirDetaylari = value; }
		}

	}
}
