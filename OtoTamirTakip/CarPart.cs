using Svg;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoTamirTakip
{
	public partial class CarPart : UserControl
	{
		public FrmKaportaBoya frmKaportaBoya;
		List<RadioButton> RadioButtons = new List<RadioButton>();
		private string _Title, SvgXml;
		public PictureBox pictureBox;
		public string SvgFilePath;
		public string IDName;
		public string Title
		{
			get { return _Title; }
			set { _Title = value; }
		}
		private Color _CarPartColor;

		public Color CarPartColor
		{
			get { return _CarPartColor; }
			set { _CarPartColor = value; }
		}

		public CarPart(string svgFilePath,string idName)
		{
			InitializeComponent();
			this.SvgFilePath = svgFilePath;
			this.IDName = idName;
			RadioButtons.Add(rdOrjinal);
			RadioButtons.Add(rdBoyali);
			RadioButtons.Add(rdLokalBoya);
			RadioButtons.Add(rdSokTakOrjinal);
			RadioButtons.Add(rdSokTakBoyali);
			RadioButtons.Add(rdDegismis);
			RadioButtons.Add(rdIslemGormus);
			RadioButtons.Add(rdPlastik);
			RadioButtons.Add(rdFolyoKapli);
			
		}

		private void groupControl5_Paint(object sender, PaintEventArgs e)
		{
			Create().Draw();
		}
		public SvgDocument Create()
		{
			var textReader = new StreamReader(SvgFilePath);

			SvgXml = textReader.ReadToEnd();
			var document = SvgDocument.FromSvg<SvgDocument>(SvgXml);

			//var path = document.Children.FindSvgElementsOf<SvgPath>().ToList();

			var part = document.Children.Where(x => x.ID == IDName)
				.Where(e => e is SvgPath)
				.Cast<SvgPath>()
				.First();
			part.Fill = new SvgColourServer(CarPartColor);


			return document;
		}
		private void rdOrjinal_CheckedChanged(object sender, EventArgs e)
		{
			CarPartColor = Color.Green;
			pictureBox.Image = Create().Draw();
		}

		private void rdBoyali_CheckedChanged(object sender, EventArgs e)
		{
			CarPartColor = Color.Orange;
			pictureBox.Image = Create().Draw();
		}

		private void rdLokalBoya_CheckedChanged(object sender, EventArgs e)
		{
			CarPartColor = Color.Blue;
			pictureBox.Image = Create().Draw();
		}

		private void rdDegismis_CheckedChanged(object sender, EventArgs e)
		{
			CarPartColor = Color.Red;
			pictureBox.Image = Create().Draw();
		}

		private void rdSokTakOrjinal_CheckedChanged(object sender, EventArgs e)
		{
			CarPartColor = Color.Purple;
			pictureBox.Image = Create().Draw();
		}

		private void rdSokTakBoyali_CheckedChanged(object sender, EventArgs e)
		{
			CarPartColor = Color.Pink;
			pictureBox.Image = Create().Draw();
		}

		private void rdIslemGormus_CheckedChanged(object sender, EventArgs e)
		{
			CarPartColor = Color.Yellow;
			pictureBox.Image = Create().Draw();
		}

		private void rdPlastik_CheckedChanged(object sender, EventArgs e)
		{
			CarPartColor = Color.Turquoise;
			pictureBox.Image = Create().Draw();
		}

		private void rdFolyoKapli_CheckedChanged(object sender, EventArgs e)
		{
			CarPartColor = Color.Gray;
			pictureBox.Image = Create().Draw();
		}
	}
}
