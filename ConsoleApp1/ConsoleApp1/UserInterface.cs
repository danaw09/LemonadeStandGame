using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public class UserInterface
    {

        internal static void GameOver()
        {
            Console.WriteLine("You have run out of money! Sorry the game is over....");
            Console.ReadKey();
        }
        public static void DisplayGreet(player player)
        {
            
            Console.WriteLine("Hello " + player.name + "!");
            Console.WriteLine();
            Console.WriteLine("These are rules to help you determine how to play.....");
            Console.WriteLine("You are the owner of a Lemonade Stand and you are responsible for purchasing all of your stock!");
            Console.WriteLine("Before you begin you will buy Cups, Lemons, Sugar and Ice to create your recipe.");
            Console.WriteLine("After the day is over, you will need to re-stock your supplies and see how much you made.");
            Console.WriteLine("If sales were low, you may need to adjust your recipe based on the weather forecast to maximize your profits.");
            Console.WriteLine("Ready to play?....");
            Console.WriteLine();
            


        }



       
    }
}
