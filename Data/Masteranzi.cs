using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW_StroescuM
{
    class Masteranzi : Clienti
    {
        private string numarMatricol;
        private string numeInstitutie;

        public Masteranzi(string numeClient,
            DateTime dataNasterii,
            long cnp, CreditStudiu credit,
            string numarMatricol,
            string numeInstitutie) : base(numeClient, dataNasterii, cnp, credit)
        {
            this.numarMatricol = numarMatricol;
            this.numeInstitutie = numeInstitutie;
        }

        public double afiseazaDetaliiCredit()
        {
            return this.CreditDetails.CalculeazaCredit();
        }

        public override string ToString()
        {
            double suma = this.CreditDetails.CalculeazaCredit();
            return base.ToString() + " fiind student inregistrat la " + numeInstitutie
                + " cu numarul matricol : "
                + numarMatricol + " si are de rambursat in total " + suma + " lei";
        }

    }
}
