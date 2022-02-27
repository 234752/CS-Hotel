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
        private Room R;
        public RoomEditingForm(Room r0)
        {
            R = r0;
            InitializeComponent();
            display();
        }
        private void display()
        {
            this.typeTextBox.Text = R.getType();
            this.noTextBox.Text = R.getNumber().ToString();
            this.areaTextBox.Text = R.getArea().ToString();
            this.maxGuestsTextBox.Text = R.getMaxGuests().ToString();
            this.guestsTextBox.Text = R.getNumberOfGuests().ToString();
            this.feeTextBox.Text = R.getFee().ToString();
        }
        private void editNumber()
        {
            try
            {
                int n0 = int.Parse(this.noTextBox.Text);
                R.setNumber(n0);
                this.noTextBox.BackColor = Color.White;
            }
            catch(Exception e)
            {
                this.noTextBox.BackColor = Color.Red;
            }

        }
        private void editArea()
        {
            try
            {
                double a0 = double.Parse(this.areaTextBox.Text);
                R.setArea(a0);
                this.areaTextBox.BackColor = Color.White;
            }
            catch (Exception e)
            {
                this.areaTextBox.BackColor = Color.Red;
            }
        }

        private void editMaxGuests()
        {
            try
            {
                int m0 = int.Parse(this.maxGuestsTextBox.Text);
                if (!R.setMaxGuests(m0)) throw new Exception();
                this.maxGuestsTextBox.BackColor = Color.White;
            }
            catch (Exception e)
            {
                this.maxGuestsTextBox.BackColor = Color.Red;
            }
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            editNumber();
            editArea();
            editMaxGuests();
        }
    }
}
