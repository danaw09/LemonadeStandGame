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
        private List<day> days;
        private int totalPlayDays;
        private decimal TotalCash;
        Random rnd = new Random();



        public void Startgame()
        {
           
        }

        private void GetInfo()
        {
            Console.WriteLine("Hello and Welcome");
        }
        
        public game()
        {
            GetInfo();
            player = new player();
            //player.
        }

        public void MainMenu()
        {
        
        }
        
	}


        

        
    

}
