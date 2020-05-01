using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW_StroescuM.Exceptions
{
    class NullPointerExceptionCustom : Exception
    {
        public NullPointerExceptionCustom(string message) : base(message) { }
    }
}
