namespace úkol_1___přepočet_jednotek
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
            this.buttonPrevod = new System.Windows.Forms.Button();
            this.radioButtonMili = new System.Windows.Forms.RadioButton();
            this.radioButtonCent = new System.Windows.Forms.RadioButton();
            this.radioButtonDeci = new System.Windows.Forms.RadioButton();
            this.radioButtonKilo = new System.Windows.Forms.RadioButton();
            this.textBoxCislo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Převod jednotek";
            // 
            // buttonPrevod
            // 
            this.buttonPrevod.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrevod.Location = new System.Drawing.Point(189, 67);
            this.buttonPrevod.Name = "buttonPrevod";
            this.buttonPrevod.Size = new System.Drawing.Size(75, 23);
            this.buttonPrevod.TabIndex = 1;
            this.buttonPrevod.Text = "Převést";
            this.buttonPrevod.UseVisualStyleBackColor = true;
            this.buttonPrevod.Click += new System.EventHandler(this.buttonPrevod_Click);
            // 
            // radioButtonMili
            // 
            this.radioButtonMili.AutoSize = true;
            this.radioButtonMili.Checked = true;
            this.radioButtonMili.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMili.Location = new System.Drawing.Point(16, 97);
            this.radioButtonMili.Name = "radioButtonMili";
            this.radioButtonMili.Size = new System.Drawing.Size(75, 20);
            this.radioButtonMili.TabIndex = 2;
            this.radioButtonMili.TabStop = true;
            this.radioButtonMili.Text = "milimetry";
            this.radioButtonMili.UseVisualStyleBackColor = true;
            // 
            // radioButtonCent
            // 
            this.radioButtonCent.AutoSize = true;
            this.radioButtonCent.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCent.Location = new System.Drawing.Point(16, 123);
            this.radioButtonCent.Name = "radioButtonCent";
            this.radioButtonCent.Size = new System.Drawing.Size(81, 20);
            this.radioButtonCent.TabIndex = 3;
            this.radioButtonCent.Text = "centimetry";
            this.radioButtonCent.UseVisualStyleBackColor = true;
            // 
            // radioButtonDeci
            // 
            this.radioButtonDeci.AutoSize = true;
            this.radioButtonDeci.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonDeci.Location = new System.Drawing.Point(16, 149);
            this.radioButtonDeci.Name = "radioButtonDeci";
            this.radioButtonDeci.Size = new System.Drawing.Size(77, 20);
            this.radioButtonDeci.TabIndex = 4;
            this.radioButtonDeci.Text = "decimetry";
            this.radioButtonDeci.UseVisualStyleBackColor = true;
            // 
            // radioButtonKilo
            // 
            this.radioButtonKilo.AutoSize = true;
            this.radioButtonKilo.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonKilo.Location = new System.Drawing.Point(16, 175);
            this.radioButtonKilo.Name = "radioButtonKilo";
            this.radioButtonKilo.Size = new System.Drawing.Size(74, 20);
            this.radioButtonKilo.TabIndex = 5;
            this.radioButtonKilo.Text = "kilometry";
            this.radioButtonKilo.UseVisualStyleBackColor = true;
            // 
            // textBoxCislo
            // 
            this.textBoxCislo.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxCislo.Location = new System.Drawing.Point(16, 64);
            this.textBoxCislo.Name = "textBoxCislo";
            this.textBoxCislo.Size = new System.Drawing.Size(167, 27);
            this.textBoxCislo.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(13, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Zadání v metrech";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 207);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxCislo);
            this.Controls.Add(this.radioButtonKilo);
            this.Controls.Add(this.radioButtonDeci);
            this.Controls.Add(this.radioButtonCent);
            this.Controls.Add(this.radioButtonMili);
            this.Controls.Add(this.buttonPrevod);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Převod jednotek";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPrevod;
        private System.Windows.Forms.RadioButton radioButtonMili;
        private System.Windows.Forms.RadioButton radioButtonCent;
        private System.Windows.Forms.RadioButton radioButtonDeci;
        private System.Windows.Forms.RadioButton radioButtonKilo;
        private System.Windows.Forms.TextBox textBoxCislo;
        private System.Windows.Forms.Label label3;
    }
}

