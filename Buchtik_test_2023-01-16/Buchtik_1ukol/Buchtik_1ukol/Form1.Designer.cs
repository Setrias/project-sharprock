
namespace Buchtik_1ukol
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
            this.textBoxCislo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonZadat = new System.Windows.Forms.Button();
            this.radioButtonMocnina = new System.Windows.Forms.RadioButton();
            this.radioButtonOdmocnina = new System.Windows.Forms.RadioButton();
            this.radioButtonLog = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.labelVysledek = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxCislo
            // 
            this.textBoxCislo.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCislo.Location = new System.Drawing.Point(12, 47);
            this.textBoxCislo.Name = "textBoxCislo";
            this.textBoxCislo.Size = new System.Drawing.Size(100, 23);
            this.textBoxCislo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Úkol 1.";
            // 
            // buttonZadat
            // 
            this.buttonZadat.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonZadat.Location = new System.Drawing.Point(118, 47);
            this.buttonZadat.Name = "buttonZadat";
            this.buttonZadat.Size = new System.Drawing.Size(75, 23);
            this.buttonZadat.TabIndex = 2;
            this.buttonZadat.Text = "Zadat";
            this.buttonZadat.UseVisualStyleBackColor = true;
            this.buttonZadat.Click += new System.EventHandler(this.buttonZadat_Click);
            // 
            // radioButtonMocnina
            // 
            this.radioButtonMocnina.AutoSize = true;
            this.radioButtonMocnina.Checked = true;
            this.radioButtonMocnina.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMocnina.Location = new System.Drawing.Point(12, 85);
            this.radioButtonMocnina.Name = "radioButtonMocnina";
            this.radioButtonMocnina.Size = new System.Drawing.Size(102, 20);
            this.radioButtonMocnina.TabIndex = 3;
            this.radioButtonMocnina.TabStop = true;
            this.radioButtonMocnina.Text = "Druhá mocnina";
            this.radioButtonMocnina.UseVisualStyleBackColor = true;
            // 
            // radioButtonOdmocnina
            // 
            this.radioButtonOdmocnina.AutoSize = true;
            this.radioButtonOdmocnina.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonOdmocnina.Location = new System.Drawing.Point(12, 111);
            this.radioButtonOdmocnina.Name = "radioButtonOdmocnina";
            this.radioButtonOdmocnina.Size = new System.Drawing.Size(106, 20);
            this.radioButtonOdmocnina.TabIndex = 4;
            this.radioButtonOdmocnina.TabStop = true;
            this.radioButtonOdmocnina.Text = "Třetí odmocnina";
            this.radioButtonOdmocnina.UseVisualStyleBackColor = true;
            // 
            // radioButtonLog
            // 
            this.radioButtonLog.AutoSize = true;
            this.radioButtonLog.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonLog.Location = new System.Drawing.Point(12, 137);
            this.radioButtonLog.Name = "radioButtonLog";
            this.radioButtonLog.Size = new System.Drawing.Size(84, 20);
            this.radioButtonLog.TabIndex = 5;
            this.radioButtonLog.TabStop = true;
            this.radioButtonLog.Text = "Logaritmus";
            this.radioButtonLog.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Výsledek:";
            // 
            // labelVysledek
            // 
            this.labelVysledek.AutoSize = true;
            this.labelVysledek.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVysledek.Location = new System.Drawing.Point(81, 170);
            this.labelVysledek.Name = "labelVysledek";
            this.labelVysledek.Size = new System.Drawing.Size(95, 19);
            this.labelVysledek.TabIndex = 7;
            this.labelVysledek.Text = "labelVysledek";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 200);
            this.Controls.Add(this.labelVysledek);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButtonLog);
            this.Controls.Add(this.radioButtonOdmocnina);
            this.Controls.Add(this.radioButtonMocnina);
            this.Controls.Add(this.buttonZadat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCislo);
            this.Name = "Form1";
            this.Text = "Počty";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCislo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonZadat;
        private System.Windows.Forms.RadioButton radioButtonMocnina;
        private System.Windows.Forms.RadioButton radioButtonOdmocnina;
        private System.Windows.Forms.RadioButton radioButtonLog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelVysledek;
    }
}

