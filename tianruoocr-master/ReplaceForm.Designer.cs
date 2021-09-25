namespace TrOCR
{

	public partial class ReplaceForm : global::System.Windows.Forms.Form
	{

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.findtextbox = new global::System.Windows.Forms.TextBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.replacetextBox = new global::System.Windows.Forms.TextBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.findbutton = new global::System.Windows.Forms.Button();
			this.replacebutton = new global::System.Windows.Forms.Button();
			this.replaceallbutton = new global::System.Windows.Forms.Button();
			this.canclebutton = new global::System.Windows.Forms.Button();
			base.SuspendLayout();
			this.findtextbox.Location = new global::System.Drawing.Point(77, 7);
			this.findtextbox.Name = "findtextbox";
			this.findtextbox.Size = new global::System.Drawing.Size(280, 21);
			this.findtextbox.TabIndex = 3;
			this.findtextbox.ImeMode = global::System.Windows.Forms.ImeMode.HangulFull;
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("宋体", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 134);
			this.label1.Location = new global::System.Drawing.Point(12, 11);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(59, 12);
			this.label1.TabIndex = 2;
			this.label1.Text = "查找内容:";
			this.replacetextBox.Location = new global::System.Drawing.Point(77, 43);
			this.replacetextBox.Name = "replacetextBox";
			this.replacetextBox.Size = new global::System.Drawing.Size(280, 21);
			this.replacetextBox.TabIndex = 5;
			this.replacetextBox.ImeMode = global::System.Windows.Forms.ImeMode.HangulFull;
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("宋体", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 134);
			this.label2.Location = new global::System.Drawing.Point(12, 48);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(59, 12);
			this.label2.TabIndex = 4;
			this.label2.Text = "替换内容:";
			this.findbutton.Location = new global::System.Drawing.Point(12, 75);
			this.findbutton.Name = "findbutton";
			this.findbutton.Size = new global::System.Drawing.Size(75, 23);
			this.findbutton.TabIndex = 6;
			this.findbutton.Text = "查找下一个";
			this.findbutton.UseVisualStyleBackColor = false;
			this.findbutton.Click += new global::System.EventHandler(this.findbutton_Click);
			this.replacebutton.Location = new global::System.Drawing.Point(100, 75);
			this.replacebutton.Name = "replacebutton";
			this.replacebutton.Size = new global::System.Drawing.Size(75, 23);
			this.replacebutton.TabIndex = 7;
			this.replacebutton.Text = "替换";
			this.replacebutton.UseVisualStyleBackColor = false;
			this.replacebutton.Click += new global::System.EventHandler(this.replacebutton_Click);
			this.replaceallbutton.Location = new global::System.Drawing.Point(191, 75);
			this.replaceallbutton.Name = "replaceallbutton";
			this.replaceallbutton.Size = new global::System.Drawing.Size(75, 23);
			this.replaceallbutton.TabIndex = 8;
			this.replaceallbutton.Text = "全部替换";
			this.replaceallbutton.UseVisualStyleBackColor = false;
			this.replaceallbutton.Click += new global::System.EventHandler(this.replaceallbutton_Click);
			this.canclebutton.Location = new global::System.Drawing.Point(282, 75);
			this.canclebutton.Name = "canclebutton";
			this.canclebutton.Size = new global::System.Drawing.Size(75, 23);
			this.canclebutton.TabIndex = 9;
			this.canclebutton.Text = "取消";
			this.canclebutton.UseVisualStyleBackColor = false;
			this.canclebutton.Click += new global::System.EventHandler(this.canclebutton_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 12f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.White;
			base.ClientSize = new global::System.Drawing.Size(366, 105);
			base.Controls.Add(this.canclebutton);
			base.Controls.Add(this.replaceallbutton);
			base.Controls.Add(this.replacebutton);
			base.Controls.Add(this.findbutton);
			base.Controls.Add(this.replacetextBox);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.findtextbox);
			base.Controls.Add(this.label1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "ReplaceForm";
			this.Text = "替换";
			base.TopMost = true;
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.ReplaceForm_FormClosing);
			base.Load += new global::System.EventHandler(this.Form2_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private global::System.ComponentModel.IContainer components;

		private global::System.Windows.Forms.TextBox findtextbox;

		private global::System.Windows.Forms.Label label1;

		private global::System.Windows.Forms.TextBox replacetextBox;

		private global::System.Windows.Forms.Label label2;

		private global::System.Windows.Forms.Button findbutton;

		private global::System.Windows.Forms.Button replacebutton;

		private global::System.Windows.Forms.Button replaceallbutton;

		private global::System.Windows.Forms.Button canclebutton;
	}
}
