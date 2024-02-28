using DevExpress.XtraEditors;
using Microsoft.Win32;
using OtoTamirTakip.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoTamirTakip
{
	public partial class FrmLisans : DevExpress.XtraEditors.XtraForm
	{
		string Anahtar , KarsiKod,Gun;
		public FrmLisans()
		{
			InitializeComponent();
		}

		private void FrmLisans_Load(object sender, EventArgs e)
		{
			RegistryKey anahtar = Registry.CurrentUser.OpenSubKey("Software", true);
			if (anahtar.OpenSubKey(FrmLogin.LisansAnahtariAdi) != null)
			{
				label2.Text = "Lisanslı";
				label2.ForeColor = Color.Green;
				label4.Text = CustomTool.FromHexString(anahtar.OpenSubKey(FrmLogin.LisansAnahtariAdi).GetValue(FrmLogin.CalismaLisansGunSayisi).ToString());
				label10.Enabled = label5.Enabled = txtKarsiKod.Enabled = txtLisansAnahtari.Enabled = false;
				label6.Enabled = txtSertifika.Enabled = btnDosyaSec.Enabled = false;
				label8.Enabled = label9.Enabled = txtKullaniciAdi.Enabled = txtSifre.Enabled = false;
				chcKullanimKosullari.Enabled = false;
				btnKaydet.Enabled = false;
				cmbLisansSüre.Enabled = false;
				btnKarsiKodOlustur.Enabled = false;

				radioButton1.Enabled = false;
				radioButton2.Enabled = false;
				radioButton3.Enabled = false;
				cmbLisansSüre.Text = "Seçiniz";
			}
			else
			{
				label2.Text = "Lisans Yapılmamış";
				label2.ForeColor = Color.Red;
				label4.Text = "-";

				label10.Enabled = label5.Enabled = txtKarsiKod.Enabled = txtLisansAnahtari.Enabled = false;
				label6.Enabled = txtSertifika.Enabled = btnDosyaSec.Enabled = true;
				label8.Enabled = label9.Enabled = txtKullaniciAdi.Enabled = txtSifre.Enabled = false;
				radioButton1.Checked = true;
				cmbLisansSüre.Text = "Seçiniz";
			}

			




		}

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{
			label10.Enabled = label5.Enabled = txtKarsiKod.Enabled = txtLisansAnahtari.Enabled = false;
			label6.Enabled = txtSertifika.Enabled = btnDosyaSec.Enabled = true;
			label8.Enabled = label9.Enabled = txtKullaniciAdi.Enabled = txtSifre.Enabled = false;
		}

		private void radioButton3_CheckedChanged(object sender, EventArgs e)
		{
			label10.Enabled = label5.Enabled = txtKarsiKod.Enabled = txtLisansAnahtari.Enabled = false;
			label6.Enabled = txtSertifika.Enabled = btnDosyaSec.Enabled = false;
			label8.Enabled = label9.Enabled = txtKullaniciAdi.Enabled = txtSifre.Enabled = true;
		}

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
			label10.Enabled = label5.Enabled = txtKarsiKod.Enabled = txtLisansAnahtari.Enabled = true;
			label6.Enabled = txtSertifika.Enabled = btnDosyaSec.Enabled = false;
			label8.Enabled = label9.Enabled = txtKullaniciAdi.Enabled = txtSifre.Enabled = false;
		}

		private void btnKaydet_Click(object sender, EventArgs e)
		{
			if (radioButton1.Checked)
			{
				if (txtLisansAnahtari.Text == Anahtar)
				{
					MessageBox.Show("Lisans İşlemi Başarılı,Tanımlanan Lisans Süresi : " + Gun + " Gün");
				}
				else
				{
					MessageBox.Show("Geçersiz Lisans Anahtarı");
				}
			}
		}

		private void btnKarsiKodOlustur_Click(object sender, EventArgs e)
		{
			
			if (cmbLisansSüre.Text != "Seçiniz")
			{
				txtLisansAnahtari.Text = "";
				string hamAnahtar = "";
				if (cmbLisansSüre.SelectedIndex==0)//Demo(15 Gün)
				{
					Gun = "15";
				}else if (cmbLisansSüre.SelectedIndex == 1)//30 Gün
				{
					Gun = "30";
				}
				else if (cmbLisansSüre.SelectedIndex == 2)//1 Yıl
				{
					Gun = "365";
				}
				else if (cmbLisansSüre.SelectedIndex == 3)//2 Yıl
				{
					Gun = "730";
				}
				else if (cmbLisansSüre.SelectedIndex==4)//5 Yıl
				{
					Gun = "1825";
				}
				else if (cmbLisansSüre.SelectedIndex == 5)
				{
					Gun = "3650";
				}
				hamAnahtar = txtKarsiKod.Text + "#" + DateTime.Now.ToString() + "#" + "Oto Tamir Takip" + "#" + Gun + " Gün" + "#" + FrmLogin.cpuId;
				KarsiKod = CustomTool.ToHexString(hamAnahtar);
				Anahtar = CustomTool.ToHexString(KarsiKod);
				txtKarsiKod.Text = KarsiKod;
			}
			else
			{
				MessageBox.Show("Lisans Süresi Seçiniz");
			}
		}
	}
}