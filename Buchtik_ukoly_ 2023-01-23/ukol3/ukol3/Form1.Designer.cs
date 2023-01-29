namespace ukol3
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCisla = new System.Windows.Forms.TextBox();
            this.buttonZadat = new System.Windows.Forms.Button();
            this.listBoxCisla = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Úkol 3.";
            // 
            // textBoxCisla
            // 
            this.textBoxCisla.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxCisla.Location = new System.Drawing.Point(12, 41);
            this.textBoxCisla.Name = "textBoxCisla";
            this.textBoxCisla.Size = new System.Drawing.Size(100, 23);
            this.textBoxCisla.TabIndex = 1;
            // 
            // buttonZadat
            // 
            this.buttonZadat.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonZadat.Location = new System.Drawing.Point(118, 41);
            this.buttonZadat.Name = "buttonZadat";
            this.buttonZadat.Size = new System.Drawing.Size(75, 23);
            this.buttonZadat.TabIndex = 2;
            this.buttonZadat.Text = "Zadat číslo";
            this.buttonZadat.UseVisualStyleBackColor = true;
            this.buttonZadat.Click += new System.EventHandler(this.buttonZadat_Click);
            // 
            // listBoxCisla
            // 
            this.listBoxCisla.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBoxCisla.FormattingEnabled = true;
            this.listBoxCisla.ItemHeight = 16;
            this.listBoxCisla.Location = new System.Drawing.Point(12, 70);
            this.listBoxCisla.Name = "listBoxCisla";
            this.listBoxCisla.Size = new System.Drawing.Size(181, 164);
            this.listBoxCisla.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 243);
            this.Controls.Add(this.listBoxCisla);
            this.Controls.Add(this.buttonZadat);
            this.Controls.Add(this.textBoxCisla);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCisla;
        private System.Windows.Forms.Button buttonZadat;
        private System.Windows.Forms.ListBox listBoxCisla;
    }
}

