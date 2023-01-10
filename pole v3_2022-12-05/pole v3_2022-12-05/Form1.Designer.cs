
namespace pole_v3_2022_12_05
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
            this.textBoxCislo = new System.Windows.Forms.TextBox();
            this.buttonZapis = new System.Windows.Forms.Button();
            this.listBoxVypis = new System.Windows.Forms.ListBox();
            this.buttonMin = new System.Windows.Forms.Button();
            this.buttonMax = new System.Windows.Forms.Button();
            this.labelMin = new System.Windows.Forms.Label();
            this.labelMax = new System.Windows.Forms.Label();
            this.buttonPocetKladnych = new System.Windows.Forms.Button();
            this.labelPocetKladnych = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pole v3";
            // 
            // textBoxCislo
            // 
            this.textBoxCislo.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCislo.Location = new System.Drawing.Point(12, 31);
            this.textBoxCislo.Name = "textBoxCislo";
            this.textBoxCislo.Size = new System.Drawing.Size(100, 23);
            this.textBoxCislo.TabIndex = 1;
            // 
            // buttonZapis
            // 
            this.buttonZapis.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonZapis.Location = new System.Drawing.Point(118, 31);
            this.buttonZapis.Name = "buttonZapis";
            this.buttonZapis.Size = new System.Drawing.Size(92, 23);
            this.buttonZapis.TabIndex = 2;
            this.buttonZapis.Text = "Zapiš";
            this.buttonZapis.UseVisualStyleBackColor = true;
            this.buttonZapis.Click += new System.EventHandler(this.buttonZapis_Click);
            // 
            // listBoxVypis
            // 
            this.listBoxVypis.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxVypis.FormattingEnabled = true;
            this.listBoxVypis.ItemHeight = 16;
            this.listBoxVypis.Location = new System.Drawing.Point(12, 60);
            this.listBoxVypis.Name = "listBoxVypis";
            this.listBoxVypis.Size = new System.Drawing.Size(100, 84);
            this.listBoxVypis.TabIndex = 3;
            // 
            // buttonMin
            // 
            this.buttonMin.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMin.Location = new System.Drawing.Point(118, 60);
            this.buttonMin.Name = "buttonMin";
            this.buttonMin.Size = new System.Drawing.Size(92, 23);
            this.buttonMin.TabIndex = 4;
            this.buttonMin.Text = "Minimum";
            this.buttonMin.UseVisualStyleBackColor = true;
            this.buttonMin.Click += new System.EventHandler(this.buttonMin_Click);
            // 
            // buttonMax
            // 
            this.buttonMax.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMax.Location = new System.Drawing.Point(118, 91);
            this.buttonMax.Name = "buttonMax";
            this.buttonMax.Size = new System.Drawing.Size(92, 23);
            this.buttonMax.TabIndex = 5;
            this.buttonMax.Text = "Maximum";
            this.buttonMax.UseVisualStyleBackColor = true;
            this.buttonMax.Click += new System.EventHandler(this.buttonMax_Click);
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMin.Location = new System.Drawing.Point(216, 63);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(49, 16);
            this.labelMin.TabIndex = 6;
            this.labelMin.Text = "labelMin";
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMax.Location = new System.Drawing.Point(216, 94);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(52, 16);
            this.labelMax.TabIndex = 7;
            this.labelMax.Text = "labelMax";
            // 
            // buttonPocetKladnych
            // 
            this.buttonPocetKladnych.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPocetKladnych.Location = new System.Drawing.Point(118, 121);
            this.buttonPocetKladnych.Name = "buttonPocetKladnych";
            this.buttonPocetKladnych.Size = new System.Drawing.Size(92, 23);
            this.buttonPocetKladnych.TabIndex = 8;
            this.buttonPocetKladnych.Text = "Počet kladných";
            this.buttonPocetKladnych.UseVisualStyleBackColor = true;
            this.buttonPocetKladnych.Click += new System.EventHandler(this.buttonPocetKladnych_Click);
            // 
            // labelPocetKladnych
            // 
            this.labelPocetKladnych.AutoSize = true;
            this.labelPocetKladnych.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPocetKladnych.Location = new System.Drawing.Point(216, 124);
            this.labelPocetKladnych.Name = "labelPocetKladnych";
            this.labelPocetKladnych.Size = new System.Drawing.Size(105, 16);
            this.labelPocetKladnych.TabIndex = 9;
            this.labelPocetKladnych.Text = "labelPocetKladnych";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 159);
            this.Controls.Add(this.labelPocetKladnych);
            this.Controls.Add(this.buttonPocetKladnych);
            this.Controls.Add(this.labelMax);
            this.Controls.Add(this.labelMin);
            this.Controls.Add(this.buttonMax);
            this.Controls.Add(this.buttonMin);
            this.Controls.Add(this.listBoxVypis);
            this.Controls.Add(this.buttonZapis);
            this.Controls.Add(this.textBoxCislo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Pole 5ti čísel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCislo;
        private System.Windows.Forms.Button buttonZapis;
        private System.Windows.Forms.ListBox listBoxVypis;
        private System.Windows.Forms.Button buttonMin;
        private System.Windows.Forms.Button buttonMax;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.Button buttonPocetKladnych;
        private System.Windows.Forms.Label labelPocetKladnych;
    }
}

