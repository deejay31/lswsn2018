using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Base
{
    public class UsertypeDTO
    {
        public int id { get; set; }
        public string userType { get; set; }
        public DateTime date_entry { get; set; }
        public bool isActive { get; set; }
    }
}
