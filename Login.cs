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
    public partial class Login : Form
    {
        string provider = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = banking.accdb";
        public Login()
        {
            InitializeComponent();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbUser.TextLength != 0 && tbPass.TextLength != 0)
            {
                OleDbConnection connection = new OleDbConnection(provider);
                string query = "SELECT * from Clienti where Email='" + tbUser.Text + "'";
                OleDbCommand command = new OleDbCommand(query, connection);
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();

                try
                {
                    string CNP = null;
                    string passwd = null;
                    string numeClient = null;
                    while (reader.Read())
                    {

                        numeClient = reader["Nume"].ToString();
                        CNP = reader["CNP"].ToString();
                        passwd = reader["Password"].ToString();
                    }
                    if (numeClient != null && tbPass.Text.Equals(passwd) && CNP != null)
                    {
                        MessageBox.Show("Login Successful!");
                        Account form = new Account(numeClient, CNP);
                        tbUser.Text = "";
                        tbPass.Text = "";
                        this.Hide();
                        form.ShowDialog();

                    }
                    else
                    {
                        MessageBox.Show("User sau parola incorecta!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Userul nu se regaseste in baza de date! sau " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally { reader.Close(); }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register form = new Register();
            form.ShowDialog();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
