using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using TrOCR.Helper;

namespace TrOCR
{

	public partial class FmLoading
    {

		public FmLoading()
		{
			InitializeComponent();
		}

		protected override CreateParams CreateParams
		{
			get
			{
				var createParams = base.CreateParams;
				createParams.Style |= 131072;
				var flag = !DesignMode;
				var flag2 = flag;
				var flag3 = flag2;
				var flag4 = flag3;
				var flag5 = flag4;
				var flag6 = flag5;
				var flag7 = flag6;
				var flag8 = flag7;
				var flag9 = flag8;
				if (flag9)
				{
					createParams.ExStyle |= 524288;
				}
				return createParams;
			}
		}

		public void SetBits(Bitmap bitmap)
		{
			var flag = Image.IsCanonicalPixelFormat(bitmap.PixelFormat) && Image.IsAlphaPixelFormat(bitmap.PixelFormat);
			var flag2 = flag;
			var flag3 = flag2;
			var flag4 = flag3;
			var flag5 = flag4;
			var flag6 = flag5;
			var flag7 = flag6;
			var flag8 = flag7;
			var flag9 = flag8;
			if (flag9)
			{
				var hObj = IntPtr.Zero;
				var dc = HelpWin32.GetDC(IntPtr.Zero);
				var intPtr = IntPtr.Zero;
				var intPtr2 = HelpWin32.CreateCompatibleDC(dc);
				try
				{
					var point = new HelpWin32.Point(Left, Top);
					var size = new HelpWin32.Size(bitmap.Width, bitmap.Height);
					var blendFunction = default(HelpWin32.BLENDFUNCTION);
					var point2 = new HelpWin32.Point(0, 0);
					intPtr = bitmap.GetHbitmap(Color.FromArgb(0));
					hObj = HelpWin32.SelectObject(intPtr2, intPtr);
					blendFunction.BlendOp = 0;
					blendFunction.SourceConstantAlpha = byte.MaxValue;
					blendFunction.AlphaFormat = 1;
					blendFunction.BlendFlags = 0;
					HelpWin32.UpdateLayeredWindow(Handle, dc, ref point, ref size, intPtr2, ref point2, 0, ref blendFunction, 2);
					return;
				}
				finally
				{
					var flag10 = intPtr != IntPtr.Zero;
					var flag11 = flag10;
					var flag12 = flag11;
					var flag13 = flag12;
					var flag14 = flag13;
					var flag15 = flag14;
					var flag16 = flag15;
					var flag17 = flag16;
					var flag18 = flag17;
					if (flag18)
					{
						HelpWin32.SelectObject(intPtr2, hObj);
						HelpWin32.DeleteObject(intPtr);
					}
					HelpWin32.ReleaseDC(IntPtr.Zero, dc);
					HelpWin32.DeleteDC(intPtr2);
				}
			}
			throw new ApplicationException("图片必须是32位带Alhpa通道的图片。");
		}

		public void InitializeComponent()
		{
			timer = new Timer();
			fm_close = "窗体已开启";
			SuspendLayout();
			ShowInTaskbar = false;
			AutoScaleDimensions = new SizeF(6f, 12f);
			AutoScaleMode = AutoScaleMode.Font;
			ForeColor = Color.Aqua;
			FormBorderStyle = FormBorderStyle.None;
			Name = "Form1";
			Text = "Form1";
			TopMost = true;
			ClientSize = new Size(120, 120);
			Location = (Point)new Size(500, 500);
			StartPosition = FormStartPosition.CenterScreen;
			Set_png();
			ResumeLayout(false);
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			try
			{
				var flag = fm_close != "窗体已开启";
				var flag2 = flag;
				var flag3 = flag2;
				var flag4 = flag3;
				var flag5 = flag4;
				var flag6 = flag5;
				var flag7 = flag6;
				var flag8 = flag7;
				var flag9 = flag8;
				if (flag9)
				{
					Close();
				}
				var flag10 = i_c >= fla_1;
				var flag11 = flag10;
				var flag12 = flag11;
				var flag13 = flag12;
				var flag14 = flag13;
				var flag15 = flag14;
				var flag16 = flag15;
				var flag17 = flag16;
				var flag18 = flag17;
				if (flag18)
				{
					i_c = 0;
				}
				bgImg = (Image)new ComponentResourceManager(typeof(FmLoading)).GetObject(i_c + fla_2 + ".png");
				SetBits((Bitmap)bgImg);
				i_c++;
			}
			catch
			{
				MessageBox.Show("加载窗体关闭报错");
			}
		}

		public void Set_png()
		{
			string a;
			try
			{
				a = IniHelper.GetValue("配置", "窗体动画");
			}
			catch
			{
				a = "窗体";
			}
			var flag = a == "少女";
			var flag2 = flag;
			var flag3 = flag2;
			var flag4 = flag3;
			var flag5 = flag4;
			var flag6 = flag5;
			if (flag6)
			{
				timer.Interval = 50;
				fla_1 = 27;
				fla_2 = "";
			}
			else
			{
				var flag7 = a == "罗小黑";
				var flag8 = flag7;
				var flag9 = flag8;
				var flag10 = flag9;
				var flag11 = flag10;
				var flag12 = flag11;
				if (flag12)
				{
					timer.Interval = 18;
					fla_1 = 46;
					fla_2 = "_luo";
				}
				else
				{
					timer.Interval = 80;
					fla_1 = 4;
					fla_2 = "_load";
				}
			}
			bgImg = null;
			i_c = 0;
			timer.Tick += timer1_Tick;
			timer.Start();
		}


		public string FmlClose
		{
			get => fm_close;
            set => fm_close = value;
        }

		public int i_c;

		private Image bgImg;

		public Timer timer;

		public int fla_1;

		public string fla_2;

		public string fm_close;
	}
}
