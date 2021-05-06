using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Entity;

namespace Domain.Interfaces
{
    public interface IExportRepository
    {
        Task<IList<ExportHistoryEntry>> GetExportReport(int placeId, DateTime startDate, DateTime endDate);
        Task<IList<Place>> GetAllPlaces();
    }
}
