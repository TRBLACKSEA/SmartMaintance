using DevExpress.XtraEditors;
using OtoTamirTakip.Context;
using OtoTamirTakip.DAL;
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
	public partial class FrmYeniCariOlustur : DevExpress.XtraEditors.XtraForm
	{
		OtoTamirTakipContext context = new OtoTamirTakipContext();
		MusteriDAL musteriDAL = new MusteriDAL();
		public FrmYeniCariOlustur()
		{
			InitializeComponent();
		}

		private void FrmYeniCariOlustur_Load(object sender, EventArgs e)
		{

		}

		private void simpleButton1_Click(object sender, EventArgs e)
		{
			Musteri eklenecekMusteri = new Musteri()
			{
				Adi = txtMusteriAdi.Text,
				TcNo = txtTcNo.Text,
				Adres = txtAdres.Text,
				Tel = txtTelNo.Text,
				Mail = txtEposta.Text,
				Kullanimdami=true
			};
			//context.Musteriler.Add(eklenecekMusteri);
			//context.SaveChanges();

			musteriDAL.Add(context, eklenecekMusteri);
			musteriDAL.Save(context);
			MessageBox.Show("Müşteri Eklendi");
			this.Close();

		}
	}
}