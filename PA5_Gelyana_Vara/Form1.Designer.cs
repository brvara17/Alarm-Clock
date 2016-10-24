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
            this.dateTimePicker_DateAppt = new System.Windows.Forms.DateTimePicker();
            this.Date = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.reminderTimeLabel = new System.Windows.Forms.Label();
            this.reminderDateLabel = new System.Windows.Forms.Label();
            this.dateTimePicker_ReminderTime = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_ReminderDate = new System.Windows.Forms.DateTimePicker();
            this.rb_Reminder = new System.Windows.Forms.RadioButton();
            this.addApt = new System.Windows.Forms.Button();
            this.rtb_ApptNotes = new System.Windows.Forms.RichTextBox();
            this.Notes = new System.Windows.Forms.Label();
            this.dateTimePicker_TimeAppt = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
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
            this.groupBox1.Controls.Add(this.reminderTimeLabel);
            this.groupBox1.Controls.Add(this.reminderDateLabel);
            this.groupBox1.Controls.Add(this.dateTimePicker_ReminderTime);
            this.groupBox1.Controls.Add(this.dateTimePicker_ReminderDate);
            this.groupBox1.Controls.Add(this.rb_Reminder);
            this.groupBox1.Controls.Add(this.addApt);
            this.groupBox1.Controls.Add(this.rtb_ApptNotes);
            this.groupBox1.Controls.Add(this.Notes);
            this.groupBox1.Controls.Add(this.dateTimePicker_TimeAppt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Date);
            this.groupBox1.Controls.Add(this.dateTimePicker_DateAppt);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(337, 498);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Set New Appointment:";
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
            this.dateTimePicker_ReminderTime.Location = new System.Drawing.Point(166, 456);
            this.dateTimePicker_ReminderTime.Name = "dateTimePicker_ReminderTime";
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
            // rb_Reminder
            // 
            this.rb_Reminder.AutoSize = true;
            this.rb_Reminder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Reminder.Location = new System.Drawing.Point(10, 383);
            this.rb_Reminder.Name = "rb_Reminder";
            this.rb_Reminder.Size = new System.Drawing.Size(136, 24);
            this.rb_Reminder.TabIndex = 8;
            this.rb_Reminder.TabStop = true;
            this.rb_Reminder.Text = "Set Reminder";
            this.rb_Reminder.UseVisualStyleBackColor = true;
            this.rb_Reminder.Click += new System.EventHandler(this.rb_Reminder_CheckedChanged);
            // 
            // addApt
            // 
            this.addApt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addApt.Location = new System.Drawing.Point(7, 445);
            this.addApt.Name = "addApt";
            this.addApt.Size = new System.Drawing.Size(80, 36);
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
            // Appointment_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 528);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Appointment_Book";
            this.Text = "Appointment Book";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.RadioButton rb_Reminder;
        private System.Windows.Forms.DateTimePicker dateTimePicker_ReminderDate;
        private System.Windows.Forms.Label reminderTimeLabel;
        private System.Windows.Forms.Label reminderDateLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker_ReminderTime;
    }
}

