using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Reports
{
    public class dbaReports
    {
        SqlDbConnect con = new SqlDbConnect();
        public DataSet selectReportBaptism()
        {
            string query = "SELECT * FROM baptism WHERE isActive = 1 AND BaptismDate > CURDATE();";
            con.SqlQuery(query);
            con.NonQueryEx();
            return con.QueryExReport();
        }
    }
}
