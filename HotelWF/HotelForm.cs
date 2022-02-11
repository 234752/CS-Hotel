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
            Int32.TryParse(this.AddRoomNoInput.Text, out n0);
            Double.TryParse(this.AddRoomAreaInput.Text, out a0);
            Int32.TryParse(this.AddRoomMaxGuestsInput.Text, out g0);

            MainHotel.addRoom(new Room(n0, a0, g0));
        }
    }
}