using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Menu
{
    public class PatientSmsDTO
    {
        public int id { get; set; }
        public string barcode { get; set; }
        public string name { get; set; }
        public string doctor { get; set; }
        public DateTime date_appointment { get; set; }
        public string number { get; set; }
    }
}
