using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class lemon: supply
    {
        public lemon()
        {
            price = .10;
            name = "lemon";
        }

        public static int Count { get; internal set; }
    }
}
