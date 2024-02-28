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
	public partial class FrmAracEkle : DevExpress.XtraEditors.XtraForm
	{
		OtoTamirTakipContext context = new OtoTamirTakipContext();
		AracDAL aracDAL = new AracDAL();
		int secilenMusteriID;
		public FrmAracEkle()
		{
			InitializeComponent();
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}



		private void FrmPlakalar_Load(object sender, EventArgs e)
		{

			gridLookUpIsım.Properties.DataSource = context.Musteriler.ToList();
		}

		private void simpleButton1_Click(object sender, EventArgs e)
		{
			Arac arac = new Arac()
			{
				PlakaNo = txtPlakaNo.Text,
				AracTipi = cmbAracTipi.Text,
				AracModel = txtAracModel.Text,
				Renk = txtRenk.Text,
				SaseNo = txtSaseNo.Text,
				GarantiBaslangic = dtGarantiBaslangic.Value,
				MusteriID = secilenMusteriID,
				Kullanimdami=true
			};
			arac.Renk = string.IsNullOrEmpty(arac.Renk) ? "Renk Belirtilmemiş" : txtRenk.Text;
			aracDAL.Add(context, arac);
			aracDAL.Save(context);
			MessageBox.Show("Araç Eklendi");
			this.Close();
		}

		private void gridLookUpEdit1View_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
		{
			secilenMusteriID = Convert.ToInt32(gridLookUpEdit1View.GetRowCellValue(e.FocusedRowHandle, "ID"));
		}
	}
}