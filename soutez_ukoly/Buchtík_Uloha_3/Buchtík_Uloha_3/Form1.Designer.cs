namespace Buchtík_Uloha_3
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
            this.label2 = new System.Windows.Forms.Label();
            this.labelVypisCisel = new System.Windows.Forms.Label();
            this.buttonVybratSoubor = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelAritPrumer = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelMedian = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelPocetPrvocisel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelDokonaleCislo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Úloha 3.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(14, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Výpis čísel ze souboru:";
            // 
            // labelVypisCisel
            // 
            this.labelVypisCisel.AutoSize = true;
            this.labelVypisCisel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelVypisCisel.Location = new System.Drawing.Point(203, 120);
            this.labelVypisCisel.Name = "labelVypisCisel";
            this.labelVypisCisel.Size = new System.Drawing.Size(123, 24);
            this.labelVypisCisel.TabIndex = 2;
            this.labelVypisCisel.Text = "labelVypisCisel";
            // 
            // buttonVybratSoubor
            // 
            this.buttonVybratSoubor.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonVybratSoubor.Location = new System.Drawing.Point(18, 66);
            this.buttonVybratSoubor.Name = "buttonVybratSoubor";
            this.buttonVybratSoubor.Size = new System.Drawing.Size(158, 39);
            this.buttonVybratSoubor.TabIndex = 3;
            this.buttonVybratSoubor.Text = "Vybrat soubor";
            this.buttonVybratSoubor.UseVisualStyleBackColor = true;
            this.buttonVybratSoubor.Click += new System.EventHandler(this.buttonVybratSoubor_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Aritmetický průměr:";
            // 
            // labelAritPrumer
            // 
            this.labelAritPrumer.AutoSize = true;
            this.labelAritPrumer.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAritPrumer.Location = new System.Drawing.Point(203, 158);
            this.labelAritPrumer.Name = "labelAritPrumer";
            this.labelAritPrumer.Size = new System.Drawing.Size(134, 24);
            this.labelAritPrumer.TabIndex = 5;
            this.labelAritPrumer.Text = "labelAritPrumer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(14, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Medián:";
            // 
            // labelMedian
            // 
            this.labelMedian.AutoSize = true;
            this.labelMedian.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMedian.Location = new System.Drawing.Point(203, 197);
            this.labelMedian.Name = "labelMedian";
            this.labelMedian.Size = new System.Drawing.Size(101, 24);
            this.labelMedian.TabIndex = 7;
            this.labelMedian.Text = "labelMedian";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(14, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Počet prvočísel:";
            // 
            // labelPocetPrvocisel
            // 
            this.labelPocetPrvocisel.AutoSize = true;
            this.labelPocetPrvocisel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPocetPrvocisel.Location = new System.Drawing.Point(203, 235);
            this.labelPocetPrvocisel.Name = "labelPocetPrvocisel";
            this.labelPocetPrvocisel.Size = new System.Drawing.Size(161, 24);
            this.labelPocetPrvocisel.TabIndex = 9;
            this.labelPocetPrvocisel.Text = "labelPocetPrvocisel";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(14, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Dokonalé číslo:";
            // 
            // labelDokonaleCislo
            // 
            this.labelDokonaleCislo.AutoSize = true;
            this.labelDokonaleCislo.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDokonaleCislo.Location = new System.Drawing.Point(203, 275);
            this.labelDokonaleCislo.Name = "labelDokonaleCislo";
            this.labelDokonaleCislo.Size = new System.Drawing.Size(154, 24);
            this.labelDokonaleCislo.TabIndex = 11;
            this.labelDokonaleCislo.Text = "labelDokonaleCislo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 744);
            this.Controls.Add(this.labelDokonaleCislo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelPocetPrvocisel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelMedian);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelAritPrumer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonVybratSoubor);
            this.Controls.Add(this.labelVypisCisel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelVypisCisel;
        private System.Windows.Forms.Button buttonVybratSoubor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelAritPrumer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelMedian;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelPocetPrvocisel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelDokonaleCislo;
    }
}

