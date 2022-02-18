using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelWF.zClasses
{
    internal class Hotel
    {
        public List<Room> RoomList = new List<Room>();
        public int getRoomCount() { return RoomList.Count; }
        public void addRoom(Room R)
        {
            RoomList.Add(R);
        }
        public bool removeRoom(Room R)
        {
            if (RoomList.Remove(R)) return true;
            return false;
        }
        public double countRevenue()
        {
            double R = 0.0;
            for(int i = 0;i < RoomList.Count;i++)
            {
                R+=RoomList[i].getFee();
            }
            return R;
        }
        public double countCosts()
        {
            double C = 0.0;
            for(int i=0; i < RoomList.Count;i++)
            {
                C += RoomList[i].getArea() * 5;
            }
            return C;
        }
    }
}
