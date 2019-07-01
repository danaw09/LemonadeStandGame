using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Weather
    {
        private Random rnd;
        private int weatherOutside;
        private string descriptionOfWeather;

        public Weather(Random rnd)
        {
            this.rnd = rnd;
            GetTheWeather();
            descriptionOfWeather = GetTheConditions();
        }

        public string DescriptionOfWeather
        {
            get
            {
                return descriptionOfWeather;
            }
        }

        public int WeatherOutside
        {
            get
            {
                return weatherOutside;
            }
        }

        private void GetTheWeather()
        {
            weatherOutside = rnd.Next(45, 95);
        }

        public string GetTheConditions()
        {
            int result;
            List<string> conditions = new List<string>();
            conditions.Add("Sunny");
            conditions.Add("Cloudy");
            conditions.Add("Rainy");
            conditions.Add("Overcast");
            conditions.Add("Hazy");
            conditions.Add("Foggy");
            result = rnd.Next(0, conditions.Count - 1);
            return conditions[result].ToString();
        }
    }
}
