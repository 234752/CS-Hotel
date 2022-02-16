using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelWF.zClasses
{
    internal class OfficeRoom : Room
    {
        public OfficeRoom(int n0, double a0, int m0) : base(n0, a0, 1) { }
        public override double getFee()
        {
            if (getNumberOfGuests() == 1) return 300;
            else return 0;
        }
        public override string getType()
        {
            return "Office";
        }
    }
}
