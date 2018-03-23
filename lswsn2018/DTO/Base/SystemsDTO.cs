using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Base
{
    public class SystemsDTO
    {
        public int id { get; set; }
        public string title { get; set; }
        public string subtitle { get; set; }
        public string code { get; set; }
        public string version { get; set; }
        public string year { get; set; }
        public int isActive { get; set; }
    }
}
