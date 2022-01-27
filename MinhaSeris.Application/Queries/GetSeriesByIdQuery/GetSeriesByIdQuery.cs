using MediatR;
using MinhaSeries.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaSeries.Application.Queries.GetSeriesByIdQuery
{
    public class GetSeriesByIdQuery : IRequest<SerieDetailsViewModel>
    {
        public GetSeriesByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
