namespace WeatherApp
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.headPanel = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.curTemp = new System.Windows.Forms.Label();
            this.curMetcast = new System.Windows.Forms.Label();
            this.curCity = new System.Windows.Forms.Label();
            this.picMain = new System.Windows.Forms.PictureBox();
            this.label20 = new System.Windows.Forms.Label();
            this.curDayHum = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.curDayMorn = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.curDayEven = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.curDayPress = new System.Windows.Forms.Label();
            this.curDayWindDir = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.curDayWind = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.curDayTemp = new System.Windows.Forms.Label();
            this.dayPanel1 = new System.Windows.Forms.Panel();
            this.dayPic1 = new System.Windows.Forms.PictureBox();
            this.dayDate1 = new System.Windows.Forms.Label();
            this.dayTemp1 = new System.Windows.Forms.Label();
            this.dayPanel3 = new System.Windows.Forms.Panel();
            this.dayPic3 = new System.Windows.Forms.PictureBox();
            this.dayDate3 = new System.Windows.Forms.Label();
            this.dayTemp3 = new System.Windows.Forms.Label();
            this.dayPanel2 = new System.Windows.Forms.Panel();
            this.dayPic2 = new System.Windows.Forms.PictureBox();
            this.dayDate2 = new System.Windows.Forms.Label();
            this.dayTemp2 = new System.Windows.Forms.Label();
            this.cmbCities = new System.Windows.Forms.ComboBox();
            this.headPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).BeginInit();
            this.dayPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dayPic1)).BeginInit();
            this.dayPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dayPic3)).BeginInit();
            this.dayPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dayPic2)).BeginInit();
            this.SuspendLayout();
            // 
            // headPanel
            // 
            this.headPanel.Controls.Add(this.cmbCities);
            this.headPanel.Controls.Add(this.btnRefresh);
            this.headPanel.Controls.Add(this.btnClose);
            this.headPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headPanel.Location = new System.Drawing.Point(0, 0);
            this.headPanel.Name = "headPanel";
            this.headPanel.Size = new System.Drawing.Size(443, 48);
            this.headPanel.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe MDL2 Assets", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(351, 8);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(37, 30);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe MDL2 Assets", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(394, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(37, 30);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // curTemp
            // 
            this.curTemp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.curTemp.AutoSize = true;
            this.curTemp.BackColor = System.Drawing.Color.Transparent;
            this.curTemp.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.curTemp.ForeColor = System.Drawing.Color.White;
            this.curTemp.Location = new System.Drawing.Point(107, 57);
            this.curTemp.Name = "curTemp";
            this.curTemp.Size = new System.Drawing.Size(0, 86);
            this.curTemp.TabIndex = 1;
            // 
            // curMetcast
            // 
            this.curMetcast.AutoSize = true;
            this.curMetcast.BackColor = System.Drawing.Color.Transparent;
            this.curMetcast.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.curMetcast.ForeColor = System.Drawing.Color.White;
            this.curMetcast.Location = new System.Drawing.Point(133, 156);
            this.curMetcast.Name = "curMetcast";
            this.curMetcast.Size = new System.Drawing.Size(0, 21);
            this.curMetcast.TabIndex = 1;
            this.curMetcast.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // curCity
            // 
            this.curCity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.curCity.AutoSize = true;
            this.curCity.BackColor = System.Drawing.Color.Transparent;
            this.curCity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.curCity.ForeColor = System.Drawing.Color.White;
            this.curCity.Location = new System.Drawing.Point(188, 221);
            this.curCity.Name = "curCity";
            this.curCity.Size = new System.Drawing.Size(0, 21);
            this.curCity.TabIndex = 1;
            this.curCity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picMain
            // 
            this.picMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picMain.BackgroundImage")));
            this.picMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picMain.Location = new System.Drawing.Point(0, 57);
            this.picMain.Name = "picMain";
            this.picMain.Size = new System.Drawing.Size(443, 198);
            this.picMain.TabIndex = 3;
            this.picMain.TabStop = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(51, 574);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(84, 20);
            this.label20.TabIndex = 23;
            this.label20.Text = "Влажность";
            // 
            // curDayHum
            // 
            this.curDayHum.AutoSize = true;
            this.curDayHum.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.curDayHum.ForeColor = System.Drawing.Color.White;
            this.curDayHum.Location = new System.Drawing.Point(48, 537);
            this.curDayHum.Name = "curDayHum";
            this.curDayHum.Size = new System.Drawing.Size(69, 37);
            this.curDayHum.TabIndex = 24;
            this.curDayHum.Text = "89%";
            this.curDayHum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(186, 574);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(58, 20);
            this.label18.TabIndex = 25;
            this.label18.Text = "Восход";
            // 
            // curDayMorn
            // 
            this.curDayMorn.AutoSize = true;
            this.curDayMorn.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.curDayMorn.ForeColor = System.Drawing.Color.White;
            this.curDayMorn.Location = new System.Drawing.Point(183, 537);
            this.curDayMorn.Name = "curDayMorn";
            this.curDayMorn.Size = new System.Drawing.Size(83, 37);
            this.curDayMorn.TabIndex = 26;
            this.curDayMorn.Text = "08:15";
            this.curDayMorn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(321, 574);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 20);
            this.label16.TabIndex = 27;
            this.label16.Text = "Заход";
            // 
            // curDayEven
            // 
            this.curDayEven.AutoSize = true;
            this.curDayEven.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.curDayEven.ForeColor = System.Drawing.Color.White;
            this.curDayEven.Location = new System.Drawing.Point(318, 537);
            this.curDayEven.Name = "curDayEven";
            this.curDayEven.Size = new System.Drawing.Size(83, 37);
            this.curDayEven.TabIndex = 28;
            this.curDayEven.Text = "17:05";
            this.curDayEven.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(321, 497);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 20);
            this.label14.TabIndex = 29;
            this.label14.Text = "Давление";
            // 
            // curDayPress
            // 
            this.curDayPress.AutoSize = true;
            this.curDayPress.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.curDayPress.ForeColor = System.Drawing.Color.White;
            this.curDayPress.Location = new System.Drawing.Point(318, 460);
            this.curDayPress.Name = "curDayPress";
            this.curDayPress.Size = new System.Drawing.Size(62, 37);
            this.curDayPress.TabIndex = 30;
            this.curDayPress.Text = "734";
            this.curDayPress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // curDayWindDir
            // 
            this.curDayWindDir.AutoSize = true;
            this.curDayWindDir.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.curDayWindDir.ForeColor = System.Drawing.Color.White;
            this.curDayWindDir.Location = new System.Drawing.Point(229, 497);
            this.curDayWindDir.Name = "curDayWindDir";
            this.curDayWindDir.Size = new System.Drawing.Size(33, 20);
            this.curDayWindDir.TabIndex = 31;
            this.curDayWindDir.Text = "ЮЗ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(186, 497);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 20);
            this.label12.TabIndex = 32;
            this.label12.Text = "Ветер";
            // 
            // curDayWind
            // 
            this.curDayWind.AutoSize = true;
            this.curDayWind.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.curDayWind.ForeColor = System.Drawing.Color.White;
            this.curDayWind.Location = new System.Drawing.Point(183, 460);
            this.curDayWind.Name = "curDayWind";
            this.curDayWind.Size = new System.Drawing.Size(88, 37);
            this.curDayWind.TabIndex = 33;
            this.curDayWind.Text = "3 м/с ";
            this.curDayWind.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(51, 497);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 20);
            this.label10.TabIndex = 34;
            this.label10.Text = "Температура";
            // 
            // curDayTemp
            // 
            this.curDayTemp.AutoSize = true;
            this.curDayTemp.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.curDayTemp.ForeColor = System.Drawing.Color.White;
            this.curDayTemp.Location = new System.Drawing.Point(48, 460);
            this.curDayTemp.Name = "curDayTemp";
            this.curDayTemp.Size = new System.Drawing.Size(47, 37);
            this.curDayTemp.TabIndex = 35;
            this.curDayTemp.Text = "24";
            this.curDayTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dayPanel1
            // 
            this.dayPanel1.BackColor = System.Drawing.Color.Transparent;
            this.dayPanel1.Controls.Add(this.dayPic1);
            this.dayPanel1.Controls.Add(this.dayDate1);
            this.dayPanel1.Controls.Add(this.dayTemp1);
            this.dayPanel1.Location = new System.Drawing.Point(24, 268);
            this.dayPanel1.Name = "dayPanel1";
            this.dayPanel1.Size = new System.Drawing.Size(125, 179);
            this.dayPanel1.TabIndex = 22;
            this.dayPanel1.Tag = "dayPanel";
            // 
            // dayPic1
            // 
            this.dayPic1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.dayPic1.Location = new System.Drawing.Point(26, 13);
            this.dayPic1.Name = "dayPic1";
            this.dayPic1.Size = new System.Drawing.Size(75, 68);
            this.dayPic1.TabIndex = 0;
            this.dayPic1.TabStop = false;
            // 
            // dayDate1
            // 
            this.dayDate1.AutoSize = true;
            this.dayDate1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dayDate1.ForeColor = System.Drawing.Color.White;
            this.dayDate1.Location = new System.Drawing.Point(7, 119);
            this.dayDate1.Name = "dayDate1";
            this.dayDate1.Size = new System.Drawing.Size(0, 21);
            this.dayDate1.TabIndex = 1;
            this.dayDate1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dayTemp1
            // 
            this.dayTemp1.AutoSize = true;
            this.dayTemp1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dayTemp1.ForeColor = System.Drawing.Color.White;
            this.dayTemp1.Location = new System.Drawing.Point(20, 87);
            this.dayTemp1.Name = "dayTemp1";
            this.dayTemp1.Size = new System.Drawing.Size(0, 32);
            this.dayTemp1.TabIndex = 1;
            this.dayTemp1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dayPanel3
            // 
            this.dayPanel3.BackColor = System.Drawing.Color.Transparent;
            this.dayPanel3.Controls.Add(this.dayPic3);
            this.dayPanel3.Controls.Add(this.dayDate3);
            this.dayPanel3.Controls.Add(this.dayTemp3);
            this.dayPanel3.Location = new System.Drawing.Point(294, 268);
            this.dayPanel3.Name = "dayPanel3";
            this.dayPanel3.Size = new System.Drawing.Size(125, 179);
            this.dayPanel3.TabIndex = 21;
            this.dayPanel3.Tag = "dayPanel";
            // 
            // dayPic3
            // 
            this.dayPic3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.dayPic3.Location = new System.Drawing.Point(26, 13);
            this.dayPic3.Name = "dayPic3";
            this.dayPic3.Size = new System.Drawing.Size(75, 68);
            this.dayPic3.TabIndex = 0;
            this.dayPic3.TabStop = false;
            // 
            // dayDate3
            // 
            this.dayDate3.AutoSize = true;
            this.dayDate3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dayDate3.ForeColor = System.Drawing.Color.White;
            this.dayDate3.Location = new System.Drawing.Point(30, 119);
            this.dayDate3.Name = "dayDate3";
            this.dayDate3.Size = new System.Drawing.Size(0, 21);
            this.dayDate3.TabIndex = 1;
            this.dayDate3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dayTemp3
            // 
            this.dayTemp3.AutoSize = true;
            this.dayTemp3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dayTemp3.ForeColor = System.Drawing.Color.White;
            this.dayTemp3.Location = new System.Drawing.Point(25, 87);
            this.dayTemp3.Name = "dayTemp3";
            this.dayTemp3.Size = new System.Drawing.Size(0, 32);
            this.dayTemp3.TabIndex = 1;
            this.dayTemp3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dayPanel2
            // 
            this.dayPanel2.BackColor = System.Drawing.Color.Transparent;
            this.dayPanel2.Controls.Add(this.dayPic2);
            this.dayPanel2.Controls.Add(this.dayDate2);
            this.dayPanel2.Controls.Add(this.dayTemp2);
            this.dayPanel2.Location = new System.Drawing.Point(159, 268);
            this.dayPanel2.Name = "dayPanel2";
            this.dayPanel2.Size = new System.Drawing.Size(125, 179);
            this.dayPanel2.TabIndex = 20;
            this.dayPanel2.Tag = "dayPanel";
            // 
            // dayPic2
            // 
            this.dayPic2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.dayPic2.Location = new System.Drawing.Point(26, 13);
            this.dayPic2.Name = "dayPic2";
            this.dayPic2.Size = new System.Drawing.Size(75, 68);
            this.dayPic2.TabIndex = 0;
            this.dayPic2.TabStop = false;
            // 
            // dayDate2
            // 
            this.dayDate2.AutoSize = true;
            this.dayDate2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dayDate2.ForeColor = System.Drawing.Color.White;
            this.dayDate2.Location = new System.Drawing.Point(21, 119);
            this.dayDate2.Name = "dayDate2";
            this.dayDate2.Size = new System.Drawing.Size(0, 21);
            this.dayDate2.TabIndex = 1;
            this.dayDate2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dayTemp2
            // 
            this.dayTemp2.AutoSize = true;
            this.dayTemp2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dayTemp2.ForeColor = System.Drawing.Color.White;
            this.dayTemp2.Location = new System.Drawing.Point(20, 87);
            this.dayTemp2.Name = "dayTemp2";
            this.dayTemp2.Size = new System.Drawing.Size(0, 32);
            this.dayTemp2.TabIndex = 1;
            this.dayTemp2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbCities
            // 
            this.cmbCities.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.cmbCities.ForeColor = System.Drawing.Color.White;
            this.cmbCities.FormattingEnabled = true;
            this.cmbCities.Location = new System.Drawing.Point(12, 12);
            this.cmbCities.Name = "cmbCities";
            this.cmbCities.Size = new System.Drawing.Size(156, 21);
            this.cmbCities.TabIndex = 4;
            this.cmbCities.SelectedValueChanged += new System.EventHandler(this.cmbCities_SelectedValueChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(443, 643);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.curDayHum);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.curDayMorn);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.curDayEven);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.curDayPress);
            this.Controls.Add(this.curDayWindDir);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.curDayWind);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.curDayTemp);
            this.Controls.Add(this.dayPanel1);
            this.Controls.Add(this.dayPanel3);
            this.Controls.Add(this.dayPanel2);
            this.Controls.Add(this.curCity);
            this.Controls.Add(this.curMetcast);
            this.Controls.Add(this.curTemp);
            this.Controls.Add(this.headPanel);
            this.Controls.Add(this.picMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(443, 643);
            this.MinimumSize = new System.Drawing.Size(443, 643);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WeatherApp";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.headPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).EndInit();
            this.dayPanel1.ResumeLayout(false);
            this.dayPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dayPic1)).EndInit();
            this.dayPanel3.ResumeLayout(false);
            this.dayPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dayPic3)).EndInit();
            this.dayPanel2.ResumeLayout(false);
            this.dayPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dayPic2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel headPanel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label curTemp;
        private System.Windows.Forms.Label curMetcast;
        private System.Windows.Forms.Label curCity;
        private System.Windows.Forms.PictureBox picMain;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label curDayHum;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label curDayMorn;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label curDayEven;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label curDayPress;
        private System.Windows.Forms.Label curDayWindDir;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label curDayWind;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label curDayTemp;
        private System.Windows.Forms.Panel dayPanel1;
        private System.Windows.Forms.PictureBox dayPic1;
        private System.Windows.Forms.Label dayDate1;
        private System.Windows.Forms.Label dayTemp1;
        private System.Windows.Forms.Panel dayPanel3;
        private System.Windows.Forms.PictureBox dayPic3;
        private System.Windows.Forms.Label dayDate3;
        private System.Windows.Forms.Label dayTemp3;
        private System.Windows.Forms.Panel dayPanel2;
        private System.Windows.Forms.PictureBox dayPic2;
        private System.Windows.Forms.Label dayDate2;
        private System.Windows.Forms.Label dayTemp2;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ComboBox cmbCities;
    }
}

