using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Dtos
{
     public class ReportDto
    {
        public string Name { get; set; }
        public DateTime DateTime { get; set; }
        public string User { get; set; }
        public string Place { get; set; }
    }
}
