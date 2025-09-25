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
    public partial class MainForm : Form
    {
        //Open api
        API api = new API();

        public MainForm()
        {
            InitializeComponent();
        }



        //Logo Events
        private void logoBox_MouseEnter(object sender, EventArgs e)
        {
            this.logoBox.Image = Properties.Resources.Logo1__Mouse_Enter_;
        }

        private void logoBox_MouseLeave(object sender, EventArgs e)
        {
            this.logoBox.Image = Properties.Resources.Logo1;
        }

        private void logoBox_Click(object sender, EventArgs e)
        {
            this.logoBox.Image = Properties.Resources.Logo1__Mouse_Click_;

            //Open About Form
            //About a = new About();
            //a.ShowDialog();
        }



        //Button Events
        private void wheelButton_Click(object sender, EventArgs e)
        {
            WheelOfFortune wof = new WheelOfFortune();
            if (!api.isFormOpen(typeof(WheelOfFortune)))
            {
                wof.Show();
            }
            else
            {
                msgBoxWarning();
            }
        }

        private void listButton_Click(object sender, EventArgs e)
        {

        }

        private void hotButton_Click(object sender, EventArgs e)
        {
            HeadsOrTails hot = new HeadsOrTails();
            if (!api.isFormOpen(typeof(HeadsOrTails)))
            {
                hot.Show();
            }
            else 
            {
                msgBoxWarning();
            }
        }

        private void rngButton_Click(object sender, EventArgs e)
        {
            RandomNumber rn = new RandomNumber();
            if (!api.isFormOpen(typeof(RandomNumber)))
            {
                rn.Show();
            }
            else 
            {
                msgBoxWarning();
            }
        }

        private void calculatorButton_Click(object sender, EventArgs e)
        {

        }

        private void discordButton_Click(object sender, EventArgs e)
        {
            TimeGenerator tg = new TimeGenerator();
            if (!api.isFormOpen(typeof(TimeGenerator)))
            {
                tg.Show();
            }
            else
            {
                msgBoxWarning();
            }
        }

        private void unitButton_Click(object sender, EventArgs e)
        {

        }

        private void unusedButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=48rz8udZBmQ");
        }


        //Extra Private Voids
        private void msgBoxWarning() 
        {
            //Messagebox Strings
            string text = "This tool is currently open";
            string title = "Notice";

            //Messagebox Buttons
            MessageBoxManager.Unregister();
            MessageBoxManager.OK = "Aight";
            MessageBoxManager.Register();
            MessageBoxButtons buttons = MessageBoxButtons.OK;

            //Messagebox Icon
            MessageBoxIcon icon = MessageBoxIcon.Information;

            //Messagebox
            MessageBox.Show(text,title,buttons,icon);
        }
    }
}
