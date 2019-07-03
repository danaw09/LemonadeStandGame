using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class game
    {
        public Random random;
        public Weather Weather;
        public player player;
        public store store;
        public day day;
        public int randomValue;

        public game()
        {
            random = new Random();
            Weather = new Weather(random);
            player = new player();
            store = new store();
            day = new day(random);
        }

        public void Startgame()
        {
            UserInterface.GetGreet();
            Weather.DisplayCurrentWeather();
            Weather.DisplayForecast();
        }

        private void GetInfo()
        {
            Console.WriteLine("Hello and Welcome");
        }
        
        

        public void MainMenu()
        {
    
        }



        
	}


        

        
    

}
