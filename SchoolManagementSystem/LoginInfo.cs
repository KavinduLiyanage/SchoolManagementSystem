using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem
{
    public static class LoginInfo
    {
        private static string username;
        private static string proPic;
        private static int usrId;
        private static string sysLvl;

        public static string userName
        {
            get { return username; }
            set { username = value; }
        }
        public static string getsetproPic
        {
            get { return proPic; }
            set { proPic = value; }
        }
        public static int getsetusrId
        {
            get { return usrId; }
            set { usrId = value; }
        }
        public static string getsetsysLvl
        {
            get { return sysLvl; }
            set { sysLvl = value; }
        }

    }
}
