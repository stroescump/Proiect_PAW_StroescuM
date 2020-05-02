using Proiect_PAW_StroescuM.Helpers;
using Proiect_PAW_StroescuM.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Proiect_PAW_StroescuM
{
    public partial class CreditNou : Form
    {
        private String CNP;
        private static String provider = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source=banking.accdb";
        private OleDbConnection connection = new OleDbConnection(provider);
        private bool isStudent = false;
        private Account referenceForm;
        private static Label customLabelErrorForSuma = new Label();
        private HelperNightMode helperNightMode = new HelperNightMode();
        public CreditNou(String CNP, bool isStudent, Account referenceForm)
        {
            InitializeComponent();
            helperNightMode.setColorTheme(Settings.Default.isNightMode, this);
            tb_sumaCeruta.Focus();
            this.CNP = CNP;
            this.isStudent = isStudent;
            this.referenceForm = referenceForm;

            if (isStudent)
            {
                cbStudent.Enabled = true;
                cbStudent.Checked = true;
                clbPerioadaDeGratiere.Enabled = true;
            }
            else
            {
                cbStudent.Enabled = false;
                clbPerioadaDeGratiere.Enabled = false;
            }

        }

        private void btn_aplicaCredit_Click(object sender, EventArgs e)
        {
            string creditQuery = Settings.Default.CreditQuery;
            MessageBox.Show(creditQuery);
            OleDbCommand command = new OleDbCommand(creditQuery, connection);

            if (clbPerioadaDeCreditare.CheckedItems.Count == 0 || (tb_sumaCeruta.Text.Length) == 0)
            {
                if ((tb_sumaCeruta.Text.Length) == 0 || Int32.Parse(tb_sumaCeruta.Text) < 100)
                {
                    MessageBox.Show("Valoarea creditului trebuie sa fie mai mare de 99 lei!");
                }
                else
                {
                    MessageBox.Show("Trebuie sa selectezi o perioada de creditare din cele oferite!");
                }
            }
            else
            {
                try
                {
                    command.Parameters.AddWithValue("sumaAprobata", tb_sumaCeruta.Text);
                    command.Parameters.AddWithValue("perioadaCredit", clbPerioadaDeCreditare.CheckedItems[0].ToString());
                    string perioadaDeGratiere;
                    if (isStudent && cbStudent.Checked == true)
                    {
                        if (clbPerioadaDeGratiere.CheckedItems.Count == 0)
                        {
                            perioadaDeGratiere = "0";
                        }
                        else
                        {
                            perioadaDeGratiere = clbPerioadaDeGratiere.CheckedItems[0].ToString();
                        }
                    }
                    else perioadaDeGratiere = "0";
                    CreditStudiu creditNouStudii = new CreditStudiu(DateTime.Now, int.Parse(tb_sumaCeruta.Text),
                        int.Parse(clbPerioadaDeCreditare.CheckedItems[0].ToString()),
                        int.Parse(perioadaDeGratiere));
                    Credite creditNouSimplu = new Credite(DateTime.Now, int.Parse(tb_sumaCeruta.Text),
                        int.Parse(clbPerioadaDeCreditare.CheckedItems[0].ToString()));

                    if (isStudent)
                    {
                        if (cbStudent.CheckState == CheckState.Checked)
                        {
                            command.Parameters.AddWithValue("dobanda", "3");
                            command.Parameters.AddWithValue("totalDePlata", ((CreditStudiu)creditNouStudii).CalculeazaCredit().ToString());
                            command.Parameters.AddWithValue("dataCredit", DateTime.Now.ToShortDateString());
                            command.Parameters.AddWithValue("perioadaDeGratie", perioadaDeGratiere);
                            command.Parameters.AddWithValue("CNP", this.CNP);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("dobanda", "12");
                            command.Parameters.AddWithValue("totalDePlata", (creditNouSimplu).CalculeazaCredit().ToString());
                            command.Parameters.AddWithValue("dataCredit", DateTime.Now.ToShortDateString());
                            command.Parameters.AddWithValue("perioadaDeGratie", perioadaDeGratiere);
                            command.Parameters.AddWithValue("CNP", this.CNP);
                        }
                    }
                    else
                    {
                        command.Parameters.AddWithValue("dobanda", "12");
                        command.Parameters.AddWithValue("totalDePlata", (creditNouSimplu).CalculeazaCredit().ToString());
                        command.Parameters.AddWithValue("dataCredit", DateTime.Now.ToShortDateString());
                        command.Parameters.AddWithValue("perioadaDeGratie", perioadaDeGratiere);
                        command.Parameters.AddWithValue("CNP", this.CNP);
                    }

                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Credit accesat cu succes!");
                    if (isStudent && cbStudent.Checked == true)
                    {
                        referenceForm.GetListaCredite.Add(creditNouStudii);
                    }
                    else
                    {
                        referenceForm.GetListaCredite.Add(creditNouSimplu);
                    }
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void clbPerioadaDeCreditare_ItemCheck(object sender, ItemCheckEventArgs e)
        {

            for (int i = 0; i < clbPerioadaDeCreditare.Items.Count; i++)
            {
                if (i != e.Index)
                {
                    clbPerioadaDeCreditare.SetItemChecked(i, false);
                }

            }
        }

        private void clbPerioadaDeGratiere_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int i = 0; i < clbPerioadaDeGratiere.Items.Count; i++)
            {
                if (i != e.Index)
                {
                    clbPerioadaDeGratiere.SetItemChecked(i, false);
                }

            }
        }

        private void CreditNou_MouseMove(object sender, MouseEventArgs e)
        {
            if (Cursor.Position.X > 13 &&
                    Cursor.Position.X < (clbPerioadaDeGratiere.Location.X - clbPerioadaDeGratiere.Size.Width) &&
                    Cursor.Position.Y > (clbPerioadaDeGratiere.Location.Y) && Cursor.Position.Y < (clbPerioadaDeGratiere.Location.Y - clbPerioadaDeGratiere.Size.Height))
            {
                Label test = new Label();
                test.Text = "Hallo";
                this.Controls.Add(test);
            }
        }

        private void cbStudent_CheckedChanged(object sender, EventArgs e)
        {
            if (cbStudent.Checked == false)
            {
                clbPerioadaDeGratiere.Enabled = false;
                for (int i = 0; i < clbPerioadaDeGratiere.Items.Count; i++)
                {
                    clbPerioadaDeGratiere.SetItemChecked(i, false);
                }
            }
            else clbPerioadaDeGratiere.Enabled = true;
        }

        private void tb_sumaCeruta_TextChanged(object sender, EventArgs e)
        {
            if (tb_sumaCeruta.Text.Length < 3)
            {
                customLabelErrorForSuma.Visible = true;
                customLabelErrorForSuma.Text = "Suma trebuie > 99 lei";
                customLabelErrorForSuma.ForeColor = Settings.Default.isNightMode == true ? Color.WhiteSmoke : Color.DarkSlateGray;
                customLabelErrorForSuma.Location = new Point(
                    tb_sumaCeruta.Location.X + tb_sumaCeruta.Size.Width + 10,
                    tb_sumaCeruta.Location.Y + 2);
                customLabelErrorForSuma.AutoSize = true;
                this.Controls.Add(customLabelErrorForSuma);
            }
            if (tb_sumaCeruta.Text.Length >= 3)
            {
                customLabelErrorForSuma.Visible = false;
            }
        }

        private void tb_sumaCeruta_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar))
            {
                if (!char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }

        }
    }
}
