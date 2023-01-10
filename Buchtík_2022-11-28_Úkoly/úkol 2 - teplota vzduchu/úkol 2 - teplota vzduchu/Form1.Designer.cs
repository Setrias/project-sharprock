namespace úkol_2___teplota_vzduchu
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
            this.buttonZapis = new System.Windows.Forms.Button();
            this.listBoxPole = new System.Windows.Forms.ListBox();
            this.labelPrumer = new System.Windows.Forms.Label();
            this.labelNejvetsi = new System.Windows.Forms.Label();
            this.labelNejmensi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxCislo
            // 
            this.textBoxCislo.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxCislo.Location = new System.Drawing.Point(16, 64);
            this.textBoxCislo.Name = "textBoxCislo";
            this.textBoxCislo.Size = new System.Drawing.Size(124, 23);
            this.textBoxCislo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Teplota vzduchu";
            // 
            // buttonZapis
            // 
            this.buttonZapis.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonZapis.Location = new System.Drawing.Point(146, 64);
            this.buttonZapis.Name = "buttonZapis";
            this.buttonZapis.Size = new System.Drawing.Size(95, 23);
            this.buttonZapis.TabIndex = 2;
            this.buttonZapis.Text = "Zapsat hodnotu";
            this.buttonZapis.UseVisualStyleBackColor = true;
            this.buttonZapis.Click += new System.EventHandler(this.buttonZapis_Click);
            // 
            // listBoxPole
            // 
            this.listBoxPole.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBoxPole.FormattingEnabled = true;
            this.listBoxPole.ItemHeight = 16;
            this.listBoxPole.Location = new System.Drawing.Point(16, 93);
            this.listBoxPole.Name = "listBoxPole";
            this.listBoxPole.Size = new System.Drawing.Size(124, 116);
            this.listBoxPole.TabIndex = 3;
            // 
            // labelPrumer
            // 
            this.labelPrumer.AutoSize = true;
            this.labelPrumer.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelPrumer.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPrumer.Location = new System.Drawing.Point(146, 104);
            this.labelPrumer.Name = "labelPrumer";
            this.labelPrumer.Size = new System.Drawing.Size(10, 16);
            this.labelPrumer.TabIndex = 4;
            this.labelPrumer.Text = " ";
            // 
            // labelNejvetsi
            // 
            this.labelNejvetsi.AutoSize = true;
            this.labelNejvetsi.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelNejvetsi.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNejvetsi.Location = new System.Drawing.Point(146, 130);
            this.labelNejvetsi.Name = "labelNejvetsi";
            this.labelNejvetsi.Size = new System.Drawing.Size(10, 16);
            this.labelNejvetsi.TabIndex = 5;
            this.labelNejvetsi.Text = " ";
            // 
            // labelNejmensi
            // 
            this.labelNejmensi.AutoSize = true;
            this.labelNejmensi.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelNejmensi.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNejmensi.Location = new System.Drawing.Point(146, 156);
            this.labelNejmensi.Name = "labelNejmensi";
            this.labelNejmensi.Size = new System.Drawing.Size(10, 16);
            this.labelNejmensi.TabIndex = 6;
            this.labelNejmensi.Text = " ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(13, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Zadej 7 hodnot";
            // 
            // buttonReset
            // 
            this.buttonReset.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonReset.Location = new System.Drawing.Point(146, 186);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(95, 23);
            this.buttonReset.TabIndex = 10;
            this.buttonReset.Text = "Resetování";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 223);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelNejmensi);
            this.Controls.Add(this.labelNejvetsi);
            this.Controls.Add(this.labelPrumer);
            this.Controls.Add(this.listBoxPole);
            this.Controls.Add(this.buttonZapis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCislo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCislo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonZapis;
        private System.Windows.Forms.ListBox listBoxPole;
        private System.Windows.Forms.Label labelPrumer;
        private System.Windows.Forms.Label labelNejvetsi;
        private System.Windows.Forms.Label labelNejmensi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonReset;
    }
}

