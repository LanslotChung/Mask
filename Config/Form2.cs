using Microsoft.Win32;
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
        

        private bool isMouseDown;
        private Point lastMouseLocation;
        private string password;

        private form1 mainForm;

        public Form2()
        {
            InitializeComponent();
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

            password = Mask.IniUtils.Read("secure", "password", "root", 
                Path.Combine(Application.StartupPath, "config.ini"));
            mainForm = new form1();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
