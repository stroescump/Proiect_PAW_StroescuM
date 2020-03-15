using System;
using System.Activities;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_PAW_StroescuM
{
    public partial class Register : Form
    {
        String provider = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = banking.accdb";
        Label lbNrMatricol = new Label();
        Label lbNumeInstitutie = new Label();
        Point diferenta;
        Point pozitieDeStart;

        TextBox numeInstitutie = new TextBox();
        TextBox nrMatricol = new TextBox();
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbNume.TextLength < 3)
            {
                errorProvider1.SetError(tbNume, "Completeaza nume!");
                tbNume.Focus();
            }
            if (tbPrenume.TextLength < 3)
            {
                errorProvider1.SetError(tbPrenume, "Completeaza prenume!");
                tbPrenume.Focus();
            }
            if (tbCNP.TextLength != 13)
            {
                errorProvider1.SetError(tbCNP, "CNP din 13 cifre!");
                tbCNP.Focus();
            }
            if (!(tbEmail.Text.Contains("@") && (tbEmail.Text.Contains(".com") || tbEmail.Text.Contains(".ro"))))
            {
                errorProvider1.SetError(tbEmail, "Completeaza un format de email corect!");
                tbEmail.Focus();
            }

            if (tb_passwd.TextLength < 8)
            {
                errorProvider1.SetError(tb_passwd, "Parola din cel putin 8 caractere!");
                tb_passwd.Focus();
            }
            else
            {
                OleDbCommand cmd = null;
                OleDbConnection conexiune = new OleDbConnection(provider);
                if (cbStudent.Checked)
                {
                    string commandSql = "insert into Clienti ([Nume],[Prenume],[Email],[DataNasterii],[CNP],[Password],[numarMatricol],[numeInstitutie]) values(?,?,?,?,?,?,?,?)";
                    cmd = new OleDbCommand(commandSql, conexiune);
                    cmd.Parameters.AddWithValue("Nume", tbNume.Text);
                    cmd.Parameters.AddWithValue("Prenume", tbPrenume.Text);
                    cmd.Parameters.AddWithValue("Email", tbEmail.Text);
                    cmd.Parameters.AddWithValue("DataNasterii", dateTimePicker_DataNasterii.Value.Date.ToShortDateString());
                    cmd.Parameters.AddWithValue("CNP", tbCNP.Text);
                    cmd.Parameters.AddWithValue("Password", tb_passwd.Text);
                    cmd.Parameters.AddWithValue("numarMatricol", nrMatricol.Text);
                    cmd.Parameters.AddWithValue("numeInstitutie", numeInstitutie.Text);
                }
                else
                {
                    string commandSql = "INSERT INTO Clienti ([Nume],[Prenume],[Email],[DataNasterii],[CNP],[Password]) values(?,?,?,?,?,?)";
                    cmd = new OleDbCommand(commandSql, conexiune);
                    cmd.Parameters.AddWithValue("Nume", tbNume.Text);
                    cmd.Parameters.AddWithValue("Prenume", tbPrenume.Text);
                    cmd.Parameters.AddWithValue("Email", tbEmail.Text);
                    cmd.Parameters.AddWithValue("DataNasterii", dateTimePicker_DataNasterii.Value.Date.ToShortDateString());
                    cmd.Parameters.AddWithValue("CNP", tbCNP.Text);
                    cmd.Parameters.AddWithValue("Password", tb_passwd.Text);
                }
                try
                {
                    conexiune.Open();
                    if (cmd != null)
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("User creat cu succes!");
                        this.Hide();
                        new Login().ShowDialog();
                    }
                    else Console.WriteLine("CMD E NULL!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    conexiune.Close();
                    errorProvider1.Clear();
                }
            }
        }

        private void cbStudent_CheckStateChanged(object sender, EventArgs e)
        {

            if (cbStudent.Checked)
            {
                diferenta = new Point(dateTimePicker_DataNasterii.Location.X - cbStudent.Location.X,
                    dateTimePicker_DataNasterii.Location.Y - cbStudent.Location.Y);
                pozitieDeStart = new Point(cbStudent.Location.X - diferenta.X, cbStudent.Location.Y - diferenta.Y);
                lbNrMatricol.Text = "Nr.Matricol";
                lbNumeInstitutie.Text = "Nume Institutie";

                nrMatricol.Text = "";
                numeInstitutie.Text = "";
                lbNumeInstitutie.Location = pozitieDeStart;
                numeInstitutie.Location = new Point(lbNumeInstitutie.Location.X - (lbPasswd.Location.X - tb_passwd.Location.X),
                       lbNumeInstitutie.Location.Y - (lbPasswd.Location.Y - tb_passwd.Location.Y));
                lbNrMatricol.Location = new Point(numeInstitutie.Location.X - diferenta.X,
                    numeInstitutie.Location.Y - diferenta.Y);
                nrMatricol.Location = new Point(lbNrMatricol.Location.X - (lbPasswd.Location.X - tb_passwd.Location.X),
                    lbNrMatricol.Location.Y - (lbPasswd.Location.Y - tb_passwd.Location.Y));
                btnInregistrare.Location = new Point(nrMatricol.Location.X - diferenta.X, nrMatricol.Location.Y - diferenta.Y);
                this.Controls.Add(nrMatricol);
                this.Controls.Add(numeInstitutie);
                this.Controls.Add(lbNumeInstitutie);
                this.Controls.Add(lbNrMatricol);
                this.Size = new Size(this.Size.Width, this.Size.Height + lbNumeInstitutie.Size.Height +
                    lbNrMatricol.Size.Height + nrMatricol.Size.Height + numeInstitutie.Size.Height);
            }
        }

        private void cbStudent_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbStudent.Checked)
            {
                //Console.WriteLine(this.Size);
                //this.Size = new Size(481, 500);
                this.Size = new Size(this.Size.Width, this.Size.Height - lbNumeInstitutie.Size.Height -
                    lbNrMatricol.Size.Height - nrMatricol.Size.Height - numeInstitutie.Size.Height);
                btnInregistrare.Location = pozitieDeStart;
                this.Controls.Remove(lbNumeInstitutie);
                this.Controls.Remove(lbNrMatricol);
                this.Controls.Remove(nrMatricol);
                this.Controls.Remove(numeInstitutie);
            }
        }

        private void tbNume_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
