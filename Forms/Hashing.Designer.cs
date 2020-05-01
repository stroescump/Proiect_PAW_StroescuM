namespace Proiect_PAW_StroescuM.Forms
{
    partial class Hashing
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
            this.btnCriptare = new System.Windows.Forms.Button();
            this.tb_emailEncrypt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCriptare
            // 
            this.btnCriptare.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnCriptare.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnCriptare.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCriptare.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriptare.Location = new System.Drawing.Point(311, 221);
            this.btnCriptare.Name = "btnCriptare";
            this.btnCriptare.Size = new System.Drawing.Size(178, 49);
            this.btnCriptare.TabIndex = 0;
            this.btnCriptare.Text = "Criptare";
            this.btnCriptare.UseVisualStyleBackColor = true;
            this.btnCriptare.Click += new System.EventHandler(this.btnCriptare_Click);
            // 
            // tb_emailEncrypt
            // 
            this.tb_emailEncrypt.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tb_emailEncrypt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_emailEncrypt.Location = new System.Drawing.Point(194, 180);
            this.tb_emailEncrypt.Name = "tb_emailEncrypt";
            this.tb_emailEncrypt.Size = new System.Drawing.Size(413, 26);
            this.tb_emailEncrypt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(770, 64);
            this.label1.TabIndex = 2;
            this.label1.Text = "Completati in campul de mai jos, adresa de email a destinatarului.\r\nAtentie, cara" +
    "cterele trebuie sa fie identice cu adresa acestuia!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Hashing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_emailEncrypt);
            this.Controls.Add(this.btnCriptare);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Hashing";
            this.Text = "Hasing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCriptare;
        private System.Windows.Forms.TextBox tb_emailEncrypt;
        private System.Windows.Forms.Label label1;
    }
}