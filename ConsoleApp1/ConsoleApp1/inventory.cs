﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class inventory
    {
        private string name;
        private double price;
       private string unit;
       private string recipePart;

        public inventory()
        {
        }

         public inventory(string name, double price, string unit, string recipePart)
        {
            this.name = name;
            this.price = price;
            this.unit = unit;
            this.recipePart = recipePart;
        }

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        public double Price
        {
            get { return price; }
            private set { price = value; }
        }

        public string RecipePart
        {
            get { return recipePart; }
            private set { recipePart = value; }
        }

        public string Unit
        {
            get { return unit; }
            private set { unit = value; }
        }

        public void Getnventory()
        {
            Console.WriteLine("You currently have {0} lemons.\n\n", lemon.Count);
            Console.WriteLine("You currently have {0} cups of sugar.\n\n", sugar.Count);
            Console.WriteLine("You currently have {0} ice cubes.\n\n", ice.Count);
            Console.WriteLine("You currently have {0} cups.\n\n", cups.Count);
        }





    }
}
