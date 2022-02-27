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
        public Room(int number0, double area0, int maxGuests0)
        {
            Number = number0;
            Area = area0;
            MaxGuests = maxGuests0;
        }

        public int getNumber() { return Number; }
        public void setNumber(int number) { Number = number; }
        public double getArea() { return Area; }
        public void setArea(double area) { Area = area; }
        public int getNumberOfGuests() { return Guests.Count; }
        public int getMaxGuests() { return MaxGuests; }
        public bool setMaxGuests(int maxGuests) 
        {
            if (maxGuests < this.getNumberOfGuests()) return false;
            else MaxGuests = maxGuests;
            return true;
        }

        public bool addGuest(Guest G)
        {
            if (getMaxGuests() > getNumberOfGuests())
            {
                Guests.Add(G);
                return true;
            }else return false;
        }
        public bool removeGuest(Guest G)
        {
            return Guests.Remove(G);
        }
        public virtual double getFee() { return 99.99; }
        public virtual string getType() { return "9"; }
        public double countGuestsFees()
        {
            double F = 0.0;
            for (int i = 0; i < Guests.Count; i++)
            {
                F += Guests[i].countFees();
            }
            return F;
        }
            
    }
}
