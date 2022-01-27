using MediatR;
using MinhaSeries.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MinhaSeries.Application.Commands.DeleteSerie
{
    public class DeleteSerieCommandHandler : IRequestHandler<DeleteSerieCommand, Unit>
    {
        private readonly ISerieRepository _serieRepository;

        public DeleteSerieCommandHandler(ISerieRepository serieRepository)
        {
            _serieRepository = serieRepository;
        }

        public async Task<Unit> Handle(DeleteSerieCommand request, CancellationToken cancellationToken)
        {
            var serie = await _serieRepository.GetByIdAsync(request.Id);

            serie.Delete();

            await _serieRepository.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
