using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAK_1._1
{
    public partial class AddOption : Form
    {
        public AddOption(string listTitle)
        {
            InitializeComponent();
            titleLabel.Text = titleLabel.Text + "\"" + listTitle + "\"";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            WheelOfFortune wof = new WheelOfFortune();
            if (textBox.Text != "")
            {
                wof.recieveData(textBox.Text);
                this.Close();
            }
            else
            {
                API api = new API();
                string text = "You haven´t written your option down!";
                string title = "Notice";
                string ok = "My b";
                MessageBoxIcon icon = MessageBoxIcon.Information;
                api.messageBoxSimple(text,title,ok,icon);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
