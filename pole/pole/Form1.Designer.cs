
namespace pole
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
            this.buttonVysledek = new System.Windows.Forms.Button();
            this.textBoxCislo = new System.Windows.Forms.TextBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.labelPopis = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonVysledek
            // 
            this.buttonVysledek.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVysledek.Location = new System.Drawing.Point(167, 58);
            this.buttonVysledek.Name = "buttonVysledek";
            this.buttonVysledek.Size = new System.Drawing.Size(75, 23);
            this.buttonVysledek.TabIndex = 0;
            this.buttonVysledek.Text = "Výpis";
            this.buttonVysledek.UseVisualStyleBackColor = true;
            this.buttonVysledek.Click += new System.EventHandler(this.buttonVysledek_Click);
            // 
            // textBoxCislo
            // 
            this.textBoxCislo.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxCislo.Location = new System.Drawing.Point(61, 58);
            this.textBoxCislo.Name = "textBoxCislo";
            this.textBoxCislo.Size = new System.Drawing.Size(100, 23);
            this.textBoxCislo.TabIndex = 1;
            // 
            // buttonReset
            // 
            this.buttonReset.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.Location = new System.Drawing.Point(248, 58);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 2;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            // 
            // labelPopis
            // 
            this.labelPopis.AutoSize = true;
            this.labelPopis.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPopis.Location = new System.Drawing.Point(12, 61);
            this.labelPopis.Name = "labelPopis";
            this.labelPopis.Size = new System.Drawing.Size(43, 16);
            this.labelPopis.TabIndex = 3;
            this.labelPopis.Text = "Cislo A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pole - Uložení a výpis čísel";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 167);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelPopis);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.textBoxCislo);
            this.Controls.Add(this.buttonVysledek);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonVysledek;
        private System.Windows.Forms.TextBox textBoxCislo;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label labelPopis;
        private System.Windows.Forms.Label label2;
    }
}

