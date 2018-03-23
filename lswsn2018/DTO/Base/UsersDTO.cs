using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Base
{
    public class UsersDTO
    {
        public int id { get; set; }
        public string userName { get; set; }
        public string userPass { get; set; }
        public int userTypeId { get; set; }
        public int clientId { get; set; }
        public DateTime date_entry { get; set; }
        public int isActive { get; set; }
    }
}
