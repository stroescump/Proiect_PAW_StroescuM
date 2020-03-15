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
        public CreditNou(String CNP, bool isStudent)
        {
            InitializeComponent();
            this.CNP = CNP;
            this.isStudent = isStudent;
            if (isStudent)
            {
                cbStudent.Enabled = true;
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
            string query = "INSERT into Credite ([sumaAprobata],[perioadaCredit],[dobanda],[totalDePlata]," +
                "[dataCredit],[perioadaDeGratie],[CNP]) values(?,?,?,?,?,?,?)";
            OleDbCommand command = new OleDbCommand(query, connection);

            try
            {
                command.Parameters.AddWithValue("sumaAprobata", tb_sumaCeruta.Text);
                command.Parameters.AddWithValue("perioadaCredit", clbPerioadaDeCreditare.CheckedItems[0].ToString());
                String perioadaDeGratiere;
                if (isStudent) perioadaDeGratiere = clbPerioadaDeGratiere.CheckedItems[0].ToString();
                else perioadaDeGratiere = "0";
                CreditStudiu creditNou = new CreditStudiu(DateTime.Now, int.Parse(tb_sumaCeruta.Text),
                    int.Parse(clbPerioadaDeCreditare.CheckedItems[0].ToString()),
                    int.Parse(perioadaDeGratiere));
                if (isStudent)
                {
                    if (cbStudent.CheckState == CheckState.Checked)
                    {
                        command.Parameters.AddWithValue("dobanda", "3");
                        command.Parameters.AddWithValue("totalDePlata", ((CreditStudiu)creditNou).CalculeazaCredit().ToString());
                        command.Parameters.AddWithValue("dataCredit", DateTime.Now.ToShortDateString());
                        command.Parameters.AddWithValue("perioadaDeGratie", clbPerioadaDeGratiere.CheckedItems[0].ToString());
                        command.Parameters.AddWithValue("CNP", this.CNP);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("dobanda", "12");
                        command.Parameters.AddWithValue("totalDePlata", (creditNou).CalculeazaCredit().ToString());
                        command.Parameters.AddWithValue("dataCredit", DateTime.Now.ToShortDateString());
                        command.Parameters.AddWithValue("perioadaDeGratie", "0");
                        command.Parameters.AddWithValue("CNP", this.CNP);
                    }
                }
                else
                {
                    command.Parameters.AddWithValue("dobanda", "12");
                    command.Parameters.AddWithValue("totalDePlata", (creditNou).CalculeazaCredit().ToString());
                    command.Parameters.AddWithValue("dataCredit", DateTime.Now.ToShortDateString());
                    command.Parameters.AddWithValue("perioadaDeGratie", "0");
                    command.Parameters.AddWithValue("CNP", this.CNP);
                }

                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Credit accesat cu succes!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
    }
}
