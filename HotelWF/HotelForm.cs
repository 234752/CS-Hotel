using HotelWF.zClasses;

namespace HotelWF
{
    public partial class HotelForm : Form
    {
        public HotelForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Room r1 = new Room(1, 30.4, 3);
            Guest g1 = new Guest("bob1", 200.1);
            Guest g2 = new Guest("bob2", 200.2);
            Guest g3 = new Guest("bob3", 200.3);
            Guest g4 = new Guest("bob4", 200.4);
            r1.addGuest(g1);
            r1.addGuest(g2);
            r1.addGuest(g3);
            r1.addGuest(g4);
            for(int i = 0; i < r1.getNumberOfGuests(); i++)
            {
                this.GuestGrid.Rows.Add();
                this.GuestGrid.Rows[i].Cells[0].Value = r1.Guests[i].getName();
                this.GuestGrid.Rows[i].Cells[1].Value = r1.Guests[i].getBalance();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Room> RoomList = new List<Room>();
            Room r1 = new Room(1, 30.4, 3);
            Room r2 = new Room(1, 30.4, 3);
            Room r3 = new Room(1, 30.4, 3);
            RoomList.Add(r1);
            RoomList.Add(r2);
            RoomList.Add(r3);
        }
    }
}