using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelWF.zClasses
{
    internal class Guest
    {
        private string Name { get; }
        private double Balance { get; set; }

        public string getName() { return Name; }
        public double getBalance() { return Balance; }
    }
}
