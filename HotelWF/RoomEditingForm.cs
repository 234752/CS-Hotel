using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelWF.zClasses;

namespace HotelWF
{
    internal partial class RoomEditingForm : Form
    {
        public RoomEditingForm(Room R)
        {
            InitializeComponent();
            display(R);
        }
        private void display(Room R)
        {
            this.typeTextBox.Text = R.getType();
            this.noTextBox.Text = R.getNumber().ToString();
            this.areaTextBox.Text = R.getArea().ToString();
            this.maxGuestsTextBox.Text = R.getMaxGuests().ToString();
            this.guestsTextBox.Text = R.getNumberOfGuests().ToString();
            this.feeTextBox.Text = R.getFee().ToString();
        }
    }
}
