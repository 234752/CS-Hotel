using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelWF.zClasses
{
    internal class RegularRoom : Room
    {
        public RegularRoom(int n0, double a0, int m0) : base(n0, a0, m0) { }
        public double getFee()
        {
            if (getNumberOfGuests() != 0) return getNumberOfGuests() * 50 + 100;
            else return 0;
        }
    }
}
