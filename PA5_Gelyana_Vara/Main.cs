using System;
using System.Media;
using System.Windows.Forms;
using WMPLib;

namespace PA5_Gelyana_Vara
{
    public partial class Main : Form
    {
        DateTime currTime = new DateTime();
        DateTime snoozeTime = new DateTime();

        SoundPlayer alarmSound = new SoundPlayer(@"C:\Users\Manny\Desktop\Fall 2016\Compe 361\chris.wav");
        

        public Main()
        {
            
            InitializeComponent();
            

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

        public string alarmAmPm
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

        public void Snooze()
        {
            snoozeTime = DateTime.Now;
            snoozeTime = snoozeTime.AddHours(snoozeHour);
            snoozeTime = snoozeTime.AddMinutes(snoozeMin);
            snoozeTime = snoozeTime.AddSeconds(snoozeSec);

        }

        
        private void clockTimer_Tick(object sender, EventArgs e)
        {
            currTimeLabel.Text = DateTime.Now.ToString("M/dd/yyyy hh:mm:ss tt");
            currTime = DateTime.Now;

            

            if ((currTime.Hour == alarmHour) && (currTime.Minute == alarmMin) && (currTime.Second == alarmSec)
              && (currTime.ToString("tt") == alarmAmPm))
            {
                alarmWentOff = true;
               alarmSound.PlayLooping();
                
               
            }


            if (currTime.Hour == snoozeTime.Hour && currTime.Minute == snoozeTime.Minute && currTime.Second == snoozeTime.Second)
            {                
                alarmSound.PlayLooping();
                alarmWentOff = true;
                snoozeSet = true;

            }


            foreach (Appointment apt in Appointment_Book.appointment_Book)
            {

                if (DateTime.Now.ToString("M/dd/yyyy hh:mm:ss tt") == apt.reminderDateTime.ToString("M/dd/yyyy hh:mm:ss tt"))
                {
                    alarmSound.PlayLooping();
                    MessageBox.Show(apt.ToString());
                }

            }

        }
        
    
        private void alarmBtn_Click(object sender, EventArgs e)
        {
            
            Form2 frm2 = new Form2();
            frm2.Show();
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            
            alarmSound.Stop();
            alarmWentOff = false;
            
        }

        private void snzBtn_Click(object sender, EventArgs e)
        {
            SnoozeForm snzFrm1 = new SnoozeForm();
            snzFrm1.Show();
        }

        private void btn_AppointmentBook_Click(object sender, EventArgs e)
        {
            Appointment_Book form1 = new Appointment_Book();
            form1.Show();
        }

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
    }
}
