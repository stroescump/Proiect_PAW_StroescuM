using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW_StroescuM.Exceptions
{
    class ExceptieCreareInstanteMultipleSingleton : Exception
    {
        public ExceptieCreareInstanteMultipleSingleton(string message) : base(message)
        {
        }

    }
}
