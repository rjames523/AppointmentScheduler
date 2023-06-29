namespace AppointmentScheduler
{
    partial class ViewAppointmentsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.selectedCustNameTxtBox = new System.Windows.Forms.TextBox();
            this.appNameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.editApptButton = new System.Windows.Forms.Button();
            this.cancelApptButton = new System.Windows.Forms.Button();
            this.customerSpecificApptsDGV = new System.Windows.Forms.DataGridView();
            this.viewPastCurrApptsLabel = new System.Windows.Forms.LinkLabel();
            this.viewByWeekButton = new System.Windows.Forms.Button();
            this.viewByMonthButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customersDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerSpecificApptsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // customersDGV
            // 
            this.customersDGV.AllowUserToAddRows = false;
            this.customersDGV.AllowUserToDeleteRows = false;
            this.customersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersDGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.customersDGV.Location = new System.Drawing.Point(10, 95);
            this.customersDGV.MultiSelect = false;
            this.customersDGV.Name = "customersDGV";
            this.customersDGV.RowHeadersVisible = false;
            this.customersDGV.RowHeadersWidth = 51;
            this.customersDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customersDGV.Size = new System.Drawing.Size(432, 241);
            this.customersDGV.TabIndex = 2;
            this.customersDGV.SelectionChanged += new System.EventHandler(this.customersDGV_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(469, 115);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Viewing appointments for:";
            // 
            // selectedCustNameTxtBox
            // 
            this.selectedCustNameTxtBox.Enabled = false;
            this.selectedCustNameTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedCustNameTxtBox.Location = new System.Drawing.Point(471, 132);
            this.selectedCustNameTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.selectedCustNameTxtBox.Multiline = true;
            this.selectedCustNameTxtBox.Name = "selectedCustNameTxtBox";
            this.selectedCustNameTxtBox.Size = new System.Drawing.Size(234, 25);
            this.selectedCustNameTxtBox.TabIndex = 4;
            // 
            // appNameLabel
            // 
            this.appNameLabel.AutoSize = true;
            this.appNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appNameLabel.Location = new System.Drawing.Point(352, 29);
            this.appNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.appNameLabel.Name = "appNameLabel";
            this.appNameLabel.Size = new System.Drawing.Size(185, 29);
            this.appNameLabel.TabIndex = 0;
            this.appNameLabel.Text = "The Scheduler";
            this.appNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customers:";
            // 
            // editApptButton
            // 
            this.editApptButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editApptButton.Location = new System.Drawing.Point(610, 353);
            this.editApptButton.Margin = new System.Windows.Forms.Padding(2);
            this.editApptButton.Name = "editApptButton";
            this.editApptButton.Size = new System.Drawing.Size(65, 33);
            this.editApptButton.TabIndex = 10;
            this.editApptButton.Text = "Edit";
            this.editApptButton.UseVisualStyleBackColor = true;
            this.editApptButton.Click += new System.EventHandler(this.editApptButton_Click);
            // 
            // cancelApptButton
            // 
            this.cancelApptButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelApptButton.Location = new System.Drawing.Point(700, 353);
            this.cancelApptButton.Margin = new System.Windows.Forms.Padding(2);
            this.cancelApptButton.Name = "cancelApptButton";
            this.cancelApptButton.Size = new System.Drawing.Size(65, 33);
            this.cancelApptButton.TabIndex = 11;
            this.cancelApptButton.Text = "Cancel";
            this.cancelApptButton.UseVisualStyleBackColor = true;
            this.cancelApptButton.Click += new System.EventHandler(this.cancelApptButton_Click);
            // 
            // customerSpecificApptsDGV
            // 
            this.customerSpecificApptsDGV.AllowUserToAddRows = false;
            this.customerSpecificApptsDGV.AllowUserToDeleteRows = false;
            this.customerSpecificApptsDGV.AllowUserToResizeColumns = false;
            this.customerSpecificApptsDGV.AllowUserToResizeRows = false;
            this.customerSpecificApptsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customerSpecificApptsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerSpecificApptsDGV.Location = new System.Drawing.Point(471, 162);
            this.customerSpecificApptsDGV.Margin = new System.Windows.Forms.Padding(2);
            this.customerSpecificApptsDGV.Name = "customerSpecificApptsDGV";
            this.customerSpecificApptsDGV.ReadOnly = true;
            this.customerSpecificApptsDGV.RowHeadersVisible = false;
            this.customerSpecificApptsDGV.RowHeadersWidth = 51;
            this.customerSpecificApptsDGV.RowTemplate.Height = 24;
            this.customerSpecificApptsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customerSpecificApptsDGV.Size = new System.Drawing.Size(421, 175);
            this.customerSpecificApptsDGV.TabIndex = 6;
            this.customerSpecificApptsDGV.SelectionChanged += new System.EventHandler(this.customerSpecificApptsDGV_SelectionChanged);
            // 
            // viewPastCurrApptsLabel
            // 
            this.viewPastCurrApptsLabel.AutoSize = true;
            this.viewPastCurrApptsLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewPastCurrApptsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewPastCurrApptsLabel.Location = new System.Drawing.Point(728, 141);
            this.viewPastCurrApptsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.viewPastCurrApptsLabel.Name = "viewPastCurrApptsLabel";
            this.viewPastCurrApptsLabel.Size = new System.Drawing.Size(137, 15);
            this.viewPastCurrApptsLabel.TabIndex = 5;
            this.viewPastCurrApptsLabel.TabStop = true;
            this.viewPastCurrApptsLabel.Text = "View past appointments";
            this.viewPastCurrApptsLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.viewPastCurrApptsLabel_LinkClicked);
            // 
            // viewByWeekButton
            // 
            this.viewByWeekButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewByWeekButton.Location = new System.Drawing.Point(212, 353);
            this.viewByWeekButton.Margin = new System.Windows.Forms.Padding(2);
            this.viewByWeekButton.Name = "viewByWeekButton";
            this.viewByWeekButton.Size = new System.Drawing.Size(85, 33);
            this.viewByWeekButton.TabIndex = 8;
            this.viewByWeekButton.Text = "By Week";
            this.viewByWeekButton.UseVisualStyleBackColor = true;
            this.viewByWeekButton.Click += new System.EventHandler(this.viewByWeekButton_Click);
            // 
            // viewByMonthButton
            // 
            this.viewByMonthButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewByMonthButton.Location = new System.Drawing.Point(323, 353);
            this.viewByMonthButton.Margin = new System.Windows.Forms.Padding(2);
            this.viewByMonthButton.Name = "viewByMonthButton";
            this.viewByMonthButton.Size = new System.Drawing.Size(85, 33);
            this.viewByMonthButton.TabIndex = 9;
            this.viewByMonthButton.Text = "By Month";
            this.viewByMonthButton.UseVisualStyleBackColor = true;
            this.viewByMonthButton.Click += new System.EventHandler(this.viewByMonthButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "View all appointments:";
            // 
            // ViewAppointmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 399);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.viewByMonthButton);
            this.Controls.Add(this.viewByWeekButton);
            this.Controls.Add(this.viewPastCurrApptsLabel);
            this.Controls.Add(this.customerSpecificApptsDGV);
            this.Controls.Add(this.cancelApptButton);
            this.Controls.Add(this.editApptButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.appNameLabel);
            this.Controls.Add(this.selectedCustNameTxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customersDGV);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ViewAppointmentsForm";
            this.Text = "The Scheduler - Appointments";
            this.Load += new System.EventHandler(this.ViewAppointmentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customersDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerSpecificApptsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView customersDGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox selectedCustNameTxtBox;
        private System.Windows.Forms.Label appNameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button editApptButton;
        private System.Windows.Forms.Button cancelApptButton;
        private System.Windows.Forms.DataGridView customerSpecificApptsDGV;
        private System.Windows.Forms.LinkLabel viewPastCurrApptsLabel;
        private System.Windows.Forms.Button viewByWeekButton;
        private System.Windows.Forms.Button viewByMonthButton;
        private System.Windows.Forms.Label label3;
    }
}