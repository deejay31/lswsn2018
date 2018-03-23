using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Menu
{
    public class SmsNotificationDTO
    {
        public int id { get; set; }
        public string barcode { get; set; }
        public string name { get; set; }
        public string doctor { get; set; }
        public string message { get; set; }
        public string status { get; set; }
        public DateTime date_entry { get; set; }
        public int isActive { get; set; }
    }
}
