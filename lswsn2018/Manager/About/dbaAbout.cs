using DTO.About;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.About
{
    public class dbaAbout
    {
        SqlDbConnect con = new SqlDbConnect();
        public List<AboutDTO> getAbout()
        {
            List<AboutDTO> datas = new List<AboutDTO>();
            AboutDTO data = new AboutDTO();

            string query = "SELECT * FROM `developer` WHERE `isActive` = 1";
            con.SqlQuery(query);
            con.NonQueryEx();
            foreach(DataRow row in con.QueryEx().Rows)
            {
                data = new AboutDTO();
                data.id = Convert.ToInt32(row["id"]);
                data.name = row["name"].ToString();
                data.isActive = Convert.ToInt32(row["isActive"]);

                datas.Add(data);
            }
            return datas;
        }
    }
}
