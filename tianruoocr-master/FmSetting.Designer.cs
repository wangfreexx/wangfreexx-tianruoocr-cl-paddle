namespace TrOCR
{

	public sealed partial class FmSetting : global::System.Windows.Forms.Form
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
            this.Page_代理 = new System.Windows.Forms.TabPage();
            this.代理Button = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chbox_代理服务器 = new System.Windows.Forms.CheckBox();
            this.text_密码 = new System.Windows.Forms.TextBox();
            this.text_端口 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.text_账号 = new System.Windows.Forms.TextBox();
            this.text_服务器 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.combox_代理 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Page_密钥 = new System.Windows.Forms.TabPage();
            this.百度_btn = new System.Windows.Forms.Button();
            this.密钥Button_apply = new System.Windows.Forms.Button();
            this.密钥Button = new System.Windows.Forms.Button();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.inPage_百度接口 = new System.Windows.Forms.TabPage();
            this.text_baidupassword = new System.Windows.Forms.TextBox();
            this.text_baiduaccount = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Page_快捷键 = new System.Windows.Forms.TabPage();
            this.快捷键Button = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox_识别界面 = new System.Windows.Forms.PictureBox();
            this.pictureBox_记录界面 = new System.Windows.Forms.PictureBox();
            this.pictureBox_翻译文本 = new System.Windows.Forms.PictureBox();
            this.pictureBox_文字识别 = new System.Windows.Forms.PictureBox();
            this.txtBox_识别界面 = new System.Windows.Forms.TextBox();
            this.txtBox_记录界面 = new System.Windows.Forms.TextBox();
            this.txtBox_翻译文本 = new System.Windows.Forms.TextBox();
            this.txtBox_文字识别 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.page_常规 = new System.Windows.Forms.TabPage();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.chbox_save = new System.Windows.Forms.CheckBox();
            this.chbox_copy = new System.Windows.Forms.CheckBox();
            this.label20 = new System.Windows.Forms.Label();
            this.btn_音效路径 = new System.Windows.Forms.Button();
            this.btn_音效 = new System.Windows.Forms.Button();
            this.text_音效path = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btn_浏览 = new System.Windows.Forms.Button();
            this.textBox_path = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbBox_保存 = new System.Windows.Forms.CheckBox();
            this.pic_help = new System.Windows.Forms.PictureBox();
            this.常规Button = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numbox_记录 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cobBox_动画 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chbox_取色 = new System.Windows.Forms.CheckBox();
            this.cbBox_弹窗 = new System.Windows.Forms.CheckBox();
            this.cbBox_翻译 = new System.Windows.Forms.CheckBox();
            this.cbBox_开机 = new System.Windows.Forms.CheckBox();
            this.tab_标签 = new System.Windows.Forms.TabControl();
            this.Page_更新 = new System.Windows.Forms.TabPage();
            this.更新Button_check = new System.Windows.Forms.Button();
            this.更新Button = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.numbox_间隔时间 = new System.Windows.Forms.NumericUpDown();
            this.checkBox_更新间隔 = new System.Windows.Forms.CheckBox();
            this.check_检查更新 = new System.Windows.Forms.CheckBox();
            this.Page_反馈 = new System.Windows.Forms.TabPage();
            this.label21 = new System.Windows.Forms.Label();
            this.反馈Button = new System.Windows.Forms.Button();
            this.txt_问题反馈 = new System.Windows.Forms.TextBox();
            this.Page_OCR设置 = new System.Windows.Forms.TabPage();
            this.label27 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label26 = new System.Windows.Forms.Label();
            this.ocrNum6 = new System.Windows.Forms.NumericUpDown();
            this.ocrNum3 = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.ocrNum2 = new System.Windows.Forms.NumericUpDown();
            this.label22 = new System.Windows.Forms.Label();
            this.ocrNum1 = new System.Windows.Forms.NumericUpDown();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.ocrNum4 = new System.Windows.Forms.NumericUpDown();
            this.label25 = new System.Windows.Forms.Label();
            this.ocrNum5 = new System.Windows.Forms.NumericUpDown();
            this.doAngleCheckBox = new System.Windows.Forms.CheckBox();
            this.mostAngleCheckBox = new System.Windows.Forms.CheckBox();
            this.Page_OCR设置2 = new System.Windows.Forms.TabPage();
            this.label28 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label29 = new System.Windows.Forms.Label();
            this.ocrNum12 = new System.Windows.Forms.NumericUpDown();
            this.ocrNum9 = new System.Windows.Forms.NumericUpDown();
            this.label30 = new System.Windows.Forms.Label();
            this.ocrNum8 = new System.Windows.Forms.NumericUpDown();
            this.label31 = new System.Windows.Forms.Label();
            this.ocrNum7 = new System.Windows.Forms.NumericUpDown();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.ocrNum10 = new System.Windows.Forms.NumericUpDown();
            this.label34 = new System.Windows.Forms.Label();
            this.ocrNum11 = new System.Windows.Forms.NumericUpDown();
            this.doAngleCheckBox2 = new System.Windows.Forms.CheckBox();
            this.mostAngleCheckBox2 = new System.Windows.Forms.CheckBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label_版本号 = new System.Windows.Forms.Label();
            this.label_更新日期 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.txt_更新说明 = new System.Windows.Forms.TextBox();
            this.Page_代理.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.Page_密钥.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.inPage_百度接口.SuspendLayout();
            this.Page_快捷键.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_识别界面)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_记录界面)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_翻译文本)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_文字识别)).BeginInit();
            this.page_常规.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_help)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numbox_记录)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tab_标签.SuspendLayout();
            this.Page_更新.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numbox_间隔时间)).BeginInit();
            this.Page_反馈.SuspendLayout();
            this.Page_OCR设置.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ocrNum6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocrNum3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocrNum2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocrNum1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocrNum4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocrNum5)).BeginInit();
            this.Page_OCR设置2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ocrNum12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocrNum9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocrNum8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocrNum7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocrNum10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocrNum11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // Page_代理
            // 
            this.Page_代理.BackColor = System.Drawing.Color.White;
            this.Page_代理.Controls.Add(this.代理Button);
            this.Page_代理.Controls.Add(this.groupBox4);
            this.Page_代理.Location = new System.Drawing.Point(4, 22);
            this.Page_代理.Name = "Page_代理";
            this.Page_代理.Padding = new System.Windows.Forms.Padding(3);
            this.Page_代理.Size = new System.Drawing.Size(390, 329);
            this.Page_代理.TabIndex = 4;
            this.Page_代理.Text = "代理";
            // 
            // 代理Button
            // 
            this.代理Button.BackColor = System.Drawing.Color.White;
            this.代理Button.Location = new System.Drawing.Point(309, 193);
            this.代理Button.Name = "代理Button";
            this.代理Button.Size = new System.Drawing.Size(75, 23);
            this.代理Button.TabIndex = 9;
            this.代理Button.Text = "恢复默认";
            this.代理Button.UseVisualStyleBackColor = false;
            this.代理Button.Click += new System.EventHandler(this.代理Button_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chbox_代理服务器);
            this.groupBox4.Controls.Add(this.text_密码);
            this.groupBox4.Controls.Add(this.text_端口);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.text_账号);
            this.groupBox4.Controls.Add(this.text_服务器);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.combox_代理);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(3, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(381, 183);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "代理";
            // 
            // chbox_代理服务器
            // 
            this.chbox_代理服务器.AutoSize = true;
            this.chbox_代理服务器.Location = new System.Drawing.Point(78, 84);
            this.chbox_代理服务器.Name = "chbox_代理服务器";
            this.chbox_代理服务器.Size = new System.Drawing.Size(132, 16);
            this.chbox_代理服务器.TabIndex = 12;
            this.chbox_代理服务器.Text = "代理服务器需要密码";
            this.chbox_代理服务器.UseVisualStyleBackColor = true;
            // 
            // text_密码
            // 
            this.text_密码.Location = new System.Drawing.Point(78, 144);
            this.text_密码.Name = "text_密码";
            this.text_密码.Size = new System.Drawing.Size(128, 21);
            this.text_密码.TabIndex = 11;
            this.text_密码.TextChanged += new System.EventHandler(this.text_密码_TextChanged);
            // 
            // text_端口
            // 
            this.text_端口.Location = new System.Drawing.Point(248, 52);
            this.text_端口.Name = "text_端口";
            this.text_端口.Size = new System.Drawing.Size(55, 21);
            this.text_端口.TabIndex = 10;
            this.text_端口.Text = " ";
            this.text_端口.TextChanged += new System.EventHandler(this.text_端口_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(212, 57);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 12);
            this.label15.TabIndex = 9;
            this.label15.Text = "端口：";
            // 
            // text_账号
            // 
            this.text_账号.Location = new System.Drawing.Point(78, 110);
            this.text_账号.Name = "text_账号";
            this.text_账号.Size = new System.Drawing.Size(128, 21);
            this.text_账号.TabIndex = 8;
            this.text_账号.TextChanged += new System.EventHandler(this.text_账号_TextChanged);
            // 
            // text_服务器
            // 
            this.text_服务器.Location = new System.Drawing.Point(78, 52);
            this.text_服务器.Name = "text_服务器";
            this.text_服务器.Size = new System.Drawing.Size(128, 21);
            this.text_服务器.TabIndex = 7;
            this.text_服务器.TextChanged += new System.EventHandler(this.text_服务器_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 147);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 12);
            this.label14.TabIndex = 6;
            this.label14.Text = "密码：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 114);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 5;
            this.label13.Text = "用户名：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 57);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 4;
            this.label12.Text = "服务器：";
            // 
            // combox_代理
            // 
            this.combox_代理.BackColor = System.Drawing.Color.White;
            this.combox_代理.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combox_代理.FormattingEnabled = true;
            this.combox_代理.Items.AddRange(new object[] {
            "不使用代理",
            "系统代理",
            "自定义代理"});
            this.combox_代理.Location = new System.Drawing.Point(78, 18);
            this.combox_代理.Name = "combox_代理";
            this.combox_代理.Size = new System.Drawing.Size(95, 20);
            this.combox_代理.TabIndex = 3;
            this.combox_代理.SelectedIndexChanged += new System.EventHandler(this.combox_代理_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 0;
            this.label11.Text = "代理类型：";
            // 
            // Page_密钥
            // 
            this.Page_密钥.BackColor = System.Drawing.Color.White;
            this.Page_密钥.Controls.Add(this.百度_btn);
            this.Page_密钥.Controls.Add(this.密钥Button_apply);
            this.Page_密钥.Controls.Add(this.密钥Button);
            this.Page_密钥.Controls.Add(this.tabControl2);
            this.Page_密钥.Location = new System.Drawing.Point(4, 22);
            this.Page_密钥.Name = "Page_密钥";
            this.Page_密钥.Padding = new System.Windows.Forms.Padding(3);
            this.Page_密钥.Size = new System.Drawing.Size(390, 329);
            this.Page_密钥.TabIndex = 3;
            this.Page_密钥.Text = "密钥";
            // 
            // 百度_btn
            // 
            this.百度_btn.BackColor = System.Drawing.Color.White;
            this.百度_btn.Location = new System.Drawing.Point(152, 136);
            this.百度_btn.Name = "百度_btn";
            this.百度_btn.Size = new System.Drawing.Size(75, 23);
            this.百度_btn.TabIndex = 10;
            this.百度_btn.Text = "密钥测试";
            this.百度_btn.UseVisualStyleBackColor = false;
            this.百度_btn.Click += new System.EventHandler(this.百度_btn_Click);
            // 
            // 密钥Button_apply
            // 
            this.密钥Button_apply.BackColor = System.Drawing.Color.White;
            this.密钥Button_apply.Location = new System.Drawing.Point(6, 136);
            this.密钥Button_apply.Name = "密钥Button_apply";
            this.密钥Button_apply.Size = new System.Drawing.Size(75, 23);
            this.密钥Button_apply.TabIndex = 9;
            this.密钥Button_apply.Text = "接口申请";
            this.密钥Button_apply.UseVisualStyleBackColor = false;
            this.密钥Button_apply.Click += new System.EventHandler(this.百度申请_Click);
            // 
            // 密钥Button
            // 
            this.密钥Button.BackColor = System.Drawing.Color.White;
            this.密钥Button.Location = new System.Drawing.Point(309, 136);
            this.密钥Button.Name = "密钥Button";
            this.密钥Button.Size = new System.Drawing.Size(75, 23);
            this.密钥Button.TabIndex = 8;
            this.密钥Button.Text = "恢复默认";
            this.密钥Button.UseVisualStyleBackColor = false;
            this.密钥Button.Click += new System.EventHandler(this.密钥Button_Click);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.inPage_百度接口);
            this.tabControl2.Location = new System.Drawing.Point(6, 6);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(378, 124);
            this.tabControl2.TabIndex = 0;
            // 
            // inPage_百度接口
            // 
            this.inPage_百度接口.BackColor = System.Drawing.Color.White;
            this.inPage_百度接口.Controls.Add(this.text_baidupassword);
            this.inPage_百度接口.Controls.Add(this.text_baiduaccount);
            this.inPage_百度接口.Controls.Add(this.label10);
            this.inPage_百度接口.Controls.Add(this.label9);
            this.inPage_百度接口.Location = new System.Drawing.Point(4, 22);
            this.inPage_百度接口.Name = "inPage_百度接口";
            this.inPage_百度接口.Padding = new System.Windows.Forms.Padding(3);
            this.inPage_百度接口.Size = new System.Drawing.Size(370, 98);
            this.inPage_百度接口.TabIndex = 0;
            this.inPage_百度接口.Text = "百度识别接口";
            // 
            // text_baidupassword
            // 
            this.text_baidupassword.BackColor = System.Drawing.Color.White;
            this.text_baidupassword.Location = new System.Drawing.Point(56, 55);
            this.text_baidupassword.Name = "text_baidupassword";
            this.text_baidupassword.Size = new System.Drawing.Size(260, 21);
            this.text_baidupassword.TabIndex = 3;
            this.text_baidupassword.TextChanged += new System.EventHandler(this.text_baidupassword_TextChanged);
            // 
            // text_baiduaccount
            // 
            this.text_baiduaccount.BackColor = System.Drawing.Color.White;
            this.text_baiduaccount.Location = new System.Drawing.Point(56, 20);
            this.text_baiduaccount.Name = "text_baiduaccount";
            this.text_baiduaccount.Size = new System.Drawing.Size(260, 21);
            this.text_baiduaccount.TabIndex = 2;
            this.text_baiduaccount.TextChanged += new System.EventHandler(this.text_baiduaccount_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 1;
            this.label10.Text = "密码：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "账号：";
            // 
            // Page_快捷键
            // 
            this.Page_快捷键.BackColor = System.Drawing.Color.White;
            this.Page_快捷键.Controls.Add(this.快捷键Button);
            this.Page_快捷键.Controls.Add(this.label8);
            this.Page_快捷键.Controls.Add(this.groupBox3);
            this.Page_快捷键.Location = new System.Drawing.Point(4, 22);
            this.Page_快捷键.Name = "Page_快捷键";
            this.Page_快捷键.Padding = new System.Windows.Forms.Padding(3);
            this.Page_快捷键.Size = new System.Drawing.Size(390, 329);
            this.Page_快捷键.TabIndex = 2;
            this.Page_快捷键.Text = "快捷键";
            // 
            // 快捷键Button
            // 
            this.快捷键Button.BackColor = System.Drawing.Color.White;
            this.快捷键Button.Location = new System.Drawing.Point(309, 175);
            this.快捷键Button.Name = "快捷键Button";
            this.快捷键Button.Size = new System.Drawing.Size(75, 23);
            this.快捷键Button.TabIndex = 7;
            this.快捷键Button.Text = "恢复默认";
            this.快捷键Button.UseVisualStyleBackColor = false;
            this.快捷键Button.Click += new System.EventHandler(this.快捷键Button_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(215, 12);
            this.label8.TabIndex = 1;
            this.label8.Text = "说明：按Backspace键可清除当前快捷键";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureBox_识别界面);
            this.groupBox3.Controls.Add(this.pictureBox_记录界面);
            this.groupBox3.Controls.Add(this.pictureBox_翻译文本);
            this.groupBox3.Controls.Add(this.pictureBox_文字识别);
            this.groupBox3.Controls.Add(this.txtBox_识别界面);
            this.groupBox3.Controls.Add(this.txtBox_记录界面);
            this.groupBox3.Controls.Add(this.txtBox_翻译文本);
            this.groupBox3.Controls.Add(this.txtBox_文字识别);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(378, 163);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "全局快捷键";
            // 
            // pictureBox_识别界面
            // 
            this.pictureBox_识别界面.Image = global::TrOCR.Properties.Resources.快捷键_1;
            this.pictureBox_识别界面.Location = new System.Drawing.Point(351, 122);
            this.pictureBox_识别界面.Name = "pictureBox_识别界面";
            this.pictureBox_识别界面.Size = new System.Drawing.Size(21, 21);
            this.pictureBox_识别界面.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_识别界面.TabIndex = 11;
            this.pictureBox_识别界面.TabStop = false;
            // 
            // pictureBox_记录界面
            // 
            this.pictureBox_记录界面.Image = global::TrOCR.Properties.Resources.快捷键_1;
            this.pictureBox_记录界面.Location = new System.Drawing.Point(351, 89);
            this.pictureBox_记录界面.Name = "pictureBox_记录界面";
            this.pictureBox_记录界面.Size = new System.Drawing.Size(21, 21);
            this.pictureBox_记录界面.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_记录界面.TabIndex = 10;
            this.pictureBox_记录界面.TabStop = false;
            // 
            // pictureBox_翻译文本
            // 
            this.pictureBox_翻译文本.Image = global::TrOCR.Properties.Resources.快捷键_1;
            this.pictureBox_翻译文本.Location = new System.Drawing.Point(351, 52);
            this.pictureBox_翻译文本.Name = "pictureBox_翻译文本";
            this.pictureBox_翻译文本.Size = new System.Drawing.Size(21, 21);
            this.pictureBox_翻译文本.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_翻译文本.TabIndex = 9;
            this.pictureBox_翻译文本.TabStop = false;
            // 
            // pictureBox_文字识别
            // 
            this.pictureBox_文字识别.Image = global::TrOCR.Properties.Resources.快捷键_1;
            this.pictureBox_文字识别.Location = new System.Drawing.Point(351, 19);
            this.pictureBox_文字识别.Name = "pictureBox_文字识别";
            this.pictureBox_文字识别.Size = new System.Drawing.Size(21, 21);
            this.pictureBox_文字识别.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_文字识别.TabIndex = 8;
            this.pictureBox_文字识别.TabStop = false;
            // 
            // txtBox_识别界面
            // 
            this.txtBox_识别界面.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.txtBox_识别界面.Location = new System.Drawing.Point(78, 122);
            this.txtBox_识别界面.Name = "txtBox_识别界面";
            this.txtBox_识别界面.Size = new System.Drawing.Size(260, 23);
            this.txtBox_识别界面.TabIndex = 7;
            this.txtBox_识别界面.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBox_识别界面.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBox_KeyDown);
            this.txtBox_识别界面.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBox_KeyUp);
            // 
            // txtBox_记录界面
            // 
            this.txtBox_记录界面.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.txtBox_记录界面.Location = new System.Drawing.Point(78, 89);
            this.txtBox_记录界面.Name = "txtBox_记录界面";
            this.txtBox_记录界面.Size = new System.Drawing.Size(260, 23);
            this.txtBox_记录界面.TabIndex = 6;
            this.txtBox_记录界面.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBox_记录界面.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBox_KeyDown);
            this.txtBox_记录界面.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBox_KeyUp);
            // 
            // txtBox_翻译文本
            // 
            this.txtBox_翻译文本.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.txtBox_翻译文本.Location = new System.Drawing.Point(78, 52);
            this.txtBox_翻译文本.Name = "txtBox_翻译文本";
            this.txtBox_翻译文本.Size = new System.Drawing.Size(260, 23);
            this.txtBox_翻译文本.TabIndex = 5;
            this.txtBox_翻译文本.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBox_翻译文本.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBox_KeyDown);
            this.txtBox_翻译文本.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBox_KeyUp);
            // 
            // txtBox_文字识别
            // 
            this.txtBox_文字识别.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.txtBox_文字识别.Location = new System.Drawing.Point(78, 19);
            this.txtBox_文字识别.Name = "txtBox_文字识别";
            this.txtBox_文字识别.Size = new System.Drawing.Size(260, 23);
            this.txtBox_文字识别.TabIndex = 4;
            this.txtBox_文字识别.TabStop = false;
            this.txtBox_文字识别.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBox_文字识别.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBox_KeyDown);
            this.txtBox_文字识别.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBox_KeyUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 3;
            this.label7.Text = "识别界面：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "记录界面：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "翻译文本：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "文字识别：";
            // 
            // page_常规
            // 
            this.page_常规.BackColor = System.Drawing.Color.White;
            this.page_常规.Controls.Add(this.groupBox10);
            this.page_常规.Controls.Add(this.groupBox6);
            this.page_常规.Controls.Add(this.pic_help);
            this.page_常规.Controls.Add(this.常规Button);
            this.page_常规.Controls.Add(this.groupBox2);
            this.page_常规.Controls.Add(this.groupBox1);
            this.page_常规.Location = new System.Drawing.Point(4, 22);
            this.page_常规.Name = "page_常规";
            this.page_常规.Padding = new System.Windows.Forms.Padding(3);
            this.page_常规.Size = new System.Drawing.Size(390, 329);
            this.page_常规.TabIndex = 0;
            this.page_常规.Text = "常规";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.chbox_save);
            this.groupBox10.Controls.Add(this.chbox_copy);
            this.groupBox10.Controls.Add(this.label20);
            this.groupBox10.Controls.Add(this.btn_音效路径);
            this.groupBox10.Controls.Add(this.btn_音效);
            this.groupBox10.Controls.Add(this.text_音效path);
            this.groupBox10.Controls.Add(this.label18);
            this.groupBox10.Location = new System.Drawing.Point(6, 136);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(378, 86);
            this.groupBox10.TabIndex = 8;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "音效";
            // 
            // chbox_save
            // 
            this.chbox_save.AutoSize = true;
            this.chbox_save.Checked = true;
            this.chbox_save.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbox_save.Location = new System.Drawing.Point(167, 54);
            this.chbox_save.Name = "chbox_save";
            this.chbox_save.Size = new System.Drawing.Size(96, 16);
            this.chbox_save.TabIndex = 10;
            this.chbox_save.Text = "快速保存图片";
            this.chbox_save.UseVisualStyleBackColor = true;
            this.chbox_save.CheckedChanged += new System.EventHandler(this.chbox_save_CheckedChanged);
            // 
            // chbox_copy
            // 
            this.chbox_copy.AutoSize = true;
            this.chbox_copy.Location = new System.Drawing.Point(53, 54);
            this.chbox_copy.Name = "chbox_copy";
            this.chbox_copy.Size = new System.Drawing.Size(96, 16);
            this.chbox_copy.TabIndex = 6;
            this.chbox_copy.Text = "复制到粘贴板";
            this.chbox_copy.UseVisualStyleBackColor = true;
            this.chbox_copy.CheckedChanged += new System.EventHandler(this.chbox_copy_CheckedChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(14, 55);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(41, 12);
            this.label20.TabIndex = 9;
            this.label20.Text = "何时：";
            // 
            // btn_音效路径
            // 
            this.btn_音效路径.BackColor = System.Drawing.Color.White;
            this.btn_音效路径.Location = new System.Drawing.Point(332, 49);
            this.btn_音效路径.Name = "btn_音效路径";
            this.btn_音效路径.Size = new System.Drawing.Size(40, 23);
            this.btn_音效路径.TabIndex = 8;
            this.btn_音效路径.Text = "更改";
            this.btn_音效路径.UseVisualStyleBackColor = false;
            this.btn_音效路径.Click += new System.EventHandler(this.btn_音效路径_Click);
            // 
            // btn_音效
            // 
            this.btn_音效.BackColor = System.Drawing.Color.White;
            this.btn_音效.Image = global::TrOCR.Properties.Resources.语音按钮;
            this.btn_音效.Location = new System.Drawing.Point(344, 17);
            this.btn_音效.Name = "btn_音效";
            this.btn_音效.Size = new System.Drawing.Size(26, 23);
            this.btn_音效.TabIndex = 7;
            this.btn_音效.UseVisualStyleBackColor = false;
            this.btn_音效.Click += new System.EventHandler(this.btn_音效_Click);
            // 
            // text_音效path
            // 
            this.text_音效path.BackColor = System.Drawing.Color.White;
            this.text_音效path.Location = new System.Drawing.Point(51, 19);
            this.text_音效path.Name = "text_音效path";
            this.text_音效path.ReadOnly = true;
            this.text_音效path.Size = new System.Drawing.Size(288, 21);
            this.text_音效path.TabIndex = 4;
            this.text_音效path.Text = "Data\\screenshot.wav";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(13, 22);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 12);
            this.label18.TabIndex = 3;
            this.label18.Text = "文件：";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btn_浏览);
            this.groupBox6.Controls.Add(this.textBox_path);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this.cbBox_保存);
            this.groupBox6.Location = new System.Drawing.Point(6, 227);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(378, 63);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            // 
            // btn_浏览
            // 
            this.btn_浏览.BackColor = System.Drawing.Color.White;
            this.btn_浏览.Location = new System.Drawing.Point(332, 24);
            this.btn_浏览.Name = "btn_浏览";
            this.btn_浏览.Size = new System.Drawing.Size(40, 23);
            this.btn_浏览.TabIndex = 7;
            this.btn_浏览.Text = "浏览";
            this.btn_浏览.UseVisualStyleBackColor = false;
            this.btn_浏览.Click += new System.EventHandler(this.btn_浏览_Click);
            // 
            // textBox_path
            // 
            this.textBox_path.BackColor = System.Drawing.Color.White;
            this.textBox_path.Location = new System.Drawing.Point(51, 26);
            this.textBox_path.Name = "textBox_path";
            this.textBox_path.ReadOnly = true;
            this.textBox_path.Size = new System.Drawing.Size(275, 21);
            this.textBox_path.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "目录：";
            // 
            // cbBox_保存
            // 
            this.cbBox_保存.AutoSize = true;
            this.cbBox_保存.BackColor = System.Drawing.Color.White;
            this.cbBox_保存.Location = new System.Drawing.Point(6, 0);
            this.cbBox_保存.Name = "cbBox_保存";
            this.cbBox_保存.Size = new System.Drawing.Size(72, 16);
            this.cbBox_保存.TabIndex = 2;
            this.cbBox_保存.Text = "自动保存";
            this.cbBox_保存.UseVisualStyleBackColor = false;
            this.cbBox_保存.CheckedChanged += new System.EventHandler(this.cbBox_保存_CheckedChanged);
            // 
            // pic_help
            // 
            this.pic_help.Image = global::TrOCR.Properties.Resources.帮助;
            this.pic_help.Location = new System.Drawing.Point(7, 296);
            this.pic_help.Name = "pic_help";
            this.pic_help.Size = new System.Drawing.Size(27, 23);
            this.pic_help.TabIndex = 7;
            this.pic_help.TabStop = false;
            this.pic_help.Click += new System.EventHandler(this.pic_help_Click);
            // 
            // 常规Button
            // 
            this.常规Button.BackColor = System.Drawing.Color.White;
            this.常规Button.Location = new System.Drawing.Point(310, 297);
            this.常规Button.Name = "常规Button";
            this.常规Button.Size = new System.Drawing.Size(75, 23);
            this.常规Button.TabIndex = 6;
            this.常规Button.Text = "恢复默认";
            this.常规Button.UseVisualStyleBackColor = false;
            this.常规Button.Click += new System.EventHandler(this.常规Button_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numbox_记录);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cobBox_动画);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(6, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(378, 70);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "界面";
            // 
            // numbox_记录
            // 
            this.numbox_记录.Location = new System.Drawing.Point(276, 28);
            this.numbox_记录.Name = "numbox_记录";
            this.numbox_记录.Size = new System.Drawing.Size(63, 21);
            this.numbox_记录.TabIndex = 5;
            this.numbox_记录.ValueChanged += new System.EventHandler(this.numbox_记录_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "记录数目：";
            // 
            // cobBox_动画
            // 
            this.cobBox_动画.BackColor = System.Drawing.Color.White;
            this.cobBox_动画.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobBox_动画.FormattingEnabled = true;
            this.cobBox_动画.Items.AddRange(new object[] {
            "窗体",
            "少女",
            "罗小黑"});
            this.cobBox_动画.Location = new System.Drawing.Point(84, 30);
            this.cobBox_动画.Name = "cobBox_动画";
            this.cobBox_动画.Size = new System.Drawing.Size(63, 20);
            this.cobBox_动画.TabIndex = 3;
            this.cobBox_动画.SelectedIndexChanged += new System.EventHandler(this.cobBox_动画_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "窗体动画：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chbox_取色);
            this.groupBox1.Controls.Add(this.cbBox_弹窗);
            this.groupBox1.Controls.Add(this.cbBox_翻译);
            this.groupBox1.Controls.Add(this.cbBox_开机);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 48);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "设置";
            // 
            // chbox_取色
            // 
            this.chbox_取色.AutoSize = true;
            this.chbox_取色.Location = new System.Drawing.Point(298, 20);
            this.chbox_取色.Name = "chbox_取色";
            this.chbox_取色.Size = new System.Drawing.Size(66, 16);
            this.chbox_取色.TabIndex = 6;
            this.chbox_取色.Text = "取色HEX";
            this.chbox_取色.UseVisualStyleBackColor = true;
            this.chbox_取色.CheckedChanged += new System.EventHandler(this.chbox_取色_CheckedChanged);
            // 
            // cbBox_弹窗
            // 
            this.cbBox_弹窗.AutoSize = true;
            this.cbBox_弹窗.Location = new System.Drawing.Point(204, 20);
            this.cbBox_弹窗.Name = "cbBox_弹窗";
            this.cbBox_弹窗.Size = new System.Drawing.Size(72, 16);
            this.cbBox_弹窗.TabIndex = 5;
            this.cbBox_弹窗.Text = "识别弹窗";
            this.cbBox_弹窗.UseVisualStyleBackColor = true;
            this.cbBox_弹窗.CheckedChanged += new System.EventHandler(this.cbBox_弹窗_CheckedChanged);
            // 
            // cbBox_翻译
            // 
            this.cbBox_翻译.AutoSize = true;
            this.cbBox_翻译.Location = new System.Drawing.Point(107, 20);
            this.cbBox_翻译.Name = "cbBox_翻译";
            this.cbBox_翻译.Size = new System.Drawing.Size(72, 16);
            this.cbBox_翻译.TabIndex = 4;
            this.cbBox_翻译.Text = "快速翻译";
            this.cbBox_翻译.UseVisualStyleBackColor = true;
            this.cbBox_翻译.CheckedChanged += new System.EventHandler(this.cbBox_翻译_CheckedChanged);
            // 
            // cbBox_开机
            // 
            this.cbBox_开机.AutoSize = true;
            this.cbBox_开机.Location = new System.Drawing.Point(17, 20);
            this.cbBox_开机.Name = "cbBox_开机";
            this.cbBox_开机.Size = new System.Drawing.Size(72, 16);
            this.cbBox_开机.TabIndex = 2;
            this.cbBox_开机.Text = "开机启动";
            this.cbBox_开机.UseVisualStyleBackColor = true;
            this.cbBox_开机.CheckedChanged += new System.EventHandler(this.cbBox_开机_CheckedChanged);
            // 
            // tab_标签
            // 
            this.tab_标签.Controls.Add(this.page_常规);
            this.tab_标签.Controls.Add(this.Page_快捷键);
            this.tab_标签.Controls.Add(this.Page_密钥);
            this.tab_标签.Controls.Add(this.Page_代理);
            this.tab_标签.Controls.Add(this.Page_更新);
            this.tab_标签.Controls.Add(this.Page_反馈);
            this.tab_标签.Controls.Add(this.Page_OCR设置);
            this.tab_标签.Controls.Add(this.Page_OCR设置2);
            this.tab_标签.Location = new System.Drawing.Point(10, 2);
            this.tab_标签.Name = "tab_标签";
            this.tab_标签.SelectedIndex = 0;
            this.tab_标签.Size = new System.Drawing.Size(398, 355);
            this.tab_标签.TabIndex = 0;
            this.tab_标签.SelectedIndexChanged += new System.EventHandler(this.tab_标签_SelectedIndexChanged);
            // 
            // Page_更新
            // 
            this.Page_更新.BackColor = System.Drawing.Color.White;
            this.Page_更新.Controls.Add(this.更新Button_check);
            this.Page_更新.Controls.Add(this.更新Button);
            this.Page_更新.Controls.Add(this.groupBox5);
            this.Page_更新.Location = new System.Drawing.Point(4, 22);
            this.Page_更新.Name = "Page_更新";
            this.Page_更新.Padding = new System.Windows.Forms.Padding(3);
            this.Page_更新.Size = new System.Drawing.Size(390, 329);
            this.Page_更新.TabIndex = 5;
            this.Page_更新.Text = "更新";
            this.Page_更新.UseVisualStyleBackColor = true;
            // 
            // 更新Button_check
            // 
            this.更新Button_check.BackColor = System.Drawing.Color.White;
            this.更新Button_check.Location = new System.Drawing.Point(6, 83);
            this.更新Button_check.Name = "更新Button_check";
            this.更新Button_check.Size = new System.Drawing.Size(75, 23);
            this.更新Button_check.TabIndex = 11;
            this.更新Button_check.Text = "检查更新";
            this.更新Button_check.UseVisualStyleBackColor = false;
            // 
            // 更新Button
            // 
            this.更新Button.BackColor = System.Drawing.Color.White;
            this.更新Button.Location = new System.Drawing.Point(309, 83);
            this.更新Button.Name = "更新Button";
            this.更新Button.Size = new System.Drawing.Size(75, 23);
            this.更新Button.TabIndex = 10;
            this.更新Button.Text = "恢复默认";
            this.更新Button.UseVisualStyleBackColor = false;
            this.更新Button.Click += new System.EventHandler(this.更新Button_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.numbox_间隔时间);
            this.groupBox5.Controls.Add(this.checkBox_更新间隔);
            this.groupBox5.Controls.Add(this.check_检查更新);
            this.groupBox5.Location = new System.Drawing.Point(6, 14);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(378, 65);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(98, 31);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 12);
            this.label16.TabIndex = 3;
            this.label16.Text = "小时";
            // 
            // numbox_间隔时间
            // 
            this.numbox_间隔时间.Location = new System.Drawing.Point(54, 27);
            this.numbox_间隔时间.Name = "numbox_间隔时间";
            this.numbox_间隔时间.Size = new System.Drawing.Size(37, 21);
            this.numbox_间隔时间.TabIndex = 2;
            this.numbox_间隔时间.ValueChanged += new System.EventHandler(this.numbox_间隔时间_ValueChanged);
            // 
            // checkBox_更新间隔
            // 
            this.checkBox_更新间隔.AutoSize = true;
            this.checkBox_更新间隔.Location = new System.Drawing.Point(6, 31);
            this.checkBox_更新间隔.Name = "checkBox_更新间隔";
            this.checkBox_更新间隔.Size = new System.Drawing.Size(48, 16);
            this.checkBox_更新间隔.TabIndex = 1;
            this.checkBox_更新间隔.Text = "每隔";
            this.checkBox_更新间隔.UseVisualStyleBackColor = true;
            this.checkBox_更新间隔.CheckedChanged += new System.EventHandler(this.checkBox_更新间隔_CheckedChanged);
            // 
            // check_检查更新
            // 
            this.check_检查更新.AutoSize = true;
            this.check_检查更新.BackColor = System.Drawing.Color.White;
            this.check_检查更新.Location = new System.Drawing.Point(6, 0);
            this.check_检查更新.Name = "check_检查更新";
            this.check_检查更新.Size = new System.Drawing.Size(108, 16);
            this.check_检查更新.TabIndex = 0;
            this.check_检查更新.Text = "启动时检查更新";
            this.check_检查更新.UseVisualStyleBackColor = false;
            this.check_检查更新.CheckedChanged += new System.EventHandler(this.check_检查更新_CheckedChanged);
            // 
            // Page_反馈
            // 
            this.Page_反馈.BackColor = System.Drawing.Color.White;
            this.Page_反馈.Controls.Add(this.label21);
            this.Page_反馈.Controls.Add(this.反馈Button);
            this.Page_反馈.Controls.Add(this.txt_问题反馈);
            this.Page_反馈.Location = new System.Drawing.Point(4, 22);
            this.Page_反馈.Name = "Page_反馈";
            this.Page_反馈.Padding = new System.Windows.Forms.Padding(3);
            this.Page_反馈.Size = new System.Drawing.Size(390, 329);
            this.Page_反馈.TabIndex = 8;
            this.Page_反馈.Text = "反馈";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(7, 151);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(0, 12);
            this.label21.TabIndex = 12;
            // 
            // 反馈Button
            // 
            this.反馈Button.BackColor = System.Drawing.Color.White;
            this.反馈Button.Location = new System.Drawing.Point(309, 146);
            this.反馈Button.Name = "反馈Button";
            this.反馈Button.Size = new System.Drawing.Size(75, 23);
            this.反馈Button.TabIndex = 11;
            this.反馈Button.Text = "提交";
            this.反馈Button.UseVisualStyleBackColor = false;
            this.反馈Button.Click += new System.EventHandler(this.反馈Button_Click);
            // 
            // txt_问题反馈
            // 
            this.txt_问题反馈.BackColor = System.Drawing.Color.White;
            this.txt_问题反馈.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_问题反馈.ImeMode = System.Windows.Forms.ImeMode.HangulFull;
            this.txt_问题反馈.Location = new System.Drawing.Point(6, 6);
            this.txt_问题反馈.Multiline = true;
            this.txt_问题反馈.Name = "txt_问题反馈";
            this.txt_问题反馈.Size = new System.Drawing.Size(378, 134);
            this.txt_问题反馈.TabIndex = 5;
            // 
            // Page_OCR设置
            // 
            this.Page_OCR设置.Controls.Add(this.label27);
            this.Page_OCR设置.Controls.Add(this.button1);
            this.Page_OCR设置.Controls.Add(this.tableLayoutPanel1);
            this.Page_OCR设置.Location = new System.Drawing.Point(4, 22);
            this.Page_OCR设置.Name = "Page_OCR设置";
            this.Page_OCR设置.Padding = new System.Windows.Forms.Padding(3);
            this.Page_OCR设置.Size = new System.Drawing.Size(390, 329);
            this.Page_OCR设置.TabIndex = 9;
            this.Page_OCR设置.Text = "CL-OCR设置";
            this.Page_OCR设置.UseVisualStyleBackColor = true;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(247, 248);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(125, 12);
            this.label27.TabIndex = 12;
            this.label27.Text = "线程更改需要重启程序";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(285, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "重启";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tableLayoutPanel1.Controls.Add(this.label26, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.ocrNum6, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.ocrNum3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label17, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ocrNum2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label22, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ocrNum1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label23, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label24, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.ocrNum4, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label25, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.ocrNum5, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.doAngleCheckBox, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.mostAngleCheckBox, 1, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(22, 22);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(169, 281);
            this.tableLayoutPanel1.TabIndex = 3;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(5, 226);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(59, 12);
            this.label26.TabIndex = 28;
            this.label26.Text = "numThread";
            // 
            // ocrNum6
            // 
            this.ocrNum6.Location = new System.Drawing.Point(87, 229);
            this.ocrNum6.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.ocrNum6.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ocrNum6.Name = "ocrNum6";
            this.ocrNum6.Size = new System.Drawing.Size(74, 21);
            this.ocrNum6.TabIndex = 29;
            this.ocrNum6.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // ocrNum3
            // 
            this.ocrNum3.DecimalPlaces = 3;
            this.ocrNum3.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ocrNum3.Location = new System.Drawing.Point(87, 69);
            this.ocrNum3.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ocrNum3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.ocrNum3.Name = "ocrNum3";
            this.ocrNum3.Size = new System.Drawing.Size(74, 21);
            this.ocrNum3.TabIndex = 13;
            this.ocrNum3.Value = new decimal(new int[] {
            618,
            0,
            0,
            196608});
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(5, 66);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(71, 24);
            this.label17.TabIndex = 12;
            this.label17.Text = "boxScoreThresh";
            // 
            // ocrNum2
            // 
            this.ocrNum2.Location = new System.Drawing.Point(87, 37);
            this.ocrNum2.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.ocrNum2.Name = "ocrNum2";
            this.ocrNum2.Size = new System.Drawing.Size(74, 21);
            this.ocrNum2.TabIndex = 10;
            this.ocrNum2.Value = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(5, 34);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(65, 12);
            this.label22.TabIndex = 9;
            this.label22.Text = "maxSideLen";
            // 
            // ocrNum1
            // 
            this.ocrNum1.Location = new System.Drawing.Point(87, 5);
            this.ocrNum1.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.ocrNum1.Name = "ocrNum1";
            this.ocrNum1.Size = new System.Drawing.Size(74, 21);
            this.ocrNum1.TabIndex = 7;
            this.ocrNum1.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(5, 2);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(47, 12);
            this.label23.TabIndex = 6;
            this.label23.Text = "padding";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(5, 98);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(59, 12);
            this.label24.TabIndex = 14;
            this.label24.Text = "boxThresh";
            // 
            // ocrNum4
            // 
            this.ocrNum4.DecimalPlaces = 3;
            this.ocrNum4.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ocrNum4.Location = new System.Drawing.Point(87, 101);
            this.ocrNum4.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ocrNum4.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.ocrNum4.Name = "ocrNum4";
            this.ocrNum4.Size = new System.Drawing.Size(74, 21);
            this.ocrNum4.TabIndex = 15;
            this.ocrNum4.Value = new decimal(new int[] {
            3,
            0,
            0,
            65536});
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(5, 130);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(71, 12);
            this.label25.TabIndex = 21;
            this.label25.Text = "unClipRatio";
            // 
            // ocrNum5
            // 
            this.ocrNum5.DecimalPlaces = 1;
            this.ocrNum5.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ocrNum5.Location = new System.Drawing.Point(87, 133);
            this.ocrNum5.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ocrNum5.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ocrNum5.Name = "ocrNum5";
            this.ocrNum5.Size = new System.Drawing.Size(74, 21);
            this.ocrNum5.TabIndex = 22;
            this.ocrNum5.Value = new decimal(new int[] {
            20,
            0,
            0,
            65536});
            // 
            // doAngleCheckBox
            // 
            this.doAngleCheckBox.AutoSize = true;
            this.doAngleCheckBox.Checked = true;
            this.doAngleCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.doAngleCheckBox.Location = new System.Drawing.Point(5, 165);
            this.doAngleCheckBox.Name = "doAngleCheckBox";
            this.doAngleCheckBox.Size = new System.Drawing.Size(66, 16);
            this.doAngleCheckBox.TabIndex = 26;
            this.doAngleCheckBox.Text = "doAngle";
            this.doAngleCheckBox.UseVisualStyleBackColor = true;
            // 
            // mostAngleCheckBox
            // 
            this.mostAngleCheckBox.AutoSize = true;
            this.mostAngleCheckBox.Checked = true;
            this.mostAngleCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mostAngleCheckBox.Location = new System.Drawing.Point(87, 165);
            this.mostAngleCheckBox.Name = "mostAngleCheckBox";
            this.mostAngleCheckBox.Size = new System.Drawing.Size(78, 16);
            this.mostAngleCheckBox.TabIndex = 27;
            this.mostAngleCheckBox.Text = "mostAngle";
            this.mostAngleCheckBox.UseVisualStyleBackColor = true;
            // 
            // Page_OCR设置2
            // 
            this.Page_OCR设置2.Controls.Add(this.label28);
            this.Page_OCR设置2.Controls.Add(this.button3);
            this.Page_OCR设置2.Controls.Add(this.tableLayoutPanel2);
            this.Page_OCR设置2.Location = new System.Drawing.Point(4, 22);
            this.Page_OCR设置2.Name = "Page_OCR设置2";
            this.Page_OCR设置2.Padding = new System.Windows.Forms.Padding(3);
            this.Page_OCR设置2.Size = new System.Drawing.Size(390, 329);
            this.Page_OCR设置2.TabIndex = 10;
            this.Page_OCR设置2.Text = "PA-OCR设置";
            this.Page_OCR设置2.UseVisualStyleBackColor = true;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(245, 250);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(125, 12);
            this.label28.TabIndex = 15;
            this.label28.Text = "线程更改需要重启程序";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(283, 282);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "重启";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tableLayoutPanel2.Controls.Add(this.label29, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.ocrNum12, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.ocrNum9, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label30, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.ocrNum8, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label31, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.ocrNum7, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label32, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label33, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.ocrNum10, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label34, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.ocrNum11, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.doAngleCheckBox2, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.mostAngleCheckBox2, 1, 5);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(20, 24);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(169, 281);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(5, 226);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(59, 12);
            this.label29.TabIndex = 28;
            this.label29.Text = "numThread";
            // 
            // ocrNum12
            // 
            this.ocrNum12.Location = new System.Drawing.Point(87, 229);
            this.ocrNum12.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.ocrNum12.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ocrNum12.Name = "ocrNum12";
            this.ocrNum12.Size = new System.Drawing.Size(74, 21);
            this.ocrNum12.TabIndex = 29;
            this.ocrNum12.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // ocrNum9
            // 
            this.ocrNum9.DecimalPlaces = 3;
            this.ocrNum9.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ocrNum9.Location = new System.Drawing.Point(87, 69);
            this.ocrNum9.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ocrNum9.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.ocrNum9.Name = "ocrNum9";
            this.ocrNum9.Size = new System.Drawing.Size(74, 21);
            this.ocrNum9.TabIndex = 13;
            this.ocrNum9.Value = new decimal(new int[] {
            7,
            0,
            0,
            65536});
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(5, 66);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(71, 24);
            this.label30.TabIndex = 12;
            this.label30.Text = "boxScoreThresh";
            // 
            // ocrNum8
            // 
            this.ocrNum8.Location = new System.Drawing.Point(87, 37);
            this.ocrNum8.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.ocrNum8.Name = "ocrNum8";
            this.ocrNum8.Size = new System.Drawing.Size(74, 21);
            this.ocrNum8.TabIndex = 10;
            this.ocrNum8.Value = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(5, 34);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(65, 12);
            this.label31.TabIndex = 9;
            this.label31.Text = "maxSideLen";
            // 
            // ocrNum7
            // 
            this.ocrNum7.Location = new System.Drawing.Point(87, 5);
            this.ocrNum7.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.ocrNum7.Name = "ocrNum7";
            this.ocrNum7.Size = new System.Drawing.Size(74, 21);
            this.ocrNum7.TabIndex = 7;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(5, 2);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(47, 12);
            this.label32.TabIndex = 6;
            this.label32.Text = "padding";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(5, 98);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(59, 12);
            this.label33.TabIndex = 14;
            this.label33.Text = "boxThresh";
            // 
            // ocrNum10
            // 
            this.ocrNum10.DecimalPlaces = 3;
            this.ocrNum10.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ocrNum10.Location = new System.Drawing.Point(87, 101);
            this.ocrNum10.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ocrNum10.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.ocrNum10.Name = "ocrNum10";
            this.ocrNum10.Size = new System.Drawing.Size(74, 21);
            this.ocrNum10.TabIndex = 15;
            this.ocrNum10.Value = new decimal(new int[] {
            3,
            0,
            0,
            65536});
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(5, 130);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(71, 12);
            this.label34.TabIndex = 21;
            this.label34.Text = "unClipRatio";
            // 
            // ocrNum11
            // 
            this.ocrNum11.DecimalPlaces = 1;
            this.ocrNum11.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ocrNum11.Location = new System.Drawing.Point(87, 133);
            this.ocrNum11.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ocrNum11.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ocrNum11.Name = "ocrNum11";
            this.ocrNum11.Size = new System.Drawing.Size(74, 21);
            this.ocrNum11.TabIndex = 22;
            this.ocrNum11.Value = new decimal(new int[] {
            15,
            0,
            0,
            65536});
            // 
            // doAngleCheckBox2
            // 
            this.doAngleCheckBox2.AutoSize = true;
            this.doAngleCheckBox2.Checked = true;
            this.doAngleCheckBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.doAngleCheckBox2.Location = new System.Drawing.Point(5, 165);
            this.doAngleCheckBox2.Name = "doAngleCheckBox2";
            this.doAngleCheckBox2.Size = new System.Drawing.Size(66, 16);
            this.doAngleCheckBox2.TabIndex = 26;
            this.doAngleCheckBox2.Text = "doAngle";
            this.doAngleCheckBox2.UseVisualStyleBackColor = true;
            // 
            // mostAngleCheckBox2
            // 
            this.mostAngleCheckBox2.AutoSize = true;
            this.mostAngleCheckBox2.Location = new System.Drawing.Point(87, 165);
            this.mostAngleCheckBox2.Name = "mostAngleCheckBox2";
            this.mostAngleCheckBox2.Size = new System.Drawing.Size(78, 16);
            this.mostAngleCheckBox2.TabIndex = 27;
            this.mostAngleCheckBox2.Text = "mostAngle";
            this.mostAngleCheckBox2.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Location = new System.Drawing.Point(117, 14);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(255, 83);
            this.groupBox8.TabIndex = 4;
            this.groupBox8.TabStop = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label19.Location = new System.Drawing.Point(13, 56);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(141, 17);
            this.label19.TabIndex = 5;
            // 
            // label_版本号
            // 
            this.label_版本号.AutoSize = true;
            this.label_版本号.Location = new System.Drawing.Point(13, 13);
            this.label_版本号.Name = "label_版本号";
            this.label_版本号.Size = new System.Drawing.Size(95, 12);
            this.label_版本号.TabIndex = 4;
            // 
            // label_更新日期
            // 
            this.label_更新日期.AutoSize = true;
            this.label_更新日期.Location = new System.Drawing.Point(13, 34);
            this.label_更新日期.Name = "label_更新日期";
            this.label_更新日期.Size = new System.Drawing.Size(125, 12);
            this.label_更新日期.TabIndex = 6;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.White;
            this.pictureBox6.Image = global::TrOCR.Properties.Resources.头像;
            this.pictureBox6.Location = new System.Drawing.Point(12, 15);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(84, 82);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            // 
            // txt_更新说明
            // 
            this.txt_更新说明.BackColor = System.Drawing.Color.White;
            this.txt_更新说明.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_更新说明.Location = new System.Drawing.Point(6, 20);
            this.txt_更新说明.Multiline = true;
            this.txt_更新说明.Name = "txt_更新说明";
            this.txt_更新说明.Size = new System.Drawing.Size(366, 155);
            this.txt_更新说明.TabIndex = 4;
            // 
            // FmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(417, 396);
            this.Controls.Add(this.tab_标签);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FmSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设置";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Page_代理.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.Page_密钥.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.inPage_百度接口.ResumeLayout(false);
            this.inPage_百度接口.PerformLayout();
            this.Page_快捷键.ResumeLayout(false);
            this.Page_快捷键.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_识别界面)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_记录界面)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_翻译文本)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_文字识别)).EndInit();
            this.page_常规.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_help)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numbox_记录)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tab_标签.ResumeLayout(false);
            this.Page_更新.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numbox_间隔时间)).EndInit();
            this.Page_反馈.ResumeLayout(false);
            this.Page_反馈.PerformLayout();
            this.Page_OCR设置.ResumeLayout(false);
            this.Page_OCR设置.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ocrNum6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocrNum3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocrNum2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocrNum1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocrNum4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocrNum5)).EndInit();
            this.Page_OCR设置2.ResumeLayout(false);
            this.Page_OCR设置2.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ocrNum12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocrNum9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocrNum8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocrNum7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocrNum10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocrNum11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);

		}

		private global::System.ComponentModel.IContainer components;

		private global::System.Windows.Forms.TabPage Page_代理;

		private global::System.Windows.Forms.TabPage Page_密钥;

		private global::System.Windows.Forms.TabPage Page_快捷键;

		private global::System.Windows.Forms.TabPage page_常规;

		private global::System.Windows.Forms.PictureBox pic_help;

		private global::System.Windows.Forms.Button 常规Button;

		private global::System.Windows.Forms.GroupBox groupBox2;

		private global::System.Windows.Forms.NumericUpDown numbox_记录;

		private global::System.Windows.Forms.Label label3;

		private global::System.Windows.Forms.ComboBox cobBox_动画;

		private global::System.Windows.Forms.Label label2;

		private global::System.Windows.Forms.GroupBox groupBox1;

		private global::System.Windows.Forms.CheckBox cbBox_开机;

		private global::System.Windows.Forms.TabControl tab_标签;

		private global::System.Windows.Forms.TabPage Page_更新;

		private global::System.Windows.Forms.GroupBox groupBox3;

		private global::System.Windows.Forms.PictureBox pictureBox_翻译文本;

		private global::System.Windows.Forms.PictureBox pictureBox_文字识别;

		private global::System.Windows.Forms.TextBox txtBox_识别界面;

		private global::System.Windows.Forms.TextBox txtBox_记录界面;

		private global::System.Windows.Forms.TextBox txtBox_翻译文本;

		private global::System.Windows.Forms.TextBox txtBox_文字识别;

		private global::System.Windows.Forms.Label label7;

		private global::System.Windows.Forms.Label label6;

		private global::System.Windows.Forms.Label label5;

		private global::System.Windows.Forms.Label label4;

		private global::System.Windows.Forms.PictureBox pictureBox_识别界面;

		private global::System.Windows.Forms.PictureBox pictureBox_记录界面;

		private global::System.Windows.Forms.Label label8;

		private global::System.Windows.Forms.CheckBox cbBox_翻译;

		private global::System.Windows.Forms.TabControl tabControl2;

		private global::System.Windows.Forms.TabPage inPage_百度接口;

		private global::System.Windows.Forms.TextBox text_baidupassword;

		private global::System.Windows.Forms.TextBox text_baiduaccount;

		private global::System.Windows.Forms.Label label10;

		private global::System.Windows.Forms.Label label9;

		private global::System.Windows.Forms.Button 快捷键Button;

		private global::System.Windows.Forms.Button 密钥Button_apply;

		private global::System.Windows.Forms.Button 密钥Button;

		private global::System.Windows.Forms.GroupBox groupBox4;

		private global::System.Windows.Forms.ComboBox combox_代理;

		private global::System.Windows.Forms.Label label11;

		private global::System.Windows.Forms.Button 代理Button;

		private global::System.Windows.Forms.CheckBox chbox_代理服务器;

		private global::System.Windows.Forms.TextBox text_密码;

		private global::System.Windows.Forms.TextBox text_端口;

		private global::System.Windows.Forms.Label label15;

		private global::System.Windows.Forms.TextBox text_账号;

		private global::System.Windows.Forms.TextBox text_服务器;

		private global::System.Windows.Forms.Label label14;

		private global::System.Windows.Forms.Label label13;

		private global::System.Windows.Forms.Label label12;

		private global::System.Windows.Forms.Button 更新Button_check;

		private global::System.Windows.Forms.Button 更新Button;

		private global::System.Windows.Forms.GroupBox groupBox5;

		private global::System.Windows.Forms.Label label16;

		private global::System.Windows.Forms.NumericUpDown numbox_间隔时间;

		private global::System.Windows.Forms.CheckBox checkBox_更新间隔;

		private global::System.Windows.Forms.CheckBox check_检查更新;

		private global::System.Windows.Forms.CheckBox cbBox_弹窗;

		private global::System.Windows.Forms.GroupBox groupBox6;

		private global::System.Windows.Forms.TextBox textBox_path;

		private global::System.Windows.Forms.Label label1;

		private global::System.Windows.Forms.CheckBox cbBox_保存;

		private global::System.Windows.Forms.Button btn_浏览;

		private global::System.Windows.Forms.Button 百度_btn;

		private global::System.Windows.Forms.GroupBox groupBox10;

		private global::System.Windows.Forms.Button btn_音效;

		private global::System.Windows.Forms.TextBox text_音效path;

		private global::System.Windows.Forms.Label label18;

		private global::System.Windows.Forms.CheckBox chbox_save;

		private global::System.Windows.Forms.CheckBox chbox_copy;

		private global::System.Windows.Forms.Label label20;

		private global::System.Windows.Forms.Button btn_音效路径;

		private global::System.Windows.Forms.CheckBox chbox_取色;
        private System.Windows.Forms.TabPage Page_反馈;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button 反馈Button;
        private System.Windows.Forms.TextBox txt_问题反馈;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label_版本号;
        private System.Windows.Forms.Label label_更新日期;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.TextBox txt_更新说明;
        private System.Windows.Forms.TabPage Page_OCR设置;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.NumericUpDown ocrNum3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown ocrNum2;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.NumericUpDown ocrNum1;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.NumericUpDown ocrNum4;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.NumericUpDown ocrNum5;
        private System.Windows.Forms.CheckBox doAngleCheckBox;
        private System.Windows.Forms.CheckBox mostAngleCheckBox;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.NumericUpDown ocrNum6;
        private System.Windows.Forms.TabPage Page_OCR设置2;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.NumericUpDown ocrNum12;
        private System.Windows.Forms.NumericUpDown ocrNum9;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.NumericUpDown ocrNum8;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.NumericUpDown ocrNum7;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.NumericUpDown ocrNum10;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.NumericUpDown ocrNum11;
        private System.Windows.Forms.CheckBox doAngleCheckBox2;
        private System.Windows.Forms.CheckBox mostAngleCheckBox2;
    }
}
