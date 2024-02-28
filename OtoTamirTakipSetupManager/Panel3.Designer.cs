
namespace OtoTamirTakipSetupManager
{
	partial class Panel3
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
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
			this.treeView1 = new System.Windows.Forms.TreeView();
			((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
			this.SuspendLayout();
			// 
			// labelControl1
			// 
			this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelControl1.Appearance.Options.UseFont = true;
			this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.labelControl1.Location = new System.Drawing.Point(20, 14);
			this.labelControl1.Margin = new System.Windows.Forms.Padding(5);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(439, 64);
			this.labelControl1.TabIndex = 9;
			this.labelControl1.Text = "Yükleme Seçenekleri";
			// 
			// separatorControl1
			// 
			this.separatorControl1.Location = new System.Drawing.Point(3, 64);
			this.separatorControl1.Name = "separatorControl1";
			this.separatorControl1.Size = new System.Drawing.Size(627, 23);
			this.separatorControl1.TabIndex = 12;
			// 
			// treeView1
			// 
			this.treeView1.Location = new System.Drawing.Point(20, 86);
			this.treeView1.Name = "treeView1";
			this.treeView1.Size = new System.Drawing.Size(253, 408);
			this.treeView1.TabIndex = 13;
			// 
			// Panel3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.treeView1);
			this.Controls.Add(this.separatorControl1);
			this.Controls.Add(this.labelControl1);
			this.Name = "Panel3";
			this.Size = new System.Drawing.Size(659, 502);
			((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraEditors.SeparatorControl separatorControl1;
		private System.Windows.Forms.TreeView treeView1;
	}
}
