using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelWF.zClasses;

namespace HotelWF.zFunctions
{
    internal static class RoomFunctions
    {
        public static void displayRooms(Hotel H, DataGridView DGV)
        {
            Guest g1 = new Guest("bob1", 200.1);
            Guest g2 = new Guest("bob2", 200.2);
            Guest g3 = new Guest("bob3", 200.3);
            Guest g4 = new Guest("bob4", 200.4);

            Room r1 = new Room(1, 30.1, 1);
            r1.addGuest(g1);
            r1.addGuest(g2);
            r1.addGuest(g3);
            r1.addGuest(g4);
            Room r2 = new Room(2, 30.2, 2);
            r2.addGuest(g1);
            r2.addGuest(g2);
            r2.addGuest(g3);
            r2.addGuest(g4);
            Room r3 = new Room(3, 30.3, 3);
            r3.addGuest(g1);
            r3.addGuest(g2);
            r3.addGuest(g3);
            r3.addGuest(g4);
            
            H.addRoom(r1);
            H.addRoom(r2);
            H.addRoom(r3);

            for (int i = 0; i < H.getRoomCount(); i++)
            {
                DGV.Rows.Add();
                DGV.Rows[i].Cells[0].Value = H.RoomList[i].getNumber();
                DGV.Rows[i].Cells[1].Value = H.RoomList[i].getArea();
                DGV.Rows[i].Cells[2].Value = H.RoomList[i].getMaxGuests();
                DGV.Rows[i].Cells[3].Value = H.RoomList[i].getNumberOfGuests();
            }
        }
    }
}
