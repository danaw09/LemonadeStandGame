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

        }
	}


        private void DisplayIntro()
        {
            Console.WriteLine("Welcome to Lemonade Stand!");
        }

        public void StartGame()
        {
           
        }
    }

}
