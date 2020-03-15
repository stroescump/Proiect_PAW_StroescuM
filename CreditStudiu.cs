using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW_StroescuM
{
    class CreditStudiu : Credite, ICredit
    {
        private int perioadaDeGratie;
        new public const double DOBANDA = 3;
        public CreditStudiu(DateTime dC, double s, int per, int perioadaDeGratie) : base(dC, s, per)
        {
            this.perioadaDeGratie = perioadaDeGratie;
        }

        public int PerioadaDeGratie
        {
            get { return this.perioadaDeGratie; }
        }

        public new double CalculeazaDobanda()
        {
            return this.CuantumCredit * (DOBANDA / 100);

        }

        public new double CalculeazaCredit()
        {
            return this.CuantumCredit * (DOBANDA / 100) + this.CuantumCredit;
        }
    }
}
