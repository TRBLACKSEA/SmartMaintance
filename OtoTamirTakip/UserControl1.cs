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
	public partial class UserControl1 : UserControl
	{
		
		FrmYeniIsEmriOlustur frm = (FrmYeniIsEmriOlustur)Application.OpenForms["FrmYeniIsEmriOlustur"];
		public UserControl1()
		{
			InitializeComponent();
		}

		private void UserControl1_Load(object sender, EventArgs e)
		{
			txtParcaAdi.Text = "Parça Adı";
			txtParcaAdi.ForeColor = Color.Gray;
			txtBirimFiyati.Text = "0";
			txtBirimFiyati.ForeColor = Color.Gray;
			txtTutari.Text = "0";
			txtTutari.ForeColor = Color.Gray;
		}
		private void Hesapla()
		{
			if(!string.IsNullOrEmpty(txtAdet.Text) && !string.IsNullOrEmpty(txtBirimFiyati.Text))
			{
				txtTutari.Text = (Convert.ToInt32(txtAdet.Text) * Convert.ToInt32(txtBirimFiyati.Text)).ToString();
				//frm.value += Convert.ToDecimal(txtTutari.Text);
				//frm.txtToplamTutar.Text = frm.value.ToString();
			}
			
		}

		private void txtParcaAdi_Click(object sender, EventArgs e)
		{
			if (txtParcaAdi.Text == "")
			{
				txtParcaAdi.ForeColor = Color.Gray;
				txtParcaAdi.Text = "Parça Adı";
			}
			else if(txtParcaAdi.Text=="Parça Adı")
			{
				txtParcaAdi.ForeColor = Color.Black;
				txtParcaAdi.Text = "";
			}
		}

		private void txtBirimFiyati_TextChanged(object sender, EventArgs e)
		{
			if(txtBirimFiyati.Text!="")
			{
				Hesapla();
			}	
		}

		private void txtAdet_TextChanged(object sender, EventArgs e)
		{
			Hesapla();
		}

		private void txtAdet_KeyPress(object sender, KeyPressEventArgs e)
		{
			char ch = e.KeyChar;
			if (!char.IsDigit(ch) && ch != 8 && ch != 46)
			{
				e.Handled = true;
			}
		}

		private void txtBirimFiyati_KeyPress(object sender, KeyPressEventArgs e)
		{
			char ch = e.KeyChar;
			if (!char.IsDigit(ch) && ch != 8 && ch != 46)
			{
				e.Handled = true;
			}
		}

		private void txtParcaAdi_MouseLeave(object sender, EventArgs e)
		{
			if(string.IsNullOrEmpty(txtParcaAdi.Text))
			{
				txtParcaAdi.ForeColor = Color.Gray;
				txtParcaAdi.Text = "Parça Adı";
			}
		}

		private void txtBirimFiyati_MouseLeave(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtBirimFiyati.Text))
			{
				txtBirimFiyati.Text = "0";
				Hesapla();
			}
		}

		private void txtAdet_MouseLeave(object sender, EventArgs e)
		{
			if(string.IsNullOrEmpty(txtAdet.Text) || txtAdet.Text=="0")
			{
				txtAdet.Text = "1";
				Hesapla();
			}
		}

		private void txtTutari_TextChanged(object sender, EventArgs e)
		{

			
		}

	}
}
