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
            this.customerNamesComboBox = new System.Windows.Forms.ComboBox();
            this.updateCustomerAppointmentButton = new System.Windows.Forms.Button();
            this.customerCountryTxtBox = new System.Windows.Forms.TextBox();
            this.customerCityTxtBox = new System.Windows.Forms.TextBox();
            this.customerAddressTxtBox = new System.Windows.Forms.TextBox();
            this.countryLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.calendarLabel = new System.Windows.Forms.Label();
            this.availableApptLabel = new System.Windows.Forms.Label();
            this.availableTimesRTextBox = new System.Windows.Forms.RichTextBox();
            this.createAppointmentCalendar = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // appNameLabel
            // 
            this.appNameLabel.AutoSize = true;
            this.appNameLabel.Font = new System.Drawing.Font("Goudy Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appNameLabel.Location = new System.Drawing.Point(36, 17);
            this.appNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.appNameLabel.Name = "appNameLabel";
            this.appNameLabel.Size = new System.Drawing.Size(152, 28);
            this.appNameLabel.TabIndex = 28;
            this.appNameLabel.Text = "The Scheduler";
            this.appNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // customerNamesComboBox
            // 
            this.customerNamesComboBox.FormattingEnabled = true;
            this.customerNamesComboBox.Location = new System.Drawing.Point(25, 92);
            this.customerNamesComboBox.Name = "customerNamesComboBox";
            this.customerNamesComboBox.Size = new System.Drawing.Size(175, 21);
            this.customerNamesComboBox.TabIndex = 27;
            // 
            // updateCustomerAppointmentButton
            // 
            this.updateCustomerAppointmentButton.Location = new System.Drawing.Point(61, 319);
            this.updateCustomerAppointmentButton.Name = "updateCustomerAppointmentButton";
            this.updateCustomerAppointmentButton.Size = new System.Drawing.Size(101, 41);
            this.updateCustomerAppointmentButton.TabIndex = 26;
            this.updateCustomerAppointmentButton.Text = "Update Appointment";
            this.updateCustomerAppointmentButton.UseVisualStyleBackColor = true;
            // 
            // customerCountryTxtBox
            // 
            this.customerCountryTxtBox.Location = new System.Drawing.Point(24, 257);
            this.customerCountryTxtBox.Name = "customerCountryTxtBox";
            this.customerCountryTxtBox.Size = new System.Drawing.Size(176, 20);
            this.customerCountryTxtBox.TabIndex = 25;
            // 
            // customerCityTxtBox
            // 
            this.customerCityTxtBox.Location = new System.Drawing.Point(24, 202);
            this.customerCityTxtBox.Name = "customerCityTxtBox";
            this.customerCityTxtBox.Size = new System.Drawing.Size(176, 20);
            this.customerCityTxtBox.TabIndex = 24;
            // 
            // customerAddressTxtBox
            // 
            this.customerAddressTxtBox.Location = new System.Drawing.Point(24, 147);
            this.customerAddressTxtBox.Name = "customerAddressTxtBox";
            this.customerAddressTxtBox.Size = new System.Drawing.Size(176, 20);
            this.customerAddressTxtBox.TabIndex = 23;
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryLabel.Location = new System.Drawing.Point(22, 239);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(51, 15);
            this.countryLabel.TabIndex = 22;
            this.countryLabel.Text = "Country:";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityLabel.Location = new System.Drawing.Point(22, 184);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(29, 15);
            this.cityLabel.TabIndex = 21;
            this.cityLabel.Text = "City:";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.Location = new System.Drawing.Point(22, 129);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(89, 15);
            this.addressLabel.TabIndex = 20;
            this.addressLabel.Text = "Street Address:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(22, 74);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(41, 15);
            this.nameLabel.TabIndex = 19;
            this.nameLabel.Text = "Name";
            // 
            // calendarLabel
            // 
            this.calendarLabel.AutoSize = true;
            this.calendarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendarLabel.Location = new System.Drawing.Point(239, 17);
            this.calendarLabel.Name = "calendarLabel";
            this.calendarLabel.Size = new System.Drawing.Size(65, 15);
            this.calendarLabel.TabIndex = 18;
            this.calendarLabel.Text = "Calendar";
            // 
            // availableApptLabel
            // 
            this.availableApptLabel.AutoSize = true;
            this.availableApptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availableApptLabel.Location = new System.Drawing.Point(238, 217);
            this.availableApptLabel.Name = "availableApptLabel";
            this.availableApptLabel.Size = new System.Drawing.Size(192, 15);
            this.availableApptLabel.TabIndex = 17;
            this.availableApptLabel.Text = "Available Appointment Times";
            // 
            // availableTimesRTextBox
            // 
            this.availableTimesRTextBox.Location = new System.Drawing.Point(241, 236);
            this.availableTimesRTextBox.Name = "availableTimesRTextBox";
            this.availableTimesRTextBox.Size = new System.Drawing.Size(227, 153);
            this.availableTimesRTextBox.TabIndex = 16;
            this.availableTimesRTextBox.Text = "";
            // 
            // createAppointmentCalendar
            // 
            this.createAppointmentCalendar.Location = new System.Drawing.Point(241, 35);
            this.createAppointmentCalendar.MaxSelectionCount = 1;
            this.createAppointmentCalendar.Name = "createAppointmentCalendar";
            this.createAppointmentCalendar.TabIndex = 15;
            // 
            // ModifyApptsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 468);
            this.Controls.Add(this.appNameLabel);
            this.Controls.Add(this.customerNamesComboBox);
            this.Controls.Add(this.updateCustomerAppointmentButton);
            this.Controls.Add(this.customerCountryTxtBox);
            this.Controls.Add(this.customerCityTxtBox);
            this.Controls.Add(this.customerAddressTxtBox);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.calendarLabel);
            this.Controls.Add(this.availableApptLabel);
            this.Controls.Add(this.availableTimesRTextBox);
            this.Controls.Add(this.createAppointmentCalendar);
            this.Name = "ModifyApptsForm";
            this.Text = "Modify Appointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label appNameLabel;
        private System.Windows.Forms.ComboBox customerNamesComboBox;
        private System.Windows.Forms.Button updateCustomerAppointmentButton;
        private System.Windows.Forms.TextBox customerCountryTxtBox;
        private System.Windows.Forms.TextBox customerCityTxtBox;
        private System.Windows.Forms.TextBox customerAddressTxtBox;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label calendarLabel;
        private System.Windows.Forms.Label availableApptLabel;
        private System.Windows.Forms.RichTextBox availableTimesRTextBox;
        private System.Windows.Forms.MonthCalendar createAppointmentCalendar;
    }
}