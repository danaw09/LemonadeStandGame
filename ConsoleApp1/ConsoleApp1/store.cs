using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class store
    {
        

        internal void GetItems(player player)
        {

            Console.WriteLine("Pick between [1] for Lemons, [2] for Sugar, [3] for Ice, [4] for Cups, or hit [ENTER] to take you back to the Main Menu. \n\n");

            string need = Console.ReadLine().ToLower();
            switch (need)
            {
                case "l":
                    NeedLemons(player);
                    break;
                case "2":
                    NeedSugar(player);
                    break;
                case "3":
                    NeedIce(player);
                    break;
                case "4":
                    NeedCups(player);
                    break;

                default:

                    break;


            }


        }

        private void NeedLemons(player player)
        {

        }

        private void NeedSugar(player player)
        {

        }
        private void NeedIce(player player)
        {

        }
        private void NeedCups(player player)
        {

        }
}   }   


    
