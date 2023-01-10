
namespace fyzikální_měření
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
            this.buttonVyska = new System.Windows.Forms.Button();
            this.textBoxVyska = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCas = new System.Windows.Forms.TextBox();
            this.buttonCas = new System.Windows.Forms.Button();
            this.labelPrumerCas = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.labelTihovaSila = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonVyska
            // 
            this.buttonVyska.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVyska.Location = new System.Drawing.Point(198, 44);
            this.buttonVyska.Name = "buttonVyska";
            this.buttonVyska.Size = new System.Drawing.Size(85, 23);
            this.buttonVyska.TabIndex = 0;
            this.buttonVyska.Text = "Zadat výšku";
            this.buttonVyska.UseVisualStyleBackColor = true;
            this.buttonVyska.Click += new System.EventHandler(this.buttonVyska_Click);
            // 
            // textBoxVyska
            // 
            this.textBoxVyska.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxVyska.Location = new System.Drawing.Point(92, 44);
            this.textBoxVyska.Name = "textBoxVyska";
            this.textBoxVyska.Size = new System.Drawing.Size(100, 23);
            this.textBoxVyska.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Výška [m]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fyzikálí měření tíhové síly";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Doba pádu [s]";
            // 
            // textBoxCas
            // 
            this.textBoxCas.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCas.Location = new System.Drawing.Point(92, 76);
            this.textBoxCas.Name = "textBoxCas";
            this.textBoxCas.Size = new System.Drawing.Size(100, 23);
            this.textBoxCas.TabIndex = 5;
            // 
            // buttonCas
            // 
            this.buttonCas.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCas.Location = new System.Drawing.Point(198, 76);
            this.buttonCas.Name = "buttonCas";
            this.buttonCas.Size = new System.Drawing.Size(85, 23);
            this.buttonCas.TabIndex = 6;
            this.buttonCas.Text = "Zadat čas";
            this.buttonCas.UseVisualStyleBackColor = true;
            this.buttonCas.Click += new System.EventHandler(this.buttonCas_Click);
            // 
            // labelPrumerCas
            // 
            this.labelPrumerCas.AutoSize = true;
            this.labelPrumerCas.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrumerCas.Location = new System.Drawing.Point(150, 114);
            this.labelPrumerCas.Name = "labelPrumerCas";
            this.labelPrumerCas.Size = new System.Drawing.Size(64, 16);
            this.labelPrumerCas.TabIndex = 8;
            this.labelPrumerCas.Text = "prumerCas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Průměrná doba pádu [N]:";
            // 
            // buttonReset
            // 
            this.buttonReset.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.Location = new System.Drawing.Point(16, 164);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(267, 23);
            this.buttonReset.TabIndex = 10;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(65, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tíhová síla [N]:";
            // 
            // labelTihovaSila
            // 
            this.labelTihovaSila.AutoSize = true;
            this.labelTihovaSila.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTihovaSila.Location = new System.Drawing.Point(150, 132);
            this.labelTihovaSila.Name = "labelTihovaSila";
            this.labelTihovaSila.Size = new System.Drawing.Size(57, 16);
            this.labelTihovaSila.TabIndex = 12;
            this.labelTihovaSila.Text = "tihovaSila";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 197);
            this.Controls.Add(this.labelTihovaSila);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelPrumerCas);
            this.Controls.Add(this.buttonCas);
            this.Controls.Add(this.textBoxCas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxVyska);
            this.Controls.Add(this.buttonVyska);
            this.Name = "Form1";
            this.Text = "Fyzikální měření - výpočet tíhové síly";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonVyska;
        private System.Windows.Forms.TextBox textBoxVyska;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCas;
        private System.Windows.Forms.Button buttonCas;
        private System.Windows.Forms.Label labelPrumerCas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelTihovaSila;
    }
}

