namespace Proiect_PAW_StroescuM
{
    partial class Account
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
            this.lbUser_Logged = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.CrediteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contractareCreditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbCreditePeRol = new System.Windows.Forms.Label();
            this.lvCredite = new System.Windows.Forms.ListView();
            this.colrNrCrt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDataCredit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSuma = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPerioada = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDobanda = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTotalPlata = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRataDobanzii = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbUser_Logged
            // 
            this.lbUser_Logged.AutoSize = true;
            this.lbUser_Logged.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser_Logged.Location = new System.Drawing.Point(46, 51);
            this.lbUser_Logged.Name = "lbUser_Logged";
            this.lbUser_Logged.Size = new System.Drawing.Size(136, 25);
            this.lbUser_Logged.TabIndex = 0;
            this.lbUser_Logged.Text = "Bine ai venit,";
            this.lbUser_Logged.Click += new System.EventHandler(this.lbUser_Logged_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CrediteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // CrediteToolStripMenuItem
            // 
            this.CrediteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contractareCreditToolStripMenuItem});
            this.CrediteToolStripMenuItem.Name = "CrediteToolStripMenuItem";
            this.CrediteToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.CrediteToolStripMenuItem.Text = "Credite";
            this.CrediteToolStripMenuItem.Click += new System.EventHandler(this.CrediteToolStripMenuItem_Click);
            // 
            // contractareCreditToolStripMenuItem
            // 
            this.contractareCreditToolStripMenuItem.Name = "contractareCreditToolStripMenuItem";
            this.contractareCreditToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.contractareCreditToolStripMenuItem.Text = "Contractare Credit";
            this.contractareCreditToolStripMenuItem.Click += new System.EventHandler(this.contractareCreditToolStripMenuItem_Click);
            // 
            // lbCreditePeRol
            // 
            this.lbCreditePeRol.AutoSize = true;
            this.lbCreditePeRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreditePeRol.Location = new System.Drawing.Point(46, 93);
            this.lbCreditePeRol.Name = "lbCreditePeRol";
            this.lbCreditePeRol.Size = new System.Drawing.Size(141, 25);
            this.lbCreditePeRol.TabIndex = 2;
            this.lbCreditePeRol.Text = "Credite pe rol";
            // 
            // lvCredite
            // 
            this.lvCredite.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colrNrCrt,
            this.colDataCredit,
            this.colSuma,
            this.colPerioada,
            this.colDobanda,
            this.colTotalPlata,
            this.colRataDobanzii});
            this.lvCredite.FullRowSelect = true;
            this.lvCredite.HideSelection = false;
            this.lvCredite.Location = new System.Drawing.Point(50, 138);
            this.lvCredite.Name = "lvCredite";
            this.lvCredite.Size = new System.Drawing.Size(567, 274);
            this.lvCredite.TabIndex = 3;
            this.lvCredite.UseCompatibleStateImageBehavior = false;
            this.lvCredite.View = System.Windows.Forms.View.Details;
            // 
            // colrNrCrt
            // 
            this.colrNrCrt.Text = "Nr.Crt";
            this.colrNrCrt.Width = 43;
            // 
            // colDataCredit
            // 
            this.colDataCredit.Text = "Data de contractare";
            this.colDataCredit.Width = 117;
            // 
            // colSuma
            // 
            this.colSuma.Text = "Suma Aprobata";
            this.colSuma.Width = 89;
            // 
            // colPerioada
            // 
            this.colPerioada.Text = "Perioada";
            // 
            // colDobanda
            // 
            this.colDobanda.Text = "Dobanda";
            // 
            // colTotalPlata
            // 
            this.colTotalPlata.Text = "Total de plata";
            this.colTotalPlata.Width = 86;
            // 
            // colRataDobanzii
            // 
            this.colRataDobanzii.Text = "Rata Dobanzii";
            this.colRataDobanzii.Width = 106;
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvCredite);
            this.Controls.Add(this.lbCreditePeRol);
            this.Controls.Add(this.lbUser_Logged);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Account";
            this.Text = "Account";
            this.Load += new System.EventHandler(this.Account_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbUser_Logged;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem CrediteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contractareCreditToolStripMenuItem;
        private System.Windows.Forms.Label lbCreditePeRol;
        private System.Windows.Forms.ListView lvCredite;
        private System.Windows.Forms.ColumnHeader colrNrCrt;
        private System.Windows.Forms.ColumnHeader colDataCredit;
        private System.Windows.Forms.ColumnHeader colSuma;
        private System.Windows.Forms.ColumnHeader colPerioada;
        private System.Windows.Forms.ColumnHeader colDobanda;
        private System.Windows.Forms.ColumnHeader colTotalPlata;
        private System.Windows.Forms.ColumnHeader colRataDobanzii;
    }
}