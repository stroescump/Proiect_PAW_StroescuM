﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW_StroescuM
{
    class Credite : IComparable, ICredit
    {
        private DateTime dataCredit;
        private double sumaAprobata;
        private int perioadaCredit; // Exprimata in luni
        public const double DOBANDA = 12;

        public Credite(DateTime dataCredit, double sumaAprobata, int perioadaCredit)
        {
            this.dataCredit = dataCredit;
            this.sumaAprobata = sumaAprobata;
            this.perioadaCredit = perioadaCredit;
        }

        public Credite()
        {
            this.dataCredit = new DateTime();
            this.sumaAprobata = -1;
            this.perioadaCredit = -1;
        }
        public double CuantumCredit
        {
            get { return this.sumaAprobata; }
        }

        public int PerioadaCredit
        {
            get { return this.perioadaCredit; }
        }

        public DateTime GetDateTime
        {
            get
            {
                return this.dataCredit;
            }
        }

        public double CalculeazaDobanda()
        {
            return this.CuantumCredit * (DOBANDA / 100);
        }


        public double CalculeazaCredit()
        {
            return this.CuantumCredit * (DOBANDA / 100) + this.CuantumCredit;
        }

        public int CompareTo(object obj)
        {
            Credite c = (Credite)obj;
            if (this.sumaAprobata > c.sumaAprobata) return 1;
            else if (this.sumaAprobata < c.sumaAprobata) return -1;
            else return DateTime.Compare(this.dataCredit, c.dataCredit);
        }
    }
}
