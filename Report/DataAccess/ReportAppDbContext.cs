using System;
using Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class ReportAppDbContext : DbContext
    {
        public ReportAppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<ExportHistoryEntry> HistoryEntries { get; set; }
        public DbSet<Place> Places { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Place>().HasData(
                new Place { Name = "Place1", Id = 1, },
                new Place { Name = "Place2", Id = 2 },
                new Place { Name = "Place3", Id = 3 },
                new Place { Name = "Place4", Id = 4 },
                new Place { Name = "Place5", Id = 5 },
                new Place { Name = "Place6", Id = 6 }
                );
            modelBuilder.Entity<ExportHistoryEntry>().HasData(
                new ExportHistoryEntry { ExportDateTime = DateTime.Now.Subtract(TimeSpan.FromDays(1)), Name = "Test1", PlaceId = 1, User = "User1", Id = 1 },
                new ExportHistoryEntry { ExportDateTime = DateTime.Now.Subtract(TimeSpan.FromDays(2)), Name = "Test2", PlaceId = 2, User = "User1", Id = 2 },
                new ExportHistoryEntry { ExportDateTime = DateTime.Now.Subtract(TimeSpan.FromDays(3)), Name = "Test3", PlaceId = 3, User = "User1", Id = 3 },
                new ExportHistoryEntry { ExportDateTime = DateTime.Now.Subtract(TimeSpan.FromDays(4)), Name = "Test4", PlaceId = 4, User = "User1", Id = 4 },
                new ExportHistoryEntry { ExportDateTime = DateTime.Now.Subtract(TimeSpan.FromDays(5)), Name = "Test5", PlaceId = 4, User = "User2", Id = 5 },
                new ExportHistoryEntry { ExportDateTime = DateTime.Now.Subtract(TimeSpan.FromDays(5)), Name = "Test6", PlaceId = 5, User = "User2", Id = 6 },
                new ExportHistoryEntry { ExportDateTime = DateTime.Now.Add(TimeSpan.FromDays(5)), Name = "Test7", PlaceId = 1, User = "User2", Id = 7 },
                new ExportHistoryEntry { ExportDateTime = DateTime.Now.Add(TimeSpan.FromDays(1)), Name = "Test8", PlaceId = 1, User = "User2", Id = 8 },
                new ExportHistoryEntry { ExportDateTime = DateTime.Now.Add(TimeSpan.FromDays(2)), Name = "Test9", PlaceId = 1, User = "User2", Id = 9 },
                new ExportHistoryEntry { ExportDateTime = DateTime.Now.Add(TimeSpan.FromDays(3)), Name = "Test10", PlaceId = 2, User = "User3", Id = 10 },
                new ExportHistoryEntry { ExportDateTime = DateTime.Now.Add(TimeSpan.FromDays(4)), Name = "Test11", PlaceId = 2, User = "User3", Id = 11 },
                new ExportHistoryEntry { ExportDateTime = DateTime.Now.Add(TimeSpan.FromDays(5)), Name = "Test12", PlaceId = 2, User = "User3", Id = 12 },
                new ExportHistoryEntry { ExportDateTime = DateTime.Now.Add(TimeSpan.FromDays(5)), Name = "Test13", PlaceId = 2, User = "User3", Id = 13 },
                new ExportHistoryEntry { ExportDateTime = DateTime.Now.Add(TimeSpan.FromDays(5)), Name = "Test14", PlaceId = 3, User = "User4", Id = 14 },
                new ExportHistoryEntry { ExportDateTime = DateTime.Now.Add(TimeSpan.FromDays(5)), Name = "Test15", PlaceId = 3, User = "User4", Id = 15 },
                new ExportHistoryEntry { ExportDateTime = DateTime.Now.Subtract(TimeSpan.FromDays(5)), Name = "Test16", PlaceId = 3, User = "User4", Id = 16 },
                new ExportHistoryEntry { ExportDateTime = DateTime.Now.Subtract(TimeSpan.FromDays(5)), Name = "Test17", PlaceId = 3, User = "User5", Id = 17 },
                new ExportHistoryEntry { ExportDateTime = DateTime.Now.Subtract(TimeSpan.FromDays(5)), Name = "Test17", PlaceId = 3, User = "User6", Id = 18 }
                );
        }
    }
}
