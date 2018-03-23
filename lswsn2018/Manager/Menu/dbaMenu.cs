using DTO.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Menu
{
    public class dbaMenu
    {
        public static UsertypeDTO userType(int id)
        {
            UsertypeDTO _usertype = new UsertypeDTO();

            SqlDbConnect con = new SqlDbConnect();
            string query = @"SELECT usertype.* FROM users 
                            LEFT JOIN usertype
                            ON users.userTypeId = usertype.id
                            WHERE users.isActive = 1 AND users.id = " + id;
            con.SqlQuery(query);
            con.NonQueryEx();

            if (con.QueryEx().Rows.Count > 0)
            {
                _usertype.id = Convert.ToInt32(con.QueryEx().Rows[0]["id"].ToString());
                _usertype.userType =con.QueryEx().Rows[0]["description"].ToString();
                _usertype.date_entry = Convert.ToDateTime(con.QueryEx().Rows[0]["dateEntry"]);
                _usertype.isActive = Convert.ToBoolean(con.QueryEx().Rows[0]["isActive"]);
            }
               
            return _usertype;
        }       
    }
}
