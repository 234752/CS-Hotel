using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelWF.zClasses
{
    internal class Guest
    {
        private string Name { get; set; }
        private double Balance { get; set; }
        public string getName() { return Name; }
        public double getBalance() { return Balance; }
        public bool addBalance(double cash)
        {
            if (cash < 0) return false;
            Balance += cash;
            return true;
        }
        public Guest(string name0, double balance0)
        {
            Name = name0;
            Balance = balance0;
        }
    }
}
