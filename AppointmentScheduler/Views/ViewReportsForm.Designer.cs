namespace AppointmentScheduler.Views
{
    partial class ViewReportsForm
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
            this.reportDGV = new System.Windows.Forms.DataGridView();
            this.appNameLabel = new System.Windows.Forms.Label();
            this.reportTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loadReportButton = new System.Windows.Forms.Button();
            this.selectConsultantLabel = new System.Windows.Forms.Label();
            this.consultantNameComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.reportDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // reportDGV
            // 
            this.reportDGV.AllowUserToAddRows = false;
            this.reportDGV.AllowUserToDeleteRows = false;
            this.reportDGV.AllowUserToResizeColumns = false;
            this.reportDGV.AllowUserToResizeRows = false;
            this.reportDGV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.reportDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportDGV.Location = new System.Drawing.Point(12, 175);
            this.reportDGV.Name = "reportDGV";
            this.reportDGV.RowHeadersVisible = false;
            this.reportDGV.Size = new System.Drawing.Size(446, 263);
            this.reportDGV.TabIndex = 0;
            // 
            // appNameLabel
            // 
            this.appNameLabel.AutoSize = true;
            this.appNameLabel.Font = new System.Drawing.Font("Goudy Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appNameLabel.Location = new System.Drawing.Point(159, 26);
            this.appNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.appNameLabel.Name = "appNameLabel";
            this.appNameLabel.Size = new System.Drawing.Size(152, 28);
            this.appNameLabel.TabIndex = 1;
            this.appNameLabel.Text = "The Scheduler";
            this.appNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reportTypeComboBox
            // 
            this.reportTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.reportTypeComboBox.FormattingEnabled = true;
            this.reportTypeComboBox.Location = new System.Drawing.Point(12, 100);
            this.reportTypeComboBox.Name = "reportTypeComboBox";
            this.reportTypeComboBox.Size = new System.Drawing.Size(274, 21);
            this.reportTypeComboBox.TabIndex = 2;
            this.reportTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.reportTypeComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Report to run:";
            // 
            // loadReportButton
            // 
            this.loadReportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadReportButton.Location = new System.Drawing.Point(350, 95);
            this.loadReportButton.Name = "loadReportButton";
            this.loadReportButton.Size = new System.Drawing.Size(75, 29);
            this.loadReportButton.TabIndex = 4;
            this.loadReportButton.Text = "Load";
            this.loadReportButton.UseVisualStyleBackColor = true;
            this.loadReportButton.Click += new System.EventHandler(this.loadReportButton_Click);
            // 
            // selectConsultantLabel
            // 
            this.selectConsultantLabel.AutoSize = true;
            this.selectConsultantLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectConsultantLabel.Location = new System.Drawing.Point(13, 128);
            this.selectConsultantLabel.Name = "selectConsultantLabel";
            this.selectConsultantLabel.Size = new System.Drawing.Size(113, 15);
            this.selectConsultantLabel.TabIndex = 5;
            this.selectConsultantLabel.Text = "Select a consultant:";
            this.selectConsultantLabel.Visible = false;
            // 
            // consultantNameComboBox
            // 
            this.consultantNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.consultantNameComboBox.FormattingEnabled = true;
            this.consultantNameComboBox.Location = new System.Drawing.Point(12, 144);
            this.consultantNameComboBox.Name = "consultantNameComboBox";
            this.consultantNameComboBox.Size = new System.Drawing.Size(274, 21);
            this.consultantNameComboBox.TabIndex = 6;
            this.consultantNameComboBox.Visible = false;
            // 
            // ViewReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 450);
            this.Controls.Add(this.consultantNameComboBox);
            this.Controls.Add(this.selectConsultantLabel);
            this.Controls.Add(this.loadReportButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportTypeComboBox);
            this.Controls.Add(this.appNameLabel);
            this.Controls.Add(this.reportDGV);
            this.Name = "ViewReportsForm";
            this.Text = "The Scheduler - Reports";
            this.Load += new System.EventHandler(this.ViewReportsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView reportDGV;
        private System.Windows.Forms.Label appNameLabel;
        private System.Windows.Forms.ComboBox reportTypeComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button loadReportButton;
        private System.Windows.Forms.Label selectConsultantLabel;
        private System.Windows.Forms.ComboBox consultantNameComboBox;
    }
}