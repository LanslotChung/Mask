using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Config
{
    /// <summary>
    /// 实现背景透明的ListBox,且文本居中
    /// 编写人：涂剑凯
    /// </summary>
    public class TransParentListBox : ListBox
    {
        public TransParentListBox()
        {
            //如果为 true，控件将自行绘制，而不是通过操作系统来绘制。
            //如果为 false，将不会引发 Paint 事件。此样式仅适用于派生自 Control 的类。
            this.SetStyle(ControlStyles.UserPaint, true);


            //如果为 true，控件接受 alpha 组件小于 255 的 BackColor 以模拟透明。
            //仅在 UserPaint 位设置为 true 并且父控件派生自 Control 时才模拟透明。
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);

            BorderStyle = BorderStyle.None;
        }

        protected override void OnSelectedIndexChanged(EventArgs e)
        {
            this.Invalidate();
            base.OnSelectedIndexChanged(e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (this.Focused && this.SelectedItem != null)
            {
                Rectangle itemRect = this.GetItemRectangle(this.SelectedIndex);
                e.Graphics.FillRectangle(Brushes.DarkBlue, itemRect);
            }
            for (int i = 0; i < Items.Count; i++)
            {
                StringFormat sfm = new StringFormat();
                sfm.Alignment = StringAlignment.Near;
                if(SelectedIndex == i)
                {
                    sfm.Alignment = StringAlignment.Far;
                }
                e.Graphics.DrawString(this.GetItemText(this.Items[i]), this.Font, new SolidBrush(this.ForeColor), this.GetItemRectangle(i),sfm);
            }
            base.OnPaint(e);
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
