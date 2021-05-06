
using System.Collections.Generic;
using App.Dtos;
using MediatR;

namespace App.Queries
{
    public class GetAllPlacesQuery: IRequest<IList<PlaceDto>>
    {
    }
}
