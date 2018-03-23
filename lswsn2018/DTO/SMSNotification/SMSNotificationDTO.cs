using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.SMSNotification
{
    public class SMSNotificationDTO
    {
        public int id { get; set; }
        public string name { get; set; }
        public string ContactNo { get; set; }
        public DateTime returnDate { get; set; }
        //public DateTime DateEntry { get; set; }
        //public bool isActive { get; set; }
    }
}
