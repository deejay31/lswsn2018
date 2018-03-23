using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Return
{
    public class ReturnDTO
    {
        public int borrowId { get; set; }
        public string studentId { get; set; }
        public int bookId { get; set; }
        public DateTime borrowDate { get; set; }
        public DateTime returnDate { get; set; }
        public string accountName { get; set; }
        public string transaction { get; set; }
        public decimal penalty { get; set; }
        public DateTime dateEntry { get; set; }
        public int isActive { get; set; }
        public string name { get; set; }
        public int isbn { get; set; }
        public string title { get; set; }
    }
}
