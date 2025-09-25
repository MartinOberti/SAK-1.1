using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace SAK_1._1
{
    class API
    {
        public int randomNumber(int a, int b) 
        {
            //Get data and calculate answer
            Random rnd = new Random();
            if (a > b)
            {
                int aux = a;
                a = b;
                b = aux;
            }
            return rnd.Next(a,b+1);
        }

        public void messageBoxSimple(string text, string title, string ok) 
        {
            //Buttons
            MessageBoxManager.Unregister();
            MessageBoxManager.OK = ok;
            MessageBoxManager.Register();
            MessageBoxButtons buttons = MessageBoxButtons.OK;

            //Messagebox
            MessageBox.Show(text, title, buttons);
        }

        public void messageBoxSimple(string text, string title, string ok, MessageBoxIcon icon)
        {
            //Buttons
            MessageBoxManager.Unregister();
            MessageBoxManager.OK = ok;
            MessageBoxManager.Register();
            MessageBoxButtons buttons = MessageBoxButtons.OK;

            //Messagebox
            MessageBox.Show(text, title, buttons, icon);
        }

        public bool isFormOpen(Type formType)
        {
            bool answer = false;
            //Check all open forms to find the one im looking for
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType().Name == formType.Name)
                {
                    answer = true;
                }
            }
            return answer;
        }

        //Gets a string out of a group separated by a particular symbol (char separator)
        public string getStringFromGroup(string searchedString, char separator, int position) 
        {
            string ret = "";
            int counter = 0;

            //for loop to get the required string
            for (int i = 0; i < searchedString.Length; i++)
            {
                //if the character on the searched string matches the separator
                if (searchedString[i] == separator) 
                {
                    //increase the counter
                    counter++;
                    //skip to the next string character
                    i++;
                }
                //if the counter matches the position, we copy paste each character onto the return string
                if (counter == position) 
                { 
                    ret += searchedString[i];
                }
            }
            return ret;
        }
    }
}
