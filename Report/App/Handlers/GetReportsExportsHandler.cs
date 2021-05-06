using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using App.Dtos;
using App.Queries;
using Domain.Interfaces;
using MediatR;

namespace App.Handlers
{
    public class GetReportsExportsHandler : IRequestHandler<GetReportExportsQuery, IList<ReportDto>>
    {
        private readonly IExportRepository _exportRepository;

        public GetReportsExportsHandler(IExportRepository exportRepository)
        {
            _exportRepository = exportRepository;
        }

        public async Task<IList<ReportDto>> Handle(GetReportExportsQuery request, CancellationToken cancellationToken)
        {
            return (await _exportRepository.GetExportReport(request.PlaceId, request.StartDate, request.EndDate))
                .Select(x => new ReportDto()
                {
                    DateTime = x.ExportDateTime,
                    Name = x.Name,
                    Place = x.Place.Name,
                    User = x.User
                }).ToList();
        }
    }
}
