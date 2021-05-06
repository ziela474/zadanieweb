using System;
using System.Collections.Generic;
using App.Dtos;
using MediatR;

namespace App.Queries
{
    public class GetReportExportsQuery : IRequest<IList<ReportDto>>
    {
        public GetReportExportsQuery(DateTime endDate, DateTime startDate, int placeId)
        {
            PlaceId = placeId;
            EndDate = endDate;
            StartDate = startDate;
        }

        public int PlaceId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
