using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Weather
    {
        public string temperature;
        public string condition;
        private Random random;
        

        public Weather(Random random)
        {
            this.random = random;
        }

        public int GetTemp(Random rnd)
        {
            int temperature = rnd.Next(1, 4);

            switch (temperature)
            {
                case 1:
                    this.temperature = "Hot";
                    break;
                case 2:
                    this.temperature = "Warm";
                    break;
                case 3:
                    this.temperature = "Cold";
                    break;
                default:
                    Console.WriteLine("There was an error getting the report");
                    break;
            }
            return temperature;
        }



        public int GetOvercast(Random rnd)
        {
            int condition = rnd.Next(1, 4);

            switch (condition)
            {
                case 1:
                    this.condition = "and sunny";
                    break;
                case 2:
                    this.condition = "and cloudy";
                    break;
                case 3:
                    this.condition = "with thunderstorms";
                    break;
                default:
                    Console.WriteLine("There was an error getting the report");
                    break;
            }
            return condition;
        }
        public void DisplayCurrentWeather()
        {
            
            Console.WriteLine($"Today's forcast is: {80} sunny \n");
        }
        public void DisplayForecast()
        {
            
            Console.WriteLine($"The weather for tomorrow is: {80} sunny \n");

        }

        public void Current()
        {
            List<string> weatherForcase = new List<string> { "Tomorrow's", "The next day's", "And the day after that's" };
           

            {
                GetOvercast(random);
                GetTemp(random);
               
            }


        }

    }
}


        

