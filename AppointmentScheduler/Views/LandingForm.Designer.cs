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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.viewReportsButton = new System.Windows.Forms.Button();
            this.viewReportsLabel = new System.Windows.Forms.Label();
            this.customersGroupBox.SuspendLayout();
            this.appointmentsGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // appNameLabel
            // 
            this.appNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.appNameLabel.AutoSize = true;
            this.appNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appNameLabel.Location = new System.Drawing.Point(240, 27);
            this.appNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.appNameLabel.Name = "appNameLabel";
            this.appNameLabel.Size = new System.Drawing.Size(185, 29);
            this.appNameLabel.TabIndex = 0;
            this.appNameLabel.Text = "The Scheduler";
            this.appNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // customersGroupBox
            // 
            this.customersGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customersGroupBox.Controls.Add(this.addCustomersButton);
            this.customersGroupBox.Controls.Add(this.addCustomersLabel);
            this.customersGroupBox.Controls.Add(this.viewCustomersButton);
            this.customersGroupBox.Controls.Add(this.viewCustomersLabel);
            this.customersGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customersGroupBox.Location = new System.Drawing.Point(14, 85);
            this.customersGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.customersGroupBox.Name = "customersGroupBox";
            this.customersGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.customersGroupBox.Size = new System.Drawing.Size(299, 167);
            this.customersGroupBox.TabIndex = 1;
            this.customersGroupBox.TabStop = false;
            this.customersGroupBox.Text = "Customers";
            // 
            // addCustomersButton
            // 
            this.addCustomersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCustomersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCustomersButton.Location = new System.Drawing.Point(12, 103);
            this.addCustomersButton.Margin = new System.Windows.Forms.Padding(2);
            this.addCustomersButton.Name = "addCustomersButton";
            this.addCustomersButton.Size = new System.Drawing.Size(80, 32);
            this.addCustomersButton.TabIndex = 2;
            this.addCustomersButton.Text = "Add";
            this.addCustomersButton.UseVisualStyleBackColor = true;
            this.addCustomersButton.Click += new System.EventHandler(this.addCustomersButton_Click);
            // 
            // addCustomersLabel
            // 
            this.addCustomersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCustomersLabel.Location = new System.Drawing.Point(96, 113);
            this.addCustomersLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addCustomersLabel.Name = "addCustomersLabel";
            this.addCustomersLabel.Size = new System.Drawing.Size(178, 33);
            this.addCustomersLabel.TabIndex = 3;
            this.addCustomersLabel.Text = "Add a new customer";
            // 
            // viewCustomersButton
            // 
            this.viewCustomersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewCustomersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewCustomersButton.Location = new System.Drawing.Point(12, 41);
            this.viewCustomersButton.Margin = new System.Windows.Forms.Padding(2);
            this.viewCustomersButton.Name = "viewCustomersButton";
            this.viewCustomersButton.Size = new System.Drawing.Size(80, 32);
            this.viewCustomersButton.TabIndex = 0;
            this.viewCustomersButton.Text = "View";
            this.viewCustomersButton.UseVisualStyleBackColor = true;
            this.viewCustomersButton.Click += new System.EventHandler(this.viewCustomersButton_Click);
            // 
            // viewCustomersLabel
            // 
            this.viewCustomersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewCustomersLabel.Location = new System.Drawing.Point(96, 43);
            this.viewCustomersLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.viewCustomersLabel.Name = "viewCustomersLabel";
            this.viewCustomersLabel.Size = new System.Drawing.Size(178, 28);
            this.viewCustomersLabel.TabIndex = 1;
            this.viewCustomersLabel.Text = "View, edit, or remove current customers";
            // 
            // appointmentsGroupBox
            // 
            this.appointmentsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.appointmentsGroupBox.Controls.Add(this.scheduleNewApptLabel);
            this.appointmentsGroupBox.Controls.Add(this.viewCurrApptsButton);
            this.appointmentsGroupBox.Controls.Add(this.scheduleNewApptButton);
            this.appointmentsGroupBox.Controls.Add(this.viewCurrApptsLabel);
            this.appointmentsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentsGroupBox.Location = new System.Drawing.Point(351, 85);
            this.appointmentsGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.appointmentsGroupBox.Name = "appointmentsGroupBox";
            this.appointmentsGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.appointmentsGroupBox.Size = new System.Drawing.Size(299, 167);
            this.appointmentsGroupBox.TabIndex = 2;
            this.appointmentsGroupBox.TabStop = false;
            this.appointmentsGroupBox.Text = "Appointments";
            // 
            // scheduleNewApptLabel
            // 
            this.scheduleNewApptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scheduleNewApptLabel.Location = new System.Drawing.Point(96, 112);
            this.scheduleNewApptLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.scheduleNewApptLabel.Name = "scheduleNewApptLabel";
            this.scheduleNewApptLabel.Size = new System.Drawing.Size(184, 33);
            this.scheduleNewApptLabel.TabIndex = 3;
            this.scheduleNewApptLabel.Text = "Schedule a new appointment";
            // 
            // viewCurrApptsButton
            // 
            this.viewCurrApptsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewCurrApptsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewCurrApptsButton.Location = new System.Drawing.Point(11, 41);
            this.viewCurrApptsButton.Margin = new System.Windows.Forms.Padding(2);
            this.viewCurrApptsButton.Name = "viewCurrApptsButton";
            this.viewCurrApptsButton.Size = new System.Drawing.Size(80, 32);
            this.viewCurrApptsButton.TabIndex = 0;
            this.viewCurrApptsButton.Text = "View";
            this.viewCurrApptsButton.UseVisualStyleBackColor = true;
            this.viewCurrApptsButton.Click += new System.EventHandler(this.viewApptsButton_Click);
            // 
            // scheduleNewApptButton
            // 
            this.scheduleNewApptButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.scheduleNewApptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scheduleNewApptButton.Location = new System.Drawing.Point(11, 103);
            this.scheduleNewApptButton.Margin = new System.Windows.Forms.Padding(2);
            this.scheduleNewApptButton.Name = "scheduleNewApptButton";
            this.scheduleNewApptButton.Size = new System.Drawing.Size(80, 32);
            this.scheduleNewApptButton.TabIndex = 2;
            this.scheduleNewApptButton.Text = "Schedule";
            this.scheduleNewApptButton.UseVisualStyleBackColor = true;
            this.scheduleNewApptButton.Click += new System.EventHandler(this.scheduleNewApptButton_Click);
            // 
            // viewCurrApptsLabel
            // 
            this.viewCurrApptsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewCurrApptsLabel.Location = new System.Drawing.Point(96, 41);
            this.viewCurrApptsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.viewCurrApptsLabel.Name = "viewCurrApptsLabel";
            this.viewCurrApptsLabel.Size = new System.Drawing.Size(184, 32);
            this.viewCurrApptsLabel.TabIndex = 1;
            this.viewCurrApptsLabel.Text = "View, edit, or cancel upcoming appointments";
            // 
            // logOutButton
            // 
            this.logOutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.logOutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutButton.Location = new System.Drawing.Point(574, 382);
            this.logOutButton.Margin = new System.Windows.Forms.Padding(2);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(80, 32);
            this.logOutButton.TabIndex = 4;
            this.logOutButton.Text = "Log out";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.viewReportsButton);
            this.groupBox1.Controls.Add(this.viewReportsLabel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(183, 270);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(299, 106);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reports";
            // 
            // viewReportsButton
            // 
            this.viewReportsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewReportsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewReportsButton.Location = new System.Drawing.Point(12, 41);
            this.viewReportsButton.Margin = new System.Windows.Forms.Padding(2);
            this.viewReportsButton.Name = "viewReportsButton";
            this.viewReportsButton.Size = new System.Drawing.Size(80, 32);
            this.viewReportsButton.TabIndex = 0;
            this.viewReportsButton.Text = "View";
            this.viewReportsButton.UseVisualStyleBackColor = true;
            this.viewReportsButton.Click += new System.EventHandler(this.viewReportsButton_Click);
            // 
            // viewReportsLabel
            // 
            this.viewReportsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewReportsLabel.Location = new System.Drawing.Point(96, 43);
            this.viewReportsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.viewReportsLabel.Name = "viewReportsLabel";
            this.viewReportsLabel.Size = new System.Drawing.Size(178, 28);
            this.viewReportsLabel.TabIndex = 1;
            this.viewReportsLabel.Text = "View reports based on customer and appointment data";
            // 
            // LandingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 425);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.appointmentsGroupBox);
            this.Controls.Add(this.customersGroupBox);
            this.Controls.Add(this.appNameLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LandingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Scheduler";
            this.Load += new System.EventHandler(this.LandingForm_Load);
            this.customersGroupBox.ResumeLayout(false);
            this.appointmentsGroupBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button viewReportsButton;
        private System.Windows.Forms.Label viewReportsLabel;
    }
}