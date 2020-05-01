using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW_StroescuM
{
    class Clienti : ICloneable, IComparable
    {
        private string nume;
        private DateTime dataNasterii;
        private long cnp;
        private Credite credit;

        public Clienti(string numeClient, DateTime dataNasterii, long cnp, Credite credit)
        {
            this.nume = numeClient;
            this.dataNasterii = dataNasterii;
            this.cnp = cnp;
            this.credit = credit;
        }
        public object Clone()
        {
            return (Clienti)this.MemberwiseClone();
        }

        public int CompareTo(object obj)
        {
            Clienti c = (Clienti)obj;
            return this.credit.CompareTo(c.credit);
        }

        public Credite CreditDetails
        {
            get
            {
                if (this.credit != null) return this.credit;
                else return new Credite();
            }
        }

        public string Nume
        {
            get
            {
                return this.nume;
            }
            set { if (value.Length != 0) this.nume = value; }
        }

        public override string ToString()
        {
            if (credit == null)
            {
                return "Clientul " + nume + " nu a contractat niciun credit, vizitati pagina de credite pentru oferta!";
            }
            else
                return "Clientul " + nume + " a contractat un credit in valoare de " + credit.CuantumCredit + " pe o perioada de " + credit.PerioadaCredit;
        }
    }
}
