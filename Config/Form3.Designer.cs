
namespace Config
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.oldPassword = new Config.TransTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.newPassword = new Config.TransTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.newPassword1 = new Config.TransTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new Config.CustomButton();
            this.button2 = new Config.CustomButton();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // oldPassword
            // 
            this.oldPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.oldPassword.Location = new System.Drawing.Point(106, 46);
            this.oldPassword.Margin = new System.Windows.Forms.Padding(2);
            this.oldPassword.Multiline = false;
            this.oldPassword.Name = "oldPassword";
            this.oldPassword.Size = new System.Drawing.Size(248, 21);
            this.oldPassword.TabIndex = 12;
            this.oldPassword.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label6.Location = new System.Drawing.Point(18, 48);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "旧密码";
            // 
            // newPassword
            // 
            this.newPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newPassword.Location = new System.Drawing.Point(106, 84);
            this.newPassword.Margin = new System.Windows.Forms.Padding(2);
            this.newPassword.Multiline = false;
            this.newPassword.Name = "newPassword";
            this.newPassword.Size = new System.Drawing.Size(248, 21);
            this.newPassword.TabIndex = 14;
            this.newPassword.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(18, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "新密码";
            // 
            // newPassword1
            // 
            this.newPassword1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newPassword1.Location = new System.Drawing.Point(106, 122);
            this.newPassword1.Margin = new System.Windows.Forms.Padding(2);
            this.newPassword1.Multiline = false;
            this.newPassword1.Name = "newPassword1";
            this.newPassword1.Size = new System.Drawing.Size(248, 21);
            this.newPassword1.TabIndex = 16;
            this.newPassword1.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(18, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "确认密码";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.Location = new System.Drawing.Point(20, 158);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(334, 26);
            this.button1.TabIndex = 17;
            this.button1.Text = "确认修改";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.button2.Location = new System.Drawing.Point(334, 9);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(20, 20);
            this.button2.TabIndex = 18;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.Location = new System.Drawing.Point(56, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(263, 16);
            this.label3.TabIndex = 39;
            this.label3.Text = "国网湖南安全管控中心防泄密软件";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Config.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(374, 202);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.newPassword1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.newPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.oldPassword);
            this.Controls.Add(this.label6);
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form3_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form3_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form3_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Config.TransTextBox oldPassword;
        private System.Windows.Forms.Label label6;
        private Config.TransTextBox newPassword;
        private System.Windows.Forms.Label label1;
        private Config.TransTextBox newPassword1;
        private System.Windows.Forms.Label label2;
        private Config.CustomButton button1;
        private Config.CustomButton button2;
        private System.Windows.Forms.Label label3;
    }
}