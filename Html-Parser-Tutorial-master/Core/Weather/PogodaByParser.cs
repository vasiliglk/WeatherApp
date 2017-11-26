using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngleSharp.Dom.Html;
using AngleSharp.Dom;
using Parser.Model;

namespace Parser.Core.Weather
{
    class PogodaByParser : IParser<string[]>
    {
        private List<string> d;

        public string[] Parse(IHtmlDocument document)
        {
            var positionInfoForDays = new List<int>();
            var result = new List<string>();

            

            var day = document.QuerySelectorAll("td").Where(item => item.ClassName != null && item.ClassName.Contains("dat"));
            var index = 0;
            foreach (var item in day)
            {
                if (item.TextContent.Contains("день"))
                {
                    result.Add(item.TextContent);
                    positionInfoForDays.Add(index);
                }
                index++;
            }

            var images = document.QuerySelectorAll("td.meteo img");
            foreach (var pos in positionInfoForDays)
            {
                result.Add(((IHtmlImageElement)images.ElementAt(pos)).Title);
            }


            var temps = document.QuerySelectorAll("td.meteo").Where(item => item.Attributes.Where(a => a.Value.Contains("Tmin")).Count() > 0);
            foreach (var pos in positionInfoForDays)
            {
                result.Add(temps.ElementAt(pos).TextContent);
            }

            var winds = document.QuerySelectorAll("td.meteo").Where(item => item.Attributes.Where(a => a.Value.Contains("км")).Count() > 0);
            foreach (var pos in positionInfoForDays)
            {
                result.Add(winds.ElementAt(pos).TextContent);
            }


            var press = document.QuerySelectorAll("td.meteo span");
            foreach (var pos in positionInfoForDays)
            {
                result.Add(press.ElementAt(pos).TextContent);
            }


            var hum = document.QuerySelectorAll("tr").Where(item => item.HasChildNodes && item.Children.Where(c => c.ClassName == "legend" && c.TextContent.Contains("Влажность")).Count() > 0);
            foreach (var pos in positionInfoForDays)
            {
                var ddd = hum.FirstOrDefault().Children;
                result.Add(ddd.Skip(2).ElementAt(pos).TextContent);
            }

            var time = document.QuerySelectorAll("p").Where(item => item.HasChildNodes && item.Children.Where(c => c.TagName.Contains("STRONG") && c.TextContent.Contains("Сумерки гражданские")).Count() > 0);

            result.Add(time.FirstOrDefault().TextContent.Replace("Сумерки гражданские", ""));

            return result.ToArray();
        }
    }
}
