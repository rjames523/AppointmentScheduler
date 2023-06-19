﻿namespace AppointmentScheduler
{
    partial class ViewCustomersForm
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
            this.customersDGV = new System.Windows.Forms.DataGridView();
            this.addCustomerButton = new System.Windows.Forms.Button();
            this.scheduleAppointmentButton = new System.Windows.Forms.Button();
            this.deleteCustomerButton = new System.Windows.Forms.Button();
            this.editCustomerButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.customersDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // customersDGV
            // 
            this.customersDGV.AllowUserToAddRows = false;
            this.customersDGV.AllowUserToDeleteRows = false;
            this.customersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersDGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.customersDGV.Location = new System.Drawing.Point(17, 16);
            this.customersDGV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.customersDGV.MultiSelect = false;
            this.customersDGV.Name = "customersDGV";
            this.customersDGV.RowHeadersVisible = false;
            this.customersDGV.RowHeadersWidth = 51;
            this.customersDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customersDGV.Size = new System.Drawing.Size(948, 439);
            this.customersDGV.TabIndex = 0;
            this.customersDGV.SelectionChanged += new System.EventHandler(this.customersDGV_SelectionChanged);
            // 
            // addCustomerButton
            // 
            this.addCustomerButton.Location = new System.Drawing.Point(76, 486);
            this.addCustomerButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addCustomerButton.Name = "addCustomerButton";
            this.addCustomerButton.Size = new System.Drawing.Size(131, 55);
            this.addCustomerButton.TabIndex = 1;
            this.addCustomerButton.Text = "Add Customer";
            this.addCustomerButton.UseVisualStyleBackColor = true;
            // 
            // scheduleAppointmentButton
            // 
            this.scheduleAppointmentButton.Location = new System.Drawing.Point(543, 486);
            this.scheduleAppointmentButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.scheduleAppointmentButton.Name = "scheduleAppointmentButton";
            this.scheduleAppointmentButton.Size = new System.Drawing.Size(131, 55);
            this.scheduleAppointmentButton.TabIndex = 2;
            this.scheduleAppointmentButton.Text = "Schedule Appointment";
            this.scheduleAppointmentButton.UseVisualStyleBackColor = true;
            this.scheduleAppointmentButton.Click += new System.EventHandler(this.scheduleAppointmentButton_Click);
            // 
            // deleteCustomerButton
            // 
            this.deleteCustomerButton.Location = new System.Drawing.Point(776, 486);
            this.deleteCustomerButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deleteCustomerButton.Name = "deleteCustomerButton";
            this.deleteCustomerButton.Size = new System.Drawing.Size(131, 55);
            this.deleteCustomerButton.TabIndex = 3;
            this.deleteCustomerButton.Text = "Delete Customer";
            this.deleteCustomerButton.UseVisualStyleBackColor = true;
            this.deleteCustomerButton.Click += new System.EventHandler(this.deleteCustomerButton_Click);
            // 
            // editCustomerButton
            // 
            this.editCustomerButton.Location = new System.Drawing.Point(309, 486);
            this.editCustomerButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.editCustomerButton.Name = "editCustomerButton";
            this.editCustomerButton.Size = new System.Drawing.Size(131, 55);
            this.editCustomerButton.TabIndex = 4;
            this.editCustomerButton.Text = "Edit Customer";
            this.editCustomerButton.UseVisualStyleBackColor = true;
            this.editCustomerButton.Click += new System.EventHandler(this.editCustomerButton_Click);
            // 
            // ViewCustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 567);
            this.Controls.Add(this.editCustomerButton);
            this.Controls.Add(this.deleteCustomerButton);
            this.Controls.Add(this.scheduleAppointmentButton);
            this.Controls.Add(this.addCustomerButton);
            this.Controls.Add(this.customersDGV);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ViewCustomersForm";
            this.Text = "The Scheduler - Customers";
            this.Load += new System.EventHandler(this.CustomersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customersDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView customersDGV;
        private System.Windows.Forms.Button addCustomerButton;
        private System.Windows.Forms.Button scheduleAppointmentButton;
        private System.Windows.Forms.Button deleteCustomerButton;
        private System.Windows.Forms.Button editCustomerButton;
    }
}