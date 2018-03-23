using DTO.Logs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Logs
{
    public class dbaLogs
    {
        public void insertLogs(int id, string operation)
        {
            SqlDbConnect con = new SqlDbConnect();
            string query = @"Insert into logs(userId, operation) values (@userid, @operation)";
            con.SqlQuery(query);
            con.Cmd.Parameters.AddWithValue("@userid", id);
            con.Cmd.Parameters.AddWithValue("@operation", operation);                 
            con.NonQueryEx();
        }

        public static List<LogsDTO> selectLogs()
        {
            SqlDbConnect con = new SqlDbConnect();
            LogsDTO data = new LogsDTO();
            List<LogsDTO> datas = new List<LogsDTO>();

            //string query = @"SELECT * FROM `logs`
            //                WHERE isActive = 1";
            string query = @"SELECT users.userName, usertype.userType, logs.operation, logs.date_entry FROM `logs`
                            LEFT JOIN users
                            ON logs.userId = users.id
                            LEFT JOIN usertype
                            ON users.userTypeId = usertype.id ORDER BY logs.id DESC;";
            con.SqlQuery(query);
            con.NonQueryEx();

            foreach (DataRow row in con.QueryEx().Rows)
            {
                data = new LogsDTO();
                //data.id = Convert.ToInt32(row["id"]);
                data.userName = row[0].ToString();
                data.userType = row[1].ToString();
                data.operation = row[2].ToString();
                data.date_entry = Convert.ToDateTime(row[3]);
                datas.Add(data);
            }
            return datas;
        }
    }
}
