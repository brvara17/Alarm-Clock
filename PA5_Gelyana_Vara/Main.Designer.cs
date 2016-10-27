namespace PA5_Gelyana_Vara
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.currTimeLabel = new System.Windows.Forms.Label();
            this.alarmBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.snzBtn = new System.Windows.Forms.Button();
            this.clockTimer = new System.Windows.Forms.Timer(this.components);
            this.btn_AppointmentBook = new System.Windows.Forms.Button();
            this.snoozeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // currTimeLabel
            // 
            this.currTimeLabel.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currTimeLabel.ForeColor = System.Drawing.Color.Transparent;
            this.currTimeLabel.Location = new System.Drawing.Point(12, 9);
            this.currTimeLabel.Name = "currTimeLabel";
            this.currTimeLabel.Size = new System.Drawing.Size(318, 68);
            this.currTimeLabel.TabIndex = 0;
            this.currTimeLabel.Text = "label1";
            // 
            // alarmBtn
            // 
            this.alarmBtn.Location = new System.Drawing.Point(18, 131);
            this.alarmBtn.Name = "alarmBtn";
            this.alarmBtn.Size = new System.Drawing.Size(87, 23);
            this.alarmBtn.TabIndex = 1;
            this.alarmBtn.Text = "Alarm Setting";
            this.alarmBtn.UseVisualStyleBackColor = true;
            this.alarmBtn.Click += new System.EventHandler(this.alarmBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.Location = new System.Drawing.Point(18, 160);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(87, 23);
            this.stopBtn.TabIndex = 2;
            this.stopBtn.Text = "Stop Alarm";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // snzBtn
            // 
            this.snzBtn.Location = new System.Drawing.Point(18, 218);
            this.snzBtn.Name = "snzBtn";
            this.snzBtn.Size = new System.Drawing.Size(87, 23);
            this.snzBtn.TabIndex = 3;
            this.snzBtn.Text = "Snooze Setting";
            this.snzBtn.UseVisualStyleBackColor = true;
            this.snzBtn.Click += new System.EventHandler(this.snzBtn_Click);
            // 
            // clockTimer
            // 
            this.clockTimer.Enabled = true;
            this.clockTimer.Interval = 1000;
            this.clockTimer.Tick += new System.EventHandler(this.clockTimer_Tick);
            // 
            // btn_AppointmentBook
            // 
            this.btn_AppointmentBook.Location = new System.Drawing.Point(186, 133);
            this.btn_AppointmentBook.Margin = new System.Windows.Forms.Padding(2);
            this.btn_AppointmentBook.Name = "btn_AppointmentBook";
            this.btn_AppointmentBook.Size = new System.Drawing.Size(111, 27);
            this.btn_AppointmentBook.TabIndex = 4;
            this.btn_AppointmentBook.Text = "Appointment Book";
            this.btn_AppointmentBook.UseVisualStyleBackColor = true;
            this.btn_AppointmentBook.Click += new System.EventHandler(this.btn_AppointmentBook_Click);
            // 
            // snoozeBtn
            // 
            this.snoozeBtn.Location = new System.Drawing.Point(18, 189);
            this.snoozeBtn.Name = "snoozeBtn";
            this.snoozeBtn.Size = new System.Drawing.Size(87, 23);
            this.snoozeBtn.TabIndex = 5;
            this.snoozeBtn.Text = "Snooze";
            this.snoozeBtn.UseVisualStyleBackColor = true;
            this.snoozeBtn.Click += new System.EventHandler(this.snoozeBtn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(342, 278);
            this.Controls.Add(this.snoozeBtn);
            this.Controls.Add(this.btn_AppointmentBook);
            this.Controls.Add(this.snzBtn);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.alarmBtn);
            this.Controls.Add(this.currTimeLabel);
            this.Name = "Main";
            this.Text = " ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label currTimeLabel;
        private System.Windows.Forms.Button alarmBtn;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Button snzBtn;
        private System.Windows.Forms.Timer clockTimer;
        private System.Windows.Forms.Button btn_AppointmentBook;
        private System.Windows.Forms.Button snoozeBtn;
    }
}