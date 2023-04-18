using System;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class CurrentScreen : UserControl
    {   

        public CurrentScreen()
        {
            InitializeComponent();
            DisplayCurrent();
        }

        public void DisplayCurrent()
        {
            cityOutput.Text = Form1.days[0].location;
            currentOutput.Text = Convert.ToDouble(Form1.days[0].currentTemp).ToString("#");
            minOutput.Text = Convert.ToDouble(Form1.days[1].tempLow).ToString("#");
            maxOutput.Text = Convert.ToDouble(Form1.days[2].tempHigh).ToString("#");
            dateLabel.Text = Form1.days[0].date;
            //minOutput.Text = Form1.days[1].tempLow;
            //maxOutput.Text = Convert.ToDouble(Form1.days[1].tempHigh).ToString("#");


        }



        private void forecastLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }
    }
}
