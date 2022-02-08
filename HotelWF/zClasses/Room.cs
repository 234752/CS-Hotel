using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelWF.zClasses
{
    internal class Room
    {
        private int Number { get; set; }
        private double Area { get; set; }
        private int MaxGuests { get; set; }
        public List<Guest> Guests { get; set; } = new List<Guest>();
        public int getNumber() { return Number; }
        public double getArea() { return Area; }
        public int getNumberOfGuests() { return Guests.Count; }
        public int getMaxGuests() { return MaxGuests; }

        public bool addGuest(Guest G)
        {
            if (getMaxGuests() > getNumberOfGuests())
            {
                Guests.Add(G);
                return true;
            }else return false;
        }
    }
}
