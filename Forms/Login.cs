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
using Proiect_PAW_StroescuM.Singletons;
using Proiect_PAW_StroescuM.Properties;
using Proiect_PAW_StroescuM.Interfaces;
using Proiect_PAW_StroescuM.Helpers;

namespace Proiect_PAW_StroescuM
{
    public partial class Login : Form
    {
        private bool isNightMode = Settings.Default.isNightMode;
        string provider = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = banking.accdb";
        private Hash_SHA256 encryptionClassInstance = Hash_SHA256.getInstance();
        private HelperNightMode helperNightMode = new HelperNightMode();
        public Login()
        {
            InitializeComponent();
            tbUser.Focus();
            helperNightMode.setColorTheme(isNightMode, this);
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
                    string emailAddress = tbUser.Text;
                    while (reader.Read())
                    {

                        numeClient = reader["Nume"].ToString();
                        CNP = reader["CNP"].ToString();
                        passwd = reader["Password"].ToString();
                    }
                    if (numeClient != null && tbPass.Text.Equals(passwd) && CNP != null)
                    {
                        MessageBox.Show("Login Successful!");
                        Account form = new Account(numeClient, CNP, emailAddress, encryptionClassInstance, this);
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

        private void modDeNoapteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isNightMode = !isNightMode;
            if (isNightMode)
            {
                nightModeMenuStrip.Items[0].Text = "Mod de zi";
            }
            else
            {
                nightModeMenuStrip.Items[0].Text = "Mod de noapte";
            }
            helperNightMode.setNightMode(isNightMode, this);
        }

    }
}
