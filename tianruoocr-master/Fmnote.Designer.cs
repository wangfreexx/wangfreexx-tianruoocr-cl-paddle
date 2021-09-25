namespace TrOCR
{

	public partial class FmNote : global::System.Windows.Forms.Form
	{

		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			bool flag2 = flag;
			bool flag3 = flag2;
			bool flag4 = flag3;
			bool flag5 = flag4;
			bool flag6 = flag5;
			bool flag7 = flag6;
			bool flag8 = flag7;
			if (flag8)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			base.Location = new global::System.Drawing.Point(global::System.Windows.Forms.Screen.AllScreens[0].WorkingArea.Width - base.Width, global::System.Windows.Forms.Screen.AllScreens[0].WorkingArea.Height - base.Height);
			base.Hide();
			this.Font = new global::System.Drawing.Font(this.Font.Name, 9f / global::TrOCR.Helper.StaticValue.DpiFactor, this.Font.Style, this.Font.Unit, this.Font.GdiCharSet, this.Font.GdiVerticalFont);
			this.copyItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.components = new global::System.ComponentModel.Container();
			this.dataGridView1 = new global::System.Windows.Forms.DataGridView();
			this.contextMenuStrip1 = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.contextMenuStrip1.Renderer = new global::TrOCR.Helper.HelpRepaint.MenuItemRendererT();
			((global::System.ComponentModel.ISupportInitialize)this.dataGridView1).BeginInit();
			base.SuspendLayout();
			this.dataGridView1.BackgroundColor = global::System.Drawing.Color.White;
			this.dataGridView1.ColumnHeadersVisible = false;
			this.dataGridView1.GridColor = global::System.Drawing.Color.White;
			this.dataGridView1.Location = new global::System.Drawing.Point(0, 0);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
			this.dataGridView1.EditMode = global::System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dataGridView1.DoubleClick += new global::System.EventHandler(this.doub_click);
			this.copyItem.Text = "复制";
			this.copyItem.Click += new global::System.EventHandler(this.copy_click);
			this.contextMenuStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.copyItem
			});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new global::System.Drawing.Size(61, 4);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 12f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add(this.dataGridView1);
			base.Name = "Form1";
			base.MinimizeBox = false;
			base.MaximizeBox = false;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Text = "记录";
			base.Load += new global::System.EventHandler(this.Form1_Load);
			((global::System.ComponentModel.ISupportInitialize)this.dataGridView1).EndInit();
			base.ResumeLayout(false);
		}

		private global::System.ComponentModel.IContainer components;

		private global::System.Windows.Forms.ToolStripMenuItem copyItem;

		private global::System.Windows.Forms.DataGridView dataGridView1;

		private global::System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
	}
}
