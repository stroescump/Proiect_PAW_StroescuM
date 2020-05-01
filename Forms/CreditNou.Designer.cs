namespace Proiect_PAW_StroescuM
{
    partial class CreditNou
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tb_sumaCeruta = new System.Windows.Forms.TextBox();
            this.lbSumaAprobata = new System.Windows.Forms.Label();
            this.clbPerioadaDeCreditare = new System.Windows.Forms.CheckedListBox();
            this.cbStudent = new System.Windows.Forms.CheckBox();
            this.lbDataCredit = new System.Windows.Forms.Label();
            this.clbPerioadaDeGratiere = new System.Windows.Forms.CheckedListBox();
            this.lbPerioadaDeGratiere = new System.Windows.Forms.Label();
            this.btn_aplicaCredit = new System.Windows.Forms.Button();
            this.lb_perioadaCredit = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_sumaCeruta
            // 
            this.tb_sumaCeruta.Location = new System.Drawing.Point(13, 45);
            this.tb_sumaCeruta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_sumaCeruta.Name = "tb_sumaCeruta";
            this.tb_sumaCeruta.ShortcutsEnabled = false;
            this.tb_sumaCeruta.Size = new System.Drawing.Size(210, 26);
            this.tb_sumaCeruta.TabIndex = 0;
            this.tb_sumaCeruta.TextChanged += new System.EventHandler(this.tb_sumaCeruta_TextChanged);
            this.tb_sumaCeruta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_sumaCeruta_KeyPress);
            // 
            // lbSumaAprobata
            // 
            this.lbSumaAprobata.AutoSize = true;
            this.lbSumaAprobata.Location = new System.Drawing.Point(13, 13);
            this.lbSumaAprobata.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSumaAprobata.Name = "lbSumaAprobata";
            this.lbSumaAprobata.Size = new System.Drawing.Size(100, 20);
            this.lbSumaAprobata.TabIndex = 2;
            this.lbSumaAprobata.Text = "Suma ceruta";
            // 
            // clbPerioadaDeCreditare
            // 
            this.clbPerioadaDeCreditare.CheckOnClick = true;
            this.clbPerioadaDeCreditare.FormattingEnabled = true;
            this.clbPerioadaDeCreditare.Items.AddRange(new object[] {
            "12",
            "24",
            "36",
            "48",
            "60",
            "72",
            "84",
            "96"});
            this.clbPerioadaDeCreditare.Location = new System.Drawing.Point(13, 115);
            this.clbPerioadaDeCreditare.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clbPerioadaDeCreditare.Name = "clbPerioadaDeCreditare";
            this.clbPerioadaDeCreditare.Size = new System.Drawing.Size(210, 73);
            this.clbPerioadaDeCreditare.TabIndex = 3;
            this.clbPerioadaDeCreditare.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbPerioadaDeCreditare_ItemCheck);
            // 
            // cbStudent
            // 
            this.cbStudent.AutoSize = true;
            this.cbStudent.Location = new System.Drawing.Point(12, 200);
            this.cbStudent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbStudent.Name = "cbStudent";
            this.cbStudent.Size = new System.Drawing.Size(92, 24);
            this.cbStudent.TabIndex = 4;
            this.cbStudent.Text = "Student";
            this.cbStudent.UseVisualStyleBackColor = true;
            this.cbStudent.CheckedChanged += new System.EventHandler(this.cbStudent_CheckedChanged);
            // 
            // lbDataCredit
            // 
            this.lbDataCredit.AutoSize = true;
            this.lbDataCredit.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataCredit.Location = new System.Drawing.Point(13, 236);
            this.lbDataCredit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDataCredit.Name = "lbDataCredit";
            this.lbDataCredit.Size = new System.Drawing.Size(546, 29);
            this.lbDataCredit.TabIndex = 5;
            this.lbDataCredit.Text = "*Data creditului va fi tratata ca fiind data curenta";
            // 
            // clbPerioadaDeGratiere
            // 
            this.clbPerioadaDeGratiere.CheckOnClick = true;
            this.clbPerioadaDeGratiere.FormattingEnabled = true;
            this.clbPerioadaDeGratiere.Items.AddRange(new object[] {
            "12",
            "24"});
            this.clbPerioadaDeGratiere.Location = new System.Drawing.Point(13, 309);
            this.clbPerioadaDeGratiere.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clbPerioadaDeGratiere.Name = "clbPerioadaDeGratiere";
            this.clbPerioadaDeGratiere.Size = new System.Drawing.Size(210, 50);
            this.clbPerioadaDeGratiere.TabIndex = 3;
            this.clbPerioadaDeGratiere.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbPerioadaDeGratiere_ItemCheck);
            // 
            // lbPerioadaDeGratiere
            // 
            this.lbPerioadaDeGratiere.AutoSize = true;
            this.lbPerioadaDeGratiere.Location = new System.Drawing.Point(13, 277);
            this.lbPerioadaDeGratiere.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPerioadaDeGratiere.Name = "lbPerioadaDeGratiere";
            this.lbPerioadaDeGratiere.Size = new System.Drawing.Size(138, 20);
            this.lbPerioadaDeGratiere.TabIndex = 6;
            this.lbPerioadaDeGratiere.Text = "Perioada de gratie";
            // 
            // btn_aplicaCredit
            // 
            this.btn_aplicaCredit.Location = new System.Drawing.Point(12, 371);
            this.btn_aplicaCredit.Name = "btn_aplicaCredit";
            this.btn_aplicaCredit.Size = new System.Drawing.Size(210, 34);
            this.btn_aplicaCredit.TabIndex = 8;
            this.btn_aplicaCredit.Text = "&Aplica pentru credit";
            this.btn_aplicaCredit.UseVisualStyleBackColor = true;
            this.btn_aplicaCredit.Click += new System.EventHandler(this.btn_aplicaCredit_Click);
            // 
            // lb_perioadaCredit
            // 
            this.lb_perioadaCredit.AutoSize = true;
            this.lb_perioadaCredit.Location = new System.Drawing.Point(14, 83);
            this.lb_perioadaCredit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_perioadaCredit.Name = "lb_perioadaCredit";
            this.lb_perioadaCredit.Size = new System.Drawing.Size(115, 20);
            this.lb_perioadaCredit.TabIndex = 6;
            this.lb_perioadaCredit.Text = "Perioada credit";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // CreditNou
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 422);
            this.Controls.Add(this.btn_aplicaCredit);
            this.Controls.Add(this.lb_perioadaCredit);
            this.Controls.Add(this.lbPerioadaDeGratiere);
            this.Controls.Add(this.lbDataCredit);
            this.Controls.Add(this.cbStudent);
            this.Controls.Add(this.clbPerioadaDeGratiere);
            this.Controls.Add(this.clbPerioadaDeCreditare);
            this.Controls.Add(this.lbSumaAprobata);
            this.Controls.Add(this.tb_sumaCeruta);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CreditNou";
            this.Text = "CreditNou";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CreditNou_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_sumaCeruta;
        private System.Windows.Forms.Label lbSumaAprobata;
        private System.Windows.Forms.CheckedListBox clbPerioadaDeCreditare;
        private System.Windows.Forms.CheckBox cbStudent;
        private System.Windows.Forms.Label lbDataCredit;
        private System.Windows.Forms.CheckedListBox clbPerioadaDeGratiere;
        private System.Windows.Forms.Label lbPerioadaDeGratiere;
        private System.Windows.Forms.Button btn_aplicaCredit;
        private System.Windows.Forms.Label lb_perioadaCredit;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}