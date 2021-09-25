using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace TrOCR.Helper
{

	public class HelpRepaint
	{

		public class ColorItemX
		{

			public ColorItemX(string name, Color clr)
			{
				Name = name;
				ItemColor = clr;
			}


			public Color ItemColor
			{
				get => color;
                set => color = value;
            }


			public string Name { get; set; }

            public Color color;
		}

		public sealed class HwColorPicker : FloatLayerBase
		{

			public Color SelectedColor => selectedColor;


            [DefaultValue(true)]
			[Description("是否显示颜色提示")]
			public bool ShowTip { get; set; }


            [DefaultValue(typeof(Color), "255, 238, 194")]
			[Description("高亮背景色")]
			public Color HoverBkColor
			{
				get => hoverBKColor;
                set
				{
					var flag = hoverBKColor != value;
					var flag2 = flag;
					var flag3 = flag2;
					var flag4 = flag3;
					var flag5 = flag4;
					var flag6 = flag5;
					var flag7 = flag6;
					var flag8 = flag7;
					var flag9 = flag8;
					var flag10 = flag9;
					if (flag10)
					{
						var flag11 = hoverBrush != null;
						var flag12 = flag11;
						var flag13 = flag12;
						var flag14 = flag13;
						var flag15 = flag14;
						var flag16 = flag15;
						var flag17 = flag16;
						var flag18 = flag17;
						var flag19 = flag18;
						var flag20 = flag19;
						if (flag20)
						{
							hoverBrush.Dispose();
						}
						hoverBrush = new SolidBrush(value);
					}
					hoverBKColor = value;
				}
			}

			public List<ColorItemX> ColorTable => colorTable;

            public HwColorPicker()
			{
				Font = new Font(Font.Name, 9f / StaticValue.DpiFactor, Font.Style, Font.Unit, Font.GdiCharSet, Font.GdiVerticalFont);
				hoverItem = -1;
				InitializeComponent();
				InitColor();
				CalcWindowSize();
                sf = new StringFormat {Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center};
                HoverBkColor = Color.FromArgb(255, 238, 194);
				ShowTip = true;
			}

			public void CalcWindowSize()
			{
				var width = 152;
				var height = 100;
				Size = new Size(width, height);
			}

			public Rectangle CalcItemBound(int index)
			{
				var flag = index < 0 || index > 40;
				var flag2 = flag;
				var flag3 = flag2;
				var flag4 = flag3;
				var flag5 = flag4;
				var flag6 = flag5;
				var flag7 = flag6;
				var flag8 = flag7;
				var flag9 = flag8;
				var flag10 = flag9;
				if (flag10)
				{
					throw new ArgumentOutOfRangeException("index");
				}
				var flag11 = index == 40;
				var flag12 = flag11;
				var flag13 = flag12;
				var flag14 = flag13;
				var flag15 = flag14;
				var flag16 = flag15;
				var flag17 = flag16;
				var flag18 = flag17;
				var flag19 = flag18;
				var flag20 = flag19;
                var result = flag20 ? Rectangle.FromLTRB(0, 0, 0, 0) : new Rectangle(index % 8 * 18 + 3, index / 8 * 18 + 3, 18, 18);
				return result;
			}

			public int GetIndexFromPoint(Point point)
			{
				int result;
				if (point.X <= 3 || point.X >= Width - 3 || point.Y <= 3 || point.Y >= Height - 3)
				{
					result = -1;
				}
				else
				{
					var num = (point.Y - 3) / 18;
					if (num > 4)
					{
						result = 40;
					}
					else
					{
						var num2 = (point.X - 3) / 18;
						result = num * 8 + num2;
					}
				}
				return result;
			}

			public void SelectColor(Color clr)
			{
				selectedColor = clr;
				var flag = SelectedColorChanged != null;
				var flag2 = flag;
				var flag3 = flag2;
				var flag4 = flag3;
				var flag5 = flag4;
				var flag6 = flag5;
				var flag7 = flag6;
				var flag8 = flag7;
				var flag9 = flag8;
				var flag10 = flag9;
				if (flag10)
				{
					SelectedColorChanged(ctl_T, EventArgs.Empty);
				}
				Hide();
			}

			public void DrawItem(DrawItemEventArgs e)
			{
				var bounds = e.Bounds;
				bounds.Inflate(-1, -1);
				e.DrawBackground();
				var flag = (e.State & DrawItemState.HotLight) > DrawItemState.None;
				var flag2 = flag;
				var flag3 = flag2;
				var flag4 = flag3;
				var flag5 = flag4;
				var flag6 = flag5;
				var flag7 = flag6;
				var flag8 = flag7;
				var flag9 = flag8;
				var flag10 = flag9;
				if (flag10)
				{
					e.Graphics.FillRectangle(hoverBrush, bounds);
					e.Graphics.DrawRectangle(Pens.Black, bounds);
				}
				var flag11 = e.Index == 40;
				var flag12 = !flag11;
				var flag13 = flag12;
				var flag14 = flag13;
				var flag15 = flag14;
				var flag16 = flag15;
				var flag17 = flag16;
				var flag18 = flag17;
				var flag19 = flag18;
				var flag20 = flag19;
				if (flag20)
				{
					var bounds2 = e.Bounds;
					bounds2.Inflate(-3, -3);
					using (Brush brush = new SolidBrush(ColorTable[e.Index].ItemColor))
					{
						e.Graphics.FillRectangle(brush, bounds2);
					}
					e.Graphics.DrawRectangle(Pens.Gray, bounds2);
				}
			}

			public void HWColorPicker_Paint(object sender, PaintEventArgs e)
			{
				e.Graphics.DrawRectangle(Pens.LightGray, 0, 0, 150, 98);
				for (var i = 0; i < 40; i++)
				{
					var e2 = new DrawItemEventArgs(e.Graphics, Font, CalcItemBound(i), i, DrawItemState.Default, ForeColor, BackColor);
					DrawItem(e2);
				}
			}

			public void HWColorPicker_MouseMove(object sender, MouseEventArgs e)
			{
				var indexFromPoint = GetIndexFromPoint(e.Location);
				if (indexFromPoint != hoverItem)
				{
					var graphics = CreateGraphics();
					if (hoverItem != -1)
					{
						DrawItem(new DrawItemEventArgs(graphics, Font, CalcItemBound(hoverItem), hoverItem, DrawItemState.Default));
					}
					if (indexFromPoint <= 40)
					{
						if (indexFromPoint != -1)
						{
							if (ShowTip)
							{
								ShowToolTip(indexFromPoint);
							}
							DrawItem(new DrawItemEventArgs(graphics, Font, CalcItemBound(indexFromPoint), indexFromPoint, DrawItemState.Default | DrawItemState.HotLight));
						}
						graphics.Dispose();
						hoverItem = indexFromPoint;
					}
				}
			}

			public void HWColorPicker_MouseClick(object sender, MouseEventArgs e)
			{
				var indexFromPoint = GetIndexFromPoint(e.Location);
				if (indexFromPoint != -1 && indexFromPoint != 40)
				{
					SelectedColored = colorTable[indexFromPoint].ItemColor;
					DialogResult = DialogResult.OK;
				}
			}

			public void ShowToolTip(int index)
			{
				var flag = index == 40;
				var flag2 = !flag;
				var flag3 = flag2;
				var flag4 = flag3;
				var flag5 = flag4;
				var flag6 = flag5;
				var flag7 = flag6;
				var flag8 = flag7;
				var flag9 = flag8;
				var flag10 = flag9;
				if (flag10)
				{
					tip.SetToolTip(this, ColorTable[index].Name);
				}
			}

			public void InitColor()
			{
				colorTable = new List<ColorItemX>();
				colorTable.AddRange(new[]
				{
					new ColorItemX("黑色", Color.FromArgb(0, 0, 0)),
					new ColorItemX("褐色", Color.FromArgb(153, 51, 0)),
					new ColorItemX("橄榄色", Color.FromArgb(51, 51, 0)),
					new ColorItemX("深绿", Color.FromArgb(0, 51, 0)),
					new ColorItemX("深青", Color.FromArgb(0, 51, 102)),
					new ColorItemX("深蓝", Color.FromArgb(0, 0, 128)),
					new ColorItemX("靛蓝", Color.FromArgb(51, 51, 153)),
					new ColorItemX("灰色-80%", Color.FromArgb(51, 51, 51)),
					new ColorItemX("深红", Color.FromArgb(128, 0, 0)),
					new ColorItemX("橙色", Color.FromArgb(255, 102, 0)),
					new ColorItemX("深黄", Color.FromArgb(128, 128, 0)),
					new ColorItemX("绿色", Color.FromArgb(0, 128, 0)),
					new ColorItemX("青色", Color.FromArgb(0, 128, 128)),
					new ColorItemX("蓝色", Color.FromArgb(0, 0, 255)),
					new ColorItemX("蓝灰", Color.FromArgb(102, 102, 153)),
					new ColorItemX("灰色-50%", Color.FromArgb(128, 128, 128)),
					new ColorItemX("红色", Color.FromArgb(255, 0, 0)),
					new ColorItemX("浅橙", Color.FromArgb(255, 153, 0)),
					new ColorItemX("酸橙", Color.FromArgb(153, 204, 0)),
					new ColorItemX("海绿", Color.FromArgb(51, 153, 102)),
					new ColorItemX("水绿", Color.FromArgb(51, 204, 204)),
					new ColorItemX("浅蓝", Color.FromArgb(51, 102, 255)),
					new ColorItemX("紫罗兰", Color.FromArgb(128, 0, 128)),
					new ColorItemX("灰色-40%", Color.FromArgb(153, 153, 153)),
					new ColorItemX("粉红", Color.FromArgb(255, 0, 255)),
					new ColorItemX("金色", Color.FromArgb(255, 204, 0)),
					new ColorItemX("黄色", Color.FromArgb(255, 255, 0)),
					new ColorItemX("鲜绿", Color.FromArgb(0, 255, 0)),
					new ColorItemX("青绿", Color.FromArgb(0, 255, 255)),
					new ColorItemX("天蓝", Color.FromArgb(0, 204, 255)),
					new ColorItemX("梅红", Color.FromArgb(153, 51, 102)),
					new ColorItemX("灰色-25%", Color.FromArgb(192, 192, 192)),
					new ColorItemX("玫瑰红", Color.FromArgb(255, 153, 204)),
					new ColorItemX("茶色", Color.FromArgb(255, 204, 153)),
					new ColorItemX("浅黄", Color.FromArgb(255, 255, 204)),
					new ColorItemX("浅绿", Color.FromArgb(204, 255, 204)),
					new ColorItemX("浅青绿", Color.FromArgb(204, 255, 255)),
					new ColorItemX("淡蓝", Color.FromArgb(153, 204, 255)),
					new ColorItemX("淡紫", Color.FromArgb(204, 153, 255)),
					new ColorItemX("白色", Color.FromArgb(255, 255, 255))
				});
			}

			protected override void Dispose(bool disposing)
			{
				var flag = disposing && components != null;
				var flag2 = flag;
				var flag3 = flag2;
				var flag4 = flag3;
				var flag5 = flag4;
				var flag6 = flag5;
				var flag7 = flag6;
				var flag8 = flag7;
				var flag9 = flag8;
				var flag10 = flag9;
				if (flag10)
				{
					components.Dispose();
				}
				base.Dispose(disposing);
			}

			public void InitializeComponent()
			{
				components = new Container();
				tip = new ToolTip(components);
				SuspendLayout();
				BackColor = Color.White;
				AutoScaleMode = AutoScaleMode.None;
				Name = "HwColorPicker";
				Paint += HWColorPicker_Paint;
				MouseClick += HWColorPicker_MouseClick;
				MouseMove += HWColorPicker_MouseMove;
				ClientSize = new Size(114, 115);
				SizeGripStyle = SizeGripStyle.Hide;
				ResumeLayout(false);
			}


			public Color SelectedColored { get; private set; }

			[CompilerGenerated]
			private EventHandler SelectedColorChanged;

            private Color selectedColor;

            private Color hoverBKColor;

            private List<ColorItemX> colorTable;

			public StringFormat sf;

			public int hoverItem;

			public Control ctl;

			public Brush hoverBrush;

			public IContainer components;

			public ToolTip tip;

			public ToolStripButton ctl_T;
		}

		public class MenuItemRenderer : ToolStripProfessionalRenderer
		{

			public MenuItemRenderer()
			{
				textFont = new Font("微软雅黑", 9f / StaticValue.DpiFactor, FontStyle.Regular, GraphicsUnit.Point, 0);
				menuItemSelectedColor = Color.White;
				menuItemBorderColor = Color.White;
				menuItemSelectedColor = Color.White;
				menuItemBorderColor = Color.LightSlateGray;
			}

			protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
			{
				var isOnDropDown = e.Item.IsOnDropDown;
				var flag = isOnDropDown;
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
					var flag10 = e.Item.Selected && e.Item.Enabled;
					var flag11 = flag10;
					var flag12 = flag11;
					var flag13 = flag12;
					var flag14 = flag13;
					var flag15 = flag14;
					var flag16 = flag15;
					var flag17 = flag16;
					var flag18 = flag17;
					var flag19 = flag18;
					if (flag19)
					{
						DrawMenuDropDownItemHighlight(e);
					}
				}
				else
				{
					base.OnRenderMenuItemBackground(e);
				}
			}

			public void DrawMenuDropDownItemHighlight(ToolStripItemRenderEventArgs e)
            {
                var rect = new Rectangle(2, 0, (int)e.Graphics.VisibleClipBounds.Width - 36, (int)e.Graphics.VisibleClipBounds.Height - 1);
                using (var pen = new Pen(menuItemBorderColor))
				{
					e.Graphics.DrawRectangle(pen, rect);
				}
            }

			protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
			{
				var toolStrip = e.ToolStrip;
				e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
				var flag = e.ToolStrip is MenuStrip || e.ToolStrip is ToolStripDropDown;
				var flag2 = flag;
				var flag3 = flag2;
				var flag4 = flag3;
				var flag5 = flag4;
				var flag6 = flag5;
				var flag7 = flag6;
				var flag8 = flag7;
				var flag9 = flag8;
				var flag10 = flag9;
				if (flag10)
				{
					e.Graphics.DrawRectangle(new Pen(Color.LightSlateGray), new Rectangle(0, 0, e.AffectedBounds.Width - 1, e.AffectedBounds.Height - 1));
				}
				else
				{
					var flag11 = toolStrip != null;
					var flag12 = flag11;
					var flag13 = flag12;
					var flag14 = flag13;
					var flag15 = flag14;
					var flag16 = flag15;
					var flag17 = flag16;
					var flag18 = flag17;
					var flag19 = flag18;
					var flag20 = flag19;
					if (flag20)
					{
						e.Graphics.DrawRectangle(new Pen(Color.White), new Rectangle(0, 0, e.AffectedBounds.Width - 1, e.AffectedBounds.Height - 1));
					}
					base.OnRenderToolStripBorder(e);
				}
			}

			protected override void OnRenderButtonBackground(ToolStripItemRenderEventArgs e)
			{
				var graphics = e.Graphics;
				graphics.SmoothingMode = SmoothingMode.HighQuality;
				var item = e.Item;
				var selected = item.Selected;
				var flag = selected;
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
					var pen = new Pen(Color.LightSlateGray);
					var points = new[]
					{
						new Point(0, 0),
						new Point(item.Size.Width - 1, 0),
						new Point(item.Size.Width - 1, item.Size.Height - 3),
						new Point(0, item.Size.Height - 3),
						new Point(0, 0)
					};
					graphics.DrawLines(pen, points);
				}
				else
				{
					base.OnRenderMenuItemBackground(e);
				}
			}

			protected override void OnRenderSeparator(ToolStripSeparatorRenderEventArgs e)
			{
				var graphics = e.Graphics;
				var flag = e.ToolStrip is ToolStripDropDown;
				var flag2 = flag;
				var flag3 = flag2;
				var flag4 = flag3;
				var flag5 = flag4;
				var flag6 = flag5;
				var flag7 = flag6;
				var flag8 = flag7;
				var flag9 = flag8;
				var flag10 = flag9;
				if (flag10)
				{
					var brush = new LinearGradientBrush(new Point(0, 0), new Point(e.Item.Width, 0), Color.LightGray, Color.FromArgb(0, Color.LightGray));
					graphics.FillRectangle(brush, new Rectangle(33, e.Item.Height / 2, e.Item.Width / 4 * 3, 1));
				}
			}

			protected override void OnRenderDropDownButtonBackground(ToolStripItemRenderEventArgs e)
			{
				var item = e.Item;
				var graphics = e.Graphics;
				graphics.SmoothingMode = SmoothingMode.HighQuality;
                var selected = item.Selected;
				var flag = selected;
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
					var pen = new Pen(Color.LightSlateGray);
					var points = new[]
					{
						new Point(0, 0),
						new Point(item.Size.Width - 1, 0),
						new Point(item.Size.Width - 1, item.Size.Height - 3),
						new Point(0, item.Size.Height - 3),
						new Point(0, 0)
					};
					graphics.DrawLines(pen, points);
				}
				else
				{
					base.OnRenderMenuItemBackground(e);
				}
			}

			public Font textFont;

			public Color menuItemSelectedColor;

			public Color menuItemBorderColor;
		}

		public class MenuItemRendererT : ToolStripProfessionalRenderer
		{

			public MenuItemRendererT()
			{
				textFont = new Font("微软雅黑", 9f / StaticValue.DpiFactor, FontStyle.Regular, GraphicsUnit.Point, 0);
				menuItemSelectedColor = Color.White;
				menuItemBorderColor = Color.White;
				menuItemSelectedColor = Color.White;
				menuItemBorderColor = Color.LightSlateGray;
			}

			protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
			{
				var isOnDropDown = e.Item.IsOnDropDown;
				var flag = isOnDropDown;
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
					var flag10 = e.Item.Selected && e.Item.Enabled;
					var flag11 = flag10;
					var flag12 = flag11;
					var flag13 = flag12;
					var flag14 = flag13;
					var flag15 = flag14;
					var flag16 = flag15;
					var flag17 = flag16;
					var flag18 = flag17;
					var flag19 = flag18;
					if (flag19)
					{
						DrawMenuDropDownItemHighlight(e);
					}
				}
				else
				{
					base.OnRenderMenuItemBackground(e);
				}
			}

			public void DrawMenuDropDownItemHighlight(ToolStripItemRenderEventArgs e)
            {
                var rect = new Rectangle(2, 0, (int)e.Graphics.VisibleClipBounds.Width - 4, (int)e.Graphics.VisibleClipBounds.Height - 1);
                using (var pen = new Pen(menuItemBorderColor))
				{
					e.Graphics.DrawRectangle(pen, rect);
				}
            }

			public Font textFont;

			public Color menuItemSelectedColor;

			public Color menuItemBorderColor;
		}

		[Description("ToolStripItem that allows selecting a color from a color picker control.")]
		[DefaultEvent("SelectedColorChanged")]
		[ToolboxBitmap(typeof(ToolStripColorPicker), "ToolStripColorPicker")]
		[DefaultProperty("Color")]
		[ToolboxItem(false)]
		public class ToolStripColorPicker : ToolStripButton
		{

			public Point GetOpenPoint()
			{
				var flag = Owner == null;
				var flag2 = flag;
				var flag3 = flag2;
				var flag4 = flag3;
				var flag5 = flag4;
				var flag6 = flag5;
				var flag7 = flag6;
				var flag8 = flag7;
				var flag9 = flag8;
				var flag10 = flag9;
				Point result;
				if (flag10)
				{
					result = new Point(5, 5);
				}
				else
				{
					var num = 0;
					foreach (var obj in Parent.Items)
					{
						var toolStripItem = (ToolStripItem)obj;
						var flag11 = toolStripItem == this;
						var flag12 = flag11;
						var flag13 = flag12;
						var flag14 = flag13;
						var flag15 = flag14;
						var flag16 = flag15;
						var flag17 = flag16;
						var flag18 = flag17;
						var flag19 = flag18;
						var flag20 = flag19;
						if (flag20)
						{
							break;
						}
						num += toolStripItem.Width;
					}
					result = new Point(num, -4);
				}
				return result;
			}


			public Point GetPoint => GetOpenPoint();
        }

		public class ToolStripEx : ToolStrip
		{

			protected override void WndProc(ref Message m)
			{
				if (m.Msg == 33 && CanFocus && !Focused)
				{
					Focus();
				}
				base.WndProc(ref m);
			}
		}

		public class FloatLayerBase : Form
		{
			[DefaultValue(BorderStyle.Fixed3D)]
			[Description("获取或设置边框类型。")]
			public BorderStyle BorderType
			{
				get => _borderType;
                set
				{
					var flag = _borderType != value;
					var flag2 = flag;
					var flag3 = flag2;
					var flag4 = flag3;
					var flag5 = flag4;
					var flag6 = flag5;
					var flag7 = flag6;
					var flag8 = flag7;
					var flag9 = flag8;
					var flag10 = flag9;
					if (flag10)
					{
						_borderType = value;
						Invalidate();
					}
				}
			}


			[DefaultValue(Border3DStyle.RaisedInner)]
			[Description("获取或设置三维边框样式。")]
			public Border3DStyle Border3DStyle
			{
				get => _border3DStyle;
                set
				{
					var flag = _border3DStyle != value;
					var flag2 = flag;
					var flag3 = flag2;
					var flag4 = flag3;
					var flag5 = flag4;
					var flag6 = flag5;
					var flag7 = flag6;
					var flag8 = flag7;
					var flag9 = flag8;
					var flag10 = flag9;
					if (flag10)
					{
						_border3DStyle = value;
						Invalidate();
					}
				}
			}


			[DefaultValue(ButtonBorderStyle.Solid)]
			[Description("获取或设置线型边框样式。")]
			public ButtonBorderStyle BorderSingleStyle
			{
				get => _borderSingleStyle;
                set
				{
					var flag = _borderSingleStyle != value;
					var flag2 = flag;
					var flag3 = flag2;
					var flag4 = flag3;
					var flag5 = flag4;
					var flag6 = flag5;
					var flag7 = flag6;
					var flag8 = flag7;
					var flag9 = flag8;
					var flag10 = flag9;
					if (flag10)
					{
						_borderSingleStyle = value;
						Invalidate();
					}
				}
			}


			[DefaultValue(typeof(Color), "DarkGray")]
			[Description("获取或设置边框颜色（仅当边框类型为线型时有效）。")]
			public Color BorderColor
			{
				get => _borderColor;
                set
				{
					var flag = !(_borderColor == value);
					var flag2 = flag;
					var flag3 = flag2;
					var flag4 = flag3;
					var flag5 = flag4;
					var flag6 = flag5;
					var flag7 = flag6;
					var flag8 = flag7;
					var flag9 = flag8;
					var flag10 = flag9;
					if (flag10)
					{
						_borderColor = value;
						Invalidate();
					}
				}
			}

			protected sealed override CreateParams CreateParams
			{
				get
				{
					var createParams = base.CreateParams;
					createParams.Style |= 1073741824;
					createParams.Style |= 67108864;
					createParams.Style |= 65536;
					createParams.Style &= -262145;
					createParams.Style &= -8388609;
					createParams.Style &= -4194305;
					createParams.ExStyle = 0;
					createParams.ExStyle |= 65536;
					return createParams;
				}
			}

			public FloatLayerBase()
			{
				_mouseMsgFilter = new AppMouseMessageHandler(this);
				InitBaseProperties();
				_borderType = BorderStyle.Fixed3D;
				_border3DStyle = Border3DStyle.RaisedInner;
				_borderSingleStyle = ButtonBorderStyle.Solid;
				_borderColor = Color.DarkGray;
			}

			protected override void OnLoad(EventArgs e)
			{
				var flag = !_isShowDialogAgain;
				var flag2 = flag;
				var flag3 = flag2;
				var flag4 = flag3;
				var flag5 = flag4;
				var flag6 = flag5;
				var flag7 = flag6;
				var flag8 = flag7;
				var flag9 = flag8;
				var flag10 = flag9;
				if (flag10)
				{
					var flag11 = !DesignMode;
					var flag12 = flag11;
					var flag13 = flag12;
					var flag14 = flag13;
					var flag15 = flag14;
					var flag16 = flag15;
					var flag17 = flag16;
					var flag18 = flag17;
					var flag19 = flag18;
					var flag20 = flag19;
					if (flag20)
					{
						var frameBorderSize = SystemInformation.FrameBorderSize;
						Size -= frameBorderSize + frameBorderSize;
					}
					base.OnLoad(e);
				}
			}

			protected override void OnShown(EventArgs e)
			{
				var flag = !_isShowDialogAgain;
				var flag2 = flag;
				var flag3 = flag2;
				var flag4 = flag3;
				var flag5 = flag4;
				var flag6 = flag5;
				var flag7 = flag6;
				var flag8 = flag7;
				var flag9 = flag8;
				var flag10 = flag9;
				if (flag10)
				{
					var modal = Modal;
					var flag11 = modal;
					var flag12 = flag11;
					var flag13 = flag12;
					var flag14 = flag13;
					var flag15 = flag14;
					var flag16 = flag15;
					var flag17 = flag16;
					var flag18 = flag17;
					var flag19 = flag18;
					if (flag19)
					{
						_isShowDialogAgain = true;
					}
					Control control = null;
					var flag20 = !DesignMode && (control = GetNextControl(this, true)) != null;
					var flag21 = flag20;
					var flag22 = flag21;
					var flag23 = flag22;
					var flag24 = flag23;
					var flag25 = flag24;
					var flag26 = flag25;
					var flag27 = flag26;
					var flag28 = flag27;
					var flag29 = flag28;
					if (flag29)
					{
						control.Focus();
					}
					base.OnShown(e);
				}
			}

			protected override void WndProc(ref Message m)
			{
				var flag = m.Msg == 24 && m.WParam != IntPtr.Zero && m.LParam == IntPtr.Zero && Modal && Owner != null && !Owner.IsDisposed;
				var flag2 = flag;
				var flag3 = flag2;
				var flag4 = flag3;
				var flag5 = flag4;
				var flag6 = flag5;
				var flag7 = flag6;
				var flag8 = flag7;
				var flag9 = flag8;
				var flag10 = flag9;
				if (flag10)
				{
					var isMdiChild = Owner.IsMdiChild;
					var flag11 = isMdiChild;
					var flag12 = flag11;
					var flag13 = flag12;
					var flag14 = flag13;
					var flag15 = flag14;
					var flag16 = flag15;
					var flag17 = flag16;
					var flag18 = flag17;
					var flag19 = flag18;
					if (flag19)
					{
						NativeMethods.EnableWindow(Owner.MdiParent.Handle, true);
						NativeMethods.SetParent(Handle, Owner.Handle);
					}
					else
					{
						NativeMethods.EnableWindow(Owner.Handle, true);
					}
				}
				base.WndProc(ref m);
			}

			protected override void OnPaintBackground(PaintEventArgs e)
			{
				base.OnPaintBackground(e);
				var flag = _borderType == BorderStyle.Fixed3D;
				var flag2 = flag;
				var flag3 = flag2;
				var flag4 = flag3;
				var flag5 = flag4;
				var flag6 = flag5;
				var flag7 = flag6;
				var flag8 = flag7;
				var flag9 = flag8;
				var flag10 = flag9;
				if (flag10)
				{
					ControlPaint.DrawBorder3D(e.Graphics, ClientRectangle, Border3DStyle);
				}
				else
				{
					var flag11 = _borderType == BorderStyle.FixedSingle;
					var flag12 = flag11;
					var flag13 = flag12;
					var flag14 = flag13;
					var flag15 = flag14;
					var flag16 = flag15;
					var flag17 = flag16;
					var flag18 = flag17;
					var flag19 = flag18;
					var flag20 = flag19;
					if (flag20)
					{
						ControlPaint.DrawBorder(e.Graphics, ClientRectangle, BorderColor, BorderSingleStyle);
					}
				}
			}

			protected override void OnVisibleChanged(EventArgs e)
			{
				var flag = !DesignMode;
				var flag2 = flag;
				var flag3 = flag2;
				var flag4 = flag3;
				var flag5 = flag4;
				var flag6 = flag5;
				var flag7 = flag6;
				var flag8 = flag7;
				var flag9 = flag8;
				var flag10 = flag9;
				if (flag10)
				{
					var visible = Visible;
					var flag11 = visible;
					var flag12 = flag11;
					var flag13 = flag12;
					var flag14 = flag13;
					var flag15 = flag14;
					var flag16 = flag15;
					var flag17 = flag16;
					var flag18 = flag17;
					var flag19 = flag18;
					if (flag19)
					{
						Application.AddMessageFilter(_mouseMsgFilter);
					}
					else
					{
						Application.RemoveMessageFilter(_mouseMsgFilter);
					}
				}
				base.OnVisibleChanged(e);
			}

			public DialogResult ShowDialog(Control control)
			{
				return ShowDialog(control, 0, control.Height);
			}

			public DialogResult ShowDialog(Control control, int offsetX, int offsetY)
			{
				return ShowDialog(control, new Point(offsetX, offsetY));
			}

			public DialogResult ShowDialog(Control control, Point offset)
			{
				return ShowDialogInternal(control, offset);
			}

			public DialogResult ShowDialog(ToolStripItem item)
			{
				return ShowDialog(item, 0, item.Height + 4);
			}

			public DialogResult ShowDialog(ToolStripItem item, int offsetX, int offsetY)
			{
				return ShowDialog(item, new Point(offsetX, offsetY));
			}

			public DialogResult ShowDialog(ToolStripItem item, Point offset)
			{
				return ShowDialogInternal(item, offset);
			}

			public void Show(Control control)
			{
				Show(control, 0, control.Height);
			}

			public void Show(Control control, int offsetX, int offsetY)
			{
				Show(control, new Point(offsetX, offsetY));
			}

			public void Show(Control control, Point offset)
			{
				ShowInternal(control, offset);
			}

			public void Show(ToolStripItem item)
			{
				Show(item, 0, item.Height);
			}

			public void Show(ToolStripItem item, int offsetX, int offsetY)
			{
				Show(item, new Point(offsetX, offsetY));
			}

			public void Show(ToolStripItem item, Point offset)
			{
				ShowInternal(item, offset);
			}

			public DialogResult ShowDialogInternal(Component controlOrItem, Point offset)
			{
				var visible = Visible;
				var flag = visible;
				var flag2 = flag;
				var flag3 = flag2;
				var flag4 = flag3;
				var flag5 = flag4;
				var flag6 = flag5;
				var flag7 = flag6;
				var flag8 = flag7;
				var flag9 = flag8;
				DialogResult result;
				if (flag9)
				{
					result = DialogResult.None;
				}
				else
				{
					SetLocationAndOwner(controlOrItem, offset);
					result = base.ShowDialog();
				}
				return result;
			}

			public void ShowInternal(Component controlOrItem, Point offset)
			{
				var flag = !Visible;
				var flag2 = flag;
				var flag3 = flag2;
				var flag4 = flag3;
				var flag5 = flag4;
				var flag6 = flag5;
				var flag7 = flag6;
				var flag8 = flag7;
				var flag9 = flag8;
				var flag10 = flag9;
				if (flag10)
				{
					SetLocationAndOwner(controlOrItem, offset);
					base.Show();
				}
			}

			public void SetLocationAndOwner(Component controlOrItem, Point offset)
			{
				var empty = Point.Empty;
				var flag = controlOrItem is ToolStripItem;
				var flag2 = flag;
				var flag3 = flag2;
				var flag4 = flag3;
				var flag5 = flag4;
				var flag6 = flag5;
				var flag7 = flag6;
				var flag8 = flag7;
				var flag9 = flag8;
				var flag10 = flag9;
				if (flag10)
				{
					var toolStripItem = (ToolStripItem)controlOrItem;
					empty.Offset(toolStripItem.Bounds.Location);
					controlOrItem = toolStripItem.Owner;
				}
				var control = (Control)controlOrItem;
				empty.Offset(GetControlLocationInForm(control));
				empty.Offset(offset);
				Location = empty;
				Owner = control.FindForm();
			}

			public static Point GetControlLocationInForm(Control c)
			{
				var location = c.Location;
				while (!((c = c.Parent) is Form))
				{
					location.Offset(c.Location);
				}
				return location;
			}

			public void InitBaseProperties()
			{
				ControlBox = false;
				FormBorderStyle = FormBorderStyle.SizableToolWindow;
				base.Text = string.Empty;
				HelpButton = false;
				Icon = null;
				IsMdiContainer = false;
				MaximizeBox = false;
				MinimizeBox = false;
				ShowIcon = false;
				ShowInTaskbar = false;
				StartPosition = FormStartPosition.Manual;
				TopMost = false;
				WindowState = FormWindowState.Normal;
			}
//
//			[Obsolete("请使用别的重载！", true)]
//			[EditorBrowsable(EditorBrowsableState.Never)]
//			[Browsable(false)]
//			public new DialogResult ShowDialog()
//			{
//				throw new NotImplementedException();
//			}
//
//			[Obsolete("请使用别的重载！", true)]
//			[EditorBrowsable(EditorBrowsableState.Never)]
//			[Browsable(false)]
//			public new DialogResult ShowDialog(IWin32Window owner)
//			{
//				throw new NotImplementedException();
//			}
//
//			[Obsolete("请使用别的重载！", true)]
//			[EditorBrowsable(EditorBrowsableState.Never)]
//			[Browsable(false)]
//			public new void Show()
//			{
//				throw new NotImplementedException();
//			}
//
//			[EditorBrowsable(EditorBrowsableState.Never)]
//			[Browsable(false)]
//			[Obsolete("请使用别的重载！", true)]
//			public new void Show(IWin32Window owner)
//			{
//				throw new NotImplementedException();
//			}


            [Browsable(false)]
			[Obsolete("禁用该属性！", true)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public sealed override string Text
			{
				get => string.Empty;
                set
				{
				}
			}
//
//
//			[Obsolete("禁用该属性！", true)]
//			[EditorBrowsable(EditorBrowsableState.Never)]
//			[Browsable(false)]
//			public new bool HelpButton
//			{
//				get => false;
//                set
//				{
//				}
//			}
//
//
//			[EditorBrowsable(EditorBrowsableState.Never)]
//			[Browsable(false)]
//			[Obsolete("禁用该属性！", true)]
//			public new Image Icon
//			{
//				get => null;
//                set
//				{
//				}
//			}
//
//
//			[Obsolete("禁用该属性！", true)]
//			[EditorBrowsable(EditorBrowsableState.Never)]
//			[Browsable(false)]
//			public new bool IsMdiContainer
//			{
//				get => false;
//                set
//				{
//				}
//			}
//
//
//			[EditorBrowsable(EditorBrowsableState.Never)]
//			[Obsolete("禁用该属性！", true)]
//			[Browsable(false)]
//			public new bool MaximizeBox
//			{
//				get => false;
//                set
//				{
//				}
//			}
//
//
//			[EditorBrowsable(EditorBrowsableState.Never)]
//			[Browsable(false)]
//			[Obsolete("禁用该属性！", true)]
//			public new bool MinimizeBox
//			{
//				get => false;
//                set
//				{
//				}
//			}
//
//
//			[Browsable(false)]
//			[EditorBrowsable(EditorBrowsableState.Never)]
//			[Obsolete("禁用该属性！", true)]
//			public new bool ShowIcon
//			{
//				get => false;
//                set
//				{
//				}
//			}
//
//
//			[Browsable(false)]
//			[EditorBrowsable(EditorBrowsableState.Never)]
//			[Obsolete("禁用该属性！", true)]
//			public new bool ShowInTaskbar
//			{
//				get => false;
//                set
//				{
//				}
//			}
//
//
//			[Browsable(false)]
//			[Obsolete("禁用该属性！", true)]
//			[EditorBrowsable(EditorBrowsableState.Never)]
//			public new FormStartPosition StartPosition
//			{
//				get => FormStartPosition.Manual;
//                set
//				{
//				}
//			}
//
//
//			[Browsable(false)]
//			[EditorBrowsable(EditorBrowsableState.Never)]
//			[Obsolete("禁用该属性！", true)]
//			public new bool TopMost
//			{
//				get => false;
//                set
//				{
//				}
//			}
//
//
//			[Browsable(false)]
//			[Obsolete("禁用该属性！", true)]
//			[EditorBrowsable(EditorBrowsableState.Never)]
//			public new FormWindowState WindowState
//			{
//				get => FormWindowState.Normal;
//                set
//				{
//				}
//			}

			public readonly AppMouseMessageHandler _mouseMsgFilter;

			public bool _isShowDialogAgain;

			public BorderStyle _borderType;

			public Border3DStyle _border3DStyle;

			public ButtonBorderStyle _borderSingleStyle;

			public Color _borderColor;

			public class AppMouseMessageHandler : IMessageFilter
			{

				public AppMouseMessageHandler(FloatLayerBase layerForm)
				{
					_layerForm = layerForm;
				}

				public bool PreFilterMessage(ref Message m)
				{
					var flag = m.Msg == 513 && _layerForm.Visible && !NativeMethods.GetWindowRect(_layerForm.Handle).Contains(MousePosition);
					var flag2 = flag;
					var flag3 = flag2;
					var flag4 = flag3;
					var flag5 = flag4;
					var flag6 = flag5;
					var flag7 = flag6;
					var flag8 = flag7;
					var flag9 = flag8;
					var flag10 = flag9;
					if (flag10)
					{
						_layerForm.Hide();
					}
					return false;
				}

				public readonly FloatLayerBase _layerForm;
			}

			public static class NativeMethods
			{

				[DllImport("user32.dll")]
				[return: MarshalAs(UnmanagedType.Bool)]
				public static extern bool EnableWindow(IntPtr hWnd, bool bEnable);

				[DllImport("user32.dll", CharSet = CharSet.Auto)]
				public static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

				[DllImport("user32.dll")]
				public static extern bool ReleaseCapture();

				[DllImport("user32.dll", SetLastError = true)]
				public static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

				[DllImport("user32.dll", SetLastError = true)]
				public static extern bool GetWindowRect(IntPtr hwnd, out RECT lpRect);

				public static Rectangle GetWindowRect(IntPtr hwnd)
				{
					RECT rect;
					GetWindowRect(hwnd, out rect);
					return (Rectangle)rect;
				}

				public struct RECT
				{

					public static explicit operator Rectangle(RECT rect)
					{
						return new Rectangle(rect.left, rect.top, rect.right - rect.left, rect.bottom - rect.top);
					}

					public int left;

					public int top;

					public int right;

					public int bottom;
				}
			}
		}

		public class ColorPicker : ToolStripButton
		{

			public ColorPicker()
			{
				cp = new HwColorPicker
				{
					BorderType = BorderStyle.FixedSingle
				};
			}

			protected override void OnClick(EventArgs e)
			{
				var flag = cp.ShowDialog(this) == DialogResult.OK;
				var flag2 = flag;
				var flag3 = flag2;
				var flag4 = flag3;
				var flag5 = flag4;
				var flag6 = flag5;
				var flag7 = flag6;
				var flag8 = flag7;
				var flag9 = flag8;
				var flag10 = flag9;
				if (flag10)
				{
					select_color = cp.SelectedColored;
					base.OnClick(e);
				}
			}

			public Color SelectedColor => select_color;

            private readonly HwColorPicker cp;

			public Color select_color;
		}

		public class AdvRichTextBox : RichTextBox
		{

			public void BeginUpdate()
			{
				updating++;
				var flag = updating <= 1;
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
					oldEventMask = SendMessage(new HandleRef(this, Handle), 1073, 0, 0);
					SendMessage(new HandleRef(this, Handle), 11, 0, 0);
				}
			}

			public void EndUpdate()
			{
				updating--;
				var flag = updating <= 0;
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
					SendMessage(new HandleRef(this, Handle), 11, 1, 0);
					SendMessage(new HandleRef(this, Handle), 1073, 0, oldEventMask);
				}
			}


			public new TextAlign SelectionAlignment
			{
				get
				{
					var paraformat = default(PARAFORMAT);
					paraformat.cbSize = Marshal.SizeOf(paraformat);
					SendMessage(new HandleRef(this, Handle), 1085, 1, ref paraformat);
					var flag = (paraformat.dwMask & 8u) == 0u;
					var flag2 = flag;
					var flag3 = flag2;
					var flag4 = flag3;
					var flag5 = flag4;
					var flag6 = flag5;
					var flag7 = flag6;
					var flag8 = flag7;
					var flag9 = flag8;
					TextAlign result;
					if (flag9)
					{
						result = TextAlign.Left;
					}
					else
					{
						result = (TextAlign)paraformat.wAlignment;
					}
					return result;
				}
				set
				{
					var paraformat = default(PARAFORMAT);
					paraformat.cbSize = Marshal.SizeOf(paraformat);
					paraformat.dwMask = 8u;
					paraformat.wAlignment = (short)value;
					SendMessage(new HandleRef(this, Handle), 1095, 1, ref paraformat);
				}
			}

			protected override void OnHandleCreated(EventArgs e)
			{
				base.OnHandleCreated(e);
				var flag = !AutoWordSelection;
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
					AutoWordSelection = true;
					AutoWordSelection = false;
				}
				SendMessage(new HandleRef(this, Handle), 1226, 1, 1);
			}

			[DllImport("user32", CharSet = CharSet.Auto)]
			private static extern int SendMessage(HandleRef hWnd, int msg, int wParam, int lParam);

			[DllImport("user32", CharSet = CharSet.Auto)]
			private static extern int SendMessage(HandleRef hWnd, int msg, int wParam, ref PARAFORMAT lp);

			public void SetLineSpace()
			{
				var paraformat = default(PARAFORMAT);
				paraformat.cbSize = Marshal.SizeOf(paraformat);
				paraformat.bLineSpacingRule = 4;
				paraformat.dyLineSpacing = 400;
				paraformat.dwMask = 256u;
				SendMessage(new HandleRef(this, Handle), 1095, 0, ref paraformat);
			}

			public string SetLine
			{
				set => SetLineSpace();
            }

			private const int EM_SETEVENTMASK = 1073;

			private const int EM_GETPARAFORMAT = 1085;

			private const int EM_SETPARAFORMAT = 1095;

			private const int EM_SETTYPOGRAPHYOPTIONS = 1226;

			private const int WM_SETREDRAW = 11;

			private const int TO_ADVANCEDTYPOGRAPHY = 1;

			private const int PFM_ALIGNMENT = 8;

			private const int SCF_SELECTION = 1;

			private int updating;

			private int oldEventMask;

			private struct PARAFORMAT
			{

				public int cbSize;

				public uint dwMask;

				public short wNumbering;

				public short wReserved;

				public int dxStartIndent;

				public int dxRightIndent;

				public int dxOffset;

				public short wAlignment;

				public short cTabCount;

				[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
				public int[] rgxTabs;

				public int dySpaceBefore;

				public int dySpaceAfter;

				public int dyLineSpacing;

				public short sStyle;

				public byte bLineSpacingRule;

				public byte bOutlineLevel;

				public short wShadingWeight;

				public short wShadingStyle;

				public short wNumberingStart;

				public short wNumberingStyle;

				public short wNumberingTab;

				public short wBorderSpace;

				public short wBorderWidth;

				public short wBorders;
			}
		}

		public enum TextAlign
		{

			Left = 1,

			Right,

			Center,

			Justify
		}
	}
}
