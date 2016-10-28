using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PA5_Gelyana_Vara
{
    public partial class SnoozeForm : Form
    {
        /// <summary>
        /// This form allows the user to set a Snooze Interval setting so that the alarm
        /// can play at a delayed time that is set by the user
        /// </summary>
        
        //Initializes the Form
        public SnoozeForm()
        {
            InitializeComponent();
            
        }

        /// <summary>
        /// When the Set button is clicked, this checks to make sure all values that are inserted 
        /// are numerical values. This then sets the values for the Snooze Interval for the Alarm Clock.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SetSnooze_Click(object sender, EventArgs e)
        {
            //Checks to make sure there is data in each box
            if (string.IsNullOrEmpty(hrBox.Text) || string.IsNullOrEmpty(minsBox.Text) || string.IsNullOrEmpty(secsBox.Text))
            {
                MessageBox.Show("Please enter a valid number!");
                
            }
            else
            {
                //Parse each value to an int and store it
                Main.snoozeHour = int.Parse(hrBox.Text);
                Main.snoozeMin = int.Parse(minsBox.Text);
                Main.snoozeSec = int.Parse(secsBox.Text);
                Main.snoozeSet = true; 
            }
            
        }

        //Closes the Snooze Setting form
        private void closeBtn_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        //This restricts the user from typing in anything into the textbox except number values
        //and backspace
        private void hrBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == 8);
        }

        private void minsBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == 8);
        }

        private void secsBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == 8);
        }
    }
}
