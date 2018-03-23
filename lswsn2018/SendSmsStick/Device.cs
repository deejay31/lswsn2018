using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace SendSmsStick
{
    public class Device
    {
        static string description;
        public static string Description
        {
            get { return description; }
            set { description = value; }
        }

        static string port;
        public static string Port
        {
            get { return port; }
            set { port = value; }
        }

        public static SmsDTO DeviceConnected()
        {
            SmsDTO data = new SmsDTO();
            try
            {
                ManagementObjectCollection.ManagementObjectEnumerator Enu = null;
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_POTSModem");
                try
                {
                    Enu = searcher.Get().GetEnumerator();
                    while (Enu.MoveNext())
                    {
                        ManagementObject current = (ManagementObject)Enu.Current;
                        if (Operators.ConditionalCompareObjectEqual(current["Status"], "OK", false))
                        {
                            Description = (string)(current["Description"]);
                            Port = (string)(current["AttachedTo"]);
                        }
                    }
                }
                finally
                {
                    if (Enu != null)
                    {
                        Enu.Dispose();
                    }
                }
            }
            catch (ManagementException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return data;
        }

        #region previous code
        //static string description;
        //public static string Description
        //{
        //    get { return description; }
        //    set { description = value; }
        //}

        //static string port;
        //public static string Port
        //{
        //    get { return port; }
        //    set { port = value; }
        //}
        //public static string DeviceConnected()
        //{
        //    try
        //    {
        //        ManagementObjectCollection.ManagementObjectEnumerator Enu = null;
        //        ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_POTSModem");
        //        try
        //        {
        //            Enu = searcher.Get().GetEnumerator();
        //            while (Enu.MoveNext())
        //            {
        //                ManagementObject current = (ManagementObject)Enu.Current;
        //                if (Operators.ConditionalCompareObjectEqual(current["Status"], "OK", false))
        //                {
        //                    Description = (string)(current["Description"]);
        //                    Port = (string)(current["AttachedTo"]);
        //                }
        //            }
        //        }
        //        finally
        //        {
        //            if (Enu != null)
        //            {
        //                Enu.Dispose();
        //            }
        //        }
        //    }
        //    catch (ManagementException ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //    return "";
        //}
        #endregion
    }
}
