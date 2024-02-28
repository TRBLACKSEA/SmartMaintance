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
	public partial class FrmCariGoruntule : DevExpress.XtraEditors.XtraForm
	{
		OtoTamirTakipContext context = new OtoTamirTakipContext();
		MusteriDAL musteriDAL = new MusteriDAL();
		int secilenID;
		Musteri secilenMusteri;
		public FrmCariGoruntule()
		{
			InitializeComponent();
		}

		private void FrmCariGoruntule_Load(object sender, EventArgs e)
		{
			grdMusteriler.DataSource = musteriDAL.GetAll(context);
			txtMusteriAdi.Focus();
		}

		private void btnTumu_Click(object sender, EventArgs e)
		{
			grdMusteriler.DataSource = musteriDAL.GetAll(context);
		}

		private void btnKullanimdaOlan_Click(object sender, EventArgs e)
		{
			grdMusteriler.DataSource = context.Musteriler.Where(q => q.Kullanimdami == true).ToList();
		}

		private void btnKullanimdaOlmayan_Click(object sender, EventArgs e)
		{
			grdMusteriler.DataSource = context.Musteriler.Where(q => q.Kullanimdami == false).ToList();
		}

		private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
		{
			if (gridView1.RowCount > 0)
			{
				txtMusteriAdi.Text = secilenMusteri.Adi;
				txtAdres.Text = secilenMusteri.Adres;
				txtTcNo.Text = secilenMusteri.TcNo;
				txtTelefon.Text = secilenMusteri.Tel;
				txtMail.Text = secilenMusteri.Mail;
				chcKullanimdami.Checked = secilenMusteri.Kullanimdami;
			}
		}

		private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
		{
			if (e.FocusedRowHandle > -1)
			{
				secilenID = Convert.ToInt32(gridView1.GetRowCellValue(e.FocusedRowHandle, "ID"));
				secilenMusteri = musteriDAL.GetByFilter(context, q => q.ID == secilenID);
			}
		}

		private void btnGuncelle_Click(object sender, EventArgs e)
		{
			Musteri musteri = musteriDAL.GetByFilter(context, q => q.ID == secilenMusteri.ID);
			musteri.Adi = txtMusteriAdi.Text;
			musteri.TcNo = txtTcNo.Text;
			musteri.Adres = txtAdres.Text;
			musteri.Tel = txtTelefon.Text;
			musteri.Mail = txtMail.Text;
			musteri.Kullanimdami = chcKullanimdami.Checked;
			musteriDAL.Save(context);
			grdMusteriler.DataSource = musteriDAL.GetAll(context);
			MessageBox.Show("Müşteri Güncellendi");
		}
	}
}