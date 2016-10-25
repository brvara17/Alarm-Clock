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
        public static List<Appointment> appointment_Book = new List<Appointment>();
        bool reminderActive = false;
        bool editActive = false;
        bool deleteActive = false;

        public Appointment_Book()
        {
            InitializeComponent();
            lb_AppointmentBook.Items.Clear();
            lb_AppointmentBook.BeginUpdate();
            lb_AppointmentBook.Items.Clear();
            foreach (Appointment apt in appointment_Book)
            {

                lb_AppointmentBook.Items.Add(apt.ToString());
            }     
            lb_AppointmentBook.EndUpdate();
        }

        private void dateTimePicker_SetAppt_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addApt_Click(object sender, EventArgs e)
        {
            int addAppt = 0;
            Appointment newApt = new Appointment();

            string apptDateTime = dateTimePicker_DateAppt.Text + " " + dateTimePicker_TimeAppt.Text;

            if(!DateTime.TryParse(apptDateTime, out newApt.myDateTime))
            {
                MessageBox.Show("Error! Please Enter a new appointment Date and Time.");
                addAppt = 0;
            }
            else
            {
                newApt.apptNotes = rtb_ApptNotes.Text;
                addAppt = 1;
            }

            string reminderDateTime = dateTimePicker_ReminderDate.Text + " " + dateTimePicker_ReminderTime.Text;

            if (cb_Reminder.Checked)
            {
                

                if (!(DateTime.TryParse(reminderDateTime, out newApt.reminderDateTime)))
                {
                    MessageBox.Show("Error in reminder");
                    addAppt = 0;
                }
                else
                {
                    newApt.reminder = true;
                    addAppt = 1;
                }
                
            }
          


            MessageBox.Show("Appointment added for:\n"+ newApt.ToString());
            
           
            Console.WriteLine(newApt.ToString());

            if(addAppt == 1)
            {
                appointment_Book.Add(newApt);
            }

            CleanUpAdd();
            

        }

        public void CleanUpAdd()
        {
            
            
            reminderDateLabel.Visible = false;
            dateTimePicker_ReminderDate.Visible = false;
            reminderTimeLabel.Visible = false;
            dateTimePicker_ReminderTime.Visible = false;
            reminderActive = false;

            btn_DoneEditing.Visible = false;
            addApt.Visible = true;
            btn_DoneDelete.Visible = false;
            editActive = false;
            deleteActive = false;

            rtb_ApptNotes.Text = "Enter Appointment Notes";
            cb_Reminder.Checked = false;
            dateTimePicker_DateAppt.Text = DateTime.Now.Date.ToString();
            dateTimePicker_TimeAppt.Text = DateTime.Now.Date.ToString();
            dateTimePicker_ReminderDate.Text = DateTime.Now.Date.ToString();
            dateTimePicker_ReminderTime.Text = DateTime.Now.Date.ToString();



            //Updates the Text box with the newest values held in the <List> AppointmentBook
            lb_AppointmentBook.Items.Clear();
            lb_AppointmentBook.BeginUpdate();
            lb_AppointmentBook.Items.Clear();
            foreach (Appointment apt in appointment_Book)
            {
                lb_AppointmentBook.Items.Add(apt.ToString());
            }
            lb_AppointmentBook.EndUpdate();
        }


        private void cb_Reminder_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Reminder.Checked)
            {
                reminderDateLabel.Visible = true;
                dateTimePicker_ReminderDate.Visible = true;
                reminderTimeLabel.Visible = true;
                dateTimePicker_ReminderTime.Visible = true;
                reminderActive = true;
            }
            else if (!cb_Reminder.Checked)
            {
                reminderDateLabel.Visible = false;
                dateTimePicker_ReminderDate.Visible = false;
                reminderTimeLabel.Visible = false;
                dateTimePicker_ReminderTime.Visible = false;
                reminderActive = false;
            }
        }

        private void rtb_ApptNotes_Click(object sender, EventArgs e)
        {
            if(rtb_ApptNotes.Text == "Enter Appointment Notes")
            {
                rtb_ApptNotes.Clear();
            }
        }

        public void lb_AppointmentBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            //EditorDeleteMessageBox editOrDelete = new EditorDeleteMessageBox();
            //editOrDelete.Show();
            
            if (editActive || deleteActive)
            {
                Appointment itemToEdit = new Appointment();
                Variables.appointmentSelected = lb_AppointmentBook.SelectedIndex;
                itemToEdit = appointment_Book.ElementAt(Variables.appointmentSelected);

                dateTimePicker_DateAppt.Text = itemToEdit.GetDateTime.ToString();
                dateTimePicker_TimeAppt.Text = itemToEdit.GetDateTime.ToString();
                rtb_ApptNotes.Text = itemToEdit.apptNotes;

                if(itemToEdit.reminder)
                {
                    cb_Reminder.Checked = true;
                    dateTimePicker_ReminderDate.Text = itemToEdit.reminderDateTime.ToString();
                    dateTimePicker_ReminderTime.Text = itemToEdit.reminderDateTime.ToString();
                }

            }
          
        }

        public void reload_lb_AppointmentBook()
        {
            Console.WriteLine("Reload lb Appointment Book");
            lb_AppointmentBook.Items.Clear();
            lb_AppointmentBook.BeginUpdate();
            lb_AppointmentBook.Items.Clear();
            foreach (Appointment apt in appointment_Book)
            {
                lb_AppointmentBook.Items.Add(apt.ToString());
            }
            lb_AppointmentBook.EndUpdate();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Select an Appointment from the List below to Edit:");
            editActive = true;
            btn_DoneEditing.Visible = true;
            addApt.Visible = false;

        }

        private void btn_DoneEditing_Click(object sender, EventArgs e)
        {
            Appointment itemToEdit = new Appointment();
            Variables.appointmentSelected = lb_AppointmentBook.SelectedIndex;
            itemToEdit = appointment_Book.ElementAt(Variables.appointmentSelected);
            appointment_Book.Remove(itemToEdit);

            AddNewAppointment();

        }

        public void AddNewAppointment()
        {
            int addAppt = 0;
        Appointment newApt = new Appointment();

        string apptDateTime = dateTimePicker_DateAppt.Text + " " + dateTimePicker_TimeAppt.Text;

            if(!DateTime.TryParse(apptDateTime, out newApt.myDateTime))
            {
                MessageBox.Show("Error! Please Enter a new appointment Date and Time.");
                addAppt = 0;
            }
            else
            {
                newApt.apptNotes = rtb_ApptNotes.Text;
                addAppt = 1;
            }

            string reminderDateTime = dateTimePicker_ReminderDate.Text + " " + dateTimePicker_ReminderTime.Text;

            if (cb_Reminder.Checked)
            {
                

                if (!(DateTime.TryParse(reminderDateTime, out newApt.reminderDateTime)))
                {
                    MessageBox.Show("Error in reminder");
                    addAppt = 0;
                }
                else
                {
                    newApt.reminder = true;
                    addAppt = 1;
                }
                
            }
          


            MessageBox.Show("Appointment added for:\n"+ newApt.ToString());
            
           
            Console.WriteLine(newApt.ToString());

            if(addAppt == 1)
            {
                appointment_Book.Add(newApt);
            }

            CleanUpAdd();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Select an Appointment from the List below to Delete:");
            deleteActive = true;
            btn_DoneDelete.Visible = true;
            addApt.Visible = false;
        }

        private void btn_DoneDelete_Click(object sender, EventArgs e)
        {
            Appointment itemToEdit = new Appointment();
            Variables.appointmentSelected = lb_AppointmentBook.SelectedIndex;
            itemToEdit = appointment_Book.ElementAt(Variables.appointmentSelected);
            appointment_Book.Remove(itemToEdit);

            CleanUpAdd();
        }
    }
}
