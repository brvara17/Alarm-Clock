using System;
using System.Media;
using System.Windows.Forms;

namespace PA5_Gelyana_Vara
{
    public partial class Main : Form
    {
        /// <summary>
        /// This Main window form is the main window that the user will see when program is first
        /// loaded. It displays all Alarm Clock options and Appointment Book options.
        /// </summary>
        DateTime currTime = new DateTime();
        DateTime snoozeTime = new DateTime();
        Appointment globalApt = new Appointment();
        SoundPlayer alarmSound = new SoundPlayer(Properties.Resources.force);
        SoundPlayer reminderSound = new SoundPlayer(Properties.Resources.APPLAUSE);
        
        
        public Main()
        {
            
            InitializeComponent();
            alarmLabel.Visible = false;
            ackBtn.Visible = false;

        }

        //Check to see if a reminder event has fired
        bool reminderOn_Off = false;

        /// <summary>
        /// These are all properties that allow the program to set and get from any Form.
        /// </summary>
        public static DateTime alarmTimeDisplay
        {
            get;
            set;
        }
        public static bool snoozeSet
        {
            get;
            set;
        }

        public static bool alarmWentOff
        {
            get;
            set;
        }

        public static bool alarmSet
        {
            get;
            set;
        }
        public static int alarmHour
        {
            get;
            set;
        }

        public static  int alarmMin
        {
            get;
            set;
        }

        public static int alarmSec
        {
            get;
            set;
        }

        public static string alarmAmPm
        {
            get;
            set;
        }
        public static int snoozeHour
        {
            get;
            set;
        }

        public static int snoozeMin
        {
            get;
            set;
        }

        public static int snoozeSec
        {
            get;
            set;
        }

        //This function sets the adds the Snooze Interval that is entered in by the user to the
        //SnoozeTime
        public void Snooze()
        {
            snoozeTime = DateTime.Now;
            snoozeTime = snoozeTime.AddHours(snoozeHour);
            snoozeTime = snoozeTime.AddMinutes(snoozeMin);
            snoozeTime = snoozeTime.AddSeconds(snoozeSec);

        }

        /// <summary>
        /// Timeer that fires off every 500ms to check and see if any of our conditions are met that satisfy
        /// the Alarm or the Appointment Book.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clockTimer_Tick(object sender, EventArgs e)
        {
            //Clock display on main form to display the current time of day
            currTimeLabel.Text = DateTime.Now.ToString("M/dd/yyyy hh:mm:ss tt");
            currTime = DateTime.Now;
            
            //If alarm is set, it will allow the user to view the alarm time
            if(alarmSet)
            {
                alarmLabel.Visible = true;
                alarmLabel.Text = alarmTimeDisplay.ToLongTimeString();
            }
            else
            {
                alarmLabel.Visible = false;

            }

            //Conditions to check and see if the alarm time has met the current time. Sounds the alarm if its true
            if ((currTime.Hour == alarmHour) && (currTime.Minute == alarmMin) && (currTime.Second == alarmSec)
              && (currTime.ToString("tt") == alarmAmPm))
            {
                alarmWentOff = true;
                alarmSound.PlayLooping();
            }

            //This checks to see if the Snooze Interval has been met, if so it plays the sound
            if (currTime.Hour == snoozeTime.Hour && currTime.Minute == snoozeTime.Minute && currTime.Second == snoozeTime.Second)
            {                
                alarmSound.PlayLooping();
                alarmWentOff = true;
                snoozeSet = true;

            }

            //If the Appointment reminder time has been met, flash the image
            if(reminderOn_Off)
            {
                imageReminder.Visible = !imageReminder.Visible;
                ackBtn.Visible = true;
            }
            else
            {
                ackBtn.Visible = false;
            }

            //Iterates through each appointment in the appt book to check and see if any appointment times match
            //the current time, if so play the reminder sound
            foreach (Appointment apt in Appointment_Book.appointment_Book)
            {

                if (DateTime.Now.ToString("M/dd/yyyy hh:mm:ss tt") == apt.reminderDateTime.ToString("M/dd/yyyy hh:mm:ss tt"))
                {
                    reminderOn_Off = true;
                    reminderSound.Play();
                    globalApt = apt;
                }

            }

        }
        
        //Opens alarm setting Form
        private void alarmBtn_Click(object sender, EventArgs e)
        {
            
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
        }

        //Stops the alarm sound 
        private void stopBtn_Click(object sender, EventArgs e)
        {
            
            alarmSound.Stop();
            alarmWentOff = false;
            
        }

        //Opens the Snooze Setting form
        private void snzBtn_Click(object sender, EventArgs e)
        {
            SnoozeForm snzFrm1 = new SnoozeForm();
            snzFrm1.ShowDialog();
        }

        //Opens the Appointment book form
        private void btn_AppointmentBook_Click(object sender, EventArgs e)
        {
            Appointment_Book form1 = new Appointment_Book();
            form1.Show();
        }

        /// <summary>
        /// Adds extra time, defined by user, to sound the alarm at a later time
        ///  and also checks to make sure all settings are set before proceeding
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void snoozeBtn_Click(object sender, EventArgs e)
        {
            alarmSound.Stop();

            if (alarmSet && !snoozeSet)
            {
                MessageBox.Show("Please set your snooze interval!");
            }
            else if(alarmSet && snoozeSet && !alarmWentOff)
            {
                MessageBox.Show("Waiting for alarm...");
            }
            else if(snoozeSet && alarmWentOff)
            {
                Snooze();
                alarmWentOff = false;
                alarmSet = false;
                snoozeSet = false;
            }
            else if (!alarmSet && !snoozeSet)
            {
                MessageBox.Show("Please set your Alarm and Snooze settings!");
            }
            else if(!alarmSet && snoozeSet)
            {
                MessageBox.Show("Please set your alarm!");
            }
           
            
        }

        //This button becomes visible when the appointment reminder has been met and
        //allows the user to stop the reminder and sound
        private void ackBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(globalApt.ToString());
            reminderOn_Off = false;
            imageReminder.Visible = true;

        }

        private void helpBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Alarm Clock: \n - To set the alarm, click on 'Alarm Setting'."
                + "\n - Then click inside the alarm box and enter your desired alarm time or use the 'UpDown' arrows."
                + "\n - Click 'Set' once your finished and 'Close' to close the window" 
                + "\n\nSnooze Setting: \n - To set the Snooze, click on 'Snooze Setting'."
                + "\n - Enter in your desired values in the boxes and click 'Set'."
                + "\n\nAlarm Goes Off: \n - When the alarm goes off, click 'Stop Alarm' to stop or "
                + "click 'Snooze' to delay the alarm by the Snooze Interval you set. You can click snooze"
                + "as many times as you want. \n - To stop the alarm, click 'Stop' which will also disable"
                + "the snooze from working until you enter another alarm time"
                + "\n\nAppointment Book:\n\nAdd Appointment - Enter desired appointment time, notes, and reminder time in the"
                + " appropriate fields. Then click the add button.\n\n" 
                + "Edit Appointment - Click on the edit button to put the appointment book into"
                + " edit mode. Select the desired appointment to edit and then edit the data in the set appointment section. "
                + "To finish editing the appointment hit the 'Done Editing' button."
                + "\n\nDelete Appointment - To delete an appointment click the delete button which will put the application into"
                + " the delete mode. Once in delete mode select the desired appointment to delete and then click"
                + " the 'Delete' button in the set appointment section.","Help");
        }
    }
}
