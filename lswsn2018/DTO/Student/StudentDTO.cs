using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Student
{
    public class StudentDTO
    {
        public int id { get; set; }
        public string studentId { get; set; }
        public string name { get; set; }
        public string levelSection { get; set; }
        public string gender { get; set; }
        public string contactNo { get; set; }
        public string address { get; set; }
        public DateTime dateEntry { get; set; }
        public int isActive { get; set; }
    }
}
