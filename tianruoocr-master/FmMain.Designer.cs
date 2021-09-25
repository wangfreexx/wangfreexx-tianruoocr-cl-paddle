namespace TrOCR
{

	public sealed partial class FmMain : global::System.Windows.Forms.Form
	{

		protected override void Dispose(bool disposing)
		{
			global::TrOCR.Helper.HelpWin32.ChangeClipboardChain(base.Handle, this.nextClipboardViewer);
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::TrOCR.FmMain));
			this.minico = new global::System.Windows.Forms.NotifyIcon(this.components);
			this.toolStripSeparator1 = new global::System.Windows.Forms.ToolStripSeparator();
			this.toolStrip = new global::System.Windows.Forms.ToolStripMenuItem();
			this.trans_input = new global::System.Windows.Forms.ToolStripMenuItem();
			this.trans_google = new global::System.Windows.Forms.ToolStripMenuItem();
			this.trans_baidu = new global::System.Windows.Forms.ToolStripMenuItem();
			this.trans_tencent = new global::System.Windows.Forms.ToolStripMenuItem();
			this.baidu_table = new global::System.Windows.Forms.ToolStripMenuItem();
			this.ali_table = new global::System.Windows.Forms.ToolStripMenuItem();
			this.ocr_table = new global::System.Windows.Forms.ToolStripMenuItem();
			this.menu = new global::System.Windows.Forms.ContextMenuStrip();
			this.menu.Renderer = new global::TrOCR.Helper.HelpRepaint.MenuItemRendererT();
			this.ch_en = new global::System.Windows.Forms.ToolStripMenuItem();
			this.jap = new global::System.Windows.Forms.ToolStripMenuItem();
			this.kor = new global::System.Windows.Forms.ToolStripMenuItem();
			this.pinyin = new global::System.Windows.Forms.ToolStripMenuItem();
			this.customize_Proxy = new global::System.Windows.Forms.ToolStripMenuItem();
			this.null_Proxy = new global::System.Windows.Forms.ToolStripMenuItem();
			this.system_Proxy = new global::System.Windows.Forms.ToolStripMenuItem();
			this.Proxy = new global::System.Windows.Forms.ToolStripMenuItem();
			this.left_right = new global::System.Windows.Forms.ToolStripMenuItem();
			this.righ_left = new global::System.Windows.Forms.ToolStripMenuItem();
			this.Main_copy = new global::System.Windows.Forms.ToolStripMenuItem();
			this.Main_paste = new global::System.Windows.Forms.ToolStripMenuItem();
			this.Main_selectall = new global::System.Windows.Forms.ToolStripMenuItem();
			this.Main_jiekou = new global::System.Windows.Forms.ToolStripMenuItem();
			this.Main_exit = new global::System.Windows.Forms.ToolStripMenuItem();
			this.Main_change = new global::System.Windows.Forms.ToolStripMenuItem();
			this.zh_tra = new global::System.Windows.Forms.ToolStripMenuItem();
			this.tra_zh = new global::System.Windows.Forms.ToolStripMenuItem();
			this.str_Upper = new global::System.Windows.Forms.ToolStripMenuItem();
			this.Upper_str = new global::System.Windows.Forms.ToolStripMenuItem();
			this.speak = new global::System.Windows.Forms.ToolStripMenuItem();
			this.Trans_copy = new global::System.Windows.Forms.ToolStripMenuItem();
			this.Trans_paste = new global::System.Windows.Forms.ToolStripMenuItem();
			this.Trans_SelectAll = new global::System.Windows.Forms.ToolStripMenuItem();
			this.Trans_close = new global::System.Windows.Forms.ToolStripMenuItem();
			this.Trans_Voice = new global::System.Windows.Forms.ToolStripMenuItem();
			this.sougou = new global::System.Windows.Forms.ToolStripMenuItem();
			this.Mathfuntion = new global::System.Windows.Forms.ToolStripMenuItem();
			this.tencent = new global::System.Windows.Forms.ToolStripMenuItem();
			this.baidu = new global::System.Windows.Forms.ToolStripMenuItem();
			this.shupai = new global::System.Windows.Forms.ToolStripMenuItem();
			this.write = new global::System.Windows.Forms.ToolStripMenuItem();
			this.tencent_v = new global::System.Windows.Forms.ToolStripMenuItem();
			this.baidu_s = new global::System.Windows.Forms.ToolStripMenuItem();
			this.baidu_v = new global::System.Windows.Forms.ToolStripMenuItem();
			this.tencent = new global::System.Windows.Forms.ToolStripMenuItem();
			this.baidu = new global::System.Windows.Forms.ToolStripMenuItem();
			this.youdao = new global::System.Windows.Forms.ToolStripMenuItem();
			this.Chinese = new global::System.Windows.Forms.ToolStripMenuItem();
			this.English = new global::System.Windows.Forms.ToolStripMenuItem();
			this.Split = new global::System.Windows.Forms.ToolStripMenuItem();
			this.Restore = new global::System.Windows.Forms.ToolStripMenuItem();
			this.menu_copy = new global::System.Windows.Forms.ContextMenuStrip();
			this.menu_copy.Renderer = new global::TrOCR.Helper.HelpRepaint.MenuItemRendererT();
			this.PictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.RichBoxBody = new global::TrOCR.AdvRichTextBox();
			this.RichBoxBody_T = new global::TrOCR.AdvRichTextBox();
			this.minico.BalloonTipIcon = global::System.Windows.Forms.ToolTipIcon.Info;
			this.minico.BalloonTipText = "最小化到任务栏";
			this.minico.BalloonTipTitle = "提示";
			this.minico.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("minico.Icon");
			this.minico.Text = "双击开始截图识别";
			this.minico.Visible = true;
			this.minico.MouseDoubleClick += new global::System.Windows.Forms.MouseEventHandler(this.tray_double_Click);
			this.font_base.Width = 18f * this.F_factor;
			this.font_base.Height = 17f * this.F_factor;
			this.RichBoxBody_T.Visible = false;
			this.RichBoxBody.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.RichBoxBody.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.RichBoxBody.Location = new global::System.Drawing.Point(0, 0);
			this.RichBoxBody.Name = "htmlTextBoxBody";
			this.RichBoxBody.ImeMode = global::System.Windows.Forms.ImeMode.HangulFull;
			this.RichBoxBody.TabIndex = 200;
			this.RichBoxBody.Text_flag = "天若幽心";
			this.RichBoxBody_T.ImeMode = global::System.Windows.Forms.ImeMode.HangulFull;
			this.Trans_copy.Text = "复制";
			this.Trans_copy.Click += new global::System.EventHandler(this.Trans_copy_Click);
			this.Trans_paste.Text = "粘贴";
			this.Trans_paste.Click += new global::System.EventHandler(this.Trans_paste_Click);
			this.Trans_SelectAll.Text = "全选";
			this.Trans_SelectAll.Click += new global::System.EventHandler(this.Trans_SelectAll_Click);
			this.Trans_close.Text = "关闭";
			this.Trans_close.Click += new global::System.EventHandler(this.Trans_close_Click);
			this.Trans_Voice.Text = "朗读";
			this.Trans_Voice.Click += new global::System.EventHandler(this.Trans_Voice_Click);
			this.trans_input.Text = "接口";
			this.trans_input.Click += new global::System.EventHandler(this.Trans_SelectAll_Click);
			this.trans_google.Text = "谷歌√";
			this.trans_google.Click += new global::System.EventHandler(this.Trans_google_Click);
			this.trans_baidu.Text = "百度";
			this.trans_baidu.Click += new global::System.EventHandler(this.Trans_baidu_Click);
			this.trans_tencent.Text = "腾讯";
			this.trans_tencent.Click += new global::System.EventHandler(this.Trans_tencent_Click);
			this.menu_copy.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.Trans_copy,
				this.Trans_paste,
				this.Trans_SelectAll,
				this.Trans_Voice,
				this.trans_input,
				this.Trans_close
			});
			this.trans_input.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.trans_google,
				this.trans_baidu,
				this.trans_tencent
			});
			this.menu_copy.Font = new global::System.Drawing.Font("微软雅黑", 9f / global::TrOCR.Helper.StaticValue.DpiFactor, global::System.Drawing.FontStyle.Regular);
			this.Main_copy.Text = "复制";
			this.Main_copy.Click += new global::System.EventHandler(this.MainCopyClick);
			this.Main_paste.Text = "粘贴";
			this.Main_paste.Click += new global::System.EventHandler(this.Main_paste_Click);
			this.Main_selectall.Text = "全选";
			this.Main_selectall.Click += new global::System.EventHandler(this.Main_SelectAll_Click);
			this.speak.Text = "朗读";
			this.speak.Click += new global::System.EventHandler(this.Main_Voice_Click);
			this.baidu_s.Text = "搜索";
			this.baidu_s.Click += new global::System.EventHandler(this.SearchSelText);
			this.Main_change.Text = "转换";
			this.Main_jiekou.Text = "接口";
			this.Main_exit.Text = "退出";
			this.Main_exit.Click += new global::System.EventHandler(this.trayExitClick);
			this.menu.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.Main_copy,
				this.Main_paste,
				this.Main_selectall,
				this.speak,
				this.baidu_s,
				this.Main_change,
				this.Main_jiekou,
				this.Main_exit
			});
			this.menu.Font = new global::System.Drawing.Font("微软雅黑", 9f / global::TrOCR.Helper.StaticValue.DpiFactor, global::System.Drawing.FontStyle.Regular);
			this.sougou.Text = "搜狗√";
			this.sougou.Click += new global::System.EventHandler(this.OCR_sougou_Click);
			this.Mathfuntion.Text = "公式";
			this.Mathfuntion.Click += new global::System.EventHandler(this.OCR_Mathfuntion_Click);
			this.tencent.Text = "腾讯";
			this.tencent.Click += new global::System.EventHandler(this.OCR_tencent_Click);
			this.baidu.Text = "百度";
			this.baidu.Click += new global::System.EventHandler(this.OCR_baidu_Click);
			this.youdao.Text = "有道";
			this.youdao.Click += new global::System.EventHandler(this.OCR_youdao_Click);
			this.ocr_table.Text = "表格";
			this.baidu_table.Text = "百度";
			this.baidu_table.Click += new global::System.EventHandler(this.OCR_baidutable_Click);
			this.ali_table.Text = "阿里";
			this.ali_table.Click += new global::System.EventHandler(this.OCR_ailitable_Click);
			this.ocr_table.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.baidu_table,
				this.ali_table
			});
			this.shupai.Text = "竖排";
			this.shupai.Click += new global::System.EventHandler(this.OCR_shupai_Click);
			this.write.Text = "手写";
			this.write.Click += new global::System.EventHandler(this.OCR_write_Click);
			this.Chinese.Text = "中文标点";
			this.Chinese.Click += new global::System.EventHandler(this.change_Chinese_Click);
			this.English.Text = "英文标点";
			this.English.Click += new global::System.EventHandler(this.change_English_Click);
			this.zh_tra.Text = "中文繁体";
			this.zh_tra.Click += new global::System.EventHandler(this.change_zh_tra_Click);
			this.tra_zh.Text = "中文简体";
			this.tra_zh.Click += new global::System.EventHandler(this.change_tra_zh_Click);
			this.str_Upper.Text = "英文大写";
			this.str_Upper.Click += new global::System.EventHandler(this.change_str_Upper_Click);
			this.Upper_str.Text = "英文小写";
			this.Upper_str.Click += new global::System.EventHandler(this.change_Upper_str_Click);
			this.pinyin.Text = "汉语拼音";
			this.pinyin.Click += new global::System.EventHandler(this.change_pinyin_Click);
			this.change_button = this.Main_change;
			this.change_button.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.Chinese,
				this.English,
				this.zh_tra,
				this.tra_zh,
				this.str_Upper,
				this.Upper_str,
				this.pinyin
			});
			this.interface_button = this.Main_jiekou;
			this.interface_button.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.sougou,
				this.tencent,
				this.youdao,
				this.baidu,
				this.toolStripSeparator1,
				this.Mathfuntion,
				this.ocr_table,
				this.shupai
			});
			if (global::TrOCR.Helper.IniHelper.GetValue("配置", "接口") == "百度")
			{
				this.ch_en.Text = "中英√";
			}
			else
			{
				this.ch_en.Text = "中英";
			}
			this.ch_en.Click += new global::System.EventHandler(this.OCR_baidu_Ch_and_En_Click);
			this.jap.Text = "日语";
			this.jap.Click += new global::System.EventHandler(this.OCR_baidu_Jap_Click);
			this.kor.Text = "韩语";
			this.kor.Click += new global::System.EventHandler(this.OCR_baidu_Kor_Click);
			((global::System.Windows.Forms.ToolStripDropDownItem)this.baidu).DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.ch_en,
				this.jap,
				this.kor
			});
			this.left_right.Text = "从左向右";
			this.left_right.Click += new global::System.EventHandler(this.OCR_lefttoright_Click);
			this.righ_left.Text = "从右向左";
			this.righ_left.Click += new global::System.EventHandler(this.OCR_righttoleft_Click);
			((global::System.Windows.Forms.ToolStripDropDownItem)this.shupai).DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.left_right,
				this.righ_left
			});
			this.RichBoxBody.ContextMenuStrip1 = this.menu;
			this.RichBoxBody_T.ContextMenuStrip1 = this.menu_copy;
			this.PictureBox1.Image = (global::System.Drawing.Image)new global::System.ComponentModel.ComponentResourceManager(typeof(global::TrOCR.FmMain)).GetObject("loadcat.gif");
			this.PictureBox1.Size = new global::System.Drawing.Size(85, 85);
			this.PictureBox1.Location = (global::System.Drawing.Point)new global::System.Drawing.Size((int)this.font_base.Width * 34 - this.PictureBox1.Size.Width / 2, (int)(110f * this.F_factor));
			this.PictureBox1.BackColor = global::System.Drawing.Color.White;
			this.PictureBox1.Visible = false;
			base.SuspendLayout();
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.Manual;
			base.Location = (global::System.Drawing.Point)new global::System.Drawing.Size(global::System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width / 2 - global::System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width / 10, global::System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height / 2 - global::System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height / 6);
			base.Size = new global::System.Drawing.Size((int)this.font_base.Width * 23, (int)this.font_base.Height * 24);
			base.Controls.Add(this.RichBoxBody_T);
			base.Controls.Add(this.PictureBox1);
			base.Controls.Add(this.RichBoxBody);
			base.Load += new global::System.EventHandler(this.Load_Click);
			base.Resize += new global::System.EventHandler(this.Form_Resize);
			base.Name = "Form1";
			this.Text = "耗时：";
			if (global::TrOCR.Helper.IniHelper.GetValue("工具栏", "顶置") == "True")
			{
				base.TopMost = true;
			}
			else
			{
				base.TopMost = false;
			}
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("minico.Icon");
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private global::System.ComponentModel.IContainer components;

		public global::System.Windows.Forms.NotifyIcon minico;

		public global::System.Windows.Forms.ContextMenuStrip menu;

		private global::System.Windows.Forms.ToolStripMenuItem toolStrip;

		public global::System.Windows.Forms.ToolStripMenuItem Main_copy;

		public global::System.Windows.Forms.ToolStripMenuItem Main_paste;

		public global::System.Windows.Forms.ToolStripMenuItem Main_selectall;

		public global::System.Windows.Forms.ToolStripMenuItem Main_exit;

		public global::System.Windows.Forms.ToolStripMenuItem Main_jiekou;

		public global::System.Windows.Forms.ToolStripItem sougou;

		public global::System.Windows.Forms.ToolStripItem tencent;

		public global::System.Windows.Forms.ToolStripItem baidu;

		public global::System.Windows.Forms.ToolStripItem youdao;

		public global::System.Windows.Forms.ToolStripDropDownItem interface_button;

		public global::System.Windows.Forms.ToolStripMenuItem Main_change;

		public global::System.Windows.Forms.ToolStripDropDownItem change_button;

		public global::System.Windows.Forms.ToolStripMenuItem Chinese;

		public global::System.Windows.Forms.ToolStripMenuItem English;

		public global::TrOCR.AdvRichTextBox RichBoxBody_T;

		public global::System.Windows.Forms.ContextMenuStrip menu_copy;

		public global::System.Windows.Forms.ToolStripMenuItem Trans_copy;

		public global::System.Windows.Forms.ToolStripMenuItem Trans_paste;

		public global::System.Windows.Forms.ToolStripMenuItem Trans_SelectAll;

		public global::System.Windows.Forms.ToolStripMenuItem Trans_close;

		public global::System.Drawing.SizeF font_base;

		public global::System.Windows.Forms.PictureBox PictureBox1;

		public global::System.Windows.Forms.ToolStripMenuItem Split;

		public global::System.Windows.Forms.ToolStripMenuItem Restore;

		public float F_factor;

		private global::TrOCR.AdvRichTextBox RichBoxBody;

		private global::System.IntPtr nextClipboardViewer;

		public global::System.Windows.Forms.ToolStripMenuItem baidu_v;

		public global::System.Windows.Forms.ToolStripMenuItem tencent_v;

		public global::System.Windows.Forms.ToolStripMenuItem baidu_s;

		private global::System.Windows.Forms.ToolStripMenuItem speak;

		private global::System.Windows.Forms.ToolStripMenuItem Trans_Voice;

		private global::System.Windows.Forms.ToolStripMenuItem zh_tra;

		private global::System.Windows.Forms.ToolStripMenuItem tra_zh;

		private global::System.Windows.Forms.ToolStripMenuItem str_Upper;

		private global::System.Windows.Forms.ToolStripMenuItem Upper_str;

		private global::System.Windows.Forms.ToolStripMenuItem ch_en;

		private global::System.Windows.Forms.ToolStripMenuItem jap;

		private global::System.Windows.Forms.ToolStripMenuItem kor;

		public global::System.Windows.Forms.ToolStripItem shupai;

		public global::System.Windows.Forms.ToolStripItem write;

		private global::System.Windows.Forms.ToolStripMenuItem left_right;

		private global::System.Windows.Forms.ToolStripMenuItem righ_left;

		private global::System.Windows.Forms.ToolStripMenuItem customize_Proxy;

		private global::System.Windows.Forms.ToolStripMenuItem null_Proxy;

		private global::System.Windows.Forms.ToolStripMenuItem system_Proxy;

		private global::System.Windows.Forms.ToolStripMenuItem Proxy;

		private global::System.Windows.Forms.ToolStripMenuItem pinyin;

		private global::System.Windows.Forms.ToolStripMenuItem trans_input;

		private global::System.Windows.Forms.ToolStripMenuItem trans_google;

		private global::System.Windows.Forms.ToolStripMenuItem trans_baidu;

		private global::System.Windows.Forms.ToolStripMenuItem trans_tencent;

		private global::System.Windows.Forms.ToolStripMenuItem ocr_table;

		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

		private global::System.Windows.Forms.ToolStripMenuItem baidu_table;

		private global::System.Windows.Forms.ToolStripMenuItem ali_table;

		public global::System.Windows.Forms.ToolStripItem Mathfuntion;
	}
}
