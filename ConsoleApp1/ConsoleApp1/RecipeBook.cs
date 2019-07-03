using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class RecipeBook
    {
        private int sugar = 10;
        private int cup = 10;
        private double lemonadePrice;
        public RecipeBook()
        {

        }

        public int LemonPrice { get; private set; } = 10;
        public int LemonPrice { get; private set; } = 10;

        public int SugarPrice
        {
            get { return sugar; }
            private set { sugar = value; }
        }
        public int IcePrice { get; private set; } = 10;
        public int CupPrice
        {
            get { return cup; }
            private set { cup = value; }
        }

        


}  }
