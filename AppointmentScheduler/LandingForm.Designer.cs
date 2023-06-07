namespace AppointmentScheduler
{
    partial class LandingForm
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
            this.customersGroupBox = new System.Windows.Forms.GroupBox();
            this.addCustomersButton = new System.Windows.Forms.Button();
            this.modifyCustomersButton = new System.Windows.Forms.Button();
            this.addCustomersLabel = new System.Windows.Forms.Label();
            this.modifyCustomerInfoLabel = new System.Windows.Forms.Label();
            this.viewCustomersButton = new System.Windows.Forms.Button();
            this.viewCustomersLabel = new System.Windows.Forms.Label();
            this.appointmentsGroupBox = new System.Windows.Forms.GroupBox();
            this.modifyApptLabel = new System.Windows.Forms.Label();
            this.registerNewApptLabel = new System.Windows.Forms.Label();
            this.modifyApptButton = new System.Windows.Forms.Button();
            this.viewCurrApptsButton = new System.Windows.Forms.Button();
            this.scheduleNewApptButton = new System.Windows.Forms.Button();
            this.viewCurrentApptsLabel = new System.Windows.Forms.Label();
            this.logOutButton = new System.Windows.Forms.Button();
            this.customersGroupBox.SuspendLayout();
            this.appointmentsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // appNameLabel
            // 
            this.appNameLabel.AutoSize = true;
            this.appNameLabel.Font = new System.Drawing.Font("Goudy Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appNameLabel.Location = new System.Drawing.Point(256, 27);
            this.appNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.appNameLabel.Name = "appNameLabel";
            this.appNameLabel.Size = new System.Drawing.Size(152, 28);
            this.appNameLabel.TabIndex = 1;
            this.appNameLabel.Text = "The Scheduler";
            this.appNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // customersGroupBox
            // 
            this.customersGroupBox.Controls.Add(this.addCustomersButton);
            this.customersGroupBox.Controls.Add(this.modifyCustomersButton);
            this.customersGroupBox.Controls.Add(this.addCustomersLabel);
            this.customersGroupBox.Controls.Add(this.modifyCustomerInfoLabel);
            this.customersGroupBox.Controls.Add(this.viewCustomersButton);
            this.customersGroupBox.Controls.Add(this.viewCustomersLabel);
            this.customersGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customersGroupBox.Location = new System.Drawing.Point(14, 85);
            this.customersGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.customersGroupBox.Name = "customersGroupBox";
            this.customersGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.customersGroupBox.Size = new System.Drawing.Size(299, 201);
            this.customersGroupBox.TabIndex = 2;
            this.customersGroupBox.TabStop = false;
            this.customersGroupBox.Text = "Customers";
            // 
            // addCustomersButton
            // 
            this.addCustomersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCustomersButton.Location = new System.Drawing.Point(12, 90);
            this.addCustomersButton.Margin = new System.Windows.Forms.Padding(2);
            this.addCustomersButton.Name = "addCustomersButton";
            this.addCustomersButton.Size = new System.Drawing.Size(80, 32);
            this.addCustomersButton.TabIndex = 6;
            this.addCustomersButton.Text = "Add";
            this.addCustomersButton.UseVisualStyleBackColor = true;
            this.addCustomersButton.Click += new System.EventHandler(this.addCustomersButton_Click);
            // 
            // modifyCustomersButton
            // 
            this.modifyCustomersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyCustomersButton.Location = new System.Drawing.Point(12, 152);
            this.modifyCustomersButton.Margin = new System.Windows.Forms.Padding(2);
            this.modifyCustomersButton.Name = "modifyCustomersButton";
            this.modifyCustomersButton.Size = new System.Drawing.Size(80, 32);
            this.modifyCustomersButton.TabIndex = 4;
            this.modifyCustomersButton.Text = "Modify";
            this.modifyCustomersButton.UseVisualStyleBackColor = true;
            this.modifyCustomersButton.Click += new System.EventHandler(this.modifyCustomersButton_Click);
            // 
            // addCustomersLabel
            // 
            this.addCustomersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCustomersLabel.Location = new System.Drawing.Point(96, 100);
            this.addCustomersLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addCustomersLabel.Name = "addCustomersLabel";
            this.addCustomersLabel.Size = new System.Drawing.Size(178, 33);
            this.addCustomersLabel.TabIndex = 3;
            this.addCustomersLabel.Text = "Add new customers";
            // 
            // modifyCustomerInfoLabel
            // 
            this.modifyCustomerInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyCustomerInfoLabel.Location = new System.Drawing.Point(96, 162);
            this.modifyCustomerInfoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.modifyCustomerInfoLabel.Name = "modifyCustomerInfoLabel";
            this.modifyCustomerInfoLabel.Size = new System.Drawing.Size(178, 33);
            this.modifyCustomerInfoLabel.TabIndex = 2;
            this.modifyCustomerInfoLabel.Text = "Modify customer information";
            // 
            // viewCustomersButton
            // 
            this.viewCustomersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewCustomersButton.Location = new System.Drawing.Point(12, 28);
            this.viewCustomersButton.Margin = new System.Windows.Forms.Padding(2);
            this.viewCustomersButton.Name = "viewCustomersButton";
            this.viewCustomersButton.Size = new System.Drawing.Size(80, 32);
            this.viewCustomersButton.TabIndex = 1;
            this.viewCustomersButton.Text = "View";
            this.viewCustomersButton.UseVisualStyleBackColor = true;
            this.viewCustomersButton.Click += new System.EventHandler(this.viewCustomersButton_Click);
            // 
            // viewCustomersLabel
            // 
            this.viewCustomersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewCustomersLabel.Location = new System.Drawing.Point(96, 38);
            this.viewCustomersLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.viewCustomersLabel.Name = "viewCustomersLabel";
            this.viewCustomersLabel.Size = new System.Drawing.Size(178, 33);
            this.viewCustomersLabel.TabIndex = 0;
            this.viewCustomersLabel.Text = "View all current customers";
            // 
            // appointmentsGroupBox
            // 
            this.appointmentsGroupBox.Controls.Add(this.modifyApptLabel);
            this.appointmentsGroupBox.Controls.Add(this.registerNewApptLabel);
            this.appointmentsGroupBox.Controls.Add(this.modifyApptButton);
            this.appointmentsGroupBox.Controls.Add(this.viewCurrApptsButton);
            this.appointmentsGroupBox.Controls.Add(this.scheduleNewApptButton);
            this.appointmentsGroupBox.Controls.Add(this.viewCurrentApptsLabel);
            this.appointmentsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentsGroupBox.Location = new System.Drawing.Point(351, 85);
            this.appointmentsGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.appointmentsGroupBox.Name = "appointmentsGroupBox";
            this.appointmentsGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.appointmentsGroupBox.Size = new System.Drawing.Size(299, 201);
            this.appointmentsGroupBox.TabIndex = 3;
            this.appointmentsGroupBox.TabStop = false;
            this.appointmentsGroupBox.Text = "Appointments";
            // 
            // modifyApptLabel
            // 
            this.modifyApptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyApptLabel.Location = new System.Drawing.Point(96, 162);
            this.modifyApptLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.modifyApptLabel.Name = "modifyApptLabel";
            this.modifyApptLabel.Size = new System.Drawing.Size(184, 33);
            this.modifyApptLabel.TabIndex = 8;
            this.modifyApptLabel.Text = "Modify an upcoming customer appointment";
            // 
            // registerNewApptLabel
            // 
            this.registerNewApptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerNewApptLabel.Location = new System.Drawing.Point(96, 100);
            this.registerNewApptLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.registerNewApptLabel.Name = "registerNewApptLabel";
            this.registerNewApptLabel.Size = new System.Drawing.Size(184, 33);
            this.registerNewApptLabel.TabIndex = 7;
            this.registerNewApptLabel.Text = "Schedule a new appointment";
            // 
            // modifyApptButton
            // 
            this.modifyApptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyApptButton.Location = new System.Drawing.Point(12, 152);
            this.modifyApptButton.Margin = new System.Windows.Forms.Padding(2);
            this.modifyApptButton.Name = "modifyApptButton";
            this.modifyApptButton.Size = new System.Drawing.Size(80, 32);
            this.modifyApptButton.TabIndex = 6;
            this.modifyApptButton.Text = "Modify";
            this.modifyApptButton.UseVisualStyleBackColor = true;
            this.modifyApptButton.Click += new System.EventHandler(this.modifyApptButton_Click);
            // 
            // viewCurrApptsButton
            // 
            this.viewCurrApptsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewCurrApptsButton.Location = new System.Drawing.Point(12, 29);
            this.viewCurrApptsButton.Margin = new System.Windows.Forms.Padding(2);
            this.viewCurrApptsButton.Name = "viewCurrApptsButton";
            this.viewCurrApptsButton.Size = new System.Drawing.Size(80, 32);
            this.viewCurrApptsButton.TabIndex = 2;
            this.viewCurrApptsButton.Text = "View";
            this.viewCurrApptsButton.UseVisualStyleBackColor = true;
            this.viewCurrApptsButton.Click += new System.EventHandler(this.viewApptsButton_Click);
            // 
            // scheduleNewApptButton
            // 
            this.scheduleNewApptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scheduleNewApptButton.Location = new System.Drawing.Point(12, 90);
            this.scheduleNewApptButton.Margin = new System.Windows.Forms.Padding(2);
            this.scheduleNewApptButton.Name = "scheduleNewApptButton";
            this.scheduleNewApptButton.Size = new System.Drawing.Size(80, 32);
            this.scheduleNewApptButton.TabIndex = 5;
            this.scheduleNewApptButton.Text = "Schedule";
            this.scheduleNewApptButton.UseVisualStyleBackColor = true;
            this.scheduleNewApptButton.Click += new System.EventHandler(this.scheduleNewApptButton_Click);
            // 
            // viewCurrentApptsLabel
            // 
            this.viewCurrentApptsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewCurrentApptsLabel.Location = new System.Drawing.Point(96, 38);
            this.viewCurrentApptsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.viewCurrentApptsLabel.Name = "viewCurrentApptsLabel";
            this.viewCurrentApptsLabel.Size = new System.Drawing.Size(184, 33);
            this.viewCurrentApptsLabel.TabIndex = 1;
            this.viewCurrentApptsLabel.Text = "View all upcoming appointments";
            // 
            // logOutButton
            // 
            this.logOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutButton.Location = new System.Drawing.Point(570, 310);
            this.logOutButton.Margin = new System.Windows.Forms.Padding(2);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(80, 32);
            this.logOutButton.TabIndex = 2;
            this.logOutButton.Text = "Log out";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // LandingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 353);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.appointmentsGroupBox);
            this.Controls.Add(this.customersGroupBox);
            this.Controls.Add(this.appNameLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LandingForm";
            this.Text = "The Scheduler";
            this.Load += new System.EventHandler(this.LandingForm_Load);
            this.customersGroupBox.ResumeLayout(false);
            this.appointmentsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label appNameLabel;
        private System.Windows.Forms.GroupBox customersGroupBox;
        private System.Windows.Forms.Label viewCustomersLabel;
        private System.Windows.Forms.GroupBox appointmentsGroupBox;
        private System.Windows.Forms.Label viewCurrentApptsLabel;
        private System.Windows.Forms.Button viewCustomersButton;
        private System.Windows.Forms.Button viewCurrApptsButton;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Button addCustomersButton;
        private System.Windows.Forms.Button modifyCustomersButton;
        private System.Windows.Forms.Label addCustomersLabel;
        private System.Windows.Forms.Label modifyCustomerInfoLabel;
        private System.Windows.Forms.Button scheduleNewApptButton;
        private System.Windows.Forms.Label modifyApptLabel;
        private System.Windows.Forms.Label registerNewApptLabel;
        private System.Windows.Forms.Button modifyApptButton;
    }
}