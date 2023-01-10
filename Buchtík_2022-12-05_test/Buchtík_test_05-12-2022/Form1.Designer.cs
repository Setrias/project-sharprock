
namespace Buchtík_test_05_12_2022
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
            this.listBoxPole = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonZapis = new System.Windows.Forms.Button();
            this.buttonPrumer = new System.Windows.Forms.Button();
            this.labelPrumer = new System.Windows.Forms.Label();
            this.textBoxCislo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBoxPole
            // 
            this.listBoxPole.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPole.FormattingEnabled = true;
            this.listBoxPole.ItemHeight = 16;
            this.listBoxPole.Location = new System.Drawing.Point(16, 60);
            this.listBoxPole.Name = "listBoxPole";
            this.listBoxPole.Size = new System.Drawing.Size(120, 84);
            this.listBoxPole.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Načti 5 celých čísel";
            // 
            // buttonZapis
            // 
            this.buttonZapis.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonZapis.Location = new System.Drawing.Point(122, 31);
            this.buttonZapis.Name = "buttonZapis";
            this.buttonZapis.Size = new System.Drawing.Size(75, 23);
            this.buttonZapis.TabIndex = 2;
            this.buttonZapis.Text = "Zápis čísla";
            this.buttonZapis.UseVisualStyleBackColor = true;
            this.buttonZapis.Click += new System.EventHandler(this.buttonZapis_Click);
            // 
            // buttonPrumer
            // 
            this.buttonPrumer.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrumer.Location = new System.Drawing.Point(16, 150);
            this.buttonPrumer.Name = "buttonPrumer";
            this.buttonPrumer.Size = new System.Drawing.Size(75, 23);
            this.buttonPrumer.TabIndex = 3;
            this.buttonPrumer.Text = "Průměr";
            this.buttonPrumer.UseVisualStyleBackColor = true;
            this.buttonPrumer.Click += new System.EventHandler(this.buttonPrumer_Click);
            // 
            // labelPrumer
            // 
            this.labelPrumer.AutoSize = true;
            this.labelPrumer.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrumer.Location = new System.Drawing.Point(97, 153);
            this.labelPrumer.Name = "labelPrumer";
            this.labelPrumer.Size = new System.Drawing.Size(71, 16);
            this.labelPrumer.TabIndex = 4;
            this.labelPrumer.Text = "labelPrumer";
            // 
            // textBoxCislo
            // 
            this.textBoxCislo.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCislo.Location = new System.Drawing.Point(16, 31);
            this.textBoxCislo.Name = "textBoxCislo";
            this.textBoxCislo.Size = new System.Drawing.Size(100, 23);
            this.textBoxCislo.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 188);
            this.Controls.Add(this.textBoxCislo);
            this.Controls.Add(this.labelPrumer);
            this.Controls.Add(this.buttonPrumer);
            this.Controls.Add(this.buttonZapis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxPole);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonZapis;
        private System.Windows.Forms.Button buttonPrumer;
        private System.Windows.Forms.Label labelPrumer;
        private System.Windows.Forms.TextBox textBoxCislo;
    }
}

