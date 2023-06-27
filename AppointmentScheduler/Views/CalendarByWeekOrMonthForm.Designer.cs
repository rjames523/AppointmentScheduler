﻿namespace AppointmentScheduler.Views
{
    partial class CalendarByWeekOrMonthForm
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
            this.calendarDGV = new System.Windows.Forms.DataGridView();
            this.weekOrMonthOfLabel = new System.Windows.Forms.Label();
            this.appNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.calendarDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // calendarDGV
            // 
            this.calendarDGV.AllowUserToAddRows = false;
            this.calendarDGV.AllowUserToDeleteRows = false;
            this.calendarDGV.AllowUserToResizeColumns = false;
            this.calendarDGV.AllowUserToResizeRows = false;
            this.calendarDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.calendarDGV.Location = new System.Drawing.Point(13, 82);
            this.calendarDGV.Name = "calendarDGV";
            this.calendarDGV.Size = new System.Drawing.Size(515, 268);
            this.calendarDGV.TabIndex = 0;
            // 
            // weekOrMonthOfLabel
            // 
            this.weekOrMonthOfLabel.AutoSize = true;
            this.weekOrMonthOfLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weekOrMonthOfLabel.Location = new System.Drawing.Point(13, 63);
            this.weekOrMonthOfLabel.Name = "weekOrMonthOfLabel";
            this.weekOrMonthOfLabel.Size = new System.Drawing.Size(54, 15);
            this.weekOrMonthOfLabel.TabIndex = 1;
            this.weekOrMonthOfLabel.Text = "Week of:";
            // 
            // appNameLabel
            // 
            this.appNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.appNameLabel.AutoSize = true;
            this.appNameLabel.Font = new System.Drawing.Font("Goudy Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appNameLabel.Location = new System.Drawing.Point(194, 22);
            this.appNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.appNameLabel.Name = "appNameLabel";
            this.appNameLabel.Size = new System.Drawing.Size(152, 28);
            this.appNameLabel.TabIndex = 2;
            this.appNameLabel.Text = "The Scheduler";
            this.appNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CalendarByWeekOrMonthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 362);
            this.Controls.Add(this.appNameLabel);
            this.Controls.Add(this.weekOrMonthOfLabel);
            this.Controls.Add(this.calendarDGV);
            this.Name = "CalendarByWeekOrMonthForm";
            this.Text = "The Scheduler - Calendar";
            this.Load += new System.EventHandler(this.CalendarByWeekOrMonthForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.calendarDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView calendarDGV;
        private System.Windows.Forms.Label weekOrMonthOfLabel;
        private System.Windows.Forms.Label appNameLabel;
    }
}