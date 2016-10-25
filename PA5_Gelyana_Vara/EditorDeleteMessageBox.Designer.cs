namespace PA5_Gelyana_Vara
{
    partial class EditorDeleteMessageBox
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
            this.label1 = new System.Windows.Forms.Label();
            this.edit_Appointment = new System.Windows.Forms.Button();
            this.delete_Appointment = new System.Windows.Forms.Button();
            this.btn_CancelEditOrDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Would you like to Edit or Delete\nthis appointment?";
            // 
            // edit_Appointment
            // 
            this.edit_Appointment.Location = new System.Drawing.Point(90, 75);
            this.edit_Appointment.Name = "edit_Appointment";
            this.edit_Appointment.Size = new System.Drawing.Size(85, 34);
            this.edit_Appointment.TabIndex = 1;
            this.edit_Appointment.Text = "Edit";
            this.edit_Appointment.UseVisualStyleBackColor = true;
            this.edit_Appointment.Click += new System.EventHandler(this.edit_Appointment_Click);
            // 
            // delete_Appointment
            // 
            this.delete_Appointment.Location = new System.Drawing.Point(195, 75);
            this.delete_Appointment.Name = "delete_Appointment";
            this.delete_Appointment.Size = new System.Drawing.Size(85, 34);
            this.delete_Appointment.TabIndex = 2;
            this.delete_Appointment.Text = "Delete";
            this.delete_Appointment.UseVisualStyleBackColor = true;
            this.delete_Appointment.Click += new System.EventHandler(this.delete_Appointment_Click);
            // 
            // btn_CancelEditOrDelete
            // 
            this.btn_CancelEditOrDelete.Location = new System.Drawing.Point(318, 119);
            this.btn_CancelEditOrDelete.Name = "btn_CancelEditOrDelete";
            this.btn_CancelEditOrDelete.Size = new System.Drawing.Size(81, 29);
            this.btn_CancelEditOrDelete.TabIndex = 3;
            this.btn_CancelEditOrDelete.Text = "Cancel";
            this.btn_CancelEditOrDelete.UseVisualStyleBackColor = true;
            this.btn_CancelEditOrDelete.Click += new System.EventHandler(this.btn_CancelEditOrDelete_Click);
            // 
            // EditorDeleteMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 151);
            this.ControlBox = false;
            this.Controls.Add(this.btn_CancelEditOrDelete);
            this.Controls.Add(this.delete_Appointment);
            this.Controls.Add(this.edit_Appointment);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditorDeleteMessageBox";
            this.ShowInTaskbar = false;
            this.Text = "EditorDeleteMessageBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button edit_Appointment;
        private System.Windows.Forms.Button delete_Appointment;
        private System.Windows.Forms.Button btn_CancelEditOrDelete;
    }
}