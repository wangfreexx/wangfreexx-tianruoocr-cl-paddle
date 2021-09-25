using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace TrOCR
{

	public partial class FmScreenPaste : Form
	{

		public FmScreenPaste(Image img, Point LocationPoint)
		{
			m_aeroEnabled = false;
			InitializeComponent();
			BackgroundImage = img;
			Location = LocationPoint;
			FormBorderStyle = FormBorderStyle.None;
			MouseDown += Form1_MouseDown;
			MouseMove += Form1_MouseMove;
			MouseUp += Form1_MouseUp;
			var size = img.Size;
			MaximumSize = (MinimumSize = size);
			Size = size;
			MouseDoubleClick += 双击_MouseDoubleClick;
            MouseWheel += Form_MouseWheel;
            KeyDown += FmScreenPaste_KeyDown;
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(AdvRichTextBox));
            Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("minico.Icon");
        }
        private void FmScreenPaste_KeyDown(object sender, KeyEventArgs e)
        {
            int t = 1;
            if (e.Shift)
            {
                t = 10;
            }
            switch (e.KeyCode)
            {
                case Keys.Left:
                    this.Left -= t * 1;
                    break;
                case Keys.Up:
                    this.Top -= t * 1;
                    break;
                case Keys.Right:
                    this.Left += t * 1;
                    break;
                case Keys.Down:
                    this.Top += t * 1;
                    break;
            }
        }
        System.Timers.Timer _timerTrt;
        /// <summary>
        /// 即刻执行，执行之后，在timeMs内再次调用无效
        /// </summary>
        /// <param name="timeMs">不应期，这段时间内调用无效</param>
        /// <param name="invoker">同步对象，一般为控件。 如不需同步可传null</param>
        public void Throttle(int timeMs, ISynchronizeInvoke invoker, Action action)
        {
            System.Threading.Monitor.Enter(this);
            bool needExit = true;
            try
            {
                if (_timerTrt == null)
                {
                    _timerTrt = new System.Timers.Timer(timeMs);
                    _timerTrt.AutoReset = false;
                    _timerTrt.Elapsed += (o, e) =>
                    {
                        _timerTrt.Stop();
                        _timerTrt.Close();
                        _timerTrt = null;
                    };
                    _timerTrt.Start();
                    System.Threading.Monitor.Exit(this);
                    needExit = false;
                    InvokeAction(action, invoker);//这个过程不能锁
                }
            }
            finally
            {
                if (needExit)
                    System.Threading.Monitor.Exit(this);
            }
        }
        private static void InvokeAction(Action action, ISynchronizeInvoke invoker)
        {
            if (invoker == null)
            {
                action();
            }
            else
            {
                if (invoker.InvokeRequired)
                {
                    invoker.Invoke(action, null);
                }
                else
                {
                    action();
                }
            }
        }
        //鼠标滚轮调整透明度
        private void Form_MouseWheel(object sender, MouseEventArgs e)
        {
            const double min = 0.2;
            const double max = 1;
            var isup = e.Delta < 0;
            Throttle(5, this, () =>
            {
                if (isup)
                {
                    if (this.Opacity <= min) return;
                    this.Opacity -= 0.1;
                }
                else
                {
                    if (this.Opacity >= max) return;
                    this.Opacity += 0.1;
                }
            });
        }

		private void RightCMS_Opening(object sender, CancelEventArgs e)
		{
			var topMost = TopMost;
			if (topMost)
			{
				置顶ToolStripMenuItem.Text = "取消置顶";
			}
			else
			{
				置顶ToolStripMenuItem.Text = "置顶窗体";
			}
		}

		private void 置顶ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			TopMost = !TopMost;
		}

		private void 关闭ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			BackgroundImage.Dispose();
			GC.Collect();
			Close();
		}

		private void 复制toolStripMenuItem_Click(object sender, EventArgs e)
		{
			Clipboard.SetImage(BackgroundImage);
		}

		private void 保存toolStripMenuItem_Click(object sender, EventArgs e)
		{
			var saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "jpg图片(*.jpg)|*.jpg|png图片(*.png)|*.jpg|bmp图片(*.bmp)|*.bmp";
			saveFileDialog.AddExtension = false;
			saveFileDialog.FileName = string.Concat("tianruo_", DateTime.Now.Year.ToString(), "-", DateTime.Now.Month.ToString(), "-", DateTime.Now.Day.ToString(), "-", DateTime.Now.Ticks.ToString());
			saveFileDialog.Title = "保存图片";
			saveFileDialog.FilterIndex = 1;
			saveFileDialog.RestoreDirectory = true;
			var flag = saveFileDialog.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				var extension = Path.GetExtension(saveFileDialog.FileName);
				var flag2 = extension.Equals(".jpg");
				if (flag2)
				{
					BackgroundImage.Save(saveFileDialog.FileName, ImageFormat.Jpeg);
				}
				var flag3 = extension.Equals(".png");
				if (flag3)
				{
					BackgroundImage.Save(saveFileDialog.FileName, ImageFormat.Png);
				}
				var flag4 = extension.Equals(".bmp");
				if (flag4)
				{
					BackgroundImage.Save(saveFileDialog.FileName, ImageFormat.Bmp);
				}
			}
		}

		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		[DllImport("user32.dll")]
		public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

		private void Form_MouseDown(object sender, MouseEventArgs e)
		{
			var wMsg = 274;
			var num = 61456;
			var num2 = 2;
			ReleaseCapture();
			SendMessage(Handle, wMsg, num + num2, 0);
		}

		[DllImport("Gdi32.dll")]
		private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

		[DllImport("dwmapi.dll")]
		public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);

		[DllImport("dwmapi.dll")]
		public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

		[DllImport("dwmapi.dll")]
		public static extern int DwmIsCompositionEnabled(ref int pfEnabled);

		private bool CheckAeroEnabled()
		{
			var flag = Environment.OSVersion.Version.Major >= 6;
			bool result;
			if (flag)
			{
				var num = 0;
				DwmIsCompositionEnabled(ref num);
				result = (num == 1);
			}
			else
			{
				result = false;
			}
			return result;
		}

		protected override void WndProc(ref Message m)
		{
			var msg = m.Msg;
			var flag = m.Msg == 132 && (int)m.Result == 1;
			if (flag)
			{
				m.Result = (IntPtr)2;
			}
			var flag2 = msg == 133 && m_aeroEnabled;
			if (flag2)
			{
				var num = 2;
				DwmSetWindowAttribute(Handle, 2, ref num, 4);
				var margins = new MARGINS
				{
					bottomHeight = 1,
					leftWidth = 1,
					rightWidth = 1,
					topHeight = 1
				};
				DwmExtendFrameIntoClientArea(Handle, ref margins);
			}
			base.WndProc(ref m);
		}

		protected override CreateParams CreateParams
		{
			get
			{
				m_aeroEnabled = CheckAeroEnabled();
				var createParams = base.CreateParams;
				var flag = !m_aeroEnabled;
				if (flag)
				{
					createParams.ClassStyle |= 131072;
				}
				return createParams;
			}
		}

		private void 双击_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			BackgroundImage.Dispose();
			GC.Collect();
			Close();
		}

		public void AdjustSize()
		{
			var size = new Size(10, 25);
			MaximumSize = (MinimumSize = size);
			Size = size;
		}

		private void Form1_MouseDown(object sender, MouseEventArgs e)
		{
			var flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				mouseOff = new Point(-e.X, -e.Y);
				leftFlag = true;
			}
		}

		private void Form1_MouseMove(object sender, MouseEventArgs e)
		{
			var flag = leftFlag;
			if (flag)
			{
				var mousePosition = MousePosition;
				mousePosition.Offset(mouseOff.X, mouseOff.Y);
				Location = mousePosition;
			}
		}

		private void Form1_MouseUp(object sender, MouseEventArgs e)
		{
			var flag = leftFlag;
			if (flag)
			{
				leftFlag = false;
			}
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			DoubleBuffered = true;
			var flag = BackgroundImage != null;
			if (flag)
			{
				e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
				e.Graphics.DrawImage(BackgroundImage, new Rectangle(0, 0, Width, Height), 0, 0, BackgroundImage.Width, BackgroundImage.Height, GraphicsUnit.Pixel);
			}
			base.OnPaint(e);
		}

		protected override void OnPaintBackground(PaintEventArgs e)
		{
		}

		private int zoomLevel;

		private string ScreenshotLastSavePath;

		private bool m_aeroEnabled;

		private const int CS_DROPSHADOW = 131072;

		private const int WM_NCPAINT = 133;

		private const int WM_ACTIVATEAPP = 28;

		private const int WM_NCHITTEST = 132;

		private const int HTCLIENT = 1;

		private const int HTCAPTION = 2;

		private Point mouseOff;

		private bool leftFlag;

		public struct MARGINS
		{

			public int leftWidth;

			public int rightWidth;

			public int topHeight;

			public int bottomHeight;
		}

        private void 最小化ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
