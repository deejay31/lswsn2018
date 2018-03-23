using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Category
{
    public class CategoryDTO
    {
        public int id { get; set; }
        public string classes { get; set; }
        public string description { get; set; }
        public DateTime dateEntry { get; set; }
        public int isActive { get; set; }
    }
}
