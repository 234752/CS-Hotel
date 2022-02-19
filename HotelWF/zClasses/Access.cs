using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelWF.zClasses
{
    internal class Access
    {
        private double Price;
        public Access(double p0) { Price = p0; }
        public virtual double getPrice() { return Price; }
    }
}
