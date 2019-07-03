using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class day
    {
        private string name;
        private  int number;
        private  string totalCustomers;
        internal Weather weather;
       
        public List<Customer> customers = new List<Customer>();
        Random rnd = new Random();
        private Random random;

        public day(Random random)
        {
            this.random = random;
        }
    }
}
