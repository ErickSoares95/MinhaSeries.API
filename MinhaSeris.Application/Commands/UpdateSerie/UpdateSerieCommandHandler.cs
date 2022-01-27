using MediatR;
using MinhaSeries.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MinhaSeries.Application.Commands.UpdateSerie
{
    class UpdateSerieCommandHandler : IRequestHandler<UpdateSerieCommand, Unit>
    {
        private readonly ISerieRepository _serieRepository;

        public UpdateSerieCommandHandler(ISerieRepository serieRepository)
        {
            _serieRepository = serieRepository;
        }

        public async Task<Unit> Handle(UpdateSerieCommand request, CancellationToken cancellationToken)
        {
            var serie = await _serieRepository.GetByIdAsync(request.Id);

            serie.Update(request.Title, request.Description, request.Year, request.Genre);

            await _serieRepository.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
