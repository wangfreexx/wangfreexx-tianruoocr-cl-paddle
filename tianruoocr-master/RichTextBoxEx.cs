using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using TrOCR.Helper;

namespace TrOCR
{

	public class RichTextBoxEx : HelpRepaint.AdvRichTextBox
	{

		protected override void Dispose(bool disposing)
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			components = new Container();
		}

		[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern IntPtr LoadLibrary(string path);


		[Bindable(true)]
		[RefreshProperties(RefreshProperties.All)]
		[SettingsBindable(true)]
		[DefaultValue(false)]
		[Category("Appearance")]
		public string Rtf2
		{
			get
			{
				return Rtf;
			}
			set
			{
				Rtf = value;
			}
		}

		private IContainer components;

		private static IntPtr moduleHandle;
	}
}
