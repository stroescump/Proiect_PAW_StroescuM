using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_PAW_StroescuM
{
    public partial class PieChart : Form
    {
        private List<Credite> listaCrediteCurente;
        public PieChart(List<Credite> listaCrediteCurente, double cuantumTotalCredite)
        {
            this.listaCrediteCurente = listaCrediteCurente;
            InitializeComponent();
            chart1.Titles.Add("Distributia procentuala a cuantumului creditelor pe rol");

            for (int i = 0; i < listaCrediteCurente.Count; i++)
            {
                if (listaCrediteCurente[i] is CreditStudiu)
                {
                    double valoareCredit = ((CreditStudiu)listaCrediteCurente[i]).CalculeazaCredit();
                    double procentajCreditChart = (100 * valoareCredit) / cuantumTotalCredite;
                    chart1.Series["Credite"].Points.AddXY(valoareCredit.ToString() + " RON" + Environment.NewLine +
                        Math.Ceiling(procentajCreditChart).ToString() + "%",
                        procentajCreditChart.ToString());
                }
                else
                {
                    double valoareCredit = listaCrediteCurente[i].CalculeazaCredit();
                    double procentajCreditChart = (100 * valoareCredit) / cuantumTotalCredite;
                    chart1.Series["Credite"].Points.AddXY(valoareCredit.ToString() + " RON" + Environment.NewLine +
                        Math.Ceiling(procentajCreditChart).ToString() + "%",
                        procentajCreditChart.ToString());
                }

            }
        }
    }
}
