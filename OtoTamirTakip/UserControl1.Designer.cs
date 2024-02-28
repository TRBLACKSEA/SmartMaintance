
namespace OtoTamirTakip
{
	partial class UserControl1
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtSiraNo = new System.Windows.Forms.TextBox();
			this.txtAdet = new System.Windows.Forms.TextBox();
			this.txtParcaAdi = new System.Windows.Forms.TextBox();
			this.txtBirimFiyati = new System.Windows.Forms.TextBox();
			this.txtTutari = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// txtSiraNo
			// 
			this.txtSiraNo.Enabled = false;
			this.txtSiraNo.Location = new System.Drawing.Point(5, 5);
			this.txtSiraNo.Margin = new System.Windows.Forms.Padding(5);
			this.txtSiraNo.Name = "txtSiraNo";
			this.txtSiraNo.Size = new System.Drawing.Size(83, 34);
			this.txtSiraNo.TabIndex = 0;
			this.txtSiraNo.Text = "1";
			this.txtSiraNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtAdet
			// 
			this.txtAdet.Location = new System.Drawing.Point(91, 5);
			this.txtAdet.Margin = new System.Windows.Forms.Padding(5);
			this.txtAdet.Name = "txtAdet";
			this.txtAdet.Size = new System.Drawing.Size(134, 34);
			this.txtAdet.TabIndex = 0;
			this.txtAdet.Text = "1";
			this.txtAdet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtAdet.TextChanged += new System.EventHandler(this.txtAdet_TextChanged);
			this.txtAdet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdet_KeyPress);
			this.txtAdet.MouseLeave += new System.EventHandler(this.txtAdet_MouseLeave);
			// 
			// txtParcaAdi
			// 
			this.txtParcaAdi.Location = new System.Drawing.Point(228, 5);
			this.txtParcaAdi.Margin = new System.Windows.Forms.Padding(5);
			this.txtParcaAdi.Name = "txtParcaAdi";
			this.txtParcaAdi.Size = new System.Drawing.Size(700, 34);
			this.txtParcaAdi.TabIndex = 0;
			this.txtParcaAdi.Click += new System.EventHandler(this.txtParcaAdi_Click);
			this.txtParcaAdi.MouseLeave += new System.EventHandler(this.txtParcaAdi_MouseLeave);
			// 
			// txtBirimFiyati
			// 
			this.txtBirimFiyati.Location = new System.Drawing.Point(931, 5);
			this.txtBirimFiyati.Margin = new System.Windows.Forms.Padding(5);
			this.txtBirimFiyati.Name = "txtBirimFiyati";
			this.txtBirimFiyati.Size = new System.Drawing.Size(130, 34);
			this.txtBirimFiyati.TabIndex = 0;
			this.txtBirimFiyati.TextChanged += new System.EventHandler(this.txtBirimFiyati_TextChanged);
			this.txtBirimFiyati.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBirimFiyati_KeyPress);
			this.txtBirimFiyati.MouseLeave += new System.EventHandler(this.txtBirimFiyati_MouseLeave);
			// 
			// txtTutari
			// 
			this.txtTutari.Enabled = false;
			this.txtTutari.Location = new System.Drawing.Point(1064, 5);
			this.txtTutari.Margin = new System.Windows.Forms.Padding(5);
			this.txtTutari.Name = "txtTutari";
			this.txtTutari.Size = new System.Drawing.Size(140, 34);
			this.txtTutari.TabIndex = 0;
			// 
			// UserControl1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.txtTutari);
			this.Controls.Add(this.txtBirimFiyati);
			this.Controls.Add(this.txtParcaAdi);
			this.Controls.Add(this.txtAdet);
			this.Controls.Add(this.txtSiraNo);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "UserControl1";
			this.Size = new System.Drawing.Size(1209, 40);
			this.Load += new System.EventHandler(this.UserControl1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		public System.Windows.Forms.TextBox txtAdet;
		public System.Windows.Forms.TextBox txtParcaAdi;
		public System.Windows.Forms.TextBox txtBirimFiyati;
		public System.Windows.Forms.TextBox txtTutari;
		public System.Windows.Forms.TextBox txtSiraNo;
	}
}
