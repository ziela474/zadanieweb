using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entity;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories
{
    public class ExportRepository : IExportRepository
    {
        private readonly ReportAppDbContext _dbContext;

        public ExportRepository(ReportAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IList<ExportHistoryEntry>> GetExportReport(int placeId, DateTime startDate, DateTime endDate)
        {
            return await _dbContext
                .HistoryEntries
                .Include(h => h.Place)
                .Where(h => h.PlaceId == placeId
                            && startDate <= h.ExportDateTime
                            && endDate >= h.ExportDateTime
                            )
                .AsNoTracking().ToListAsync();
        }

        public async Task<IList<Place>> GetAllPlaces()
        {
            return await _dbContext.Places.AsNoTracking().ToListAsync();
        }
    }
}
