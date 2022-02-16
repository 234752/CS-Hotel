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
            DGV.Rows.Clear();
            for (int i = 0; i < H.getRoomCount(); i++)
            {
                DGV.Rows.Add();
                DGV.Rows[i].Cells[0].Value = H.RoomList[i].getType();
                DGV.Rows[i].Cells[1].Value = H.RoomList[i].getNumber();
                DGV.Rows[i].Cells[2].Value = H.RoomList[i].getArea();
                DGV.Rows[i].Cells[3].Value = H.RoomList[i].getMaxGuests();
                DGV.Rows[i].Cells[4].Value = H.RoomList[i].getNumberOfGuests();
                DGV.Rows[i].Cells[5].Value = H.RoomList[i].getFee();
            }
        }
    }
}
