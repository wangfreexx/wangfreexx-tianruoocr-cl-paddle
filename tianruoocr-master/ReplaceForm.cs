using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace TrOCR
{

	public partial class ReplaceForm : Form
	{

		public ReplaceForm(AdvRichTextBox mm)
		{
			InitializeComponent();
			Fmok = mm;
			var componentResourceManager = new ComponentResourceManager(typeof(FmMain));
			Icon = (Icon)componentResourceManager.GetObject("minico.Icon");
			StartPosition = FormStartPosition.Manual;
		}

		private void Form2_Load(object sender, EventArgs e)
		{
		}

		private void findbutton_Click(object sender, EventArgs e)
		{
			try
			{
				if (Fmok.richTextBox1.Text != "")
				{
					p = Fmok.richTextBox1.Text.IndexOf(findtextbox.Text, p);
					if (p != -1)
					{
						Fmok.richTextBox1.Select(p, findtextbox.Text.Length);
						p++;
					}
					else
					{
						MessageBox.Show("已查找到文档尾！", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						p = 0;
					}
				}
			}
			catch
			{
				p = 0;
				MessageBox.Show("已查找到文档尾！", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		private void replacebutton_Click(object sender, EventArgs e)
		{
			if (Fmok.richTextBox1.Text != "")
			{
				p = 0;
				p = Fmok.richTextBox1.Text.IndexOf(findtextbox.Text, p);
				if (p != -1)
				{
					Fmok.richTextBox1.Select(p, findtextbox.Text.Length);
					Fmok.richTextBox1.SelectedText = replacetextBox.Text;
					p++;
					return;
				}
				MessageBox.Show("已替换完！", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				p = 0;
			}
		}

		private void replaceallbutton_Click(object sender, EventArgs e)
		{
			if (Fmok.richTextBox1.Text != "" && findtextbox.Text != "")
			{
				p = 0;
				p = Fmok.richTextBox1.Text.IndexOf(findtextbox.Text, p);
				while (p != -1)
				{
					Fmok.richTextBox1.Select(p, findtextbox.Text.Length);
					Fmok.richTextBox1.SelectedText = replacetextBox.Text;
					p = Fmok.richTextBox1.Text.IndexOf(findtextbox.Text, p);
					flag = true;
				}
				if (flag)
				{
					MessageBox.Show("替换完毕！", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					return;
				}
				if (MessageBox.Show("替换内容不存在，请重新输入！", "提醒") == DialogResult.OK)
				{
					findtextbox.Text = "";
				}
			}
		}

		private void canclebutton_Click(object sender, EventArgs e)
		{
			Hide();
			Fmok.Focus();
		}

		private void ReplaceForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			Hide();
			Fmok.Focus();
		}

		public AdvRichTextBox Fmok;

		private int p;

		private bool flag;
	}
}
