
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "版本";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "受保护的程序";
            // 
            // processList
            // 
            this.processList.FormattingEnabled = true;
            this.processList.ItemHeight = 12;
            this.processList.Location = new System.Drawing.Point(94, 28);
            this.processList.Margin = new System.Windows.Forms.Padding(2);
            this.processList.Name = "processList";
            this.processList.Size = new System.Drawing.Size(248, 112);
            this.processList.TabIndex = 2;
            // 
            // version
            // 
            this.version.Location = new System.Drawing.Point(94, 3);
            this.version.Margin = new System.Windows.Forms.Padding(2);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(248, 21);
            this.version.TabIndex = 3;
            this.version.TextChanged += new System.EventHandler(this.version_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 173);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "密度";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 173);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "行";
            // 
            // row
            // 
            this.row.Location = new System.Drawing.Point(118, 170);
            this.row.Margin = new System.Windows.Forms.Padding(2);
            this.row.Name = "row";
            this.row.Size = new System.Drawing.Size(90, 21);
            this.row.TabIndex = 6;
            this.row.TextChanged += new System.EventHandler(this.row_TextChanged);
            // 
            // column
            // 
            this.column.Location = new System.Drawing.Point(252, 170);
            this.column.Margin = new System.Windows.Forms.Padding(2);
            this.column.Name = "column";
            this.column.Size = new System.Drawing.Size(90, 21);
            this.column.TabIndex = 8;
            this.column.TextChanged += new System.EventHandler(this.column_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(231, 173);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "列";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 199);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "字体大小";
            // 
            // fontSize
            // 
            this.fontSize.Location = new System.Drawing.Point(94, 197);
            this.fontSize.Margin = new System.Windows.Forms.Padding(2);
            this.fontSize.Name = "fontSize";
            this.fontSize.Size = new System.Drawing.Size(248, 21);
            this.fontSize.TabIndex = 10;
            this.fontSize.TextChanged += new System.EventHandler(this.fontSize_TextChanged);
            // 
            // angle
            // 
            this.angle.Location = new System.Drawing.Point(94, 272);
            this.angle.Margin = new System.Windows.Forms.Padding(2);
            this.angle.Name = "angle";
            this.angle.Size = new System.Drawing.Size(248, 21);
            this.angle.TabIndex = 12;
            this.angle.TextChanged += new System.EventHandler(this.angle_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 274);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "旋转角度";
            // 
            // alpha
            // 
            this.alpha.Location = new System.Drawing.Point(94, 222);
            this.alpha.Margin = new System.Windows.Forms.Padding(2);
            this.alpha.Name = "alpha";
            this.alpha.Size = new System.Drawing.Size(248, 21);
            this.alpha.TabIndex = 15;
            this.alpha.TextChanged += new System.EventHandler(this.alpha_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 224);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 14;
            this.label8.Text = "字体透明度";
            // 
            // outlineWeight
            // 
            this.outlineWeight.Location = new System.Drawing.Point(94, 247);
            this.outlineWeight.Margin = new System.Windows.Forms.Padding(2);
            this.outlineWeight.Name = "outlineWeight";
            this.outlineWeight.Size = new System.Drawing.Size(248, 21);
            this.outlineWeight.TabIndex = 17;
            this.outlineWeight.TextChanged += new System.EventHandler(this.outlineWeight_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 249);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 16;
            this.label9.Text = "字体外轮廓";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(266, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "添加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(185, 142);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "删除";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(8, 298);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(334, 23);
            this.button3.TabIndex = 20;
            this.button3.Text = "保存";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 329);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "form1";
            this.Text = "Config";
            this.Load += new System.EventHandler(this.form1_Load);
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
    }
}

