using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaskProtector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Process[] processList = Process.GetProcesses();
            bool isFound = false;
            foreach (Process process in processList)
            {
                if (process.ProcessName == "Mask")
                {
                    isFound = true;
                    }
            }
            if (!isFound)
            {
                Process.Start(Path.Combine(Application.StartupPath, "Mask.exe"));

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void Form1_VisibleChanged(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
