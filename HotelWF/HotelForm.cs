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

        private void addRoomButton_Click(object sender, EventArgs e)
        {
            int n0 = 0;
            double a0 = 1.0;
            int g0 = 1;
            Int32.TryParse(this.addRoomNoInput.Text, out n0);
            Double.TryParse(this.addRoomAreaInput.Text, out a0);
            Int32.TryParse(this.addRoomMaxGuestsInput.Text, out g0);

            MainHotel.addRoom(new Room(n0, a0, g0));
            RoomFunctions.displayRooms(MainHotel, RoomGrid);
        }

        private void addGuestButton_Click(object sender, EventArgs e)
        {
            int index = this.RoomGrid.CurrentCell.RowIndex;

            double b0 = 0.0;
            string n0 = this.addGuestNameInput.Text;
            Double.TryParse(this.addGuestBalanceInput.Text, out b0);

            MainHotel.RoomList[index].addGuest(new Guest(n0, b0));
            GuestFunctions.displayGuests(MainHotel, GuestGrid, index);
        }

        private void displayGuestsButton_Click(object sender, EventArgs e)
        {

        }
    }
}