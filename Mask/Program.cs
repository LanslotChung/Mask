using GameOverlay.Drawing;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Mask
{
    internal static class Program
    {
        private readonly static List<string> protectedProcessList = new List<string>()
        {
            "msedge",
            "360chrome"
        };

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        private static void Main()
        {
            GameOverlay.TimerService.EnableHighPrecisionTimers();
            Rectangle screenParameter = new Rectangle();
            foreach (var screen in Screen.AllScreens)
            {
                screenParameter.Right += screen.Bounds.Width;
                screenParameter.Bottom += screen.Bounds.Height;
                screenParameter.Left = Math.Min(screen.Bounds.Left, screenParameter.Left);
                screenParameter.Top = Math.Min(screen.Bounds.Top, screenParameter.Top);
            }
            using (var form = new WatermaskForm(protectedProcessList, screenParameter, 3, 3, 50, 14, 30, .5f))
            {
                form.Run();
            }
        }
    }
}