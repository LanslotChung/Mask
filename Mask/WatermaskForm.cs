using GameOverlay.Drawing;
using GameOverlay.Windows;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Mask
{
    internal class WatermaskForm : IDisposable
    {
        private readonly Dictionary<string, SolidBrush> _brushes;
        private readonly Dictionary<string, Font> _fonts;
        private readonly Dictionary<string, Image> _images;
        private readonly GraphicsWindow _window;
        private int Alpha;
        private float Angle;
        private int Column, Row;
        private float FontSize;
        private float OutlineWeight = .1f;
        private List<string> ProtectedProcessList;
        private Rectangle Canvas;
        private int SpacingX;
        private int SpacingY;
        private bool EnableQrCode = false;
        private int QrCodeSize;
        private int QrCodeAlpha;
        private int QrCodePos;
        private int _qrCodePos;
        private string TextContent = "";
        private long tmpTime = 0;
        private int ChangePosTime;

        public WatermaskForm(Rectangle canvas)
        {
            Canvas = canvas;

            _brushes = new Dictionary<string, SolidBrush>();
            _fonts = new Dictionary<string, Font>();
            _images = new Dictionary<string, Image>();

            var gfx = new Graphics()
            {
                MeasureFPS = true,
                PerPrimitiveAntiAliasing = true,
                TextAntiAliasing = true
            };
            _window = new GraphicsWindow((int)Canvas.Left, (int)Canvas.Top, (int)Canvas.Width, (int)Canvas.Height, gfx)
            {
                FPS = 120,
                IsTopmost = true,
                IsVisible = true
            };

            _window.DestroyGraphics += Window_DestroyGraphics;
            _window.DrawGraphics += Window_DrawGraphics;
            _window.SetupGraphics += Window_SetupGraphics;
        }

        public void Setup(Config config)
        {
            Column = config.Column;
            Row = config.Row;
            Alpha = config.Alpha;
            FontSize = config.FontSize;
            Angle = (float)Math.PI / 180 * config.Angle;

            OutlineWeight = config.OutlineWeight;

            ProtectedProcessList = config.ProcessList;
            if (config.IsShowComputerName)
            {
                TextContent += Computer.Instance.ComputerName + " ";
            }
            if (config.IsShowMacAddr)
            {
                TextContent += Computer.Instance.MacAddress + " ";
            }

            if (config.IsShowIPAddr)
            {
                TextContent += Computer.Instance.IpAddress + " ";
            }

            if (config.IsShowLoginUser)
            {
                TextContent += Computer.Instance.LoginUserName + " ";
            }

            EnableQrCode = config.IsShowQrCode;
            QrCodeAlpha = config.QrCodeAlpha;
            QrCodePos = config.QrCodePos;
            if (QrCodePos == 0) _qrCodePos = 1;
            QrCodeSize = config.QrCodeSize;
            ChangePosTime = config.ChangePosDeltaTime;


            if (EnableQrCode)
            {
                System.Drawing.Bitmap bitmap = QrCodeUtils.GenerateQrCode(
                    $"计算机名： {Computer.Instance.ComputerName} \n" +
                    $"系统登录用户：{Computer.Instance.LoginUserName} \n" +
                    $"计算机MAC地址：{Computer.Instance.MacAddress} \n" +
                    $"计算机IP地址：{Computer.Instance.IpAddress}",
                    QrCodeSize,
                    QrCodeSize
                    );
                bitmap.Save(Path.Combine(Application.StartupPath, "qrcode.png"), System.Drawing.Imaging.ImageFormat.Png);
            }
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

            var text = TextContent + " " + DateTime.Now.GetDateTimeFormats('f')[0].ToString();
            var textSize = gfx.MeasureString(_fonts["微软雅黑"], text);

            foreach (var windowInfo in foundWindowInfoes)
            {
                //Column = (int)Math.Floor(windowInfo.Bounds.Width / textSize.X);
                //Column = Column == 0 ? 1 : Column;

                //Row = (int)Math.Floor(windowInfo.Bounds.Height / textSize.X);
                //Row = Row == 0 ? 1 : Row;

                SpacingX = windowInfo.Bounds.Width / Column;
                SpacingY = windowInfo.Bounds.Height / Row;

                for (int x = 0; x < Column; x++)
                {
                    for (int y = 0; y < Row; y++)
                    {
                        var xPos = (x + .5f) * SpacingX;
                        var yPos = (y + .5f) * SpacingY;
                        TransformationMatrix transformationMatrix = TransformationMatrix.Transformation(1, 1, Angle, xPos + windowInfo.Bounds.Left - Canvas.Left, yPos + windowInfo.Bounds.Top - Canvas.Top);
                        gfx.TransformStart(transformationMatrix);
                        gfx.DrawTextWithBackground(_fonts["微软雅黑"], _brushes["黑色"], _brushes["透明"], -textSize.X / 2 - OutlineWeight, -textSize.Y / 2, text);
                        gfx.DrawTextWithBackground(_fonts["微软雅黑"], _brushes["黑色"], _brushes["透明"], -textSize.X / 2 + OutlineWeight, -textSize.Y / 2, text);
                        gfx.DrawTextWithBackground(_fonts["微软雅黑"], _brushes["黑色"], _brushes["透明"], -textSize.X / 2, -textSize.Y / 2 - OutlineWeight, text);
                        gfx.DrawTextWithBackground(_fonts["微软雅黑"], _brushes["黑色"], _brushes["透明"], -textSize.X / 2, -textSize.Y / 2 + OutlineWeight, text);
                        gfx.DrawTextWithBackground(_fonts["微软雅黑"], _brushes["白色"], _brushes["透明"], -textSize.X / 2, -textSize.Y / 2, text);
                        gfx.TransformEnd();
                    }
                }

                if (EnableQrCode)
                {
                    if(QrCodePos != 0)
                    {
                        _qrCodePos = QrCodePos;
                    }
                    else
                    {
                        if((tmpTime += e.DeltaTime) / 1000 > ChangePosTime)
                        {
                            tmpTime = 0;
                            _qrCodePos = new Random().Next(1, 4 + 1);
                        }
                    }
                    switch (_qrCodePos)
                    {
                        case 1://LEFT TOP
                            gfx.DrawImage(_images["二维码"], windowInfo.Bounds.Left, windowInfo.Bounds.Top, (float)QrCodeAlpha / 255.0f);
                            break;
                        case 2://LEFT BOTTOM
                            gfx.DrawImage(_images["二维码"], windowInfo.Bounds.Left, windowInfo.Bounds.Bottom - QrCodeSize, (float)QrCodeAlpha / 255.0f);
                            break;
                        case 3://RIGHT TOP
                            gfx.DrawImage(_images["二维码"], windowInfo.Bounds.Right - QrCodeSize, windowInfo.Bounds.Top, (float)QrCodeAlpha / 255.0f);
                            break;
                        case 4://RIGHT BOTTOM
                            gfx.DrawImage(_images["二维码"], windowInfo.Bounds.Right - QrCodeSize, windowInfo.Bounds.Bottom - QrCodeSize, (float)QrCodeAlpha / 255.0f);
                            break;
                    }
                }

                gfx.DrawRectangleEdges(_brushes["蓝色"],
                        windowInfo.Bounds.Left,
                        windowInfo.Bounds.Top,
                        windowInfo.Bounds.Right,
                        windowInfo.Bounds.Bottom,
                        5);
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
            _brushes["蓝色"] = gfx.CreateSolidBrush(0, 0, 100, 255);
            _fonts["微软雅黑"] = gfx.CreateFont("微软雅黑", FontSize);
            _images["二维码"] = gfx.CreateImage(Path.Combine(Application.StartupPath, "qrcode.png"));
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