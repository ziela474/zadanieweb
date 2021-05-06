using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Place
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<ExportHistoryEntry> ExportHistoryEntry { get; set; }

    }
}
