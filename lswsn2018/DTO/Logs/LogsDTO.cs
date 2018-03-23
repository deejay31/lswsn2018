using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Logs
{
    public class LogsDTO
    {
        //public int id { get; set; }
        //public int userId { get; set; }
        public string userName { get; set; }
        public string userType { get; set; }
        public string operation { get; set; }
        public DateTime date_entry { get; set; }
        //public int isActive { get; set; }
    }
}
