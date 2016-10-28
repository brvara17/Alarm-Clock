﻿using System;
using System.Media;
using System.Windows.Forms;
using WMPLib;

namespace PA5_Gelyana_Vara
{
    public partial class Main : Form
    {
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


        bool reminderOn_Off = false;

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
            
            if(alarmSet)
            {
                alarmLabel.Visible = true;
                alarmLabel.Text = alarmTimeDisplay.ToLongTimeString();
            }
            else
            {
                alarmLabel.Visible = false;

            }

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

            if(reminderOn_Off)
            {
                imageReminder.Visible = !imageReminder.Visible;
                ackBtn.Visible = true;
            }
            else
            {
                ackBtn.Visible = false;
            }


            foreach (Appointment apt in Appointment_Book.appointment_Book)
            {

                if (DateTime.Now.ToString("M/dd/yyyy hh:mm:ss tt") == apt.reminderDateTime.ToString("M/dd/yyyy hh:mm:ss tt"))
                {
                    reminderOn_Off = true;
                    reminderSound.PlayLooping();
                    globalApt = apt;
                }

            }

        }
        
    
        private void alarmBtn_Click(object sender, EventArgs e)
        {
            
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            
            alarmSound.Stop();
            alarmWentOff = false;
            
        }

        private void snzBtn_Click(object sender, EventArgs e)
        {
            SnoozeForm snzFrm1 = new SnoozeForm();
            snzFrm1.ShowDialog();
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

        private void ackBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(globalApt.ToString());
            reminderSound.Stop();
            reminderOn_Off = false;
            imageReminder.Visible = true;

        }
    }
}
