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
    public partial class Winner : Form
    {
        public Winner(string answer)
        {
            InitializeComponent();
            winnerLabel.Text = answer+"!";

            //Increase size of form if the label is too big
            if (winnerLabel.Size.Width > 345)
            {
                winnerLabel.Location = new Point(0, 46);
                Size = new Size(winnerLabel.Size.Width + 24,144);
            }

            //Center "Congrat!"
            int tPoint = (Size.Width / 2) - (titleLabel.Size.Width / 2);
            titleLabel.Location = new Point(tPoint, 9);

            //Center "Winner"
            int wPoint = (Size.Width / 2) - (winnerLabel.Size.Width / 2);
            winnerLabel.Location = new Point(wPoint, 46);
        }
    }
}
