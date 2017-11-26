using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using WeatherApp.ServiceReference1;

namespace WeatherApp
{
    public partial class MainForm : Form, IMainForm
    {
        #region Extern
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;


        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void AddDrag(Control control)
        {
            control.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragForm_MouseDown);
        }
        private void DragForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                if (this.Location.Y == 0) { this.WindowState = FormWindowState.Maximized; }
            }
        }
        #endregion
        public MainForm()
        {
            InitializeComponent();
            InitLabelControl(curTemp, curMetcast, curCity);
            AddDrag(headPanel);
        }
        
        #region Form
        private void InitLabelControl(params Label[] labels)
        {
            foreach (Label label in labels)
            {
                var pos = this.PointToScreen(label.Location);
                pos = picMain.PointToClient(pos);
                label.Parent = picMain;
                label.Location = pos;
                label.BackColor = Color.Transparent;
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshDataClick?.Invoke(this, EventArgs.Empty);
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            RefreshDataClick?.Invoke(this, EventArgs.Empty);
        }
        private void cmbCities_SelectedValueChanged(object sender, EventArgs e)
        {
            SetCurrrentCity((cmbCities?.SelectedItem as Cities)?.Name);
            RefreshDataClick?.Invoke(this, EventArgs.Empty);
        }
        #endregion

        #region Private
        private Image GetImage(string metcast)
        {
            Image image = null;
            var mainImage = "cloud.jpg";
            if (metcast.Contains("Сплошная облачность\r\nНебольшой мокрый снег"))
            {
                image = Image.FromFile(FilePath("snowing.png"));
                mainImage = "snowing.jpg";
            }
            if (metcast.Contains("Облачно с прояснениями\r\nБез осадков"))
            {
                image = Image.FromFile(FilePath("cloudy.png"));
                mainImage = "sun.jpg";
            }
            if (metcast.Contains("Сплошная облачность\r\nБез осадков")|| metcast.Contains("Сплошная облачность\r\nБез осадков\r\nТуман\r\nВидимость 50-100 м\r\n"))
            {
                image = Image.FromFile(FilePath("cloud.png"));
                mainImage = "cloud.jpg";
            }
            if (metcast.Contains("Сплошная облачность\r\nНебольшой дождь") ||
                metcast.Contains("Сплошная облачность\r\nВозможен дождь\r\n") || metcast.Contains("Сплошная облачность\r\nМокрый снег\r\n")|| metcast.Contains("Сплошная облачность\r\nСильный мокрый снег\r\n")|| metcast.Contains("Сплошная облачность\r\nДождь\r\n"))
            {
                image = Image.FromFile(FilePath("rain-cloud.png"));
                mainImage = "cloud.jpg";
            }
            SetMainImage(mainImage);
            return image;
        }
        private void SetMainImage(string image)
        {
            try
            {
                if (DateTime.Now.Hour > 6 && DateTime.Now.Hour < 19)
                {
                    var path = FilePath(image);
                    picMain.BackgroundImage = Image.FromFile(path);
                }
                else
                {
                    picMain.BackgroundImage = Image.FromFile(FilePath("mqdefault.jpg"));
                }
            }
            catch (Exception ex)
            {
            }
        }
        private string FilePath(string fileName)
        {
            return Path.Combine(Path.Combine(Environment.CurrentDirectory, "Images"), fileName);
        }
        #endregion

        #region Interface
        public void SetTempForCurrrentDay(string temp)
        {
            this.curDayTemp.Text = temp;
            this.curTemp.Text = temp;
        }
        public void SetHumidityForCurrrentDay(string humidity)
        {
            this.curDayHum.Text = $"{humidity}%";
        }
        public void SetPressureForCurrrentDay(string pressure)
        {
            this.curDayPress.Text = pressure;
        }
        public void SetWindForCurrrentDay(string wind, string windDirection)
        {
            this.curDayWind.Text = $"{wind} м/с";
            this.curDayWindDir.Text = windDirection;
        }
        public void SetTimeForCurrrentDay(string morningTime, string eveningTime)
        {
            this.curDayMorn.Text = morningTime;
            this.curDayEven.Text = eveningTime;
        }
        public void SetMetCastForCurrrentDay(string metcast)
        {
            this.curMetcast.Text = metcast;
        }
        public void SetCurrrentCity(string city)
        {
            this.curCity.Text = city;
        }
        public void SetDayPanels(List<DayMeteoInfo> days)
        {
            SetDayPanels(days.Count, days);
        }
        public void SetDayPanels(int countPanels, List<DayMeteoInfo> days)
        {
            var numPanel = 1;
            foreach (var day in days.Take(countPanels))
            {
                SetDayPanel(numPanel++, day.Metcast, day.Temperature, day.Day);
            }
        }
        public void SetDayPanel(int numPanel, string metcast, string temp, string date)
        {
            var namePanel = $"dayPanel{numPanel}";
            var panel = this.Controls.Find(namePanel, true).FirstOrDefault();
            var dayPic = panel.Controls.Find($"dayPic{numPanel}", false).FirstOrDefault() as PictureBox;
            var dayTemp = panel.Controls.Find($"dayTemp{numPanel}", false).FirstOrDefault() as Label;
            var dayDate = panel.Controls.Find($"dayDate{numPanel}", false).FirstOrDefault() as Label;

            if (dayPic != null)
            {
                dayPic.BackgroundImage = GetImage(metcast);
            }
            if (dayTemp != null)
            {
                dayTemp.Text = temp;
            }
            if (dayDate != null)
            {
                dayDate.Text = date;
            }
        }
        public void SetCities(Cities[] cities)
        {
            cmbCities.Items.AddRange(cities);
            cmbCities.DisplayMember = "Name";
        }
        public string GetCity()
        {
            var city = (cmbCities.SelectedItem as Cities)??new Cities() {Name = "Минск", Url = ""};
            return city.Url??"";
        }

        public event EventHandler RefreshDataClick;


        #endregion


    }
}
