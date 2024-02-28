
namespace OtoTamirTakip
{
	partial class FrmPersonelGoruntule
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
			this.components = new System.ComponentModel.Container();
			this.grdKullanici = new DevExpress.XtraGrid.GridControl();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.btnTumu = new System.Windows.Forms.ToolStripMenuItem();
			this.btnKullanimdaOlan = new System.Windows.Forms.ToolStripMenuItem();
			this.btnKullanimdaOlmayan = new System.Windows.Forms.ToolStripMenuItem();
			this.kullaniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colKulaniciAdi = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSifre = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colisAdmin = new DevExpress.XtraGrid.Columns.GridColumn();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnSil = new System.Windows.Forms.Button();
			this.btnGuncelle = new System.Windows.Forms.Button();
			this.chcYonetici = new System.Windows.Forms.CheckBox();
			this.chcAktif = new System.Windows.Forms.CheckBox();
			this.txtSifre = new System.Windows.Forms.TextBox();
			this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			((System.ComponentModel.ISupportInitialize)(this.grdKullanici)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.kullaniciBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// grdKullanici
			// 
			this.grdKullanici.ContextMenuStrip = this.contextMenuStrip1;
			this.grdKullanici.DataSource = this.kullaniciBindingSource;
			this.grdKullanici.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grdKullanici.Location = new System.Drawing.Point(0, 0);
			this.grdKullanici.MainView = this.gridView1;
			this.grdKullanici.Name = "grdKullanici";
			this.grdKullanici.Size = new System.Drawing.Size(1193, 360);
			this.grdKullanici.TabIndex = 0;
			this.grdKullanici.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnTumu,
            this.btnKullanimdaOlan,
            this.btnKullanimdaOlmayan});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(285, 76);
			// 
			// btnTumu
			// 
			this.btnTumu.Name = "btnTumu";
			this.btnTumu.Size = new System.Drawing.Size(284, 24);
			this.btnTumu.Text = "Tümü";
			this.btnTumu.Click += new System.EventHandler(this.btnTumu_Click);
			// 
			// btnKullanimdaOlan
			// 
			this.btnKullanimdaOlan.Name = "btnKullanimdaOlan";
			this.btnKullanimdaOlan.Size = new System.Drawing.Size(284, 24);
			this.btnKullanimdaOlan.Text = "Kullanımda Olanları Göster";
			this.btnKullanimdaOlan.Click += new System.EventHandler(this.btnKullanimdaOlan_Click);
			// 
			// btnKullanimdaOlmayan
			// 
			this.btnKullanimdaOlmayan.Name = "btnKullanimdaOlmayan";
			this.btnKullanimdaOlmayan.Size = new System.Drawing.Size(284, 24);
			this.btnKullanimdaOlmayan.Text = "Kullanımda Olmayanları Göster";
			this.btnKullanimdaOlmayan.Click += new System.EventHandler(this.btnKullanimdaOlmayan_Click);
			// 
			// kullaniciBindingSource
			// 
			this.kullaniciBindingSource.DataSource = typeof(OtoTamirTakip.Entities.Kullanici);
			// 
			// gridView1
			// 
			this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colKulaniciAdi,
            this.colSifre,
            this.colisAdmin});
			this.gridView1.GridControl = this.grdKullanici;
			this.gridView1.Name = "gridView1";
			this.gridView1.OptionsView.ShowAutoFilterRow = true;
			this.gridView1.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridView1_SelectionChanged);
			this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
			// 
			// colID
			// 
			this.colID.FieldName = "ID";
			this.colID.MinWidth = 25;
			this.colID.Name = "colID";
			this.colID.OptionsColumn.AllowEdit = false;
			this.colID.Width = 94;
			// 
			// colKulaniciAdi
			// 
			this.colKulaniciAdi.Caption = "Kullanıcı Adı";
			this.colKulaniciAdi.FieldName = "KulaniciAdi";
			this.colKulaniciAdi.MinWidth = 25;
			this.colKulaniciAdi.Name = "colKulaniciAdi";
			this.colKulaniciAdi.OptionsColumn.AllowEdit = false;
			this.colKulaniciAdi.Visible = true;
			this.colKulaniciAdi.VisibleIndex = 0;
			this.colKulaniciAdi.Width = 94;
			// 
			// colSifre
			// 
			this.colSifre.FieldName = "Sifre";
			this.colSifre.MinWidth = 25;
			this.colSifre.Name = "colSifre";
			this.colSifre.OptionsColumn.AllowEdit = false;
			this.colSifre.Visible = true;
			this.colSifre.VisibleIndex = 1;
			this.colSifre.Width = 94;
			// 
			// colisAdmin
			// 
			this.colisAdmin.Caption = "Yönetici";
			this.colisAdmin.FieldName = "isAdmin";
			this.colisAdmin.MinWidth = 25;
			this.colisAdmin.Name = "colisAdmin";
			this.colisAdmin.OptionsColumn.AllowEdit = false;
			this.colisAdmin.Visible = true;
			this.colisAdmin.VisibleIndex = 2;
			this.colisAdmin.Width = 94;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnSil);
			this.groupBox1.Controls.Add(this.btnGuncelle);
			this.groupBox1.Controls.Add(this.chcYonetici);
			this.groupBox1.Controls.Add(this.chcAktif);
			this.groupBox1.Controls.Add(this.txtSifre);
			this.groupBox1.Controls.Add(this.txtKullaniciAdi);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1193, 86);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Personel Bilgileri";
			// 
			// btnSil
			// 
			this.btnSil.Location = new System.Drawing.Point(1061, 37);
			this.btnSil.Name = "btnSil";
			this.btnSil.Size = new System.Drawing.Size(121, 32);
			this.btnSil.TabIndex = 6;
			this.btnSil.Text = "Sil";
			this.btnSil.UseVisualStyleBackColor = true;
			this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
			// 
			// btnGuncelle
			// 
			this.btnGuncelle.Location = new System.Drawing.Point(943, 38);
			this.btnGuncelle.Name = "btnGuncelle";
			this.btnGuncelle.Size = new System.Drawing.Size(112, 32);
			this.btnGuncelle.TabIndex = 5;
			this.btnGuncelle.Text = "Güncelle";
			this.btnGuncelle.UseVisualStyleBackColor = true;
			this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
			// 
			// chcYonetici
			// 
			this.chcYonetici.AutoSize = true;
			this.chcYonetici.Location = new System.Drawing.Point(745, 41);
			this.chcYonetici.Name = "chcYonetici";
			this.chcYonetici.Size = new System.Drawing.Size(103, 28);
			this.chcYonetici.TabIndex = 3;
			this.chcYonetici.Text = "Yönetici";
			this.chcYonetici.UseVisualStyleBackColor = true;
			// 
			// chcAktif
			// 
			this.chcAktif.AutoSize = true;
			this.chcAktif.Location = new System.Drawing.Point(854, 41);
			this.chcAktif.Name = "chcAktif";
			this.chcAktif.Size = new System.Drawing.Size(72, 28);
			this.chcAktif.TabIndex = 4;
			this.chcAktif.Text = "Aktif";
			this.chcAktif.UseVisualStyleBackColor = true;
			// 
			// txtSifre
			// 
			this.txtSifre.Location = new System.Drawing.Point(493, 39);
			this.txtSifre.Name = "txtSifre";
			this.txtSifre.Size = new System.Drawing.Size(237, 32);
			this.txtSifre.TabIndex = 2;
			// 
			// txtKullaniciAdi
			// 
			this.txtKullaniciAdi.Location = new System.Drawing.Point(145, 39);
			this.txtKullaniciAdi.Name = "txtKullaniciAdi";
			this.txtKullaniciAdi.Size = new System.Drawing.Size(287, 32);
			this.txtKullaniciAdi.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(438, 42);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 24);
			this.label2.TabIndex = 0;
			this.label2.Text = "Şifre:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(24, 42);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(125, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "Kullanıcı Adı:";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.statusStrip1);
			this.panel1.Controls.Add(this.grdKullanici);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 86);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1193, 360);
			this.panel1.TabIndex = 2;
			// 
			// statusStrip1
			// 
			this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.statusStrip1.Location = new System.Drawing.Point(0, 338);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(1193, 22);
			this.statusStrip1.TabIndex = 1;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// FrmPersonelGoruntule
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1193, 446);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "FrmPersonelGoruntule";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmPersonelGoruntule";
			this.Load += new System.EventHandler(this.FrmPersonelGoruntule_Load);
			((System.ComponentModel.ISupportInitialize)(this.grdKullanici)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.kullaniciBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraGrid.GridControl grdKullanici;
		private System.Windows.Forms.BindingSource kullaniciBindingSource;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraGrid.Columns.GridColumn colID;
		private DevExpress.XtraGrid.Columns.GridColumn colKulaniciAdi;
		private DevExpress.XtraGrid.Columns.GridColumn colSifre;
		private DevExpress.XtraGrid.Columns.GridColumn colisAdmin;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnSil;
		private System.Windows.Forms.Button btnGuncelle;
		private System.Windows.Forms.CheckBox chcAktif;
		private System.Windows.Forms.TextBox txtSifre;
		private System.Windows.Forms.TextBox txtKullaniciAdi;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem btnTumu;
		private System.Windows.Forms.ToolStripMenuItem btnKullanimdaOlan;
		private System.Windows.Forms.ToolStripMenuItem btnKullanimdaOlmayan;
		private System.Windows.Forms.CheckBox chcYonetici;
		private System.Windows.Forms.StatusStrip statusStrip1;
	}
}