using System;
using System.Windows.Forms;

namespace WeatherApp
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            DataWeatherService dataService = new DataWeatherService();
            MainForm view = new MainForm();
            
            MainPresenter presenter = new MainPresenter(view,dataService);
            
            Application.Run(view);
        }
    }
}
