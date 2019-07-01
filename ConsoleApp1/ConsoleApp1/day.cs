using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class day
    {
        private string name;
        private int number;
        private readonly string totalCustomers;
        internal Weather weather;
        internal Report report;
        public List<customer> customers = new List<customer>();
        Random rnd = new Random();

    }
    public Day(Random rnd)
    {
        this.rnd = rnd;
        totalCustomers = rnd.Next(50, 100);
        for (int i = 1; i <= totalCustomers; i++)
        {
            customers.Add(new Customer(rnd, this));
        }
    }
}
