using DTO.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.About
{
    public class AboutDTO
    {
        public int id { get; set; }
        public string name { get; set; }
        public int isActive { get; set; }
        public SystemsDTO sytemdto { get; set; }
    }
}
