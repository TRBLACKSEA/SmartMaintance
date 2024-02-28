
namespace OtoTamirTakipSetupManager
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnGeri = new System.Windows.Forms.Button();
			this.btnİleri = new System.Windows.Forms.Button();
			this.btnIptal = new System.Windows.Forms.Button();
			this.btnYardim = new System.Windows.Forms.Button();
			this.icerikPanel = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.panel1.Controls.Add(this.btnYardim);
			this.panel1.Controls.Add(this.btnIptal);
			this.panel1.Controls.Add(this.btnİleri);
			this.panel1.Controls.Add(this.btnGeri);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 502);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(864, 43);
			this.panel1.TabIndex = 2;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.panel2.Controls.Add(this.icerikPanel);
			this.panel2.Controls.Add(this.pictureBox1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(864, 502);
			this.panel2.TabIndex = 3;
			// 
			// btnGeri
			// 
			this.btnGeri.Location = new System.Drawing.Point(202, 6);
			this.btnGeri.Name = "btnGeri";
			this.btnGeri.Size = new System.Drawing.Size(158, 31);
			this.btnGeri.TabIndex = 0;
			this.btnGeri.Text = "Geri";
			this.btnGeri.UseVisualStyleBackColor = true;
			// 
			// btnİleri
			// 
			this.btnİleri.Location = new System.Drawing.Point(364, 6);
			this.btnİleri.Name = "btnİleri";
			this.btnİleri.Size = new System.Drawing.Size(162, 31);
			this.btnİleri.TabIndex = 0;
			this.btnİleri.Text = "İleri";
			this.btnİleri.UseVisualStyleBackColor = true;
			this.btnİleri.Click += new System.EventHandler(this.btnİleri_Click);
			// 
			// btnIptal
			// 
			this.btnIptal.Location = new System.Drawing.Point(530, 6);
			this.btnIptal.Name = "btnIptal";
			this.btnIptal.Size = new System.Drawing.Size(162, 31);
			this.btnIptal.TabIndex = 0;
			this.btnIptal.Text = "İptal";
			this.btnIptal.UseVisualStyleBackColor = true;
			// 
			// btnYardim
			// 
			this.btnYardim.Location = new System.Drawing.Point(694, 6);
			this.btnYardim.Name = "btnYardim";
			this.btnYardim.Size = new System.Drawing.Size(162, 31);
			this.btnYardim.TabIndex = 0;
			this.btnYardim.Text = "Yardım";
			this.btnYardim.UseVisualStyleBackColor = true;
			// 
			// icerikPanel
			// 
			this.icerikPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.icerikPanel.Location = new System.Drawing.Point(205, 0);
			this.icerikPanel.Name = "icerikPanel";
			this.icerikPanel.Size = new System.Drawing.Size(659, 502);
			this.icerikPanel.TabIndex = 1;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
			this.pictureBox1.Image = global::OtoTamirTakipSetupManager.Properties.Resources._1;
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(205, 502);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(864, 545);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Oto Tamir Takip Setup Manager";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btnYardim;
		private System.Windows.Forms.Button btnIptal;
		private System.Windows.Forms.Button btnİleri;
		private System.Windows.Forms.Button btnGeri;
		private System.Windows.Forms.Panel icerikPanel;
	}
}

