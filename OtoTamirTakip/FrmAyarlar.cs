using DevExpress.XtraEditors;
using OtoTamirTakip.Context;
using OtoTamirTakip.Entities;
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
	public partial class FrmAyarlar : DevExpress.XtraEditors.XtraForm
	{
		OtoTamirTakipContext context = new OtoTamirTakipContext();
		Ayarlar ayarlar;
		public FrmAyarlar()
		{
			InitializeComponent();
			ayarlar = context.Ayarlar.Where(q => q.ID == 1).FirstOrDefault();
		}

		private void simpleButton1_Click(object sender, EventArgs e)
		{
			ayarlar.Ad = txtSirket.Text;
			ayarlar.Adres = txtAdres.Text;
			ayarlar.Telefon = txtTelefon.Text;
			ayarlar.Mail = txtMail.Text;
			context.SaveChanges();
			MessageBox.Show("Ayarlar Güncellendi");
		}

		private void FrmAyarlar_Load(object sender, EventArgs e)
		{
			txtSirket.Text = ayarlar.Ad;
			txtAdres.Text = ayarlar.Adres;
			txtTelefon.Text = ayarlar.Telefon;
			txtMail.Text = ayarlar.Mail;
		}
	}
}