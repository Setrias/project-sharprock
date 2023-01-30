
namespace tvary_komplexniho_cisla
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
            this.buttonZadatHodnoty = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelAlgebTvar = new System.Windows.Forms.Label();
            this.labelGonioTvar = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelExponTvar = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownRealne = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownImaginarni = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonVypocet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRealne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownImaginarni)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tvary komplexního čísla";
            // 
            // buttonZadatHodnoty
            // 
            this.buttonZadatHodnoty.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonZadatHodnoty.Location = new System.Drawing.Point(203, 45);
            this.buttonZadatHodnoty.Name = "buttonZadatHodnoty";
            this.buttonZadatHodnoty.Size = new System.Drawing.Size(75, 52);
            this.buttonZadatHodnoty.TabIndex = 1;
            this.buttonZadatHodnoty.Text = "Zadat hodnoty";
            this.buttonZadatHodnoty.UseVisualStyleBackColor = true;
            this.buttonZadatHodnoty.Click += new System.EventHandler(this.buttonZadatHodnoty_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(80, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Algebraický tvar:";
            // 
            // labelAlgebTvar
            // 
            this.labelAlgebTvar.AutoSize = true;
            this.labelAlgebTvar.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAlgebTvar.Location = new System.Drawing.Point(194, 113);
            this.labelAlgebTvar.Name = "labelAlgebTvar";
            this.labelAlgebTvar.Size = new System.Drawing.Size(80, 16);
            this.labelAlgebTvar.TabIndex = 4;
            this.labelAlgebTvar.Text = "labelAlgebTvar";
            // 
            // labelGonioTvar
            // 
            this.labelGonioTvar.AutoSize = true;
            this.labelGonioTvar.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelGonioTvar.Location = new System.Drawing.Point(194, 138);
            this.labelGonioTvar.Name = "labelGonioTvar";
            this.labelGonioTvar.Size = new System.Drawing.Size(80, 16);
            this.labelGonioTvar.TabIndex = 6;
            this.labelGonioTvar.Text = "labelGonioTvar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(80, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Goniometrický tvar:";
            // 
            // labelExponTvar
            // 
            this.labelExponTvar.AutoSize = true;
            this.labelExponTvar.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelExponTvar.Location = new System.Drawing.Point(194, 163);
            this.labelExponTvar.Name = "labelExponTvar";
            this.labelExponTvar.Size = new System.Drawing.Size(82, 16);
            this.labelExponTvar.TabIndex = 8;
            this.labelExponTvar.Text = "labelExponTvar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(80, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Exponenciální tvar:";
            // 
            // numericUpDownRealne
            // 
            this.numericUpDownRealne.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownRealne.Location = new System.Drawing.Point(83, 45);
            this.numericUpDownRealne.Name = "numericUpDownRealne";
            this.numericUpDownRealne.Size = new System.Drawing.Size(115, 23);
            this.numericUpDownRealne.TabIndex = 9;
            // 
            // numericUpDownImaginarni
            // 
            this.numericUpDownImaginarni.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownImaginarni.Location = new System.Drawing.Point(83, 74);
            this.numericUpDownImaginarni.Name = "numericUpDownImaginarni";
            this.numericUpDownImaginarni.Size = new System.Drawing.Size(115, 23);
            this.numericUpDownImaginarni.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Reálné:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(12, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Imaginární:";
            // 
            // buttonVypocet
            // 
            this.buttonVypocet.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVypocet.Location = new System.Drawing.Point(15, 113);
            this.buttonVypocet.Name = "buttonVypocet";
            this.buttonVypocet.Size = new System.Drawing.Size(62, 66);
            this.buttonVypocet.TabIndex = 13;
            this.buttonVypocet.Text = "Výpočet";
            this.buttonVypocet.UseVisualStyleBackColor = true;
            this.buttonVypocet.Click += new System.EventHandler(this.buttonVypocet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 191);
            this.Controls.Add(this.buttonVypocet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownImaginarni);
            this.Controls.Add(this.numericUpDownRealne);
            this.Controls.Add(this.labelExponTvar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelGonioTvar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelAlgebTvar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonZadatHodnoty);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRealne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownImaginarni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonZadatHodnoty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelAlgebTvar;
        private System.Windows.Forms.Label labelGonioTvar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelExponTvar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownRealne;
        private System.Windows.Forms.NumericUpDown numericUpDownImaginarni;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonVypocet;
    }
}

