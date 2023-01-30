
namespace pole_v4_2023_01_30
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
            this.textBoxPocetCisel = new System.Windows.Forms.TextBox();
            this.buttonPocetCisel = new System.Windows.Forms.Button();
            this.buttonZadatCisla = new System.Windows.Forms.Button();
            this.textBoxCisla = new System.Windows.Forms.TextBox();
            this.listBoxCisla = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pole v4";
            // 
            // textBoxPocetCisel
            // 
            this.textBoxPocetCisel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPocetCisel.Location = new System.Drawing.Point(16, 42);
            this.textBoxPocetCisel.Name = "textBoxPocetCisel";
            this.textBoxPocetCisel.Size = new System.Drawing.Size(100, 23);
            this.textBoxPocetCisel.TabIndex = 1;
            // 
            // buttonPocetCisel
            // 
            this.buttonPocetCisel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPocetCisel.Location = new System.Drawing.Point(122, 42);
            this.buttonPocetCisel.Name = "buttonPocetCisel";
            this.buttonPocetCisel.Size = new System.Drawing.Size(107, 23);
            this.buttonPocetCisel.TabIndex = 2;
            this.buttonPocetCisel.Text = "Zadat počet čísel";
            this.buttonPocetCisel.UseVisualStyleBackColor = true;
            this.buttonPocetCisel.Click += new System.EventHandler(this.buttonPocetCisel_Click);
            // 
            // buttonZadatCisla
            // 
            this.buttonZadatCisla.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonZadatCisla.Location = new System.Drawing.Point(122, 86);
            this.buttonZadatCisla.Name = "buttonZadatCisla";
            this.buttonZadatCisla.Size = new System.Drawing.Size(107, 23);
            this.buttonZadatCisla.TabIndex = 4;
            this.buttonZadatCisla.Text = "Zadat číslo";
            this.buttonZadatCisla.UseVisualStyleBackColor = true;
            this.buttonZadatCisla.Click += new System.EventHandler(this.buttonZadatCisla_Click);
            // 
            // textBoxCisla
            // 
            this.textBoxCisla.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxCisla.Location = new System.Drawing.Point(16, 86);
            this.textBoxCisla.Name = "textBoxCisla";
            this.textBoxCisla.Size = new System.Drawing.Size(100, 23);
            this.textBoxCisla.TabIndex = 3;
            // 
            // listBoxCisla
            // 
            this.listBoxCisla.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBoxCisla.FormattingEnabled = true;
            this.listBoxCisla.ItemHeight = 16;
            this.listBoxCisla.Location = new System.Drawing.Point(235, 14);
            this.listBoxCisla.Name = "listBoxCisla";
            this.listBoxCisla.Size = new System.Drawing.Size(120, 148);
            this.listBoxCisla.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 186);
            this.Controls.Add(this.listBoxCisla);
            this.Controls.Add(this.buttonZadatCisla);
            this.Controls.Add(this.textBoxCisla);
            this.Controls.Add(this.buttonPocetCisel);
            this.Controls.Add(this.textBoxPocetCisel);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPocetCisel;
        private System.Windows.Forms.Button buttonPocetCisel;
        private System.Windows.Forms.Button buttonZadatCisla;
        private System.Windows.Forms.TextBox textBoxCisla;
        private System.Windows.Forms.ListBox listBoxCisla;
    }
}

