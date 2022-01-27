using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaSeries.Application.Commands.CreateComment
{
    public class CreateCommentCommand : IRequest<Unit>
    {
        public string Content { get; set; }
        public int IdSerie { get; set; }
    }
}
