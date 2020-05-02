using Proiect_PAW_StroescuM.Helpers;
using Proiect_PAW_StroescuM.Properties;
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
        private HelperNightMode helperNightMode = new HelperNightMode();
        private double cuantumTotalCredite = 0;
        List<Brush> brushes = new List<Brush>();
        public PieChart(List<Credite> listaCrediteCurente, double cuantumTotalCredite)
        {
            initBrushes();
            this.listaCrediteCurente = listaCrediteCurente;
            this.cuantumTotalCredite = cuantumTotalCredite;
            InitializeComponent();
            helperNightMode.setColorTheme(Settings.Default.isNightMode, this);
        }

        private void initBrushes()
        {
            foreach (KnownColor color in Enum.GetValues(typeof(KnownColor)))
            {
                System.Drawing.Color colorObj = System.Drawing.Color.FromKnownColor(color);
                brushes.Add(new SolidBrush(colorObj));
            }
            brushes.RemoveRange(0, 34);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = panel1.CreateGraphics();
            double sumaCredite = 0;
            for (int i = 0; i < listaCrediteCurente.Count; i++)
            {
                if (listaCrediteCurente[i] is CreditStudiu)
                {
                    double valoareCredit = ((CreditStudiu)listaCrediteCurente[i]).CalculeazaCredit();
                    sumaCredite += valoareCredit;
                    double procentajCreditChart = (100 * valoareCredit) / cuantumTotalCredite;
                }
                else
                {
                    double valoareCredit = listaCrediteCurente[i].CalculeazaCredit();
                    sumaCredite += valoareCredit;
                    double procentajCreditChart = (100 * valoareCredit) / cuantumTotalCredite;
                }
            }
            double sumSlices = 0;
            int x, y, w, h = 0;
            x = this.Size.Width - 180;
            y = 20;
            w = 40;
            h = 10;
            try
            {
                g.DrawString("Distributia cuantumului creditelor",
                    new Font(FontFamily.GenericSansSerif, 10),
                    new SolidBrush(Settings.Default.isNightMode == true ? Color.WhiteSmoke : Color.DarkSlateGray),
                    new PointF(55, 15));
                for (int i = 0; i < listaCrediteCurente.Count; i++)
                {
                    if (listaCrediteCurente[i] is CreditStudiu)
                    {
                        g.FillPie(brushes[i % listaCrediteCurente.Count],
                            new Rectangle(50, 50, 200, 200), i == 0 ? 0 : float.Parse(sumSlices.ToString()),
                            float.Parse((360f / sumaCredite * ((CreditStudiu)listaCrediteCurente[i]).CalculeazaCredit()).ToString()));
                        g.FillRectangle(brushes[i % listaCrediteCurente.Count], new Rectangle(x, y, w, h));
                        sumSlices += 360f / sumaCredite * ((CreditStudiu)listaCrediteCurente[i]).CalculeazaCredit();

                        Label details = new Label();
                        details.Location = new Point(x + 50, y - 2);
                        details.Text = (Math.Round(100 / sumaCredite * ((CreditStudiu)listaCrediteCurente[i]).CalculeazaCredit()).ToString() + "%" + " - " +
                            (Math.Round(((CreditStudiu)listaCrediteCurente[i]).CalculeazaCredit()).ToString()) + " lei");
                        panel1.Controls.Add(details);
                        y += 25;
                    }
                    else
                    {
                        g.FillPie(brushes[i % listaCrediteCurente.Count],
                            new Rectangle(50, 50, 200, 200), i == 0 ? 0 : float.Parse(sumSlices.ToString()),
                            float.Parse((360f / sumaCredite * (listaCrediteCurente[i]).CalculeazaCredit()).ToString()));
                        g.FillRectangle(brushes[i % listaCrediteCurente.Count], new Rectangle(x, y, w, h));
                        sumSlices += 360f / sumaCredite * listaCrediteCurente[i].CalculeazaCredit();

                        Label details = new Label();
                        details.Location = new Point(x + 50, y - 2);
                        details.Text = (Math.Round(100 / sumaCredite * listaCrediteCurente[i].CalculeazaCredit()).ToString() + "%" + " - " +
                            Math.Round(listaCrediteCurente[i].CalculeazaCredit()).ToString() + " lei");
                        panel1.Controls.Add(details);
                        y += 25;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
