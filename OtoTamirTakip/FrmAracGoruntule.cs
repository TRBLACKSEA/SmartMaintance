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
	public partial class FrmAracGoruntule : DevExpress.XtraEditors.XtraForm
	{
		OtoTamirTakipContext context = new OtoTamirTakipContext();
		MusteriDAL musteriDAL = new MusteriDAL();
		AracDAL aracDAL = new AracDAL();
		int secilenID;
		Arac secilenArac;
		public FrmAracGoruntule()
		{
			InitializeComponent();
		}

		private void FrmAracGoruntule_Load(object sender, EventArgs e)
		{
			gridLookUpIsım.Properties.DataSource = musteriDAL.GetAll(context);
			grdAraclar.DataSource = aracDAL.GetAll(context);
			txtPlakaNo.Focus();
			
		}

		private void grdAraclar_Click(object sender, EventArgs e)
		{

		}

		private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
		{
			if(e.FocusedRowHandle>-1)
			{
				//secilenIndex = e.FocusedRowHandle;
				secilenID = Convert.ToInt32(gridView1.GetRowCellValue(e.FocusedRowHandle, "ID"));
				secilenArac = aracDAL.GetByFilter(context, q => q.ID == secilenID);
			}
		}

		private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
		{
			if (gridView1.RowCount > 0)
			{
				
				txtPlakaNo.Text = secilenArac.PlakaNo;
				cmbAracTipi.Text = secilenArac.AracTipi;
				txtAracModel.Text = secilenArac.AracModel;
				txtRenk.Text = secilenArac.Renk;
				txtSaseNo.Text = secilenArac.SaseNo;
				chcKullanimda.Checked = secilenArac.Kullanimdami;
				Musteri secilenMusteri = musteriDAL.GetByFilter(context, q => q.Adi == secilenArac.Musteri.Adi);
				//edit value'yu bulmak için value member ı kullanmak yani ID değerini kullanmak gerekir
				gridLookUpIsım.EditValue = secilenMusteri.ID;
				
			}
		}

		private void btnGuncelle_Click(object sender, EventArgs e)
		{
			Arac guncellenecekArac = aracDAL.GetByFilter(context, q => q.ID == secilenArac.ID);
			guncellenecekArac.PlakaNo = txtPlakaNo.Text;
			guncellenecekArac.AracTipi = cmbAracTipi.Text;
			guncellenecekArac.AracModel = txtAracModel.Text;
			guncellenecekArac.Renk = txtRenk.Text;
			guncellenecekArac.SaseNo = txtSaseNo.Text;
			int secilenMusteriID = Convert.ToInt32(gridLookUpIsım.EditValue);
			guncellenecekArac.MusteriID = secilenMusteriID;
			guncellenecekArac.Musteri = musteriDAL.GetByFilter(context, q => q.ID == secilenMusteriID);
			guncellenecekArac.GarantiBaslangic = dtGarantiBaslangic.Value;
			guncellenecekArac.Kullanimdami = chcKullanimda.Checked;
			aracDAL.Save(context);
			grdAraclar.DataSource = aracDAL.GetAll(context);
			MessageBox.Show("Araç Güncellendi");
		}

		private void btnTumu_Click(object sender, EventArgs e)
		{
			grdAraclar.DataSource = aracDAL.GetAll(context);
		}

		private void btnKullanimdaOlan_Click(object sender, EventArgs e)
		{
			grdAraclar.DataSource = context.Araclar.Where(q => q.Kullanimdami==true).ToList();
		}

		private void btnKullanimdaOlmayan_Click(object sender, EventArgs e)
		{
			grdAraclar.DataSource = context.Araclar.Where(q => q.Kullanimdami == false).ToList();
		}
	}
}