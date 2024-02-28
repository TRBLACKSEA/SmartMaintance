using Microsoft.Win32;
using OtoTamirTakip.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoTamirTakip
{
	public partial class FrmLisansGiris : Form
	{
		string Anahtar, KarsiKod,hamAnahtar = "";
		public static string LisansAnahtariAdi = "A94FE5112588FD0018DADF585A7F0F47DC09816A82AB9974D470AE2349C5D9C8"; // Lisans Anahtarı Anlamına Gelen Şirelenmmiş Anahtar Adı
		public static string CalismaLisansGunSayisi = "C1B4F28C324245F43C1E3E956A161A69AC1C9DD083EB0376CEBF5EFC1C31F33E"; //Lisans Gün Sayısı
		public static string cpuId = string.Empty;
		FrmLogin frmLogin = (FrmLogin)Application.OpenForms["FrmLogin"];

		string demoSureAdi = CustomTool.ToHexString("Süresiz Lisans");

		public FrmLisansGiris()
		{
			InitializeComponent();




			//ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM win32_processor");

			//foreach (ManagementObject wmi_CPU in searcher.Get())
			//{
			//	cpuId = wmi_CPU["processorID"].ToString();
			//}
			btnLisansla.Enabled = false;
			frmLogin.txtKullaniciAdi.Enabled = false;
			frmLogin.txtSifre.Enabled = false;
			frmLogin.chcBeniHatirla.Enabled = false;
			frmLogin.btnGiris.Enabled = false;
		}

		private void FrmLisansGiris_Load(object sender, EventArgs e)
		{
			


		}

		private void txtLisansAnahtari_TextChanged(object sender, EventArgs e)
		{
			if (txtLisansAnahtari.Text == Anahtar)
			{
				btnLisansla.Enabled = true;
				btnKarsiKodOlustur.Enabled = false;
				txtKarsiKod.Enabled = false;
			}
		}

		private void FrmLisansGiris_FormClosed(object sender, FormClosedEventArgs e)
		{
			RegistryKey anahtar = Registry.CurrentUser.OpenSubKey("Software", true);
			string demoSureAdi = CustomTool.ToHexString("Süresiz");
			if (anahtar.OpenSubKey(LisansAnahtariAdi) == null)
			{
				Application.Exit();
			}
			anahtar.Close();
		}

		private void btnLisansla_Click(object sender, EventArgs e)
		{
			if (txtLisansAnahtari.Text == Anahtar)
			{
				RegistryKey anahtar = Registry.CurrentUser.OpenSubKey("Software", true);
				if (anahtar.OpenSubKey(FrmLogin.LisansAnahtariAdi) == null)
				{
					anahtar.CreateSubKey(LisansAnahtariAdi);
					anahtar.OpenSubKey(LisansAnahtariAdi, true).SetValue(CalismaLisansGunSayisi, demoSureAdi, RegistryValueKind.String);
				}
				else
				{
					MessageBox.Show("Lisanslama Esnasında Hata Oluştu,Lütfen Yazılım Geliştiricisine Başvurunuz");
				}
				MessageBox.Show("Lisans İşlemi Başarılı,Tanımlanan Lisans Süresi : Süresiz Lisans");
				frmLogin.txtKullaniciAdi.Enabled = true;
				frmLogin.txtSifre.Enabled = true;
				frmLogin.chcBeniHatirla.Enabled = true;
				frmLogin.btnGiris.Enabled = true;
				this.Close();
			}
			else
			{
				MessageBox.Show("Geçersiz Lisans Anahtarı,Yazılım Geliştiricisine Başvurunuz");
			}
		}

		private void btnKarsiKodOlustur_Click(object sender, EventArgs e)
		{
			hamAnahtar = txtKarsiKod.Text + "#" + DateTime.Now.ToString() + "#" + "Oto Tamir Takip" + "#" + FrmLogin.cpuId;
			KarsiKod = CustomTool.ToHexString(hamAnahtar);
			Anahtar = CustomTool.ToHexString(KarsiKod);
			txtKarsiKod.Text = KarsiKod;
		}
	}
}
