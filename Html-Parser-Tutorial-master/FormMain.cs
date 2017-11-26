using Parser.Core;
using Parser.Core.Weather;
using Parser.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parser
{
    public partial class FormMain : Form
    {
        ParserWorker<string[]> parser;
        MeteoInfo meteoInfo = new MeteoInfo();

        public FormMain()
        {
            InitializeComponent();

            parser = new ParserWorker<string[]>(
                    new PogodaByParser()
                );

            parser.OnCompleted += Parser_OnCompleted;
            parser.OnNewData += Parser_OnNewData;
        }

        private void Parser_OnNewData(object arg1, string[] arg2)
        {
            var days = new List<DayMeteoInfo>();
            int daysCount = (arg2.Length - 1) / 6;
            for (int day = 0; day < daysCount; day++)
            {
                meteoInfo.Days.Add(Parse(day, daysCount, arg2));
            }
            meteoInfo.MorningTime = arg2.Last().Split(',')[0].Replace("Начало:","").Trim();
            meteoInfo.EveningTime = arg2.Last().Split(',')[1].Replace("конец:", "").Trim();
            ListTitles.Items.AddRange(arg2);
            
        }

        private DayMeteoInfo Parse(int numDay,int countDay, string[] data)
        {
            var day = new DayMeteoInfo()
            {
                Day = data[numDay],
                Metcast = data[numDay + countDay],
                Temperature = data[numDay + countDay*2],
                Wind = data[numDay + countDay*3],
                Pressure = data[numDay + countDay*4],
                Humidity = data[numDay + countDay*5]
            };

            return day;
        }

        private void Parser_OnCompleted(object obj)
        {
            MessageBox.Show("All works done!");
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            parser.Settings = new PogodaBySettings((int)NumericStart.Value, (int)NumericEnd.Value);
            parser.Start();
        }

        private void ButtonAbort_Click(object sender, EventArgs e)
        {
            parser.Abort();
        }
    }
}
