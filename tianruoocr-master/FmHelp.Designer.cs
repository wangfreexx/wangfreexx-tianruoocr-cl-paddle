namespace TrOCR
{

	public partial class FmHelp : global::System.Windows.Forms.Form
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
			if (flag7)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.panel_识别说明 = new System.Windows.Forms.Panel();
            this.panel_识别说明.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Items.AddRange(new object[] {
            "使用说明",
            "快捷键",
            "常见问题"});
            this.listBox1.Location = new System.Drawing.Point(10, 5);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(87, 454);
            this.listBox1.TabIndex = 1;
            this.listBox1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox1_DrawItem);
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(484, 452);
            this.webBrowser1.TabIndex = 3;
            // 
            // panel_识别说明
            // 
            this.panel_识别说明.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_识别说明.Controls.Add(this.webBrowser1);
            this.panel_识别说明.Location = new System.Drawing.Point(108, 5);
            this.panel_识别说明.Name = "panel_识别说明";
            this.panel_识别说明.Size = new System.Drawing.Size(486, 454);
            this.panel_识别说明.TabIndex = 4;
            // 
            // FmHelp
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(606, 472);
            this.Controls.Add(this.panel_识别说明);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FmHelp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "帮助";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FmHelp_Load);
            this.panel_识别说明.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		private global::System.ComponentModel.IContainer components;

		private global::System.Windows.Forms.ListBox listBox1;

		private global::System.Windows.Forms.WebBrowser webBrowser1;

		private global::System.Windows.Forms.Panel panel_识别说明;
	}
}
