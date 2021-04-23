using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mask
{
    class Config
    {
        public int Version { get; set; }
        public List<string> ProcessList { get; set; }
        public int Column { get; set; }
        public int Row { get; set; }
        public int Alpha { get; set; } 
        public int FontSize { get; set; }
        public int Angle { get; set; }
        public float OutlineWeight { get; set; }

        public Config()
        {
        }

        public Config(int version, List<string> processList, int column, int row, int alpha, int fontSize, int angle, float outlineWeight)
        {
            Version = version;
            ProcessList = processList;
            Column = column;
            Row = row;
            Alpha = alpha;
            FontSize = fontSize;
            Angle = angle;
            OutlineWeight = outlineWeight;
        }

        public override bool Equals(object obj)
        {
            return obj is Config config &&
                   Version == config.Version &&
                   EqualityComparer<List<string>>.Default.Equals(ProcessList, config.ProcessList) &&
                   Column == config.Column &&
                   Row == config.Row &&
                   Alpha == config.Alpha &&
                   FontSize == config.FontSize &&
                   Angle == config.Angle &&
                   OutlineWeight == config.OutlineWeight;
        }

        public override int GetHashCode()
        {
            int hashCode = -1943960548;
            hashCode = hashCode * -1521134295 + Version.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<List<string>>.Default.GetHashCode(ProcessList);
            hashCode = hashCode * -1521134295 + Column.GetHashCode();
            hashCode = hashCode * -1521134295 + Row.GetHashCode();
            hashCode = hashCode * -1521134295 + Alpha.GetHashCode();
            hashCode = hashCode * -1521134295 + FontSize.GetHashCode();
            hashCode = hashCode * -1521134295 + Angle.GetHashCode();
            hashCode = hashCode * -1521134295 + OutlineWeight.GetHashCode();
            return hashCode;
        }
    }
}
