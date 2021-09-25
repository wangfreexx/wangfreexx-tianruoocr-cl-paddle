using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using TrOCR.Helper;

namespace TrOCR
{

	public partial class FmNote
    {

		public FmNote()
		{
			InitializeComponent();
			Focus();
			TopMost = true;
			ShowInTaskbar = false;
			Location = new Point(Screen.AllScreens[0].WorkingArea.Width - Width, Screen.AllScreens[0].WorkingArea.Height - Height);
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			var componentResourceManager = new ComponentResourceManager(typeof(FmMain));
			Icon = (Icon)componentResourceManager.GetObject("minico.Icon");
			dataGridView1.ColumnCount = 1;
			dataGridView1.RowCount = StaticValue.NoteCount;
			dataGridView1.Columns[0].Width = Convert.ToInt32(400f * Program.Factor);
			dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
			dataGridView1.AllowUserToResizeRows = false;
			dataGridView1.AllowUserToResizeColumns = false;
			for (var i = 0; i < StaticValue.NoteCount; i++)
			{
				var flag = i < 9;
				if (flag)
				{
					dataGridView1.Rows[i].Cells[0].Value = "0" + (i + 1) + "." + StaticValue.v_note[i];
				}
				else
				{
					dataGridView1.Rows[i].Cells[0].Value = (i + 1) + "." + StaticValue.v_note[i];
				}
			}
			dataGridView1.Columns[0].DefaultCellStyle.SelectionBackColor = Color.DodgerBlue;
			dataGridView1.Size = new Size(Convert.ToInt32(402f * Program.Factor), StaticValue.NoteCount * dataGridView1.Rows[0].Cells[0].Size.Height + 2);
			ClientSize = dataGridView1.Size;
			base.MaximumSize = new Size(Size.Width, Screen.GetWorkingArea(this).Height / 4 * 3);
			dataGridView1.MaximumSize = new Size(Size.Width, Screen.GetWorkingArea(this).Height / 4 * 3 - 5);
		}

		private void copy_click(object sender, EventArgs e)
		{
			var text = "";
			var array = new int[dataGridView1.SelectedRows.Count];
			var num = 0;
			foreach (var obj in dataGridView1.SelectedRows)
			{
				var dataGridViewRow = (DataGridViewRow)obj;
				array[num] = Convert.ToInt32(dataGridViewRow.Cells[0].Value.ToString().Substring(0, 2));
				num++;
			}
			var array2 = array;
			for (var i = 0; i < array2.Length - 1; i++)
			{
				for (var j = 0; j < array2.Length - 1 - i; j++)
				{
					var flag = array2[j] > array2[j + 1];
					var flag2 = flag;
					var flag3 = flag2;
					var flag4 = flag3;
					var flag5 = flag4;
					var flag6 = flag5;
					var flag7 = flag6;
					var flag8 = flag7;
					if (flag8)
					{
						var num2 = array2[j];
						array2[j] = array2[j + 1];
						array2[j + 1] = num2;
					}
				}
			}
			for (var k = 0; k < array2.Length; k++)
			{
				var flag9 = k == array2.Length - 1;
				var flag10 = flag9;
				var flag11 = flag10;
				var flag12 = flag11;
				var flag13 = flag12;
				var flag14 = flag13;
				var flag15 = flag14;
				var flag16 = flag15;
				if (flag16)
				{
					text += dataGridView1.Rows[array2[k] - 1].Cells[0].Value.ToString().Remove(0, 3);
				}
				else
				{
					text = text + dataGridView1.Rows[array2[k] - 1].Cells[0].Value.ToString().Remove(0, 3) + "\r\n";
				}
			}
			Clipboard.SetDataObject(text);
		}


        public string TextNote
		{
			get => null;
            set
			{
				for (var i = 0; i < StaticValue.NoteCount; i++)
				{
					var flag = i < 9;
					var flag2 = flag;
					var flag3 = flag2;
					var flag4 = flag3;
					var flag5 = flag4;
					var flag6 = flag5;
					var flag7 = flag6;
					var flag8 = flag7;
					if (flag8)
					{
						dataGridView1.Rows[i].Cells[0].Value = "0" + (i + 1) + "." + StaticValue.v_note[i];
					}
					else
					{
						dataGridView1.Rows[i].Cells[0].Value = (i + 1) + "." + StaticValue.v_note[i];
					}
				}
			}
		}

		protected override void WndProc(ref Message m)
		{
			if (m.Msg == 274 && (int)m.WParam == 61536)
			{
				Visible = false;
				return;
			}
			if (m.Msg == 163)
			{
				Location = new Point(Screen.AllScreens[0].WorkingArea.Width - Width, Screen.AllScreens[0].WorkingArea.Height - Height);
			}
			base.WndProc(ref m);
		}

		private void doub_click(object sender, EventArgs e)
		{
			var flag = dataGridView1.SelectedCells[0].Value.ToString().Remove(0, 3) != "";
			var flag2 = flag;
			var flag3 = flag2;
			var flag4 = flag3;
			var flag5 = flag4;
			var flag6 = flag5;
			var flag7 = flag6;
			var flag8 = flag7;
			if (flag8)
			{
				Clipboard.SetDataObject(dataGridView1.SelectedCells[0].Value.ToString().Remove(0, 3));
				CommonHelper.ShowHelpMsg("已复制");
			}
		}


		public string TextNoteChange
		{
			get => null;
            set
			{
				dataGridView1.Rows.Clear();
				dataGridView1.ColumnCount = 1;
				dataGridView1.RowCount = StaticValue.NoteCount;
				dataGridView1.Columns[0].Width = Convert.ToInt32(400f * Program.Factor);
				dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
				dataGridView1.AllowUserToResizeRows = false;
				dataGridView1.AllowUserToResizeColumns = false;
				for (var i = 0; i < StaticValue.NoteCount; i++)
				{
					var flag = i < 9;
					var flag2 = flag;
					var flag3 = flag2;
					var flag4 = flag3;
					var flag5 = flag4;
					var flag6 = flag5;
					var flag7 = flag6;
					var flag8 = flag7;
					if (flag8)
					{
						dataGridView1.Rows[i].Cells[0].Value = "0" + (i + 1) + ".";
					}
					else
					{
						dataGridView1.Rows[i].Cells[0].Value = (i + 1) + ".";
					}
				}
				dataGridView1.Columns[0].DefaultCellStyle.SelectionBackColor = Color.DodgerBlue;
				dataGridView1.Size = new Size(Convert.ToInt32(402f * Program.Factor), StaticValue.NoteCount * dataGridView1.Rows[0].Cells[0].Size.Height + 2);
				ClientSize = dataGridView1.Size;
				base.MaximumSize = new Size(Size.Width, Screen.GetWorkingArea(this).Height / 4 * 3);
				dataGridView1.MaximumSize = new Size(Size.Width, Screen.GetWorkingArea(this).Height / 4 * 3 - 5);
			}
		}
	}
}
