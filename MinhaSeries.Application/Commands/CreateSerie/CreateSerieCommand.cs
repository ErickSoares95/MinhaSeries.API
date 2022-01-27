using MediatR;
using MinhaSeries.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaSeries.Application.Commands.CreateSerie
{
    public class CreateSerieCommand : IRequest<int>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Year { get; set; }
        public Genre Genre { get; set; }
        public bool Active { get; set; }
    }
}
