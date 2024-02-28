
namespace OtoTamirTakip
{
	partial class FrmAyarlar
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAyarlar));
			this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
			this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
			this.txtAdres = new System.Windows.Forms.TextBox();
			this.txtMail = new DevExpress.XtraEditors.TextEdit();
			this.txtTelefon = new DevExpress.XtraEditors.TextEdit();
			this.txtSirket = new DevExpress.XtraEditors.TextEdit();
			this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
			this.layoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtMail.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTelefon.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtSirket.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
			this.SuspendLayout();
			// 
			// layoutControl1
			// 
			this.layoutControl1.Controls.Add(this.simpleButton1);
			this.layoutControl1.Controls.Add(this.txtAdres);
			this.layoutControl1.Controls.Add(this.txtMail);
			this.layoutControl1.Controls.Add(this.txtTelefon);
			this.layoutControl1.Controls.Add(this.txtSirket);
			this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new System.Drawing.Point(0, 0);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.Root = this.Root;
			this.layoutControl1.Size = new System.Drawing.Size(602, 288);
			this.layoutControl1.TabIndex = 0;
			this.layoutControl1.Text = "layoutControl1";
			// 
			// simpleButton1
			// 
			this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.simpleButton1.Appearance.Options.UseFont = true;
			this.simpleButton1.Location = new System.Drawing.Point(399, 247);
			this.simpleButton1.Name = "simpleButton1";
			this.simpleButton1.Size = new System.Drawing.Size(191, 29);
			this.simpleButton1.StyleController = this.layoutControl1;
			this.simpleButton1.TabIndex = 9;
			this.simpleButton1.Text = "Kaydet";
			this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
			// 
			// txtAdres
			// 
			this.txtAdres.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtAdres.Location = new System.Drawing.Point(72, 46);
			this.txtAdres.Multiline = true;
			this.txtAdres.Name = "txtAdres";
			this.txtAdres.Size = new System.Drawing.Size(518, 129);
			this.txtAdres.TabIndex = 8;
			// 
			// txtMail
			// 
			this.txtMail.Location = new System.Drawing.Point(72, 213);
			this.txtMail.Name = "txtMail";
			this.txtMail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtMail.Properties.Appearance.Options.UseFont = true;
			this.txtMail.Size = new System.Drawing.Size(518, 30);
			this.txtMail.StyleController = this.layoutControl1;
			this.txtMail.TabIndex = 7;
			// 
			// txtTelefon
			// 
			this.txtTelefon.Location = new System.Drawing.Point(72, 179);
			this.txtTelefon.Name = "txtTelefon";
			this.txtTelefon.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtTelefon.Properties.Appearance.Options.UseFont = true;
			this.txtTelefon.Size = new System.Drawing.Size(518, 30);
			this.txtTelefon.StyleController = this.layoutControl1;
			this.txtTelefon.TabIndex = 6;
			// 
			// txtSirket
			// 
			this.txtSirket.Location = new System.Drawing.Point(72, 12);
			this.txtSirket.Name = "txtSirket";
			this.txtSirket.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtSirket.Properties.Appearance.Options.UseFont = true;
			this.txtSirket.Size = new System.Drawing.Size(518, 30);
			this.txtSirket.StyleController = this.layoutControl1;
			this.txtSirket.TabIndex = 4;
			// 
			// Root
			// 
			this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.Root.GroupBordersVisible = false;
			this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem2,
            this.layoutControlItem5});
			this.Root.Name = "Root";
			this.Root.Size = new System.Drawing.Size(602, 288);
			this.Root.TextVisible = false;
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.txtSirket;
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(582, 34);
			this.layoutControlItem1.Text = "Şirket:";
			this.layoutControlItem1.TextSize = new System.Drawing.Size(48, 16);
			// 
			// emptySpaceItem1
			// 
			this.emptySpaceItem1.AllowHotTrack = false;
			this.emptySpaceItem1.Location = new System.Drawing.Point(0, 235);
			this.emptySpaceItem1.Name = "emptySpaceItem1";
			this.emptySpaceItem1.Size = new System.Drawing.Size(387, 33);
			this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
			// 
			// layoutControlItem3
			// 
			this.layoutControlItem3.Control = this.txtTelefon;
			this.layoutControlItem3.Location = new System.Drawing.Point(0, 167);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Size = new System.Drawing.Size(582, 34);
			this.layoutControlItem3.Text = "Telefon:";
			this.layoutControlItem3.TextSize = new System.Drawing.Size(48, 16);
			// 
			// layoutControlItem4
			// 
			this.layoutControlItem4.Control = this.txtMail;
			this.layoutControlItem4.Location = new System.Drawing.Point(0, 201);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.Size = new System.Drawing.Size(582, 34);
			this.layoutControlItem4.Text = "Mail:";
			this.layoutControlItem4.TextSize = new System.Drawing.Size(48, 16);
			// 
			// layoutControlItem2
			// 
			this.layoutControlItem2.Control = this.txtAdres;
			this.layoutControlItem2.Location = new System.Drawing.Point(0, 34);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Size = new System.Drawing.Size(582, 133);
			this.layoutControlItem2.Text = "Adres:";
			this.layoutControlItem2.TextSize = new System.Drawing.Size(48, 16);
			// 
			// layoutControlItem5
			// 
			this.layoutControlItem5.Control = this.simpleButton1;
			this.layoutControlItem5.Location = new System.Drawing.Point(387, 235);
			this.layoutControlItem5.Name = "layoutControlItem5";
			this.layoutControlItem5.Size = new System.Drawing.Size(195, 33);
			this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem5.TextVisible = false;
			// 
			// FrmAyarlar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(602, 288);
			this.Controls.Add(this.layoutControl1);
			this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("FrmAyarlar.IconOptions.LargeImage")));
			this.Name = "FrmAyarlar";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Ayarlar";
			this.Load += new System.EventHandler(this.FrmAyarlar_Load);
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
			this.layoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.txtMail.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTelefon.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtSirket.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraLayout.LayoutControl layoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup Root;
		private DevExpress.XtraEditors.SimpleButton simpleButton1;
		private System.Windows.Forms.TextBox txtAdres;
		private DevExpress.XtraEditors.TextEdit txtMail;
		private DevExpress.XtraEditors.TextEdit txtTelefon;
		private DevExpress.XtraEditors.TextEdit txtSirket;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
	}
}