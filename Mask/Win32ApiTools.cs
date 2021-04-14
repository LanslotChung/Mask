using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Text;

namespace Mask
{
    public class Win32ApiTools
    {
        public static List<WindowInfo> GetAllWindowInfoByHandle(int Pid)
        {
            List<WindowInfo> windowInfos = new List<WindowInfo>();
            foreach (var handle in EnumerateProcessWindowHandles(Pid))
            {
                windowInfos.Add(GetWindowInfoByHandle(handle));
            }
            return windowInfos.FindAll(info =>
            {
                return info != null &&
                    info.IsVisible &&
                    !info.IsMinimized &&
                    info.Title.Length > 0;
            });
        }

        private static IEnumerable<IntPtr> EnumerateProcessWindowHandles(int processId)
        {
            var handles = new List<IntPtr>();
            try
            {
                var process = Process.GetProcessById(processId);
                if (process != null)
                {
                    int threadCount = process.Threads.Count;
                    for (int i = 0; i < threadCount; i++)
                    {
                        if (process == null || process.Threads[i] == null) break;
                        var thread = process.Threads[i];
                        Win32Api.EnumThreadWindows(
                            thread.Id,
                            (hWnd, lParam) =>
                            {
                                handles.Add(hWnd);
                                return true;
                            },
                            IntPtr.Zero);
                    }
                }
                return handles;
            }
            catch (Exception e)
            {
                return handles;
            }
        }

        public static WindowInfo GetWindowInfoByHandle(IntPtr hWnd)
        {
            // 仅查找顶层窗口。
            if (Win32Api.GetParent(hWnd) == IntPtr.Zero)
            {
                // 获取窗口类名。
                var lpString = new StringBuilder(512);
                Win32Api.GetClassName(hWnd, lpString, lpString.Capacity);
                var className = lpString.ToString();

                // 获取窗口标题。
                var lptrString = new StringBuilder(512);
                Win32Api.GetWindowText(hWnd, lptrString, lptrString.Capacity);
                var title = lptrString.ToString().Trim();

                // 获取窗口可见性。
                var isVisible = Win32Api.IsWindowVisible(hWnd);

                // 获取窗口位置和尺寸。
                Win32Api.LPRECT rect = default;
                Win32Api.GetWindowRect(hWnd, ref rect);
                var bounds = new Rectangle(rect.Left, rect.Top, rect.Right - rect.Left, rect.Bottom - rect.Top);

                // 添加到已找到的窗口列表。
                return new WindowInfo(hWnd, className, title, isVisible, bounds);
            }

            return null;
        }
    }

    /// <summary>
    /// 获取 Win32 窗口的一些基本信息。
    /// </summary>
    public class WindowInfo
    {
        public WindowInfo(IntPtr hWnd, string className, string title, bool isVisible, Rectangle bounds)
        {
            Hwnd = hWnd;
            ClassName = className;
            Title = title;
            IsVisible = isVisible;
            Bounds = bounds;
        }

        /// <summary>
        /// 获取窗口句柄。
        /// </summary>
        public IntPtr Hwnd { get; }

        /// <summary>
        /// 获取窗口类名。
        /// </summary>
        public string ClassName { get; }

        /// <summary>
        /// 获取窗口标题。
        /// </summary>
        public string Title { get; }

        /// <summary>
        /// 获取当前窗口是否可见。
        /// </summary>
        public bool IsVisible { get; }

        /// <summary>
        /// 获取窗口当前的位置和尺寸。
        /// </summary>
        public Rectangle Bounds { get; }

        /// <summary>
        /// 获取窗口当前是否是最小化的。
        /// </summary>
        public bool IsMinimized => Bounds.Left == -32000 && Bounds.Top == -32000;
    }
}