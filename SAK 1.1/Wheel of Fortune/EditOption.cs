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
    public partial class EditOption : Form
    {
        private string option { get; set; }
        WheelOfFortune wof = new WheelOfFortune();
        API api = new API();

        public EditOption(string options)
        {
            InitializeComponent();
            titleLabel.Text= titleLabel.Text + "\"" + options + "\"";
            textBox.Text = options;
            option = options;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "")
            {
                wof.editData(textBox.Text, option);
                this.Close();
            }
            else 
            {
                string text = "Leaving the object in blank will delete it from the list." +
                "\nDo you wish to proceed?";
                msgBoxDelete(text);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string text = "Are you sure you want to delete this option?";
            msgBoxDelete(text);
        }



        //Delete void
        private void msgBoxDelete(string text) 
        {
            //Messagebox buttons
            MessageBoxManager.Unregister();
            MessageBoxManager.Yes = "Yeah";
            MessageBoxManager.No = "Nah";
            MessageBoxManager.Register();
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            //Display messagebox
            DialogResult dr = MessageBox.Show(text, "Delete option", buttons);

            if (dr == DialogResult.Yes)
            {
                wof.deleteData(option);
                this.Close();
            }
        }
    }
}
