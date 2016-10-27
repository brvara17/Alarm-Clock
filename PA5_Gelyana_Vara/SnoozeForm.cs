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
        //DateTime snoozeTime = new DateTime();
        Main main1 = new Main();

        
        public SnoozeForm()
        {
            InitializeComponent();
            
        }

        private void btn_SetSnooze_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(hrBox.Text) || string.IsNullOrEmpty(minsBox.Text) || string.IsNullOrEmpty(secsBox.Text))
            {
                MessageBox.Show("Please enter a valid number!");
                
            }
            else
            {

                Main.snoozeHour = int.Parse(hrBox.Text);
                Main.snoozeMin = int.Parse(minsBox.Text);
                Main.snoozeSec = int.Parse(secsBox.Text);
                Main.snoozeSet = true; 
            }


            //Console.WriteLine("{0}:{1}:{2}", int.Parse(snoozeSplit[0]), int.Parse(snoozeSplit[1]),int.Parse(snoozeSplit[2]));
            ////snoozeTime = snoozeDTP.Value;
            //main1.alarmHour += snoozeTime.Hour;
            //main1.alarmMin += snoozeTime.Minute;
            //main1.alarmSec += snoozeTime.Minute;

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

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
