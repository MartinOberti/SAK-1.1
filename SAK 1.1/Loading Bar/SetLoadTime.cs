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
    public partial class SetLoadTime : Form
    {
        //type of form open
        public int type { get; set; }

        //open api
        API api = new API();
        public SetLoadTime(int loadTime,int fType)
        {
            InitializeComponent();
            loadTimeNumeric.Value = loadTime/10;
            type = fType;
        }

        private void setButton_Click(object sender, EventArgs e)
        {
            switch (type) 
            {
                //Random Number Set
                case 1:
                    RandomNumber rn = new RandomNumber();
                    rn.setLoadTime((int)loadTimeNumeric.Value * 10);
                    break;

                //Heads or Tails Set
                case 2:
                    HeadsOrTails hot = new HeadsOrTails();
                    hot.setLoadTime((int)loadTimeNumeric.Value * 10);
                    break;

                //Wheel of Fortune Set
                case 3:
                    WheelOfFortune wof = new WheelOfFortune();
                    wof.setLoadTime((int)loadTimeNumeric.Value * 10);
                    break;
            }

            this.Close();
        }
    }
}
