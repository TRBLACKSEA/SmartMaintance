
namespace OtoTamirTakip
{
	partial class FrmKullaniciEkle
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKullaniciEkle));
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.txtKullaniciAdi = new DevExpress.XtraEditors.TextEdit();
			this.txtSifre = new DevExpress.XtraEditors.TextEdit();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.chckYoneticiMi = new System.Windows.Forms.CheckBox();
			this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
			this.chcAktif = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdi.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// labelControl1
			// 
			this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelControl1.Appearance.Options.UseFont = true;
			this.labelControl1.Location = new System.Drawing.Point(17, 15);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(130, 28);
			this.labelControl1.TabIndex = 1;
			this.labelControl1.Text = "Kullanıcı Adı:";
			// 
			// txtKullaniciAdi
			// 
			this.txtKullaniciAdi.Location = new System.Drawing.Point(153, 12);
			this.txtKullaniciAdi.Name = "txtKullaniciAdi";
			this.txtKullaniciAdi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtKullaniciAdi.Properties.Appearance.Options.UseFont = true;
			this.txtKullaniciAdi.Size = new System.Drawing.Size(348, 34);
			this.txtKullaniciAdi.TabIndex = 0;
			// 
			// txtSifre
			// 
			this.txtSifre.Location = new System.Drawing.Point(153, 52);
			this.txtSifre.Name = "txtSifre";
			this.txtSifre.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtSifre.Properties.Appearance.Options.UseFont = true;
			this.txtSifre.Size = new System.Drawing.Size(348, 34);
			this.txtSifre.TabIndex = 1;
			// 
			// labelControl2
			// 
			this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelControl2.Appearance.Options.UseFont = true;
			this.labelControl2.Location = new System.Drawing.Point(94, 55);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(53, 28);
			this.labelControl2.TabIndex = 1;
			this.labelControl2.Text = "Şifre:";
			// 
			// chckYoneticiMi
			// 
			this.chckYoneticiMi.AutoSize = true;
			this.chckYoneticiMi.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.chckYoneticiMi.Location = new System.Drawing.Point(153, 92);
			this.chckYoneticiMi.Name = "chckYoneticiMi";
			this.chckYoneticiMi.Size = new System.Drawing.Size(117, 33);
			this.chckYoneticiMi.TabIndex = 2;
			this.chckYoneticiMi.Text = "Yönetici";
			this.chckYoneticiMi.UseVisualStyleBackColor = true;
			// 
			// btnKaydet
			// 
			this.btnKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnKaydet.Appearance.Options.UseFont = true;
			this.btnKaydet.Location = new System.Drawing.Point(338, 133);
			this.btnKaydet.Name = "btnKaydet";
			this.btnKaydet.Size = new System.Drawing.Size(161, 50);
			this.btnKaydet.TabIndex = 3;
			this.btnKaydet.Text = "Kaydet";
			this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
			// 
			// chcAktif
			// 
			this.chcAktif.AutoSize = true;
			this.chcAktif.Checked = true;
			this.chcAktif.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chcAktif.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.chcAktif.Location = new System.Drawing.Point(276, 92);
			this.chcAktif.Name = "chcAktif";
			this.chcAktif.Size = new System.Drawing.Size(82, 33);
			this.chcAktif.TabIndex = 2;
			this.chcAktif.Text = "Aktif";
			this.chcAktif.UseVisualStyleBackColor = true;
			// 
			// FrmKullaniciEkle
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(511, 195);
			this.Controls.Add(this.btnKaydet);
			this.Controls.Add(this.chcAktif);
			this.Controls.Add(this.chckYoneticiMi);
			this.Controls.Add(this.labelControl2);
			this.Controls.Add(this.labelControl1);
			this.Controls.Add(this.txtSifre);
			this.Controls.Add(this.txtKullaniciAdi);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("FrmKullaniciEkle.IconOptions.LargeImage")));
			this.Name = "FrmKullaniciEkle";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Yeni Kullanıcı Ekle";
			this.Load += new System.EventHandler(this.FrmKullaniciEkle_Load);
			((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdi.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraEditors.TextEdit txtKullaniciAdi;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraEditors.TextEdit txtSifre;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private System.Windows.Forms.CheckBox chckYoneticiMi;
		private DevExpress.XtraEditors.SimpleButton btnKaydet;
		private System.Windows.Forms.CheckBox chcAktif;
	}
}