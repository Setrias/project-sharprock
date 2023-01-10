
namespace vypocet_znamky
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
            this.numericUpDownBody = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPocetBodu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxZnamka = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonZadatBody = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBody)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownBody
            // 
            this.numericUpDownBody.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownBody.Location = new System.Drawing.Point(16, 49);
            this.numericUpDownBody.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownBody.Name = "numericUpDownBody";
            this.numericUpDownBody.Size = new System.Drawing.Size(60, 30);
            this.numericUpDownBody.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Výpočet známky";
            // 
            // textBoxPocetBodu
            // 
            this.textBoxPocetBodu.Location = new System.Drawing.Point(83, 85);
            this.textBoxPocetBodu.Name = "textBoxPocetBodu";
            this.textBoxPocetBodu.ReadOnly = true;
            this.textBoxPocetBodu.Size = new System.Drawing.Size(81, 20);
            this.textBoxPocetBodu.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Počet bodů:";
            // 
            // textBoxZnamka
            // 
            this.textBoxZnamka.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxZnamka.Location = new System.Drawing.Point(227, 49);
            this.textBoxZnamka.Name = "textBoxZnamka";
            this.textBoxZnamka.ReadOnly = true;
            this.textBoxZnamka.Size = new System.Drawing.Size(30, 30);
            this.textBoxZnamka.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(170, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Známka:";
            // 
            // buttonZadatBody
            // 
            this.buttonZadatBody.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonZadatBody.Location = new System.Drawing.Point(83, 49);
            this.buttonZadatBody.Name = "buttonZadatBody";
            this.buttonZadatBody.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.buttonZadatBody.Size = new System.Drawing.Size(81, 30);
            this.buttonZadatBody.TabIndex = 7;
            this.buttonZadatBody.Text = "Zadat počet bodů";
            this.buttonZadatBody.UseVisualStyleBackColor = true;
            this.buttonZadatBody.Click += new System.EventHandler(this.buttonZadatBody_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 117);
            this.Controls.Add(this.buttonZadatBody);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxZnamka);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPocetBodu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownBody);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBody)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownBody;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPocetBodu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxZnamka;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonZadatBody;
    }
}

