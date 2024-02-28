using DevExpress.LookAndFeel;
using DevExpress.XtraBars;
using DevExpress.XtraPrinting.Caching;
using DevExpress.XtraReports.UI;
using Microsoft.Win32;
using OtoTamirTakip.Context;
using OtoTamirTakip.Entities;
using OtoTamirTakip.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoTamirTakip
{
	public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
	{
		Ayarlar ayarlar;
		OtoTamirTakipContext OtoTamirTakip = new OtoTamirTakipContext();
		public static string dosyaadi = Directory.GetCurrentDirectory() + "\\reports\\İşEmriRaporu.repx";
		public static XtraReport report = XtraReport.FromFile(dosyaadi, true);

		SqlConnection sqlConnection;
		string DatabasePath = "";
		string DatabaseName = "";
		string UserName = "";
		string Password = "";
		string EkrandaYazacakGunSayisi = "";
		public FrmMain()
		{
			InitializeComponent();
			StreamReader sr = new StreamReader(Application.StartupPath + "\\config.txt");

			while (!sr.EndOfStream)
			{
				DatabasePath = sr.ReadLine();
				DatabaseName = sr.ReadLine();
				UserName = sr.ReadLine();
				Password = sr.ReadLine();
			}
			sr.Close();
			sqlConnection = new SqlConnection("Data Source=" + DatabasePath + ";Initial Catalog=" + DatabaseName + ";Integrated Security=true;");
			ayarlar = OtoTamirTakip.Ayarlar.Where(q => q.ID == 1).FirstOrDefault();

		}

		private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
		{
			FrmYeniCariOlustur frmYeniCariOlustur = new FrmYeniCariOlustur();
			frmYeniCariOlustur.ShowDialog();
		}

		private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
		{
			FrmCariGoruntule frmCariGoruntule = new FrmCariGoruntule();
			frmCariGoruntule.ShowDialog();
		}

		private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
		{
			FrmAracEkle frmPlakalar = new FrmAracEkle();
			frmPlakalar.ShowDialog();
		}

		private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
		{
			FrmYeniIsEmriOlustur frmYeniIsEmriOlustur = new FrmYeniIsEmriOlustur();
			frmYeniIsEmriOlustur.ShowDialog();
		}

		private void FrmMain_Load(object sender, EventArgs e)
		{
			//ribbonPage1.Visible = false;
			var versionInfo = FileVersionInfo.GetVersionInfo(Application.ExecutablePath);
			string version = versionInfo.ProductVersion;
			barlblVersiyon.Caption = version;
			if (!FrmLogin.kullanici.isAdmin)
			{
				ribbonPageYonetim.Visible = false;
			}
			barlblKullaniciAdi.Caption = "Kullanıcı: " + FrmLogin.kullanici.KulaniciAdi;

			RegistryKey anahtar = Registry.CurrentUser.OpenSubKey("Software", true);
			if (anahtar.OpenSubKey(FrmLogin.LisansAnahtariAdi) != null)
			{
				EkrandaYazacakGunSayisi = CustomTool.FromHexString(anahtar.OpenSubKey(FrmLogin.LisansAnahtariAdi).GetValue(FrmLogin.CalismaLisansGunSayisi).ToString());
			}
			else
			{
				EkrandaYazacakGunSayisi = "Lisanslama Yapılmamış";
			}

			lblKalanLisansSure.Caption = "Kalan Lisans Süresi: " + EkrandaYazacakGunSayisi;
		}

		private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
		{
			FrmRaporTasarla frmRaporTasarla = new FrmRaporTasarla();
			frmRaporTasarla.ShowDialog();
		}

		private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
		{
			FrmAyarlar frmAyarlar = new FrmAyarlar();
			frmAyarlar.ShowDialog();
		}




		private void ribbon_Click(object sender, EventArgs e)
		{

		}

		private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
		{
			FrmIsEmirGoruntule frmIsEmirGoruntule = new FrmIsEmirGoruntule();
			frmIsEmirGoruntule.ShowDialog();

		}

		private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
		{
			FrmAracEkle frmAracEkle = new FrmAracEkle();
			frmAracEkle.ShowDialog();
		}

		private void barButtonItem14_ItemClick(object sender, ItemClickEventArgs e)
		{

		}

		private void barButtonItem6_ItemClick_1(object sender, ItemClickEventArgs e)
		{
			FrmAyarlar frmAyarlar = new FrmAyarlar();
			frmAyarlar.ShowDialog();
		}

		private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
		{
			FrmLogin frmLogin = (FrmLogin)Application.OpenForms["FrmLogin"];
			frmLogin.Show();
			this.Close();
		}

		private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
		{

		}

		private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
		{
			FrmKullaniciEkle frmKullaniciEkle = new FrmKullaniciEkle();
			frmKullaniciEkle.ShowDialog();
		}

		private void barButtonItem15_ItemClick(object sender, ItemClickEventArgs e)
		{
			FrmAracGoruntule frmAracGoruntule = new FrmAracGoruntule();
			frmAracGoruntule.ShowDialog();
		}

		private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
		{
			FrmLogin frmLogin = (FrmLogin)Application.OpenForms["FrmLogin"];
			frmLogin.Show();
		}

		private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
		{
			FrmPersonelGoruntule frmPersonelGoruntule = new FrmPersonelGoruntule();
			frmPersonelGoruntule.ShowDialog();
		}

		private void barButtonItem14_ItemClick_1(object sender, ItemClickEventArgs e)
		{

			string backupKomut = "BACKUP DATABASE " + DatabaseName + " TO DISK = '" + Application.StartupPath + @"\DBBackUp\" + DateTime.Now.ToString("yyyymmdd") + ".bak'";
			SqlCommand command = new SqlCommand(backupKomut, sqlConnection);
			sqlConnection.Open();
			command.ExecuteNonQuery();
			sqlConnection.Close();
			MessageBox.Show("Veritabanı Yedeği Alındı");

		}

		private void barButtonItem16_ItemClick(object sender, ItemClickEventArgs e)
		{
			FrmLisans frmLisans = new FrmLisans();
			frmLisans.ShowDialog();
		}

		private void barButtonItem14_ItemClick_2(object sender, ItemClickEventArgs e)
		{
			FrmKaportaBoya frmKaportaBoya = new FrmKaportaBoya();
			frmKaportaBoya.ShowDialog();
		}
	}
}