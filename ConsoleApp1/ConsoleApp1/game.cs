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
        private inventory inventory;

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
            // Weather.DisplayCurrentWeather();
            //
            Weather.DisplayForecast();
            MainMenu();
        }



        private void GetInfo()
        {
            Console.WriteLine("Hello and Welcome");
        }

        public void RePlayGame()
        {
            Console.WriteLine("Would you like to replay the game? [Y] or [N]");
            string answer = Console.ReadLine().ToUpper();
        }

        public void MainMenu()
        {
            Console.WriteLine(" type in the number of the menu item you would like to select.\n\n");
            Console.WriteLine("1: Rules\n\n2: Weather\n\n3: Check Wallet\n\n4: Run to the store\n\n5: Check inventory\n\n6: Check recipe and make Lemonade.\n\n7: Set price and play game");
            string value = Console.ReadLine();

            switch (value)
            {
                //Rules
                case "1":
                    Console.Clear();
                    UserInterface.GetGreet();
                    break;

                //Weather
                case "2":
                    Console.Clear();
                    Weather.DisplayCurrentWeather();
                    Weather.GetOvercast(random);
                    Console.WriteLine("please hit [enter] to go to the main meun.");
                    Console.ReadLine();
                    Console.Clear();
                    MainMenu();
                    break;

                //Wallet
                case "3":
                    Console.Clear();
                    player.CheckWallet();
                    Console.ReadLine();
                    Console.Clear();
                    MainMenu();
                    break;

                //store
                case "4":
                    Console.Clear();
                    store.GetItems(player);
                    Console.ReadLine();
                    Console.Clear();
                    MainMenu();
                    break;

                //inventory
                case "5":
                    Console.Clear();
                    player.inventory.Getnventory();
                    Console.ReadLine();
                    Console.Clear();
                    MainMenu();
                    break;

                //pitchers
                case "6":
                    Console.Clear();
                    player.inventory.Getnventory();
                    MainMenu();
                    Console.WriteLine("You now have {0} cups of lemonade!!");
                    //day.
                   
                    Console.ReadLine();
                    Console.Clear();
                    MainMenu();
                    break;

               
                case "7":
                     Console.Clear();
                    // day.PriceOfCup();
                    // for (int d = 1; d <= 7; d++)
                    // {

                    //     for (int i = 0; i < day.stopSelling; i++)
                    //     {
                    //         day.customers[i].DeterminesCustomerBuys(day.weather, day, randomValue);
                    //      }
                    player.CheckWallet();
                    Console.ReadLine();
                    RePlayGame();
                    MainMenu();
                    Console.Clear();
                     break;
                    default:
                     Console.WriteLine("Sorry, that we don't have an option for that.\n\n");
                     MainMenu();
                      break;




                    //      day.SellLemonade(player);

            }
                 


        }
    }




}	


        

        
    
    

