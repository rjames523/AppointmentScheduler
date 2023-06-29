namespace AppointmentScheduler
{
    partial class ModifyApptsForm
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
            this.appNameLabel = new System.Windows.Forms.Label();
            this.updateApptButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.calendarLabel = new System.Windows.Forms.Label();
            this.typeTxtBox = new System.Windows.Forms.TextBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.countryLabel = new System.Windows.Forms.Label();
            this.titleTxtBox = new System.Windows.Forms.TextBox();
            this.apptDescriptionRTxtBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.custNameTxtBox = new System.Windows.Forms.TextBox();
            this.locationTxtBox = new System.Windows.Forms.TextBox();
            this.urlTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.contactTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.apptStartTimeTxtBox = new System.Windows.Forms.TextBox();
            this.apptEndTimeTxtBox = new System.Windows.Forms.TextBox();
            this.apptDatePicker = new System.Windows.Forms.DateTimePicker();
            this.apptDateTxtBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.schedApptEndTimePicker = new System.Windows.Forms.DateTimePicker();
            this.schedApptStartTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // appNameLabel
            // 
            this.appNameLabel.AutoSize = true;
            this.appNameLabel.Font = new System.Drawing.Font("Goudy Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appNameLabel.Location = new System.Drawing.Point(201, 21);
            this.appNameLabel.Name = "appNameLabel";
            this.appNameLabel.Size = new System.Drawing.Size(194, 34);
            this.appNameLabel.TabIndex = 28;
            this.appNameLabel.Text = "The Scheduler";
            this.appNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // updateApptButton
            // 
            this.updateApptButton.Location = new System.Drawing.Point(144, 673);
            this.updateApptButton.Margin = new System.Windows.Forms.Padding(4);
            this.updateApptButton.Name = "updateApptButton";
            this.updateApptButton.Size = new System.Drawing.Size(135, 50);
            this.updateApptButton.TabIndex = 26;
            this.updateApptButton.Text = "Update";
            this.updateApptButton.UseVisualStyleBackColor = true;
            this.updateApptButton.Click += new System.EventHandler(this.updateApptButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(29, 91);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(52, 18);
            this.nameLabel.TabIndex = 19;
            this.nameLabel.Text = "Name:";
            // 
            // calendarLabel
            // 
            this.calendarLabel.AutoSize = true;
            this.calendarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendarLabel.Location = new System.Drawing.Point(29, 501);
            this.calendarLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.calendarLabel.Name = "calendarLabel";
            this.calendarLabel.Size = new System.Drawing.Size(111, 18);
            this.calendarLabel.TabIndex = 18;
            this.calendarLabel.Text = "Select a date:";
            // 
            // typeTxtBox
            // 
            this.typeTxtBox.Location = new System.Drawing.Point(312, 307);
            this.typeTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.typeTxtBox.Name = "typeTxtBox";
            this.typeTxtBox.Size = new System.Drawing.Size(254, 22);
            this.typeTxtBox.TabIndex = 25;
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityLabel.Location = new System.Drawing.Point(29, 153);
            this.cityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(87, 18);
            this.cityLabel.TabIndex = 21;
            this.cityLabel.Text = "Description:";
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryLabel.Location = new System.Drawing.Point(309, 285);
            this.countryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(44, 18);
            this.countryLabel.TabIndex = 22;
            this.countryLabel.Text = "Type:";
            // 
            // titleTxtBox
            // 
            this.titleTxtBox.Location = new System.Drawing.Point(312, 113);
            this.titleTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.titleTxtBox.Name = "titleTxtBox";
            this.titleTxtBox.Size = new System.Drawing.Size(254, 22);
            this.titleTxtBox.TabIndex = 23;
            // 
            // apptDescriptionRTxtBox
            // 
            this.apptDescriptionRTxtBox.Location = new System.Drawing.Point(32, 176);
            this.apptDescriptionRTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.apptDescriptionRTxtBox.Multiline = true;
            this.apptDescriptionRTxtBox.Name = "apptDescriptionRTxtBox";
            this.apptDescriptionRTxtBox.Size = new System.Drawing.Size(260, 196);
            this.apptDescriptionRTxtBox.TabIndex = 24;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(309, 91);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(39, 18);
            this.titleLabel.TabIndex = 20;
            this.titleLabel.Text = "Title:";
            // 
            // custNameTxtBox
            // 
            this.custNameTxtBox.Enabled = false;
            this.custNameTxtBox.Location = new System.Drawing.Point(32, 113);
            this.custNameTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.custNameTxtBox.Name = "custNameTxtBox";
            this.custNameTxtBox.Size = new System.Drawing.Size(260, 22);
            this.custNameTxtBox.TabIndex = 29;
            // 
            // locationTxtBox
            // 
            this.locationTxtBox.Location = new System.Drawing.Point(312, 239);
            this.locationTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.locationTxtBox.Name = "locationTxtBox";
            this.locationTxtBox.Size = new System.Drawing.Size(254, 22);
            this.locationTxtBox.TabIndex = 33;
            // 
            // urlTxtBox
            // 
            this.urlTxtBox.Location = new System.Drawing.Point(312, 373);
            this.urlTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.urlTxtBox.Name = "urlTxtBox";
            this.urlTxtBox.Size = new System.Drawing.Size(254, 22);
            this.urlTxtBox.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 217);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 18);
            this.label1.TabIndex = 31;
            this.label1.Text = "Location:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(309, 350);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 18);
            this.label2.TabIndex = 30;
            this.label2.Text = "URL:";
            // 
            // contactTxtBox
            // 
            this.contactTxtBox.Location = new System.Drawing.Point(312, 176);
            this.contactTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.contactTxtBox.Name = "contactTxtBox";
            this.contactTxtBox.Size = new System.Drawing.Size(254, 22);
            this.contactTxtBox.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(309, 154);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 18);
            this.label3.TabIndex = 34;
            this.label3.Text = "Contact:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 406);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(257, 18);
            this.label4.TabIndex = 36;
            this.label4.Text = "Currently Scheduled Appointment";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(219, 432);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 37;
            this.label5.Text = "Start Time:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(388, 431);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 18);
            this.label6.TabIndex = 38;
            this.label6.Text = "End Time:";
            // 
            // apptStartTimeTxtBox
            // 
            this.apptStartTimeTxtBox.Location = new System.Drawing.Point(219, 452);
            this.apptStartTimeTxtBox.Name = "apptStartTimeTxtBox";
            this.apptStartTimeTxtBox.Size = new System.Drawing.Size(131, 22);
            this.apptStartTimeTxtBox.TabIndex = 39;
            // 
            // apptEndTimeTxtBox
            // 
            this.apptEndTimeTxtBox.Location = new System.Drawing.Point(391, 452);
            this.apptEndTimeTxtBox.Name = "apptEndTimeTxtBox";
            this.apptEndTimeTxtBox.Size = new System.Drawing.Size(131, 22);
            this.apptEndTimeTxtBox.TabIndex = 40;
            // 
            // apptDatePicker
            // 
            this.apptDatePicker.Location = new System.Drawing.Point(32, 523);
            this.apptDatePicker.Name = "apptDatePicker";
            this.apptDatePicker.Size = new System.Drawing.Size(248, 22);
            this.apptDatePicker.TabIndex = 41;
            this.apptDatePicker.ValueChanged += new System.EventHandler(this.apptDateTimePicker_ValueChanged);
            this.apptDatePicker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.apptDatePicker_KeyDown);
            // 
            // apptDateTxtBox
            // 
            this.apptDateTxtBox.Location = new System.Drawing.Point(32, 452);
            this.apptDateTxtBox.Name = "apptDateTxtBox";
            this.apptDateTxtBox.Size = new System.Drawing.Size(151, 22);
            this.apptDateTxtBox.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 432);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 18);
            this.label7.TabIndex = 42;
            this.label7.Text = "Date:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(320, 576);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 18);
            this.label8.TabIndex = 46;
            this.label8.Text = "End Time";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(29, 576);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 18);
            this.label9.TabIndex = 44;
            this.label9.Text = "Start Time";
            // 
            // schedApptEndTimePicker
            // 
            this.schedApptEndTimePicker.CustomFormat = "hh:mm tt";
            this.schedApptEndTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.schedApptEndTimePicker.Location = new System.Drawing.Point(324, 597);
            this.schedApptEndTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.schedApptEndTimePicker.Name = "schedApptEndTimePicker";
            this.schedApptEndTimePicker.ShowUpDown = true;
            this.schedApptEndTimePicker.Size = new System.Drawing.Size(198, 22);
            this.schedApptEndTimePicker.TabIndex = 47;
            // 
            // schedApptStartTimePicker
            // 
            this.schedApptStartTimePicker.CustomFormat = "hh:mm tt";
            this.schedApptStartTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.schedApptStartTimePicker.Location = new System.Drawing.Point(32, 597);
            this.schedApptStartTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.schedApptStartTimePicker.Name = "schedApptStartTimePicker";
            this.schedApptStartTimePicker.ShowUpDown = true;
            this.schedApptStartTimePicker.Size = new System.Drawing.Size(198, 22);
            this.schedApptStartTimePicker.TabIndex = 45;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(317, 673);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(135, 50);
            this.cancelButton.TabIndex = 48;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // ModifyApptsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 754);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.schedApptEndTimePicker);
            this.Controls.Add(this.schedApptStartTimePicker);
            this.Controls.Add(this.apptDateTxtBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.apptDatePicker);
            this.Controls.Add(this.apptEndTimeTxtBox);
            this.Controls.Add(this.apptStartTimeTxtBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.contactTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.locationTxtBox);
            this.Controls.Add(this.urlTxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.custNameTxtBox);
            this.Controls.Add(this.appNameLabel);
            this.Controls.Add(this.updateApptButton);
            this.Controls.Add(this.typeTxtBox);
            this.Controls.Add(this.apptDescriptionRTxtBox);
            this.Controls.Add(this.titleTxtBox);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.calendarLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ModifyApptsForm";
            this.Text = "The Scheduler - Modify Appointment";
            this.Load += new System.EventHandler(this.ModifyApptsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label appNameLabel;
        private System.Windows.Forms.Button updateApptButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label calendarLabel;
        private System.Windows.Forms.TextBox typeTxtBox;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.TextBox titleTxtBox;
        private System.Windows.Forms.TextBox apptDescriptionRTxtBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox custNameTxtBox;
        private System.Windows.Forms.TextBox locationTxtBox;
        private System.Windows.Forms.TextBox urlTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox contactTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox apptStartTimeTxtBox;
        private System.Windows.Forms.TextBox apptEndTimeTxtBox;
        private System.Windows.Forms.DateTimePicker apptDatePicker;
        private System.Windows.Forms.TextBox apptDateTxtBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker schedApptEndTimePicker;
        private System.Windows.Forms.DateTimePicker schedApptStartTimePicker;
        private System.Windows.Forms.Button cancelButton;
    }
}