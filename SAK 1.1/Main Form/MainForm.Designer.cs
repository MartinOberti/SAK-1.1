
namespace SAK_1._1
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.wheelButton = new System.Windows.Forms.Button();
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.subtitleLabel = new System.Windows.Forms.Label();
            this.listButton = new System.Windows.Forms.Button();
            this.hotButton = new System.Windows.Forms.Button();
            this.rngButton = new System.Windows.Forms.Button();
            this.calculatorButton = new System.Windows.Forms.Button();
            this.discordButton = new System.Windows.Forms.Button();
            this.unitButton = new System.Windows.Forms.Button();
            this.unusedButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // wheelButton
            // 
            this.wheelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.wheelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.wheelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.wheelButton.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wheelButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.wheelButton.Image = global::SAK_1._1.Properties.Resources.Button;
            this.wheelButton.Location = new System.Drawing.Point(12, 136);
            this.wheelButton.Name = "wheelButton";
            this.wheelButton.Size = new System.Drawing.Size(166, 62);
            this.wheelButton.TabIndex = 0;
            this.wheelButton.Text = "Wheel of Fortune";
            this.wheelButton.UseVisualStyleBackColor = true;
            this.wheelButton.Click += new System.EventHandler(this.wheelButton_Click);
            // 
            // logoBox
            // 
            this.logoBox.BackColor = System.Drawing.Color.Transparent;
            this.logoBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoBox.Cursor = System.Windows.Forms.Cursors.Help;
            this.logoBox.Image = global::SAK_1._1.Properties.Resources.Logo1;
            this.logoBox.Location = new System.Drawing.Point(12, 12);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(84, 107);
            this.logoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoBox.TabIndex = 6;
            this.logoBox.TabStop = false;
            this.logoBox.Click += new System.EventHandler(this.logoBox_Click);
            this.logoBox.MouseEnter += new System.EventHandler(this.logoBox_MouseEnter);
            this.logoBox.MouseLeave += new System.EventHandler(this.logoBox_MouseLeave);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Spray Army Division", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(97, 25);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(243, 50);
            this.titleLabel.TabIndex = 7;
            this.titleLabel.Text = "S.A.C.K. 1.1";
            // 
            // subtitleLabel
            // 
            this.subtitleLabel.AutoSize = true;
            this.subtitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.subtitleLabel.Font = new System.Drawing.Font("Spray Army Division", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtitleLabel.ForeColor = System.Drawing.Color.White;
            this.subtitleLabel.Location = new System.Drawing.Point(102, 75);
            this.subtitleLabel.Name = "subtitleLabel";
            this.subtitleLabel.Size = new System.Drawing.Size(261, 20);
            this.subtitleLabel.TabIndex = 8;
            this.subtitleLabel.Text = "Swiss Army Combat Knife 1.1";
            // 
            // listButton
            // 
            this.listButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.listButton.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.listButton.Image = global::SAK_1._1.Properties.Resources.Button;
            this.listButton.Location = new System.Drawing.Point(212, 136);
            this.listButton.Name = "listButton";
            this.listButton.Size = new System.Drawing.Size(166, 62);
            this.listButton.TabIndex = 9;
            this.listButton.Text = "List with Counters";
            this.listButton.UseVisualStyleBackColor = true;
            this.listButton.Click += new System.EventHandler(this.listButton_Click);
            // 
            // hotButton
            // 
            this.hotButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hotButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.hotButton.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.hotButton.Image = global::SAK_1._1.Properties.Resources.Button;
            this.hotButton.Location = new System.Drawing.Point(12, 224);
            this.hotButton.Name = "hotButton";
            this.hotButton.Size = new System.Drawing.Size(166, 62);
            this.hotButton.TabIndex = 10;
            this.hotButton.Text = "Heads or Tails";
            this.hotButton.UseVisualStyleBackColor = true;
            this.hotButton.Click += new System.EventHandler(this.hotButton_Click);
            // 
            // rngButton
            // 
            this.rngButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rngButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rngButton.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rngButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.rngButton.Image = global::SAK_1._1.Properties.Resources.Button;
            this.rngButton.Location = new System.Drawing.Point(212, 224);
            this.rngButton.Name = "rngButton";
            this.rngButton.Size = new System.Drawing.Size(166, 62);
            this.rngButton.TabIndex = 11;
            this.rngButton.Text = "Random Number Generator";
            this.rngButton.UseVisualStyleBackColor = true;
            this.rngButton.Click += new System.EventHandler(this.rngButton_Click);
            // 
            // calculatorButton
            // 
            this.calculatorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calculatorButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.calculatorButton.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculatorButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.calculatorButton.Image = global::SAK_1._1.Properties.Resources.Button;
            this.calculatorButton.Location = new System.Drawing.Point(12, 312);
            this.calculatorButton.Name = "calculatorButton";
            this.calculatorButton.Size = new System.Drawing.Size(166, 62);
            this.calculatorButton.TabIndex = 12;
            this.calculatorButton.Text = "Calculator";
            this.calculatorButton.UseVisualStyleBackColor = true;
            this.calculatorButton.Click += new System.EventHandler(this.calculatorButton_Click);
            // 
            // discordButton
            // 
            this.discordButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.discordButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.discordButton.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discordButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.discordButton.Image = global::SAK_1._1.Properties.Resources.Button;
            this.discordButton.Location = new System.Drawing.Point(212, 312);
            this.discordButton.Name = "discordButton";
            this.discordButton.Size = new System.Drawing.Size(166, 62);
            this.discordButton.TabIndex = 13;
            this.discordButton.Text = "Discord Time Generator";
            this.discordButton.UseVisualStyleBackColor = true;
            this.discordButton.Click += new System.EventHandler(this.discordButton_Click);
            // 
            // unitButton
            // 
            this.unitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.unitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.unitButton.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.unitButton.Image = global::SAK_1._1.Properties.Resources.Button;
            this.unitButton.Location = new System.Drawing.Point(12, 400);
            this.unitButton.Name = "unitButton";
            this.unitButton.Size = new System.Drawing.Size(166, 62);
            this.unitButton.TabIndex = 14;
            this.unitButton.Text = "Unit Converter";
            this.unitButton.UseVisualStyleBackColor = true;
            this.unitButton.Click += new System.EventHandler(this.unitButton_Click);
            // 
            // unusedButton
            // 
            this.unusedButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.unusedButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.unusedButton.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unusedButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.unusedButton.Image = global::SAK_1._1.Properties.Resources.Button;
            this.unusedButton.Location = new System.Drawing.Point(212, 400);
            this.unusedButton.Name = "unusedButton";
            this.unusedButton.Size = new System.Drawing.Size(166, 62);
            this.unusedButton.TabIndex = 15;
            this.unusedButton.Text = "???";
            this.unusedButton.UseVisualStyleBackColor = true;
            this.unusedButton.Click += new System.EventHandler(this.unusedButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SAK_1._1.Properties.Resources.Main_Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(390, 474);
            this.Controls.Add(this.unusedButton);
            this.Controls.Add(this.unitButton);
            this.Controls.Add(this.discordButton);
            this.Controls.Add(this.calculatorButton);
            this.Controls.Add(this.rngButton);
            this.Controls.Add(this.hotButton);
            this.Controls.Add(this.listButton);
            this.Controls.Add(this.subtitleLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.wheelButton);
            this.Controls.Add(this.logoBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "S.A.C.K. 1.1";
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button wheelButton;
        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label subtitleLabel;
        private System.Windows.Forms.Button listButton;
        private System.Windows.Forms.Button hotButton;
        private System.Windows.Forms.Button rngButton;
        private System.Windows.Forms.Button calculatorButton;
        private System.Windows.Forms.Button discordButton;
        private System.Windows.Forms.Button unitButton;
        private System.Windows.Forms.Button unusedButton;
    }
}

