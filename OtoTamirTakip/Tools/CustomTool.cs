using DevExpress.LookAndFeel;
using DevExpress.XtraPrinting.Caching;
using DevExpress.XtraReports.UI;
using OtoTamirTakip.Context;
using OtoTamirTakip.DAL;
using OtoTamirTakip.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoTamirTakip.Tools
{
	public class CustomTool
	{
		public static DataTable ConvertListToDataTable(List<IsEmirDetay> list)
		{
			// New table.
			DataTable table = new DataTable();
			Type t = typeof(IsEmirDetay);
			var properties = t.GetProperties();

			// Add columns.
			for (int i = 0; i < properties.Length; i++)
			{
				table.Columns.Add(properties[i].Name);
			}

			// Add rows.
			foreach (var item in list)
			{
				table.Rows.Add(item.ID, item.SiraNo, item.Adet, item.ParcaAdi, item.BirimFiyat, item.Tutari);
			}

			return table;
		}
		public static void ToolStripYaz(ToolStripStatusLabel toolStripStatusLabel, decimal value)
		{
			
			toolStripStatusLabel.Text += (Convert.ToInt32(toolStripStatusLabel.Text) + value).ToString();
		}
		public static void RaporOlustur(OtoTamirTakipContext context,string secilenIsEmriNo,string dosyaadi, XtraReport report, MusteriDAL musteriDAL,AracDAL aracDAL)
		{
			List<IsEmirDetay> ısEmirDetays = context.IsEmriDetaylari.Where(q => q.IsEmriNo == secilenIsEmriNo).ToList();
			IsEmri ısEmri = context.IsEmirleri.Where(q => q.IsEmriNo == secilenIsEmriNo).FirstOrDefault();
			//Rapor Önizlemesi

			report.LoadLayout(dosyaadi);
			Ayarlar ayarlar = context.Ayarlar.Where(q => q.ID == 1).FirstOrDefault();
			Musteri musteri = musteriDAL.GetByFilter(context, q => q.ID == ısEmri.MusteriID);
			Arac arac = aracDAL.GetByFilter(context, q => q.ID == ısEmri.AracID);
			//Rapor Başlığı
			report.Parameters["IsYeriAdi"].Value = ayarlar.Ad;
			report.Parameters["IsYeriAdresi"].Value = ayarlar.Adres;
			report.Parameters["MusteriAdi"].Value = musteri.Adi;
			report.Parameters["TcNo"].Value = musteri.TcNo;
			report.Parameters["Adres"].Value = musteri.Adres;
			report.Parameters["TelNo"].Value = musteri.Tel;
			report.Parameters["EPosta"].Value = musteri.Mail;
			report.Parameters["Plaka"].Value = arac.PlakaNo;
			report.Parameters["AracTipi"].Value = arac.AracTipi;
			report.Parameters["AracModel"].Value = arac.AracModel;
			report.Parameters["AracKM"].Value = ısEmri.AracKM;
			report.Parameters["Renk"].Value = arac.Renk;
			report.Parameters["SaseNo"].Value = arac.SaseNo;
			report.Parameters["GarantiBaslangic"].Value = arac.GarantiBaslangic;
			report.Parameters["GelisTarihi"].Value = ısEmri.GelisTarihi;
			report.Parameters["BaslamaTarihi"].Value = ısEmri.BaslamaTarihi;
			report.Parameters["TeslimTarihi"].Value = ısEmri.TeslimTarihi;
			report.Parameters["OdemeSekli"].Value = ısEmri.OdemeSekli;
			report.Parameters["IsEmriNo"].Value = ısEmri.IsEmriNo;
			report.Parameters["Kasko"].Value = ısEmri.Kasko;
			report.Parameters["Trafik"].Value = ısEmri.Trafik;
			report.Parameters["MusOd"].Value = ısEmri.MusOd;
			report.Parameters["ToplamTutar"].Value = ısEmri.ToplamTutar;


			//Rapor İçeriği
			DataTable table = CustomTool.ConvertListToDataTable(ısEmirDetays);

			report.DataSource = table;
			report.DataMember = "Line1";

			//Rapor Footer
			report.Parameters["ToplamTutar"].Value = string.Format("{0:C2}", ısEmri.ToplamTutar);

			report.Parameters["IsYeriAdi"].Visible = false;
			report.Parameters["IsYeriAdresi"].Visible = false;
			report.Parameters["MusteriAdi"].Visible = false;
			report.Parameters["TcNo"].Visible = false;
			report.Parameters["Adres"].Visible = false;
			report.Parameters["TelNo"].Visible = false;
			report.Parameters["EPosta"].Visible = false;
			report.Parameters["Plaka"].Visible = false;
			report.Parameters["AracTipi"].Visible = false;
			report.Parameters["AracModel"].Visible = false;
			report.Parameters["AracKM"].Visible = false;
			report.Parameters["Renk"].Visible = false;
			report.Parameters["SaseNo"].Visible = false;
			report.Parameters["GarantiBaslangic"].Visible = false;
			report.Parameters["GelisTarihi"].Visible = false;
			report.Parameters["BaslamaTarihi"].Visible = false;
			report.Parameters["TeslimTarihi"].Visible = false;
			report.Parameters["OdemeSekli"].Visible = false;
			report.Parameters["IsEmriNo"].Visible = false;
			report.Parameters["Kasko"].Visible = false;
			report.Parameters["Trafik"].Visible = false;
			report.Parameters["MusOd"].Visible = false;
			report.Parameters["ToplamTutar"].Visible = false;
		}

		public static void RaporOnizle(XtraReport report)
		{
			//Rapor Önizleme
			var storage = new MemoryDocumentStorage();
			var cachedReportSource = new CachedReportSource(report, storage);
			ReportPrintTool printTool = new ReportPrintTool(cachedReportSource);
			printTool.AutoShowParametersPanel = false;
			printTool.ShowPreviewDialog(UserLookAndFeel.Default);
		}
		public static void RaporYazdir(XtraReport report)
		{
			report.Print();
		}
		public static string ToHexString(string str)
		{
			var sb = new StringBuilder();

			var bytes = Encoding.Unicode.GetBytes(str);
			foreach (var t in bytes)
			{
				sb.Append(t.ToString("X2"));
			}

			return sb.ToString();
		}

		public static string FromHexString(string hexString)
		{
			var bytes = new byte[hexString.Length / 2];
			for (var i = 0; i < bytes.Length; i++)
			{
				bytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 16);
			}

			return Encoding.Unicode.GetString(bytes);
		}
	}
}
