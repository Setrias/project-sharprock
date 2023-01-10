namespace david_01
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
            this.labelVysledekA = new System.Windows.Forms.Label();
            this.labelVysledekB = new System.Windows.Forms.Label();
            this.labelVysledekC = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonVysledek
            // 
            this.buttonVysledek.Location = new System.Drawing.Point(118, 39);
            this.buttonVysledek.Name = "buttonVysledek";
            this.buttonVysledek.Size = new System.Drawing.Size(75, 72);
            this.buttonVysledek.TabIndex = 0;
            this.buttonVysledek.Text = "Výsledky";
            this.buttonVysledek.UseVisualStyleBackColor = true;
            this.buttonVysledek.Click += new System.EventHandler(this.buttonVysledek_Click);
            // 
            // labelVysledekA
            // 
            this.labelVysledekA.AutoSize = true;
            this.labelVysledekA.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVysledekA.Location = new System.Drawing.Point(199, 42);
            this.labelVysledekA.Name = "labelVysledekA";
            this.labelVysledekA.Size = new System.Drawing.Size(0, 16);
            this.labelVysledekA.TabIndex = 1;
            // 
            // labelVysledekB
            // 
            this.labelVysledekB.AutoSize = true;
            this.labelVysledekB.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVysledekB.Location = new System.Drawing.Point(199, 67);
            this.labelVysledekB.Name = "labelVysledekB";
            this.labelVysledekB.Size = new System.Drawing.Size(0, 16);
            this.labelVysledekB.TabIndex = 2;
            // 
            // labelVysledekC
            // 
            this.labelVysledekC.AutoSize = true;
            this.labelVysledekC.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelVysledekC.Location = new System.Drawing.Point(199, 96);
            this.labelVysledekC.Name = "labelVysledekC";
            this.labelVysledekC.Size = new System.Drawing.Size(0, 16);
            this.labelVysledekC.TabIndex = 3;
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(12, 39);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(100, 20);
            this.textBoxA.TabIndex = 4;
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(12, 65);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(100, 20);
            this.textBoxB.TabIndex = 5;
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(12, 91);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(100, 20);
            this.textBoxC.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Random příklady David 01";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 133);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxC);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.labelVysledekC);
            this.Controls.Add(this.labelVysledekB);
            this.Controls.Add(this.labelVysledekA);
            this.Controls.Add(this.buttonVysledek);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonVysledek;
        private System.Windows.Forms.Label labelVysledekA;
        private System.Windows.Forms.Label labelVysledekB;
        private System.Windows.Forms.Label labelVysledekC;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.Label label1;
    }
}

