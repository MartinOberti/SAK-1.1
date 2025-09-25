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
    public partial class RandomNumber : Form
    {
        //Load times for the loading bar (seconds * 10)
        public static int loadTime { get; set; }

        public RandomNumber()
        {
            //Loading bar always starts with 1 second
            InitializeComponent();
            loadTime = 10;
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            //Get data and calculate answer
            API api = new API();
            int a = (int)numericUpDown1.Value;
            int b = (int)numericUpDown2.Value;
            int answer = api.randomNumber(a,b);

            //Loading bar
            LoadingBar lb;
            if (loadTime != 0)
            {
                lb = new LoadingBar(loadTime);
                lb.ShowDialog();
            }

            //Open Winner form
            Winner w = new Winner(answer.ToString());
            w.Show();
        }

        //Set load time
        private void setToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Call form to set load time
            SetLoadTime slt = new SetLoadTime(loadTime,1);
            slt.ShowDialog();
        }

        //Get load time
        private void getToolStripMenuItem_Click(object sender, EventArgs e)
        {
            API api = new API();
            string text = "The current load time is " + (loadTime / 10).ToString() + " seconds.";
            string title = "Load Time";
            string ok = "Epic";
            api.messageBoxSimple(text,title,ok);
        }

        //Help
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Values
            string text = "Set two random numbers on the boxes then click on the \"Generate!\" button to get a random number in between your two options." +
                "\n\nThis function also comes with an artificial loading bar, used to add an extra factor of surprise. " +
                "Said loading bar can be adjusted in time by going to Options > Loading Bar Time > Set. " +
                "Setting the load bar to 0 will automatically disable it.";
            string title = "Random Number Generator";
            int y = 320;

            //Print
            About a = new About(text,title,y);
            a.ShowDialog();
        }



        //Get load time from external form
        internal void setLoadTime(int time)
        {
            loadTime = time;
        }
    }
}
