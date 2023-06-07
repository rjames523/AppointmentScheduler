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
            this.createAppointmentCalendar = new System.Windows.Forms.MonthCalendar();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.availableApptLabel = new System.Windows.Forms.Label();
            this.calendarLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.countryLabel = new System.Windows.Forms.Label();
            this.customerAddressTxtBox = new System.Windows.Forms.TextBox();
            this.customerCityTxtBox = new System.Windows.Forms.TextBox();
            this.customerCountryTxtBox = new System.Windows.Forms.TextBox();
            this.createCustomerAppointmentButton = new System.Windows.Forms.Button();
            this.customerNamesComboBox = new System.Windows.Forms.ComboBox();
            this.appNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // createAppointmentCalendar
            // 
            this.createAppointmentCalendar.Location = new System.Drawing.Point(241, 35);
            this.createAppointmentCalendar.MaxSelectionCount = 1;
            this.createAppointmentCalendar.Name = "createAppointmentCalendar";
            this.createAppointmentCalendar.TabIndex = 0;
            this.createAppointmentCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.createAppointmentCalendar_DateChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(241, 236);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(227, 153);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // availableApptLabel
            // 
            this.availableApptLabel.AutoSize = true;
            this.availableApptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availableApptLabel.Location = new System.Drawing.Point(238, 217);
            this.availableApptLabel.Name = "availableApptLabel";
            this.availableApptLabel.Size = new System.Drawing.Size(192, 15);
            this.availableApptLabel.TabIndex = 2;
            this.availableApptLabel.Text = "Available Appointment Times";
            // 
            // calendarLabel
            // 
            this.calendarLabel.AutoSize = true;
            this.calendarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendarLabel.Location = new System.Drawing.Point(239, 17);
            this.calendarLabel.Name = "calendarLabel";
            this.calendarLabel.Size = new System.Drawing.Size(65, 15);
            this.calendarLabel.TabIndex = 3;
            this.calendarLabel.Text = "Calendar";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(22, 74);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(41, 15);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Name";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.Location = new System.Drawing.Point(22, 129);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(89, 15);
            this.addressLabel.TabIndex = 5;
            this.addressLabel.Text = "Street Address:";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityLabel.Location = new System.Drawing.Point(22, 184);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(29, 15);
            this.cityLabel.TabIndex = 6;
            this.cityLabel.Text = "City:";
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryLabel.Location = new System.Drawing.Point(22, 239);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(51, 15);
            this.countryLabel.TabIndex = 7;
            this.countryLabel.Text = "Country:";
            // 
            // customerAddressTxtBox
            // 
            this.customerAddressTxtBox.Location = new System.Drawing.Point(24, 147);
            this.customerAddressTxtBox.Name = "customerAddressTxtBox";
            this.customerAddressTxtBox.Size = new System.Drawing.Size(176, 20);
            this.customerAddressTxtBox.TabIndex = 9;
            // 
            // customerCityTxtBox
            // 
            this.customerCityTxtBox.Location = new System.Drawing.Point(24, 202);
            this.customerCityTxtBox.Name = "customerCityTxtBox";
            this.customerCityTxtBox.Size = new System.Drawing.Size(176, 20);
            this.customerCityTxtBox.TabIndex = 10;
            // 
            // customerCountryTxtBox
            // 
            this.customerCountryTxtBox.Location = new System.Drawing.Point(24, 257);
            this.customerCountryTxtBox.Name = "customerCountryTxtBox";
            this.customerCountryTxtBox.Size = new System.Drawing.Size(176, 20);
            this.customerCountryTxtBox.TabIndex = 11;
            // 
            // createCustomerAppointmentButton
            // 
            this.createCustomerAppointmentButton.Location = new System.Drawing.Point(61, 319);
            this.createCustomerAppointmentButton.Name = "createCustomerAppointmentButton";
            this.createCustomerAppointmentButton.Size = new System.Drawing.Size(101, 41);
            this.createCustomerAppointmentButton.TabIndex = 12;
            this.createCustomerAppointmentButton.Text = "Create Appointment";
            this.createCustomerAppointmentButton.UseVisualStyleBackColor = true;
            this.createCustomerAppointmentButton.Click += new System.EventHandler(this.createAppointmentButton_Click);
            // 
            // customerNamesComboBox
            // 
            this.customerNamesComboBox.FormattingEnabled = true;
            this.customerNamesComboBox.Location = new System.Drawing.Point(25, 92);
            this.customerNamesComboBox.Name = "customerNamesComboBox";
            this.customerNamesComboBox.Size = new System.Drawing.Size(175, 21);
            this.customerNamesComboBox.TabIndex = 13;
            this.customerNamesComboBox.SelectedIndexChanged += new System.EventHandler(this.customerNamesComboBox_SelectedIndexChanged);
            // 
            // appNameLabel
            // 
            this.appNameLabel.AutoSize = true;
            this.appNameLabel.Font = new System.Drawing.Font("Goudy Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appNameLabel.Location = new System.Drawing.Point(36, 17);
            this.appNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.appNameLabel.Name = "appNameLabel";
            this.appNameLabel.Size = new System.Drawing.Size(152, 28);
            this.appNameLabel.TabIndex = 14;
            this.appNameLabel.Text = "The Scheduler";
            this.appNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CreateAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 404);
            this.Controls.Add(this.appNameLabel);
            this.Controls.Add(this.customerNamesComboBox);
            this.Controls.Add(this.createCustomerAppointmentButton);
            this.Controls.Add(this.customerCountryTxtBox);
            this.Controls.Add(this.customerCityTxtBox);
            this.Controls.Add(this.customerAddressTxtBox);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.calendarLabel);
            this.Controls.Add(this.availableApptLabel);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.createAppointmentCalendar);
            this.Name = "CreateAppointmentForm";
            this.Text = "Create Appointment";
            this.Load += new System.EventHandler(this.CreateAppointmentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar createAppointmentCalendar;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label availableApptLabel;
        private System.Windows.Forms.Label calendarLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.TextBox customerAddressTxtBox;
        private System.Windows.Forms.TextBox customerCityTxtBox;
        private System.Windows.Forms.TextBox customerCountryTxtBox;
        private System.Windows.Forms.Button createCustomerAppointmentButton;
        private System.Windows.Forms.ComboBox customerNamesComboBox;
        private System.Windows.Forms.Label appNameLabel;
    }
}