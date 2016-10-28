using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PA5_Gelyana_Vara
{

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }


    /// <summary>
    /// Appointment class holds all the values associated with every appointment
    /// created in the application
    /// </summary>
    public class Appointment
    {
        public DateTime myDateTime;
        public string apptNotes;
        public bool reminder = false;
        public DateTime reminderDateTime;

        /// <summary>
        /// Used to set the Date and Time of an Appointment
        /// </summary>
        /// <param name="date">Gets the value of the specified appointment date and time</param>
        /// <param name="notes">Gets the string of notes for the specified appointment</param>
        public void SetAppointment(DateTime date, string notes)
        {
            myDateTime = date;
            apptNotes = notes;
        }

        /// <summary>
        /// Property for getting and setting the Date and Time or the appointment
        /// </summary>
        public DateTime GetDateTime
        {
            get { return myDateTime; }
            set { myDateTime = value; }
        }

        /// <summary>
        /// Used to output the Values of an Appointment in a presentable format.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string printview;

            if (apptNotes == "" || apptNotes == "Enter Appointment Notes")
            {
                printview = myDateTime.ToString();
            }
            else
            {
                printview = myDateTime.ToString() + "\n" + "Appointment Notes:\n" + apptNotes;
            }

            if (reminder)
            {
                printview += "\n\n Reminder on:\n" + reminderDateTime.ToString();
            }

            return printview;
        }

        /// <summary>
        /// Used to output the Values of an Appointment in a presentable format for the listbox.
        /// </summary>
        /// <returns></returns>
        public string ToStringShort()
        {
            string printview;

                printview = myDateTime.ToString();

            if (reminder)
            {
                printview += "\n\n Reminder on:\n" + reminderDateTime.ToString();
            }

            return printview;
        }
    }

    /// <summary>
    /// Used to know what appointment is selected in the Appointment Book listbox.
    /// </summary>
    public class Variables
    {
        public static int appointmentSelected;

    }

}
