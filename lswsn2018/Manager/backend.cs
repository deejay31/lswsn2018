using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager
{
    public class backend
    {
        static string username;
        public static string Username
        {
            get { return username; }
            set { username = value; }
        }

        static string password;
        public static string Password
        {
            get { return password; }
            set { password = value; }
        }

        static int useraccountid;
        public static int UserAccountId
        {
            get { return useraccountid; }
            set { useraccountid = value; }
        }

        static int usertypeId;
        public static int UsertypeId
        {
            get { return usertypeId; }
            set { usertypeId = value; }
        }

        static string fullname;
        public static string FullName
        {
            get { return fullname; }
            set { fullname = value; }
        }

        static bool isReset = false;
        public static bool isreset
        {
            get { return isReset; }
            set { isReset = value; }
        }

        static int selectedId = 0;
        public static int SelectedId
        {
            get { return selectedId; }
            set { selectedId = value; }
        }

        static bool updateAppointment = false;
        public static bool UpdateAppointment
        {
            get { return updateAppointment; }
            set { updateAppointment = value; }
        }

        static bool isCancel = false;
        public static bool IsCancel
        {
            get { return isCancel; }
            set { isCancel = value; }
        }

        static string selectedTooth = "";
        public static string SelectedTooth
        {
            get { return selectedTooth; }
            set { selectedTooth = value; }
        }
    }
}
