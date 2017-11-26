using System.Collections.Generic;
using WeatherApp.ServiceReference1;

namespace WeatherApp
{
    public interface IDataService
    {
        void GetDataFromService(string urlCity, bool isCities);
        string GetCity();
        string GetHumidityForCurrrentDay();
        string GetMetCastForCurrrentDay();
        string GetPressureForCurrrentDay();
        string GetWindForCurrrentDay();
        string GetTempForCurrrentDay();
        string GetEveningTimeForCurrrentDay();
        string GetMorningTimeForCurrrentDay();
        string GetWindDirectionForCurrrentDay();
        List<DayMeteoInfo> GetDays();
        Cities[] GetCities();
    }
}