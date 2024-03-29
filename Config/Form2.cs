﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Config
{
    public partial class Form2 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        private bool isMouseDown;
        private Point lastMouseLocation;
        private string password;

        private form1 mainForm;

        public Form2()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            lastMouseLocation = e.Location;
        }

        private void Form2_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                int deltaX = e.Location.X - lastMouseLocation.X;
                int deltaY = e.Location.Y - lastMouseLocation.Y;
                this.Left += deltaX;
                this.Top += deltaY;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (password != null && !String.IsNullOrEmpty(password))
            {
                if (password.Equals(textBox1.Text))
                {
                    mainForm.Show();
                    this.Hide();
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (!File.Exists(Config.Form3.IniFile))
            {
                File.WriteAllText(Config.Form3.IniFile,
                    @"[secure]
password=root");
            }
            password = Mask.IniUtils.Read("secure", "password", "root",Config.Form3.IniFile);
            mainForm = new form1();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
