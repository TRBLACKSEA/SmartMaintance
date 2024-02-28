
namespace OtoTamirTakip
{
	partial class FrmLisansGiris
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLisansGiris));
			this.txtKarsiKod = new System.Windows.Forms.TextBox();
			this.txtLisansAnahtari = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.btnKarsiKodOlustur = new System.Windows.Forms.Button();
			this.btnLisansla = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtKarsiKod
			// 
			this.txtKarsiKod.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtKarsiKod.Location = new System.Drawing.Point(169, 12);
			this.txtKarsiKod.Name = "txtKarsiKod";
			this.txtKarsiKod.Size = new System.Drawing.Size(645, 32);
			this.txtKarsiKod.TabIndex = 6;
			// 
			// txtLisansAnahtari
			// 
			this.txtLisansAnahtari.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtLisansAnahtari.Location = new System.Drawing.Point(169, 50);
			this.txtLisansAnahtari.Name = "txtLisansAnahtari";
			this.txtLisansAnahtari.Size = new System.Drawing.Size(645, 32);
			this.txtLisansAnahtari.TabIndex = 7;
			this.txtLisansAnahtari.TextChanged += new System.EventHandler(this.txtLisansAnahtari_TextChanged);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label10.Location = new System.Drawing.Point(52, 15);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(101, 24);
			this.label10.TabIndex = 4;
			this.label10.Text = "Karşı Kod:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label5.Location = new System.Drawing.Point(10, 53);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(153, 24);
			this.label5.TabIndex = 5;
			this.label5.Text = "Lisans Anahtarı:";
			// 
			// btnKarsiKodOlustur
			// 
			this.btnKarsiKodOlustur.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnKarsiKodOlustur.Location = new System.Drawing.Point(169, 88);
			this.btnKarsiKodOlustur.Name = "btnKarsiKodOlustur";
			this.btnKarsiKodOlustur.Size = new System.Drawing.Size(340, 36);
			this.btnKarsiKodOlustur.TabIndex = 9;
			this.btnKarsiKodOlustur.Text = "Karşı Kod Oluştur";
			this.btnKarsiKodOlustur.UseVisualStyleBackColor = true;
			this.btnKarsiKodOlustur.Click += new System.EventHandler(this.btnKarsiKodOlustur_Click);
			// 
			// btnLisansla
			// 
			this.btnLisansla.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnLisansla.Location = new System.Drawing.Point(515, 88);
			this.btnLisansla.Name = "btnLisansla";
			this.btnLisansla.Size = new System.Drawing.Size(299, 36);
			this.btnLisansla.TabIndex = 9;
			this.btnLisansla.Text = "Lisansla";
			this.btnLisansla.UseVisualStyleBackColor = true;
			this.btnLisansla.Click += new System.EventHandler(this.btnLisansla_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.ForeColor = System.Drawing.Color.Red;
			this.label1.Location = new System.Drawing.Point(165, 131);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(601, 24);
			this.label1.TabIndex = 5;
			this.label1.Text = "Uyarı: Lisans Anahtarınız Yok ise Yazılım Geliştiricisine Başvurunuz";
			// 
			// FrmLisansGiris
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(826, 163);
			this.Controls.Add(this.btnLisansla);
			this.Controls.Add(this.btnKarsiKodOlustur);
			this.Controls.Add(this.txtKarsiKod);
			this.Controls.Add(this.txtLisansAnahtari);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label5);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FrmLisansGiris";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Lisans Aktivasyonu";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmLisansGiris_FormClosed);
			this.Load += new System.EventHandler(this.FrmLisansGiris_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtKarsiKod;
		private System.Windows.Forms.TextBox txtLisansAnahtari;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnKarsiKodOlustur;
		private System.Windows.Forms.Button btnLisansla;
		private System.Windows.Forms.Label label1;
	}
}