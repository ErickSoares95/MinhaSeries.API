using MediatR;
using MinhaSeries.Core.Entities;
using MinhaSeries.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MinhaSeries.Application.Commands.CreateComment
{
    public class CreateCommentCommandHandler : IRequestHandler<CreateCommentCommand, Unit>
    {
        private readonly ISerieRepository _serieRepository;

        public CreateCommentCommandHandler(ISerieRepository serieRepository)
        {
            _serieRepository = serieRepository;
        }

        public async Task<Unit> Handle(CreateCommentCommand request, CancellationToken cancellationToken)
        {
            var comment = new SerieComment(request.Content, request.IdSerie);

            await _serieRepository.AddCommentAsync(comment);

            return Unit.Value;
        }
    }
}
