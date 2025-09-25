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
    public partial class About : Form
    {
        public About(string text, string title, int y)
        {
            InitializeComponent();
            textLabel.Text = text;
            titleLabel.Text = title;
            Size = new Size(500, y);
        }

        public About(string text, string title, int maxSize, int y)
        {
            InitializeComponent();
            textLabel.Text = text;
            titleLabel.Text = title;
            textLabel.MaximumSize = new Size(maxSize, 0);
            Size = new Size(600, y);
        }
    }
}
