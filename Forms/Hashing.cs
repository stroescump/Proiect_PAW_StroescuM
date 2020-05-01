using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proiect_PAW_StroescuM.Singletons;
using Proiect_PAW_StroescuM.Exceptions;
using Proiect_PAW_StroescuM.Interfaces;

namespace Proiect_PAW_StroescuM.Forms
{
    public partial class Hashing : Form
    {
        Hash_SHA256 hashingInstance = null;
        Account formReference = null;
        public Hashing(Account AccountFormRef, Hash_SHA256 encryptionInstanceRef)
        {
            InitializeComponent();
            formReference = AccountFormRef;
            hashingInstance = encryptionInstanceRef;
        }

        private void btnCriptare_Click(object sender, EventArgs e)
        {
            try
            {
                if ((hashingInstance != null) && (formReference != null))
                {
                    string hashComputed = hashingInstance.calculHash(tb_emailEncrypt.Text);
                    IDataTransfer dataTransfer = formReference;
                    dataTransfer.passData(hashComputed);
                    tb_emailEncrypt.Clear();
                    this.Close();
                }
                else
                {
                    throw new NullPointerExceptionCustom("Verifica referintele pt hashInstance si formInstance in clasa Hashing : Form!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
