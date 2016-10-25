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



    public class Appointment
    {
        public DateTime myDateTime;
        public string apptNotes;
        public bool reminder = false;
        public DateTime reminderDateTime;

        public void SetAppointment(DateTime date, string notes)
        {
            myDateTime = date;
            apptNotes = notes;
        }

        public DateTime GetDateTime
        {
            get { return myDateTime; }
            set { myDateTime = value; }
        }

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
    }

    public class Variables
    {
        public static int appointmentSelected;

    }

    



}
