using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Web;
using System.Windows.Forms;
using Microsoft.Win32;
using TrOCR.Helper;
using TrOCR.Properties;
using static System.Net.WebRequestMethods;

namespace TrOCR
{

	public sealed partial class FmSetting
    {

		public FmSetting()
		{
			Font = new Font(Font.Name, 9f / StaticValue.DpiFactor, Font.Style, Font.Unit, Font.GdiCharSet, Font.GdiVerticalFont);
			InitializeComponent();
		}

		public void readIniFile()
		{
			var value = IniHelper.GetValue("配置", "开机自启");
			if (value == "发生错误")
			{
				cbBox_开机.Checked = true;
			}
			try
			{
				cbBox_开机.Checked = Convert.ToBoolean(value);
			}
			catch
			{
				cbBox_开机.Checked = true;
			}
			var value2 = IniHelper.GetValue("配置", "快速翻译");
			if (value2 == "发生错误")
			{
				cbBox_翻译.Checked = true;
			}
			try
			{
				cbBox_翻译.Checked = Convert.ToBoolean(value2);
			}
			catch
			{
				cbBox_翻译.Checked = true;
			}
			var value3 = IniHelper.GetValue("配置", "识别弹窗");
			if (value3 == "发生错误")
			{
				cbBox_弹窗.Checked = true;
			}
			try
			{
				cbBox_弹窗.Checked = Convert.ToBoolean(value3);
			}
			catch
			{
				cbBox_弹窗.Checked = true;
			}
			var value4 = IniHelper.GetValue("配置", "窗体动画");
			cobBox_动画.Text = value4;
			if (value4 == "发生错误")
			{
				cobBox_动画.Text = "窗体";
			}
			var value5 = IniHelper.GetValue("配置", "记录数目");
			numbox_记录.Value = Convert.ToInt32(value5);
			if (value5 == "发生错误")
			{
				numbox_记录.Value = 20m;
			}
			var value6 = IniHelper.GetValue("配置", "自动保存");
			if (value6 == "发生错误")
			{
				cbBox_保存.Checked = false;
			}
			try
			{
				cbBox_保存.Checked = Convert.ToBoolean(value6);
			}
			catch
			{
				cbBox_保存.Checked = false;
			}
			if (cbBox_保存.Checked)
			{
				textBox_path.Enabled = true;
				btn_浏览.Enabled = true;
			}
			if (!cbBox_保存.Checked)
			{
				textBox_path.Enabled = false;
				btn_浏览.Enabled = false;
			}
			var value7 = IniHelper.GetValue("配置", "截图位置");
			textBox_path.Text = value7;
			if (value7 == "发生错误")
			{
				textBox_path.Text = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
			}
			var value8 = IniHelper.GetValue("快捷键", "文字识别");
			txtBox_文字识别.Text = value8;
			if (value8 == "发生错误")
			{
				txtBox_文字识别.Text = "F4";
			}
			var value9 = IniHelper.GetValue("快捷键", "翻译文本");
			txtBox_翻译文本.Text = value9;
			if (value9 == "发生错误")
			{
				txtBox_翻译文本.Text = "F9";
			}
			var value10 = IniHelper.GetValue("快捷键", "记录界面");
			txtBox_记录界面.Text = value10;
			if (value10 == "发生错误")
			{
				txtBox_记录界面.Text = "请按下快捷键";
			}
			var value11 = IniHelper.GetValue("快捷键", "识别界面");
			txtBox_识别界面.Text = value11;
			if (value11 == "发生错误")
			{
				txtBox_识别界面.Text = "请按下快捷键";
			}
			pictureBox_文字识别.Image = txtBox_文字识别.Text == "请按下快捷键" ? Resources.快捷键_0 : Resources.快捷键_1;
			pictureBox_翻译文本.Image = txtBox_翻译文本.Text == "请按下快捷键" ? Resources.快捷键_0 : Resources.快捷键_1;
			pictureBox_记录界面.Image = txtBox_记录界面.Text == "请按下快捷键" ? Resources.快捷键_0 : Resources.快捷键_1;
			pictureBox_识别界面.Image = txtBox_识别界面.Text == "请按下快捷键" ? Resources.快捷键_0 : Resources.快捷键_1;
			var value12 = IniHelper.GetValue("密钥_百度", "secret_id");
			text_baiduaccount.Text = value12;
			if (value12 == "发生错误")
			{
				text_baiduaccount.Text = "YsZKG1wha34PlDOPYaIrIIKO";
			}
			var value13 = IniHelper.GetValue("密钥_百度", "secret_key");
			text_baidupassword.Text = value13;
			if (value13 == "发生错误")
			{
				text_baidupassword.Text = "HPRZtdOHrdnnETVsZM2Nx7vbDkMfxrkD";
			}
			var value14 = IniHelper.GetValue("代理", "代理类型");
			combox_代理.Text = value14;
			if (value14 == "发生错误")
			{
				combox_代理.Text = "系统代理";
			}
			if (combox_代理.Text == "不使用代理" || combox_代理.Text == "系统代理")
			{
				text_账号.Enabled = false;
				text_密码.Enabled = false;
				chbox_代理服务器.Enabled = false;
				text_端口.Enabled = false;
				text_服务器.Enabled = false;
			}
			if (combox_代理.Text == "自定义代理")
			{
				text_端口.Enabled = true;
				text_服务器.Enabled = true;
			}
			var value15 = IniHelper.GetValue("代理", "服务器");
			text_服务器.Text = value15;
			if (value15 == "发生错误")
			{
				text_服务器.Text = "127.0.0.1";
			}
			var value16 = IniHelper.GetValue("代理", "端口");
			text_端口.Text = value16;
			if (value16 == "发生错误")
			{
				text_端口.Text = "1080";
			}
			var value17 = IniHelper.GetValue("代理", "需要密码");
			if (value17 == "发生错误")
			{
				chbox_代理服务器.Checked = false;
			}
			try
			{
				chbox_代理服务器.Checked = Convert.ToBoolean(value17);
			}
			catch
			{
				chbox_代理服务器.Checked = false;
			}
			var value18 = IniHelper.GetValue("代理", "服务器账号");
			text_账号.Text = value18;
			if (value18 == "发生错误")
			{
				text_账号.Text = "";
			}
			var value19 = IniHelper.GetValue("代理", "服务器密码");
			text_密码.Text = value19;
			if (value19 == "发生错误")
			{
				text_密码.Text = "";
			}
			if (chbox_代理服务器.Checked)
			{
				text_账号.Enabled = true;
				text_密码.Enabled = true;
			}
			if (!chbox_代理服务器.Checked)
			{
				text_账号.Enabled = false;
				text_密码.Enabled = false;
			}
			var value20 = IniHelper.GetValue("更新", "检测更新");
			if (value20 == "发生错误")
			{
				check_检查更新.Checked = false;
			}
			try
			{
				check_检查更新.Checked = Convert.ToBoolean(value20);
			}
			catch
			{
				check_检查更新.Checked = false;
			}
			if (check_检查更新.Checked)
			{
				checkBox_更新间隔.Enabled = true;
			}
			if (!check_检查更新.Checked)
			{
				checkBox_更新间隔.Enabled = false;
				numbox_间隔时间.Enabled = false;
			}
			var value21 = IniHelper.GetValue("更新", "更新间隔");
			if (value21 == "发生错误")
			{
				checkBox_更新间隔.Checked = false;
			}
			try
			{
				checkBox_更新间隔.Checked = Convert.ToBoolean(value21);
			}
			catch
			{
				checkBox_更新间隔.Checked = false;
			}
			if (checkBox_更新间隔.Checked)
			{
				numbox_间隔时间.Enabled = true;
			}
			if (!checkBox_更新间隔.Checked)
			{
				numbox_间隔时间.Enabled = false;
			}
			var value22 = IniHelper.GetValue("更新", "间隔时间");
			numbox_间隔时间.Value = Convert.ToInt32(value22);
			if (value5 == "发生错误")
			{
				numbox_间隔时间.Value = 24m;
			}
			var value23 = IniHelper.GetValue("截图音效", "粘贴板");
			if (value23 == "发生错误")
			{
				chbox_copy.Checked = false;
			}
			try
			{
				chbox_copy.Checked = Convert.ToBoolean(value23);
			}
			catch
			{
				chbox_copy.Checked = false;
			}
			var value24 = IniHelper.GetValue("截图音效", "自动保存");
			if (value24 == "发生错误")
			{
				chbox_save.Checked = true;
			}
			try
			{
				chbox_save.Checked = Convert.ToBoolean(value24);
			}
			catch
			{
				chbox_save.Checked = true;
			}
			var value25 = IniHelper.GetValue("截图音效", "音效路径");
			text_音效path.Text = value25;
			if (value25 == "发生错误")
			{
				text_音效path.Text = "Data\\screenshot.wav";
			}
			var value26 = IniHelper.GetValue("取色器", "类型");
			if (value26 == "发生错误")
			{
				chbox_取色.Checked = false;
			}
			if (value26 == "RGB")
			{
				chbox_取色.Checked = false;
			}
			if (value26 == "HEX")
			{
				chbox_取色.Checked = true;
			}


			/*
			 *                 IniHelper.SetValue("OCR", "padding", "50");
                IniHelper.SetValue("OCR", "maxSideLen", "1024");
                IniHelper.SetValue("OCR", "boxScoreThresh", "0.618");
                IniHelper.SetValue("OCR", "boxThresh", "0.300");
                IniHelper.SetValue("OCR", "unClipRatio", "2.0");
                IniHelper.SetValue("OCR", "doAngle", "1");
                IniHelper.SetValue("OCR", "mostAngle", "1");
                IniHelper.SetValue("OCR", "numThread", "4");
			 */
			var value27 = IniHelper.GetValue("OCR", "padding");
			if (value27 == "发生错误")
			{
				ocrNum1.Value = 50;
			}
			else {
				ocrNum1.Value = int.Parse(value27);
			}
			value27 = IniHelper.GetValue("OCR", "maxSideLen");
			if (value27 == "发生错误")
			{
				ocrNum2.Value = 1024;
			}
			else
			{
				ocrNum2.Value = int.Parse(value27);
			}
			value27 = IniHelper.GetValue("OCR", "boxScoreThresh");
			if (value27 == "发生错误")
			{
				ocrNum3.Value = 0.618M;
			}
			else
			{
				ocrNum3.Value = (decimal)Convert.ToSingle(value27);
			}
			value27 = IniHelper.GetValue("OCR", "boxThresh");
			if (value27 == "发生错误")
			{
				ocrNum4.Value = 0.300M;
			}
			else
			{
				ocrNum4.Value = (decimal)Convert.ToSingle(value27);
			}
			value27 = IniHelper.GetValue("OCR", "unClipRatio");
			if (value27 == "发生错误")
			{
				ocrNum5.Value = 2.0M;
			}
			else
			{
				ocrNum5.Value = (decimal)Convert.ToSingle(value27);
			}

			value27 = IniHelper.GetValue("OCR", "doAngle");
			if (value27 == "发生错误")
			{
				doAngleCheckBox.Checked = true;
			}
			if (value27 == "0")
			{
				doAngleCheckBox.Checked = false;
			}
			else
			{
				doAngleCheckBox.Checked = true;
			}

			value27 = IniHelper.GetValue("OCR", "mostAngle");
			if (value27 == "发生错误")
			{
				mostAngleCheckBox.Checked = true;
			}
			if (value27 == "0")
			{
				mostAngleCheckBox.Checked = false;
			}
			else
			{
				mostAngleCheckBox.Checked = true;
			}

			value27 = IniHelper.GetValue("OCR", "numThread");
			if (value27 == "发生错误")
			{
				ocrNum6.Value = 4;
			}
			else
			{
				ocrNum6.Value = int.Parse(value27); ;
			}


			/*
			 *  IniHelper.SetValue("OCR2", "padding", "0");
                IniHelper.SetValue("OCR2", "maxSideLen", "1024");
                IniHelper.SetValue("OCR2", "boxScoreThresh", "0.700");
                IniHelper.SetValue("OCR2", "boxThresh", "0.300");
                IniHelper.SetValue("OCR2", "unClipRatio", "1.5");
                IniHelper.SetValue("OCR2", "doAngle", "1");
                IniHelper.SetValue("OCR2", "mostAngle", "0");
                IniHelper.SetValue("OCR2", "numThread", "4");
			 */
			value27 = IniHelper.GetValue("OCR2", "padding");
			if (value27 == "发生错误")
			{
				ocrNum7.Value = 0;
			}
			else
			{
				ocrNum7.Value = int.Parse(value27);
			}
			value27 = IniHelper.GetValue("OCR2", "maxSideLen");
			if (value27 == "发生错误")
			{
				ocrNum8.Value = 1024;
			}
			else
			{
				ocrNum8.Value = int.Parse(value27);
			}
			value27 = IniHelper.GetValue("OCR2", "boxScoreThresh");
			if (value27 == "发生错误")
			{
				ocrNum9.Value = 0.700M;
			}
			else
			{
				ocrNum9.Value = (decimal)Convert.ToSingle(value27);
			}
			value27 = IniHelper.GetValue("OCR2", "boxThresh");
			if (value27 == "发生错误")
			{
				ocrNum10.Value = 0.300M;
			}
			else
			{
				ocrNum10.Value = (decimal)Convert.ToSingle(value27);
			}
			value27 = IniHelper.GetValue("OCR2", "unClipRatio");
			if (value27 == "发生错误")
			{
				ocrNum11.Value = 1.5M;
			}
			else
			{
				ocrNum11.Value = (decimal)Convert.ToSingle(value27);
			}

			value27 = IniHelper.GetValue("OCR2", "doAngle");
			if (value27 == "发生错误")
			{
				doAngleCheckBox2.Checked = true;
			}
			if (value27 == "0")
			{
				doAngleCheckBox2.Checked = false;
			}
			else
			{
				doAngleCheckBox2.Checked = true;
			}

			value27 = IniHelper.GetValue("OCR2", "mostAngle");
			if (value27 == "发生错误")
			{
				mostAngleCheckBox2.Checked = false;
			}
			if (value27 == "0")
			{
				mostAngleCheckBox2.Checked = false;
			}
			else
			{
				mostAngleCheckBox2.Checked = true;
			}

			value27 = IniHelper.GetValue("OCR2", "numThread");
			if (value27 == "发生错误")
			{
				ocrNum12.Value = 4;
			}
			else
			{
				ocrNum12.Value = int.Parse(value27); ;
			}
			//模型选择
			value27 = IniHelper.GetValue("paddle模型", "模型");
			//自定义模型
			if (value27 == "发生错误")
			{
				radioButton1.Checked=true;
			}
			else {
                switch (int.Parse(value27))
                {
					case 1:
						radioButton1.Checked = true;
						break;
					case 2:
						radioButton2.Checked = true;
						break;
					case 3:
						radioButton3.Checked = true;
						break;
					default:
						radioButton1.Checked = true;
						break;
                }
            }


			//翻译接口

			value27 = IniHelper.GetValue("翻译API", "BDsecret_id");
			//自定义模型
			if (value27 == "发生错误")
			{
				翻译api_id.Text = "";
			}
			else {
				翻译api_id.Text = value27;
			}
			value27 = IniHelper.GetValue("翻译API", "BDsecret_key");
			//自定义模型
			if (value27 == "发生错误")
			{
				翻译api_key.Text = "";
			}
			else
			{
				翻译api_key.Text = value27;
			}
            value27 = IniHelper.GetValue("翻译API", "TXsecret_id");
            //自定义模型
            if (value27 == "发生错误")
            {
                腾讯翻译api_id.Text = "";
            }
            else
            {
                腾讯翻译api_id.Text = value27;
            }
            value27 = IniHelper.GetValue("翻译API", "TXsecret_key");
            if (value27 == "发生错误")
            {
                腾讯翻译api_key.Text = "";
            }
            else
            {
                腾讯翻译api_key.Text = value27;
            }

            value27 = IniHelper.GetValue("翻译API", "CYsecret_token");
            if (value27 == "发生错误")
            {
                彩云翻译api_token.Text = "";
            }
            else
            {
                彩云翻译api_token.Text = value27;
            }
            value27 = IniHelper.GetValue("翻译API", "offline_url");
            if (value27 == "发生错误")
            {
                离线翻译网址.Text = "";
            }
            else
            {
                离线翻译网址.Text = value27;
            }
            value27 = IniHelper.GetValue("其他特性", "静默识别");
			if (value27 == "发生错误")
			{
                cbBox_静默识别.Checked = false;
            }
            try
            {
				//Console.WriteLine(value27);
                cbBox_静默识别.Checked = Convert.ToBoolean(value27);
            }
            catch
            {
                cbBox_静默识别.Checked = true;
            }

            value27 = IniHelper.GetValue("其他特性", "始终复制");
            if (value27 == "发生错误")
            {
                cbBox_是否复制.Checked = true;
            }
            try
            {
                //Console.WriteLine(value27);
                cbBox_是否复制.Checked = Convert.ToBoolean(value27);
            }
            catch
            {
                cbBox_是否复制.Checked = true;
            }

            value27 = IniHelper.GetValue("其他特性", "添加换行");
            if (value27 == "发生错误")
            {
                cbBox_是否添加换行.Checked = false;
            }
            try
            {
                //Console.WriteLine(value27);
                cbBox_是否添加换行.Checked = Convert.ToBoolean(value27);
            }
            catch
            {
                cbBox_是否添加换行.Checked = false;
            }

            value27 = IniHelper.GetValue("其他特性", "缩放倍数");
            if (value27 == "发生错误")
            {
                num_zoom.Value = 1.0M;
            }
            try
            {
                //Console.WriteLine(value27);
                num_zoom.Value = Convert.ToDecimal(value27);
            }
            catch
            {
                num_zoom.Value = 1.0M;
            }

            value27 = IniHelper.GetValue("其他特性", "文字缩放倍数");
            if (value27 == "发生错误")
            {
                num_zoom_text.Value = 1.0M;
            }
            try
            {
                //Console.WriteLine(value27);
                num_zoom_text.Value = Convert.ToDecimal(value27);
            }
            catch
            {
                num_zoom_text.Value = 1.0M;
            }


        }

		private void Form1_Load(object sender, EventArgs e)
		{
			var componentResourceManager = new ComponentResourceManager(typeof(FmMain));
			Icon = (Icon)componentResourceManager.GetObject("minico.Icon");
			var numericUpDown = numbox_记录;
			var array = new int[4];
			array[0] = 99;
			numericUpDown.Maximum = new decimal(array);
			var numericUpDown2 = numbox_记录;
			var array2 = new int[4];
			array2[0] = 1;
			numericUpDown2.Minimum = new decimal(array2);
			var numericUpDown3 = numbox_记录;
			var array3 = new int[4];
			array3[0] = 1;
			numericUpDown3.Value = new decimal(array3);
			var numericUpDown4 = numbox_间隔时间;
			var array4 = new int[4];
			array4[0] = 24;
			numericUpDown4.Maximum = new decimal(array4);
			var numericUpDown5 = numbox_间隔时间;
			var array5 = new int[4];
			array5[0] = 1;
			numericUpDown5.Minimum = new decimal(array5);
			var numericUpDown6 = numbox_间隔时间;
			var array6 = new int[4];
			array6[0] = 1;
			numericUpDown6.Value = new decimal(array6);
			tab_标签.Height = (int)(350.0 * Program.Factor);
			Height = tab_标签.Height + 50;
			readIniFile();
			chbox_代理服务器.CheckedChanged += chbox_代理服务器_CheckedChanged;
			更新Button_check.Click += 更新Button_check_Click;
            tab_标签.TabPages.RemoveByKey("Page_更新");
            tab_标签.TabPages.RemoveByKey("Page_反馈");
			//tab_标签.TabPages.RemoveByKey("Page_密钥");
			//tab_标签.TabPages.RemoveByKey("Page_代理");
		}

        private void 百度申请_Click(object sender, EventArgs e)
		{
			Process.Start("https://console.bce.baidu.com/ai/");
		}

		public static string Get_html(string url)
		{
			string result;
			var httpWebRequest = WebRequest.Create(url) as HttpWebRequest;
			httpWebRequest.Method = "POST";
			httpWebRequest.ContentType = "application/x-www-form-urlencoded";
			try
			{
				using (var httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse())
				{
					using (var streamReader = new StreamReader(httpWebResponse.GetResponseStream(), Encoding.UTF8))
					{
						result = streamReader.ReadToEnd();
						streamReader.Close();
						httpWebResponse.Close();
					}
				}
				httpWebRequest.Abort();
			}
			catch
			{
				result = "";
			}
			return result;
		}

		private void tab_标签_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (tab_标签.SelectedTab == page_常规)
			{
				tab_标签.Height = (int)(355 * Program.Factor);
				Height = tab_标签.Height + 50;
			}
			else if (tab_标签.SelectedTab == Page_快捷键)
			{
				tab_标签.Height = (int)(225.0 * Program.Factor);
				Height = tab_标签.Height + 50;
			}
            else if (tab_标签.SelectedTab == Page_OCR设置)
			{
				tab_标签.Height = (int)(355.0 * Program.Factor);
				Height = tab_标签.Height + 50;
			}
            else if (tab_标签.SelectedTab == Page_OCR设置2)
			{
				tab_标签.Height = (int)(355.0 * Program.Factor);
				Height = tab_标签.Height + 50;
			}
            else if (tab_标签.SelectedTab == Page_翻译API)
			{
				tab_标签.Height = (int)(200.0 * Program.Factor);
				Height = tab_标签.Height + 50;
			}
            else if (tab_标签.SelectedTab == Page_密钥)
			{
				tab_标签.Height = (int)(200.0 * Program.Factor);
				Height = tab_标签.Height + 50;
			}
            else if (tab_标签.SelectedTab == Page_其他特性)
            {
                tab_标签.Height = (int)(200.0 * Program.Factor);
                Height = tab_标签.Height + 50;
            }
            else if (tab_标签.SelectedTab == Page_代理)
            {
                tab_标签.Height = (int)(220.0 * Program.Factor);
                Height = tab_标签.Height + 50;
            }
        }

		private void pic_help_Click(object sender, EventArgs e)
		{
			new FmHelp().Show();
		}

		private void cbBox_开机_CheckedChanged(object sender, EventArgs e)
		{
			AutoStart(cbBox_开机.Checked);
		}

		private void cbBox_翻译_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void cbBox_弹窗_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void cobBox_动画_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		private void numbox_记录_ValueChanged(object sender, EventArgs e)
		{
		}

		private void cbBox_保存_CheckedChanged(object sender, EventArgs e)
		{
			if (cbBox_保存.Checked)
			{
				textBox_path.Enabled = true;
				btn_浏览.Enabled = true;
			}
			if (!cbBox_保存.Checked)
			{
				textBox_path.Enabled = false;
				btn_浏览.Enabled = false;
			}
		}

		private void btn_浏览_Click(object sender, EventArgs e)
		{
			var folderBrowserDialog = new FolderBrowserDialog();
			if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
			{
				textBox_path.Text = folderBrowserDialog.SelectedPath;
			}
		}

		private void 密钥Button_Click(object sender, EventArgs e)
		{
			text_baiduaccount.Text = "YsZKG1wha34PlDOPYaIrIIKO";
			text_baidupassword.Text = "HPRZtdOHrdnnETVsZM2Nx7vbDkMfxrkD";
		}

		private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
		{
		}

		private void 常规Button_Click(object sender, EventArgs e)
		{
			cbBox_开机.Checked = true;
			cbBox_翻译.Checked = true;
			cbBox_弹窗.Checked = true;
			cobBox_动画.SelectedIndex = 0;
			numbox_记录.Value = 20m;
			cbBox_保存.Checked = true;
			textBox_path.Enabled = true;
			textBox_path.Text = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
			btn_浏览.Enabled = true;
			chbox_save.Checked = true;
			text_音效path.Text = "Data\\screenshot.wav";
			chbox_copy.Checked = false;
			chbox_取色.Checked = false;
		}

		private void txtBox_KeyUp(object sender, KeyEventArgs e)
		{
			var textBox = sender as TextBox;
			var regex = new Regex("[一-龥]+");
			var str = "";
			foreach (var obj in regex.Matches(textBox.Name))
			{
				str = ((Match)obj).ToString();
			}
			var key = "pictureBox_" + str;
			var pictureBox = (PictureBox)Controls.Find(key, true)[0];
			new ComponentResourceManager(typeof(FmSetting));
			if (e.KeyData == Keys.Back)
			{
				textBox.Text = "请按下快捷键";
				pictureBox.Image = Resources.快捷键_0;
				if (textBox.Name.Contains("文字识别"))
				{
					IniHelper.SetValue("快捷键", "文字识别", txtBox_文字识别.Text);
				}
				if (textBox.Name.Contains("翻译文本"))
				{
					IniHelper.SetValue("快捷键", "翻译文本", txtBox_翻译文本.Text);
				}
				if (textBox.Name.Contains("记录界面"))
				{
					IniHelper.SetValue("快捷键", "记录界面", txtBox_记录界面.Text);
				}
				if (textBox.Name.Contains("识别界面"))
				{
					IniHelper.SetValue("快捷键", "识别界面", txtBox_识别界面.Text);
                }
			}
			else if (e.KeyValue != 16 && e.KeyValue != 17 && e.KeyValue != 18)
			{
				var array = e.KeyData.ToString().Replace(" ", "").Replace("Control", "Ctrl").Split(',');
				pictureBox.Image = Resources.快捷键_1;
				if (array.Length == 1)
				{
					textBox.Text = array[0];
				}
				if (array.Length == 2)
				{
					textBox.Text = array[1] + "+" + array[0];
				}
				if (array.Length <= 2)
				{
					if (textBox.Name.Contains("文字识别"))
					{
						IniHelper.SetValue("快捷键", "文字识别", txtBox_文字识别.Text);
					}
					if (textBox.Name.Contains("翻译文本"))
					{
						IniHelper.SetValue("快捷键", "翻译文本", txtBox_翻译文本.Text);
					}
					if (textBox.Name.Contains("记录界面"))
					{
						IniHelper.SetValue("快捷键", "记录界面", txtBox_记录界面.Text);
					}
					if (textBox.Name.Contains("识别界面"))
					{
						IniHelper.SetValue("快捷键", "识别界面", txtBox_识别界面.Text);
					}
				}
			}
		}

		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			return (keyData == Keys.Tab && txtBox_文字识别.Focused) || (keyData == Keys.Tab && txtBox_翻译文本.Focused) || (keyData == Keys.Tab && txtBox_记录界面.Focused) || (keyData == Keys.Tab && txtBox_识别界面.Focused);
		}

		private void txtBox_KeyDown(object sender, KeyEventArgs e)
		{
			e.SuppressKeyPress = true;
		}

		private void 快捷键Button_Click(object sender, EventArgs e)
		{
			new ComponentResourceManager(typeof(FmSetting));
			txtBox_文字识别.Text = "F4";
			pictureBox_文字识别.Image = Resources.快捷键_1;
			txtBox_翻译文本.Text = "F9";
			pictureBox_翻译文本.Image = Resources.快捷键_1;
			txtBox_记录界面.Text = "请按下快捷键";
			pictureBox_记录界面.Image = Resources.快捷键_0;
			txtBox_识别界面.Text = "请按下快捷键";
			pictureBox_识别界面.Image = Resources.快捷键_0;
		}

		private void 百度_btn_Click(object sender, EventArgs e)
		{
			if (Get_html(string.Format("{0}?{1}", "https://aip.baidubce.com/oauth/2.0/token", "grant_type=client_credentials&client_id=" + text_baiduaccount.Text + "&client_secret=" + text_baidupassword.Text)) != "")
			{
				MessageBox.Show("密钥正确!", "提醒");
				return;
			}
			MessageBox.Show("请确保密钥正确!", "提醒");
		}

		private void combox_代理_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (combox_代理.Text == "不使用代理" || combox_代理.Text == "系统代理")
			{
				text_账号.Enabled = false;
				text_密码.Enabled = false;
				chbox_代理服务器.Enabled = false;
				text_端口.Enabled = false;
				chbox_代理服务器.Checked = false;
				text_服务器.Enabled = false;
				text_服务器.Text = "";
				text_端口.Text = "";
				text_服务器.Text = "";
				text_账号.Text = "";
				text_密码.Text = "";
			}
			if (combox_代理.Text == "自定义代理")
			{
				text_端口.Enabled = true;
				text_服务器.Enabled = true;
				chbox_代理服务器.Enabled = true;
			}
		}

		private void text_端口_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
		{
		}

		private void text_baiduaccount_TextChanged(object sender, EventArgs e)
		{
		}

		private void text_baidupassword_TextChanged(object sender, EventArgs e)
		{
		}

		private void text_服务器_TextChanged(object sender, EventArgs e)
		{
		}

		private void text_端口_TextChanged(object sender, EventArgs e)
		{
		}

		private void chbox_代理服务器_CheckedChanged(object sender, EventArgs e)
		{
			if (chbox_代理服务器.Checked)
			{
				text_账号.Enabled = true;
				text_密码.Enabled = true;
			}
			if (!chbox_代理服务器.Checked)
			{
				text_账号.Enabled = false;
				text_密码.Enabled = false;
			}
		}

		private void text_账号_TextChanged(object sender, EventArgs e)
		{
		}

		private void text_密码_TextChanged(object sender, EventArgs e)
		{
		}

		private void 代理Button_Click(object sender, EventArgs e)
		{
			combox_代理.Text = "系统代理";
			text_账号.Enabled = false;
			text_密码.Enabled = false;
			chbox_代理服务器.Enabled = false;
			text_端口.Enabled = false;
			text_服务器.Enabled = false;
		}

		private void check_检查更新_CheckedChanged(object sender, EventArgs e)
		{
			if (check_检查更新.Checked)
			{
				checkBox_更新间隔.Enabled = true;
				checkBox_更新间隔.Checked = true;
				numbox_间隔时间.Enabled = true;
			}
			if (!check_检查更新.Checked)
			{
				checkBox_更新间隔.Checked = false;
				checkBox_更新间隔.Enabled = false;
				numbox_间隔时间.Enabled = false;
			}
		}

		private void checkBox_更新间隔_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox_更新间隔.Checked)
			{
				numbox_间隔时间.Enabled = true;
			}
			if (!checkBox_更新间隔.Checked)
			{
				numbox_间隔时间.Enabled = false;
			}
		}

		private void numbox_间隔时间_ValueChanged(object sender, EventArgs e)
		{
		}

		private void 更新Button_Click(object sender, EventArgs e)
		{
			numbox_间隔时间.Value = 24m;
			check_检查更新.Checked = true;
			checkBox_更新间隔.Checked = true;
		}

		private void 更新Button_check_Click(object sender, EventArgs e)
		{
			//new Thread(Program.CheckUpdate).Start();
		}

		private void 反馈Button_Click(object sender, EventArgs e)
		{
			//new Thread(反馈send).Start();
		}

		public string Post_Html(string url, string post_str)
		{
			var bytes = Encoding.UTF8.GetBytes(post_str);
			var result = "";
			var httpWebRequest = WebRequest.Create(url) as HttpWebRequest;
			httpWebRequest.Method = "POST";
			httpWebRequest.Timeout = 6000;
			httpWebRequest.Proxy = null;
			httpWebRequest.ContentType = "application/x-www-form-urlencoded";
			try
			{
				using (var requestStream = httpWebRequest.GetRequestStream())
				{
					requestStream.Write(bytes, 0, bytes.Length);
				}
				var responseStream = ((HttpWebResponse)httpWebRequest.GetResponse()).GetResponseStream();
				var streamReader = new StreamReader(responseStream, Encoding.GetEncoding("utf-8"));
				result = streamReader.ReadToEnd();
				responseStream.Close();
				streamReader.Close();
				httpWebRequest.Abort();
			}
			catch
			{
			}
			return result;
		}

		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{
			IniHelper.SetValue("配置", "开机自启", cbBox_开机.Checked.ToString());
			IniHelper.SetValue("配置", "快速翻译", cbBox_翻译.Checked.ToString());
			IniHelper.SetValue("配置", "识别弹窗", cbBox_弹窗.Checked.ToString());
			IniHelper.SetValue("配置", "窗体动画", cobBox_动画.Text);
			IniHelper.SetValue("配置", "记录数目", numbox_记录.Text);
			IniHelper.SetValue("配置", "自动保存", cbBox_保存.Checked.ToString());
			IniHelper.SetValue("配置", "截图位置", textBox_path.Text);
			IniHelper.SetValue("快捷键", "文字识别", txtBox_文字识别.Text);
			IniHelper.SetValue("快捷键", "翻译文本", txtBox_翻译文本.Text);
			IniHelper.SetValue("快捷键", "记录界面", txtBox_记录界面.Text);
			IniHelper.SetValue("快捷键", "识别界面", txtBox_识别界面.Text);
			IniHelper.SetValue("密钥_百度", "secret_id", text_baiduaccount.Text);
			IniHelper.SetValue("密钥_百度", "secret_key", text_baidupassword.Text);
			IniHelper.SetValue("代理", "代理类型", combox_代理.Text);
			IniHelper.SetValue("代理", "服务器", text_服务器.Text);
			IniHelper.SetValue("代理", "端口", text_端口.Text);
			IniHelper.SetValue("代理", "需要密码", chbox_代理服务器.Checked.ToString());
			IniHelper.SetValue("代理", "服务器账号", text_账号.Text);
			IniHelper.SetValue("代理", "服务器密码", text_密码.Text);
			IniHelper.SetValue("更新", "检测更新", check_检查更新.Checked.ToString());
			IniHelper.SetValue("更新", "更新间隔", checkBox_更新间隔.Checked.ToString());
			IniHelper.SetValue("更新", "间隔时间", numbox_间隔时间.Value.ToString());
			IniHelper.SetValue("截图音效", "自动保存", chbox_save.Checked.ToString());
			IniHelper.SetValue("截图音效", "音效路径", text_音效path.Text);
			IniHelper.SetValue("截图音效", "粘贴板", chbox_copy.Checked.ToString());
			if (!chbox_取色.Checked)
			{
				IniHelper.SetValue("取色器", "类型", "RGB");
			}
			if (chbox_取色.Checked)
			{
				IniHelper.SetValue("取色器", "类型", "HEX");
			}

			IniHelper.SetValue("OCR", "padding", ocrNum1.Value.ToString());
			IniHelper.SetValue("OCR", "maxSideLen", ocrNum2.Value.ToString());
			IniHelper.SetValue("OCR", "boxScoreThresh", ocrNum3.Value.ToString());
			IniHelper.SetValue("OCR", "boxThresh", ocrNum4.Value.ToString());
			IniHelper.SetValue("OCR", "unClipRatio", ocrNum5.Value.ToString());
			if (doAngleCheckBox.Checked)
			{
				IniHelper.SetValue("OCR", "doAngle", "1");
			}
			else {
				IniHelper.SetValue("OCR", "doAngle", "0");
			}

			if (mostAngleCheckBox.Checked)
			{
				IniHelper.SetValue("OCR", "mostAngle", "1");
			}
			else
			{
				IniHelper.SetValue("OCR", "mostAngle", "0");
			}

			IniHelper.SetValue("OCR", "numThread", ocrNum6.Value.ToString());

			//模型2数据保存
			IniHelper.SetValue("OCR2", "padding", ocrNum7.Value.ToString());
			IniHelper.SetValue("OCR2", "maxSideLen", ocrNum8.Value.ToString());
			IniHelper.SetValue("OCR2", "boxScoreThresh", ocrNum9.Value.ToString());
			IniHelper.SetValue("OCR2", "boxThresh", ocrNum10.Value.ToString());
			IniHelper.SetValue("OCR2", "unClipRatio", ocrNum11.Value.ToString());
			if (doAngleCheckBox2.Checked)
			{
				IniHelper.SetValue("OCR2", "doAngle", "1");
			}
			else
			{
				IniHelper.SetValue("OCR2", "doAngle", "0");
			}

			if (mostAngleCheckBox2.Checked)
			{
				IniHelper.SetValue("OCR2", "mostAngle", "1");
			}
			else
			{
				IniHelper.SetValue("OCR2", "mostAngle", "0");
			}

			IniHelper.SetValue("OCR2", "numThread", ocrNum12.Value.ToString());

			if (radioButton1.Checked)
			{
				IniHelper.SetValue("paddle模型", "模型", "1");
			}
			else if (radioButton2.Checked) {
				IniHelper.SetValue("paddle模型", "模型", "2");
			}
			else if (radioButton3.Checked)
			{
				IniHelper.SetValue("paddle模型", "模型", "3");
			}

			//翻译接口
			IniHelper.SetValue("翻译API", "BDsecret_id", 翻译api_id.Text);
			IniHelper.SetValue("翻译API", "BDsecret_key", 翻译api_key.Text);

            IniHelper.SetValue("翻译API", "TXsecret_id", 腾讯翻译api_id.Text);
            IniHelper.SetValue("翻译API", "TXsecret_key", 腾讯翻译api_key.Text);

            IniHelper.SetValue("翻译API", "CYsecret_token", 彩云翻译api_token.Text);

            IniHelper.SetValue("翻译API", "offline_url", 离线翻译网址.Text);

            IniHelper.SetValue("其他特性", "静默识别", cbBox_静默识别.Checked.ToString());

            IniHelper.SetValue("其他特性", "始终复制", cbBox_是否复制.Checked.ToString());
            IniHelper.SetValue("其他特性", "添加换行", cbBox_是否添加换行.Checked.ToString());
            IniHelper.SetValue("其他特性", "缩放倍数", num_zoom.Value.ToString());
            IniHelper.SetValue("其他特性", "文字缩放倍数", num_zoom_text.Value.ToString());
            DialogResult = DialogResult.OK;
		}

		public static void AutoStart(bool isAuto)
		{
			try
			{
				var value = Application.ExecutablePath.Replace("/", "\\");
				if (isAuto)
				{
					var currentUser = Registry.CurrentUser;
					var registryKey = currentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run");
					registryKey.SetValue("tianruoOCR", value);
					registryKey.Close();
					currentUser.Close();
				}
				else
				{
					var currentUser2 = Registry.CurrentUser;
					var registryKey2 = currentUser2.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run");
					registryKey2.DeleteValue("tianruoOCR", false);
					registryKey2.Close();
					currentUser2.Close();
				}
			}
			catch (Exception)
			{
				MessageBox.Show("您需要管理员权限修改", "提示");
			}
		}

		private void 反馈send()
		{

		}

		public void PlaySong(string file)
		{
			HelpWin32.mciSendString("close media", null, 0, IntPtr.Zero);
			HelpWin32.mciSendString("open \"" + file + "\" type mpegvideo alias media", null, 0, IntPtr.Zero);
			HelpWin32.mciSendString("play media notify", null, 0, Handle);
		}

		private void btn_音效_Click(object sender, EventArgs e)
		{
			PlaySong(text_音效path.Text);
		}

		private void btn_音效路径_Click(object sender, EventArgs e)
		{
			var openFileDialog = new OpenFileDialog();
			openFileDialog.Title = "请选择音效文件";
			openFileDialog.Filter = "All files（*.*）|*.*|All files(*.*)|*.* ";
			openFileDialog.RestoreDirectory = true;
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				text_音效path.Text = Path.GetFullPath(openFileDialog.FileName);
			}
		}

		private void chbox_copy_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void chbox_save_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void chbox_取色_CheckedChanged(object sender, EventArgs e)
		{
		}

		public string Start_set
		{
			set
			{
				tab_标签.SelectedIndex = 5;
			}
		}

        private void partImgCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void debugCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

			IniHelper.SetValue("配置", "开机自启", cbBox_开机.Checked.ToString());
			IniHelper.SetValue("配置", "快速翻译", cbBox_翻译.Checked.ToString());
			IniHelper.SetValue("配置", "识别弹窗", cbBox_弹窗.Checked.ToString());
			IniHelper.SetValue("配置", "窗体动画", cobBox_动画.Text);
			IniHelper.SetValue("配置", "记录数目", numbox_记录.Text);
			IniHelper.SetValue("配置", "自动保存", cbBox_保存.Checked.ToString());
			IniHelper.SetValue("配置", "截图位置", textBox_path.Text);
			IniHelper.SetValue("快捷键", "文字识别", txtBox_文字识别.Text);
			IniHelper.SetValue("快捷键", "翻译文本", txtBox_翻译文本.Text);
			IniHelper.SetValue("快捷键", "记录界面", txtBox_记录界面.Text);
			IniHelper.SetValue("快捷键", "识别界面", txtBox_识别界面.Text);
			IniHelper.SetValue("密钥_百度", "secret_id", text_baiduaccount.Text);
			IniHelper.SetValue("密钥_百度", "secret_key", text_baidupassword.Text);
			IniHelper.SetValue("代理", "代理类型", combox_代理.Text);
			IniHelper.SetValue("代理", "服务器", text_服务器.Text);
			IniHelper.SetValue("代理", "端口", text_端口.Text);
			IniHelper.SetValue("代理", "需要密码", chbox_代理服务器.Checked.ToString());
			IniHelper.SetValue("代理", "服务器账号", text_账号.Text);
			IniHelper.SetValue("代理", "服务器密码", text_密码.Text);
			IniHelper.SetValue("更新", "检测更新", check_检查更新.Checked.ToString());
			IniHelper.SetValue("更新", "更新间隔", checkBox_更新间隔.Checked.ToString());
			IniHelper.SetValue("更新", "间隔时间", numbox_间隔时间.Value.ToString());
			IniHelper.SetValue("截图音效", "自动保存", chbox_save.Checked.ToString());
			IniHelper.SetValue("截图音效", "音效路径", text_音效path.Text);
			IniHelper.SetValue("截图音效", "粘贴板", chbox_copy.Checked.ToString());
			if (!chbox_取色.Checked)
			{
				IniHelper.SetValue("取色器", "类型", "RGB");
			}
			if (chbox_取色.Checked)
			{
				IniHelper.SetValue("取色器", "类型", "HEX");
			}

			IniHelper.SetValue("OCR", "padding", ocrNum1.Value.ToString());
			IniHelper.SetValue("OCR", "maxSideLen", ocrNum2.Value.ToString());
			IniHelper.SetValue("OCR", "boxScoreThresh", ocrNum3.Value.ToString());
			IniHelper.SetValue("OCR", "boxThresh", ocrNum4.Value.ToString());
			IniHelper.SetValue("OCR", "unClipRatio", ocrNum5.Value.ToString());
			if (doAngleCheckBox.Checked)
			{
				IniHelper.SetValue("OCR", "doAngle", "1");
			}
			else
			{
				IniHelper.SetValue("OCR", "doAngle", "0");
			}

			if (mostAngleCheckBox.Checked)
			{
				IniHelper.SetValue("OCR", "mostAngle", "1");
			}
			else
			{
				IniHelper.SetValue("OCR", "mostAngle", "0");
			}

			IniHelper.SetValue("OCR", "numThread", ocrNum6.Value.ToString());

			//模型2数据保存
			IniHelper.SetValue("OCR2", "padding", ocrNum7.Value.ToString());
			IniHelper.SetValue("OCR2", "maxSideLen", ocrNum8.Value.ToString());
			IniHelper.SetValue("OCR2", "boxScoreThresh", ocrNum9.Value.ToString());
			IniHelper.SetValue("OCR2", "boxThresh", ocrNum10.Value.ToString());
			IniHelper.SetValue("OCR2", "unClipRatio", ocrNum11.Value.ToString());
			if (doAngleCheckBox2.Checked)
			{
				IniHelper.SetValue("OCR2", "doAngle", "1");
			}
			else
			{
				IniHelper.SetValue("OCR2", "doAngle", "0");
			}

			if (mostAngleCheckBox2.Checked)
			{
				IniHelper.SetValue("OCR2", "mostAngle", "1");
			}
			else
			{
				IniHelper.SetValue("OCR2", "mostAngle", "0");
			}

			IniHelper.SetValue("OCR2", "numThread", ocrNum12.Value.ToString());

			if (radioButton1.Checked)
			{
				IniHelper.SetValue("paddle模型", "模型", "1");
			}
			else if (radioButton2.Checked)
			{
				IniHelper.SetValue("paddle模型", "模型", "2");
			}
			else if (radioButton3.Checked)
			{
				IniHelper.SetValue("paddle模型", "模型", "3");
			}

			//翻译接口
			IniHelper.SetValue("翻译API", "BDsecret_id", 翻译api_id.Text);
			IniHelper.SetValue("翻译API", "BDsecret_key", 翻译api_key.Text);

            IniHelper.SetValue("翻译API", "TXsecret_id", 腾讯翻译api_id.Text);
            IniHelper.SetValue("翻译API", "TXsecret_key", 腾讯翻译api_key.Text);

            IniHelper.SetValue("翻译API", "CYsecret_token", 彩云翻译api_token.Text);
            IniHelper.SetValue("翻译API", "offline_url", 离线翻译网址.Text);

            IniHelper.SetValue("其他特性", "静默识别", cbBox_静默识别.Checked.ToString());
            IniHelper.SetValue("其他特性", "始终复制", cbBox_是否复制.Checked.ToString());
            IniHelper.SetValue("其他特性", "添加换行", cbBox_是否添加换行.Checked.ToString());
            IniHelper.SetValue("其他特性", "缩放倍数", num_zoom.Value.ToString());
            IniHelper.SetValue("其他特性", "文字缩放倍数", num_zoom_text.Value.ToString());
            Process.Start(Application.ExecutablePath);

			//关闭当前实例
			Process.GetCurrentProcess().Kill();
		}
		private void button参数说明_Click(object sender, EventArgs e)
		{

			string text = "padding：图像预处理，在图片外周添加白边，用于提升识别率，文字框没有正确框住所有文字时，增加此值。" + Environment.NewLine;
			text+= "maxSideLen ：按图片最长边的长度，此值为0代表不缩放，例：1024，如果图片长边大于1024则把图像整体缩小到1024再进行图像分割计算，如果图片长边小于1024则不缩放，如果图片长边小于32，则缩放到32。" + Environment.NewLine;
			text += "boxScoreThresh：文字框置信度门限，文字框没有正确框住所有文字时，减小此值。" + Environment.NewLine;
			text += "boxThresh：请自行试验。" + Environment.NewLine;
			text += "unClipRatio：单个文字框大小倍率，越大时单个文字框越大。此项与图片的大小相关，越大的图片此值应该越大。" + Environment.NewLine;
			text += "doAngle：启用(1)/禁用(0) 文字方向检测，只有图片倒置的情况下(旋转90~270度的图片)，才需要启用文字方向检测。" + Environment.NewLine;
			text += "mostAngle：启用(1)/禁用(0) 角度投票(整张图片以最大可能文字方向来识别)，当禁用文字方向检测时，此项也不起作用。" + Environment.NewLine;
			MessageBox.Show(text);
		}

			private void button3_Click(object sender, EventArgs e)
        {
			IniHelper.SetValue("配置", "开机自启", cbBox_开机.Checked.ToString());
			IniHelper.SetValue("配置", "快速翻译", cbBox_翻译.Checked.ToString());
			IniHelper.SetValue("配置", "识别弹窗", cbBox_弹窗.Checked.ToString());
			IniHelper.SetValue("配置", "窗体动画", cobBox_动画.Text);
			IniHelper.SetValue("配置", "记录数目", numbox_记录.Text);
			IniHelper.SetValue("配置", "自动保存", cbBox_保存.Checked.ToString());
			IniHelper.SetValue("配置", "截图位置", textBox_path.Text);
			IniHelper.SetValue("快捷键", "文字识别", txtBox_文字识别.Text);
			IniHelper.SetValue("快捷键", "翻译文本", txtBox_翻译文本.Text);
			IniHelper.SetValue("快捷键", "记录界面", txtBox_记录界面.Text);
			IniHelper.SetValue("快捷键", "识别界面", txtBox_识别界面.Text);
			IniHelper.SetValue("密钥_百度", "secret_id", text_baiduaccount.Text);
			IniHelper.SetValue("密钥_百度", "secret_key", text_baidupassword.Text);
			IniHelper.SetValue("代理", "代理类型", combox_代理.Text);
			IniHelper.SetValue("代理", "服务器", text_服务器.Text);
			IniHelper.SetValue("代理", "端口", text_端口.Text);
			IniHelper.SetValue("代理", "需要密码", chbox_代理服务器.Checked.ToString());
			IniHelper.SetValue("代理", "服务器账号", text_账号.Text);
			IniHelper.SetValue("代理", "服务器密码", text_密码.Text);
			IniHelper.SetValue("更新", "检测更新", check_检查更新.Checked.ToString());
			IniHelper.SetValue("更新", "更新间隔", checkBox_更新间隔.Checked.ToString());
			IniHelper.SetValue("更新", "间隔时间", numbox_间隔时间.Value.ToString());
			IniHelper.SetValue("截图音效", "自动保存", chbox_save.Checked.ToString());
			IniHelper.SetValue("截图音效", "音效路径", text_音效path.Text);
			IniHelper.SetValue("截图音效", "粘贴板", chbox_copy.Checked.ToString());
			if (!chbox_取色.Checked)
			{
				IniHelper.SetValue("取色器", "类型", "RGB");
			}
			if (chbox_取色.Checked)
			{
				IniHelper.SetValue("取色器", "类型", "HEX");
			}

			IniHelper.SetValue("OCR", "padding", ocrNum1.Value.ToString());
			IniHelper.SetValue("OCR", "maxSideLen", ocrNum2.Value.ToString());
			IniHelper.SetValue("OCR", "boxScoreThresh", ocrNum3.Value.ToString());
			IniHelper.SetValue("OCR", "boxThresh", ocrNum4.Value.ToString());
			IniHelper.SetValue("OCR", "unClipRatio", ocrNum5.Value.ToString());
			if (doAngleCheckBox.Checked)
			{
				IniHelper.SetValue("OCR", "doAngle", "1");
			}
			else
			{
				IniHelper.SetValue("OCR", "doAngle", "0");
			}

			if (mostAngleCheckBox.Checked)
			{
				IniHelper.SetValue("OCR", "mostAngle", "1");
			}
			else
			{
				IniHelper.SetValue("OCR", "mostAngle", "0");
			}

			IniHelper.SetValue("OCR", "numThread", ocrNum6.Value.ToString());

			//模型2数据保存
			IniHelper.SetValue("OCR2", "padding", ocrNum7.Value.ToString());
			IniHelper.SetValue("OCR2", "maxSideLen", ocrNum8.Value.ToString());
			IniHelper.SetValue("OCR2", "boxScoreThresh", ocrNum9.Value.ToString());
			IniHelper.SetValue("OCR2", "boxThresh", ocrNum10.Value.ToString());
			IniHelper.SetValue("OCR2", "unClipRatio", ocrNum11.Value.ToString());
			if (doAngleCheckBox2.Checked)
			{
				IniHelper.SetValue("OCR2", "doAngle", "1");
			}
			else
			{
				IniHelper.SetValue("OCR2", "doAngle", "0");
			}

			if (mostAngleCheckBox2.Checked)
			{
				IniHelper.SetValue("OCR2", "mostAngle", "1");
			}
			else
			{
				IniHelper.SetValue("OCR2", "mostAngle", "0");
			}

			IniHelper.SetValue("OCR2", "numThread", ocrNum12.Value.ToString());

			if (radioButton1.Checked)
			{
				IniHelper.SetValue("paddle模型", "模型", "1");
			}
			else if (radioButton2.Checked)
			{
				IniHelper.SetValue("paddle模型", "模型", "2");
			}
			else if (radioButton3.Checked)
			{
				IniHelper.SetValue("paddle模型", "模型", "3");
			}

			//翻译接口
			IniHelper.SetValue("翻译API", "BDsecret_id", 翻译api_id.Text);
			IniHelper.SetValue("翻译API", "BDsecret_key", 翻译api_key.Text);

            IniHelper.SetValue("翻译API", "TXsecret_id", 腾讯翻译api_id.Text);
            IniHelper.SetValue("翻译API", "TXsecret_key", 腾讯翻译api_key.Text);

            IniHelper.SetValue("翻译API", "CYsecret_token", 彩云翻译api_token.Text);

            IniHelper.SetValue("翻译API", "offline_url", 离线翻译网址.Text);

            IniHelper.SetValue("其他特性", "静默识别", cbBox_静默识别.Checked.ToString());
            IniHelper.SetValue("其他特性", "始终复制", cbBox_是否复制.Checked.ToString());
            IniHelper.SetValue("其他特性", "添加换行", cbBox_是否添加换行.Checked.ToString());
            IniHelper.SetValue("其他特性", "缩放倍数", num_zoom.Value.ToString());
            IniHelper.SetValue("其他特性", "文字缩放倍数", num_zoom_text.Value.ToString());
            Process.Start(Application.ExecutablePath);

			//关闭当前实例
			Process.GetCurrentProcess().Kill();
		}
		//接口申请
        private void button2_Click(object sender, EventArgs e)
        {
			Process.Start("https://api.fanyi.baidu.com/");
		}

		private void button4_Click(object sender, EventArgs e)
		{
            Process.Start("https://cloud.tencent.com/product/tmt#featuresV2");
        

        }
	}
}
