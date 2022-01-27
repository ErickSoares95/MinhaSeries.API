using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaSeries.Core.Entities
{
    public class SerieComment : BaseEntity
    {
        public SerieComment(string content, int idSerie)
        {
            Content = content;
            IdSerie = idSerie;

            CreatedAt = DateTime.Now;
        }

        public string Content { get; private set; }
        public int IdSerie { get; private set; }
        public Serie Serie { get; private set; }
        public DateTime CreatedAt { get; private set; }
    }
}
