using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Config
{
    public class TransTextBox : RichTextBox
    {
        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        static extern IntPtr LoadLibrary(string lpFileName);

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams prams = base.CreateParams;
                if (LoadLibrary("msftedit.dll") != IntPtr.Zero)
                {
                    prams.ExStyle |= 0x020; // transparent 
                    prams.ClassName = "RICHEDIT50W";// TRANSTEXTBOXW
                }
                return prams;
            }
        }

        public TransTextBox() : base()
        {
            this.Multiline = false;
        }
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            var switchExpr = m.Msg;
            switch (switchExpr)
            {
                case 0xF:
                    {
                        Graphics g = this.CreateGraphics();
                        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default;
                        int borderWidth = 2;
                        Rectangle rect = ClientRectangle;
                        using (var p = new Pen(Color.DeepSkyBlue, borderWidth) { Alignment = System.Drawing.Drawing2D.PenAlignment.Center })
                        {
                            g.DrawRectangle(p, rect);
                        }

                        break;
                    }

                default:
                    {
                        break;
                    }
            }
        }
    }
}
