using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class store
    {
        List<inventory> inventorys;
        static double lemonPrice = 0.10;
        static double sugarPrice = 0.10;
        static double iceCubePrice = 0.10;
        static double cupPrice = 0.10;

        public store()
        {
            inventorys = new List<inventory>();
            inventorys.Add(new inventory("lemon", lemonPrice, "each", "pitcher"));
            inventorys.Add(new inventory("sugar", sugarPrice, "cup", "pitcher"));
            inventorys.Add(new inventory("ice cube", iceCubePrice, "each", "cup"));
            inventorys.Add(new inventory("cup", cupPrice, "each", "cup"));
        }

        

    }

}



    
