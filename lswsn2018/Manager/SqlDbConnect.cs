using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager
{
    public class SqlDbConnect
    {
        private MySqlConnection _con;
        public MySqlCommand Cmd;
        private MySqlDataAdapter _da;
        private DataTable _dt;
        private DataSet _ds;

        public static string connString = ConfigurationManager.ConnectionStrings["LSWSN2018"].ConnectionString;

        public SqlDbConnect()
        {
            _con = new MySqlConnection(connString);
            _con.Open();
        }

        public void SqlQuery(string queryText)
        {
            Cmd = new MySqlCommand(queryText, _con);
        }

        public DataTable QueryEx()
        {
            _da = new MySqlDataAdapter(Cmd);
            _dt = new DataTable();
            _da.Fill(_dt);
            return _dt;
        }

        public DataSet QueryExReport()
        {
            _da = new MySqlDataAdapter(Cmd);
            _ds = new DataSet();
            _da.Fill(_ds);
            return _ds;
        }

        public void NonQueryEx()
        {
            Cmd.ExecuteNonQuery();
        }
    }
}
