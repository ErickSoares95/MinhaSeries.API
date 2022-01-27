using MediatR;
using MinhaSeries.Application.ViewModels;
using MinhaSeries.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MinhaSeries.Application.Queries.GetAllSeriesQuery
{
    class GetAllSeriesQueryHandler : IRequestHandler<GetAllSeriesQuery, List<SerieViewModel>>
    {
        public readonly ISerieRepository _serieRepository;

        public GetAllSeriesQueryHandler(ISerieRepository serieRepository)
        {
            _serieRepository = serieRepository;
        }

        public async Task<List<SerieViewModel>> Handle(GetAllSeriesQuery request, CancellationToken cancellationToken)
        {
            var series = await _serieRepository.GetAllAsync();

            var seriesViewModel = series.Select(p => new SerieViewModel(p.Id, p.Title, p.Description, p.Year, p.Genre, p.AddedAt)).ToList();

            return seriesViewModel;
        }
    }
}
