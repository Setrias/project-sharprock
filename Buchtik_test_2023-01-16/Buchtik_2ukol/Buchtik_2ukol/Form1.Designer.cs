
namespace Buchtik_2ukol
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
            this.numericUpDownCislo = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonZadatPocet = new System.Windows.Forms.Button();
            this.textBoxPocet = new System.Windows.Forms.TextBox();
            this.buttonZadatCislo = new System.Windows.Forms.Button();
            this.labelPopisZadat = new System.Windows.Forms.Label();
            this.labelPopisVysledek = new System.Windows.Forms.Label();
            this.labelVysledek = new System.Windows.Forms.Label();
            this.listBoxCisla = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCislo)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownCislo
            // 
            this.numericUpDownCislo.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownCislo.Location = new System.Drawing.Point(150, 71);
            this.numericUpDownCislo.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownCislo.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            this.numericUpDownCislo.Name = "numericUpDownCislo";
            this.numericUpDownCislo.Size = new System.Drawing.Size(100, 30);
            this.numericUpDownCislo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Úkol 2.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(13, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kolik čísel chcete zadat:";
            // 
            // buttonZadatPocet
            // 
            this.buttonZadatPocet.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonZadatPocet.Location = new System.Drawing.Point(256, 39);
            this.buttonZadatPocet.Name = "buttonZadatPocet";
            this.buttonZadatPocet.Size = new System.Drawing.Size(75, 23);
            this.buttonZadatPocet.TabIndex = 3;
            this.buttonZadatPocet.Text = "Zadat";
            this.buttonZadatPocet.UseVisualStyleBackColor = true;
            this.buttonZadatPocet.Click += new System.EventHandler(this.buttonZadatPocet_Click);
            // 
            // textBoxPocet
            // 
            this.textBoxPocet.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPocet.Location = new System.Drawing.Point(150, 39);
            this.textBoxPocet.Name = "textBoxPocet";
            this.textBoxPocet.Size = new System.Drawing.Size(100, 23);
            this.textBoxPocet.TabIndex = 4;
            // 
            // buttonZadatCislo
            // 
            this.buttonZadatCislo.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonZadatCislo.Location = new System.Drawing.Point(256, 76);
            this.buttonZadatCislo.Name = "buttonZadatCislo";
            this.buttonZadatCislo.Size = new System.Drawing.Size(75, 23);
            this.buttonZadatCislo.TabIndex = 5;
            this.buttonZadatCislo.Text = "Zadat";
            this.buttonZadatCislo.UseVisualStyleBackColor = true;
            this.buttonZadatCislo.Click += new System.EventHandler(this.buttonZadatCislo_Click);
            // 
            // labelPopisZadat
            // 
            this.labelPopisZadat.AutoSize = true;
            this.labelPopisZadat.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPopisZadat.Location = new System.Drawing.Point(13, 79);
            this.labelPopisZadat.Name = "labelPopisZadat";
            this.labelPopisZadat.Size = new System.Drawing.Size(75, 16);
            this.labelPopisZadat.TabIndex = 6;
            this.labelPopisZadat.Text = "Zadejte číslo:";
            // 
            // labelPopisVysledek
            // 
            this.labelPopisVysledek.AutoSize = true;
            this.labelPopisVysledek.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPopisVysledek.Location = new System.Drawing.Point(13, 120);
            this.labelPopisVysledek.Name = "labelPopisVysledek";
            this.labelPopisVysledek.Size = new System.Drawing.Size(49, 16);
            this.labelPopisVysledek.TabIndex = 7;
            this.labelPopisVysledek.Text = "Průměr:";
            // 
            // labelVysledek
            // 
            this.labelVysledek.AutoSize = true;
            this.labelVysledek.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelVysledek.Location = new System.Drawing.Point(68, 120);
            this.labelVysledek.Name = "labelVysledek";
            this.labelVysledek.Size = new System.Drawing.Size(77, 16);
            this.labelVysledek.TabIndex = 8;
            this.labelVysledek.Text = "labelVysledek";
            // 
            // listBoxCisla
            // 
            this.listBoxCisla.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxCisla.FormattingEnabled = true;
            this.listBoxCisla.ItemHeight = 16;
            this.listBoxCisla.Location = new System.Drawing.Point(337, 9);
            this.listBoxCisla.Name = "listBoxCisla";
            this.listBoxCisla.Size = new System.Drawing.Size(120, 132);
            this.listBoxCisla.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 157);
            this.Controls.Add(this.listBoxCisla);
            this.Controls.Add(this.labelVysledek);
            this.Controls.Add(this.labelPopisVysledek);
            this.Controls.Add(this.labelPopisZadat);
            this.Controls.Add(this.buttonZadatCislo);
            this.Controls.Add(this.textBoxPocet);
            this.Controls.Add(this.buttonZadatPocet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownCislo);
            this.Name = "Form1";
            this.Text = "Průměr čísel";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCislo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownCislo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonZadatPocet;
        private System.Windows.Forms.TextBox textBoxPocet;
        private System.Windows.Forms.Button buttonZadatCislo;
        private System.Windows.Forms.Label labelPopisZadat;
        private System.Windows.Forms.Label labelPopisVysledek;
        private System.Windows.Forms.Label labelVysledek;
        private System.Windows.Forms.ListBox listBoxCisla;
    }
}

