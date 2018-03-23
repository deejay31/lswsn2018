using DTO.Account;
using DTO.Base;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Account
{
    public class dbaAccount
    {
        SqlDbConnect con = new SqlDbConnect();
        public static DataTable userList()
        {
            SqlDbConnect con = new SqlDbConnect();
            DataTable dt = new DataTable();
            string query = @"SELECT users.*, usertype.userType FROM users 
                            LEFT JOIN usertype
                            ON users.userTypeId = usertype.id
                            WHERE users.isActive = 1;";
            con.SqlQuery(query);
            con.NonQueryEx();

            if (con.QueryEx().Rows.Count > 0)
                dt = con.QueryEx();
            return dt;
        }

        public static List<AccountDTO> selectAll()
        {
            SqlDbConnect con = new SqlDbConnect();
            List<AccountDTO> users = new List<AccountDTO>();
            AccountDTO user = new AccountDTO();
            string query = @"SELECT users.*, usertype.description FROM users 
                            LEFT JOIN usertype
                            ON users.userTypeId = usertype.id
                            WHERE users.isActive = 1;";

            con.SqlQuery(query);
            con.NonQueryEx();
            foreach(DataRow row in con.QueryEx().Rows)
            {
                user = new AccountDTO();
                user.id = Convert.ToInt32(row["id"]);
                user.userName = row["userName"].ToString();
                user.userPass = row["userPass"].ToString();
                user.userTypeId = Convert.ToInt32(row["userTypeId"]);
                user.clientId = Convert.ToInt32(row["clientId"]);
                user.date_entry = Convert.ToDateTime(row["dateEntry"]);
                user.isActive = Convert.ToInt32(row["isActive"]);
                user.userType = row["description"].ToString();

                users.Add(user);
            }
            return users;
        }

        public bool insertUser(UsersDTO user)
        {
            bool result = false;

            try
            {
                string query = @"Insert into users(userName, userPass, userTypeId) values (@username, @userpass, @usertypeid)";
                con.SqlQuery(query);
                con.Cmd.Parameters.AddWithValue("@username", user.userName);
                con.Cmd.Parameters.AddWithValue("@userpass", user.userPass);
                con.Cmd.Parameters.AddWithValue("@usertypeid", 2);
                //con.Cmd.Parameters.AddWithValue("@name", user.name);
                con.NonQueryEx();
                result = true;
            }
            catch (Exception ex)
            {
                result = false;
            }
            return result;
        }

        //public static bool updatetUser(UsersDTO user)
        //{
        //    SqlDbConnect con = new SqlDbConnect();
        //    bool result = false;

        //    try
        //    {
        //        string query = @"Update users set userName = @username, userTypeId = @usertypeid, Name = @name where id = " + user.id;
        //        con.SqlQuery(query);
        //        con.Cmd.Parameters.AddWithValue("@username", user.userName);
        //        con.Cmd.Parameters.AddWithValue("@usertypeid", user.userTypeId);
        //        con.Cmd.Parameters.AddWithValue("@name", user.name);
        //        con.NonQueryEx();
        //        result = true;
        //    }
        //    catch (Exception ex)
        //    {
        //        result = false;
        //    }
        //    return result;
        //}

        public static bool deleteUser(int id)
        {
            SqlDbConnect con = new SqlDbConnect();
            bool result = false;

            try
            {
                string query = @"Update users set isActive = @isactive where id = " + id;
                con.SqlQuery(query);
                con.Cmd.Parameters.AddWithValue("@isactive", 0);
                con.NonQueryEx();
                result = true;
            }
            catch (Exception ex)
            {
                result = false;
            }
            return result;
        }

        //public static DataTable getUserType()
        //{
        //    SqlDbConnect con = new SqlDbConnect();
        //    DataTable dt = new DataTable();

        //    string query = "SELECT * FROM usertype WHERE isActive = 1;";
        //    con.SqlQuery(query);
        //    con.NonQueryEx();
        //    if (con.QueryEx().Rows.Count > 0)
        //        dt = con.QueryEx();

        //    return dt;
        //}

        //public static int isExist(string data)
        //{
        //    SqlDbConnect con = new SqlDbConnect();
        //    int count = 0;

        //    string query = "SELECT COUNT(userName) FROM users WHERE isActive = 1 AND userName = '" + data + "';";
        //    con.SqlQuery(query);
        //    con.NonQueryEx();

        //    if (con.QueryEx().Rows.Count > 0)
        //        count = Convert.ToInt32(con.QueryEx().Rows[0][0]);

        //    return count;
        //}
    }
}
