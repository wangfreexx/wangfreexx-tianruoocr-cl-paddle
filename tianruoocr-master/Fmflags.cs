using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Threading;
using System.Windows.Forms;
using TrOCR.Helper;

namespace TrOCR
{

	public partial class FmFlags
    {

		public FmFlags()
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
				if (flag8)
				{
					createParams.ExStyle |= 524288;
				}
				return createParams;
			}
		}

		public void SetBits(Bitmap bitmap)
		{
			var flag = !Image.IsCanonicalPixelFormat(bitmap.PixelFormat) || !Image.IsAlphaPixelFormat(bitmap.PixelFormat);
			var flag2 = flag;
			var flag3 = flag2;
			var flag4 = flag3;
			var flag5 = flag4;
			var flag6 = flag5;
			var flag7 = flag6;
			if (flag7)
			{
				throw new ApplicationException("图片必须是32位带Alhpa通道的图片。");
			}
			var hObj = IntPtr.Zero;
			var dc = HelpWin32.GetDC(IntPtr.Zero);
			var intPtr = IntPtr.Zero;
			var intPtr2 = HelpWin32.CreateCompatibleDC(dc);
			try
			{
				var point = new HelpWin32.Point(Left, Top);
				var size = new HelpWin32.Size(bitmap.Width, bitmap.Height);
				var blendfunction = default(HelpWin32.BLENDFUNCTION);
				var point2 = new HelpWin32.Point(0, 0);
				intPtr = bitmap.GetHbitmap(Color.FromArgb(0));
				hObj = HelpWin32.SelectObject(intPtr2, intPtr);
				blendfunction.BlendOp = 0;
				blendfunction.SourceConstantAlpha = byte.MaxValue;
				blendfunction.AlphaFormat = 1;
				blendfunction.BlendFlags = 0;
				HelpWin32.UpdateLayeredWindow(Handle, dc, ref point, ref size, intPtr2, ref point2, 0, ref blendfunction, 2);
			}
			finally
			{
				var flag8 = intPtr != IntPtr.Zero;
				var flag9 = flag8;
				var flag10 = flag9;
				var flag11 = flag10;
				var flag12 = flag11;
				var flag13 = flag12;
				var flag14 = flag13;
				if (flag14)
				{
					HelpWin32.SelectObject(intPtr2, hObj);
					HelpWin32.DeleteObject(intPtr);
				}
				HelpWin32.ReleaseDC(IntPtr.Zero, dc);
				HelpWin32.DeleteDC(intPtr2);
			}
		}

		public void DrawStr(string str)
		{
			宽度 = 50 * str.Length;
			ClientSize = new Size(宽度, 50);
			Location = new Point((Screen.PrimaryScreen.Bounds.Width - Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - Height) / 2 / 3 * 5);
			bmp = new Bitmap(宽度, 50);
			g = Graphics.FromImage(bmp);
			g.InterpolationMode = InterpolationMode.Bilinear;
			g.SmoothingMode = SmoothingMode.HighQuality;
			g.TextRenderingHint = TextRenderingHint.AntiAlias;
			g.Clear(Color.Transparent);
			g.FillRectangle(new SolidBrush(Color.FromArgb(1, 255, 255, 255)), ClientRectangle);
			var stringFormat = new StringFormat();
			stringFormat.Alignment = StringAlignment.Center;
			var r = new Rectangle(0, 3, 宽度, 50);
			g.FillRectangle(new SolidBrush(Color.FromArgb(120, Color.Black)), 1, 1, 宽度 - 2, 48);
			g.DrawRectangle(new Pen(Color.FromArgb(224, 224, 224)), 2, 2, 宽度 - 2 - 2, 46);
			g.DrawString(str, new Font("微软雅黑", 24f / Program.Factor), new SolidBrush(Color.FromArgb(255, Color.White)), r, stringFormat);
			SetBits(bmp);
			g.Dispose();
			bmp.Dispose();
			Delay(600u);
			Hide();
		}

		private void Delay(uint ms)
		{
			var tickCount = HelpWin32.GetTickCount();
			while (HelpWin32.GetTickCount() - tickCount < ms)
			{
				Thread.Sleep(1);
				Application.DoEvents();
			}
		}

		public void DrawStr_update(string str)
		{
			宽度 = 28 * str.Length;
			ClientSize = new Size(宽度, 50);
			bmp = new Bitmap(宽度, 50);
			g = Graphics.FromImage(bmp);
			g.InterpolationMode = InterpolationMode.Bilinear;
			g.SmoothingMode = SmoothingMode.HighQuality;
			g.TextRenderingHint = TextRenderingHint.AntiAlias;
			g.Clear(Color.Transparent);
			g.FillRectangle(new SolidBrush(Color.FromArgb(1, 255, 255, 255)), ClientRectangle);
			var stringFormat = new StringFormat();
			stringFormat.Alignment = StringAlignment.Center;
			var r = new Rectangle(0, 10, 宽度, 48);
			g.FillRectangle(new SolidBrush(Color.FromArgb(120, Color.Black)), 1, 1, 宽度 - 2, 48);
			g.DrawRectangle(new Pen(Color.FromArgb(224, 224, 224)), 1, 1, 宽度 - 2, 48);
			g.DrawString(str, new Font("微软雅黑", 18f), new SolidBrush(Color.FromArgb(255, Color.White)), r, stringFormat);
			SetBits_update(bmp);
			Delay(2000u);
			Hide();
		}

		public void SetBits_update(Bitmap bitmap)
		{
			var flag = !Image.IsCanonicalPixelFormat(bitmap.PixelFormat) || !Image.IsAlphaPixelFormat(bitmap.PixelFormat);
			var flag2 = flag;
			var flag3 = flag2;
			var flag4 = flag3;
			var flag5 = flag4;
			var flag6 = flag5;
			var flag7 = flag6;
			if (flag7)
			{
				throw new ApplicationException("图片必须是32位带Alhpa通道的图片。");
			}
			var hObj = IntPtr.Zero;
			var dc = HelpWin32.GetDC(IntPtr.Zero);
			var intPtr = IntPtr.Zero;
			var intPtr2 = HelpWin32.CreateCompatibleDC(dc);
			try
			{
				var point = new HelpWin32.Point(Screen.PrimaryScreen.Bounds.Width - Width, Screen.PrimaryScreen.WorkingArea.Height - 50);
				var size = new HelpWin32.Size(bitmap.Width, bitmap.Height);
				var blendfunction = default(HelpWin32.BLENDFUNCTION);
				var point2 = new HelpWin32.Point(0, 0);
				intPtr = bitmap.GetHbitmap(Color.FromArgb(0));
				hObj = HelpWin32.SelectObject(intPtr2, intPtr);
				blendfunction.BlendOp = 0;
				blendfunction.SourceConstantAlpha = byte.MaxValue;
				blendfunction.AlphaFormat = 1;
				blendfunction.BlendFlags = 0;
				HelpWin32.UpdateLayeredWindow(Handle, dc, ref point, ref size, intPtr2, ref point2, 0, ref blendfunction, 2);
			}
			finally
			{
				var flag8 = intPtr != IntPtr.Zero;
				var flag9 = flag8;
				var flag10 = flag9;
				var flag11 = flag10;
				var flag12 = flag11;
				var flag13 = flag12;
				var flag14 = flag13;
				if (flag14)
				{
					HelpWin32.SelectObject(intPtr2, hObj);
					HelpWin32.DeleteObject(intPtr);
				}
				HelpWin32.ReleaseDC(IntPtr.Zero, dc);
				HelpWin32.DeleteDC(intPtr2);
			}
		}

		private Bitmap bmp;

		private Graphics g;

		public int 宽度;
	}
}
