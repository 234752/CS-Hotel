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
            int index = this.RoomGrid.CurrentCell.RowIndex;

            GuestFunctions.DisplayGuests(MainHotel, GuestGrid, index);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RoomFunctions.displayRooms(MainHotel, RoomGrid);
        }
    }
}