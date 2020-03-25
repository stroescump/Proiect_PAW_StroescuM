using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW_StroescuM
{
    public class CreditStudiu : Credite, ICredit
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

        public string TransformCreditToCsv()
        {
            return "dataCredit," + this.GetDateTime.ToShortDateString() + ",sumaAprobata," + this.CuantumCredit + ",perioadaCredit," +
                this.PerioadaCredit + ",DOBANDA," + DOBANDA + ",perioadaDeGratie," + perioadaDeGratie;
        }

        public override string ToString()
        {
            return "Creditul a fost accesat la " + this.GetDateTime.ToShortDateString() + " cu o suma aprobata de " + this.CuantumCredit + " RON" +
                " pe o perioada de " + this.PerioadaCredit + " luni" + "\ncu o dobanda de " + DOBANDA + "% " +
                " iar suma totala de rambursat este " + CalculeazaCredit() + " RON" + Environment.NewLine + "Perioada de gratie: " + perioadaDeGratie;
        }

    }
}
