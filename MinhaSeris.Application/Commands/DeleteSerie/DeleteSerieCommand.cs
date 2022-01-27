using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaSeries.Application.Commands.DeleteSerie
{
    public class DeleteSerieCommand : IRequest<Unit>
    {
        public int Id { get; set; }

        public DeleteSerieCommand(int id)
        {
            Id = id;
        }
    }
}
