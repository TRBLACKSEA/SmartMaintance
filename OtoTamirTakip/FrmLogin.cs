using DevExpress.XtraEditors;
using Microsoft.Win32;
using OtoTamirTakip.Context;
using OtoTamirTakip.DAL;
using OtoTamirTakip.Entities;
using OtoTamirTakip.Properties;
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
	public partial class FrmLogin : DevExpress.XtraEditors.XtraForm
	{

		OtoTamirTakipContext context = new OtoTamirTakipContext();
		KullanıcıDAL kullanicDAL = new KullanıcıDAL();
		BeniHatirlaKullanicisiDAL BeniHatirlaKullanicisiDAL = new BeniHatirlaKullanicisiDAL();
		BeniHatirlaKullanicisi bhk;
		public static Kullanici kullanici;
		public static string LisansAnahtariAdi = "A94FE5112588FD0018DADF585A7F0F47DC09816A82AB9974D470AE2349C5D9C8"; // Lisans Anahtarı Anlamına Gelen Şirelenmmiş Anahtar Adı
		public static string CalismaLisansGunSayisi = "C1B4F28C324245F43C1E3E956A161A69AC1C9DD083EB0376CEBF5EFC1C31F33E"; //Lisans Gün Sayısı
		public static string cpuId = string.Empty;
		public FrmLogin()
		{
			InitializeComponent();

			//ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM win32_processor");

			//foreach (ManagementObject wmi_CPU in searcher.Get())
			//{
			//	cpuId = wmi_CPU["processorID"].ToString();
			//}
			//MessageBox.Show(cpuId.ToString());
		}


		private void btnGiris_Click(object sender, EventArgs e)
		{

			if (!string.IsNullOrEmpty(txtKullaniciAdi.Text) && !string.IsNullOrEmpty(txtSifre.Text))
			{
				kullanici = kullanicDAL.GetByFilter(context, q => q.KulaniciAdi == txtKullaniciAdi.Text && q.Sifre == txtSifre.Text);

				if (kullanici != null)
				{
					if (kullanici.Kullanimdami)
					{
						if (chcBeniHatirla.Checked)
						{
							bhk.KullaniciID = kullanici.ID;
							BeniHatirlaKullanicisiDAL.Save(context);
						}
						else
						{

							if (bhk != null)
							{
								bhk.KullaniciID = 0;
								BeniHatirlaKullanicisiDAL.Save(context);
							}
						}

						FrmMain frmMain = new FrmMain();
						frmMain.Show();
						this.Hide();

					}
					else
					{
						MessageBox.Show("Kullanıcı Aktif Değil,Giriş Yapamazsınız");
					}
				}
				else
				{
					MessageBox.Show("Kullanıcı Bulunamadı");
				}


			}
			else
			{
				MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış");
			}

		}

		private void FrmLogin_Load(object sender, EventArgs e)
		{
			RegistryKey anahtar = Registry.CurrentUser.OpenSubKey("Software", true);
			//int demoSure = 15;
			//string demoSureAdi = CustomTool.ToHexString(demoSure.ToString() + " Gün");
			if (anahtar.OpenSubKey(LisansAnahtariAdi) == null)
			{
				FrmLisansGiris frmLisansGiris = new FrmLisansGiris();
				frmLisansGiris.ShowDialog();
			}
			else
			{
				if (!context.Database.Exists())
				{
					context.Database.Create();
					Ayarlar ayarEkle = new Ayarlar() { Ad = "Firma Adı", Adres = "Firma Adresi", Telefon = "0123456789", Mail = "Firma@mail.com" };
					context.Ayarlar.Add(ayarEkle);
					context.SaveChanges();
					Kullanici ilkKullanici = new Kullanici()
					{
						KulaniciAdi = "admin",
						Sifre = "admin",
						isAdmin = true,
						Kullanimdami = true
					};
					kullanicDAL.Add(context, ilkKullanici);
					kullanicDAL.Save(context);
					bhk = new BeniHatirlaKullanicisi()
					{
						KullaniciID = 0
					};
					BeniHatirlaKullanicisiDAL.Add(context, bhk);
					BeniHatirlaKullanicisiDAL.Save(context);


				}
				bhk = BeniHatirlaKullanicisiDAL.GetByFilter(context, q => q.ID == 1);
				txtKullaniciAdi.Focus();
				txtSifre.PasswordChar = '*';

				if (bhk.KullaniciID != 0)
				{
					chcBeniHatirla.Checked = true;
					Kullanici kullanici = kullanicDAL.GetByFilter(context, q => q.ID == bhk.KullaniciID);
					txtKullaniciAdi.Text = kullanici.KulaniciAdi;
					txtSifre.Text = kullanici.Sifre;
				}
				else
				{
					chcBeniHatirla.Checked = false;
				}
			}

			anahtar.Close();



		}

		private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		private void FrmLogin_Shown(object sender, EventArgs e)
		{

		}

		private void FrmLogin_Paint(object sender, PaintEventArgs e)
		{

		}

		private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
		{

			
		}
	}
}