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
        Room CurrentRoom = new Room(999, 99.99, 9);

        public void REFRESH()
        {
            RoomFunctions.displayRooms(MainHotel, RoomGrid);
            GuestFunctions.displayGuests(MainHotel, GuestGrid, CurrentRoom);
        }

        private void addRoomButton_Click(object sender, EventArgs e)
        {
            int n0 = 0;
            double a0 = 1.0;
            int g0 = 1;
            Int32.TryParse(this.addRoomNoInput.Text, out n0);
            Double.TryParse(this.addRoomAreaInput.Text, out a0);
            Int32.TryParse(this.addRoomMaxGuestsInput.Text, out g0);

            MainHotel.addRoom(new RegularRoom(n0, a0, g0));
            //RoomFunctions.displayRooms(MainHotel, RoomGrid);
            REFRESH();
        }

        private void addGuestButton_Click(object sender, EventArgs e)
        {
            int indexR = this.RoomGrid.CurrentCell.RowIndex;
            CurrentRoom = MainHotel.RoomList[indexR];

            double b0 = 0.0;
            string n0 = this.addGuestNameInput.Text;
            Double.TryParse(this.addGuestBalanceInput.Text, out b0);

            CurrentRoom.addGuest(new Guest(n0, b0));

            //GuestFunctions.displayGuests(MainHotel, GuestGrid, CurrentRoom);
            REFRESH();
        }

        private void displayGuestsButton_Click(object sender, EventArgs e)
        {
            int indexR = this.RoomGrid.CurrentCell.RowIndex;
            CurrentRoom = MainHotel.RoomList[indexR];
            //GuestFunctions.displayGuests(MainHotel, GuestGrid, CurrentRoom);
            REFRESH();
        }

        private void removeGuestButton_Click(object sender, EventArgs e)
        {
            int indexG = this.GuestGrid.CurrentCell.RowIndex;
            CurrentRoom.Guests.RemoveAt(indexG);
            //GuestFunctions.displayGuests(MainHotel, GuestGrid, CurrentRoom);
            REFRESH();
        }
    }
}