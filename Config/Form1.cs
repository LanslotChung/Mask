using Newtonsoft.Json;
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
    public partial class form1 : Form
    {
        Config loadedConfig = null;
        private readonly static List<string> protectedProcessList = new List<string>()
        {
            "explorer"
        };
        private readonly static string jsonFile = Path.Combine(Application.StartupPath, "config.json");
        public form1()
        {
            InitializeComponent();
        }

        private void form1_Load(object sender, EventArgs e)
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
            version.Text = loadedConfig.Version.ToString();
            foreach (var process in loadedConfig.ProcessList)
            {
                processList.Items.Add(process);
            }
            column.Text = loadedConfig.Column.ToString();
            row.Text = loadedConfig.Row.ToString();
            alpha.Text = loadedConfig.Alpha.ToString();
            fontSize.Text = loadedConfig.FontSize.ToString();
            angle.Text = loadedConfig.Angle.ToString();
            outlineWeight.Text = loadedConfig.OutlineWeight.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool containError = false;
            Config newConfig = new Config();
            if (int.TryParse(version.Text, out int _version))
            {
                newConfig.Version = _version;
            }
            else
            {
                containError = true;
                version.BackColor = Color.IndianRed;
            }
            if (int.TryParse(column.Text, out int _column))
            {
                newConfig.Column = _column;
            }
            else
            {
                containError = true;
                column.BackColor = Color.IndianRed;
            }
            if (int.TryParse(row.Text, out int _row))
            {
                newConfig.Row = _row;
            }
            else
            {
                containError = true;
                row.BackColor = Color.IndianRed;
            }
            if (int.TryParse(fontSize.Text, out int _fontSize))
            {
                newConfig.FontSize = _fontSize;
            }
            else
            {
                containError = true;
                fontSize.BackColor = Color.IndianRed;
            }
            if (int.TryParse(angle.Text, out int _angle))
            {
                newConfig.Angle = _angle;
            }
            else
            {
                containError = true;
                angle.BackColor = Color.IndianRed;
            }
            if (int.TryParse(alpha.Text, out int _alpha))
            {
                newConfig.Alpha = _alpha;
            }
            else
            {
                containError = true;
                alpha.BackColor = Color.IndianRed;
            }
            if (float.TryParse(outlineWeight.Text, out float _outlineWeight))
            {
                newConfig.OutlineWeight = _outlineWeight;
            }
            else
            {
                containError = true;
                outlineWeight.BackColor = Color.IndianRed;
            }
            if (processList.Items.Count == 0)
            {
                containError = true;
                processList.BackColor = Color.IndianRed;
            }
            else
            {
                newConfig.ProcessList = new List<string>();
                foreach (string process in processList.Items)
                {
                    if (string.IsNullOrEmpty(process))
                    {
                        containError = true;
                        processList.BackColor = Color.IndianRed;
                        break;
                    }
                    newConfig.ProcessList.Add(process);
                }
            }
            if (containError)
            {
                MessageBox.Show("有错误的值，请修改后重新保存！");
                return;
            }
            string configJson = JsonConvert.SerializeObject(newConfig);
            if (loadedConfig.Version >= newConfig.Version)
            {
                if(MessageBox.Show("检查到版本小于或等于本地配置，该配置仅在本机生效，可以吗？","提示",MessageBoxButtons.YesNo)
                    == DialogResult.Yes)
                {
                    File.WriteAllText(jsonFile, configJson);
                }
            }
            else
            {
                loadedConfig = newConfig;
                File.WriteAllText(jsonFile, configJson);
                MessageBox.Show("将要发送并应用配置到所有计算机！", "提示");
                SendBroadcast(configJson);
            }
            
        }

        private void SendBroadcast(string msg)
        {
            UdpClient udp = new UdpClient(new IPEndPoint(IPAddress.Any, 0));
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Broadcast, 12345);
            byte[] buff = Encoding.Default.GetBytes(msg);
            udp.Send(buff,buff.Length,endPoint);
        }

        private void version_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(version.Text, out int _value))
            {
                version.BackColor = Color.IndianRed;
            }
            else
            {
                version.BackColor = Color.White;
            }
        }

        private void row_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(row.Text, out int _value))
            {
                row.BackColor = Color.IndianRed;
            }
            else
            {
                row.BackColor = Color.White;
            }
        }

        private void column_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(column.Text, out int _value))
            {
                column.BackColor = Color.IndianRed;
            }
            else
            {
                column.BackColor = Color.White;
            }
        }

        private void fontSize_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(fontSize.Text, out int _value))
            {
                fontSize.BackColor = Color.IndianRed;
            }
            else
            {
                fontSize.BackColor = Color.White;
            }
        }

        private void alpha_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(alpha.Text, out int _value))
            {
                alpha.BackColor = Color.IndianRed;
            }
            else
            {
                alpha.BackColor = Color.White;
            }
        }

        private void outlineWeight_TextChanged(object sender, EventArgs e)
        {
            if (!float.TryParse(outlineWeight.Text, out float _value))
            {
                outlineWeight.BackColor = Color.IndianRed;
            }
            else
            {
                outlineWeight.BackColor = Color.White;
            }
        }

        private void angle_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(angle.Text, out int _value))
            {
                angle.BackColor = Color.IndianRed;
            }
            else
            {
                angle.BackColor = Color.White;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认要删除吗？", "警告", MessageBoxButtons.OKCancel) == DialogResult.OK)
                processList.Items.RemoveAt(processList.SelectedIndex);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "应用程序|*.exe";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string process = openFileDialog.SafeFileName.Replace(".exe", "");
                if (processList.Items.Contains(process))
                {
                    MessageBox.Show("添加的进程已存在！");
                }
                else
                {
                    processList.Items.Add(process);
                }
            }
        }
    }
}
