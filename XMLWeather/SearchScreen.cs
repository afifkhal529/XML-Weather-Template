using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class SearchScreen : UserControl
    {
        public SearchScreen()
        {
            InitializeComponent();

            errorLabel.ForeColor = Color.CadetBlue;
            errorLabel.Text = $"Suggested Searches:";
            errorLabel.Text += "- Waterloo\n";
            errorLabel.Text += "- Whitby\n";
            errorLabel.Text += "- Vancouver\n";
            errorLabel.Text += "- New York\n";
            errorLabel.Text += "- Las Vegas\n";
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

        private void searchButton_Click(object sender, EventArgs e)
        {
            Form1.oldLocation = Form1.location;
            try
            {
                Form1.location = inputBox.Text;
                Form1.days.Clear();
                Form1.ExtractForecast();
                Form1.ExtractCurrent();

                Form s = this.FindForm();
                s.Controls.Remove(this);
                CurrentScreen fs = new CurrentScreen();
                s.Controls.Add(fs);
            }
            catch
            {
                inputBox.Text = "";
                errorLabel.ForeColor = Color.Brown;
                errorLabel.Text = "Input not valid";
                Form1.location = Form1.oldLocation;
                Form1.ExtractForecast();
                Form1.ExtractCurrent();
            }
        }
    }
}
