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
        Room CurrentRoom = new Room(9, 9.9, 9);

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
                int n0 = int.Parse(this.addRoomNoInput.Text);
                double a0 = double.Parse(this.addRoomAreaInput.Text);
                int g0 = int.Parse(this.addRoomMaxGuestsInput.Text);

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
            try
            {

                int indexR = this.RoomGrid.CurrentCell.RowIndex;
                CurrentRoom = MainHotel.RoomList[indexR];

                double b0 = double.Parse(this.addGuestBalanceInput.Text);
                string n0 = this.addGuestNameInput.Text;
                if(b0<0.0 || n0=="") throw new Exception();

                if(!CurrentRoom.addGuest(new Guest(n0, b0))) this.ErrorLabel.Text = "Cannot add this guest, room is full";
                else REFRESH();
            }
            catch (Exception ex)
            {
                this.ErrorLabel.Text = "Cannot add this guest, make sure that entered data is valid";
            }
        }

        private void displayGuestsButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.RoomGrid.CurrentCell == null) throw new Exception();
                else
                {
                    int indexR = this.RoomGrid.CurrentCell.RowIndex;
                    CurrentRoom = MainHotel.RoomList[indexR];
                }
                REFRESH();
            }
            catch (Exception ex)
            {
                this.ErrorLabel.Text = "Cannot display guests, room not selected";
            }
        }

        private void removeGuestButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(this.GuestGrid.CurrentCell == null) throw new Exception();
                else
                {
                    int indexG = this.GuestGrid.CurrentCell.RowIndex;
                    CurrentRoom.Guests.RemoveAt(indexG);
                }
                REFRESH();
            }
            catch (Exception ex)
            {
                this.ErrorLabel.Text = "Cannot delete this guest, none was selected";
            }
        }

        private void RoomGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexR = this.RoomGrid.CurrentCell.RowIndex;
            CurrentRoom = MainHotel.RoomList[indexR];
            REFRESH();
        }

        private void deleteRoomButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MainHotel.removeRoom(CurrentRoom))
                {
                    if (MainHotel.getRoomCount() > 0) CurrentRoom = MainHotel.RoomList.First();
                    else CurrentRoom = new Room(9, 9.9, 9);
                }
                else throw new Exception();
            }catch (Exception ex)
            {
                this.ErrorLabel.Text = "Cannot delete this room, none was selected";
            }
            
            REFRESH();
        }

        private void countRevenueButton_Click(object sender, EventArgs e)
        {
            this.revenueLabel.Text = "Total revenue: "+MainHotel.countRevenue().ToString();
        }

        private void countCostsButton_Click(object sender, EventArgs e)
        {
            this.costsLabel.Text = "Total costs: " + MainHotel.countCosts().ToString();
        }
    }
}