using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class CAP2
    {
        // Variable deleceration.
        private static string studentname;
        private static int courseno;
        private static DateTime dateTime;
        private static string type2;
        private static string t2;
        // used to return the value of student name.
        public static string getsn()
        {
            return studentname;
        }
        // used to store the student name in variable.
        public static void setsn(String stdname)
        {
            string nme;
            nme = studentname;
            studentname = stdname;
            if (nme != studentname)
            {
                System.Windows.Forms.MessageBox.Show("The values has been changed to" + studentname);
            }
            getsn();
        }
        // used to return the value of number or course.
        public static int getcours()
        {
            return courseno;

        }
        // used to store number or courses in variable.
        public static void setscours(int course)
        {
            int a;
            a = courseno;
            courseno = course;
            if (a != courseno)
            {
                System.Windows.Forms.MessageBox.Show("The values has been changed to" + courseno);
            }
            getcrsno();
        }
        // used to return value od start date.
        public static DateTime getstartdate()
        {
            return dateTime;

        }
        // used to store the start date in variable.
        public static void setstartdate(DateTime dtTime)
        {
            DateTime t1;
            t1 = dateTime;
            dateTime = dtTime;
            if (t1 != dateTime)
            {
                System.Windows.Forms.MessageBox.Show("The Value has been changed to" + dateTime);
            }
            getstartdate();
        }
        // used to return the type of course
        public static string gettype()
        {
            return type2;

        }
        // use to store the course type in variable
        public static void settype(string Type)
        {
            string type;
            type = type2;
            type2 = Type;
            if (type != type2)
            {
                System.Windows.Forms.MessageBox.Show("The calue has been changed to" + type2);
            }
            gettype();
        }
        // used to return the course number
        public static string getcrsno()
        {
            return t2;

        }
        // used to store the value of course number in variable.
        public static void setcours(string T1)
        {
            string t;
            t = t2;
            t2 = T1;
            if (t != t2)
            {
                System.Windows.Forms.MessageBox.Show("The value has been changed to" + t2);
            }
            getcrsno();
        }
    }
}
