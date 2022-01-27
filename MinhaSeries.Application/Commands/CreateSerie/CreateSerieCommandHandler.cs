using MediatR;
using MinhaSeries.Core.Entities;
using MinhaSeries.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MinhaSeries.Application.Commands.CreateSerie
{
    public class CreateSerieCommandHandler : IRequestHandler<CreateSerieCommand, int>
    {
        private readonly ISerieRepository _serieRepository;

        public CreateSerieCommandHandler(ISerieRepository serieRepository)
        {
            _serieRepository = serieRepository;
        }

        public async Task<int> Handle(CreateSerieCommand request, CancellationToken cancellationToken)
        {
            var serie = new Serie(request.Title, request.Description, request.Year, request.Genre, request.Active);
            await _serieRepository.AddAsync(serie);

            return serie.Id;
        }
    }
}
