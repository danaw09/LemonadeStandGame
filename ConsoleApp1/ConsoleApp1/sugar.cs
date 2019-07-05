using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class sugar : supply
    {
        public sugar()
        {
            price = .05;
            name = "sugar";
        }

        public static int Count { get; internal set; }
    }   }
