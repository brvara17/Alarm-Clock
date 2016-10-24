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
    public partial class Appointment_Book : Form
    {
        List<Appointment> appointment_Book = new List<Appointment>();
        bool reminderActive = false;

        public Appointment_Book()
        {
            InitializeComponent();
        }

        private void dateTimePicker_SetAppt_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addApt_Click(object sender, EventArgs e)
        {
            Appointment newApt = new Appointment();

            string apptDateTime = dateTimePicker_DateAppt.Text + " " + dateTimePicker_TimeAppt.Text;

            if(!DateTime.TryParse(apptDateTime, out newApt.myDateTime))
            {
                MessageBox.Show("Error! Please Enter a new appointment Date and Time.");
            }
            else
            {
                newApt.apptNotes = rtb_ApptNotes.Text;
            }

            string reminderDateTime = dateTimePicker_ReminderDate.Text + " " + dateTimePicker_ReminderTime.Text;

            if (!(DateTime.TryParse(reminderDateTime, out newApt.reminderDateTime)))
            {
                MessageBox.Show("error in reminder");
            }
            else if(rb_Reminder.Checked)
            {
                newApt.reminder = 1;
            }


            MessageBox.Show("Appointment added for:\n"+ newApt.ToString());
            
           
            Console.WriteLine(newApt.ToString());

            rb_Reminder.Checked = false;
            reminderDateLabel.Visible = false;
            dateTimePicker_ReminderDate.Visible = false;
            reminderTimeLabel.Visible = false;
            dateTimePicker_ReminderTime.Visible = false;
            reminderActive = false;
        }

        private void rb_Reminder_CheckedChanged(object sender, EventArgs e)
        {
                reminderDateLabel.Visible = true;
                dateTimePicker_ReminderDate.Visible = true;
                reminderTimeLabel.Visible = true;
                dateTimePicker_ReminderTime.Visible = true;
                reminderActive = true;


        }
    }
}
