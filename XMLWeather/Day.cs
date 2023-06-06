using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XMLWeather
{
    public class Day
    {
        public string date, currentTemp, currentTime, condition, location, tempHigh, tempLow, 
            windSpeed, windDirection, windName, precipitation, visibility, humidity, weatherNumber, weatherValue;

        public Day()
        {
            date = currentTemp = currentTime = condition = location = tempHigh = tempLow
                = windSpeed = windDirection = windName = precipitation = visibility = humidity = weatherNumber = weatherValue = "";
        }
    }
}
