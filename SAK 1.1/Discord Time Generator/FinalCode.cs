using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAK_1._1.Discord_Time_Generator
{
    public partial class FinalCode : Form
    {
        public FinalCode(string code, string preview)
        {
            InitializeComponent();

            //--------------------------------------------------
            //SET RECIEVED VALUES
            codeLabel.Text = code;
            previewLabel.Text = preview;
            //--------------------------------------------------



            //--------------------------------------------------
            //CENTER COMPONENTS
            //Center "Final Code:"
            int point1 = (Size.Width / 2) - (titleLabel.Width / 2);
            titleLabel.Location=new Point(point1,9);

            //Center Copy-Paste Code
            int point2 = (Size.Width / 2) - (codeLabel.Width / 2);
            codeLabel.Location=new Point(point2,50);

            //Center Preview
            int point3 = (Size.Width / 2) - (previewLabel.Width / 2);
            previewLabel.Location=new Point(point3,108);

            //Center Copy-Paste Button (Too lazy to do it myself lmfao)
            int point4 = (Size.Width / 2) - (copyCodeButton.Width / 2);
            copyCodeButton.Location = new Point(point4, 160);
            //--------------------------------------------------
        }

        //Copy final code to clipboard
        private void copyCodeButton_Click(object sender, EventArgs e)
        {
            //Code to copy
            Clipboard.SetText(codeLabel.Text);

            //API for messagebox
            API api = new API();
            api.messageBoxSimple("Code has been copied to clipboard!", "Code Copied", "Radical!");
        }
    }
}
