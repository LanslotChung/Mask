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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Config
{
    public partial class Form3 : Form
    {
        private bool isMouseDown;
        private Point lastMouseLocation;
        private string password;

        public Form3()
        {
            InitializeComponent();
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

            Mask.IniUtils.Write("secure", "password", newPassword.Text,
                Path.Combine(Application.StartupPath, "config.ini"));
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
            password = Mask.IniUtils.Read("secure", "password", "root",
                Path.Combine(Application.StartupPath, "config.ini"));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
