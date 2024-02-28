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
	public partial class FrmPersonelGoruntule : DevExpress.XtraEditors.XtraForm
	{
		OtoTamirTakipContext context = new OtoTamirTakipContext();
		KullanıcıDAL kullanıcıDAL = new KullanıcıDAL();
		int secilenKullaniciID;
		Kullanici secilenKullanici;
		public FrmPersonelGoruntule()
		{
			InitializeComponent();
		}

		private void FrmPersonelGoruntule_Load(object sender, EventArgs e)
		{
			grdKullanici.DataSource = kullanıcıDAL.GetAll(context);
			txtKullaniciAdi.Focus();
		}

		private void btnTumu_Click(object sender, EventArgs e)
		{
			grdKullanici.DataSource = kullanıcıDAL.GetAll(context);
		}

		private void btnKullanimdaOlan_Click(object sender, EventArgs e)
		{
			grdKullanici.DataSource = context.Kullanicilar.Where(q => q.Kullanimdami == true).ToList();
		}

		private void btnKullanimdaOlmayan_Click(object sender, EventArgs e)
		{
			grdKullanici.DataSource = context.Kullanicilar.Where(q => q.Kullanimdami == true).ToList();
		}

		private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
		{
			if (e.FocusedRowHandle > -1)
			{
				//secilenIndex = e.FocusedRowHandle;
				secilenKullaniciID = Convert.ToInt32(gridView1.GetRowCellValue(e.FocusedRowHandle, "ID"));
				secilenKullanici = kullanıcıDAL.GetByFilter(context, q => q.ID == secilenKullaniciID);
			}
		}

		private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
		{
			if (gridView1.RowCount > 0)
			{
				txtKullaniciAdi.Text = secilenKullanici.KulaniciAdi;
				txtSifre.Text = secilenKullanici.Sifre;
				chcYonetici.Checked = secilenKullanici.isAdmin;
				chcAktif.Checked = secilenKullanici.Kullanimdami;
			}
		}

		private void btnGuncelle_Click(object sender, EventArgs e)
		{
			Kullanici kullanici = kullanıcıDAL.GetByFilter(context, q => q.ID == secilenKullaniciID);
			kullanici.KulaniciAdi = txtKullaniciAdi.Text;
			kullanici.Sifre = txtSifre.Text;
			kullanici.isAdmin = chcYonetici.Checked;
			kullanici.Kullanimdami = chcAktif.Checked;
			kullanıcıDAL.Save(context);
			MessageBox.Show("Kullanıcı Güncellendi");
			grdKullanici.DataSource = kullanıcıDAL.GetAll(context);
		}

		private void btnSil_Click(object sender, EventArgs e)
		{
			DialogResult result = new DialogResult();
			result = MessageBox.Show("Kullanıcıyı Silmek İstediğinize Eminmisiniz","Uyarı",MessageBoxButtons.YesNo);
			if (result == DialogResult.Yes)
			{
				Kullanici SilinecekKullanici = kullanıcıDAL.GetByFilter(context, q => q.ID == secilenKullaniciID);
				kullanıcıDAL.Delete(context, SilinecekKullanici);
				kullanıcıDAL.Save(context);
				MessageBox.Show("Kullanıcı Silindi");
				grdKullanici.DataSource = kullanıcıDAL.GetAll(context);
			}
		}
	}
}