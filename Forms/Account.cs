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
using System.Security.Cryptography;
using Proiect_PAW_StroescuM.Forms;
using Proiect_PAW_StroescuM.Interfaces;
using Proiect_PAW_StroescuM.Properties;
using Proiect_PAW_StroescuM.Singletons;
using Proiect_PAW_StroescuM.Exceptions;
using System.Runtime.Serialization.Formatters.Binary;

namespace Proiect_PAW_StroescuM
{
    public partial class Account : Form, IDataTransfer
    {
        private String userReceiverText = "";
        static String provider = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = banking.accdb";
        private String CNP = null;
        private OleDbConnection connection = new OleDbConnection(provider);
        private bool isStudent = false;
        private List<Credite> listaCredite = new List<Credite>();
        private double cuantumTotalCredite;
        private int counterForListaCredite;
        private string shaKeyForEncryption;
        private Hashing hashingForm;
        private Hash_SHA256 encryptionClassInstance;
        private string currentUserEmailAddress;
        private Login loginInstance;

        public Account(String s, String CNP, String emailAddress, Hash_SHA256 encryptionInstance, Login loginFormInstance)
        {
            InitializeComponent();
            userReceiverText += s + "!";
            lbUser_Logged.Text += userReceiverText;
            this.CNP = CNP;
            this.currentUserEmailAddress = emailAddress;
            verifyIfStudent();
            encryptionClassInstance = encryptionInstance;
            loginInstance = loginFormInstance;
            hashingForm = new Hashing(this, encryptionClassInstance);
            try
            {
                string query = "Select * from Credite where CNP='" + CNP + "'";
                OleDbCommand command = new OleDbCommand(query, connection);
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();
                if (isStudent)
                {
                    lvCredite.Columns.Add("Perioada de gratie");
                    lvCredite.Size = new Size(lvCredite.Width + 150, lvCredite.Height);
                    lvCredite.Columns[lvCredite.Columns.Count - 1].Width = 150;
                }

                while (reader.Read())
                {
                    if (reader["dobanda"].ToString() == "3")
                    {
                        CreditStudiu c = new CreditStudiu(DateTime.Parse(reader["dataCredit"].ToString()), double.Parse(reader["sumaAprobata"].ToString()),
                            int.Parse(reader["perioadaCredit"].ToString()), int.Parse(reader["perioadaDeGratie"].ToString()));
                        ListViewItem item = lvCredite.Items.Add((lvCredite.Items.Count + 1).ToString());
                        item.SubItems.Add(c.GetDateTime.ToShortDateString());
                        item.SubItems.Add(c.CuantumCredit.ToString());
                        item.SubItems.Add(c.PerioadaCredit.ToString());
                        item.SubItems.Add(c.CalculeazaDobanda().ToString());
                        item.SubItems.Add(c.CalculeazaCredit().ToString());
                        item.SubItems.Add(CreditStudiu.DOBANDA.ToString() + "%");
                        item.SubItems.Add(c.PerioadaDeGratie.ToString() + " luni");
                        listaCredite.Add(c);
                        cuantumTotalCredite += c.CalculeazaCredit();
                    }
                    else
                    {
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
                connection.Close();
                counterForListaCredite = listaCredite.Count;
                Console.WriteLine("Counter initial: " + counterForListaCredite);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void verifyIfStudent()
        {
            try
            {
                string query = "Select * from Clienti where CNP='" + CNP + "'";
                OleDbCommand command = new OleDbCommand(query, connection);
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();
                string numarMatricol = "";
                string numeInstitutie = "";
                while (reader.Read())
                {
                    numarMatricol = reader["numarMatricol"].ToString();
                    numeInstitutie = reader["numeInstitutie"].ToString();
                }
                reader.Close();
                connection.Close();
                if (numarMatricol != "" && numeInstitutie != "")
                {
                    isStudent = true;
                }
                else
                {
                    isStudent = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la query pe tabela Clienti pt. a determina isStudent!" + Environment.NewLine + ex.Message);
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
            MessageBox.Show("Salvarea fisierelor va utiliza encriptare SHA-256bit!");
            hashingForm.ShowDialog();
            try
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                FileStream fileStream = new FileStream("export_listaCredite_" +
                    DateTime.Now.Day + "_" +
                    DateTime.Now.Hour + "_" +
                    DateTime.Now.Minute + "_" +
                    DateTime.Now.Millisecond + ".smp", FileMode.Create, FileAccess.Write);
                StringBuilder builder = new StringBuilder();
                builder.AppendLine(shaKeyForEncryption);
                for (int i = 0; i < listaCredite.Count; i++)
                {
                    if (progressBar.Value < 100)
                    {
                        progressBar.Value += listaCredite.Count / 100;
                    }
                    if (listaCredite[i] is CreditStudiu)

                        builder.AppendLine(((CreditStudiu)listaCredite[i]).TransformCreditToCsv());
                    else
                    {
                        builder.AppendLine(listaCredite[i].TransformCreditToCsv());
                    }
                }
                binaryFormatter.Serialize(fileStream, builder.ToString());
                fileStream.Close();
                progressBar.Value += 100 - progressBar.Value;
                MessageBox.Show("Salvarea s-a efectuat cu succes!");
                progressBar.Value = 0;
                progressBar.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void displayCreditFromTxtFile(Object path)
        {
            BinaryFormatter bf = new BinaryFormatter();
            StringReader reader = null;
            if (path is OpenFileDialog)
            {
                FileStream stream = new FileStream(((OpenFileDialog)path).FileName, FileMode.Open, FileAccess.Read);
                reader = new StringReader((string)bf.Deserialize(stream));
            }
            else if (path is string)
            {
                FileStream stream = new FileStream((string)path, FileMode.Open, FileAccess.Read);
                reader = new StringReader((string)bf.Deserialize(stream));
            }

            string computedHashForCurrentUserEmail = encryptionClassInstance.calculHash(currentUserEmailAddress);
            if (computedHashForCurrentUserEmail.Equals(reader.ReadLine()))
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
                MessageBox.Show("Aceste date nu va apartin! Va rugam sa utilizati doar date asociate sau trimise contului dvs.!");
            }
            reader.Close();
        }

        private void restaurareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "(*.smp)|*.smp";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                displayCreditFromTxtFile(openFileDialog1);
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            loginInstance.Show();
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
                        Console.WriteLine(listaCredite[i]);
                        if (listaCredite[i] is CreditStudiu)
                        {
                            (lvCredite.Items[j]).SubItems.Add((((CreditStudiu)listaCredite[i]).GetDateTime.ToShortDateString()));
                            (lvCredite.Items[j]).SubItems.Add((((CreditStudiu)listaCredite[i]).CuantumCredit.ToString()));
                            (lvCredite.Items[j]).SubItems.Add((((CreditStudiu)listaCredite[i]).PerioadaCredit.ToString()));
                            (lvCredite.Items[j]).SubItems.Add((((CreditStudiu)listaCredite[i]).CalculeazaDobanda().ToString()));
                            (lvCredite.Items[j]).SubItems.Add((((CreditStudiu)listaCredite[i]).CalculeazaCredit().ToString()));
                            (lvCredite.Items[j]).SubItems.Add((CreditStudiu.DOBANDA.ToString() + "%"));
                            (lvCredite.Items[j]).SubItems.Add(((CreditStudiu)listaCredite[i]).PerioadaDeGratie.ToString() + " luni");
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

        public void passData(string message)
        {
            shaKeyForEncryption = message;
        }
    }
}
