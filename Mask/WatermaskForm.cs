using GameOverlay.Drawing;
using GameOverlay.Windows;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Mask
{
    internal class WatermaskForm : IDisposable
    {
        private readonly Dictionary<string, SolidBrush> _brushes;
        private readonly Dictionary<string, Font> _fonts;
        private readonly GraphicsWindow _window;
        private int Alpha;
        private float Angle;
        private int Column, Row;
        private float FontSize;
        private float OutlineWeight = .1f;
        private List<string> ProtectedProcessList;
        private Rectangle Screen;
        private int SpacingX;
        private int SpacingY;

        public WatermaskForm(List<string> protectedProcessList, Rectangle screen, int column, int row, int alpha, float fontSize, int angle, float outlineWeight)
        {
            Init(protectedProcessList, screen, column, row, alpha, fontSize, angle, outlineWeight);

            _brushes = new Dictionary<string, SolidBrush>();
            _fonts = new Dictionary<string, Font>();

            var gfx = new Graphics()
            {
                MeasureFPS = true,
                PerPrimitiveAntiAliasing = true,
                TextAntiAliasing = true
            };
            _window = new GraphicsWindow((int)Screen.Left, (int)Screen.Top, (int)Screen.Width, (int)Screen.Height, gfx)
            {
                FPS = 1,
                IsTopmost = true,
                IsVisible = true
            };

            _window.DestroyGraphics += Window_DestroyGraphics;
            _window.DrawGraphics += Window_DrawGraphics;
            _window.SetupGraphics += Window_SetupGraphics;
        }

        public void Init(List<string> protectedProcessList, Rectangle screen, int column, int row, int alpha, float fontSize, int angle, float outlineWeight)
        {
            Screen = screen;
            Column = column;
            Row = row;
            Alpha = alpha;
            FontSize = fontSize;
            Angle = (float)Math.PI / 180 * angle;

            OutlineWeight = outlineWeight;

            ProtectedProcessList = protectedProcessList;
        }

        ~WatermaskForm()
        {
            Dispose(false);
        }

        public void Run()
        {
            _window.Create();
            _window.Join();
        }

        private void Window_DestroyGraphics(object sender, DestroyGraphicsEventArgs e)
        {
            foreach (var pair in _brushes) pair.Value.Dispose();
            foreach (var pair in _fonts) pair.Value.Dispose();
        }

        private void Window_DrawGraphics(object sender, DrawGraphicsEventArgs e)
        {
            var gfx = e.Graphics;
            gfx.ClearScene(_brushes["透明"]);
            if (!IsProcessExist(ProtectedProcessList, out List<WindowInfo> foundWindowInfoes)) return;
            var desc = $"{Computer.Instance.ComputerName}-{Computer.Instance.MacAddress}";
            desc += DateTime.Now.GetDateTimeFormats('f')[0].ToString();
            var textSize = gfx.MeasureString(_fonts["微软雅黑"], desc);

            foreach (var windowInfo in foundWindowInfoes)
            {
                Column = (int)Math.Floor(windowInfo.Bounds.Width / textSize.X);
                Column = Column == 0 ? 1 : Column;

                Row = (int)Math.Floor(windowInfo.Bounds.Height / textSize.X);
                Row = Row == 0 ? 1 : Row;

                SpacingX = windowInfo.Bounds.Width / Column;
                SpacingY = windowInfo.Bounds.Height / Row;

                for (int x = 0; x < Column; x++)
                {
                    for (int y = 0; y < Row; y++)
                    {
                        var xPos = (x + .5f) * SpacingX;
                        var yPos = (y + .5f) * SpacingY;
                        TransformationMatrix transformationMatrix = TransformationMatrix.Transformation(1, 1, Angle, xPos + windowInfo.Bounds.Left - Screen.Left, yPos + windowInfo.Bounds.Top - Screen.Top);
                        gfx.TransformStart(transformationMatrix);
                        gfx.DrawTextWithBackground(_fonts["微软雅黑"], _brushes["黑色"], _brushes["透明"], -textSize.X / 2 - OutlineWeight, -textSize.Y / 2, desc);
                        gfx.DrawTextWithBackground(_fonts["微软雅黑"], _brushes["黑色"], _brushes["透明"], -textSize.X / 2 + OutlineWeight, -textSize.Y / 2, desc);
                        gfx.DrawTextWithBackground(_fonts["微软雅黑"], _brushes["黑色"], _brushes["透明"], -textSize.X / 2, -textSize.Y / 2 - OutlineWeight, desc);
                        gfx.DrawTextWithBackground(_fonts["微软雅黑"], _brushes["黑色"], _brushes["透明"], -textSize.X / 2, -textSize.Y / 2 + OutlineWeight, desc);
                        gfx.DrawTextWithBackground(_fonts["微软雅黑"], _brushes["白色"], _brushes["透明"], -textSize.X / 2, -textSize.Y / 2, desc);
                        gfx.TransformEnd();
                    }
                }
            }
        }

        private void Window_SetupGraphics(object sender, SetupGraphicsEventArgs e)
        {
            var gfx = e.Graphics;

            if (e.RecreateResources)
            {
                foreach (var pair in _brushes) pair.Value.Dispose();
            }

            _brushes["透明"] = gfx.CreateSolidBrush(0, 0, 0, 0);
            _brushes["黑色"] = gfx.CreateSolidBrush(0, 0, 0, Alpha);
            _brushes["白色"] = gfx.CreateSolidBrush(255, 255, 255, Alpha);
            _fonts["微软雅黑"] = gfx.CreateFont("微软雅黑", FontSize);
        }

        #region IDisposable Support

        private bool disposedValue;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public bool IsProcessExist(List<string> processes, out List<WindowInfo> foundWindowInfo)
        {
            bool isExistAny = false;
            foundWindowInfo = new List<WindowInfo>();
            foreach (var process in processes)
            {
                foreach (var foundProcess in Process.GetProcessesByName(process))
                {
                    isExistAny = true;
                    foreach (var windowInfo in Win32ApiTools.GetAllWindowInfoByHandle(foundProcess.Id))
                        foundWindowInfo.Add(windowInfo);
                }
            }
            return isExistAny;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                _window.Dispose();

                disposedValue = true;
            }
        }

        #endregion IDisposable Support
    }
}