using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaSeries.Core.Exceptions
{
    public class SerieAlreadyExists : Exception
    {
        public SerieAlreadyExists() : base("Serie With Same Name Already Exists")
        {

        }
    }
}
