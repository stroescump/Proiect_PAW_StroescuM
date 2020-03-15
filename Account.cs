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

namespace Proiect_PAW_StroescuM
{
    public partial class Account : Form
    {
        private String userReceiverText = "";
        static String provider = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = banking.accdb";
        private String CNP = null;
        private OleDbConnection connection = new OleDbConnection(provider);
        private Credite credit;
        private bool isStudent = false;

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
                        Console.WriteLine("Credit: " + c.CalculeazaCredit().ToString());
                        Console.WriteLine("\n");
                        Console.WriteLine("Dobanda " + c.CalculeazaDobanda().ToString());
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
                    }
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Account_Load(object sender, EventArgs e)
        {

        }

        private void contractareCreditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.CNP != null)
            {
                MessageBox.Show(this.CNP);
                new CreditNou(this.CNP, isStudent).ShowDialog();


            }
            else MessageBox.Show("Eroare la contractare credite! Va rugam reincercati!");

        }

        private void CrediteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lbUser_Logged_Click(object sender, EventArgs e)
        {

        }
    }
}
