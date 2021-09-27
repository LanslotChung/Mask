using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mask
{
    public class Config
    {
        public List<string> ProcessList { get; set; }
        public int Column { get; set; }
        public int Row { get; set; }
        public int Alpha { get; set; }
        public int FontSize { get; set; }
        public int Angle { get; set; }
        public float OutlineWeight { get; set; }
        public bool IsShowComputerName { get; set; }
        public bool IsShowMacAddr { get; set; }
        public bool IsShowIPAddr { get; set; }
        public bool IsShowLoginUser { get; set; }
        public bool IsShowQrCode { get; set; }
        public int QrCodePos { get; set; }
        public int QrCodeAlpha { get; set; }
        public int QrCodeSize { get; set; }
        public int ChangePosDeltaTime { get; set; }

        public Config()
        {
        }

        public Config(List<string> processList, int column, int row, int alpha, int fontSize, int angle, float outlineWeight, bool isShowComputerName, bool isShowMacAddr, bool isShowIPAddr, bool isShowLoginUser, bool isShowQrCode, int qrCodePos, int qrCodeAlpha, int qrCodeSize, int changePosDeltaTime)
        {
            ProcessList = processList;
            Column = column;
            Row = row;
            Alpha = alpha;
            FontSize = fontSize;
            Angle = angle;
            OutlineWeight = outlineWeight;
            IsShowComputerName = isShowComputerName;
            IsShowMacAddr = isShowMacAddr;
            IsShowIPAddr = isShowIPAddr;
            IsShowLoginUser = isShowLoginUser;
            IsShowQrCode = isShowQrCode;
            QrCodePos = qrCodePos;
            QrCodeAlpha = qrCodeAlpha;
            QrCodeSize = qrCodeSize;
            ChangePosDeltaTime = changePosDeltaTime;
        }

        public override bool Equals(object obj)
        {
            return obj is Config config &&
                   EqualityComparer<List<string>>.Default.Equals(ProcessList, config.ProcessList) &&
                   Column == config.Column &&
                   Row == config.Row &&
                   Alpha == config.Alpha &&
                   FontSize == config.FontSize &&
                   Angle == config.Angle &&
                   OutlineWeight == config.OutlineWeight &&
                   IsShowComputerName == config.IsShowComputerName &&
                   IsShowMacAddr == config.IsShowMacAddr &&
                   IsShowIPAddr == config.IsShowIPAddr &&
                   IsShowLoginUser == config.IsShowLoginUser &&
                   IsShowQrCode == config.IsShowQrCode &&
                   QrCodePos == config.QrCodePos &&
                   QrCodeAlpha == config.QrCodeAlpha &&
                   QrCodeSize == config.QrCodeSize &&
                   ChangePosDeltaTime == config.ChangePosDeltaTime;
        }

        public override int GetHashCode()
        {
            int hashCode = 1133365354;
            hashCode = hashCode * -1521134295 + EqualityComparer<List<string>>.Default.GetHashCode(ProcessList);
            hashCode = hashCode * -1521134295 + Column.GetHashCode();
            hashCode = hashCode * -1521134295 + Row.GetHashCode();
            hashCode = hashCode * -1521134295 + Alpha.GetHashCode();
            hashCode = hashCode * -1521134295 + FontSize.GetHashCode();
            hashCode = hashCode * -1521134295 + Angle.GetHashCode();
            hashCode = hashCode * -1521134295 + OutlineWeight.GetHashCode();
            hashCode = hashCode * -1521134295 + IsShowComputerName.GetHashCode();
            hashCode = hashCode * -1521134295 + IsShowMacAddr.GetHashCode();
            hashCode = hashCode * -1521134295 + IsShowIPAddr.GetHashCode();
            hashCode = hashCode * -1521134295 + IsShowLoginUser.GetHashCode();
            hashCode = hashCode * -1521134295 + IsShowQrCode.GetHashCode();
            hashCode = hashCode * -1521134295 + QrCodePos.GetHashCode();
            hashCode = hashCode * -1521134295 + QrCodeAlpha.GetHashCode();
            hashCode = hashCode * -1521134295 + QrCodeSize.GetHashCode();
            hashCode = hashCode * -1521134295 + ChangePosDeltaTime.GetHashCode();
            return hashCode;
        }
    }
}
