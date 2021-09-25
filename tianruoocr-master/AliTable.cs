using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using TrOCR.Helper;

namespace TrOCR
{

    public partial class AliTable : Form
	{

		public AliTable()
		{
			string fileName = Path.GetFileName(Application.ExecutablePath);
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Internet Explorer\\MAIN\\FeatureControl\\FEATURE_BROWSER_EMULATION", true);
			if (registryKey != null)
			{
				registryKey.SetValue(fileName, 11001, RegistryValueKind.DWord);
				registryKey.SetValue(fileName, 11001, RegistryValueKind.DWord);
			}
			registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Wow6432Node\\Microsoft\\Internet Explorer\\MAIN\\FeatureControl\\FEATURE_BROWSER_EMULATION", true);
			if (registryKey != null)
			{
				registryKey.SetValue(fileName, 11001, RegistryValueKind.DWord);
				registryKey.SetValue(fileName, 11001, RegistryValueKind.DWord);
			}
			InitializeComponent();
		}

		[DllImport("wininet.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern bool InternetGetCookieEx(string pchURL, string pchCookieName, StringBuilder pchCookieData, ref int pcchCookieData, int dwFlags, object lpReserved);

		private string GetCookieString(string url)
		{
			int num = 256;
			StringBuilder stringBuilder = new StringBuilder(num);
			if (!InternetGetCookieEx(url, null, stringBuilder, ref num, 8192, null))
			{
				if (num < 0)
				{
					return null;
				}
				stringBuilder = new StringBuilder(num);
				if (!InternetGetCookieEx(url, null, stringBuilder, ref num, 8192, null))
				{
					return null;
				}
			}
			return stringBuilder.ToString();
		}

		private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
		{
			try
			{
				count++;
				textBox1.Text = GetCookieString(e.Url.ToString());
				webBrowser1.Document.Window.ScrollTo(10000, 145);
				webBrowser1.Document.Body.SetAttribute("scroll", "no");
				webBrowser1.Document.GetElementById("guid-762944").OuterHtml = "";
				if (count <= 10)
				{
					timer1.Interval = 500;
					timer1.Start();
				}
			}
			catch
			{
			}
		}

		private void Form2_Load(object sender, EventArgs e)
		{
			webBrowser1.Url = new Uri("https://data.aliyun.com/ai/ocr-other#/ocr-other");
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			if (textBox1.Text.Contains("login_aliyunid=\""))
			{
				webBrowser1.Url = new Uri("https://data.aliyun.com/ai/ocr-other#/ocr-other");
				IniHelper.SetValue("特殊", "ali_cookie", textBox1.Text);
                Hide();
			}
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			if (webBrowser1.ReadyState == WebBrowserReadyState.Complete)
			{
				try
				{
					cclick();
				}
				catch
				{
				}
				if (count >= 2)
				{
					count = 0;
                    Show();
				}
				timer1.Stop();
			}
		}

		// (get) Token: 0x0600030A RID: 778 RVA: 0x00003043 File Offset: 0x00001243
		// (set) Token: 0x0600030B RID: 779 RVA: 0x00003007 File Offset: 0x00001207
		public string getcookie
		{
			get
			{
				return textBox1.Text;
			}
			set
			{
				webBrowser1.Url = new Uri("https://data.aliyun.com/ai/ocr-other#/ocr-other");
			}
		}

		public void cclick()
		{
			try
			{
				if (IniHelper.GetValue("特殊", "ali_account").Trim() != "" && IniHelper.GetValue("特殊", "ali_password").Trim() != "")
				{
//                    WebBrowserHelper.GetDocumentFromWindow(webBrowser1.Document.Window.Frames["alibaba-login-box"].DomWindow as IHTMLWindow2).getElementById("fm-login-id").setAttribute("value", IniHelper.GetValue("特殊", "ali_account"), 1);
//                    WebBrowserHelper.GetDocumentFromWindow(webBrowser1.Document.Window.Frames["alibaba-login-box"].DomWindow as IHTMLWindow2).getElementById("fm-login-password").setAttribute("value", IniHelper.GetValue("特殊", "ali_password"), 1);
				}
			}
			catch
			{
			}
		}

		private int count;
	}
}
