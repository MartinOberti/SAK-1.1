using SAK_1._1.Discord_Time_Generator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAK_1._1
{
    public partial class TimeGenerator : Form
    {
        //Import Methods
        private TimeGeneratorMethods tgm = new TimeGeneratorMethods();
        private static API api = new API();


        //Default Date as a Global Variable
        //Default date 31/12/1969 9:00 PM
        public static DateTime referenceDate = new DateTime(1969, 12, 31, 21, 0, 0);


        //Set TextBoxes from DateTimes
        public void setDateTime(DateTime dt) 
        {
            //Get Date Values
            string day = tgm.extraZero(dt.Day.ToString());
            string month = tgm.extraZero(dt.Month.ToString());
            string year = tgm.fourDigitYear(dt.Year.ToString());

            //Set Date
            dateTextBox.Text = day + month + year;

            //Get Time Values
            string hour = tgm.extraZero(dt.Hour.ToString());
            string minute = tgm.extraZero(dt.Minute.ToString());
            string second = tgm.extraZero(dt.Second.ToString());

            //Set Time
            timeTextBox.Text = hour + minute + second;
        }


        //Time Generator Class
        public TimeGenerator()
        {
            InitializeComponent();

            //Invalid Labels for the text boxes
            invalidDateLabel.Visible = false;
            invalidTimeLabel.Visible = false;
            invalidTypeLabel.Visible = false;
        }



        //--------------------------------------------------
        //CALENDAR
        //Button that enables the calendar
        private void button1_Click(object sender, EventArgs e)
        {
            calendar.Visible = true;
        }


        //If the mouse leaves the calendar, it dissapears
        private void calendar_MouseLeave(object sender, EventArgs e)
        {
            calendar.Visible = false;
        }


        //Setting the date from the calendar
        //The user clicks the button to open the calendar, then selects their date
        private void calendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            //Get date from calendar
            DateTime dt = calendar.SelectionRange.Start;

            //Combine all calendar values into one string
            string dateSelected = tgm.extraZero(dt.Day.ToString())  //Set Day
                + tgm.extraZero(dt.Month.ToString())                //Set Month
                + dt.Year.ToString();                               //Set Year

            //Insert date onto the text box
            dateTextBox.Text = dateSelected;

            //Remove calendar
            calendar.Visible = false;

            //Set invalidDateLabel to not visible
            invalidDateLabel.Visible = false;
        }
        //--------------------------------------------------



        //--------------------------------------------------
        //DATE TEXT BOX
        //Updates the set date whenever the mouse leaves the text box.
        //This function exists so that no wrong dates are written down by the user.
        //Should this happen, this event will update them accordingly
        private void dateTextBox_MouseLeave(object sender, EventArgs e)
        {
            updateDateFields();
        }

        private void dateTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                updateDateFields();
            }
        }

        private void updateDateFields() 
        {
            //Obtains the date from the text box
            string date = tgm.updateDate(dateTextBox.Text);

            //If the date is valid
            if (!tgm.isUndefined(date))
            {
                //Update text label
                dateTextBox.Text = date;
            }

            //Update invalid label accordingly
            invalidDateLabel.Visible = tgm.isUndefined(date);
        }
        //--------------------------------------------------



        //--------------------------------------------------
        //TIME TEXT BOX
        //Updates the set time whenever the mouse leaves the text box.
        //The time has to be written down by the user, and multiple checks have been coded
        //So that no wrong times pass by.
        private void timeTextBox_MouseLeave(object sender, EventArgs e)
        {
            updateTimeFields();   
        }

        private void timeTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                updateTimeFields();
            }
        }

        private void updateTimeFields() 
        {
            //Obtains the time written down by the user
            string time = tgm.updateTime(timeTextBox.Text);
            double extraDays = tgm.returnExtraDays();

            if (!tgm.isUndefined(time))
            {
                //Update text label
                timeTextBox.Text = time;

                //Update date should there be extra days
                string date = dateTextBox.Text;
                date = tgm.addDays(date, extraDays);
                dateTextBox.Text = date;
            }

            //Update invalid label accordingly
            invalidTimeLabel.Visible = tgm.isUndefined(time);
        }
        //--------------------------------------------------



        //--------------------------------------------------
        //TYPE COMBO BOX
        private void typeBox_Updated(object sender, EventArgs e)
        {
            //Updates invalid label accordingly
            invalidTypeLabel.Visible = tgm.isUndefined(typeBox.Text);
        }
        //--------------------------------------------------



        //--------------------------------------------------
        //DATETIME SET BUTTONS
        //Writes down the current date and time on the text boxes
        private void getCurrentDateButton_Click(object sender, EventArgs e)
        {
            //Get current date time
            DateTime now = DateTime.Now;

            //Set current date
            setDateTime(now);
        }


        //Writes down minimum accepted date
        private void getMinDateButton_Click(object sender, EventArgs e)
        {
            DateTime min = DateTime.MinValue;
            setDateTime(min);
        }


        //Writes down maximum accepted date
        private void getMaxDateButton_Click(object sender, EventArgs e)
        {
            DateTime max = DateTime.MaxValue;
            setDateTime(max);
        }


        //Writes down reference date
        private void getReferenceDate_Click(object sender, EventArgs e)
        {
            setDateTime(referenceDate);
        }
        //--------------------------------------------------



        //--------------------------------------------------
        //REFERENCE DATE
        //Checkbox for the reference date. Just in case it changes in the future
        private void referenceDateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (referenceDateCheckBox.Checked) { generateOutputButton.Text = "Set"; }
            else { generateOutputButton.Text = "Generate"; }
        }
        //--------------------------------------------------



        //--------------------------------------------------
        //GENERATE OUTPUT BUTTON
        //The meat and potatoes. Gives the user the code to copy-paste onto discord
        //Here´s where we´ll use the global variables
        private void generateOutputButton_Click(object sender, EventArgs e)
        {
            //Enable invalid labels should the text boxes contain invalid values
            string date = tgm.updateDate(dateTextBox.Text);
            bool bDate = tgm.isUndefined(date);
            invalidDateLabel.Visible = bDate;

            string time = tgm.updateTime(timeTextBox.Text);
            bool bTime = tgm.isUndefined(time);
            invalidTimeLabel.Visible = bTime;

            string type = typeBox.Text;
            bool bType = tgm.isUndefined(type);
            invalidTypeLabel.Visible = bType;

            //Find out which values are missing, then show a messagebox
            //Method also returns a boolean. Execute equation for copy/paste code if false (no errors)
            if (!tgm.showGenErrMessage(bDate, bTime, bType)) 
            {
                //Create new DateTime instance for our global values
                string completeDate = dateTextBox.Text + " " + timeTextBox.Text;
                DateTime userDate = DateTime.Parse(completeDate);

                //Check for refence date change
                bool changeRef = referenceDateCheckBox.Checked;
                switch (changeRef)
                {
                    //If it´s checked, change reference date to the written one
                    case true:
                        referenceDate = userDate;
                        api.messageBoxSimple("The reference date has been changed!","Reference Date","Ight!");
                        break;

                    //If it isn´t checked
                    case false:
                        //Get copy-paste code
                        tgm.generateCode(userDate, referenceDate, type);

                        //Finish 
                        break;
                }
            }
        }
        //--------------------------------------------------
    }
}
