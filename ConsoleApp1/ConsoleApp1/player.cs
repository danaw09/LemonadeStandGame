using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class player
    {
        private int weeklyProfits;
        public inventory inventory;
        private string name;
        public RecipeBook recipeBook;


        public player()
        {
            inventory = new inventory();
            recipeBook = new RecipeBook();

        }

    }
}
