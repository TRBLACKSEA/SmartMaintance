
namespace OtoTamirTakip
{
	partial class CarPart
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
			this.grpControl = new DevExpress.XtraEditors.GroupControl();
			this.rdFolyoKapli = new System.Windows.Forms.RadioButton();
			this.rdBoyali = new System.Windows.Forms.RadioButton();
			this.rdPlastik = new System.Windows.Forms.RadioButton();
			this.rdOrjinal = new System.Windows.Forms.RadioButton();
			this.rdIslemGormus = new System.Windows.Forms.RadioButton();
			this.rdLokalBoya = new System.Windows.Forms.RadioButton();
			this.rdSokTakBoyali = new System.Windows.Forms.RadioButton();
			this.rdDegismis = new System.Windows.Forms.RadioButton();
			this.rdSokTakOrjinal = new System.Windows.Forms.RadioButton();
			((System.ComponentModel.ISupportInitialize)(this.grpControl)).BeginInit();
			this.grpControl.SuspendLayout();
			this.SuspendLayout();
			// 
			// grpControl
			// 
			this.grpControl.AutoSize = true;
			this.grpControl.Controls.Add(this.rdFolyoKapli);
			this.grpControl.Controls.Add(this.rdBoyali);
			this.grpControl.Controls.Add(this.rdPlastik);
			this.grpControl.Controls.Add(this.rdOrjinal);
			this.grpControl.Controls.Add(this.rdIslemGormus);
			this.grpControl.Controls.Add(this.rdLokalBoya);
			this.grpControl.Controls.Add(this.rdSokTakBoyali);
			this.grpControl.Controls.Add(this.rdDegismis);
			this.grpControl.Controls.Add(this.rdSokTakOrjinal);
			this.grpControl.Dock = System.Windows.Forms.DockStyle.Top;
			this.grpControl.Location = new System.Drawing.Point(0, 0);
			this.grpControl.Name = "grpControl";
			this.grpControl.Size = new System.Drawing.Size(850, 49);
			this.grpControl.TabIndex = 64;
			this.grpControl.Text = "PartName";
			this.grpControl.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl5_Paint);
			// 
			// rdFolyoKapli
			// 
			this.rdFolyoKapli.AutoSize = true;
			this.rdFolyoKapli.BackColor = System.Drawing.Color.Gray;
			this.rdFolyoKapli.Location = new System.Drawing.Point(748, 29);
			this.rdFolyoKapli.Name = "rdFolyoKapli";
			this.rdFolyoKapli.Size = new System.Drawing.Size(76, 17);
			this.rdFolyoKapli.TabIndex = 0;
			this.rdFolyoKapli.TabStop = true;
			this.rdFolyoKapli.Text = "Folyo Kaplı";
			this.rdFolyoKapli.UseVisualStyleBackColor = false;
			this.rdFolyoKapli.CheckedChanged += new System.EventHandler(this.rdFolyoKapli_CheckedChanged);
			// 
			// rdBoyali
			// 
			this.rdBoyali.AutoSize = true;
			this.rdBoyali.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.rdBoyali.Location = new System.Drawing.Point(74, 29);
			this.rdBoyali.Name = "rdBoyali";
			this.rdBoyali.Size = new System.Drawing.Size(53, 17);
			this.rdBoyali.TabIndex = 0;
			this.rdBoyali.TabStop = true;
			this.rdBoyali.Text = "Boyalı";
			this.rdBoyali.UseVisualStyleBackColor = false;
			this.rdBoyali.CheckedChanged += new System.EventHandler(this.rdBoyali_CheckedChanged);
			// 
			// rdPlastik
			// 
			this.rdPlastik.AutoSize = true;
			this.rdPlastik.BackColor = System.Drawing.Color.Aqua;
			this.rdPlastik.Location = new System.Drawing.Point(687, 29);
			this.rdPlastik.Name = "rdPlastik";
			this.rdPlastik.Size = new System.Drawing.Size(55, 17);
			this.rdPlastik.TabIndex = 0;
			this.rdPlastik.TabStop = true;
			this.rdPlastik.Text = "Plastik";
			this.rdPlastik.UseVisualStyleBackColor = false;
			this.rdPlastik.CheckedChanged += new System.EventHandler(this.rdPlastik_CheckedChanged);
			// 
			// rdOrjinal
			// 
			this.rdOrjinal.AutoSize = true;
			this.rdOrjinal.BackColor = System.Drawing.Color.Lime;
			this.rdOrjinal.Location = new System.Drawing.Point(12, 29);
			this.rdOrjinal.Name = "rdOrjinal";
			this.rdOrjinal.Size = new System.Drawing.Size(56, 17);
			this.rdOrjinal.TabIndex = 0;
			this.rdOrjinal.TabStop = true;
			this.rdOrjinal.Text = "Orjinal";
			this.rdOrjinal.UseVisualStyleBackColor = false;
			this.rdOrjinal.CheckedChanged += new System.EventHandler(this.rdOrjinal_CheckedChanged);
			// 
			// rdIslemGormus
			// 
			this.rdIslemGormus.AutoSize = true;
			this.rdIslemGormus.BackColor = System.Drawing.Color.Yellow;
			this.rdIslemGormus.Location = new System.Drawing.Point(592, 29);
			this.rdIslemGormus.Name = "rdIslemGormus";
			this.rdIslemGormus.Size = new System.Drawing.Size(89, 17);
			this.rdIslemGormus.TabIndex = 0;
			this.rdIslemGormus.TabStop = true;
			this.rdIslemGormus.Text = "İşlem Görmüş";
			this.rdIslemGormus.UseVisualStyleBackColor = false;
			this.rdIslemGormus.CheckedChanged += new System.EventHandler(this.rdIslemGormus_CheckedChanged);
			// 
			// rdLokalBoya
			// 
			this.rdLokalBoya.AutoSize = true;
			this.rdLokalBoya.BackColor = System.Drawing.Color.Blue;
			this.rdLokalBoya.Location = new System.Drawing.Point(133, 29);
			this.rdLokalBoya.Name = "rdLokalBoya";
			this.rdLokalBoya.Size = new System.Drawing.Size(76, 17);
			this.rdLokalBoya.TabIndex = 0;
			this.rdLokalBoya.TabStop = true;
			this.rdLokalBoya.Text = "Lokal Boya";
			this.rdLokalBoya.UseVisualStyleBackColor = false;
			this.rdLokalBoya.CheckedChanged += new System.EventHandler(this.rdLokalBoya_CheckedChanged);
			// 
			// rdSokTakBoyali
			// 
			this.rdSokTakBoyali.AutoSize = true;
			this.rdSokTakBoyali.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.rdSokTakBoyali.Location = new System.Drawing.Point(446, 29);
			this.rdSokTakBoyali.Name = "rdSokTakBoyali";
			this.rdSokTakBoyali.Size = new System.Drawing.Size(140, 17);
			this.rdSokTakBoyali.TabIndex = 0;
			this.rdSokTakBoyali.TabStop = true;
			this.rdSokTakBoyali.Text = "Sökülüp Takılmış (Boyalı)";
			this.rdSokTakBoyali.UseVisualStyleBackColor = false;
			this.rdSokTakBoyali.CheckedChanged += new System.EventHandler(this.rdSokTakBoyali_CheckedChanged);
			// 
			// rdDegismis
			// 
			this.rdDegismis.AutoSize = true;
			this.rdDegismis.BackColor = System.Drawing.Color.Red;
			this.rdDegismis.Location = new System.Drawing.Point(215, 29);
			this.rdDegismis.Name = "rdDegismis";
			this.rdDegismis.Size = new System.Drawing.Size(66, 17);
			this.rdDegismis.TabIndex = 0;
			this.rdDegismis.TabStop = true;
			this.rdDegismis.Text = "Değişmiş";
			this.rdDegismis.UseVisualStyleBackColor = false;
			this.rdDegismis.CheckedChanged += new System.EventHandler(this.rdDegismis_CheckedChanged);
			// 
			// rdSokTakOrjinal
			// 
			this.rdSokTakOrjinal.AutoSize = true;
			this.rdSokTakOrjinal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.rdSokTakOrjinal.Location = new System.Drawing.Point(297, 29);
			this.rdSokTakOrjinal.Name = "rdSokTakOrjinal";
			this.rdSokTakOrjinal.Size = new System.Drawing.Size(143, 17);
			this.rdSokTakOrjinal.TabIndex = 0;
			this.rdSokTakOrjinal.TabStop = true;
			this.rdSokTakOrjinal.Text = "Sökülüp Takılmış (Orjinal)";
			this.rdSokTakOrjinal.UseVisualStyleBackColor = false;
			this.rdSokTakOrjinal.CheckedChanged += new System.EventHandler(this.rdSokTakOrjinal_CheckedChanged);
			// 
			// CarPart
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.grpControl);
			this.Name = "CarPart";
			this.Size = new System.Drawing.Size(850, 63);
			((System.ComponentModel.ISupportInitialize)(this.grpControl)).EndInit();
			this.grpControl.ResumeLayout(false);
			this.grpControl.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public DevExpress.XtraEditors.GroupControl grpControl;
		public System.Windows.Forms.RadioButton rdFolyoKapli;
		public System.Windows.Forms.RadioButton rdBoyali;
		public System.Windows.Forms.RadioButton rdPlastik;
		public System.Windows.Forms.RadioButton rdOrjinal;
		public System.Windows.Forms.RadioButton rdIslemGormus;
		public System.Windows.Forms.RadioButton rdLokalBoya;
		public System.Windows.Forms.RadioButton rdSokTakBoyali;
		public System.Windows.Forms.RadioButton rdDegismis;
		public System.Windows.Forms.RadioButton rdSokTakOrjinal;
	}
}
