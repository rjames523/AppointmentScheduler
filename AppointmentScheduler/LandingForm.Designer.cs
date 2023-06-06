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
            this.openCustomersButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.appointmentsGroupBox = new System.Windows.Forms.GroupBox();
            this.openApptsButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.customersGroupBox.SuspendLayout();
            this.appointmentsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // appNameLabel
            // 
            this.appNameLabel.AutoSize = true;
            this.appNameLabel.Font = new System.Drawing.Font("Goudy Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appNameLabel.Location = new System.Drawing.Point(188, 27);
            this.appNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.appNameLabel.Name = "appNameLabel";
            this.appNameLabel.Size = new System.Drawing.Size(152, 28);
            this.appNameLabel.TabIndex = 1;
            this.appNameLabel.Text = "The Scheduler";
            this.appNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // customersGroupBox
            // 
            this.customersGroupBox.Controls.Add(this.openCustomersButton);
            this.customersGroupBox.Controls.Add(this.label1);
            this.customersGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customersGroupBox.Location = new System.Drawing.Point(53, 99);
            this.customersGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.customersGroupBox.Name = "customersGroupBox";
            this.customersGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.customersGroupBox.Size = new System.Drawing.Size(187, 132);
            this.customersGroupBox.TabIndex = 2;
            this.customersGroupBox.TabStop = false;
            this.customersGroupBox.Text = "Customers";
            // 
            // openCustomersButton
            // 
            this.openCustomersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openCustomersButton.Location = new System.Drawing.Point(52, 68);
            this.openCustomersButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.openCustomersButton.Name = "openCustomersButton";
            this.openCustomersButton.Size = new System.Drawing.Size(80, 32);
            this.openCustomersButton.TabIndex = 1;
            this.openCustomersButton.Text = "Open";
            this.openCustomersButton.UseVisualStyleBackColor = true;
            this.openCustomersButton.Click += new System.EventHandler(this.openCustomersButton_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "View, edit, and remove customers";
            // 
            // appointmentsGroupBox
            // 
            this.appointmentsGroupBox.Controls.Add(this.openApptsButton);
            this.appointmentsGroupBox.Controls.Add(this.label2);
            this.appointmentsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentsGroupBox.Location = new System.Drawing.Point(281, 99);
            this.appointmentsGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.appointmentsGroupBox.Name = "appointmentsGroupBox";
            this.appointmentsGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.appointmentsGroupBox.Size = new System.Drawing.Size(187, 132);
            this.appointmentsGroupBox.TabIndex = 3;
            this.appointmentsGroupBox.TabStop = false;
            this.appointmentsGroupBox.Text = "Appointments";
            // 
            // openApptsButton
            // 
            this.openApptsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openApptsButton.Location = new System.Drawing.Point(55, 68);
            this.openApptsButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.openApptsButton.Name = "openApptsButton";
            this.openApptsButton.Size = new System.Drawing.Size(80, 32);
            this.openApptsButton.TabIndex = 2;
            this.openApptsButton.Text = "Open";
            this.openApptsButton.UseVisualStyleBackColor = true;
            this.openApptsButton.Click += new System.EventHandler(this.openApptsButton_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Create, edit, and cancel appointments for customers";
            // 
            // LandingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 275);
            this.Controls.Add(this.appointmentsGroupBox);
            this.Controls.Add(this.customersGroupBox);
            this.Controls.Add(this.appNameLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LandingForm";
            this.Text = "The Scheduler";
            this.customersGroupBox.ResumeLayout(false);
            this.appointmentsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label appNameLabel;
        private System.Windows.Forms.GroupBox customersGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox appointmentsGroupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button openCustomersButton;
        private System.Windows.Forms.Button openApptsButton;
    }
}