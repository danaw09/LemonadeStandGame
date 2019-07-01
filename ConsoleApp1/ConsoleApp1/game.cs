using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class game
    {
        private player player;
        private store store;
        private List<Day> days;
        private int totalPlayDays;
        private decimal TotalCash;
        Random rnd = new Random();


    public Game ()
	{
        DisplayIntro();
        player = new Player();
        player.GetUserName();
        store = new store();
        totalDaysPlay = 7;
        days = new List<Day>()
        {
         new Day(rnd) { Name = "Monday", Number = 1, weather = new Weather(rnd), report = new Report(player) },
         new Day(rnd) { Name = "Tuesday", Number = 2, weather = new Weather(rnd), report = new Report(player) },
         new Day(rnd) { Name = "Wenesday", Number = 3, weather = new Weather(rnd), report = new Report(player) },
         new Day(rnd) { Name = "Thrusday", Number = 4, weather = new Weather(rnd), report = new Report(player) },
          new Day(rnd) { Name = "Friday", Number = 4, weather = new Weather(rnd), report = new Report(player) }

        };
	}


        private void DisplayIntro()
        {
            Console.WriteLine("Welcome to Lemonade Stand!");
        }

        public void StartGame()
        {
           DisplayIntro();
        }
    }

}
