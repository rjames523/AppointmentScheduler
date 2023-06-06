﻿namespace AppointmentScheduler
{
    partial class CustomersForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addCustomerButton = new System.Windows.Forms.Button();
            this.createAppointmentButton = new System.Windows.Forms.Button();
            this.deleteCustomerButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(711, 357);
            this.dataGridView1.TabIndex = 0;
            // 
            // addCustomerButton
            // 
            this.addCustomerButton.Location = new System.Drawing.Point(128, 395);
            this.addCustomerButton.Name = "addCustomerButton";
            this.addCustomerButton.Size = new System.Drawing.Size(98, 45);
            this.addCustomerButton.TabIndex = 1;
            this.addCustomerButton.Text = "Add Customer";
            this.addCustomerButton.UseVisualStyleBackColor = true;
            // 
            // createAppointmentButton
            // 
            this.createAppointmentButton.Location = new System.Drawing.Point(319, 395);
            this.createAppointmentButton.Name = "createAppointmentButton";
            this.createAppointmentButton.Size = new System.Drawing.Size(98, 45);
            this.createAppointmentButton.TabIndex = 2;
            this.createAppointmentButton.Text = "Create Appointment";
            this.createAppointmentButton.UseVisualStyleBackColor = true;
            // 
            // deleteCustomerButton
            // 
            this.deleteCustomerButton.Location = new System.Drawing.Point(510, 395);
            this.deleteCustomerButton.Name = "deleteCustomerButton";
            this.deleteCustomerButton.Size = new System.Drawing.Size(98, 45);
            this.deleteCustomerButton.TabIndex = 3;
            this.deleteCustomerButton.Text = "Delete Customer";
            this.deleteCustomerButton.UseVisualStyleBackColor = true;
            // 
            // CustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 461);
            this.Controls.Add(this.deleteCustomerButton);
            this.Controls.Add(this.createAppointmentButton);
            this.Controls.Add(this.addCustomerButton);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CustomersForm";
            this.Text = "The Scheduler - Customers";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addCustomerButton;
        private System.Windows.Forms.Button createAppointmentButton;
        private System.Windows.Forms.Button deleteCustomerButton;
    }
}