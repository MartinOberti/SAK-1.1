namespace SAK_1._1.Discord_Time_Generator
{
    partial class FinalCode
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
            this.codeLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.previewLabel = new System.Windows.Forms.Label();
            this.copyCodeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // codeLabel
            // 
            this.codeLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.codeLabel.AutoSize = true;
            this.codeLabel.BackColor = System.Drawing.Color.Transparent;
            this.codeLabel.Font = new System.Drawing.Font("Constantia", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeLabel.ForeColor = System.Drawing.Color.Black;
            this.codeLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.codeLabel.Location = new System.Drawing.Point(13, 50);
            this.codeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.codeLabel.Name = "codeLabel";
            this.codeLabel.Size = new System.Drawing.Size(156, 58);
            this.codeLabel.TabIndex = 14;
            this.codeLabel.Text = "CODE";
            this.codeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.Black;
            this.titleLabel.Location = new System.Drawing.Point(13, 9);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(187, 41);
            this.titleLabel.TabIndex = 13;
            this.titleLabel.Text = "Final Code: ";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // previewLabel
            // 
            this.previewLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.previewLabel.AutoSize = true;
            this.previewLabel.BackColor = System.Drawing.Color.Transparent;
            this.previewLabel.Font = new System.Drawing.Font("Constantia", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previewLabel.ForeColor = System.Drawing.Color.Black;
            this.previewLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.previewLabel.Location = new System.Drawing.Point(13, 108);
            this.previewLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.previewLabel.Name = "previewLabel";
            this.previewLabel.Size = new System.Drawing.Size(108, 35);
            this.previewLabel.TabIndex = 15;
            this.previewLabel.Text = "Preview";
            this.previewLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // copyCodeButton
            // 
            this.copyCodeButton.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyCodeButton.Location = new System.Drawing.Point(171, 173);
            this.copyCodeButton.Name = "copyCodeButton";
            this.copyCodeButton.Size = new System.Drawing.Size(182, 43);
            this.copyCodeButton.TabIndex = 16;
            this.copyCodeButton.Text = "Copy Code";
            this.copyCodeButton.UseVisualStyleBackColor = true;
            this.copyCodeButton.Click += new System.EventHandler(this.copyCodeButton_Click);
            // 
            // FinalCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 253);
            this.Controls.Add(this.copyCodeButton);
            this.Controls.Add(this.previewLabel);
            this.Controls.Add(this.codeLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "FinalCode";
            this.Text = "FinalCode";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label codeLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label previewLabel;
        private System.Windows.Forms.Button copyCodeButton;
    }
}