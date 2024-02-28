
namespace OtoTamirTakip
{
	partial class FrmCariGoruntule
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCariGoruntule));
			this.grdMusteriler = new DevExpress.XtraGrid.GridControl();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.btnTumu = new System.Windows.Forms.ToolStripMenuItem();
			this.btnKullanimdaOlan = new System.Windows.Forms.ToolStripMenuItem();
			this.btnKullanimdaOlmayan = new System.Windows.Forms.ToolStripMenuItem();
			this.musteriBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colAdi = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTcNo = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colAdres = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTel = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colMail = new DevExpress.XtraGrid.Columns.GridColumn();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnGuncelle = new System.Windows.Forms.Button();
			this.chcKullanimdami = new System.Windows.Forms.CheckBox();
			this.txtAdres = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtMail = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtTcNo = new System.Windows.Forms.TextBox();
			this.txtTelefon = new System.Windows.Forms.TextBox();
			this.lblTcNo = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtMusteriAdi = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			((System.ComponentModel.ISupportInitialize)(this.grdMusteriler)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.musteriBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// grdMusteriler
			// 
			this.grdMusteriler.ContextMenuStrip = this.contextMenuStrip1;
			this.grdMusteriler.DataSource = this.musteriBindingSource;
			this.grdMusteriler.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grdMusteriler.Location = new System.Drawing.Point(0, 0);
			this.grdMusteriler.MainView = this.gridView1;
			this.grdMusteriler.Name = "grdMusteriler";
			this.grdMusteriler.Size = new System.Drawing.Size(936, 313);
			this.grdMusteriler.TabIndex = 0;
			this.grdMusteriler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
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
			// musteriBindingSource
			// 
			this.musteriBindingSource.DataSource = typeof(OtoTamirTakip.Entities.Musteri);
			// 
			// gridView1
			// 
			this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colAdi,
            this.colTcNo,
            this.colAdres,
            this.colTel,
            this.colMail});
			this.gridView1.GridControl = this.grdMusteriler;
			this.gridView1.Name = "gridView1";
			this.gridView1.OptionsView.ShowAutoFilterRow = true;
			this.gridView1.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridView1_SelectionChanged);
			this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
			// 
			// colID
			// 
			this.colID.Caption = "ID";
			this.colID.FieldName = "ID";
			this.colID.MinWidth = 25;
			this.colID.Name = "colID";
			this.colID.OptionsColumn.AllowEdit = false;
			this.colID.Width = 94;
			// 
			// colAdi
			// 
			this.colAdi.Caption = "Müşteri Adı";
			this.colAdi.FieldName = "Adi";
			this.colAdi.MinWidth = 25;
			this.colAdi.Name = "colAdi";
			this.colAdi.OptionsColumn.AllowEdit = false;
			this.colAdi.Visible = true;
			this.colAdi.VisibleIndex = 0;
			this.colAdi.Width = 94;
			// 
			// colTcNo
			// 
			this.colTcNo.Caption = "Tc No";
			this.colTcNo.FieldName = "TcNo";
			this.colTcNo.MinWidth = 25;
			this.colTcNo.Name = "colTcNo";
			this.colTcNo.OptionsColumn.AllowEdit = false;
			this.colTcNo.Visible = true;
			this.colTcNo.VisibleIndex = 1;
			this.colTcNo.Width = 94;
			// 
			// colAdres
			// 
			this.colAdres.Caption = "Müşteri Adresi";
			this.colAdres.FieldName = "Adres";
			this.colAdres.MinWidth = 25;
			this.colAdres.Name = "colAdres";
			this.colAdres.OptionsColumn.AllowEdit = false;
			this.colAdres.Visible = true;
			this.colAdres.VisibleIndex = 2;
			this.colAdres.Width = 94;
			// 
			// colTel
			// 
			this.colTel.Caption = "Telefon";
			this.colTel.FieldName = "Tel";
			this.colTel.MinWidth = 25;
			this.colTel.Name = "colTel";
			this.colTel.OptionsColumn.AllowEdit = false;
			this.colTel.Visible = true;
			this.colTel.VisibleIndex = 3;
			this.colTel.Width = 94;
			// 
			// colMail
			// 
			this.colMail.Caption = "Mail";
			this.colMail.FieldName = "Mail";
			this.colMail.MinWidth = 25;
			this.colMail.Name = "colMail";
			this.colMail.OptionsColumn.AllowEdit = false;
			this.colMail.Visible = true;
			this.colMail.VisibleIndex = 4;
			this.colMail.Width = 94;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnGuncelle);
			this.groupBox1.Controls.Add(this.chcKullanimdami);
			this.groupBox1.Controls.Add(this.txtAdres);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtMail);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.txtTcNo);
			this.groupBox1.Controls.Add(this.txtTelefon);
			this.groupBox1.Controls.Add(this.lblTcNo);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txtMusteriAdi);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(936, 229);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Müşteri Bilgileri";
			// 
			// btnGuncelle
			// 
			this.btnGuncelle.Location = new System.Drawing.Point(788, 164);
			this.btnGuncelle.Name = "btnGuncelle";
			this.btnGuncelle.Size = new System.Drawing.Size(131, 43);
			this.btnGuncelle.TabIndex = 7;
			this.btnGuncelle.Text = "Güncelle";
			this.btnGuncelle.UseVisualStyleBackColor = true;
			this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
			// 
			// chcKullanimdami
			// 
			this.chcKullanimdami.AutoSize = true;
			this.chcKullanimdami.Location = new System.Drawing.Point(589, 123);
			this.chcKullanimdami.Name = "chcKullanimdami";
			this.chcKullanimdami.Size = new System.Drawing.Size(131, 28);
			this.chcKullanimdami.TabIndex = 6;
			this.chcKullanimdami.Text = "Kullanımda";
			this.chcKullanimdami.UseVisualStyleBackColor = true;
			// 
			// txtAdres
			// 
			this.txtAdres.Location = new System.Drawing.Point(160, 107);
			this.txtAdres.Multiline = true;
			this.txtAdres.Name = "txtAdres";
			this.txtAdres.Size = new System.Drawing.Size(330, 116);
			this.txtAdres.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(11, 110);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(143, 24);
			this.label3.TabIndex = 0;
			this.label3.Text = "Müşteri Adresi:";
			// 
			// txtMail
			// 
			this.txtMail.Location = new System.Drawing.Point(589, 69);
			this.txtMail.Name = "txtMail";
			this.txtMail.Size = new System.Drawing.Size(330, 32);
			this.txtMail.TabIndex = 5;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(530, 72);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(53, 24);
			this.label5.TabIndex = 0;
			this.label5.Text = "Mail:";
			// 
			// txtTcNo
			// 
			this.txtTcNo.Location = new System.Drawing.Point(160, 69);
			this.txtTcNo.Name = "txtTcNo";
			this.txtTcNo.Size = new System.Drawing.Size(330, 32);
			this.txtTcNo.TabIndex = 2;
			// 
			// txtTelefon
			// 
			this.txtTelefon.Location = new System.Drawing.Point(589, 31);
			this.txtTelefon.Name = "txtTelefon";
			this.txtTelefon.Size = new System.Drawing.Size(330, 32);
			this.txtTelefon.TabIndex = 4;
			// 
			// lblTcNo
			// 
			this.lblTcNo.AutoSize = true;
			this.lblTcNo.Location = new System.Drawing.Point(86, 72);
			this.lblTcNo.Name = "lblTcNo";
			this.lblTcNo.Size = new System.Drawing.Size(68, 24);
			this.lblTcNo.TabIndex = 0;
			this.lblTcNo.Text = "Tc No:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(499, 34);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(84, 24);
			this.label4.TabIndex = 0;
			this.label4.Text = "Telefon:";
			// 
			// txtMusteriAdi
			// 
			this.txtMusteriAdi.Location = new System.Drawing.Point(160, 31);
			this.txtMusteriAdi.Name = "txtMusteriAdi";
			this.txtMusteriAdi.Size = new System.Drawing.Size(330, 32);
			this.txtMusteriAdi.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(38, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(116, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "Müşteri Adı:";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.statusStrip1);
			this.panel1.Controls.Add(this.grdMusteriler);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 229);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(936, 313);
			this.panel1.TabIndex = 2;
			// 
			// statusStrip1
			// 
			this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.statusStrip1.Location = new System.Drawing.Point(0, 291);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(936, 22);
			this.statusStrip1.TabIndex = 1;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// FrmCariGoruntule
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(936, 542);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("FrmCariGoruntule.IconOptions.LargeImage")));
			this.Name = "FrmCariGoruntule";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Müşteriler";
			this.Load += new System.EventHandler(this.FrmCariGoruntule_Load);
			((System.ComponentModel.ISupportInitialize)(this.grdMusteriler)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.musteriBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraGrid.GridControl grdMusteriler;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private System.Windows.Forms.BindingSource musteriBindingSource;
		private DevExpress.XtraGrid.Columns.GridColumn colID;
		private DevExpress.XtraGrid.Columns.GridColumn colAdi;
		private DevExpress.XtraGrid.Columns.GridColumn colTcNo;
		private DevExpress.XtraGrid.Columns.GridColumn colAdres;
		private DevExpress.XtraGrid.Columns.GridColumn colTel;
		private DevExpress.XtraGrid.Columns.GridColumn colMail;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox chcKullanimdami;
		private System.Windows.Forms.TextBox txtAdres;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtMail;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtTcNo;
		private System.Windows.Forms.TextBox txtTelefon;
		private System.Windows.Forms.Label lblTcNo;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtMusteriAdi;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnGuncelle;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem btnTumu;
		private System.Windows.Forms.ToolStripMenuItem btnKullanimdaOlan;
		private System.Windows.Forms.ToolStripMenuItem btnKullanimdaOlmayan;
		private System.Windows.Forms.StatusStrip statusStrip1;
	}
}