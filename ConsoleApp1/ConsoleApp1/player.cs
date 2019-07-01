using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class player
    {
        private float weeklyProfits;
        public inventory inventory;
        public string name;
        public RecipeBook recipeBook;
        public float currentCash;
        private int overallCashRd;


        public player()
        {
            inventory = new inventory();
            recipeBook = new RecipeBook();
            currentCash = 25.00f;

        }

        public string GetUserInfo()
        {
            Console.WriteLine("enter name");
            name = Console.ReadLine();
            return name;
        }
        internal void CheckWallet()
        {
            if (currentCash <= 0)
            {
                UserInterface.GameOver();
                Environment.Exit(0);
            }
            else
            {
                return;
            }
        }
        public float CashOnHand
        {
            get
            {
                return currentCash;
            }
            set
            {
                currentCash = value;
            }

        }

        public float WeeklyProfits
        {
            get
            {
                return weeklyProfits;
            }
            set
            {
                weeklyProfits = value;
            }
        }





    }
}


