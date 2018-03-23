using DTO.Base;
using DTO.Login;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Login
{
    public class dbaLogin
    {
        public LoginDTO userLogin(string username, string password)
        {
            LoginDTO _logindto = new LoginDTO();
            SqlDbConnect con = new SqlDbConnect();

            try
            {
                string query = "SELECT * FROM users WHERE userName = @username AND userPass = @password AND isActive = 1";
                con.SqlQuery(query);
                con.Cmd.Parameters.AddWithValue("@username", username);
                con.Cmd.Parameters.AddWithValue("@password", password);
                DataTable dt = con.QueryEx();
                con.NonQueryEx();
                if (dt.Rows.Count > 0)
                {
                    _logindto.id = Convert.ToInt32(dt.Rows[0]["id"]);
                    _logindto.userName = dt.Rows[0]["userName"].ToString();
                    _logindto.userPass = dt.Rows[0]["userPass"].ToString();
                    _logindto.userTypeId = Convert.ToInt32(dt.Rows[0]["userTypeId"]);
                    _logindto.date_entry = Convert.ToDateTime(dt.Rows[0]["date_entry"]);
                    _logindto.isActive = Convert.ToInt32(dt.Rows[0]["isActive"]);
                    //_logindto.fullName = dt.Rows[0]["name"].ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }           

            return _logindto;
        }

        public SystemsDTO getSystem()
        {
            SqlDbConnect con = new SqlDbConnect();
            SystemsDTO data = new SystemsDTO();
            string query = "SELECT * FROM systems WHERE isActive = 1 LIMIT 1;";
            con.SqlQuery(query);
            con.NonQueryEx();
            if(con.QueryEx().Rows.Count > 0)
            {
                data.id = Convert.ToInt32(con.QueryEx().Rows[0]["id"]);
                data.title = con.QueryEx().Rows[0]["title"].ToString();
                data.subtitle = con.QueryEx().Rows[0]["subtitle"].ToString();
                data.code = con.QueryEx().Rows[0]["code"].ToString();
                data.version = con.QueryEx().Rows[0]["version"].ToString();
                data.year = con.QueryEx().Rows[0]["year"].ToString();
                data.isActive = Convert.ToInt32(con.QueryEx().Rows[0]["isActive"]);
            }
            return data;
        }
    }
}
