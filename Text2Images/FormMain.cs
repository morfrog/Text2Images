using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text2Images
{
	public partial class FormMain : Form
	{
		public FormMain()
		{
			InitializeComponent();
			 _bmp = new Bitmap(2000, 50);
			_graphics = Graphics.FromImage(_bmp);
			comboBoxFonts.Items.AddRange( FontFamily.Families.Select(f=>f.Name).ToArray());
			comboBoxFonts.SelectedIndex = Math.Max(comboBoxFonts.Items.IndexOf("Arial"), 0);
		}

		Bitmap _bmp;
		Graphics _graphics;

		class DrawOptions
		{
			public Font Font { get; set; }

			public Brush ForeBrush { get; set; }
			public Brush BackBrush { get; set; }

			public int PaddingHorizontal { get; set; }

			public int PaddingVertical { get; set; }
		}

		private void button2_Click(object sender, EventArgs e)
		{
			var showStatus = !ModifierKeys.HasFlag(Keys.Shift);
			var drawOptions = new DrawOptions
			{
				Font = new Font(comboBoxFonts.SelectedItem.ToString(), (float)numericUpDownFontSize.Value),
				ForeBrush = new SolidBrush(buttonColorFore.BackColor),
				BackBrush = new SolidBrush(buttonColorBack.BackColor),
				PaddingHorizontal = (int)numericUpDownPaddingHorizontal.Value,
				PaddingVertical = (int)numericUpDownPaddingVertical.Value
			};

			var lines = textBoxText
				.Text
				.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
			var headLen = lines.Count().ToString().Length;
			var headFmt = $"D{headLen}";

			var fileLen = (255 - (textBoxOutput.Text.Length+1)) - 4 /*extension*/ - (headLen + 1);

			int index;
			for (index = 0; index < lines.Length; index++ )
			{
				var line = lines[index];
				var name = (line.Length > fileLen ? line.Substring(0, fileLen) : line).Replace("\\","").Replace("/","");
				var file = System.IO.Path.Combine(textBoxOutput.Text, $"{(index + 1).ToString(headFmt)}.{name}.jpg");
			
				CreateTextImage(line, drawOptions, file);
			}

			if (showStatus)
			{
				var msg = $"{index} files written to:{Environment.NewLine}{Environment.NewLine}  {textBoxOutput.Text}";
				MessageBox.Show(msg, this.Text);
			}
		}

		private void CreateTextImage(string text, DrawOptions drawOptions, string fileName)
		{
			using (var fileStream = new System.IO.FileStream(fileName, FileMode.Create))
			{
				var size = _graphics.MeasureString(text, drawOptions.Font).ToSize();
				size = new Size(size.Width + (drawOptions.PaddingHorizontal * 2), size.Height + (drawOptions.PaddingVertical * 2));
				Bitmap bmp = new Bitmap(size.Width, size.Height);

				using (Graphics g = Graphics.FromImage(bmp))
				{
					g.FillRectangle(drawOptions.BackBrush, new Rectangle(0, 0, size.Width, size.Height));
					g.DrawString(text, drawOptions.Font, drawOptions.ForeBrush, drawOptions.PaddingHorizontal, drawOptions.PaddingVertical);
				}

				bmp.Save(fileStream, System.Drawing.Imaging.ImageFormat.Jpeg);
				bmp.Dispose();
			}
		}

		private void DoColor(Button btn)
		{
			colorDialog1.Color = btn.BackColor;
			if( colorDialog1.ShowDialog() == DialogResult.OK )
			{
				btn.BackColor = colorDialog1.Color;
			}
		}

		private void buttonColorFore_Click(object sender, EventArgs e)
		{
			DoColor(buttonColorFore);
		}

		private void buttonColorBack_Click(object sender, EventArgs e)
		{
			DoColor(buttonColorBack);
		}

		private void buttonFolderOutput_Click(object sender, EventArgs e)
		{
			folderBrowserDialog1.SelectedPath = textBoxOutput.Text;

			if(folderBrowserDialog1.ShowDialog() == DialogResult.OK )
			{
				textBoxOutput.Text = folderBrowserDialog1.SelectedPath;
			}
		}
	}
}
