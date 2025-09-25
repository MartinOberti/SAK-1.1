
namespace SAK_1._1
{
    partial class SetLoadTime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetLoadTime));
            this.titleLabel = new System.Windows.Forms.Label();
            this.loadTimeNumeric = new System.Windows.Forms.NumericUpDown();
            this.setButton = new System.Windows.Forms.Button();
            this.subtitleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.loadTimeNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Constantia", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.Black;
            this.titleLabel.Location = new System.Drawing.Point(20, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(159, 29);
            this.titleLabel.TabIndex = 9;
            this.titleLabel.Text = "Set Load Time";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loadTimeNumeric
            // 
            this.loadTimeNumeric.BackColor = System.Drawing.Color.Linen;
            this.loadTimeNumeric.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadTimeNumeric.Location = new System.Drawing.Point(12, 63);
            this.loadTimeNumeric.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.loadTimeNumeric.Name = "loadTimeNumeric";
            this.loadTimeNumeric.Size = new System.Drawing.Size(173, 23);
            this.loadTimeNumeric.TabIndex = 10;
            // 
            // setButton
            // 
            this.setButton.BackColor = System.Drawing.Color.Linen;
            this.setButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.setButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.setButton.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setButton.Location = new System.Drawing.Point(12, 92);
            this.setButton.Name = "setButton";
            this.setButton.Size = new System.Drawing.Size(173, 28);
            this.setButton.TabIndex = 11;
            this.setButton.Text = "Set";
            this.setButton.UseVisualStyleBackColor = false;
            this.setButton.Click += new System.EventHandler(this.setButton_Click);
            // 
            // subtitleLabel
            // 
            this.subtitleLabel.AutoSize = true;
            this.subtitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.subtitleLabel.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtitleLabel.ForeColor = System.Drawing.Color.Black;
            this.subtitleLabel.Location = new System.Drawing.Point(53, 38);
            this.subtitleLabel.Name = "subtitleLabel";
            this.subtitleLabel.Size = new System.Drawing.Size(93, 19);
            this.subtitleLabel.TabIndex = 12;
            this.subtitleLabel.Text = "(In Seconds)";
            this.subtitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SetLoadTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SAK_1._1.Properties.Resources.Popup_Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(197, 132);
            this.Controls.Add(this.subtitleLabel);
            this.Controls.Add(this.setButton);
            this.Controls.Add(this.loadTimeNumeric);
            this.Controls.Add(this.titleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SetLoadTime";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Time";
            ((System.ComponentModel.ISupportInitialize)(this.loadTimeNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.NumericUpDown loadTimeNumeric;
        private System.Windows.Forms.Button setButton;
        private System.Windows.Forms.Label subtitleLabel;
    }
}