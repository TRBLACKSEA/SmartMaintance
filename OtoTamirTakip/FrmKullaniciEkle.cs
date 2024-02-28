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
	public partial class FrmKullaniciEkle : DevExpress.XtraEditors.XtraForm
	{
		OtoTamirTakipContext context = new OtoTamirTakipContext();
		KullanıcıDAL kullanicDAL = new KullanıcıDAL();

		public FrmKullaniciEkle()
		{
			InitializeComponent();
		}

		private void btnKaydet_Click(object sender, EventArgs e)
		{
			Kullanici eklenecekKullanici = kullanicDAL.GetByFilter(context, q => q.KulaniciAdi == txtKullaniciAdi.Text);
			if(eklenecekKullanici !=null)
			{
				MessageBox.Show("Kullanıcı Zaten Kayıtlı");
			}
			else
			{
				Kullanici kullanici = new Kullanici();
				kullanici.KulaniciAdi = txtKullaniciAdi.Text;
				kullanici.Sifre = txtSifre.Text;
				kullanici.isAdmin = chckYoneticiMi.Checked;
				kullanici.Kullanimdami = chcAktif.Checked;
				kullanicDAL.Add(context, kullanici);
				kullanicDAL.Save(context);
				MessageBox.Show("Kullanıcı Eklendi");
				this.Close();
			}
		}

		private void FrmKullaniciEkle_Load(object sender, EventArgs e)
		{
			txtKullaniciAdi.Focus();
		}
	}
}