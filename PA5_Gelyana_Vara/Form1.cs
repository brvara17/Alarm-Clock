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
        //Holds all active appointments in application
        public static List<Appointment> appointment_Book = new List<Appointment>();

        //Used to hide and show certain ascpects of the application depending on if you are editing or deleting an appt
        bool editActive = false;
        bool deleteActive = false;

        public Appointment_Book()
        {
            InitializeComponent();

            //Updates the Appointment listbox upon initialization of the Form
            lb_AppointmentBook.Items.Clear();
            lb_AppointmentBook.BeginUpdate();
            lb_AppointmentBook.Items.Clear();
            foreach (Appointment apt in appointment_Book)
            {

                lb_AppointmentBook.Items.Add(apt.ToStringShort());
            }     
            lb_AppointmentBook.EndUpdate();
        }

        private void dateTimePicker_SetAppt_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Adds all new appointments to the appointment book
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addApt_Click(object sender, EventArgs e)
        {
            int addAppt = 0;
            Appointment newApt = new Appointment();

            //Gets data from Appointment date and time fields
            string apptDateTime = dateTimePicker_DateAppt.Text + " " + dateTimePicker_TimeAppt.Text;

            //Makes sure the date and time is valid from user.
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

            //Gets data from Reminder date and time fields
            string reminderDateTime = dateTimePicker_ReminderDate.Text + " " + dateTimePicker_ReminderTime.Text;

            //If the Reminder checkbox is active add the reminder data to the appointment
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
          

            //Displays the appointment to be added to the user.
            MessageBox.Show("Appointment added for:\n"+ newApt.ToString(),"New Appointment");

            if(addAppt == 1)
            {
                appointment_Book.Add(newApt);
            }

            CleanUpAdd();
            

        }

        /// <summary>
        /// Does the clean up work for the application once an appointment is added, editied, or deleted.
        /// Will hide buttons and set variables back to their initial states.
        /// </summary>
        public void CleanUpAdd()
        {
            
            
            reminderDateLabel.Visible = false;
            dateTimePicker_ReminderDate.Visible = false;
            reminderTimeLabel.Visible = false;
            dateTimePicker_ReminderTime.Visible = false;

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
                lb_AppointmentBook.Items.Add(apt.ToStringShort());
            }
            lb_AppointmentBook.EndUpdate();
        }

        /// <summary>
        /// If the Reminder check box has been selected the 
        /// areas to enter the reminder will be visible.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cb_Reminder_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Reminder.Checked)
            {
                reminderDateLabel.Visible = true;
                dateTimePicker_ReminderDate.Visible = true;
                reminderTimeLabel.Visible = true;
                dateTimePicker_ReminderTime.Visible = true;
            }
            else if (!cb_Reminder.Checked)
            {
                reminderDateLabel.Visible = false;
                dateTimePicker_ReminderDate.Visible = false;
                reminderTimeLabel.Visible = false;
                dateTimePicker_ReminderTime.Visible = false;
            }
        }

        /// <summary>
        /// When the user clicks on the appointment notes text box it will delete the 
        /// "Enter Appointment Notes" text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rtb_ApptNotes_Click(object sender, EventArgs e)
        {
            if(rtb_ApptNotes.Text == "Enter Appointment Notes")
            {
                rtb_ApptNotes.Clear();
            }
        }

        /// <summary>
        /// If the index of the appointment book listbox is changed the 
        /// data from the selected appointment will be populated into the editing categories, 
        /// IFF the user is in the edit or delete mode of the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void lb_AppointmentBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Transfers data from selected appointment to the set appointment section of the Form
            //Only if the user is in the edit or delete mode of the application
            if (editActive || deleteActive)
            {
                cb_Reminder.Checked = false;
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
        /// <summary>
        /// Once the user makes an edit or delete to the appointment book this function will
        /// populate the appointment book listbox with the new data;
        /// </summary>
        public void reload_lb_AppointmentBook()
        {
            lb_AppointmentBook.Items.Clear();
            lb_AppointmentBook.BeginUpdate();
            lb_AppointmentBook.Items.Clear();
            foreach (Appointment apt in appointment_Book)
            {
                lb_AppointmentBook.Items.Add(apt.ToStringShort());
            }
            lb_AppointmentBook.EndUpdate();
        }

        /// <summary>
        /// Once the edit button is selected the user will be put into the editing
        /// mode of the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (lb_AppointmentBook.Items.Count == 0)
            {
                MessageBox.Show("Appointment Book Empty!\nPlease insert an appointment first!", "Error");

            }
            else
            {
                MessageBox.Show("Select an Appointment from the List below to Edit:", "Edit Appointment");
                editActive = true;
                btn_DoneEditing.Visible = true;
                addApt.Visible = false;
                cb_Reminder.Checked = false;
            }
        }

        /// <summary>
        /// Once the user is done editing the selected appointment 
        /// the new appointment will be added and the old one will be deleted
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_DoneEditing_Click(object sender, EventArgs e)
        {
            Appointment itemToEdit = new Appointment();
            Variables.appointmentSelected = lb_AppointmentBook.SelectedIndex;
            itemToEdit = appointment_Book.ElementAt(Variables.appointmentSelected);
            appointment_Book.Remove(itemToEdit);

            AddNewAppointment();

        }

        /// <summary>
        /// This function is used to add a new appointment when an edit is done
        /// to an existing appointment.
        /// </summary>
        public void AddNewAppointment()
        {
            int addAppt = 0;
        Appointment newApt = new Appointment();
        
            //Collects data from the date and time fields for edited appointment
            string apptDateTime = dateTimePicker_DateAppt.Text + " " + dateTimePicker_TimeAppt.Text;

            //Makes sure the data can be added into Date and Time form
            if(!DateTime.TryParse(apptDateTime, out newApt.myDateTime))
            {
                MessageBox.Show("Error! Please Enter a new appointment Date and Time.","Error");
                addAppt = 0;
            }
            else
            {
                newApt.apptNotes = rtb_ApptNotes.Text;
                addAppt = 1;
            }

            //Collects data from Reminder date and time fields
            string reminderDateTime = dateTimePicker_ReminderDate.Text + " " + dateTimePicker_ReminderTime.Text;

            //If a reminder is needed adds it to the selected appointment
            if (cb_Reminder.Checked)
            {
                

                if (!(DateTime.TryParse(reminderDateTime, out newApt.reminderDateTime)))
                {
                    MessageBox.Show("Error in reminder","Error");
                    addAppt = 0;
                }
                else
                {
                    newApt.reminder = true;
                    addAppt = 1;
                }
                
            }
          

            //Shows the edited appointment information to be added.
            MessageBox.Show("Appointment added for:\n"+ newApt.ToString(),"Edited Appointment");

            if(addAppt == 1)
            {
                appointment_Book.Add(newApt);
            }

            CleanUpAdd();
        }

        /// <summary>
        /// Once the delete button is selected the user will be put into the deleting
        /// mode of the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (lb_AppointmentBook.Items.Count == 0)
            {
                MessageBox.Show("Appointment Book Empty!\nPlease insert an appointment first!", "Error");
            }
            else
            {
                MessageBox.Show("Select an Appointment from the List below to Delete:", "Delete Appointment");
                deleteActive = true;
                btn_DoneDelete.Visible = true;
                addApt.Visible = false;
                cb_Reminder.Checked = false;
            }
        }

        /// <summary>
        /// Once the user Confirms to delete the selected appointment the 
        /// this function will delete it from the appointment book
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_DoneDelete_Click(object sender, EventArgs e)
        {
            Appointment itemToEdit = new Appointment();
            Variables.appointmentSelected = lb_AppointmentBook.SelectedIndex;
            itemToEdit = appointment_Book.ElementAt(Variables.appointmentSelected);
            appointment_Book.Remove(itemToEdit);

            CleanUpAdd();
        }

        /// <summary>
        /// Used to view the the appointment information from the listbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lb_AppointmentBook_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int selectedappt = lb_AppointmentBook.SelectedIndex;
            Appointment apptViewNow = appointment_Book.ElementAt(selectedappt);
            MessageBox.Show(apptViewNow.ToString(),"Appointment");
        }
    }
}
