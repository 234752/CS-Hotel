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
            Guest g1 = new Guest("bob", 200);
            this.GuestGrid.Rows.Add();
            this.GuestGrid.Rows[0].Cells[0].Value=g1.getName();
            this.GuestGrid.Rows[0].Cells[1].Value=g1.getBalance();
        }
    }
}