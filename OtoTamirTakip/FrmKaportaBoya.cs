using Svg;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using SvgPath = Svg.SvgPath;

namespace OtoTamirTakip
{
	public partial class FrmKaportaBoya : DevExpress.XtraEditors.XtraForm
	{

		string SolSvgPath = Application.StartupPath + @"\Svgs\pickup-tekkapi-sol.svg";
		string SagSvgPath = Application.StartupPath + @"\Svgs\pickup-tekkapi-sag.svg";
		CarPart SolOnCamurlukPart;
		CarPart SolArkaCamurlukPart;
		CarPart SolOnKapiPart;
		CarPart SolArkaKapiPart;

		CarPart SagOnCamurlukPart;
		CarPart SagArkaCamurlukPart;
		CarPart SagOnKapiPart;
		CarPart SagArkaKapiPart;


		public FrmKaportaBoya()
		{
			InitializeComponent();
			SolOnCamurlukPart = new CarPart(SolSvgPath,"Sol_On_Camurluk");
			SolArkaCamurlukPart = new CarPart(SolSvgPath,"Sol_Arka_Camurluk");
			SolOnKapiPart = new CarPart(SolSvgPath,"Sol_On_Kapi");
			//SolArkaKapiPart = new CarPart(SolSvgPath,"Sol_Arka_Kapi");

			SagOnCamurlukPart = new CarPart(SagSvgPath,"Sag_On_Camurluk");
			//SagArkaCamurlukPart = new CarPart(SagSvgPath,"Sag_Arka_Camurluk");
			//SagOnKapiPart = new CarPart(SagSvgPath,"Sag_On_Kapi");
			//SagArkaKapiPart = new CarPart(SagSvgPath,"Sag_Arka_Kapi");


			SolArkaCamurlukPart.grpControl.Text = "Sol Arka Çamurluk";
			SolArkaCamurlukPart.Dock = DockStyle.Top;
			SolArkaCamurlukPart.frmKaportaBoya = this;
			SolArkaCamurlukPart.pictureBox = pbSol;
			panel1.Controls.Add(SolArkaCamurlukPart);


			SolOnKapiPart.grpControl.Text = "Sol Ön Kapı";
			SolOnKapiPart.Dock = DockStyle.Top;
			SolOnKapiPart.frmKaportaBoya = this;
			SolOnKapiPart.pictureBox = pbSol;
			panel1.Controls.Add(SolOnKapiPart);

			SolOnCamurlukPart.grpControl.Text = "Sol Ön Çamurluk";
			SolOnCamurlukPart.SvgFilePath = SolSvgPath;
			SolOnCamurlukPart.Dock = DockStyle.Top;
			SolOnCamurlukPart.frmKaportaBoya = this;
			SolOnCamurlukPart.pictureBox = pbSol;
			panel1.Controls.Add(SolOnCamurlukPart);


			SagOnCamurlukPart.grpControl.Text = "Sağ Ön Çamurluk";
			SagOnCamurlukPart.Dock = DockStyle.Top;
			SagOnCamurlukPart.frmKaportaBoya = this;
			SagOnCamurlukPart.pictureBox = pbSag;
			panel2.Controls.Add(SagOnCamurlukPart);
		}

		private void FrmKaportaBoya_Load(object sender, EventArgs e)
		{
			
		}


	


	}
}