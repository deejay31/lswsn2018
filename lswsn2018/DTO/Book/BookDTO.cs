using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Book
{
    public class BookDTO
    {
        public int id { get; set; }
        public int accessionNo { get; set; }
        public int isbn { get; set; }
        public string category { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public string edition { get; set; }
        public string status { get; set; }
        public DateTime dateEntry { get; set; }
        public int isActive { get; set; }
    }
}
