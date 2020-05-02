namespace Proiect_PAW_StroescuM
{
    partial class Login
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
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.lbPass = new System.Windows.Forms.Label();
            this.lbUser = new System.Windows.Forms.Label();
            this.nightModeMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modDeNoapteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lb_nightMode = new System.Windows.Forms.Label();
            this.nightModeMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(287, 251);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(230, 31);
            this.btnRegister.TabIndex = 0;
            this.btnRegister.Text = "&Inregistrare";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(287, 214);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(230, 31);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "&Logare";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tbUser
            // 
            this.tbUser.BackColor = System.Drawing.Color.White;
            this.tbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUser.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.tbUser.Location = new System.Drawing.Point(287, 147);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(230, 35);
            this.tbUser.TabIndex = 2;
            // 
            // tbPass
            // 
            this.tbPass.BackColor = System.Drawing.Color.White;
            this.tbPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPass.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.tbPass.Location = new System.Drawing.Point(287, 182);
            this.tbPass.Name = "tbPass";
            this.tbPass.PasswordChar = '*';
            this.tbPass.Size = new System.Drawing.Size(229, 35);
            this.tbPass.TabIndex = 3;
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPass.Location = new System.Drawing.Point(227, 185);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(83, 29);
            this.lbPass.TabIndex = 4;
            this.lbPass.Text = "Parola";
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.Location = new System.Drawing.Point(210, 150);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(106, 29);
            this.lbUser.TabIndex = 4;
            this.lbUser.Text = "Utilizator";
            // 
            // nightModeMenuStrip
            // 
            this.nightModeMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.nightModeMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modDeNoapteToolStripMenuItem});
            this.nightModeMenuStrip.Name = "contextMenuStrip1";
            this.nightModeMenuStrip.Size = new System.Drawing.Size(209, 36);
            // 
            // modDeNoapteToolStripMenuItem
            // 
            this.modDeNoapteToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.modDeNoapteToolStripMenuItem.Name = "modDeNoapteToolStripMenuItem";
            this.modDeNoapteToolStripMenuItem.Size = new System.Drawing.Size(208, 32);
            this.modDeNoapteToolStripMenuItem.Text = "Mod de noapte";
            this.modDeNoapteToolStripMenuItem.Click += new System.EventHandler(this.modDeNoapteToolStripMenuItem_Click);
            // 
            // lb_nightMode
            // 
            this.lb_nightMode.AutoSize = true;
            this.lb_nightMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nightMode.Location = new System.Drawing.Point(8, 428);
            this.lb_nightMode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_nightMode.Name = "lb_nightMode";
            this.lb_nightMode.Size = new System.Drawing.Size(653, 25);
            this.lb_nightMode.TabIndex = 5;
            this.lb_nightMode.Text = "**Pentru a activa modul de noapte, apasa click dreapta pe formular";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.nightModeMenuStrip;
            this.Controls.Add(this.lb_nightMode);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.lbPass);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnRegister);
            this.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Login";
            this.Text = "Login";
            this.nightModeMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.ContextMenuStrip nightModeMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem modDeNoapteToolStripMenuItem;
        private System.Windows.Forms.Label lb_nightMode;
    }
}

