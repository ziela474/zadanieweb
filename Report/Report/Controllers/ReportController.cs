using System;
using System.Collections.Generic;
using System.Globalization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using App.Dtos;
using App.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace Report.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ReportController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<IList<ReportDto>>> GetExportHistory([FromQuery] int placeId, string startDate, string endDate)
        {
            var format = "yyyy-MM-dd";
            var query = new GetReportExportsQuery(DateTime.ParseExact(endDate, format, CultureInfo.CurrentCulture),
                DateTime.ParseExact(startDate, format, CultureInfo.CurrentCulture), 
                placeId);

            var result = await _mediator.Send(query);

            return Ok(result);
        }


        [HttpGet]
        public async Task<ActionResult<IList<PlaceDto>>> GetAllPlaces()
        {
            var query = new GetAllPlacesQuery();

            var result = await _mediator.Send(query);

            return Ok(result);
        }


    }
}
