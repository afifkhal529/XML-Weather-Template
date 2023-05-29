using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class ForecastScreen : UserControl
    {
        double outsideWeather;

        List<PictureBox> pictureBoxes = new List<PictureBox>();

        public ForecastScreen()
        {
            InitializeComponent();
            displayForecast();
        }

        public void displayForecast()
        {
            //adding weather images
            pictureBoxes.Add(icon1);
            pictureBoxes.Add(icon2);
            pictureBoxes.Add(icon3);
            pictureBoxes.Add(icon4);
            pictureBoxes.Add(icon5);

            day1.Text = Form1.days[1].date;
            day2.Text = Form1.days[2].date;
            day3.Text = Form1.days[3].date;
            day4.Text = Form1.days[4].date;
            day5.Text = Form1.days[5].date;

            max1.Text = Convert.ToDouble(Form1.days[1].tempHigh).ToString("#");
            min1.Text = Convert.ToDouble(Form1.days[1].tempLow).ToString("#");

            max2.Text = Convert.ToDouble(Form1.days[2].tempHigh).ToString("#");
            min2.Text = Convert.ToDouble(Form1.days[2].tempLow).ToString("#");

            max3.Text = Convert.ToDouble(Form1.days[3].tempHigh).ToString("#");
            min3.Text = Convert.ToDouble(Form1.days[3].tempHigh).ToString("#");

            max4.Text = Convert.ToDouble(Form1.days[4].tempHigh).ToString("#");
            min4.Text = Convert.ToDouble(Form1.days[4].tempHigh).ToString("#");

            max5.Text = Convert.ToDouble(Form1.days[5].tempHigh).ToString("#");
            min5.Text = Convert.ToDouble(Form1.days[5].tempHigh).ToString("#");
            

            if (outsideWeather < 300 && outsideWeather >= 200)
            {
                pictureBoxes[0].Image = Properties.Resources.thunderstorm;
            }
            else if (outsideWeather >= 300 && outsideWeather < 400)
            {
                pictureBoxes[0].Image = Properties.Resources.shower_rain;
            }
            else if (outsideWeather >= 500 && outsideWeather < 600)
            {
                pictureBoxes[0].Image = Properties.Resources.rain;
            }
            else if (outsideWeather >= 800)
            {
                pictureBoxes[0].Image = Properties.Resources.sunny;
            }
            else if (outsideWeather <= 80)
            {
                pictureBoxes[0].Image = Properties.Resources.scattered_clouds;
            }

            if (outsideWeather >= 300 && outsideWeather < 400)
            {
                pictureBoxes[1].Image = Properties.Resources.shower_rain;
            }
            else if (outsideWeather < 300 && outsideWeather >= 200)
            {
                pictureBoxes[1].Image = Properties.Resources.thunderstorm;
            }
            else if (outsideWeather >= 500 && outsideWeather < 600)
            {
                pictureBoxes[1].Image = Properties.Resources.rain;
            }
            else if (outsideWeather >= 800)
            {
                pictureBoxes[1].Image = Properties.Resources.sunny;
            }
            else if (outsideWeather <= 80)
            {
                pictureBoxes[1].Image = Properties.Resources.scattered_clouds;
            }

            if (outsideWeather >= 500 && outsideWeather < 600)
            {
                pictureBoxes[2].Image = Properties.Resources.rain;
            }
            else if (outsideWeather < 300 && outsideWeather >= 200)
            {
                pictureBoxes[2].Image = Properties.Resources.thunderstorm;
            }
            else if (outsideWeather >= 300 && outsideWeather < 400)
            {
                pictureBoxes[2].Image = Properties.Resources.shower_rain;
            }
            else if (outsideWeather >= 800)
            {
                pictureBoxes[2].Image = Properties.Resources.sunny;
            }
            else if (outsideWeather <= 80)
            {
                pictureBoxes[2].Image= Properties.Resources.scattered_clouds;
            }

            if (outsideWeather >= 800)
            {
                pictureBoxes[3].Image = Properties.Resources.sunny;
            }
            else if (outsideWeather >= 500 && outsideWeather <= 600)
            {
                pictureBoxes[3].Image= Properties.Resources.rain;
            }
            else if (outsideWeather < 300 && outsideWeather >= 200)
            {
                pictureBoxes[3].Image = Properties.Resources.thunderstorm;
            }
            else if (outsideWeather >= 300 && outsideWeather < 400)
            {
                pictureBoxes[3].Image = Properties.Resources.shower_rain;
            }
            else if (outsideWeather <= 80)
            {
                pictureBoxes[3].Image = Properties.Resources.scattered_clouds;
            }

            if (outsideWeather <= 80)
            {
                pictureBoxes[4].Image = Properties.Resources.scattered_clouds;
            }
            else if (outsideWeather >= 800)
            {
                pictureBoxes[4].Image = Properties.Resources.sunny;
            }
            else if (outsideWeather >= 500 && outsideWeather <= 600)
            {
                pictureBoxes[4].Image = Properties.Resources.rain;
            }
            else if (outsideWeather < 300 && outsideWeather >= 200)
            {
                pictureBoxes[4].Image = Properties.Resources.thunderstorm;
            }
            else if (outsideWeather >= 300 && outsideWeather < 400)
            {
                pictureBoxes[4].Image = Properties.Resources.shower_rain;
            }
            
        }

        private void currentForecast_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }

        private void weeklyForecast_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }

        private void searchLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            SearchScreen ss = new SearchScreen();
            f.Controls.Add(ss);
        }
        private void currentForecast_Click_1(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }
    }
}
