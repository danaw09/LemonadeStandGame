﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public static class UserInterface
    {
       

        internal static void GameOver()
        {
            Console.WriteLine("You have run out of money! Sorry the game is over....");
            Console.ReadKey();
        }
      internal static void GetGreet()
        {
            
            Console.WriteLine("Hello ");
            Console.WriteLine("These are rules to help you determine how to play.....");
            Console.WriteLine("You are the owner of a Lemonade Stand and you are responsible for purchasing all of your stock!");
            Console.WriteLine("Before you begin you will buy Cups, Lemons, Sugar and Ice to create your recipe.");
            Console.WriteLine("You will have 7 days to make as much money as you can.");
            Console.WriteLine("If sales are low, you may need to adjust your recipe based on the weather forecast to maximize your profits.");
            Console.WriteLine("Ready to play?....");
            Console.ReadLine();
            Console.Clear();
          //  MainMenu();
            


        }



       
    }
}
