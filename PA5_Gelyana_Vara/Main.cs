using System;
using System.Media;
using System.Windows.Forms;
using WMPLib;

namespace PA5_Gelyana_Vara
{
    public partial class Main : Form
    {
        DateTime currTime = new DateTime();
        SoundPlayer alarmSound = new SoundPlayer(@"C:\Users\Manny\Desktop\Fall 2016\Compe 361\chris.wav");


        public Main()
        {
            InitializeComponent();
            
        }
        public bool alarmSoundStop
        {
            get;
            set;
        }
        public int alarmHour
        {
            get;
            set;
        }

        public int alarmMin
        {
            get;
            set;
        }

        public int alarmSec
        {
            get;
            set;
        }

        public string alarmAmPm
        {
            get;
            set;
        }

        private void clockTimer_Tick(object sender, EventArgs e)
        {
            currTimeLabel.Text = DateTime.Now.ToString("M /dd/yyyy hh:mm:ss tt");
            currTime = DateTime.Now;

            if ((currTime.Hour == alarmHour) && (currTime.Minute == alarmMin) && (currTime.Second == alarmSec)
              && (currTime.ToString("tt") == alarmAmPm))
            {
               alarmSound.Play();              
               
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
                       
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
