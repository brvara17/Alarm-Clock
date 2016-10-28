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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.currTimeLabel = new System.Windows.Forms.Label();
            this.alarmBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.snzBtn = new System.Windows.Forms.Button();
            this.clockTimer = new System.Windows.Forms.Timer(this.components);
            this.btn_AppointmentBook = new System.Windows.Forms.Button();
            this.snoozeBtn = new System.Windows.Forms.Button();
            this.imageReminder = new System.Windows.Forms.PictureBox();
            this.alarmLabel = new System.Windows.Forms.Label();
            this.ackBtn = new System.Windows.Forms.Button();
            this.alarmTitle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.helpBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imageReminder)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // currTimeLabel
            // 
            this.currTimeLabel.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.currTimeLabel.ForeColor = System.Drawing.Color.Black;
            this.currTimeLabel.Location = new System.Drawing.Point(12, 9);
            this.currTimeLabel.Name = "currTimeLabel";
            this.currTimeLabel.Size = new System.Drawing.Size(241, 68);
            this.currTimeLabel.TabIndex = 0;
            // 
            // alarmBtn
            // 
            this.alarmBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alarmBtn.Location = new System.Drawing.Point(15, 189);
            this.alarmBtn.Name = "alarmBtn";
            this.alarmBtn.Size = new System.Drawing.Size(99, 31);
            this.alarmBtn.TabIndex = 1;
            this.alarmBtn.Text = "Alarm Setting";
            this.alarmBtn.UseVisualStyleBackColor = true;
            this.alarmBtn.Click += new System.EventHandler(this.alarmBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopBtn.Location = new System.Drawing.Point(15, 218);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(99, 31);
            this.stopBtn.TabIndex = 2;
            this.stopBtn.Text = "Stop Alarm";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // snzBtn
            // 
            this.snzBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snzBtn.Location = new System.Drawing.Point(15, 276);
            this.snzBtn.Name = "snzBtn";
            this.snzBtn.Size = new System.Drawing.Size(99, 31);
            this.snzBtn.TabIndex = 3;
            this.snzBtn.Text = "Snooze Setting";
            this.snzBtn.UseVisualStyleBackColor = true;
            this.snzBtn.Click += new System.EventHandler(this.snzBtn_Click);
            // 
            // clockTimer
            // 
            this.clockTimer.Enabled = true;
            this.clockTimer.Interval = 500;
            this.clockTimer.Tick += new System.EventHandler(this.clockTimer_Tick);
            // 
            // btn_AppointmentBook
            // 
            this.btn_AppointmentBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AppointmentBook.Location = new System.Drawing.Point(120, 101);
            this.btn_AppointmentBook.Margin = new System.Windows.Forms.Padding(2);
            this.btn_AppointmentBook.Name = "btn_AppointmentBook";
            this.btn_AppointmentBook.Size = new System.Drawing.Size(122, 27);
            this.btn_AppointmentBook.TabIndex = 4;
            this.btn_AppointmentBook.Text = "Appointment Book";
            this.btn_AppointmentBook.UseVisualStyleBackColor = true;
            this.btn_AppointmentBook.Click += new System.EventHandler(this.btn_AppointmentBook_Click);
            // 
            // snoozeBtn
            // 
            this.snoozeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snoozeBtn.Location = new System.Drawing.Point(15, 247);
            this.snoozeBtn.Name = "snoozeBtn";
            this.snoozeBtn.Size = new System.Drawing.Size(99, 31);
            this.snoozeBtn.TabIndex = 5;
            this.snoozeBtn.Text = "Snooze";
            this.snoozeBtn.UseVisualStyleBackColor = true;
            this.snoozeBtn.Click += new System.EventHandler(this.snoozeBtn_Click);
            // 
            // imageReminder
            // 
            this.imageReminder.Image = ((System.Drawing.Image)(resources.GetObject("imageReminder.Image")));
            this.imageReminder.Location = new System.Drawing.Point(120, 163);
            this.imageReminder.Name = "imageReminder";
            this.imageReminder.Size = new System.Drawing.Size(122, 143);
            this.imageReminder.TabIndex = 6;
            this.imageReminder.TabStop = false;
            // 
            // alarmLabel
            // 
            this.alarmLabel.AutoSize = true;
            this.alarmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.alarmLabel.Location = new System.Drawing.Point(6, 15);
            this.alarmLabel.Name = "alarmLabel";
            this.alarmLabel.Size = new System.Drawing.Size(56, 16);
            this.alarmLabel.TabIndex = 7;
            this.alarmLabel.Text = "00:00:00";
            // 
            // ackBtn
            // 
            this.ackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ackBtn.Location = new System.Drawing.Point(120, 131);
            this.ackBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ackBtn.Name = "ackBtn";
            this.ackBtn.Size = new System.Drawing.Size(122, 27);
            this.ackBtn.TabIndex = 8;
            this.ackBtn.Text = "Acknowledge";
            this.ackBtn.UseVisualStyleBackColor = true;
            this.ackBtn.Visible = false;
            this.ackBtn.Click += new System.EventHandler(this.ackBtn_Click);
            // 
            // alarmTitle
            // 
            this.alarmTitle.AutoSize = true;
            this.alarmTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.alarmTitle.Location = new System.Drawing.Point(13, 0);
            this.alarmTitle.Name = "alarmTitle";
            this.alarmTitle.Size = new System.Drawing.Size(55, 20);
            this.alarmTitle.TabIndex = 9;
            this.alarmTitle.Text = "Alarm";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.alarmLabel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.groupBox1.Location = new System.Drawing.Point(6, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(89, 35);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alarm Time:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.alarmTitle);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Location = new System.Drawing.Point(9, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(104, 209);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // helpBtn
            // 
            this.helpBtn.BackColor = System.Drawing.Color.Yellow;
            this.helpBtn.Location = new System.Drawing.Point(9, 313);
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.Size = new System.Drawing.Size(43, 24);
            this.helpBtn.TabIndex = 12;
            this.helpBtn.Text = "Help?";
            this.helpBtn.UseVisualStyleBackColor = false;
            this.helpBtn.Click += new System.EventHandler(this.helpBtn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(265, 339);
            this.Controls.Add(this.helpBtn);
            this.Controls.Add(this.ackBtn);
            this.Controls.Add(this.imageReminder);
            this.Controls.Add(this.snoozeBtn);
            this.Controls.Add(this.btn_AppointmentBook);
            this.Controls.Add(this.snzBtn);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.alarmBtn);
            this.Controls.Add(this.currTimeLabel);
            this.Controls.Add(this.groupBox2);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Main";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.imageReminder)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.PictureBox imageReminder;
        private System.Windows.Forms.Label alarmLabel;
        private System.Windows.Forms.Button ackBtn;
        private System.Windows.Forms.Label alarmTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button helpBtn;
    }
}