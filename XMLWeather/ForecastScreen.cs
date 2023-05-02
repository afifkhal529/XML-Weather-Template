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
        public ForecastScreen()
        {
            InitializeComponent();
            displayForecast();
        }

        public void displayForecast()
        {
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
            //max2.Text = Convert.ToDouble(Form1.days[1.temp])
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }

        private void label2_Click(object sender, EventArgs e)
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
    }
}
