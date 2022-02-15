using HotelWF.zClasses;
using HotelWF.zFunctions;

namespace HotelWF
{
    public partial class HotelForm : Form
    {
        public HotelForm()
        {
            InitializeComponent();
            this.RegularRoomSwitch.Checked = true;
        }
        Hotel MainHotel = new Hotel();
        Room CurrentRoom = new Room(999, 99.99, 9);

        public void REFRESH()
        {
            RoomFunctions.displayRooms(MainHotel, RoomGrid);
            GuestFunctions.displayGuests(MainHotel, GuestGrid, CurrentRoom);

            this.GuestGrid.CurrentCell = null;

            if (MainHotel.getRoomCount() != 0)
            {
                int currentIndex = MainHotel.RoomList.IndexOf(CurrentRoom);
                this.RoomGrid.CurrentCell = this.RoomGrid.Rows[currentIndex].Cells[0];
                this.RoomGrid.Rows[currentIndex].Selected = true;
            }
            this.ErrorLabel.Text = "";
        }

        private void addRoomButton_Click(object sender, EventArgs e)
        {
            try
            {
                int n0 = 0;
                double a0 = 1.0;
                int g0 = 1;
                n0=int.Parse(this.addRoomNoInput.Text);
                a0=double.Parse(this.addRoomAreaInput.Text);
                g0=int.Parse(this.addRoomMaxGuestsInput.Text);

                if (this.RegularRoomSwitch.Checked == true) { MainHotel.addRoom(new RegularRoom(n0, a0, g0)); }
                else if (this.OfficeRoomSwitch.Checked == true) { MainHotel.addRoom(new OfficeRoom(n0, a0, g0)); }
                else throw new Exception();

                CurrentRoom = MainHotel.RoomList.Last();
                REFRESH();
            }
            catch (Exception ex)
            {
                this.ErrorLabel.Text = "Cannot add this room, make sure that entered data is valid";
            }
            
        }

        private void addGuestButton_Click(object sender, EventArgs e)
        {
            int indexR = this.RoomGrid.CurrentCell.RowIndex;
            CurrentRoom = MainHotel.RoomList[indexR];

            double b0 = 0.0;
            string n0 = this.addGuestNameInput.Text;
            Double.TryParse(this.addGuestBalanceInput.Text, out b0);

            CurrentRoom.addGuest(new Guest(n0, b0));
            REFRESH();
        }

        private void displayGuestsButton_Click(object sender, EventArgs e)
        {
            int indexR = this.RoomGrid.CurrentCell.RowIndex;
            CurrentRoom = MainHotel.RoomList[indexR];
            REFRESH();
        }

        private void removeGuestButton_Click(object sender, EventArgs e)
        {
            int indexG = this.GuestGrid.CurrentCell.RowIndex;
            CurrentRoom.Guests.RemoveAt(indexG);
            REFRESH();
        }

        private void RoomGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexR = this.RoomGrid.CurrentCell.RowIndex;
            CurrentRoom = MainHotel.RoomList[indexR];
            REFRESH();
        }
    }
}