using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelWF.zClasses
{
    internal class ParkingLot : Access
    {
        private bool isUnderground;
        public ParkingLot(bool isUnderground0) : base(isUnderground0, 60, 30) { }
    }
}
