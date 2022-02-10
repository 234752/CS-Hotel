using HotelWF.zClasses;

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
            

            Guest g1 = new Guest("bob1", 200.1);            
            Guest g2 = new Guest("bob2", 200.2);         
            Guest g3 = new Guest("bob3", 200.3);           
            Guest g4 = new Guest("bob4", 200.4);

            Room r1 = new Room(1, 30.1, 1);
            r1.addGuest(g1);
            r1.addGuest(g2);
            r1.addGuest(g3);
            r1.addGuest(g4);
            Room r2 = new Room(2, 30.2, 2);
            r2.addGuest(g1);
            r2.addGuest(g2);
            r2.addGuest(g3);
            r2.addGuest(g4);
            Room r3 = new Room(3, 30.3, 3);
            r3.addGuest(g1);
            r3.addGuest(g2);
            r3.addGuest(g3);
            r3.addGuest(g4);

            MainHotel.addRoom(r1);
            MainHotel.addRoom(r2);
            MainHotel.addRoom(r3);

            for(int i = 0; i<MainHotel.getRoomCount(); i++)
            {
                this.RoomGrid.Rows.Add();
                this.RoomGrid.Rows[i].Cells[0].Value = MainHotel.RoomList[i].getNumber();
                this.RoomGrid.Rows[i].Cells[1].Value = MainHotel.RoomList[i].getArea();
                this.RoomGrid.Rows[i].Cells[2].Value = MainHotel.RoomList[i].getMaxGuests();
                this.RoomGrid.Rows[i].Cells[3].Value = MainHotel.RoomList[i].getNumberOfGuests();
            }
        }
    }
}