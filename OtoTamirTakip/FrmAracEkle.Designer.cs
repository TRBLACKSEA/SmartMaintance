
namespace OtoTamirTakip
{
	partial class FrmAracEkle
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAracEkle));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
			this.gridLookUpIsım = new DevExpress.XtraEditors.GridLookUpEdit();
			this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.Adi = new DevExpress.XtraGrid.Columns.GridColumn();
			this.TcNo = new DevExpress.XtraGrid.Columns.GridColumn();
			this.Adres = new DevExpress.XtraGrid.Columns.GridColumn();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
			this.txtRenk = new DevExpress.XtraEditors.TextEdit();
			this.txtSaseNo = new DevExpress.XtraEditors.TextEdit();
			this.cmbAracTipi = new DevExpress.XtraEditors.ComboBoxEdit();
			this.txtAracModel = new DevExpress.XtraEditors.TextEdit();
			this.txtPlakaNo = new DevExpress.XtraEditors.TextEdit();
			this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
			this.musteriBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.Telefon = new DevExpress.XtraGrid.Columns.GridColumn();
			this.EPosta = new DevExpress.XtraGrid.Columns.GridColumn();
			this.PlakaID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.dtGarantiBaslangic = new System.Windows.Forms.DateTimePicker();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridLookUpIsım.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
			this.layoutControl2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtRenk.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtSaseNo.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmbAracTipi.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtAracModel.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPlakaNo.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.musteriBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.simpleButton1);
			this.groupBox1.Controls.Add(this.gridLookUpIsım);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(777, 63);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Müşteri";
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// simpleButton1
			// 
			this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.simpleButton1.Appearance.Options.UseFont = true;
			this.simpleButton1.Location = new System.Drawing.Point(619, 19);
			this.simpleButton1.Name = "simpleButton1";
			this.simpleButton1.Size = new System.Drawing.Size(141, 38);
			this.simpleButton1.TabIndex = 8;
			this.simpleButton1.Text = "Kaydet";
			this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
			// 
			// gridLookUpIsım
			// 
			this.gridLookUpIsım.Location = new System.Drawing.Point(91, 22);
			this.gridLookUpIsım.Name = "gridLookUpIsım";
			this.gridLookUpIsım.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.gridLookUpIsım.Properties.Appearance.Options.UseFont = true;
			this.gridLookUpIsım.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.gridLookUpIsım.Properties.DataSource = this.musteriBindingSource;
			this.gridLookUpIsım.Properties.DisplayMember = "Adi";
			this.gridLookUpIsım.Properties.NullText = "";
			this.gridLookUpIsım.Properties.PopupView = this.gridLookUpEdit1View;
			this.gridLookUpIsım.Properties.ValueMember = "ID";
			this.gridLookUpIsım.Size = new System.Drawing.Size(522, 30);
			this.gridLookUpIsım.TabIndex = 7;
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
			this.gridLookUpEdit1View.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridLookUpEdit1View_FocusedRowChanged);
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
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(13, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(82, 24);
			this.label1.TabIndex = 1;
			this.label1.Text = "Müşteri:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.layoutControl2);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.groupBox2.Location = new System.Drawing.Point(0, 63);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.groupBox2.Size = new System.Drawing.Size(777, 261);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Araç Bilgileri";
			// 
			// layoutControl2
			// 
			this.layoutControl2.Controls.Add(this.dtGarantiBaslangic);
			this.layoutControl2.Controls.Add(this.txtRenk);
			this.layoutControl2.Controls.Add(this.txtSaseNo);
			this.layoutControl2.Controls.Add(this.cmbAracTipi);
			this.layoutControl2.Controls.Add(this.txtAracModel);
			this.layoutControl2.Controls.Add(this.txtPlakaNo);
			this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl2.Location = new System.Drawing.Point(5, 29);
			this.layoutControl2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.layoutControl2.Name = "layoutControl2";
			this.layoutControl2.Root = this.layoutControlGroup1;
			this.layoutControl2.Size = new System.Drawing.Size(767, 228);
			this.layoutControl2.TabIndex = 0;
			this.layoutControl2.Text = "layoutControl1";
			// 
			// txtRenk
			// 
			this.txtRenk.Location = new System.Drawing.Point(179, 114);
			this.txtRenk.Name = "txtRenk";
			this.txtRenk.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtRenk.Properties.Appearance.Options.UseFont = true;
			this.txtRenk.Size = new System.Drawing.Size(576, 30);
			this.txtRenk.StyleController = this.layoutControl2;
			this.txtRenk.TabIndex = 7;
			// 
			// txtSaseNo
			// 
			this.txtSaseNo.Location = new System.Drawing.Point(179, 148);
			this.txtSaseNo.Name = "txtSaseNo";
			this.txtSaseNo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtSaseNo.Properties.Appearance.Options.UseFont = true;
			this.txtSaseNo.Size = new System.Drawing.Size(576, 30);
			this.txtSaseNo.StyleController = this.layoutControl2;
			this.txtSaseNo.TabIndex = 7;
			// 
			// cmbAracTipi
			// 
			this.cmbAracTipi.Location = new System.Drawing.Point(179, 46);
			this.cmbAracTipi.Name = "cmbAracTipi";
			this.cmbAracTipi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.cmbAracTipi.Properties.Appearance.Options.UseFont = true;
			this.cmbAracTipi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cmbAracTipi.Properties.Items.AddRange(new object[] {
            "Binek",
            "Ticari",
            "Kamyonet"});
			this.cmbAracTipi.Properties.PopupSizeable = true;
			this.cmbAracTipi.Size = new System.Drawing.Size(576, 30);
			this.cmbAracTipi.StyleController = this.layoutControl2;
			this.cmbAracTipi.TabIndex = 9;
			// 
			// txtAracModel
			// 
			this.txtAracModel.Location = new System.Drawing.Point(179, 80);
			this.txtAracModel.Name = "txtAracModel";
			this.txtAracModel.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtAracModel.Properties.Appearance.Options.UseFont = true;
			this.txtAracModel.Size = new System.Drawing.Size(576, 30);
			this.txtAracModel.StyleController = this.layoutControl2;
			this.txtAracModel.TabIndex = 6;
			// 
			// txtPlakaNo
			// 
			this.txtPlakaNo.Location = new System.Drawing.Point(179, 12);
			this.txtPlakaNo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.txtPlakaNo.Name = "txtPlakaNo";
			this.txtPlakaNo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtPlakaNo.Properties.Appearance.Options.UseFont = true;
			this.txtPlakaNo.Size = new System.Drawing.Size(576, 30);
			this.txtPlakaNo.StyleController = this.layoutControl2;
			this.txtPlakaNo.TabIndex = 4;
			// 
			// layoutControlGroup1
			// 
			this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.layoutControlGroup1.GroupBordersVisible = false;
			this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem9,
            this.layoutControlItem12,
            this.layoutControlItem8,
            this.layoutControlItem1});
			this.layoutControlGroup1.Name = "Root";
			this.layoutControlGroup1.Size = new System.Drawing.Size(767, 228);
			this.layoutControlGroup1.TextVisible = false;
			// 
			// layoutControlItem6
			// 
			this.layoutControlItem6.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.layoutControlItem6.AppearanceItemCaption.Options.UseFont = true;
			this.layoutControlItem6.Control = this.txtPlakaNo;
			this.layoutControlItem6.CustomizationFormText = "İsim/Ünvan:";
			this.layoutControlItem6.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem6.Name = "layoutControlItem1";
			this.layoutControlItem6.Size = new System.Drawing.Size(747, 34);
			this.layoutControlItem6.Text = "Plaka";
			this.layoutControlItem6.TextSize = new System.Drawing.Size(155, 24);
			// 
			// layoutControlItem7
			// 
			this.layoutControlItem7.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.layoutControlItem7.AppearanceItemCaption.Options.UseFont = true;
			this.layoutControlItem7.Control = this.txtSaseNo;
			this.layoutControlItem7.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
			this.layoutControlItem7.CustomizationFormText = "Tel/Cep Tel:";
			this.layoutControlItem7.Location = new System.Drawing.Point(0, 136);
			this.layoutControlItem7.Name = "layoutControlItem7";
			this.layoutControlItem7.Size = new System.Drawing.Size(747, 34);
			this.layoutControlItem7.Text = "Şase No:";
			this.layoutControlItem7.TextSize = new System.Drawing.Size(155, 24);
			// 
			// layoutControlItem9
			// 
			this.layoutControlItem9.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.layoutControlItem9.AppearanceItemCaption.Options.UseFont = true;
			this.layoutControlItem9.Control = this.txtRenk;
			this.layoutControlItem9.Location = new System.Drawing.Point(0, 102);
			this.layoutControlItem9.Name = "layoutControlItem4";
			this.layoutControlItem9.Size = new System.Drawing.Size(747, 34);
			this.layoutControlItem9.Text = "Renk:";
			this.layoutControlItem9.TextSize = new System.Drawing.Size(155, 24);
			// 
			// layoutControlItem12
			// 
			this.layoutControlItem12.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.layoutControlItem12.AppearanceItemCaption.Options.UseFont = true;
			this.layoutControlItem12.Control = this.txtAracModel;
			this.layoutControlItem12.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
			this.layoutControlItem12.CustomizationFormText = "Araç Tipi:";
			this.layoutControlItem12.Location = new System.Drawing.Point(0, 68);
			this.layoutControlItem12.Name = "layoutControlItem12";
			this.layoutControlItem12.Size = new System.Drawing.Size(747, 34);
			this.layoutControlItem12.Text = "Araç Model:";
			this.layoutControlItem12.TextSize = new System.Drawing.Size(155, 24);
			// 
			// layoutControlItem8
			// 
			this.layoutControlItem8.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.layoutControlItem8.AppearanceItemCaption.Options.UseFont = true;
			this.layoutControlItem8.Control = this.cmbAracTipi;
			this.layoutControlItem8.Location = new System.Drawing.Point(0, 34);
			this.layoutControlItem8.Name = "layoutControlItem8";
			this.layoutControlItem8.Size = new System.Drawing.Size(747, 34);
			this.layoutControlItem8.Text = "Araç Tipi:";
			this.layoutControlItem8.TextSize = new System.Drawing.Size(155, 24);
			// 
			// musteriBindingSource
			// 
			this.musteriBindingSource.DataSource = typeof(OtoTamirTakip.Entities.Musteri);
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
			// dtGarantiBaslangic
			// 
			this.dtGarantiBaslangic.Location = new System.Drawing.Point(179, 182);
			this.dtGarantiBaslangic.Name = "dtGarantiBaslangic";
			this.dtGarantiBaslangic.Size = new System.Drawing.Size(576, 32);
			this.dtGarantiBaslangic.TabIndex = 10;
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
			this.layoutControlItem1.Control = this.dtGarantiBaslangic;
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 170);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(747, 38);
			this.layoutControlItem1.Text = "Garanti Başlangıç";
			this.layoutControlItem1.TextSize = new System.Drawing.Size(155, 24);
			// 
			// FrmAracEkle
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(777, 324);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("FrmAracEkle.IconOptions.LargeImage")));
			this.Name = "FrmAracEkle";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Araç Kartı";
			this.Load += new System.EventHandler(this.FrmPlakalar_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridLookUpIsım.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
			this.layoutControl2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.txtRenk.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtSaseNo.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmbAracTipi.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtAracModel.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPlakaNo.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.musteriBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.BindingSource musteriBindingSource;
		private DevExpress.XtraEditors.GridLookUpEdit gridLookUpIsım;
		private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
		private DevExpress.XtraGrid.Columns.GridColumn ID;
		private DevExpress.XtraGrid.Columns.GridColumn Adi;
		private DevExpress.XtraGrid.Columns.GridColumn TcNo;
		private DevExpress.XtraGrid.Columns.GridColumn Adres;
		private DevExpress.XtraGrid.Columns.GridColumn Telefon;
		private DevExpress.XtraGrid.Columns.GridColumn EPosta;
		private DevExpress.XtraGrid.Columns.GridColumn PlakaID;
		private DevExpress.XtraEditors.SimpleButton simpleButton1;
		private System.Windows.Forms.GroupBox groupBox2;
		private DevExpress.XtraLayout.LayoutControl layoutControl2;
		private DevExpress.XtraEditors.TextEdit txtRenk;
		private DevExpress.XtraEditors.TextEdit txtSaseNo;
		private DevExpress.XtraEditors.ComboBoxEdit cmbAracTipi;
		private DevExpress.XtraEditors.TextEdit txtAracModel;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem12;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
		private DevExpress.XtraEditors.TextEdit txtPlakaNo;
		private System.Windows.Forms.DateTimePicker dtGarantiBaslangic;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
	}
}