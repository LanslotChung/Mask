using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Config
{
    public partial class Form3 : Form
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
        public static string IniFile = Path.Combine(Application.StartupPath, "config.ini");
        private bool isMouseDown;
        private Point lastMouseLocation;
        private string password;

        public Form3()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void Form3_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            lastMouseLocation = e.Location;
        }

        private void Form3_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                int deltaX = e.Location.X - lastMouseLocation.X;
                int deltaY = e.Location.Y - lastMouseLocation.Y;
                this.Left += deltaX;
                this.Top += deltaY;
            }
        }

        private void Form3_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!oldPassword.Text.Equals(password))
            {
                oldPassword.BackColor = Color.IndianRed;
                return;
            }
            oldPassword.BackColor = Color.White;
            if (!newPassword.Text.Equals(newPassword1.Text))
            {
                newPassword1.BackColor = Color.IndianRed;
                return;
            }
            newPassword1.BackColor = Color.White;

            Mask.IniUtils.Write("secure", "password", newPassword.Text,IniFile);
            password = newPassword.Text;
            MessageBox.Show("修改成功！");
            oldPassword.Text = "";
            newPassword.Text = "";
            newPassword1.Text = "";
            SendBroadcast("password:" + password);
        }

        private void SendBroadcast(string msg)
        {
            UdpClient udp = new UdpClient(new IPEndPoint(IPAddress.Any, 0));
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Broadcast, 12345);
            byte[] buff = Encoding.Default.GetBytes(msg);
            udp.Send(buff, buff.Length, endPoint);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            if (!File.Exists(IniFile))
            {
                File.WriteAllText(IniFile,
                    @"[secure]
password=root");
            }
            password = Mask.IniUtils.Read("secure", "password", "root", IniFile);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
