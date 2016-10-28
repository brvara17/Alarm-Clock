namespace PA5_Gelyana_Vara
{
    partial class Appointment_Book
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Appointment_Book));
            this.dateTimePicker_DateAppt = new System.Windows.Forms.DateTimePicker();
            this.Date = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_DoneDelete = new System.Windows.Forms.Button();
            this.btn_DoneEditing = new System.Windows.Forms.Button();
            this.cb_Reminder = new System.Windows.Forms.CheckBox();
            this.reminderTimeLabel = new System.Windows.Forms.Label();
            this.reminderDateLabel = new System.Windows.Forms.Label();
            this.dateTimePicker_ReminderTime = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_ReminderDate = new System.Windows.Forms.DateTimePicker();
            this.addApt = new System.Windows.Forms.Button();
            this.rtb_ApptNotes = new System.Windows.Forms.RichTextBox();
            this.Notes = new System.Windows.Forms.Label();
            this.dateTimePicker_TimeAppt = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_AppointmentBook = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker_DateAppt
            // 
            this.dateTimePicker_DateAppt.CustomFormat = "yyyy,MM,dd";
            this.dateTimePicker_DateAppt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_DateAppt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_DateAppt.Location = new System.Drawing.Point(10, 77);
            this.dateTimePicker_DateAppt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker_DateAppt.Name = "dateTimePicker_DateAppt";
            this.dateTimePicker_DateAppt.Size = new System.Drawing.Size(302, 26);
            this.dateTimePicker_DateAppt.TabIndex = 0;
            this.dateTimePicker_DateAppt.ValueChanged += new System.EventHandler(this.dateTimePicker_SetAppt_ValueChanged);
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.Location = new System.Drawing.Point(10, 52);
            this.Date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(50, 20);
            this.Date.TabIndex = 1;
            this.Date.Text = "Date:";
            this.Date.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_DoneDelete);
            this.groupBox1.Controls.Add(this.btn_DoneEditing);
            this.groupBox1.Controls.Add(this.cb_Reminder);
            this.groupBox1.Controls.Add(this.reminderTimeLabel);
            this.groupBox1.Controls.Add(this.reminderDateLabel);
            this.groupBox1.Controls.Add(this.dateTimePicker_ReminderTime);
            this.groupBox1.Controls.Add(this.dateTimePicker_ReminderDate);
            this.groupBox1.Controls.Add(this.addApt);
            this.groupBox1.Controls.Add(this.rtb_ApptNotes);
            this.groupBox1.Controls.Add(this.Notes);
            this.groupBox1.Controls.Add(this.dateTimePicker_TimeAppt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Date);
            this.groupBox1.Controls.Add(this.dateTimePicker_DateAppt);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 17);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(338, 498);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Set Appointment:";
            // 
            // btn_DoneDelete
            // 
            this.btn_DoneDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DoneDelete.Location = new System.Drawing.Point(8, 445);
            this.btn_DoneDelete.Name = "btn_DoneDelete";
            this.btn_DoneDelete.Size = new System.Drawing.Size(146, 35);
            this.btn_DoneDelete.TabIndex = 15;
            this.btn_DoneDelete.Text = "Delete";
            this.btn_DoneDelete.UseVisualStyleBackColor = true;
            this.btn_DoneDelete.Visible = false;
            this.btn_DoneDelete.Click += new System.EventHandler(this.btn_DoneDelete_Click);
            // 
            // btn_DoneEditing
            // 
            this.btn_DoneEditing.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DoneEditing.Location = new System.Drawing.Point(8, 445);
            this.btn_DoneEditing.Name = "btn_DoneEditing";
            this.btn_DoneEditing.Size = new System.Drawing.Size(146, 35);
            this.btn_DoneEditing.TabIndex = 14;
            this.btn_DoneEditing.Text = "Done Editing";
            this.btn_DoneEditing.UseVisualStyleBackColor = true;
            this.btn_DoneEditing.Visible = false;
            this.btn_DoneEditing.Click += new System.EventHandler(this.btn_DoneEditing_Click);
            // 
            // cb_Reminder
            // 
            this.cb_Reminder.AutoSize = true;
            this.cb_Reminder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Reminder.Location = new System.Drawing.Point(10, 385);
            this.cb_Reminder.Name = "cb_Reminder";
            this.cb_Reminder.Size = new System.Drawing.Size(142, 24);
            this.cb_Reminder.TabIndex = 13;
            this.cb_Reminder.Text = "Set Reminder:";
            this.cb_Reminder.UseVisualStyleBackColor = true;
            this.cb_Reminder.CheckedChanged += new System.EventHandler(this.cb_Reminder_CheckedChanged);
            // 
            // reminderTimeLabel
            // 
            this.reminderTimeLabel.AutoSize = true;
            this.reminderTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reminderTimeLabel.Location = new System.Drawing.Point(170, 432);
            this.reminderTimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.reminderTimeLabel.Name = "reminderTimeLabel";
            this.reminderTimeLabel.Size = new System.Drawing.Size(51, 20);
            this.reminderTimeLabel.TabIndex = 12;
            this.reminderTimeLabel.Text = "Time:";
            this.reminderTimeLabel.Visible = false;
            // 
            // reminderDateLabel
            // 
            this.reminderDateLabel.AutoSize = true;
            this.reminderDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reminderDateLabel.Location = new System.Drawing.Point(171, 378);
            this.reminderDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.reminderDateLabel.Name = "reminderDateLabel";
            this.reminderDateLabel.Size = new System.Drawing.Size(50, 20);
            this.reminderDateLabel.TabIndex = 11;
            this.reminderDateLabel.Text = "Date:";
            this.reminderDateLabel.Visible = false;
            // 
            // dateTimePicker_ReminderTime
            // 
            this.dateTimePicker_ReminderTime.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_ReminderTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_ReminderTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker_ReminderTime.Location = new System.Drawing.Point(166, 455);
            this.dateTimePicker_ReminderTime.Name = "dateTimePicker_ReminderTime";
            this.dateTimePicker_ReminderTime.ShowUpDown = true;
            this.dateTimePicker_ReminderTime.Size = new System.Drawing.Size(146, 26);
            this.dateTimePicker_ReminderTime.TabIndex = 10;
            this.dateTimePicker_ReminderTime.Visible = false;
            // 
            // dateTimePicker_ReminderDate
            // 
            this.dateTimePicker_ReminderDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_ReminderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_ReminderDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_ReminderDate.Location = new System.Drawing.Point(166, 402);
            this.dateTimePicker_ReminderDate.Name = "dateTimePicker_ReminderDate";
            this.dateTimePicker_ReminderDate.Size = new System.Drawing.Size(146, 26);
            this.dateTimePicker_ReminderDate.TabIndex = 9;
            this.dateTimePicker_ReminderDate.Visible = false;
            // 
            // addApt
            // 
            this.addApt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addApt.Location = new System.Drawing.Point(8, 445);
            this.addApt.Name = "addApt";
            this.addApt.Size = new System.Drawing.Size(80, 35);
            this.addApt.TabIndex = 6;
            this.addApt.Text = "Add";
            this.addApt.UseVisualStyleBackColor = true;
            this.addApt.Click += new System.EventHandler(this.addApt_Click);
            // 
            // rtb_ApptNotes
            // 
            this.rtb_ApptNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_ApptNotes.Location = new System.Drawing.Point(10, 231);
            this.rtb_ApptNotes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtb_ApptNotes.Name = "rtb_ApptNotes";
            this.rtb_ApptNotes.Size = new System.Drawing.Size(304, 144);
            this.rtb_ApptNotes.TabIndex = 4;
            this.rtb_ApptNotes.Text = "Enter Appointment Notes";
            this.rtb_ApptNotes.Click += new System.EventHandler(this.rtb_ApptNotes_Click);
            // 
            // Notes
            // 
            this.Notes.AutoSize = true;
            this.Notes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Notes.Location = new System.Drawing.Point(10, 197);
            this.Notes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Notes.Name = "Notes";
            this.Notes.Size = new System.Drawing.Size(58, 20);
            this.Notes.TabIndex = 5;
            this.Notes.Text = "Notes:";
            // 
            // dateTimePicker_TimeAppt
            // 
            this.dateTimePicker_TimeAppt.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_TimeAppt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_TimeAppt.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker_TimeAppt.Location = new System.Drawing.Point(10, 152);
            this.dateTimePicker_TimeAppt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker_TimeAppt.Name = "dateTimePicker_TimeAppt";
            this.dateTimePicker_TimeAppt.ShowUpDown = true;
            this.dateTimePicker_TimeAppt.Size = new System.Drawing.Size(302, 26);
            this.dateTimePicker_TimeAppt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 128);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Time:";
            // 
            // lb_AppointmentBook
            // 
            this.lb_AppointmentBook.FormattingEnabled = true;
            this.lb_AppointmentBook.ItemHeight = 20;
            this.lb_AppointmentBook.Location = new System.Drawing.Point(406, 55);
            this.lb_AppointmentBook.Name = "lb_AppointmentBook";
            this.lb_AppointmentBook.Size = new System.Drawing.Size(512, 464);
            this.lb_AppointmentBook.TabIndex = 4;
            this.lb_AppointmentBook.SelectedIndexChanged += new System.EventHandler(this.lb_AppointmentBook_SelectedIndexChanged);
            this.lb_AppointmentBook.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lb_AppointmentBook_MouseDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(394, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Appointments:";
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(531, 14);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(80, 35);
            this.btn_Edit.TabIndex = 6;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(617, 14);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(80, 35);
            this.btn_Delete.TabIndex = 7;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(700, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "(Double Click to View Appointment)";
            // 
            // Appointment_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 557);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_AppointmentBook);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Appointment_Book";
            this.Text = "Appointment Book";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker_DateAppt;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_TimeAppt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtb_ApptNotes;
        private System.Windows.Forms.Label Notes;
        private System.Windows.Forms.Button addApt;
        private System.Windows.Forms.DateTimePicker dateTimePicker_ReminderDate;
        private System.Windows.Forms.Label reminderTimeLabel;
        private System.Windows.Forms.Label reminderDateLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker_ReminderTime;
        private System.Windows.Forms.CheckBox cb_Reminder;
        private System.Windows.Forms.ListBox lb_AppointmentBook;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_DoneEditing;
        private System.Windows.Forms.Button btn_DoneDelete;
        private System.Windows.Forms.Label label3;
    }
}

