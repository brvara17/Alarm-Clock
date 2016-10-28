namespace PA5_Gelyana_Vara
{
    partial class SnoozeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SnoozeForm));
            this.btn_SetSnooze = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.hrBox = new System.Windows.Forms.TextBox();
            this.minsBox = new System.Windows.Forms.TextBox();
            this.secsBox = new System.Windows.Forms.TextBox();
            this.hrsLabel = new System.Windows.Forms.Label();
            this.minsLabel = new System.Windows.Forms.Label();
            this.secsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_SetSnooze
            // 
            this.btn_SetSnooze.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SetSnooze.Location = new System.Drawing.Point(26, 82);
            this.btn_SetSnooze.Name = "btn_SetSnooze";
            this.btn_SetSnooze.Size = new System.Drawing.Size(85, 23);
            this.btn_SetSnooze.TabIndex = 1;
            this.btn_SetSnooze.Text = "Set";
            this.btn_SetSnooze.UseVisualStyleBackColor = true;
            this.btn_SetSnooze.Click += new System.EventHandler(this.btn_SetSnooze_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.Location = new System.Drawing.Point(111, 82);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(85, 23);
            this.closeBtn.TabIndex = 2;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // hrBox
            // 
            this.hrBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hrBox.Location = new System.Drawing.Point(45, 31);
            this.hrBox.Name = "hrBox";
            this.hrBox.Size = new System.Drawing.Size(45, 26);
            this.hrBox.TabIndex = 5;
            this.hrBox.Text = "0";
            this.hrBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hrBox_KeyPress);
            // 
            // minsBox
            // 
            this.minsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minsBox.Location = new System.Drawing.Point(90, 31);
            this.minsBox.Name = "minsBox";
            this.minsBox.Size = new System.Drawing.Size(45, 26);
            this.minsBox.TabIndex = 6;
            this.minsBox.Text = "0";
            this.minsBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.minsBox_KeyPress);
            // 
            // secsBox
            // 
            this.secsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secsBox.Location = new System.Drawing.Point(135, 31);
            this.secsBox.Name = "secsBox";
            this.secsBox.Size = new System.Drawing.Size(45, 26);
            this.secsBox.TabIndex = 7;
            this.secsBox.Text = "0";
            this.secsBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.secsBox_KeyPress);
            // 
            // hrsLabel
            // 
            this.hrsLabel.AutoSize = true;
            this.hrsLabel.Location = new System.Drawing.Point(42, 18);
            this.hrsLabel.Name = "hrsLabel";
            this.hrsLabel.Size = new System.Drawing.Size(38, 13);
            this.hrsLabel.TabIndex = 8;
            this.hrsLabel.Text = "Hours:";
            // 
            // minsLabel
            // 
            this.minsLabel.AutoSize = true;
            this.minsLabel.Location = new System.Drawing.Point(87, 17);
            this.minsLabel.Name = "minsLabel";
            this.minsLabel.Size = new System.Drawing.Size(32, 13);
            this.minsLabel.TabIndex = 9;
            this.minsLabel.Text = "Mins:";
            // 
            // secsLabel
            // 
            this.secsLabel.AutoSize = true;
            this.secsLabel.Location = new System.Drawing.Point(132, 18);
            this.secsLabel.Name = "secsLabel";
            this.secsLabel.Size = new System.Drawing.Size(34, 13);
            this.secsLabel.TabIndex = 10;
            this.secsLabel.Text = "Secs:";
            // 
            // SnoozeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 138);
            this.Controls.Add(this.secsLabel);
            this.Controls.Add(this.minsLabel);
            this.Controls.Add(this.hrsLabel);
            this.Controls.Add(this.secsBox);
            this.Controls.Add(this.minsBox);
            this.Controls.Add(this.hrBox);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.btn_SetSnooze);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SnoozeForm";
            this.Text = "Set Snooze";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_SetSnooze;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.TextBox hrBox;
        private System.Windows.Forms.TextBox minsBox;
        private System.Windows.Forms.TextBox secsBox;
        private System.Windows.Forms.Label hrsLabel;
        private System.Windows.Forms.Label minsLabel;
        private System.Windows.Forms.Label secsLabel;
    }
}