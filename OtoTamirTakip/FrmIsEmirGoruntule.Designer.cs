
namespace OtoTamirTakip
{
	partial class FrmIsEmirGoruntule
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
			DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIsEmirGoruntule));
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
			this.gridControl1 = new DevExpress.XtraGrid.GridControl();
			this.ısEmriBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colIsımUnvan = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTcNo = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colAdres = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTel = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colEPosta = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPlaka = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colAracTipi = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colAracModel = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colAracKM = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colRenk = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSaseNo = new DevExpress.XtraGrid.Columns.GridColumn();
			this.GarantiBaslangic = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colGelisTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colBaslamaTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTeslimTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colOdemeSekli = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colIsEmriNo = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colKasko = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTrafik = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colMusOd = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colisEmriDetayID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.Incele = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.statusStrip2 = new System.Windows.Forms.StatusStrip();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ısEmriBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
			this.SuspendLayout();
			// 
			// gridControl1
			// 
			this.gridControl1.DataSource = this.ısEmriBindingSource;
			this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridControl1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.gridControl1.Location = new System.Drawing.Point(0, 0);
			this.gridControl1.MainView = this.gridView1;
			this.gridControl1.Name = "gridControl1";
			this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1});
			this.gridControl1.Size = new System.Drawing.Size(1241, 589);
			this.gridControl1.TabIndex = 0;
			this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// ısEmriBindingSource
			// 
			this.ısEmriBindingSource.DataSource = typeof(OtoTamirTakip.Entities.IsEmri);
			// 
			// gridView1
			// 
			this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colIsımUnvan,
            this.colTcNo,
            this.colAdres,
            this.colTel,
            this.colEPosta,
            this.colPlaka,
            this.colAracTipi,
            this.colAracModel,
            this.colAracKM,
            this.colRenk,
            this.colSaseNo,
            this.GarantiBaslangic,
            this.colGelisTarihi,
            this.colBaslamaTarihi,
            this.colTeslimTarihi,
            this.colOdemeSekli,
            this.colIsEmriNo,
            this.colKasko,
            this.colTrafik,
            this.colMusOd,
            this.colisEmriDetayID,
            this.Incele});
			this.gridView1.GridControl = this.gridControl1;
			this.gridView1.Name = "gridView1";
			this.gridView1.OptionsView.ShowAutoFilterRow = true;
			this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
			// 
			// colID
			// 
			this.colID.Caption = "ID";
			this.colID.FieldName = "ID";
			this.colID.MinWidth = 25;
			this.colID.Name = "colID";
			this.colID.OptionsColumn.AllowEdit = false;
			this.colID.OptionsColumn.ReadOnly = true;
			this.colID.Width = 94;
			// 
			// colIsımUnvan
			// 
			this.colIsımUnvan.Caption = "Müşteri Adı";
			this.colIsımUnvan.FieldName = "Adi";
			this.colIsımUnvan.MinWidth = 25;
			this.colIsımUnvan.Name = "colIsımUnvan";
			this.colIsımUnvan.OptionsColumn.AllowEdit = false;
			this.colIsımUnvan.OptionsColumn.ReadOnly = true;
			this.colIsımUnvan.Visible = true;
			this.colIsımUnvan.VisibleIndex = 0;
			this.colIsımUnvan.Width = 94;
			// 
			// colTcNo
			// 
			this.colTcNo.Caption = "Tc No";
			this.colTcNo.FieldName = "TcNo";
			this.colTcNo.MinWidth = 25;
			this.colTcNo.Name = "colTcNo";
			this.colTcNo.OptionsColumn.AllowEdit = false;
			this.colTcNo.OptionsColumn.ReadOnly = true;
			this.colTcNo.Visible = true;
			this.colTcNo.VisibleIndex = 1;
			this.colTcNo.Width = 94;
			// 
			// colAdres
			// 
			this.colAdres.Caption = "Adres";
			this.colAdres.FieldName = "Adres";
			this.colAdres.MinWidth = 25;
			this.colAdres.Name = "colAdres";
			this.colAdres.OptionsColumn.AllowEdit = false;
			this.colAdres.OptionsColumn.ReadOnly = true;
			this.colAdres.Visible = true;
			this.colAdres.VisibleIndex = 2;
			this.colAdres.Width = 94;
			// 
			// colTel
			// 
			this.colTel.Caption = "Tel";
			this.colTel.FieldName = "Tel";
			this.colTel.MinWidth = 25;
			this.colTel.Name = "colTel";
			this.colTel.OptionsColumn.AllowEdit = false;
			this.colTel.OptionsColumn.ReadOnly = true;
			this.colTel.Visible = true;
			this.colTel.VisibleIndex = 3;
			this.colTel.Width = 94;
			// 
			// colEPosta
			// 
			this.colEPosta.Caption = "Mail";
			this.colEPosta.FieldName = "Mail";
			this.colEPosta.MinWidth = 25;
			this.colEPosta.Name = "colEPosta";
			this.colEPosta.OptionsColumn.AllowEdit = false;
			this.colEPosta.OptionsColumn.ReadOnly = true;
			this.colEPosta.Visible = true;
			this.colEPosta.VisibleIndex = 4;
			this.colEPosta.Width = 94;
			// 
			// colPlaka
			// 
			this.colPlaka.Caption = "Plaka No";
			this.colPlaka.FieldName = "PlakaNo";
			this.colPlaka.MinWidth = 25;
			this.colPlaka.Name = "colPlaka";
			this.colPlaka.OptionsColumn.AllowEdit = false;
			this.colPlaka.OptionsColumn.ReadOnly = true;
			this.colPlaka.Visible = true;
			this.colPlaka.VisibleIndex = 5;
			this.colPlaka.Width = 94;
			// 
			// colAracTipi
			// 
			this.colAracTipi.Caption = "Araç Tipi";
			this.colAracTipi.FieldName = "AracTipi";
			this.colAracTipi.MinWidth = 25;
			this.colAracTipi.Name = "colAracTipi";
			this.colAracTipi.OptionsColumn.AllowEdit = false;
			this.colAracTipi.OptionsColumn.ReadOnly = true;
			this.colAracTipi.Visible = true;
			this.colAracTipi.VisibleIndex = 6;
			this.colAracTipi.Width = 94;
			// 
			// colAracModel
			// 
			this.colAracModel.Caption = "Araç Model";
			this.colAracModel.FieldName = "AracModel";
			this.colAracModel.MinWidth = 25;
			this.colAracModel.Name = "colAracModel";
			this.colAracModel.OptionsColumn.AllowEdit = false;
			this.colAracModel.OptionsColumn.ReadOnly = true;
			this.colAracModel.Visible = true;
			this.colAracModel.VisibleIndex = 7;
			this.colAracModel.Width = 94;
			// 
			// colAracKM
			// 
			this.colAracKM.Caption = "Araç KM";
			this.colAracKM.FieldName = "AracKM";
			this.colAracKM.MinWidth = 25;
			this.colAracKM.Name = "colAracKM";
			this.colAracKM.OptionsColumn.AllowEdit = false;
			this.colAracKM.OptionsColumn.ReadOnly = true;
			this.colAracKM.Visible = true;
			this.colAracKM.VisibleIndex = 8;
			this.colAracKM.Width = 94;
			// 
			// colRenk
			// 
			this.colRenk.Caption = "Renk";
			this.colRenk.FieldName = "Renk";
			this.colRenk.MinWidth = 25;
			this.colRenk.Name = "colRenk";
			this.colRenk.OptionsColumn.AllowEdit = false;
			this.colRenk.OptionsColumn.ReadOnly = true;
			this.colRenk.Visible = true;
			this.colRenk.VisibleIndex = 9;
			this.colRenk.Width = 94;
			// 
			// colSaseNo
			// 
			this.colSaseNo.Caption = "Şase No";
			this.colSaseNo.FieldName = "SaseNo";
			this.colSaseNo.MinWidth = 25;
			this.colSaseNo.Name = "colSaseNo";
			this.colSaseNo.OptionsColumn.AllowEdit = false;
			this.colSaseNo.OptionsColumn.ReadOnly = true;
			this.colSaseNo.Visible = true;
			this.colSaseNo.VisibleIndex = 10;
			this.colSaseNo.Width = 94;
			// 
			// GarantiBaslangic
			// 
			this.GarantiBaslangic.Caption = "Garanti Başlangıç";
			this.GarantiBaslangic.FieldName = "GarantiBaslangic";
			this.GarantiBaslangic.MinWidth = 25;
			this.GarantiBaslangic.Name = "GarantiBaslangic";
			this.GarantiBaslangic.OptionsColumn.AllowEdit = false;
			this.GarantiBaslangic.OptionsColumn.ReadOnly = true;
			this.GarantiBaslangic.Visible = true;
			this.GarantiBaslangic.VisibleIndex = 11;
			this.GarantiBaslangic.Width = 94;
			// 
			// colGelisTarihi
			// 
			this.colGelisTarihi.Caption = "Geliş Tarihi";
			this.colGelisTarihi.FieldName = "GelisTarihi";
			this.colGelisTarihi.MinWidth = 25;
			this.colGelisTarihi.Name = "colGelisTarihi";
			this.colGelisTarihi.OptionsColumn.AllowEdit = false;
			this.colGelisTarihi.OptionsColumn.ReadOnly = true;
			this.colGelisTarihi.Visible = true;
			this.colGelisTarihi.VisibleIndex = 12;
			this.colGelisTarihi.Width = 94;
			// 
			// colBaslamaTarihi
			// 
			this.colBaslamaTarihi.Caption = "Başlama Tarihi";
			this.colBaslamaTarihi.FieldName = "BaslamaTarihi";
			this.colBaslamaTarihi.MinWidth = 25;
			this.colBaslamaTarihi.Name = "colBaslamaTarihi";
			this.colBaslamaTarihi.OptionsColumn.AllowEdit = false;
			this.colBaslamaTarihi.OptionsColumn.ReadOnly = true;
			this.colBaslamaTarihi.Visible = true;
			this.colBaslamaTarihi.VisibleIndex = 13;
			this.colBaslamaTarihi.Width = 94;
			// 
			// colTeslimTarihi
			// 
			this.colTeslimTarihi.Caption = "Teslim Tarihi";
			this.colTeslimTarihi.FieldName = "TeslimTarihi";
			this.colTeslimTarihi.MinWidth = 25;
			this.colTeslimTarihi.Name = "colTeslimTarihi";
			this.colTeslimTarihi.OptionsColumn.AllowEdit = false;
			this.colTeslimTarihi.OptionsColumn.ReadOnly = true;
			this.colTeslimTarihi.Visible = true;
			this.colTeslimTarihi.VisibleIndex = 14;
			this.colTeslimTarihi.Width = 94;
			// 
			// colOdemeSekli
			// 
			this.colOdemeSekli.Caption = "Ödeme Şekli";
			this.colOdemeSekli.FieldName = "OdemeSekli";
			this.colOdemeSekli.MinWidth = 25;
			this.colOdemeSekli.Name = "colOdemeSekli";
			this.colOdemeSekli.OptionsColumn.AllowEdit = false;
			this.colOdemeSekli.OptionsColumn.ReadOnly = true;
			this.colOdemeSekli.Visible = true;
			this.colOdemeSekli.VisibleIndex = 15;
			this.colOdemeSekli.Width = 94;
			// 
			// colIsEmriNo
			// 
			this.colIsEmriNo.Caption = "İş Emri No";
			this.colIsEmriNo.FieldName = "IsEmriNo";
			this.colIsEmriNo.MinWidth = 25;
			this.colIsEmriNo.Name = "colIsEmriNo";
			this.colIsEmriNo.OptionsColumn.AllowEdit = false;
			this.colIsEmriNo.OptionsColumn.ReadOnly = true;
			this.colIsEmriNo.Visible = true;
			this.colIsEmriNo.VisibleIndex = 16;
			this.colIsEmriNo.Width = 94;
			// 
			// colKasko
			// 
			this.colKasko.Caption = "Kasko";
			this.colKasko.FieldName = "Kasko";
			this.colKasko.MinWidth = 25;
			this.colKasko.Name = "colKasko";
			this.colKasko.OptionsColumn.AllowEdit = false;
			this.colKasko.OptionsColumn.ReadOnly = true;
			this.colKasko.Visible = true;
			this.colKasko.VisibleIndex = 17;
			this.colKasko.Width = 94;
			// 
			// colTrafik
			// 
			this.colTrafik.Caption = "Trafik";
			this.colTrafik.FieldName = "Trafik";
			this.colTrafik.MinWidth = 25;
			this.colTrafik.Name = "colTrafik";
			this.colTrafik.OptionsColumn.AllowEdit = false;
			this.colTrafik.OptionsColumn.ReadOnly = true;
			this.colTrafik.Visible = true;
			this.colTrafik.VisibleIndex = 18;
			this.colTrafik.Width = 94;
			// 
			// colMusOd
			// 
			this.colMusOd.Caption = "Müş. Öd.";
			this.colMusOd.FieldName = "MusOd";
			this.colMusOd.MinWidth = 25;
			this.colMusOd.Name = "colMusOd";
			this.colMusOd.OptionsColumn.AllowEdit = false;
			this.colMusOd.OptionsColumn.ReadOnly = true;
			this.colMusOd.Visible = true;
			this.colMusOd.VisibleIndex = 19;
			this.colMusOd.Width = 94;
			// 
			// colisEmriDetayID
			// 
			this.colisEmriDetayID.Caption = "İş Emri DetayID";
			this.colisEmriDetayID.FieldName = "isEmriDetayID";
			this.colisEmriDetayID.MinWidth = 25;
			this.colisEmriDetayID.Name = "colisEmriDetayID";
			this.colisEmriDetayID.OptionsColumn.AllowEdit = false;
			this.colisEmriDetayID.OptionsColumn.ReadOnly = true;
			this.colisEmriDetayID.Width = 94;
			// 
			// Incele
			// 
			this.Incele.Caption = "İncele";
			this.Incele.ColumnEdit = this.repositoryItemButtonEdit1;
			this.Incele.FieldName = "Incele";
			this.Incele.MinWidth = 25;
			this.Incele.Name = "Incele";
			this.Incele.Visible = true;
			this.Incele.VisibleIndex = 20;
			this.Incele.Width = 94;
			// 
			// repositoryItemButtonEdit1
			// 
			this.repositoryItemButtonEdit1.AutoHeight = false;
			editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
			this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
			this.repositoryItemButtonEdit1.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("repositoryItemButtonEdit1.ContextImageOptions.Image")));
			this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
			this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
			this.repositoryItemButtonEdit1.Click += new System.EventHandler(this.repositoryItemButtonEdit1_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.statusStrip1.Location = new System.Drawing.Point(0, 567);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(1241, 22);
			this.statusStrip1.TabIndex = 1;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// statusStrip2
			// 
			this.statusStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.statusStrip2.Location = new System.Drawing.Point(0, 545);
			this.statusStrip2.Name = "statusStrip2";
			this.statusStrip2.Size = new System.Drawing.Size(1241, 22);
			this.statusStrip2.TabIndex = 2;
			this.statusStrip2.Text = "statusStrip2";
			// 
			// FrmIsEmirGoruntule
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1241, 589);
			this.Controls.Add(this.statusStrip2);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.gridControl1);
			this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("FrmIsEmirGoruntule.IconOptions.LargeImage")));
			this.Name = "FrmIsEmirGoruntule";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "İş Emirleri";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.FrmIsEmirGoruntule_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ısEmriBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraGrid.GridControl gridControl1;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private System.Windows.Forms.BindingSource ısEmriBindingSource;
		private DevExpress.XtraGrid.Columns.GridColumn colID;
		private DevExpress.XtraGrid.Columns.GridColumn colIsımUnvan;
		private DevExpress.XtraGrid.Columns.GridColumn colTcNo;
		private DevExpress.XtraGrid.Columns.GridColumn colAdres;
		private DevExpress.XtraGrid.Columns.GridColumn colTel;
		private DevExpress.XtraGrid.Columns.GridColumn colEPosta;
		private DevExpress.XtraGrid.Columns.GridColumn colPlaka;
		private DevExpress.XtraGrid.Columns.GridColumn colAracTipi;
		private DevExpress.XtraGrid.Columns.GridColumn colAracModel;
		private DevExpress.XtraGrid.Columns.GridColumn colAracKM;
		private DevExpress.XtraGrid.Columns.GridColumn colRenk;
		private DevExpress.XtraGrid.Columns.GridColumn colSaseNo;
		private DevExpress.XtraGrid.Columns.GridColumn GarantiBaslangic;
		private DevExpress.XtraGrid.Columns.GridColumn colGelisTarihi;
		private DevExpress.XtraGrid.Columns.GridColumn colBaslamaTarihi;
		private DevExpress.XtraGrid.Columns.GridColumn colTeslimTarihi;
		private DevExpress.XtraGrid.Columns.GridColumn colOdemeSekli;
		private DevExpress.XtraGrid.Columns.GridColumn colIsEmriNo;
		private DevExpress.XtraGrid.Columns.GridColumn colKasko;
		private DevExpress.XtraGrid.Columns.GridColumn colTrafik;
		private DevExpress.XtraGrid.Columns.GridColumn colMusOd;
		private DevExpress.XtraGrid.Columns.GridColumn colisEmriDetayID;
		private DevExpress.XtraGrid.Columns.GridColumn Incele;
		private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.StatusStrip statusStrip2;
	}
}