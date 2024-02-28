
namespace OtoTamirTakip
{
	partial class FrmAracGoruntule
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAracGoruntule));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.chcKullanimda = new System.Windows.Forms.CheckBox();
			this.dtGarantiBaslangic = new System.Windows.Forms.DateTimePicker();
			this.btnGuncelle = new System.Windows.Forms.Button();
			this.gridLookUpIsım = new DevExpress.XtraEditors.GridLookUpEdit();
			this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.Adi = new DevExpress.XtraGrid.Columns.GridColumn();
			this.TcNo = new DevExpress.XtraGrid.Columns.GridColumn();
			this.Adres = new DevExpress.XtraGrid.Columns.GridColumn();
			this.Telefon = new DevExpress.XtraGrid.Columns.GridColumn();
			this.EPosta = new DevExpress.XtraGrid.Columns.GridColumn();
			this.PlakaID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.cmbAracTipi = new DevExpress.XtraEditors.ComboBoxEdit();
			this.txtAracModel = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtSaseNo = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtRenk = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtPlakaNo = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.grdAraclar = new DevExpress.XtraGrid.GridControl();
			this.aracBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPlakaNo = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colAracTipi = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colAracModel = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colMusteriID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colMusteri = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colRenk = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSaseNo = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colGarantiBaslangic = new DevExpress.XtraGrid.Columns.GridColumn();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.btnTumu = new System.Windows.Forms.ToolStripMenuItem();
			this.btnKullanimdaOlan = new System.Windows.Forms.ToolStripMenuItem();
			this.btnKullanimdaOlmayan = new System.Windows.Forms.ToolStripMenuItem();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridLookUpIsım.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmbAracTipi.Properties)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdAraclar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.aracBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.chcKullanimda);
			this.groupBox1.Controls.Add(this.dtGarantiBaslangic);
			this.groupBox1.Controls.Add(this.btnGuncelle);
			this.groupBox1.Controls.Add(this.gridLookUpIsım);
			this.groupBox1.Controls.Add(this.cmbAracTipi);
			this.groupBox1.Controls.Add(this.txtAracModel);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.txtSaseNo);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.txtRenk);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txtPlakaNo);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1353, 140);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Araç Bilgileri";
			// 
			// chcKullanimda
			// 
			this.chcKullanimda.AutoSize = true;
			this.chcKullanimda.Location = new System.Drawing.Point(1030, 64);
			this.chcKullanimda.Name = "chcKullanimda";
			this.chcKullanimda.Size = new System.Drawing.Size(131, 28);
			this.chcKullanimda.TabIndex = 8;
			this.chcKullanimda.Text = "Kullanımda";
			this.chcKullanimda.UseVisualStyleBackColor = true;
			// 
			// dtGarantiBaslangic
			// 
			this.dtGarantiBaslangic.CalendarFont = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.dtGarantiBaslangic.Location = new System.Drawing.Point(1030, 20);
			this.dtGarantiBaslangic.Name = "dtGarantiBaslangic";
			this.dtGarantiBaslangic.Size = new System.Drawing.Size(301, 32);
			this.dtGarantiBaslangic.TabIndex = 7;
			// 
			// btnGuncelle
			// 
			this.btnGuncelle.Location = new System.Drawing.Point(1173, 98);
			this.btnGuncelle.Name = "btnGuncelle";
			this.btnGuncelle.Size = new System.Drawing.Size(158, 35);
			this.btnGuncelle.TabIndex = 9;
			this.btnGuncelle.Text = "Güncelle";
			this.btnGuncelle.UseVisualStyleBackColor = true;
			this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
			// 
			// gridLookUpIsım
			// 
			this.gridLookUpIsım.Location = new System.Drawing.Point(580, 99);
			this.gridLookUpIsım.Name = "gridLookUpIsım";
			this.gridLookUpIsım.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.gridLookUpIsım.Properties.Appearance.Options.UseFont = true;
			this.gridLookUpIsım.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.gridLookUpIsım.Properties.DisplayMember = "Adi";
			this.gridLookUpIsım.Properties.NullText = "";
			this.gridLookUpIsım.Properties.PopupView = this.gridLookUpEdit1View;
			this.gridLookUpIsım.Properties.ValueMember = "ID";
			this.gridLookUpIsım.Size = new System.Drawing.Size(297, 34);
			this.gridLookUpIsım.TabIndex = 6;
			// 
			// gridLookUpEdit1View
			// 
			this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.Adi,
            this.TcNo,
            this.Adres,
            this.Telefon,
            this.EPosta,
            this.PlakaID});
			this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
			this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
			this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.gridLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
			this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
			// 
			// ID
			// 
			this.ID.Caption = "ID";
			this.ID.FieldName = "ID";
			this.ID.Name = "ID";
			// 
			// Adi
			// 
			this.Adi.Caption = "Adı";
			this.Adi.FieldName = "Adi";
			this.Adi.Name = "Adi";
			this.Adi.Visible = true;
			this.Adi.VisibleIndex = 0;
			// 
			// TcNo
			// 
			this.TcNo.Caption = "Tc No";
			this.TcNo.FieldName = "TcNo";
			this.TcNo.Name = "TcNo";
			this.TcNo.Visible = true;
			this.TcNo.VisibleIndex = 1;
			// 
			// Adres
			// 
			this.Adres.Caption = "Adres";
			this.Adres.FieldName = "Adres";
			this.Adres.Name = "Adres";
			// 
			// Telefon
			// 
			this.Telefon.Caption = "Telefon";
			this.Telefon.FieldName = "Telefon";
			this.Telefon.Name = "Telefon";
			// 
			// EPosta
			// 
			this.EPosta.Caption = "E-Posta";
			this.EPosta.FieldName = "EPosta";
			this.EPosta.Name = "EPosta";
			// 
			// PlakaID
			// 
			this.PlakaID.Caption = "Plaka ID";
			this.PlakaID.FieldName = "PlakaID";
			this.PlakaID.Name = "PlakaID";
			// 
			// cmbAracTipi
			// 
			this.cmbAracTipi.Location = new System.Drawing.Point(167, 58);
			this.cmbAracTipi.Name = "cmbAracTipi";
			this.cmbAracTipi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.cmbAracTipi.Properties.Appearance.Options.UseFont = true;
			this.cmbAracTipi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cmbAracTipi.Properties.Items.AddRange(new object[] {
            "Binek",
            "Ticari",
            "Kamyonet"});
			this.cmbAracTipi.Properties.PopupSizeable = true;
			this.cmbAracTipi.Size = new System.Drawing.Size(297, 34);
			this.cmbAracTipi.TabIndex = 2;
			// 
			// txtAracModel
			// 
			this.txtAracModel.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtAracModel.Location = new System.Drawing.Point(167, 99);
			this.txtAracModel.Name = "txtAracModel";
			this.txtAracModel.Size = new System.Drawing.Size(297, 35);
			this.txtAracModel.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(30, 102);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(139, 29);
			this.label3.TabIndex = 0;
			this.label3.Text = "Araç Model:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(56, 61);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(113, 29);
			this.label2.TabIndex = 0;
			this.label2.Text = "Araç Tipi:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label6.Location = new System.Drawing.Point(475, 102);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(99, 29);
			this.label6.TabIndex = 0;
			this.label6.Text = "Müşteri:";
			// 
			// txtSaseNo
			// 
			this.txtSaseNo.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtSaseNo.Location = new System.Drawing.Point(580, 58);
			this.txtSaseNo.Name = "txtSaseNo";
			this.txtSaseNo.Size = new System.Drawing.Size(297, 35);
			this.txtSaseNo.TabIndex = 5;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label5.Location = new System.Drawing.Point(466, 61);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(108, 29);
			this.label5.TabIndex = 0;
			this.label5.Text = "Şase No:";
			// 
			// txtRenk
			// 
			this.txtRenk.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtRenk.Location = new System.Drawing.Point(580, 17);
			this.txtRenk.Name = "txtRenk";
			this.txtRenk.Size = new System.Drawing.Size(297, 35);
			this.txtRenk.TabIndex = 4;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label7.Location = new System.Drawing.Point(883, 23);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(144, 29);
			this.label7.TabIndex = 0;
			this.label7.Text = "Garanti Baş:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.Location = new System.Drawing.Point(500, 20);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(74, 29);
			this.label4.TabIndex = 0;
			this.label4.Text = "Renk:";
			// 
			// txtPlakaNo
			// 
			this.txtPlakaNo.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtPlakaNo.Location = new System.Drawing.Point(167, 17);
			this.txtPlakaNo.Name = "txtPlakaNo";
			this.txtPlakaNo.Size = new System.Drawing.Size(297, 35);
			this.txtPlakaNo.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(92, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(77, 29);
			this.label1.TabIndex = 0;
			this.label1.Text = "Plaka:";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.statusStrip1);
			this.panel1.Controls.Add(this.grdAraclar);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 140);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1353, 361);
			this.panel1.TabIndex = 2;
			// 
			// statusStrip1
			// 
			this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.statusStrip1.Location = new System.Drawing.Point(0, 339);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(1353, 22);
			this.statusStrip1.TabIndex = 2;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// grdAraclar
			// 
			this.grdAraclar.DataSource = this.aracBindingSource;
			this.grdAraclar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grdAraclar.Location = new System.Drawing.Point(0, 0);
			this.grdAraclar.MainView = this.gridView1;
			this.grdAraclar.Name = "grdAraclar";
			this.grdAraclar.Size = new System.Drawing.Size(1353, 361);
			this.grdAraclar.TabIndex = 1;
			this.grdAraclar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// aracBindingSource
			// 
			this.aracBindingSource.DataSource = typeof(OtoTamirTakip.Entities.Arac);
			// 
			// gridView1
			// 
			this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colPlakaNo,
            this.colAracTipi,
            this.colAracModel,
            this.colMusteriID,
            this.colMusteri,
            this.colRenk,
            this.colSaseNo,
            this.colGarantiBaslangic});
			this.gridView1.GridControl = this.grdAraclar;
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
			// colPlakaNo
			// 
			this.colPlakaNo.FieldName = "PlakaNo";
			this.colPlakaNo.MinWidth = 25;
			this.colPlakaNo.Name = "colPlakaNo";
			this.colPlakaNo.OptionsColumn.AllowEdit = false;
			this.colPlakaNo.Visible = true;
			this.colPlakaNo.VisibleIndex = 0;
			this.colPlakaNo.Width = 94;
			// 
			// colAracTipi
			// 
			this.colAracTipi.FieldName = "AracTipi";
			this.colAracTipi.MinWidth = 25;
			this.colAracTipi.Name = "colAracTipi";
			this.colAracTipi.OptionsColumn.AllowEdit = false;
			this.colAracTipi.Visible = true;
			this.colAracTipi.VisibleIndex = 1;
			this.colAracTipi.Width = 94;
			// 
			// colAracModel
			// 
			this.colAracModel.FieldName = "AracModel";
			this.colAracModel.MinWidth = 25;
			this.colAracModel.Name = "colAracModel";
			this.colAracModel.OptionsColumn.AllowEdit = false;
			this.colAracModel.Visible = true;
			this.colAracModel.VisibleIndex = 2;
			this.colAracModel.Width = 94;
			// 
			// colMusteriID
			// 
			this.colMusteriID.FieldName = "MusteriID";
			this.colMusteriID.MinWidth = 25;
			this.colMusteriID.Name = "colMusteriID";
			this.colMusteriID.OptionsColumn.AllowEdit = false;
			this.colMusteriID.Width = 94;
			// 
			// colMusteri
			// 
			this.colMusteri.Caption = "Müşteri Adı";
			this.colMusteri.FieldName = "Musteri.Adi";
			this.colMusteri.MinWidth = 25;
			this.colMusteri.Name = "colMusteri";
			this.colMusteri.OptionsColumn.AllowEdit = false;
			this.colMusteri.Visible = true;
			this.colMusteri.VisibleIndex = 3;
			this.colMusteri.Width = 94;
			// 
			// colRenk
			// 
			this.colRenk.FieldName = "Renk";
			this.colRenk.MinWidth = 25;
			this.colRenk.Name = "colRenk";
			this.colRenk.OptionsColumn.AllowEdit = false;
			this.colRenk.Visible = true;
			this.colRenk.VisibleIndex = 4;
			this.colRenk.Width = 94;
			// 
			// colSaseNo
			// 
			this.colSaseNo.Caption = "Şase No";
			this.colSaseNo.FieldName = "SaseNo";
			this.colSaseNo.MinWidth = 25;
			this.colSaseNo.Name = "colSaseNo";
			this.colSaseNo.OptionsColumn.AllowEdit = false;
			this.colSaseNo.Visible = true;
			this.colSaseNo.VisibleIndex = 5;
			this.colSaseNo.Width = 94;
			// 
			// colGarantiBaslangic
			// 
			this.colGarantiBaslangic.Caption = "Garanti Başlangıç";
			this.colGarantiBaslangic.FieldName = "GarantiBaslangic";
			this.colGarantiBaslangic.MinWidth = 25;
			this.colGarantiBaslangic.Name = "colGarantiBaslangic";
			this.colGarantiBaslangic.OptionsColumn.AllowEdit = false;
			this.colGarantiBaslangic.Visible = true;
			this.colGarantiBaslangic.VisibleIndex = 6;
			this.colGarantiBaslangic.Width = 94;
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
			// FrmAracGoruntule
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1353, 501);
			this.ContextMenuStrip = this.contextMenuStrip1;
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("FrmAracGoruntule.IconOptions.LargeImage")));
			this.Name = "FrmAracGoruntule";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Araç Görüntüle";
			this.Load += new System.EventHandler(this.FrmAracGoruntule_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridLookUpIsım.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmbAracTipi.Properties)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdAraclar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.aracBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Panel panel1;
		private DevExpress.XtraGrid.GridControl grdAraclar;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtPlakaNo;
		private System.Windows.Forms.TextBox txtAracModel;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtSaseNo;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtRenk;
		private System.Windows.Forms.Label label4;
		private DevExpress.XtraEditors.ComboBoxEdit cmbAracTipi;
		private DevExpress.XtraEditors.GridLookUpEdit gridLookUpIsım;
		private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
		private DevExpress.XtraGrid.Columns.GridColumn ID;
		private DevExpress.XtraGrid.Columns.GridColumn Adi;
		private DevExpress.XtraGrid.Columns.GridColumn TcNo;
		private DevExpress.XtraGrid.Columns.GridColumn Adres;
		private DevExpress.XtraGrid.Columns.GridColumn Telefon;
		private DevExpress.XtraGrid.Columns.GridColumn EPosta;
		private DevExpress.XtraGrid.Columns.GridColumn PlakaID;
		private System.Windows.Forms.Button btnGuncelle;
		private System.Windows.Forms.DateTimePicker dtGarantiBaslangic;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.BindingSource aracBindingSource;
		private DevExpress.XtraGrid.Columns.GridColumn colID;
		private DevExpress.XtraGrid.Columns.GridColumn colPlakaNo;
		private DevExpress.XtraGrid.Columns.GridColumn colAracTipi;
		private DevExpress.XtraGrid.Columns.GridColumn colAracModel;
		private DevExpress.XtraGrid.Columns.GridColumn colMusteriID;
		private DevExpress.XtraGrid.Columns.GridColumn colMusteri;
		private DevExpress.XtraGrid.Columns.GridColumn colRenk;
		private DevExpress.XtraGrid.Columns.GridColumn colSaseNo;
		private DevExpress.XtraGrid.Columns.GridColumn colGarantiBaslangic;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.CheckBox chcKullanimda;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem btnTumu;
		private System.Windows.Forms.ToolStripMenuItem btnKullanimdaOlan;
		private System.Windows.Forms.ToolStripMenuItem btnKullanimdaOlmayan;
	}
}