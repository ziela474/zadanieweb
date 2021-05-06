using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entity
{
    [Table("ExportHistory")]
    public class ExportHistoryEntry
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        public DateTime ExportDateTime { get; set; }
        [MaxLength(50)]
        public string User { get; set; }
       
        public Place Place { get; set; }
        public int PlaceId { get; set; }
    }
}
