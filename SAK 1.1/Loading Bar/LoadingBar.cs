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
    public partial class LoadingBar : Form
    {
        public LoadingBar()
        {
            InitializeComponent();
            progressBar.Maximum = 10;
            timer.Start();
        }

        public LoadingBar(int time) 
        {
            InitializeComponent();
            progressBar.Maximum = time;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            progressBar.Increment(1);
            if (progressBar.Value == progressBar.Maximum) 
            {
                this.Close();
            }
        }
    }
}
