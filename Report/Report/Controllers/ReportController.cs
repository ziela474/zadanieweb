using System;
using System.Collections.Generic;
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
        public async Task<ActionResult<IList<ReportDto>>> GetExportHistory([FromQuery]int placeId, DateTime startDate, DateTime endDate)
        {
            var query = new GetReportExportsQuery(endDate, startDate, placeId);

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
