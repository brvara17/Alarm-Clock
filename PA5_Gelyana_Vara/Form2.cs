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
        
        DateTime alarmTime = new DateTime();
        Main main1 = new Main();
        
        public Form2()
        {

            InitializeComponent();

        }
       
        private void closeBtn_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            alarmTimePick.ShowUpDown = true;
            alarmTimePick.Value = DateTime.Now.Date;

        }

      
        private void setBtn_Click(object sender, EventArgs e)
        {
            alarmTime = alarmTimePick.Value;
            main1.alarmHour = alarmTime.Hour;
            main1.alarmMin = alarmTime.Minute;
            main1.alarmSec = alarmTime.Second;
            main1.alarmAmPm = alarmTime.ToString("tt");
            

        }

    }
}
