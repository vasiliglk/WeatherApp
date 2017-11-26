using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using WeatherApp.ServiceReference1;

namespace WeatherApp
{
    public class DataWeatherService : IDataService
    {
        private  MeteoInfo _meteo;
        private  Cities[] _cities;
        public DataWeatherService()
        {
            GetDataFromService("/",true);
        }

        public void GetDataFromService(string urlCity, bool isCities)
        {
            var client = new WeatherServiceClient("BasicHttpBinding_IWeatherService");
            if (client.State == CommunicationState.Created)
            {
                if (isCities)
                {
                    this._cities = client.GetCities();
                }
                this._meteo = client.GetWeather(urlCity);
                //в случае отказа сервера в получении текущей даты
                if (this._meteo.CurrentDay==null)
                {
                    this._meteo.CurrentDay = this._meteo.Days.FirstOrDefault(day => day.Day.Contains(DateTime.Now.ToString("dd MMMM")))?? this._meteo.Days.FirstOrDefault(day => day.Day.Contains(DateTime.Now.AddDays(1).ToString("dd MMMM")));
                }
            }
        }
        public string GetCity()
        {
            return _meteo.CurrentCity;
        }

        public string GetHumidityForCurrrentDay()
        {
            return _meteo.CurrentDay.Humidity;
        }

        public string GetMetCastForCurrrentDay()
        {
            return _meteo.CurrentDay.Metcast;
        }

        public string GetPressureForCurrrentDay()
        {
            return _meteo.CurrentDay.Pressure;
        }

        public string GetWindForCurrrentDay()
        {
            return _meteo.CurrentDay.Wind;
        }

        public string GetTempForCurrrentDay()
        {
            return _meteo.CurrentDay.Temperature;
        }

        public string GetEveningTimeForCurrrentDay()
        {
            return _meteo.EveningTime;
        }

        public string GetMorningTimeForCurrrentDay()
        {
            return _meteo.MorningTime;
        }

        public string GetWindDirectionForCurrrentDay()
        {
            return _meteo.CurrentDay.WindDirection;
        }

        public List<DayMeteoInfo> GetDays()
        {
            return _meteo.Days.ToList();
        }

        public Cities[] GetCities()
        {
            return _cities;
        }
    }
}
