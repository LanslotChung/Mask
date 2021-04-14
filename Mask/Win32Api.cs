using System;
using System.Runtime.InteropServices;
using System.Text;

namespace Mask
{
    public class Win32Api
    {
        public delegate bool EnumThreadDelegate(IntPtr hWnd, IntPtr lParam);

        [DllImport("user32.dll", EntryPoint = "FindWindowEx", CharSet = CharSet.Auto)]
        public static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass, string lpszWindow);

        [DllImport("user32")]
        public static extern bool EnumThreadWindows(int dwThreadId, EnumThreadDelegate lpfn,
    IntPtr lParam);

        [DllImport("user32")]
        public static extern IntPtr GetParent(IntPtr hWnd);

        [DllImport("user32")]
        public static extern bool IsWindowVisible(IntPtr hWnd);

        [DllImport("user32")]
        public static extern int GetWindowText(IntPtr hWnd, StringBuilder lptrString, int nMaxCount);

        [DllImport("user32")]
        public static extern int GetClassName(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

        [DllImport("user32")]
        public static extern void SwitchToThisWindow(IntPtr hWnd, bool fAltTab);

        [DllImport("user32")]
        public static extern bool GetWindowRect(IntPtr hWnd, ref LPRECT rect);

        [StructLayout(LayoutKind.Sequential)]
        public readonly struct LPRECT
        {
            public readonly int Left;
            public readonly int Top;
            public readonly int Right;
            public readonly int Bottom;
        }
    }
}