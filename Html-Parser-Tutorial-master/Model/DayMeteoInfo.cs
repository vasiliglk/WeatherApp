using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser.Model
{
    public class DayMeteoInfo
    {
        public string Day { get; set; }
        public string Metcast { get; set; }
        public string Temperature { get; set; }
        public string Wind { get; set; }
        public string Pressure { get; set; }
        public string Humidity { get; set; }
    }
}
