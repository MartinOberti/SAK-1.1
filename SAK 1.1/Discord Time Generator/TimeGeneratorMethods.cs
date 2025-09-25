using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAK_1._1.Discord_Time_Generator
{
    internal class TimeGeneratorMethods
    {
        //initialize api to get library
        API api = new API();



        //--------------------------------------------------
        //DATE METHODS
        //Date class. Used to update date global variables
        //Updates date given to it on a string
        public string updateDate(string date)
        {
            //If the written date is valid
            if (DateTime.TryParse(date, out DateTime parsedDate))
            {
                //Do nothing to the string
            }

            //If it´s invalid
            else
            {
                //Try to get values from the string
                try
                {
                    int iYear = int.Parse(api.getStringFromGroup(date, '/', 2));
                    int iMonth = int.Parse(api.getStringFromGroup(date, '/', 1));
                    int iDay = int.Parse(api.getStringFromGroup(date, '/', 0));

                    //Update values
                    iMonth = monthCorrected(iMonth);
                    iDay = dayCorrected(iDay, iMonth, iYear);
                    iYear = aboveZero(iYear);

                    //Update string
                    date = extraZero(iDay.ToString()) + '/'         //Days
                        + extraZero(iMonth.ToString()) + '/'        //Months
                        + fourDigitYear(iYear.ToString());          //Year
                }

                //If the values aren´t comprehensible
                catch
                {
                    date = "UNDEFINED";
                }
            }
            return date;
        }


        //Add days to a date
        public string addDays(string date, double extraDays)
        {
            //Failsafe just in case the date is invalid
            date = updateDate(date);

            if (extraDays > 0 && !isUndefined(date))
            {
                //Parse datetime to add days
                DateTime dt = DateTime.Parse(date);

                //Messagebox buttons
                string text = $"The date has been updated by {extraDays} day/s";
                string title = "Date Updated!";
                string ok = "Superb!";

                //Add days to the date
                try
                {
                    //Change date
                    dt = dt.AddDays(extraDays);

                    //Show messageBox
                    api.messageBoxSimple(text, title, ok);
                }

                //If the date is already too big, we can´t add more days
                //Max Date = 31/12/9999
                catch
                {
                    //Change messageBox strings
                    text = "The date reached it´s maximul value! \nIt cannot be updated any further!";
                    title = "Notice!";
                    ok = "Understood!";

                    //Show messageBox
                    api.messageBoxSimple(text, title, ok);

                    //Change date to maximum value
                    dt = DateTime.MaxValue;
                }

                //Update date
                date = extraZero(dt.Day.ToString()) + '/'               //Days
                    + extraZero(dt.Month.ToString()) + '/'              //Months
                    + dt.Year.ToString();                               //Year

                //Return updated date (as string)
                return date;
            }

            else
            {
                return date;
            }
        }
        //--------------------------------------------------



        //--------------------------------------------------
        //TIME METHODS
        //Establish time class in order to update multiple variables at once
        //The class is static because we only want one instance of it; a global one.
        //We don´t want to make multiple instances of it, as that´s not what we need.
        public static class cTime
        {
            public static int hour { get; set; }
            public static int minute { get; set; }
            public static int second { get; set; }

            //Extra days to add to the date
            public static int extraDays { get; set; }
        }


        //Updates time given to it on a string
        public string updateTime(string time)
        {
            //If the written time is valid
            if (DateTime.TryParse(time, out DateTime parsedTime))
            {
                cTime.extraDays = 0;
            }

            //If it´s invalid
            else
            {
                //Try to get the values from the string
                try
                {
                    cTime.hour = int.Parse(api.getStringFromGroup(time, ':', 0));
                    cTime.minute = int.Parse(api.getStringFromGroup(time, ':', 1));
                    cTime.second = int.Parse(api.getStringFromGroup(time, ':', 2));

                    //Update values
                    timeCorrector();

                    //Update string
                    time = extraZero(cTime.hour.ToString()) + ':'     //Hour
                        + extraZero(cTime.minute.ToString()) + ':'    //Minute
                        + extraZero(cTime.second.ToString());         //Second
                }

                //If the values aren´t compatible
                catch
                {
                    time = "UNDEFINED";
                }
            }
            return time;
        }


        //Arranges the time accordingly
        public void timeCorrector()
        {
            //Set extraDays to 0. This is done so that they don´t accumulate
            //should the user write down another time with extra days
            cTime.extraDays = 0;

            //Fix seconds
            if (cTime.second > 59)
            {
                cTime.second -= 60;
                cTime.minute++;
            }

            //Fix minutes
            if (cTime.minute > 59)
            {
                cTime.minute -= 60;
                cTime.hour++;
            }

            //Fix hour
            while (cTime.hour > 23)
            {
                cTime.hour -= 24;
                cTime.extraDays++;
            }
        }
        //--------------------------------------------------



        //--------------------------------------------------
        //GENERATION METHODS
        //Show appropriate message box according to the missing values
        //returns boolean that indicates if there´s any error between the 3 parameters
        public Boolean showGenErrMessage(bool bDate, bool bTime, bool bType)
        {
            //Answer to return. error=true
            bool answer = true;

            //Get values from missing data
            int value = 0;
            value += bDate ? 2 : 0;
            value += bTime ? 3 : 0;
            value += bType ? 7 : 0;

            //Messagebox values
            string text = "You still haven´t selected/written ";
            string title = "Missing Values Notice!";
            string ok = "Oh dang!";

            //Edit the text accordingly
            switch (value)
            {
                case 0: answer = false; break;
                case 2: text += "a date!"; break;
                case 3: text += "a time!"; break;
                case 7: text += "a type!"; break;
                case 5: text += "a date and time!"; break;
                case 9: text += "a date and type!"; break;
                case 10: text += "a time and type!"; break;
                case 12: text += "anything!"; break;
            }

            //Show messagebox
            if (value > 0)
            {
                api.messageBoxSimple(text, title, ok);
            }

            //Return answer
            return answer;
        }


        //Retrns char for the copy-paste code
        public char getTypeChar(string type)
        {
            //Char to return
            char t = '-';

            //Switch to change the char
            switch (type)
            {
                case "Short Time": t = 't'; break;
                case "Long Time": t = 'T'; break;
                case "Short Date": t = 'd'; break;
                case "Long Date": t = 'D'; break;
                case "Long Date - Short Time": t = 'f'; break;
                case "Long Date - Week - Short Time": t = 'F'; break;
                case "Relative": t = 'R'; break;
            }

            return t;
        }


        //Returns string with preview for the code
        public string getReference(DateTime userDate, char t)
        {
            //String to return
            string ret = "";

            //Switch to change string
            switch (t)
            {
                case 't':
                    ret = userDate.ToString("hh:mm tt");
                    break;

                case 'T':
                    ret = userDate.ToString("hh:mm:ss tt");
                    break;

                case 'd':
                    ret = userDate.ToString("dd/MM/yyyy");
                    break;

                case 'D':
                    ret = userDate.ToString("MMMM dd, yyyy");
                    break;

                case 'f':
                    ret = userDate.ToString("MMMM dd, yyyy hh:mm tt");
                    break;

                case 'F':
                    ret = userDate.ToString("dddd, MMMM dd, yyyy hh:mm tt");
                    break;
                case 'R':
                    ret = getRelativeType(userDate);
                    break;
            }
            return ret;
        }



        //-------------------------
        //RELATIVE TYPE
        //There is no code to generate the relative datetime reference
        //So we´ll do it ourselves
        //Declare static class to save up the time differences
        public static class timeDifference
        {
            public static List<int> values = new List<int>();
            //0=years
            //1=months
            //2=days
            //3=hours
            //4=minutes
            //5=seconds

            //Static void to set the recieved values
            public static void setDiff(DateTime userDate)
            {
                //Clear list. This is to prevent it from storing the same values
                //in case the user generates a new date
                values.Clear();

                //Get current date time to compare user date
                DateTime now = DateTime.Now;

                //Ensure user is always earlier than or equal to now
                if (userDate > now)
                {
                    DateTime temp = userDate;
                    userDate = now;
                    now = temp;
                }

                //Difference between dates
                TimeSpan diff = now - userDate;

                //Set Years
                int years = now.Year - userDate.Year;

                // Adjust for cases where the end date's month/day comes before the start date's month/day
                if (now.Month < userDate.Month || (now.Month == userDate.Month && now.Day < userDate.Day))
                {
                    years--;
                }
                values.Add(years);

                //Set Months
                int months = (now.Year - userDate.Year) * 12 + (now.Month - userDate.Month);

                // Adjust if the end day is before the start day in the same calendar month
                if (now.Day < userDate.Day)
                {
                    months--;
                }
                values.Add(months);

                //Set Days
                values.Add((int)diff.TotalDays);

                //Set Hours
                values.Add((int)diff.TotalHours);

                //Set Minutes
                values.Add((int)diff.TotalMinutes);

                //Set Seconds
                values.Add((int)diff.TotalSeconds);
            }
        }


        //Work with the set values to get the string
        public string getRelativeType(DateTime userDate)
        {
            //Set difference
            timeDifference.setDiff(userDate);

            //iType=month,day,second,etc.
            int iType = 0;

            //amount= amount of the type. ex:('3' months)
            int amount = 0;

            //For loop to find the values
            for (int i = 0; i < timeDifference.values.Count; i++)
            {
                if (timeDifference.values[i] != 0)
                {
                    //Set values
                    iType = i;
                    amount = (int)timeDifference.values[i];

                    //End for loop
                    break;
                }
            }

            //String to return
            string ret = $"{amount} ";

            //Switch case to get the type
            switch (iType)
            {
                case 0: ret += "year"; break;
                case 1: ret += "month"; break;
                case 2: ret += "day"; break;
                case 3: ret += "hour"; break;
                case 4: ret += "minute"; break;
                case 5: ret += "second"; break;
            }

            //Add an extra s for when value>1
            ret = (amount > 1) ? ret + "s" : ret;

            //Past or present
            ret = (userDate > DateTime.Now) ? "In " + ret : ret + " ago";

            return ret;
        }
        //-------------------------



        //The big one
        public void generateCode(DateTime userDate, DateTime defaultDate, string dateType)
        {
            //Establish difference
            var difference = (userDate - defaultDate).TotalSeconds;

            //Get char type
            char t = getTypeChar(dateType);

            //The end product
            string copyPasteCode = $"<t:{difference}:{t}>";

            //The preview of the end product
            string preview = getReference(userDate, t);

            //Open FinalCode
            FinalCode fn = new FinalCode(copyPasteCode, preview);
            fn.Show();
        }
        //--------------------------------------------------



        //--------------------------------------------------
        //EXTRA METHODS
        //Return extraDays
        public double returnExtraDays()
        {
            return cTime.extraDays;
        }


        //Add an extra 0 to the string when necessary
        public string extraZero(string s)
        {
            if (s.Length < 2) { s = "0" + s; }
            return s;
        }


        public Boolean isUndefined(string s)
        {
            bool answer = false;
            if (s == "UNDEFINED" || s == "") { answer = true; }
            return answer;
        }


        public int aboveZero(int a)
        {
            if (a < 1) { a = 1; }
            return a;
        }


        public bool isLeapYear(int a)
        {
            bool answer = false;
            if (a % 4 == 0)
            {
                answer = true;
            }
            return answer;
        }


        public string fourDigitYear(string a)
        {
            while (a.Length < 4)
            {
                a = "0" + a;
            }
            return a;
        }


        public int monthCorrected(int a)
        {
            if (a > 12) { a = 12; }
            return aboveZero(a);
        }


        public int dayCorrected(int day, int month, int year)
        {
            //Depending on the month
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    if (day > 31) { day = 31; }
                    break;

                case 4:
                case 6:
                case 9:
                case 11:
                    if (day > 30) { day = 30; }
                    break;

                case 2:
                    if (day > 28)
                    {
                        if (isLeapYear(year) == true)
                        {
                            day = 29;
                        }
                        else
                        {
                            day = 28;
                        }
                    }
                    break;
            }
            return aboveZero(day);
        }
        //--------------------------------------------------
    }
}