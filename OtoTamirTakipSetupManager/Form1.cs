using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoTamirTakipSetupManager
{
	public partial class Form1 : Form
	{

		List<UserControl> panels = new List<UserControl>();
		public Form1()
		{
			InitializeComponent();
			Panel1 panel1 = new Panel1();
			Panel2 panel2 = new Panel2();
			panels.Add(panel1);
			panels.Add(panel2);
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			btnGeri.Enabled = false;
			btnIptal.Enabled = false;
			btnYardim.Enabled = false;
			icerikPanel.Controls.Add(panels[0]);
		}

		private void btnİleri_Click(object sender, EventArgs e)
		{
			icerikPanel.Controls.Clear();
			icerikPanel.Controls.Add(panels[1]);
			btnGeri.Enabled = true;
		}
	}
}
