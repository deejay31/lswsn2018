using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Settings
{
    public class dbaSettings
    {
        public static bool updatePassword(string data)
        {
            SqlDbConnect con = new SqlDbConnect();
            bool result = false;

            try
            {
                string query = @"Update users set userPass = @password where id = " + backend.UserAccountId;
                con.SqlQuery(query);
                con.Cmd.Parameters.AddWithValue("@password", data);
                con.NonQueryEx();
                result = true;
            }
            catch (Exception ex)
            {
                result = false;
            }
            return result;
        }
    }
}
