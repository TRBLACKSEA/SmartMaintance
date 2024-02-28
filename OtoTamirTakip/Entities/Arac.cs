using OtoTamirTakip.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoTamirTakip.Entities
{
	public class Arac : IEntity
	{
		private int _ID;

		public int ID
		{
			get { return _ID; }
			set { _ID = value; }
		}

		private string _PlakaNo;

		public string PlakaNo
		{
			get { return _PlakaNo; }
			set { _PlakaNo = value; }
		}


		private string _AracTipi;

		public string AracTipi
		{
			get { return _AracTipi; }
			set { _AracTipi = value; }
		}
		private string _AracModel;

		public string AracModel
		{
			get { return _AracModel; }
			set { _AracModel = value; }
		}
		private List<IsEmri> _IsEmirleri;

		public List<IsEmri> IsEmirleri
		{
			get { return _IsEmirleri; }
			set { _IsEmirleri = value; }
		}
		private int _MusteriID;

		public int MusteriID
		{
			get { return _MusteriID; }
			set { _MusteriID = value; }
		}


		private Musteri _Musteri;

		public Musteri Musteri
		{
			get { return _Musteri; }
			set { _Musteri = value; }
		}


		private string _Renk;

		public string Renk
		{
			get { return _Renk; }
			set { _Renk = value; }
		}
		private string _SaseNo;

		public string SaseNo
		{
			get { return _SaseNo; }
			set { _SaseNo = value; }
		}

		private DateTime? _GarantiBaslangic;

		public DateTime? GarantiBaslangic
		{
			get { return _GarantiBaslangic; }
			set { _GarantiBaslangic = value; }
		}

		private bool _Kullanimdami;

		public bool Kullanimdami
		{
			get { return _Kullanimdami; }
			set { _Kullanimdami = value; }
		}

	}
}
