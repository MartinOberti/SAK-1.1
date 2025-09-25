using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.IO;

namespace SAK_1._1
{
    public partial class WheelOfFortune : Form
    {
        //List for the list box
        static List<string> options = new List<string>();
        BindingSource listBS = new BindingSource();

        //Title for the list
        static string listTitle { get; set; }
        static string loadedTitle { get; set; }

        //Load times for the loading bar (seconds * 10)
        public static int loadTime { get; set; }

        //Forms
        API api = new API();

        public WheelOfFortune()
        {
            InitializeComponent();
            listBox.HorizontalScrollbar = true;
        }



        //Data recieving voids
        internal void changeTitle(string text)
        {
            listTitle = text;
        }

        internal void recieveData(string text)
        {
            options.Add(text);
        }
        internal void editData(string text, string option)
        {
            int i = options.FindIndex(a => a.Contains(option));
            options[i] = text;
        }

        internal void deleteData(string text)
        {
            options.Remove(text);
        }

        internal void setLoadTime(int time)
        {
            loadTime = time;
        }



        //Form voids
        //-----------------------------------------------------------------------------------
        private void WheelOfFortune_Load(object sender, EventArgs e)
        {
            //Load list on list box
            listBS.DataSource = options;
            listBox.DataSource = listBS;

            //Load list title
            listTitle = listTitleLabel.Text;
            loadedTitle = "None";

            //Loading bar always starts with 1 second
            loadTime = 10;

            //List loads empty
            options.Clear();
        }
        private void WheelOfFortune_Activated(object sender, EventArgs e)
        {
            //Update title
            listTitleLabel.Text = listTitle;
            loadTitleLabel.Text = "Loaded List: " + loadedTitle;
            //Update list
            listBS.ResetBindings(false);

            //Load Files
            loadMenuStrip.Items.Clear();
            deleteMenuStrip.Items.Clear();

            StreamReader sr = new StreamReader("Wheel.txt",true);
            string line = sr.ReadLine();
            string save = "";

            while (line != null) 
            {
                string title = getTitleFromLine(line);
                if (save != title) 
                {
                    save = title;
                    loadMenuStrip.Items.Add(save);
                    deleteMenuStrip.Items.Add(save);
                }
                line = sr.ReadLine();
            }
            sr.Close();
        }



        //Buttons and list voids
        //-----------------------------------------------------------------------------------
        private void listTitleLabel_Click(object sender, EventArgs e)
        {
            ChangeTitle ct = new ChangeTitle(listTitle);
            ct.ShowDialog();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddOption ao = new AddOption(listTitle);
            if (listTitle != "(Enter List Name)")
            {
                ao.ShowDialog();
            }
            else 
            {
                msgBoxTitle();
            }
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            options.Sort();

            //messagebox
            api.messageBoxSimple("List Sorted","","Cool!");
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //MessageBox Yes/No
            MessageBoxManager.Unregister();
            MessageBoxManager.Yes = "Yeah";
            MessageBoxManager.No = "Nah";
            MessageBoxManager.Register();
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            //text
            string text = "Are you sure you want to clear this list?";

            //Display messagebox
            DialogResult dr = MessageBox.Show(text, "Clear list", buttons);

            //If user clicks yes, delete item
            if (dr == DialogResult.Yes)
            {
                //Clear list and title
                listTitle = "(Enter List Name)";
                options.Clear();

                //Message box
                text = "List has been cleared!";
                string title = "List Cleared";
                string ok = "Surreal!";
                api.messageBoxSimple(text, title, ok);
            }

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //Failsafe
            int check = 0;
            if (listTitle == "(Enter List Name)") 
            {
                check += 1;
            }
            if (options.Count == 0) 
            {
                check += 2;
            }

            switch (check) 
            {
                //Title and list elements missing
                case 3:
                    string text = "You lack both a title AND list elements! D:";
                    string title = "Mega Notice";
                    string ok = "Holy Moly!";
                    MessageBoxIcon icon = MessageBoxIcon.Information;
                    api.messageBoxSimple(text,title,ok,icon);
                    break;

                //List elements missing
                case 2:
                    msgBoxList();
                    break;

                //Title missing
                case 1:
                    msgBoxTitle();
                    break;

                //All good to go
                case 0:
                    if (!listAlreadySaved(listTitle))
                    {
                        //Save list onto file
                        loadedTitle = listTitle;
                        StreamWriter sw = new StreamWriter("Wheel.txt",true);
                        for (int i = 0; i < options.Count; i++) 
                        {
                            string line = listTitle + "|" + options[i];
                            sw.WriteLine(line);
                        }
                        sw.Dispose();

                        //Message box
                        text = "List saved!";
                        title = "Saved";
                        ok = "Épico!";
                        api.messageBoxSimple(text, title, ok);
                    }
                    else 
                    {
                        //Message box
                        text = "This list already exists!";
                        title = "Notice";
                        ok = "Yikers!";
                        icon = MessageBoxIcon.Information;
                        api.messageBoxSimple(text,title,ok,icon);
                    }
                    break;
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            loadMenuStrip.Show(loadButton,0,loadButton.Height);
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            //MessagBox Yes/No
            MessageBoxManager.Unregister();
            MessageBoxManager.Yes = "Yeah";
            MessageBoxManager.No = "Nah";
            MessageBoxManager.Register();
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            //Text
            string text= "Are you sure you want to update "+loadedTitle+"?";

            //Display messagebox
            DialogResult dr = MessageBox.Show(text, "Update option", buttons);

            //If user clicks yes, update item
            if (dr == DialogResult.Yes) 
            {
                //Temp file to load lines in
                var tempFile = Path.GetTempFileName();

                //Reading File and updating lines
                bool saved = false;
                StreamReader sr = new StreamReader("Wheel.txt", true);
                StreamWriter sw = new StreamWriter(tempFile, true);
                string line = sr.ReadLine();
                while (line != null) 
                {
                    string cTitle = getTitleFromLine(line);
                    if (cTitle != loadedTitle)
                    {
                        sw.WriteLine(line);
                    }
                    else if (saved==false)
                    {
                        for (int i = 0; i < options.Count; i++) 
                        {
                            string sLine = listTitle + "|" + options[i];
                            sw.WriteLine(sLine);
                        }
                        saved = true;
                    }
                    line = sr.ReadLine();
                }
                sr.Close();
                sw.Dispose();

                //Clear and move contents in files
                File.Delete("Wheel.txt");
                File.Move(tempFile, "Wheel.txt");

                //Change loaded title
                loadedTitle = listTitle;

                //Message box
                text = "List updated!";
                string title = "Updated";
                string ok = "Stupendous!";
                api.messageBoxSimple(text, title, ok);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            deleteMenuStrip.Show(deleteButton,0,deleteButton.Height);
        }
        private void spinWheelButton_Click(object sender, EventArgs e)
        {
            if (options.Count > 0)
            {
                //Find random winner
                int random = api.randomNumber(0, options.Count - 1);
                string winner = options[random];

                //Loading bar
                LoadingBar lb;
                if (loadTime != 0)
                {
                    lb = new LoadingBar(loadTime);
                    lb.ShowDialog();
                }

                //Show winner
                Winner w = new Winner(winner);
                w.Show();

                //Remove winner if check box is checked
                if (checkBox.Checked) 
                {
                    options.RemoveAt(random);
                }
            }
            else
            {
                string text = "Your list has no winners to pick!";
                string title = "Notice";
                string ok = ":(";
                MessageBoxIcon icon = MessageBoxIcon.Information;
                api.messageBoxSimple(text,title,ok,icon);
            }
        }

        private void listBox_DoubleClick(object sender, EventArgs e)
        {
            int i = listBox.SelectedIndex;
            if (i >= 0) 
            {
                EditOption eo = new EditOption(options[i]);
                eo.ShowDialog();
            }
        }



        //Context menu strips
        //-----------------------------------------------------------------------------------
        private void loadMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //Clear list and change title
            options.Clear();
            listTitle = e.ClickedItem.Text;
            loadedTitle = listTitle;
            listTitleLabel.Text = loadedTitle;

            //load list contents
            StreamReader sr = new StreamReader("Wheel.txt",true);
            string line = sr.ReadLine();
            while (line != null) 
            {
                string cTitle = getTitleFromLine(line);
                if (cTitle == loadedTitle) 
                {
                    string option = getOptionFromLine(line);
                    recieveData(option);
                }
                line = sr.ReadLine();
            }
            sr.Close();

            //Message box
            string text = "List loaded!";
            string title = "Loaded";
            string ok = "Radical!";
            api.messageBoxSimple(text, title, ok);

        }

        private void deleteMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //Title and temp file
            string clickedTitle = e.ClickedItem.Text;
            var tempFile = Path.GetTempFileName();

            //MessageBox Yes/No
            MessageBoxManager.Unregister();
            MessageBoxManager.Yes = "Yeah";
            MessageBoxManager.No = "Nah";
            MessageBoxManager.Register();
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            //text
            string text = "Are you sure you want to delete " + clickedTitle + "?";

            //Display messagebox
            DialogResult dr = MessageBox.Show(text, "Delete option", buttons);

            //If user clicks yes, delete item
            if (dr == DialogResult.Yes)
            {
                //Deloading title if its the same as the clicked one
                if (loadedTitle == clickedTitle)
                {
                    loadedTitle = "None";
                    listTitle = "(Enter List Name)";
                    options.Clear();
                }

                //Reading file and uploading lines without the clicked list
                StreamReader sr = new StreamReader("Wheel.txt", true);
                StreamWriter sw = new StreamWriter(tempFile, true);
                string line = sr.ReadLine();
                while (line != null)
                {
                    string cTitle = getTitleFromLine(line);
                    if (cTitle != clickedTitle)
                    {
                        sw.WriteLine(line);
                    }
                    line = sr.ReadLine();
                }
                sr.Close();
                sw.Dispose();

                //Clear and move contents in files
                File.Delete("Wheel.txt");
                File.Move(tempFile, "Wheel.txt");

                //Message box
                text = "List deleted!";
                string title = "Deleted";
                string ok = "Stupendous!";
                api.messageBoxSimple(text, title, ok);
            }
        }



        //Set and get loading times
        //-----------------------------------------------------------------------------------
        private void setToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Call form to set load time
            SetLoadTime slt = new SetLoadTime(loadTime, 3);
            slt.ShowDialog();
    }

        private void getToolStripMenuItem_Click(object sender, EventArgs e)
        {
            API api = new API();
            string text = "The current load time is " + (loadTime / 10).ToString() + " seconds.";
            string title = "Load Time";
            string ok = "Epic";
            api.messageBoxSimple(text, title, ok);
        }



        //Help
        //-----------------------------------------------------------------------------------
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Values
            string text = "Add your own options to the list, and have one of said options be chosen at random. " +
                "Said winner can be removed out of the list if the user so chooses by checking the box below the \"Spin the Wheel\" Button. " +
                "Each list can be customized, not only with its contents, but with its name as well and with the sort button, " +
                "which will instantly sort it alphabetically. " +
                "\n\nEach list can also be saved to be used later, just in case you need to use it again. " +
                "Worth noting that lists can´t share names while saved. " +
                "Saved lists can also be updated and deleted as the user sees fit." +
                "\n\nThis function also comes with an artificial loading bar, used to add an extra factor of surprise. " +
                "Said loading bar can be adjusted in time by going to Options > Loading Bar Time > Set. " +
                "Setting the load bar to 0 will automatically disable it.";
            string title = "Wheel of Fortune";
            int maxSize = 575;
            int y = 460;

            //Print
            About a = new About(text, title, maxSize, y);
            a.ShowDialog();
        }



        //Mouse enters on list name
        //-----------------------------------------------------------------------------------
        private void listTitleLabel_MouseEnter(object sender, EventArgs e)
        {
            listTitleLabel.ForeColor = Color.FromArgb(255,240,130);
        }
        //Mouse leaves list name
        private void listTitleLabel_MouseLeave(object sender, EventArgs e)
        {
            listTitleLabel.ForeColor = Color.FromArgb(255, 255, 255);
        }



        //Extra Private Voids
        //-----------------------------------------------------------------------------------
        //List has no title
        private void msgBoxTitle() 
        {
            string text = "You haven´t named your list yet!";
            string title = "Notice";
            string ok = "My b";
            MessageBoxIcon icon = MessageBoxIcon.Information;
            api.messageBoxSimple(text, title, ok, icon);
        }

        private void msgBoxList() 
        {
            string text = "Your list is empty!";
            string title = "Notice";
            string ok = "Oopsie";
            MessageBoxIcon icon = MessageBoxIcon.Information;
            api.messageBoxSimple(text, title, ok, icon);
        }

        //Deletes the option from the line, leaving only the title
        private string getTitleFromLine(string line)
        {
            string answer = "";
            bool a = false;
            for (int i = 0; i < line.Length; i++) 
            {
                if (line[i] != '|' && !a)
                {
                    answer += line[i];
                }
                else 
                {
                    a = true; 
                }
            }
            return answer;
        }

        //Deletes the title from the line, leaving only the option
        private string getOptionFromLine(string line) 
        {
            string answer = "";
            bool a = false;
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] != '|' && a)
                {
                    answer += line[i];
                }
                else if (line[i]=='|')
                {
                    a = true;
                }
            }
            return answer;
        }

        //compare titles
        private bool listAlreadySaved(string title) 
        {
            bool answer = false;
            StreamReader sr = new StreamReader("Wheel.txt",true);
            string line = sr.ReadLine();
            while (line != null) 
            {
                string cTitle = getTitleFromLine(line);
                if (title == cTitle) 
                {
                    answer = true;
                }
                line = sr.ReadLine();
            }
            sr.Close();
            return answer;
        }
    }
}
