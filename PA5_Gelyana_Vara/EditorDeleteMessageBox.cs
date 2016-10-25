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
    public partial class EditorDeleteMessageBox : Form
    {
        public EditorDeleteMessageBox()
        {
            InitializeComponent();
        }

        private void edit_Appointment_Click(object sender, EventArgs e)
        {
            EditorDeleteMessageBox.ActiveForm.Close();
        }

        private void delete_Appointment_Click(object sender, EventArgs e)
        {
            Appointment itemToDelete = new Appointment();
            EditorDeleteMessageBox.ActiveForm.Close();
            itemToDelete = Appointment_Book.appointment_Book.ElementAt(Variables.appointmentSelected);
            Appointment_Book.appointment_Book.Remove(itemToDelete);



            Console.WriteLine("\n\n");
            foreach(Appointment apot in Appointment_Book.appointment_Book)
            {
                Console.WriteLine(apot.ToString());
            }

            Appointment_Book apt = new Appointment_Book();
            apt.reload_lb_AppointmentBook();


        }

        private void btn_CancelEditOrDelete_Click(object sender, EventArgs e)
        {
            EditorDeleteMessageBox.ActiveForm.Close();
        }
        
    }
}
