using MediatR;
using MinhaSeries.Application.ViewModels;
using MinhaSeries.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MinhaSeries.Application.Queries.GetSeriesByIdQuery
{
    public class GetSerieByIdQueryHandler : IRequestHandler<GetSerieByIdQuery, SerieDetailsViewModel>
    {
        private readonly ISerieRepository _serieRepository;

        public GetSerieByIdQueryHandler(ISerieRepository serieRepository)
        {
            _serieRepository = serieRepository;
        }

        public async Task<SerieDetailsViewModel> Handle(GetSerieByIdQuery request, CancellationToken cancellationToken)
        {
            var serie = await _serieRepository.GetByIdAsync(request.Id);

            if (serie == null) return null;

            var serieDetailsViewModel = new SerieDetailsViewModel(serie.Id, serie.Title, serie.Description, serie.Year, serie.Genre, serie.AddedAt);

            return serieDetailsViewModel;
        }
    }
}
