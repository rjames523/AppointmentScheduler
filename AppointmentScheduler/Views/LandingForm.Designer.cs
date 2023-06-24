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
            this.addCustomersLabel = new System.Windows.Forms.Label();
            this.viewCustomersButton = new System.Windows.Forms.Button();
            this.viewCustomersLabel = new System.Windows.Forms.Label();
            this.appointmentsGroupBox = new System.Windows.Forms.GroupBox();
            this.scheduleNewApptLabel = new System.Windows.Forms.Label();
            this.viewCurrApptsButton = new System.Windows.Forms.Button();
            this.scheduleNewApptButton = new System.Windows.Forms.Button();
            this.viewCurrApptsLabel = new System.Windows.Forms.Label();
            this.logOutButton = new System.Windows.Forms.Button();
            this.customersGroupBox.SuspendLayout();
            this.appointmentsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // appNameLabel
            // 
            this.appNameLabel.AutoSize = true;
            this.appNameLabel.Font = new System.Drawing.Font("Goudy Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appNameLabel.Location = new System.Drawing.Point(341, 33);
            this.appNameLabel.Name = "appNameLabel";
            this.appNameLabel.Size = new System.Drawing.Size(194, 34);
            this.appNameLabel.TabIndex = 1;
            this.appNameLabel.Text = "The Scheduler";
            this.appNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // customersGroupBox
            // 
            this.customersGroupBox.Controls.Add(this.addCustomersButton);
            this.customersGroupBox.Controls.Add(this.addCustomersLabel);
            this.customersGroupBox.Controls.Add(this.viewCustomersButton);
            this.customersGroupBox.Controls.Add(this.viewCustomersLabel);
            this.customersGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customersGroupBox.Location = new System.Drawing.Point(19, 105);
            this.customersGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customersGroupBox.Name = "customersGroupBox";
            this.customersGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customersGroupBox.Size = new System.Drawing.Size(399, 206);
            this.customersGroupBox.TabIndex = 2;
            this.customersGroupBox.TabStop = false;
            this.customersGroupBox.Text = "Customers";
            // 
            // addCustomersButton
            // 
            this.addCustomersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCustomersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCustomersButton.Location = new System.Drawing.Point(16, 127);
            this.addCustomersButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addCustomersButton.Name = "addCustomersButton";
            this.addCustomersButton.Size = new System.Drawing.Size(107, 39);
            this.addCustomersButton.TabIndex = 6;
            this.addCustomersButton.Text = "Add";
            this.addCustomersButton.UseVisualStyleBackColor = true;
            this.addCustomersButton.Click += new System.EventHandler(this.addCustomersButton_Click);
            // 
            // addCustomersLabel
            // 
            this.addCustomersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCustomersLabel.Location = new System.Drawing.Point(128, 139);
            this.addCustomersLabel.Name = "addCustomersLabel";
            this.addCustomersLabel.Size = new System.Drawing.Size(237, 41);
            this.addCustomersLabel.TabIndex = 3;
            this.addCustomersLabel.Text = "Add a new customer";
            // 
            // viewCustomersButton
            // 
            this.viewCustomersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewCustomersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewCustomersButton.Location = new System.Drawing.Point(16, 50);
            this.viewCustomersButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.viewCustomersButton.Name = "viewCustomersButton";
            this.viewCustomersButton.Size = new System.Drawing.Size(107, 39);
            this.viewCustomersButton.TabIndex = 1;
            this.viewCustomersButton.Text = "View";
            this.viewCustomersButton.UseVisualStyleBackColor = true;
            this.viewCustomersButton.Click += new System.EventHandler(this.viewCustomersButton_Click);
            // 
            // viewCustomersLabel
            // 
            this.viewCustomersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewCustomersLabel.Location = new System.Drawing.Point(128, 53);
            this.viewCustomersLabel.Name = "viewCustomersLabel";
            this.viewCustomersLabel.Size = new System.Drawing.Size(237, 35);
            this.viewCustomersLabel.TabIndex = 0;
            this.viewCustomersLabel.Text = "View, edit, or remove current customers";
            // 
            // appointmentsGroupBox
            // 
            this.appointmentsGroupBox.Controls.Add(this.scheduleNewApptLabel);
            this.appointmentsGroupBox.Controls.Add(this.viewCurrApptsButton);
            this.appointmentsGroupBox.Controls.Add(this.scheduleNewApptButton);
            this.appointmentsGroupBox.Controls.Add(this.viewCurrApptsLabel);
            this.appointmentsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentsGroupBox.Location = new System.Drawing.Point(468, 105);
            this.appointmentsGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.appointmentsGroupBox.Name = "appointmentsGroupBox";
            this.appointmentsGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.appointmentsGroupBox.Size = new System.Drawing.Size(399, 206);
            this.appointmentsGroupBox.TabIndex = 3;
            this.appointmentsGroupBox.TabStop = false;
            this.appointmentsGroupBox.Text = "Appointments";
            // 
            // scheduleNewApptLabel
            // 
            this.scheduleNewApptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scheduleNewApptLabel.Location = new System.Drawing.Point(128, 138);
            this.scheduleNewApptLabel.Name = "scheduleNewApptLabel";
            this.scheduleNewApptLabel.Size = new System.Drawing.Size(245, 41);
            this.scheduleNewApptLabel.TabIndex = 7;
            this.scheduleNewApptLabel.Text = "Schedule a new appointment";
            // 
            // viewCurrApptsButton
            // 
            this.viewCurrApptsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewCurrApptsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewCurrApptsButton.Location = new System.Drawing.Point(15, 50);
            this.viewCurrApptsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.viewCurrApptsButton.Name = "viewCurrApptsButton";
            this.viewCurrApptsButton.Size = new System.Drawing.Size(107, 39);
            this.viewCurrApptsButton.TabIndex = 2;
            this.viewCurrApptsButton.Text = "View";
            this.viewCurrApptsButton.UseVisualStyleBackColor = true;
            this.viewCurrApptsButton.Click += new System.EventHandler(this.viewApptsButton_Click);
            // 
            // scheduleNewApptButton
            // 
            this.scheduleNewApptButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.scheduleNewApptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scheduleNewApptButton.Location = new System.Drawing.Point(15, 127);
            this.scheduleNewApptButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.scheduleNewApptButton.Name = "scheduleNewApptButton";
            this.scheduleNewApptButton.Size = new System.Drawing.Size(107, 39);
            this.scheduleNewApptButton.TabIndex = 5;
            this.scheduleNewApptButton.Text = "Schedule";
            this.scheduleNewApptButton.UseVisualStyleBackColor = true;
            this.scheduleNewApptButton.Click += new System.EventHandler(this.scheduleNewApptButton_Click);
            // 
            // viewCurrApptsLabel
            // 
            this.viewCurrApptsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewCurrApptsLabel.Location = new System.Drawing.Point(128, 50);
            this.viewCurrApptsLabel.Name = "viewCurrApptsLabel";
            this.viewCurrApptsLabel.Size = new System.Drawing.Size(245, 39);
            this.viewCurrApptsLabel.TabIndex = 1;
            this.viewCurrApptsLabel.Text = "View, edit, or cancel upcoming appointments";
            // 
            // logOutButton
            // 
            this.logOutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutButton.Location = new System.Drawing.Point(760, 332);
            this.logOutButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(107, 39);
            this.logOutButton.TabIndex = 2;
            this.logOutButton.Text = "Log out";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // LandingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 391);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.appointmentsGroupBox);
            this.Controls.Add(this.customersGroupBox);
            this.Controls.Add(this.appNameLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LandingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label viewCurrApptsLabel;
        private System.Windows.Forms.Button viewCustomersButton;
        private System.Windows.Forms.Button viewCurrApptsButton;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Button addCustomersButton;
        private System.Windows.Forms.Label addCustomersLabel;
        private System.Windows.Forms.Button scheduleNewApptButton;
        private System.Windows.Forms.Label scheduleNewApptLabel;
    }
}