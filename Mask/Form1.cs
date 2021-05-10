using GameOverlay.Drawing;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Mask
{
    public partial class Form1 : Form
    {
        private readonly static List<string> protectedProcessList = new List<string>()
        {
            "explorer"
        };

        private readonly static string jsonFile = Path.Combine(Application.StartupPath, "config.json");

        static private Config loadedConfig = null;

        static private WatermaskForm form;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Visible = false;
            LoadConfig();
            ReceiveConfig();
            RunOverlay();
        }

        static private void ReceiveConfig()
        {
            Thread thread = new Thread(() =>
            {
                UdpClient udp = new UdpClient(new IPEndPoint(IPAddress.Any, 12345));
                IPEndPoint endpoint = new IPEndPoint(IPAddress.Any, 0);
                while (true)
                {
                    byte[] buf = udp.Receive(ref endpoint);
                    string recvMsg = Encoding.Default.GetString(buf);

                    if (!string.IsNullOrEmpty(recvMsg))
                    {
                        if (recvMsg.StartsWith("password:"))
                        {
                            IniUtils.Write("secure", "password", recvMsg.Replace("password:", ""),
                                Path.Combine(Application.StartupPath, "config.ini"));
                        }
                        else
                        {
                            Config recvConfig = JsonConvert.DeserializeObject<Config>(recvMsg);
                            if (recvConfig != null && recvConfig != new Config())
                            {
                                if (recvConfig.Version > loadedConfig.Version)
                                {
                                    File.WriteAllText(jsonFile, recvMsg);
                                    form.Dispose();
                                    form = null;
                                    Application.Exit();
                                    Process.Start(Application.ExecutablePath);
                                }
                            }
                        }
                    }
                }
            });
            thread.IsBackground = true;
            thread.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Process[] processList = Process.GetProcesses();
            bool isFound = false;
            foreach (Process process in processList)
            {
                if (process.ProcessName == "MaskProtector")
                {
                    isFound = true;
                }
            }
            if (!isFound)
            {
                Process.Start(Path.Combine(Application.StartupPath, "MaskProtector.exe"));
            }
        }

        private void RunOverlay()
        {
            Thread thread = new Thread(() =>
            {
                Rectangle canvas = new Rectangle();
                foreach (var screen in Screen.AllScreens)
                {
                    canvas.Right += screen.Bounds.Width;
                    canvas.Bottom += screen.Bounds.Height;
                    canvas.Left = Math.Min(screen.Bounds.Left, canvas.Left);
                    canvas.Top = Math.Min(screen.Bounds.Top, canvas.Top);
                }
                form = new WatermaskForm(canvas);
                form.Setup(loadedConfig.ProcessList, loadedConfig.Column, loadedConfig.Row, loadedConfig.Alpha, loadedConfig.FontSize, loadedConfig.Angle, loadedConfig.OutlineWeight);
                form.Run();
            });
            thread.IsBackground = true;
            thread.Start();
        }

        private void LoadConfig()
        {
            if (File.Exists(jsonFile))
            {
                loadedConfig = JsonConvert.DeserializeObject<Config>(File.ReadAllText(jsonFile));
            }

            if (loadedConfig == null || loadedConfig.Equals(new Config()))
            {
                loadedConfig = new Config();
                loadedConfig.Version = -1;
                loadedConfig.ProcessList = protectedProcessList;
                loadedConfig.Column = 3;
                loadedConfig.Row = 3;
                loadedConfig.Alpha = 50;
                loadedConfig.FontSize = 14;
                loadedConfig.Angle = 30;
                loadedConfig.OutlineWeight = .5f;
                File.WriteAllText(jsonFile, JsonConvert.SerializeObject(loadedConfig));
            }
        }

        private void Form1_VisibleChanged(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
