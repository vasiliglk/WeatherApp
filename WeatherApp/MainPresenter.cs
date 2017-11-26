using System;

namespace WeatherApp
{
    public class MainPresenter
    {
        private readonly IMainForm _view;
        private readonly IDataService _data;
        public MainPresenter(IMainForm view, IDataService data)
        {
            this._view = view;
            this._data = data;
            
            _view.RefreshDataClick += ViewOnRefreshDataClick;
        }

        private void ViewOnRefreshDataClick(object sender, EventArgs eventArgs)
        {
            _data.GetDataFromService(_view.GetCityUrl(),false);
            _view.SetCities(_data.GetCities());
            _view.SetCurrrentCity(_data.GetCity());
            _view.SetHumidityForCurrrentDay(_data.GetHumidityForCurrrentDay());
            _view.SetMetCastForCurrrentDay(_data.GetMetCastForCurrrentDay());
            _view.SetPressureForCurrrentDay(_data.GetPressureForCurrrentDay());
            _view.SetTempForCurrrentDay(_data.GetTempForCurrrentDay());
            _view.SetTimeForCurrrentDay(_data.GetMorningTimeForCurrrentDay(), _data.GetEveningTimeForCurrrentDay());
            _view.SetWindForCurrrentDay(_data.GetWindForCurrrentDay(), _data.GetWindDirectionForCurrrentDay());
            _view.SetDayPanels(_data.GetDays());
        }
    }
}
