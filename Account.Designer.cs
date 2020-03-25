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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Account));
            this.lbUser_Logged = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.CrediteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contractareCreditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbCreditePeRol = new System.Windows.Forms.Label();
            this.lvCredite = new System.Windows.Forms.ListView();
            this.colrNrCrt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDataCredit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSuma = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPerioada = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDobanda = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTotalPlata = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRataDobanzii = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbUser_Logged
            // 
            this.lbUser_Logged.AutoSize = true;
            this.lbUser_Logged.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser_Logged.Location = new System.Drawing.Point(69, 78);
            this.lbUser_Logged.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUser_Logged.Name = "lbUser_Logged";
            this.lbUser_Logged.Size = new System.Drawing.Size(198, 37);
            this.lbUser_Logged.TabIndex = 0;
            this.lbUser_Logged.Text = "Bine ai venit,";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CrediteToolStripMenuItem,
            this.salvareToolStripMenuItem,
            this.restaurareToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.printToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1200, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // CrediteToolStripMenuItem
            // 
            this.CrediteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contractareCreditToolStripMenuItem});
            this.CrediteToolStripMenuItem.Name = "CrediteToolStripMenuItem";
            this.CrediteToolStripMenuItem.Size = new System.Drawing.Size(84, 29);
            this.CrediteToolStripMenuItem.Text = "&Credite";
            // 
            // contractareCreditToolStripMenuItem
            // 
            this.contractareCreditToolStripMenuItem.Name = "contractareCreditToolStripMenuItem";
            this.contractareCreditToolStripMenuItem.Size = new System.Drawing.Size(257, 34);
            this.contractareCreditToolStripMenuItem.Text = "Contractare Credit";
            this.contractareCreditToolStripMenuItem.Click += new System.EventHandler(this.contractareCreditToolStripMenuItem_Click);
            // 
            // salvareToolStripMenuItem
            // 
            this.salvareToolStripMenuItem.Name = "salvareToolStripMenuItem";
            this.salvareToolStripMenuItem.Size = new System.Drawing.Size(84, 29);
            this.salvareToolStripMenuItem.Text = "&Salvare";
            this.salvareToolStripMenuItem.Click += new System.EventHandler(this.salvareToolStripMenuItem_Click);
            // 
            // restaurareToolStripMenuItem
            // 
            this.restaurareToolStripMenuItem.Name = "restaurareToolStripMenuItem";
            this.restaurareToolStripMenuItem.Size = new System.Drawing.Size(110, 29);
            this.restaurareToolStripMenuItem.Text = "&Restaurare";
            this.restaurareToolStripMenuItem.Click += new System.EventHandler(this.restaurareToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(85, 29);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(64, 29);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // lbCreditePeRol
            // 
            this.lbCreditePeRol.AutoSize = true;
            this.lbCreditePeRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreditePeRol.Location = new System.Drawing.Point(69, 137);
            this.lbCreditePeRol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCreditePeRol.Name = "lbCreditePeRol";
            this.lbCreditePeRol.Size = new System.Drawing.Size(208, 37);
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
            this.lvCredite.Location = new System.Drawing.Point(75, 196);
            this.lvCredite.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lvCredite.Name = "lvCredite";
            this.lvCredite.Size = new System.Drawing.Size(848, 419);
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
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(75, 637);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(848, 31);
            this.progressBar.TabIndex = 16;
            this.progressBar.Visible = false;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.lvCredite);
            this.Controls.Add(this.lbCreditePeRol);
            this.Controls.Add(this.lbUser_Logged);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Account";
            this.Text = "Account";
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
        private System.Windows.Forms.ToolStripMenuItem salvareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaurareToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}