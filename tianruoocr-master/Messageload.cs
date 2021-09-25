using System;
using System.Drawing;
using System.Windows.Forms;

namespace TrOCR
{

	public partial class Messageload : Form
	{

		public Messageload()
		{
			InitializeComponent();
		}

		public void Form1_Load(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
		}

		public void InitializeComponent()
		{
			SuspendLayout();
			AutoScaleDimensions = new SizeF(6f, 12f);
			FormBorderStyle = FormBorderStyle.None;
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(0, 0);
			ForeColor = Color.Black;
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "Form1";
			Text = "弹窗";
			Load += Form1_Load;
			ResumeLayout(false);
			PerformLayout();
		}
	}
}
