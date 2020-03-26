using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using System.Drawing.Printing;

namespace Proiect_PAW_StroescuM
{
    public partial class Account : Form
    {
        private String userReceiverText = "";
        static String provider = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = banking.accdb";
        private String CNP = null;
        private OleDbConnection connection = new OleDbConnection(provider);
        private bool isStudent = false;
        private List<Credite> listaCredite = new List<Credite>();
        private double cuantumTotalCredite;
        private int counterForListaCredite;

        public Account(String s, String CNP)
        {
            InitializeComponent();
            userReceiverText += s + "!";
            lbUser_Logged.Text += userReceiverText;
            this.CNP = CNP;
            try
            {
                string query = "Select * from Credite where CNP='" + CNP + "'";
                OleDbCommand command = new OleDbCommand(query, connection);
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();
                lvCredite.Columns.Add("Perioada de gratie");
                while (reader.Read())
                {
                    if (reader["dobanda"].ToString() == "3")
                    {
                        isStudent = true;
                        CreditStudiu c = new CreditStudiu(DateTime.Parse(reader["dataCredit"].ToString()), double.Parse(reader["sumaAprobata"].ToString()),
                            int.Parse(reader["perioadaCredit"].ToString()), int.Parse(reader["perioadaDeGratie"].ToString()));
                        ListViewItem item = lvCredite.Items.Add((lvCredite.Items.Count + 1).ToString());
                        item.SubItems.Add(c.GetDateTime.ToShortDateString());
                        item.SubItems.Add(c.CuantumCredit.ToString());
                        item.SubItems.Add(c.PerioadaCredit.ToString());
                        item.SubItems.Add(c.CalculeazaDobanda().ToString());
                        item.SubItems.Add(c.CalculeazaCredit().ToString());
                        item.SubItems.Add(CreditStudiu.DOBANDA.ToString() + "%");
                        item.SubItems.Add(c.PerioadaDeGratie.ToString() + " ani");
                        listaCredite.Add(c);
                        cuantumTotalCredite += c.CalculeazaCredit();
                    }
                    else
                    {
                        isStudent = false;
                        Credite c = new Credite(DateTime.Parse(reader["dataCredit"].ToString()), double.Parse(reader["sumaAprobata"].ToString()),
                            int.Parse(reader["perioadaCredit"].ToString()));
                        ListViewItem item = lvCredite.Items.Add((lvCredite.Items.Count + 1).ToString());
                        item.SubItems.Add(c.GetDateTime.ToShortDateString());
                        item.SubItems.Add(c.CuantumCredit.ToString());
                        item.SubItems.Add(c.PerioadaCredit.ToString());
                        item.SubItems.Add(c.CalculeazaDobanda().ToString());
                        item.SubItems.Add(c.CalculeazaCredit().ToString());
                        item.SubItems.Add(Credite.DOBANDA.ToString() + "%");
                        listaCredite.Add(c);
                        cuantumTotalCredite += c.CalculeazaCredit();
                    }
                }
                reader.Close();
                counterForListaCredite = listaCredite.Count;
                Console.WriteLine("Counter initial: " + counterForListaCredite);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //
            }
        }

        private void contractareCreditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.CNP != null)
            {
                new CreditNou(this.CNP, isStudent, (Account)this).ShowDialog();
            }
            else MessageBox.Show("Eroare la contractare credite! Va rugam reincercati!");

        }

        private void salvareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            progressBar.Visible = true;
            progressBar.Value = 0;
            MessageBox.Show("Salvarea fisierelor se va face in format .txt de tip CSV fara encriptare!" + Environment.NewLine
                + "A NU SE DISTRIBUI!");
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "(*.txt)|*.txt";
            try
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter writer = new StreamWriter(dialog.FileName);
                    writer.WriteLine(CNP);
                    for (int i = 0; i < listaCredite.Count; i++)
                    {
                        if (progressBar.Value < 100)
                        {
                            progressBar.Value += listaCredite.Count / 100;
                        }
                        if (listaCredite[i] is CreditStudiu)

                            writer.WriteLine(((CreditStudiu)listaCredite[i]).TransformCreditToCsv());
                        else
                        {
                            writer.WriteLine(listaCredite[i].TransformCreditToCsv());
                        }
                    }

                    writer.Close();
                    progressBar.Value += 100 - progressBar.Value;
                    MessageBox.Show("Salvarea s-a efectuat cu succes!");
                    progressBar.Value = 0;
                    progressBar.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void displayCreditFromTxtFile(Object path)
        {
            StreamReader reader = null;
            if (path is OpenFileDialog)
            {
                reader = new StreamReader(((OpenFileDialog)path).FileName);

            }
            else if (path is string)
            {
                reader = new StreamReader((string)path);
            }

            string gdpr = reader.ReadLine(); // Antentul fisierului cu detalii despre persoana
            if (CNP.Equals(gdpr))
            {
                string[] creditParsed = new string[9];
                string creditTxt;
                while ((creditTxt = reader.ReadLine()) != null)
                {

                    if (creditTxt != null)
                    {
                        creditParsed = creditTxt.Split(',');
                    }

                    try
                    {
                        if (creditParsed.Length > 8)
                        {
                            if (creditParsed[8].Equals("perioadaDeGratie"))
                            {
                                CreditStudiu nouCredit = new CreditStudiu(DateTime.Parse(creditParsed[1]), double.Parse(creditParsed[3]),
                                    int.Parse(creditParsed[5]), int.Parse(creditParsed[9]));
                                MessageBox.Show(nouCredit.ToString());
                            }
                        }
                        else
                        {
                            Credite nouCredit = new Credite(DateTime.Parse(creditParsed[1]), double.Parse(creditParsed[3]), int.Parse(creditParsed[5]));
                            MessageBox.Show(nouCredit.ToString());
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Integritatea datelor a fost compromisa, nu se pot prelucra!" + Environment.NewLine + ex.StackTrace);
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Aceste date nu va apartin! Va rugam sa utilizati doar date asociate contului dvs.!");
            }
            reader.Close();
        }

        private void restaurareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "(*.txt)|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                displayCreditFromTxtFile(openFileDialog1.FileName);
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().ShowDialog();
        }

        public void printDataListView(object sender, PrintPageEventArgs args)
        {
            float x = 50;
            float y = 30;
            Font font = new Font(FontFamily.GenericSansSerif, 10);
            Brush brush = Brushes.Black;

            for (int i = 0; i < listaCredite.Count; i++)
            {
                if (listaCredite[i] is CreditStudiu)
                {
                    args.Graphics.DrawString(((CreditStudiu)listaCredite[i]).PrepareForPrint(), font, brush, x, y);
                    y += 100;
                }
                else
                {
                    args.Graphics.DrawString(listaCredite[i].PrepareForPrint(), font, brush, x, y);
                    y += 100;
                }
            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {

            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(this.printDataListView);
            printPreviewDialog1.Document = pd;
            printPreviewDialog1.ShowDialog();

        }

        private void pieChartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PieChart frmPieChart = new PieChart(listaCredite, cuantumTotalCredite);
            frmPieChart.ShowDialog();
        }

        private void Account_DragDrop(object sender, DragEventArgs e)
        {
            string[] data = (string[])e.Data.GetData(DataFormats.FileDrop);
            displayCreditFromTxtFile(data[0]);
        }

        private void Account_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        public int GetCounterForListaCrediteForUpdateListView
        {
            get { return counterForListaCredite; }
            set
            {
                if (value > 0)
                {
                    counterForListaCredite = value;
                }
            }
        }

        public List<Credite> GetListaCredite
        {
            get { return listaCredite; }
        }

        private void Account_Activated(object sender, EventArgs e)
        {
            Console.WriteLine("Counter final: " + counterForListaCredite);
            if (counterForListaCredite != listaCredite.Count)
            {
                counterForListaCredite++;
                Console.WriteLine("Called");

                lvCredite.Items.Clear();
                for (int i = 0; i < listaCredite.Count; i++)
                {
                    lvCredite.Items.Add((i + 1).ToString());
                    for (int j = i; j < (lvCredite.Items).Count; j++)
                    {
                        if (listaCredite[i] is CreditStudiu)
                        {
                            (lvCredite.Items[j]).SubItems.Add((((CreditStudiu)listaCredite[i]).GetDateTime.ToShortDateString()));
                            (lvCredite.Items[j]).SubItems.Add((((CreditStudiu)listaCredite[i]).CuantumCredit.ToString()));
                            (lvCredite.Items[j]).SubItems.Add((((CreditStudiu)listaCredite[i]).PerioadaCredit.ToString()));
                            (lvCredite.Items[j]).SubItems.Add((((CreditStudiu)listaCredite[i]).CalculeazaDobanda().ToString()));
                            (lvCredite.Items[j]).SubItems.Add((((CreditStudiu)listaCredite[i]).CalculeazaCredit().ToString()));
                            (lvCredite.Items[j]).SubItems.Add((CreditStudiu.DOBANDA.ToString() + "%"));
                            (lvCredite.Items[j]).SubItems.Add(((CreditStudiu)listaCredite[i]).PerioadaDeGratie.ToString() + " ani");
                            cuantumTotalCredite += ((CreditStudiu)listaCredite[i]).CalculeazaCredit();
                        }
                        else
                        {
                            (lvCredite.Items[j]).SubItems.Add((listaCredite[i].GetDateTime.ToShortDateString()));
                            (lvCredite.Items[j]).SubItems.Add((listaCredite[i].CuantumCredit.ToString()));
                            (lvCredite.Items[j]).SubItems.Add((listaCredite[i].PerioadaCredit.ToString()));
                            (lvCredite.Items[j]).SubItems.Add((listaCredite[i].CalculeazaDobanda().ToString()));
                            (lvCredite.Items[j]).SubItems.Add((listaCredite[i].CalculeazaCredit().ToString()));
                            (lvCredite.Items[j]).SubItems.Add((Credite.DOBANDA.ToString() + "%"));
                            cuantumTotalCredite += listaCredite[i].CalculeazaCredit();
                        }

                    }
                }
            }
        }
    }
}
