
namespace Config
{
    partial class form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.processList = new System.Windows.Forms.ListBox();
            this.version = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.row = new System.Windows.Forms.TextBox();
            this.column = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.fontSize = new System.Windows.Forms.TextBox();
            this.angle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.alpha = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.outlineWeight = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.showCpuName = new System.Windows.Forms.CheckBox();
            this.showMacAddr = new System.Windows.Forms.CheckBox();
            this.showIpAddr = new System.Windows.Forms.CheckBox();
            this.showLoginUser = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.showQrCode = new System.Windows.Forms.CheckBox();
            this.qrCodePos = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.qrCodeAlpha = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.qrCodeSize = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.deltaTime = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "版本";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "受保护的程序";
            // 
            // processList
            // 
            this.processList.FormattingEnabled = true;
            this.processList.ItemHeight = 24;
            this.processList.Location = new System.Drawing.Point(197, 121);
            this.processList.Margin = new System.Windows.Forms.Padding(4);
            this.processList.Name = "processList";
            this.processList.Size = new System.Drawing.Size(492, 220);
            this.processList.TabIndex = 2;
            // 
            // version
            // 
            this.version.Location = new System.Drawing.Point(197, 71);
            this.version.Margin = new System.Windows.Forms.Padding(4);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(492, 35);
            this.version.TabIndex = 3;
            this.version.TextChanged += new System.EventHandler(this.version_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 411);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "密度";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(193, 411);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "行";
            // 
            // row
            // 
            this.row.Location = new System.Drawing.Point(245, 405);
            this.row.Margin = new System.Windows.Forms.Padding(4);
            this.row.Name = "row";
            this.row.Size = new System.Drawing.Size(176, 35);
            this.row.TabIndex = 6;
            this.row.TextChanged += new System.EventHandler(this.row_TextChanged);
            // 
            // column
            // 
            this.column.Location = new System.Drawing.Point(513, 405);
            this.column.Margin = new System.Windows.Forms.Padding(4);
            this.column.Name = "column";
            this.column.Size = new System.Drawing.Size(176, 35);
            this.column.TabIndex = 8;
            this.column.TextChanged += new System.EventHandler(this.column_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(471, 411);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "列";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 463);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "字体大小";
            // 
            // fontSize
            // 
            this.fontSize.Location = new System.Drawing.Point(197, 459);
            this.fontSize.Margin = new System.Windows.Forms.Padding(4);
            this.fontSize.Name = "fontSize";
            this.fontSize.Size = new System.Drawing.Size(492, 35);
            this.fontSize.TabIndex = 10;
            this.fontSize.TextChanged += new System.EventHandler(this.fontSize_TextChanged);
            // 
            // angle
            // 
            this.angle.Location = new System.Drawing.Point(197, 609);
            this.angle.Margin = new System.Windows.Forms.Padding(4);
            this.angle.Name = "angle";
            this.angle.Size = new System.Drawing.Size(492, 35);
            this.angle.TabIndex = 12;
            this.angle.TextChanged += new System.EventHandler(this.angle_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 613);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 24);
            this.label7.TabIndex = 11;
            this.label7.Text = "旋转角度";
            // 
            // alpha
            // 
            this.alpha.Location = new System.Drawing.Point(197, 509);
            this.alpha.Margin = new System.Windows.Forms.Padding(4);
            this.alpha.Name = "alpha";
            this.alpha.Size = new System.Drawing.Size(492, 35);
            this.alpha.TabIndex = 15;
            this.alpha.TextChanged += new System.EventHandler(this.alpha_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 513);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 24);
            this.label8.TabIndex = 14;
            this.label8.Text = "字体透明度";
            // 
            // outlineWeight
            // 
            this.outlineWeight.Location = new System.Drawing.Point(197, 559);
            this.outlineWeight.Margin = new System.Windows.Forms.Padding(4);
            this.outlineWeight.Name = "outlineWeight";
            this.outlineWeight.Size = new System.Drawing.Size(492, 35);
            this.outlineWeight.TabIndex = 17;
            this.outlineWeight.TextChanged += new System.EventHandler(this.outlineWeight_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 563);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 24);
            this.label9.TabIndex = 16;
            this.label9.Text = "字体外轮廓";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.YellowGreen;
            this.button1.Location = new System.Drawing.Point(541, 349);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 46);
            this.button1.TabIndex = 18;
            this.button1.Text = "添加";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Tomato;
            this.button2.Location = new System.Drawing.Point(379, 349);
            this.button2.Margin = new System.Windows.Forms.Padding(6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 46);
            this.button2.TabIndex = 19;
            this.button2.Text = "删除";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.YellowGreen;
            this.button3.ForeColor = System.Drawing.SystemColors.Window;
            this.button3.Location = new System.Drawing.Point(25, 966);
            this.button3.Margin = new System.Windows.Forms.Padding(6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(668, 46);
            this.button3.TabIndex = 20;
            this.button3.Text = "保存并应用";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(649, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(40, 40);
            this.button4.TabIndex = 21;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Crimson;
            this.button5.ForeColor = System.Drawing.SystemColors.Window;
            this.button5.Location = new System.Drawing.Point(25, 1024);
            this.button5.Margin = new System.Windows.Forms.Padding(6);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(668, 46);
            this.button5.TabIndex = 22;
            this.button5.Text = "修改管理员密码";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 666);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 24);
            this.label10.TabIndex = 23;
            this.label10.Text = "显示文字";
            // 
            // showCpuName
            // 
            this.showCpuName.AutoSize = true;
            this.showCpuName.Location = new System.Drawing.Point(197, 666);
            this.showCpuName.Name = "showCpuName";
            this.showCpuName.Size = new System.Drawing.Size(138, 28);
            this.showCpuName.TabIndex = 24;
            this.showCpuName.Text = "计算机名";
            this.showCpuName.UseVisualStyleBackColor = true;
            // 
            // showMacAddr
            // 
            this.showMacAddr.AutoSize = true;
            this.showMacAddr.Location = new System.Drawing.Point(329, 666);
            this.showMacAddr.Name = "showMacAddr";
            this.showMacAddr.Size = new System.Drawing.Size(126, 28);
            this.showMacAddr.TabIndex = 25;
            this.showMacAddr.Text = "MAC地址";
            this.showMacAddr.UseVisualStyleBackColor = true;
            // 
            // showIpAddr
            // 
            this.showIpAddr.AutoSize = true;
            this.showIpAddr.Location = new System.Drawing.Point(447, 666);
            this.showIpAddr.Name = "showIpAddr";
            this.showIpAddr.Size = new System.Drawing.Size(114, 28);
            this.showIpAddr.TabIndex = 26;
            this.showIpAddr.Text = "IP地址";
            this.showIpAddr.UseVisualStyleBackColor = true;
            // 
            // showLoginUser
            // 
            this.showLoginUser.AutoSize = true;
            this.showLoginUser.Location = new System.Drawing.Point(556, 666);
            this.showLoginUser.Name = "showLoginUser";
            this.showLoginUser.Size = new System.Drawing.Size(162, 28);
            this.showLoginUser.TabIndex = 27;
            this.showLoginUser.Text = "登录用户名";
            this.showLoginUser.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 713);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 24);
            this.label11.TabIndex = 28;
            this.label11.Text = "二维码";
            // 
            // showQrCode
            // 
            this.showQrCode.AutoSize = true;
            this.showQrCode.Location = new System.Drawing.Point(197, 712);
            this.showQrCode.Name = "showQrCode";
            this.showQrCode.Size = new System.Drawing.Size(90, 28);
            this.showQrCode.TabIndex = 29;
            this.showQrCode.Text = "开启";
            this.showQrCode.UseVisualStyleBackColor = true;
            // 
            // qrCodePos
            // 
            this.qrCodePos.FormattingEnabled = true;
            this.qrCodePos.Items.AddRange(new object[] {
            "随机",
            "左上",
            "左下",
            "右上",
            "右下"});
            this.qrCodePos.Location = new System.Drawing.Point(306, 761);
            this.qrCodePos.Name = "qrCodePos";
            this.qrCodePos.Size = new System.Drawing.Size(115, 32);
            this.qrCodePos.TabIndex = 30;
            this.qrCodePos.Text = "随机";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(193, 764);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 24);
            this.label12.TabIndex = 31;
            this.label12.Text = "显示位置";
            // 
            // qrCodeAlpha
            // 
            this.qrCodeAlpha.Location = new System.Drawing.Point(283, 819);
            this.qrCodeAlpha.Margin = new System.Windows.Forms.Padding(4);
            this.qrCodeAlpha.Name = "qrCodeAlpha";
            this.qrCodeAlpha.Size = new System.Drawing.Size(148, 35);
            this.qrCodeAlpha.TabIndex = 33;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(193, 822);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 24);
            this.label13.TabIndex = 32;
            this.label13.Text = "透明度";
            // 
            // qrCodeSize
            // 
            this.qrCodeSize.Location = new System.Drawing.Point(524, 819);
            this.qrCodeSize.Margin = new System.Windows.Forms.Padding(4);
            this.qrCodeSize.Name = "qrCodeSize";
            this.qrCodeSize.Size = new System.Drawing.Size(167, 35);
            this.qrCodeSize.TabIndex = 35;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(447, 822);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 24);
            this.label14.TabIndex = 34;
            this.label14.Text = "尺寸";
            // 
            // deltaTime
            // 
            this.deltaTime.Location = new System.Drawing.Point(595, 761);
            this.deltaTime.Margin = new System.Windows.Forms.Padding(4);
            this.deltaTime.Name = "deltaTime";
            this.deltaTime.Size = new System.Drawing.Size(94, 35);
            this.deltaTime.TabIndex = 37;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(433, 764);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(154, 24);
            this.label15.TabIndex = 36;
            this.label15.Text = "随机间隔时长";
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(721, 1095);
            this.Controls.Add(this.deltaTime);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.qrCodeSize);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.qrCodeAlpha);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.qrCodePos);
            this.Controls.Add(this.showQrCode);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.showLoginUser);
            this.Controls.Add(this.showIpAddr);
            this.Controls.Add(this.showMacAddr);
            this.Controls.Add(this.showCpuName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.outlineWeight);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.alpha);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.angle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.fontSize);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.column);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.row);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.version);
            this.Controls.Add(this.processList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Config";
            this.Load += new System.EventHandler(this.form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.form1_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox processList;
        private System.Windows.Forms.TextBox version;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox row;
        private System.Windows.Forms.TextBox column;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox fontSize;
        private System.Windows.Forms.TextBox angle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox alpha;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox outlineWeight;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox showCpuName;
        private System.Windows.Forms.CheckBox showMacAddr;
        private System.Windows.Forms.CheckBox showIpAddr;
        private System.Windows.Forms.CheckBox showLoginUser;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox showQrCode;
        private System.Windows.Forms.ComboBox qrCodePos;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox qrCodeAlpha;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox qrCodeSize;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox deltaTime;
        private System.Windows.Forms.Label label15;
    }
}

