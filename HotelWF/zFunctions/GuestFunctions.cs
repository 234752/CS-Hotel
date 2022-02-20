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
        public static void displayGuests(Hotel H, DataGridView DGV, Room R)
        {
            DGV.Rows.Clear();
            for (int i = 0; i < R.getNumberOfGuests(); i++)
            {
                DGV.Rows.Add();
                DGV.Rows[i].Cells[0].Value = R.Guests[i].getName();
                DGV.Rows[i].Cells[1].Value = R.Guests[i].getBalance();
            }
        }
        public static void displayAccess(Hotel H, Panel P, Guest G)
        {

        }
    }
}
