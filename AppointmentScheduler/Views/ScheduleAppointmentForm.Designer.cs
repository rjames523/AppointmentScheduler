namespace AppointmentScheduler
{
    partial class ScheduleAppointmentForm
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
            this.contactTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.locationTxtBox = new System.Windows.Forms.TextBox();
            this.urlTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.appNameLabel = new System.Windows.Forms.Label();
            this.scheduleAppointmentButton = new System.Windows.Forms.Button();
            this.typeTxtBox = new System.Windows.Forms.TextBox();
            this.apptDescriptionRTxtBox = new System.Windows.Forms.TextBox();
            this.titleTxtBox = new System.Windows.Forms.TextBox();
            this.countryLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.calendarLabel = new System.Windows.Forms.Label();
            this.custNameComboBox = new System.Windows.Forms.ComboBox();
            this.schedApptDatePicker = new System.Windows.Forms.DateTimePicker();
            this.schedApptStartTimePicker = new System.Windows.Forms.DateTimePicker();
            this.schedApptEndTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contactTxtBox
            // 
            this.contactTxtBox.Location = new System.Drawing.Point(244, 140);
            this.contactTxtBox.Name = "contactTxtBox";
            this.contactTxtBox.Size = new System.Drawing.Size(176, 20);
            this.contactTxtBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(242, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Contact:";
            // 
            // locationTxtBox
            // 
            this.locationTxtBox.Location = new System.Drawing.Point(244, 190);
            this.locationTxtBox.Name = "locationTxtBox";
            this.locationTxtBox.Size = new System.Drawing.Size(176, 20);
            this.locationTxtBox.TabIndex = 10;
            // 
            // urlTxtBox
            // 
            this.urlTxtBox.Location = new System.Drawing.Point(244, 292);
            this.urlTxtBox.Name = "urlTxtBox";
            this.urlTxtBox.Size = new System.Drawing.Size(176, 20);
            this.urlTxtBox.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(242, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Location:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(242, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "URL:";
            // 
            // appNameLabel
            // 
            this.appNameLabel.AutoSize = true;
            this.appNameLabel.Font = new System.Drawing.Font("Goudy Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appNameLabel.Location = new System.Drawing.Point(152, 19);
            this.appNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.appNameLabel.Name = "appNameLabel";
            this.appNameLabel.Size = new System.Drawing.Size(152, 28);
            this.appNameLabel.TabIndex = 0;
            this.appNameLabel.Text = "The Scheduler";
            this.appNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scheduleAppointmentButton
            // 
            this.scheduleAppointmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scheduleAppointmentButton.Location = new System.Drawing.Point(136, 460);
            this.scheduleAppointmentButton.Name = "scheduleAppointmentButton";
            this.scheduleAppointmentButton.Size = new System.Drawing.Size(86, 41);
            this.scheduleAppointmentButton.TabIndex = 21;
            this.scheduleAppointmentButton.Text = "Schedule";
            this.scheduleAppointmentButton.UseVisualStyleBackColor = true;
            this.scheduleAppointmentButton.Click += new System.EventHandler(this.scheduleAppointmentButton_Click);
            // 
            // typeTxtBox
            // 
            this.typeTxtBox.Location = new System.Drawing.Point(244, 239);
            this.typeTxtBox.Name = "typeTxtBox";
            this.typeTxtBox.Size = new System.Drawing.Size(176, 20);
            this.typeTxtBox.TabIndex = 12;
            // 
            // apptDescriptionRTxtBox
            // 
            this.apptDescriptionRTxtBox.Location = new System.Drawing.Point(26, 140);
            this.apptDescriptionRTxtBox.Multiline = true;
            this.apptDescriptionRTxtBox.Name = "apptDescriptionRTxtBox";
            this.apptDescriptionRTxtBox.Size = new System.Drawing.Size(190, 160);
            this.apptDescriptionRTxtBox.TabIndex = 4;
            // 
            // titleTxtBox
            // 
            this.titleTxtBox.Location = new System.Drawing.Point(244, 89);
            this.titleTxtBox.Name = "titleTxtBox";
            this.titleTxtBox.Size = new System.Drawing.Size(176, 20);
            this.titleTxtBox.TabIndex = 6;
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryLabel.Location = new System.Drawing.Point(242, 221);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(36, 15);
            this.countryLabel.TabIndex = 11;
            this.countryLabel.Text = "Type:";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityLabel.Location = new System.Drawing.Point(24, 121);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(72, 15);
            this.cityLabel.TabIndex = 3;
            this.cityLabel.Text = "Description:";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(242, 71);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(33, 15);
            this.titleLabel.TabIndex = 5;
            this.titleLabel.Text = "Title:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(24, 71);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(44, 15);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name:";
            // 
            // calendarLabel
            // 
            this.calendarLabel.AutoSize = true;
            this.calendarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendarLabel.Location = new System.Drawing.Point(26, 327);
            this.calendarLabel.Name = "calendarLabel";
            this.calendarLabel.Size = new System.Drawing.Size(65, 15);
            this.calendarLabel.TabIndex = 15;
            this.calendarLabel.Text = "Calendar";
            // 
            // custNameComboBox
            // 
            this.custNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.custNameComboBox.FormattingEnabled = true;
            this.custNameComboBox.Location = new System.Drawing.Point(26, 86);
            this.custNameComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.custNameComboBox.Name = "custNameComboBox";
            this.custNameComboBox.Size = new System.Drawing.Size(175, 21);
            this.custNameComboBox.TabIndex = 2;
            // 
            // schedApptDatePicker
            // 
            this.schedApptDatePicker.Location = new System.Drawing.Point(26, 344);
            this.schedApptDatePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.schedApptDatePicker.Name = "schedApptDatePicker";
            this.schedApptDatePicker.Size = new System.Drawing.Size(190, 20);
            this.schedApptDatePicker.TabIndex = 16;
            // 
            // schedApptStartTimePicker
            // 
            this.schedApptStartTimePicker.CustomFormat = "hh:mm tt";
            this.schedApptStartTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.schedApptStartTimePicker.Location = new System.Drawing.Point(26, 401);
            this.schedApptStartTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.schedApptStartTimePicker.Name = "schedApptStartTimePicker";
            this.schedApptStartTimePicker.ShowUpDown = true;
            this.schedApptStartTimePicker.Size = new System.Drawing.Size(190, 20);
            this.schedApptStartTimePicker.TabIndex = 18;
            this.schedApptStartTimePicker.ValueChanged += new System.EventHandler(this.schedApptStartTimePicker_ValueChanged);
            // 
            // schedApptEndTimePicker
            // 
            this.schedApptEndTimePicker.CustomFormat = "hh:mm tt";
            this.schedApptEndTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.schedApptEndTimePicker.Location = new System.Drawing.Point(245, 401);
            this.schedApptEndTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.schedApptEndTimePicker.Name = "schedApptEndTimePicker";
            this.schedApptEndTimePicker.ShowUpDown = true;
            this.schedApptEndTimePicker.Size = new System.Drawing.Size(190, 20);
            this.schedApptEndTimePicker.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "Available Start Times";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(242, 384);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 15);
            this.label6.TabIndex = 19;
            this.label6.Text = "Available End Times";
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(234, 460);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(86, 41);
            this.cancelButton.TabIndex = 22;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // ScheduleAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 520);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.schedApptEndTimePicker);
            this.Controls.Add(this.schedApptStartTimePicker);
            this.Controls.Add(this.schedApptDatePicker);
            this.Controls.Add(this.custNameComboBox);
            this.Controls.Add(this.contactTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.locationTxtBox);
            this.Controls.Add(this.urlTxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.appNameLabel);
            this.Controls.Add(this.scheduleAppointmentButton);
            this.Controls.Add(this.typeTxtBox);
            this.Controls.Add(this.apptDescriptionRTxtBox);
            this.Controls.Add(this.titleTxtBox);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.calendarLabel);
            this.Name = "ScheduleAppointmentForm";
            this.Text = "Schedule Appointment";
            this.Load += new System.EventHandler(this.CreateAppointmentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox contactTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox locationTxtBox;
        private System.Windows.Forms.TextBox urlTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label appNameLabel;
        private System.Windows.Forms.Button scheduleAppointmentButton;
        private System.Windows.Forms.TextBox typeTxtBox;
        private System.Windows.Forms.TextBox apptDescriptionRTxtBox;
        private System.Windows.Forms.TextBox titleTxtBox;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label calendarLabel;
        private System.Windows.Forms.ComboBox custNameComboBox;
        private System.Windows.Forms.DateTimePicker schedApptDatePicker;
        private System.Windows.Forms.DateTimePicker schedApptStartTimePicker;
        private System.Windows.Forms.DateTimePicker schedApptEndTimePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button cancelButton;
    }
}