using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using App.Dtos;
using App.Queries;
using Domain.Interfaces;
using MediatR;

namespace App.Handlers
{
    public class GetAllPlacesHandler : IRequestHandler<GetAllPlacesQuery, IList<PlaceDto>>
    {
        private readonly IExportRepository _exportRepository;

        public GetAllPlacesHandler(IExportRepository exportRepository)
        {
            _exportRepository = exportRepository;
        }

        public async Task<IList<PlaceDto>> Handle(GetAllPlacesQuery request, CancellationToken cancellationToken)
        {
            return (await _exportRepository.GetAllPlaces()).Select(s => new PlaceDto()
            {
                Id = s.Id,
                Name = s.Name
            }).ToList();
        }
    }
}
