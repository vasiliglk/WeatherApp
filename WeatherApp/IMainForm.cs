using System;
using System.Collections.Generic;
using WeatherApp.ServiceReference1;

namespace WeatherApp
{
    public interface IMainForm
    {
        void SetTempForCurrrentDay(string temp);
        void SetHumidityForCurrrentDay(string humidity);
        void SetPressureForCurrrentDay(string pressure);
        void SetWindForCurrrentDay(string wind, string windDirection);
        void SetTimeForCurrrentDay(string morningTime, string eveningTime);
        void SetMetCastForCurrrentDay(string metcast);
        void SetCurrrentCity(string city);
        void SetDayPanels(List<DayMeteoInfo> days);
        void SetDayPanels(int countPanels, List<DayMeteoInfo> days);
        void SetDayPanel(int numPanel, string metcast, string temp, string date);
        void SetCities(Cities[] cities);
        string GetCity();
        event EventHandler RefreshDataClick;
    }
}
