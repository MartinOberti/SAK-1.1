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
    public partial class HeadsOrTails : Form
    {
        //Load times for the loading bar (seconds * 10)
        public static int loadTime { get; set; }

        public HeadsOrTails()
        {
            //Loading bar always starts with 1 second
            InitializeComponent();
            loadTime = 10;
        }

        private void flipCoinButton_Click(object sender, EventArgs e)
        {
            //Get heads or tails
            API api = new API();
            string answer = "";
            if (api.randomNumber(1, 2) == 1)
            {
                answer = "HEADS";
            }
            else 
            {
                answer = "TAILS";
            }

            //Loading bar
            LoadingBar lb;
            if (loadTime != 0)
            {
                lb = new LoadingBar(loadTime);
                lb.ShowDialog();
            }

            //Open Winner form
            Winner w = new Winner(answer);
            w.Show();
        }

        //Set load time
        private void setToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Call form to set load time
            SetLoadTime slt = new SetLoadTime(loadTime,2);
            slt.ShowDialog();
        }
        
        //Get load time
        private void getToolStripMenuItem_Click(object sender, EventArgs e)
        {
            API api = new API();
            string text = "The current load time is " + (loadTime / 10).ToString() + " seconds.";
            string title = "Load Time";
            string ok = "Epic";
            api.messageBoxSimple(text, title, ok);
        }

        //Help
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Values
            string text = "Press the button in the center and the algorithm will print an answer between heads or tails." +
                "\n\nThis function also comes with an artificial loading bar, used to add an extra factor of surprise. " +
                "Said loading bar can be adjusted in time by going to Options > Loading Bar Time > Set. " +
                "Setting the load bar to 0 will automatically disable it.";
            string title = "Heads or Tails";
            int y = 300;

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
