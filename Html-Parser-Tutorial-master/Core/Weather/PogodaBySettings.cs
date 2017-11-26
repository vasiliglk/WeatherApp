
namespace Parser.Core.Weather
{
    class PogodaBySettings : IParserSettings
    {
        public PogodaBySettings(int start, int end)
        {
            StartPoint = start;
            EndPoint = end;
        }

        public string BaseUrl { get; set; } = "http://pogoda.by";

        public string Prefix { get; set; } = "";

        public int StartPoint { get; set; } = 1;

        public int EndPoint { get; set; } = 1;
    }
}
