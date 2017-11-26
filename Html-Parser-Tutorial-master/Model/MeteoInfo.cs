using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser.Model
{
    public class MeteoInfo
    {
        public List<DayMeteoInfo> Days { get; set; } = new List<DayMeteoInfo>();
        public string MorningTime { get; set; }
        public string EveningTime { get; set; }
    }
}
