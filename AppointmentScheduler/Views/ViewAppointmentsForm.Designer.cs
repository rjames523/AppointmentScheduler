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
            this.custApptsListBox = new System.Windows.Forms.ListBox();
            this.editApptButton = new System.Windows.Forms.Button();
            this.cancelApptButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.customersDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // customersDGV
            // 
            this.customersDGV.AllowUserToAddRows = false;
            this.customersDGV.AllowUserToDeleteRows = false;
            this.customersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersDGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.customersDGV.Location = new System.Drawing.Point(13, 117);
            this.customersDGV.Margin = new System.Windows.Forms.Padding(4);
            this.customersDGV.MultiSelect = false;
            this.customersDGV.Name = "customersDGV";
            this.customersDGV.RowHeadersVisible = false;
            this.customersDGV.RowHeadersWidth = 51;
            this.customersDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customersDGV.Size = new System.Drawing.Size(576, 297);
            this.customersDGV.TabIndex = 1;
            this.customersDGV.SelectionChanged += new System.EventHandler(this.customersDGV_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(636, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Viewing appointments for:";
            // 
            // selectedCustNameTxtBox
            // 
            this.selectedCustNameTxtBox.Enabled = false;
            this.selectedCustNameTxtBox.Location = new System.Drawing.Point(639, 162);
            this.selectedCustNameTxtBox.Multiline = true;
            this.selectedCustNameTxtBox.Name = "selectedCustNameTxtBox";
            this.selectedCustNameTxtBox.Size = new System.Drawing.Size(311, 30);
            this.selectedCustNameTxtBox.TabIndex = 19;
            // 
            // appNameLabel
            // 
            this.appNameLabel.AutoSize = true;
            this.appNameLabel.Font = new System.Drawing.Font("Goudy Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appNameLabel.Location = new System.Drawing.Point(470, 36);
            this.appNameLabel.Name = "appNameLabel";
            this.appNameLabel.Size = new System.Drawing.Size(194, 34);
            this.appNameLabel.TabIndex = 20;
            this.appNameLabel.Text = "The Scheduler";
            this.appNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 18);
            this.label2.TabIndex = 21;
            this.label2.Text = "Customers:";
            // 
            // custApptsListBox
            // 
            this.custApptsListBox.FormattingEnabled = true;
            this.custApptsListBox.ItemHeight = 16;
            this.custApptsListBox.Location = new System.Drawing.Point(639, 199);
            this.custApptsListBox.Name = "custApptsListBox";
            this.custApptsListBox.Size = new System.Drawing.Size(407, 212);
            this.custApptsListBox.TabIndex = 22;
            this.custApptsListBox.SelectedIndexChanged += new System.EventHandler(this.custApptsListBox_SelectedIndexChanged);
            // 
            // editApptButton
            // 
            this.editApptButton.Location = new System.Drawing.Point(744, 428);
            this.editApptButton.Name = "editApptButton";
            this.editApptButton.Size = new System.Drawing.Size(75, 32);
            this.editApptButton.TabIndex = 23;
            this.editApptButton.Text = "Edit";
            this.editApptButton.UseVisualStyleBackColor = true;
            this.editApptButton.Click += new System.EventHandler(this.editApptButton_Click);
            // 
            // cancelApptButton
            // 
            this.cancelApptButton.Location = new System.Drawing.Point(863, 428);
            this.cancelApptButton.Name = "cancelApptButton";
            this.cancelApptButton.Size = new System.Drawing.Size(75, 32);
            this.cancelApptButton.TabIndex = 24;
            this.cancelApptButton.Text = "Cancel";
            this.cancelApptButton.UseVisualStyleBackColor = true;
            // 
            // ViewAppointmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 491);
            this.Controls.Add(this.cancelApptButton);
            this.Controls.Add(this.editApptButton);
            this.Controls.Add(this.custApptsListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.appNameLabel);
            this.Controls.Add(this.selectedCustNameTxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customersDGV);
            this.Name = "ViewAppointmentsForm";
            this.Text = "The Scheduler - Appointments";
            this.Load += new System.EventHandler(this.ViewAppointmentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customersDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView customersDGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox selectedCustNameTxtBox;
        private System.Windows.Forms.Label appNameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox custApptsListBox;
        private System.Windows.Forms.Button editApptButton;
        private System.Windows.Forms.Button cancelApptButton;
    }
}