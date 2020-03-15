namespace Proiect_PAW_StroescuM
{
    partial class Register
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
            this.tbNume = new System.Windows.Forms.TextBox();
            this.tbPrenume = new System.Windows.Forms.TextBox();
            this.tbCNP = new System.Windows.Forms.TextBox();
            this.lbNume = new System.Windows.Forms.Label();
            this.lbPrenume = new System.Windows.Forms.Label();
            this.lbCNP = new System.Windows.Forms.Label();
            this.lbDataNasterii = new System.Windows.Forms.Label();
            this.dateTimePicker_DataNasterii = new System.Windows.Forms.DateTimePicker();
            this.btnInregistrare = new System.Windows.Forms.Button();
            this.lbEmail = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lbPasswd = new System.Windows.Forms.Label();
            this.tb_passwd = new System.Windows.Forms.TextBox();
            this.cbStudent = new System.Windows.Forms.CheckBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(200, 117);
            this.tbNume.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(298, 26);
            this.tbNume.TabIndex = 0;
            this.tbNume.TextChanged += new System.EventHandler(this.tbNume_TextChanged);
            // 
            // tbPrenume
            // 
            this.tbPrenume.Location = new System.Drawing.Point(200, 191);
            this.tbPrenume.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPrenume.Name = "tbPrenume";
            this.tbPrenume.Size = new System.Drawing.Size(298, 26);
            this.tbPrenume.TabIndex = 1;
            // 
            // tbCNP
            // 
            this.tbCNP.Location = new System.Drawing.Point(200, 339);
            this.tbCNP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCNP.Name = "tbCNP";
            this.tbCNP.Size = new System.Drawing.Size(298, 26);
            this.tbCNP.TabIndex = 2;
            // 
            // lbNume
            // 
            this.lbNume.AutoSize = true;
            this.lbNume.Location = new System.Drawing.Point(200, 83);
            this.lbNume.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNume.Name = "lbNume";
            this.lbNume.Size = new System.Drawing.Size(55, 20);
            this.lbNume.TabIndex = 4;
            this.lbNume.Text = "Nume ";
            // 
            // lbPrenume
            // 
            this.lbPrenume.AutoSize = true;
            this.lbPrenume.Location = new System.Drawing.Point(200, 157);
            this.lbPrenume.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPrenume.Name = "lbPrenume";
            this.lbPrenume.Size = new System.Drawing.Size(73, 20);
            this.lbPrenume.TabIndex = 5;
            this.lbPrenume.Text = "Prenume";
            // 
            // lbCNP
            // 
            this.lbCNP.AutoSize = true;
            this.lbCNP.Location = new System.Drawing.Point(200, 305);
            this.lbCNP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCNP.Name = "lbCNP";
            this.lbCNP.Size = new System.Drawing.Size(41, 20);
            this.lbCNP.TabIndex = 6;
            this.lbCNP.Text = "CNP";
            // 
            // lbDataNasterii
            // 
            this.lbDataNasterii.AutoSize = true;
            this.lbDataNasterii.Location = new System.Drawing.Point(200, 453);
            this.lbDataNasterii.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDataNasterii.Name = "lbDataNasterii";
            this.lbDataNasterii.Size = new System.Drawing.Size(101, 20);
            this.lbDataNasterii.TabIndex = 7;
            this.lbDataNasterii.Text = "Data Nasterii";
            // 
            // dateTimePicker_DataNasterii
            // 
            this.dateTimePicker_DataNasterii.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_DataNasterii.Location = new System.Drawing.Point(200, 487);
            this.dateTimePicker_DataNasterii.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker_DataNasterii.Name = "dateTimePicker_DataNasterii";
            this.dateTimePicker_DataNasterii.Size = new System.Drawing.Size(113, 26);
            this.dateTimePicker_DataNasterii.TabIndex = 8;
            // 
            // btnInregistrare
            // 
            this.btnInregistrare.Location = new System.Drawing.Point(200, 565);
            this.btnInregistrare.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInregistrare.Name = "btnInregistrare";
            this.btnInregistrare.Size = new System.Drawing.Size(298, 45);
            this.btnInregistrare.TabIndex = 9;
            this.btnInregistrare.Text = "Inregistrare";
            this.btnInregistrare.UseVisualStyleBackColor = true;
            this.btnInregistrare.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(200, 231);
            this.lbEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(48, 20);
            this.lbEmail.TabIndex = 11;
            this.lbEmail.Text = "Email";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(200, 265);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(298, 26);
            this.tbEmail.TabIndex = 10;
            // 
            // lbPasswd
            // 
            this.lbPasswd.AutoSize = true;
            this.lbPasswd.Location = new System.Drawing.Point(200, 379);
            this.lbPasswd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPasswd.Name = "lbPasswd";
            this.lbPasswd.Size = new System.Drawing.Size(54, 20);
            this.lbPasswd.TabIndex = 13;
            this.lbPasswd.Text = "Parola";
            // 
            // tb_passwd
            // 
            this.tb_passwd.Location = new System.Drawing.Point(200, 413);
            this.tb_passwd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_passwd.Name = "tb_passwd";
            this.tb_passwd.Size = new System.Drawing.Size(298, 26);
            this.tb_passwd.TabIndex = 12;
            // 
            // cbStudent
            // 
            this.cbStudent.AutoSize = true;
            this.cbStudent.Location = new System.Drawing.Point(200, 527);
            this.cbStudent.Name = "cbStudent";
            this.cbStudent.Size = new System.Drawing.Size(92, 24);
            this.cbStudent.TabIndex = 14;
            this.cbStudent.Text = "Student";
            this.cbStudent.UseVisualStyleBackColor = true;
            this.cbStudent.CheckedChanged += new System.EventHandler(this.cbStudent_CheckedChanged);
            this.cbStudent.CheckStateChanged += new System.EventHandler(this.cbStudent_CheckStateChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkRate = 100;
            this.errorProvider1.ContainerControl = this;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 701);
            this.Controls.Add(this.cbStudent);
            this.Controls.Add(this.lbPasswd);
            this.Controls.Add(this.tb_passwd);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.btnInregistrare);
            this.Controls.Add(this.dateTimePicker_DataNasterii);
            this.Controls.Add(this.lbDataNasterii);
            this.Controls.Add(this.lbCNP);
            this.Controls.Add(this.lbPrenume);
            this.Controls.Add(this.lbNume);
            this.Controls.Add(this.tbCNP);
            this.Controls.Add(this.tbPrenume);
            this.Controls.Add(this.tbNume);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Register";
            this.Text = "Register";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.TextBox tbPrenume;
        private System.Windows.Forms.TextBox tbCNP;
        private System.Windows.Forms.Label lbNume;
        private System.Windows.Forms.Label lbPrenume;
        private System.Windows.Forms.Label lbCNP;
        private System.Windows.Forms.Label lbDataNasterii;
        private System.Windows.Forms.DateTimePicker dateTimePicker_DataNasterii;
        private System.Windows.Forms.Button btnInregistrare;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lbPasswd;
        private System.Windows.Forms.TextBox tb_passwd;
        private System.Windows.Forms.CheckBox cbStudent;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}