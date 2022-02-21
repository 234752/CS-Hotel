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
            int i = 0;
            foreach(Control control in P.Controls)
            {
                CheckBox CB = (CheckBox)control;
                if (G.accesses[i] != null)
                {
                    CB.Checked = true;
                }else CB.Checked = false;
                i++;
            }
        }

        public static void giveAccess(Guest G, int index0)
        {
            switch(index0)
            {
                case 0:
                    G.addAccess(new Pool(),0);
                    break;
                case 1:
                    G.addAccess(new ParkingLot(false),1);
                    break;
                case 2:
                    G.addAccess(new ParkingLot(true),2);
                    break;
                default:
                    throw new Exception();
            }
                
        }
        public static void revokeAccess(Guest G, int index0)
        {
            switch (index0)
            {
                case 0:
                    G.removeAccess(0);
                    break;
                case 1:
                    G.removeAccess(1);
                    break;
                case 2:
                    G.removeAccess(2);
                    break;
                default:
                    throw new Exception();
            }
        }
    }
}
