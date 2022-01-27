using MediatR;
using MinhaSeries.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaSeries.Application.Queries.GetSeriesByIdQuery
{
    public class GetSerieByIdQuery : IRequest<SerieDetailsViewModel>
    {
        public GetSerieByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
