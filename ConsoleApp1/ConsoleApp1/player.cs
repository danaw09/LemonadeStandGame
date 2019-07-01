using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class player
    {
        private int weeklyCash;
        public inventory inventory;
        public string name;
        public RecipeBook recipeBook;
        private float currentCash;
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

 }   }
