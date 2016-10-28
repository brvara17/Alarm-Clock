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
    public partial class Form2 : Form
    {
        /// <summary>
        /// This Form is to allow the user to set the alarm
        /// </summary>
        
        //Property to allow the user to set and get alarmTime
        public DateTime alarmTime
        {
            get;
            set;
        }
        
        public Form2()
        {
            InitializeComponent();
        }
       
        //Closes the alarm setting form
        private void closeBtn_Click(object sender, EventArgs e)
        {            
            this.Close();
        }

        //This sets the default values and properties for the datetimepicker
        private void Form1_Load(object sender, EventArgs e)
        {
            alarmTimePick.ShowUpDown = true;
            alarmTimePick.Value = DateTime.Now.Date;
        }

        //This allows the user to set the alarm clock internally and 
        //also set the alarm to display in the main form   
        private void setBtn_Click(object sender, EventArgs e)
        {
            Main.alarmSet = true;
            alarmTime = alarmTimePick.Value;
            Main.alarmHour = alarmTime.Hour;
            Main.alarmMin = alarmTime.Minute;
            Main.alarmSec = alarmTime.Second;
            Main.alarmAmPm = alarmTime.ToString("tt");
            Main.alarmTimeDisplay = alarmTimePick.Value;
        }

    }
}
