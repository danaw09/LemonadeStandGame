using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class cups:supply
    {
        private double cupCost = .05;
        private string cupName;

        public static int Count { get; internal set; }

        public double GetCost()
        {
            return cupCost;
        }
        public void setCupName()
        {
            cupName = "Cups";
        }
        public string getCupName()
        {
            return cupName;
        }
         
    }
}

