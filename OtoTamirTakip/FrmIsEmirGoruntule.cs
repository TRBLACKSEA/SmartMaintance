using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting.Caching;
using DevExpress.XtraReports.UI;
using OtoTamirTakip.Context;
using OtoTamirTakip.DAL;
using OtoTamirTakip.Entities;
using OtoTamirTakip.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoTamirTakip
{
	public partial class FrmIsEmirGoruntule : DevExpress.XtraEditors.XtraForm
	{
		OtoTamirTakipContext context = new OtoTamirTakipContext();
		string secilenIsEmriNo = "";
		MusteriDAL musteriDAL = new MusteriDAL();
		AracDAL aracDAL = new AracDAL();
		IsEmriDAL isEmriDAL = new IsEmriDAL();

		public FrmIsEmirGoruntule()
		{
			InitializeComponent();
		}

		private void FrmIsEmirGoruntule_Load(object sender, EventArgs e)
		{
			List<Musteri> musteriler = musteriDAL.GetAll(context);
			List<Arac> araclar = aracDAL.GetAll(context);
			List<IsEmri> isEmirleri = isEmriDAL.GetAll(context);
			var birlesik = from musteri in musteriler
						join arac in araclar on musteri.ID equals arac.MusteriID
						join isEmri in isEmirleri on arac.Musteri.ID equals isEmri.MusteriID
						select new
						{
							musteri.ID,
							musteri.Adi,
							musteri.TcNo,
							musteri.Adres,
							musteri.Tel,
							musteri.Mail,
							arac.PlakaNo,
							arac.AracTipi,
							arac.AracModel,
							isEmri.AracKM,
							arac.Renk,
							arac.SaseNo,
							arac.GarantiBaslangic,
							isEmri.GelisTarihi,
							isEmri.BaslamaTarihi,
							isEmri.TeslimTarihi,
							isEmri.OdemeSekli,
							isEmri.IsEmriNo,
							isEmri.Kasko,
							isEmri.Trafik,
							isEmri.MusOd
							
						};
			gridControl1.DataSource = birlesik.ToList();
		}

		private void repositoryItemButtonEdit1_Click(object sender, EventArgs e)
		{
			CustomTool.RaporOlustur(context, secilenIsEmriNo, FrmMain.dosyaadi, FrmMain.report, musteriDAL, aracDAL);
			CustomTool.RaporOnizle(FrmMain.report);
		}

		private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
		{
			if (gridView1.FocusedRowHandle > -1)
			{
				secilenIsEmriNo = gridView1.GetRowCellValue(e.FocusedRowHandle, "IsEmriNo").ToString();
			}
		}
	}
}