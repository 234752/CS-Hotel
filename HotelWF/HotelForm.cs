using HotelWF.zClasses;
using HotelWF.zFunctions;

namespace HotelWF
{
    public partial class HotelForm : Form
    {
        public HotelForm()
        {
            InitializeComponent();
        }
        Hotel MainHotel = new Hotel();
        private void button1_Click(object sender, EventArgs e)
        {
            int index=this.RoomGrid.CurrentCell.RowIndex;
            
            Room r1 = MainHotel.RoomList[index];
            this.GuestGrid.Rows.Clear();
            for(int i = 0; i < r1.getNumberOfGuests(); i++)
            {
                this.GuestGrid.Rows.Add();
                this.GuestGrid.Rows[i].Cells[0].Value = r1.Guests[i].getName();
                this.GuestGrid.Rows[i].Cells[1].Value = r1.Guests[i].getBalance();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RoomFunctions.displayRooms(MainHotel, RoomGrid);
        }
    }
}