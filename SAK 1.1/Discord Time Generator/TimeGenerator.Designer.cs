
namespace SAK_1._1
{
    partial class TimeGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeGenerator));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.titleLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.typeBox = new System.Windows.Forms.ComboBox();
            this.dateTextBox = new System.Windows.Forms.MaskedTextBox();
            this.calendar = new System.Windows.Forms.MonthCalendar();
            this.timeTextBox = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.invalidDateLabel = new System.Windows.Forms.Label();
            this.invalidTimeLabel = new System.Windows.Forms.Label();
            this.generateOutputButton = new System.Windows.Forms.Button();
            this.invalidTypeLabel = new System.Windows.Forms.Label();
            this.getCurrentDateButton = new System.Windows.Forms.Button();
            this.getMinDateButton = new System.Windows.Forms.Button();
            this.getMaxDateButton = new System.Windows.Forms.Button();
            this.referenceDateCheckBox = new System.Windows.Forms.CheckBox();
            this.getReferenceDate = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(553, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(16, 42);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(521, 36);
            this.titleLabel.TabIndex = 9;
            this.titleLabel.Text = "Discord Time Generator";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.BackColor = System.Drawing.Color.Transparent;
            this.dateLabel.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.Color.White;
            this.dateLabel.Location = new System.Drawing.Point(16, 105);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(76, 33);
            this.dateLabel.TabIndex = 10;
            this.dateLabel.Text = "Date";
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 154);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 33);
            this.label1.TabIndex = 11;
            this.label1.Text = "Time";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 203);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 33);
            this.label2.TabIndex = 12;
            this.label2.Text = "Type";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 252);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 33);
            this.label3.TabIndex = 13;
            this.label3.Text = "Output";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // typeBox
            // 
            this.typeBox.BackColor = System.Drawing.Color.BurlyWood;
            this.typeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.typeBox.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeBox.FormattingEnabled = true;
            this.typeBox.Items.AddRange(new object[] {
            "Short Time",
            "Long Time",
            "Short Date",
            "Long Date",
            "Long Date - Short Time",
            "Long Date - Week - Short Time",
            "Relative"});
            this.typeBox.Location = new System.Drawing.Point(255, 209);
            this.typeBox.Margin = new System.Windows.Forms.Padding(4);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(281, 27);
            this.typeBox.TabIndex = 14;
            this.typeBox.SelectedIndexChanged += new System.EventHandler(this.typeBox_Updated);
            this.typeBox.MouseLeave += new System.EventHandler(this.typeBox_Updated);
            // 
            // dateTextBox
            // 
            this.dateTextBox.BackColor = System.Drawing.Color.BurlyWood;
            this.dateTextBox.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTextBox.Location = new System.Drawing.Point(255, 111);
            this.dateTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.dateTextBox.Mask = "00/00/0000";
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(281, 27);
            this.dateTextBox.TabIndex = 15;
            this.dateTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dateTextBox_KeyDown);
            this.dateTextBox.MouseLeave += new System.EventHandler(this.dateTextBox_MouseLeave);
            // 
            // calendar
            // 
            this.calendar.Location = new System.Drawing.Point(205, 111);
            this.calendar.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.calendar.Name = "calendar";
            this.calendar.TabIndex = 16;
            this.calendar.Visible = false;
            this.calendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calendar_DateSelected);
            this.calendar.MouseLeave += new System.EventHandler(this.calendar_MouseLeave);
            // 
            // timeTextBox
            // 
            this.timeTextBox.BackColor = System.Drawing.Color.BurlyWood;
            this.timeTextBox.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeTextBox.Location = new System.Drawing.Point(255, 160);
            this.timeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.timeTextBox.Mask = "00:00:00";
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(281, 27);
            this.timeTextBox.TabIndex = 17;
            this.timeTextBox.ValidatingType = typeof(System.DateTime);
            this.timeTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.timeTextBox_KeyDown);
            this.timeTextBox.MouseLeave += new System.EventHandler(this.timeTextBox_MouseLeave);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(510, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 27);
            this.button1.TabIndex = 18;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // invalidDateLabel
            // 
            this.invalidDateLabel.AutoSize = true;
            this.invalidDateLabel.BackColor = System.Drawing.Color.Transparent;
            this.invalidDateLabel.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalidDateLabel.ForeColor = System.Drawing.Color.Red;
            this.invalidDateLabel.Location = new System.Drawing.Point(132, 114);
            this.invalidDateLabel.Name = "invalidDateLabel";
            this.invalidDateLabel.Size = new System.Drawing.Size(111, 21);
            this.invalidDateLabel.TabIndex = 19;
            this.invalidDateLabel.Text = "Invalid Date";
            // 
            // invalidTimeLabel
            // 
            this.invalidTimeLabel.AutoSize = true;
            this.invalidTimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.invalidTimeLabel.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalidTimeLabel.ForeColor = System.Drawing.Color.Red;
            this.invalidTimeLabel.Location = new System.Drawing.Point(128, 163);
            this.invalidTimeLabel.Name = "invalidTimeLabel";
            this.invalidTimeLabel.Size = new System.Drawing.Size(115, 21);
            this.invalidTimeLabel.TabIndex = 20;
            this.invalidTimeLabel.Text = "Invalid Time";
            // 
            // generateOutputButton
            // 
            this.generateOutputButton.Location = new System.Drawing.Point(255, 258);
            this.generateOutputButton.Name = "generateOutputButton";
            this.generateOutputButton.Size = new System.Drawing.Size(281, 27);
            this.generateOutputButton.TabIndex = 21;
            this.generateOutputButton.Text = "Generate";
            this.generateOutputButton.UseVisualStyleBackColor = true;
            this.generateOutputButton.Click += new System.EventHandler(this.generateOutputButton_Click);
            // 
            // invalidTypeLabel
            // 
            this.invalidTypeLabel.AutoSize = true;
            this.invalidTypeLabel.BackColor = System.Drawing.Color.Transparent;
            this.invalidTypeLabel.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalidTypeLabel.ForeColor = System.Drawing.Color.Red;
            this.invalidTypeLabel.Location = new System.Drawing.Point(131, 212);
            this.invalidTypeLabel.Name = "invalidTypeLabel";
            this.invalidTypeLabel.Size = new System.Drawing.Size(112, 21);
            this.invalidTypeLabel.TabIndex = 22;
            this.invalidTypeLabel.Text = "Not Selected";
            // 
            // getCurrentDateButton
            // 
            this.getCurrentDateButton.Location = new System.Drawing.Point(13, 329);
            this.getCurrentDateButton.Name = "getCurrentDateButton";
            this.getCurrentDateButton.Size = new System.Drawing.Size(131, 23);
            this.getCurrentDateButton.TabIndex = 23;
            this.getCurrentDateButton.Text = "Get Current Date";
            this.getCurrentDateButton.UseVisualStyleBackColor = true;
            this.getCurrentDateButton.Click += new System.EventHandler(this.getCurrentDateButton_Click);
            // 
            // getMinDateButton
            // 
            this.getMinDateButton.Location = new System.Drawing.Point(150, 329);
            this.getMinDateButton.Name = "getMinDateButton";
            this.getMinDateButton.Size = new System.Drawing.Size(107, 23);
            this.getMinDateButton.TabIndex = 24;
            this.getMinDateButton.Text = "Get Min. Date";
            this.getMinDateButton.UseVisualStyleBackColor = true;
            this.getMinDateButton.Click += new System.EventHandler(this.getMinDateButton_Click);
            // 
            // getMaxDateButton
            // 
            this.getMaxDateButton.Location = new System.Drawing.Point(263, 329);
            this.getMaxDateButton.Name = "getMaxDateButton";
            this.getMaxDateButton.Size = new System.Drawing.Size(107, 23);
            this.getMaxDateButton.TabIndex = 25;
            this.getMaxDateButton.Text = "Get Max. Date";
            this.getMaxDateButton.UseVisualStyleBackColor = true;
            this.getMaxDateButton.Click += new System.EventHandler(this.getMaxDateButton_Click);
            // 
            // referenceDateCheckBox
            // 
            this.referenceDateCheckBox.AutoSize = true;
            this.referenceDateCheckBox.Location = new System.Drawing.Point(255, 292);
            this.referenceDateCheckBox.Name = "referenceDateCheckBox";
            this.referenceDateCheckBox.Size = new System.Drawing.Size(174, 20);
            this.referenceDateCheckBox.TabIndex = 26;
            this.referenceDateCheckBox.Text = "Change Reference Date";
            this.referenceDateCheckBox.UseVisualStyleBackColor = true;
            this.referenceDateCheckBox.CheckedChanged += new System.EventHandler(this.referenceDateCheckBox_CheckedChanged);
            // 
            // getReferenceDate
            // 
            this.getReferenceDate.Location = new System.Drawing.Point(376, 329);
            this.getReferenceDate.Name = "getReferenceDate";
            this.getReferenceDate.Size = new System.Drawing.Size(147, 23);
            this.getReferenceDate.TabIndex = 27;
            this.getReferenceDate.Text = "Get Reference Date";
            this.getReferenceDate.UseVisualStyleBackColor = true;
            this.getReferenceDate.Click += new System.EventHandler(this.getReferenceDate_Click);
            // 
            // TimeGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(553, 364);
            this.Controls.Add(this.calendar);
            this.Controls.Add(this.getReferenceDate);
            this.Controls.Add(this.referenceDateCheckBox);
            this.Controls.Add(this.getMaxDateButton);
            this.Controls.Add(this.getMinDateButton);
            this.Controls.Add(this.getCurrentDateButton);
            this.Controls.Add(this.generateOutputButton);
            this.Controls.Add(this.invalidTimeLabel);
            this.Controls.Add(this.invalidDateLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.timeTextBox);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.typeBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.invalidTypeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TimeGenerator";
            this.Text = "Discord Time Generator";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox typeBox;
        private System.Windows.Forms.MaskedTextBox dateTextBox;
        private System.Windows.Forms.MonthCalendar calendar;
        private System.Windows.Forms.MaskedTextBox timeTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label invalidDateLabel;
        private System.Windows.Forms.Label invalidTimeLabel;
        private System.Windows.Forms.Button generateOutputButton;
        private System.Windows.Forms.Label invalidTypeLabel;
        private System.Windows.Forms.Button getCurrentDateButton;
        private System.Windows.Forms.Button getMinDateButton;
        private System.Windows.Forms.Button getMaxDateButton;
        private System.Windows.Forms.CheckBox referenceDateCheckBox;
        private System.Windows.Forms.Button getReferenceDate;
    }
}