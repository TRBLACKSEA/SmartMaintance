
namespace OtoTamirTakip
{
	partial class FrmLogin
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
			this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtSifre = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.chcBeniHatirla = new System.Windows.Forms.CheckBox();
			this.btnGiris = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// txtKullaniciAdi
			// 
			this.txtKullaniciAdi.Location = new System.Drawing.Point(229, 225);
			this.txtKullaniciAdi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txtKullaniciAdi.Name = "txtKullaniciAdi";
			this.txtKullaniciAdi.Size = new System.Drawing.Size(246, 27);
			this.txtKullaniciAdi.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(122, 227);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(102, 19);
			this.label1.TabIndex = 2;
			this.label1.Text = "Kullanıcı Adı:";
			// 
			// txtSifre
			// 
			this.txtSifre.Location = new System.Drawing.Point(229, 257);
			this.txtSifre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txtSifre.Name = "txtSifre";
			this.txtSifre.Size = new System.Drawing.Size(246, 27);
			this.txtSifre.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(178, 260);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 19);
			this.label2.TabIndex = 2;
			this.label2.Text = "Şifre:";
			// 
			// chcBeniHatirla
			// 
			this.chcBeniHatirla.AutoSize = true;
			this.chcBeniHatirla.Location = new System.Drawing.Point(229, 289);
			this.chcBeniHatirla.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.chcBeniHatirla.Name = "chcBeniHatirla";
			this.chcBeniHatirla.Size = new System.Drawing.Size(109, 23);
			this.chcBeniHatirla.TabIndex = 2;
			this.chcBeniHatirla.Text = "Beni Hatırla";
			this.chcBeniHatirla.UseVisualStyleBackColor = true;
			// 
			// btnGiris
			// 
			this.btnGiris.Location = new System.Drawing.Point(229, 314);
			this.btnGiris.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnGiris.Name = "btnGiris";
			this.btnGiris.Size = new System.Drawing.Size(246, 40);
			this.btnGiris.TabIndex = 3;
			this.btnGiris.Text = "Giriş";
			this.btnGiris.UseVisualStyleBackColor = true;
			this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::OtoTamirTakip.Properties.Resources.Adsız1;
			this.pictureBox1.Location = new System.Drawing.Point(-1, 8);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(666, 210);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// FrmLogin
			// 
			this.Appearance.Options.UseFont = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(665, 371);
			this.Controls.Add(this.btnGiris);
			this.Controls.Add(this.chcBeniHatirla);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtSifre);
			this.Controls.Add(this.txtKullaniciAdi);
			this.Controls.Add(this.pictureBox1);
			this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.Name = "FrmLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Oto Tamir Bakım Giriş";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmLogin_FormClosing);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmLogin_FormClosed);
			this.Load += new System.EventHandler(this.FrmLogin_Load);
			this.Shown += new System.EventHandler(this.FrmLogin_Shown);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmLogin_Paint);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		public System.Windows.Forms.TextBox txtKullaniciAdi;
		public System.Windows.Forms.TextBox txtSifre;
		public System.Windows.Forms.CheckBox chcBeniHatirla;
		public System.Windows.Forms.Button btnGiris;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}