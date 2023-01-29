namespace ukol1
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
            this.buttonZadatPocetCisel = new System.Windows.Forms.Button();
            this.textBoxPocetZadanychCisel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxZadCislo = new System.Windows.Forms.TextBox();
            this.buttonZadatCislo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxCisla = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Úkol 1";
            // 
            // buttonZadatPocetCisel
            // 
            this.buttonZadatPocetCisel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonZadatPocetCisel.Location = new System.Drawing.Point(122, 85);
            this.buttonZadatPocetCisel.Name = "buttonZadatPocetCisel";
            this.buttonZadatPocetCisel.Size = new System.Drawing.Size(75, 23);
            this.buttonZadatPocetCisel.TabIndex = 1;
            this.buttonZadatPocetCisel.Text = "Zadat";
            this.buttonZadatPocetCisel.UseVisualStyleBackColor = true;
            this.buttonZadatPocetCisel.Click += new System.EventHandler(this.buttonZadatPocetCisel_Click);
            // 
            // textBoxPocetZadanychCisel
            // 
            this.textBoxPocetZadanychCisel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPocetZadanychCisel.Location = new System.Drawing.Point(16, 85);
            this.textBoxPocetZadanychCisel.Name = "textBoxPocetZadanychCisel";
            this.textBoxPocetZadanychCisel.Size = new System.Drawing.Size(100, 23);
            this.textBoxPocetZadanychCisel.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(13, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kolik bude zadaných čísel:";
            // 
            // textBoxZadCislo
            // 
            this.textBoxZadCislo.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxZadCislo.Location = new System.Drawing.Point(53, 118);
            this.textBoxZadCislo.Name = "textBoxZadCislo";
            this.textBoxZadCislo.Size = new System.Drawing.Size(100, 23);
            this.textBoxZadCislo.TabIndex = 5;
            // 
            // buttonZadatCislo
            // 
            this.buttonZadatCislo.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonZadatCislo.Location = new System.Drawing.Point(159, 118);
            this.buttonZadatCislo.Name = "buttonZadatCislo";
            this.buttonZadatCislo.Size = new System.Drawing.Size(75, 23);
            this.buttonZadatCislo.TabIndex = 4;
            this.buttonZadatCislo.Text = "Zadat";
            this.buttonZadatCislo.UseVisualStyleBackColor = true;
            this.buttonZadatCislo.Click += new System.EventHandler(this.buttonZadatCislo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(13, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Číslo:";
            // 
            // listBoxCisla
            // 
            this.listBoxCisla.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBoxCisla.FormattingEnabled = true;
            this.listBoxCisla.ItemHeight = 16;
            this.listBoxCisla.Location = new System.Drawing.Point(240, 9);
            this.listBoxCisla.Name = "listBoxCisla";
            this.listBoxCisla.Size = new System.Drawing.Size(120, 132);
            this.listBoxCisla.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 153);
            this.Controls.Add(this.listBoxCisla);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxZadCislo);
            this.Controls.Add(this.buttonZadatCislo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPocetZadanychCisel);
            this.Controls.Add(this.buttonZadatPocetCisel);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonZadatPocetCisel;
        private System.Windows.Forms.TextBox textBoxPocetZadanychCisel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxZadCislo;
        private System.Windows.Forms.Button buttonZadatCislo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxCisla;
    }
}

