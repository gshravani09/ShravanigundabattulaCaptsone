using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public static class CAP1
    {
        // declaration of variables.
        private static string txtstdname1;
        private static int nocourse;
        private static DateTime datTime;
        private static string type;
        private static string t;


        // used to pass the value to class 2.
        public static void getsn()
        {
            CAP2.setsn(txtstdname1);

        }
        // used to get the value from the variables in main form.
        public static void setsn(String sname)
        {
            txtstdname1 = sname;
            getsn();
        }
        // used to pass the value to class 2.
        public static void getnocours()
        {
            CAP2.setscours(nocourse);

        }
        // used to get the value from the variables in main form.
        public static void setscours(int course)
        {
            nocourse = course;
            getnocours();
        }
        // used to pass the value to class 2.
        public static void getdate()
        {
            CAP2.setstartdate(datTime);

        }
        // used to get the value from the variables in main form.
        public static void setstdate(DateTime dtTime)
        {
            datTime = dtTime;
            getdate();
        }
        // used to pass the value to class 2.
        public static void gettype()
        {
            CAP2.settype(type);

        }
        // used to get the value from the variables in main form.
        public static void settype(string Type)
        {
            type = Type;
            gettype();
        }
        // used to pass the value to class 2.
        public static void getcoursno()
        {
            CAP2.setcours(t);

        }
        // used to get the value from the variables in main form.
        public static void setcoursno(string T)
        {
            t = T;
            getcoursno();
        }
    }
}
