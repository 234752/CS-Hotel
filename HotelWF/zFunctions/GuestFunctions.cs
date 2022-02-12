using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelWF.zClasses;

namespace HotelWF.zFunctions
{
    internal static class GuestFunctions
    {
        public static void displayGuests(Hotel H, DataGridView DGV, int index)
        {
            

            Room r = H.RoomList[index];
            DGV.Rows.Clear();
            for (int i = 0; i < r.getNumberOfGuests(); i++)
            {
                DGV.Rows.Add();
                DGV.Rows[i].Cells[0].Value = r.Guests[i].getName();
                DGV.Rows[i].Cells[1].Value = r.Guests[i].getBalance();
            }
        }
    }
}
