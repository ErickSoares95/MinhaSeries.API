using MediatR;
using MinhaSeries.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaSeries.Application.Queries.GetAllSeriesQuery
{
    public class GetAllSeriesQuery : IRequest<List<SerieViewModel>>
    {
    }
}
