
namespace hra_hadani_cisel
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxJmeno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.groupBoxHra = new System.Windows.Forms.GroupBox();
            this.labelWin = new System.Windows.Forms.Label();
            this.labelNapoveda = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPocetPokusu = new System.Windows.Forms.TextBox();
            this.buttonPlayAgain = new System.Windows.Forms.Button();
            this.buttonHadat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCislo = new System.Windows.Forms.TextBox();
            this.listBoxVysledky = new System.Windows.Forms.ListBox();
            this.buttonVysledky = new System.Windows.Forms.Button();
            this.groupBoxHra.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxJmeno
            // 
            this.textBoxJmeno.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxJmeno.Location = new System.Drawing.Point(63, 45);
            this.textBoxJmeno.Name = "textBoxJmeno";
            this.textBoxJmeno.Size = new System.Drawing.Size(100, 23);
            this.textBoxJmeno.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Jméno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hra hádání čísel 0 až 20";
            // 
            // buttonPlay
            // 
            this.buttonPlay.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPlay.Location = new System.Drawing.Point(169, 42);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(151, 29);
            this.buttonPlay.TabIndex = 3;
            this.buttonPlay.Text = "Hrát!";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // groupBoxHra
            // 
            this.groupBoxHra.Controls.Add(this.labelWin);
            this.groupBoxHra.Controls.Add(this.labelNapoveda);
            this.groupBoxHra.Controls.Add(this.label4);
            this.groupBoxHra.Controls.Add(this.textBoxPocetPokusu);
            this.groupBoxHra.Controls.Add(this.buttonPlayAgain);
            this.groupBoxHra.Controls.Add(this.buttonHadat);
            this.groupBoxHra.Controls.Add(this.label3);
            this.groupBoxHra.Controls.Add(this.textBoxCislo);
            this.groupBoxHra.Location = new System.Drawing.Point(12, 77);
            this.groupBoxHra.Name = "groupBoxHra";
            this.groupBoxHra.Size = new System.Drawing.Size(262, 241);
            this.groupBoxHra.TabIndex = 4;
            this.groupBoxHra.TabStop = false;
            this.groupBoxHra.Text = "Hra";
            // 
            // labelWin
            // 
            this.labelWin.AutoSize = true;
            this.labelWin.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWin.Location = new System.Drawing.Point(90, 147);
            this.labelWin.Name = "labelWin";
            this.labelWin.Size = new System.Drawing.Size(85, 25);
            this.labelWin.TabIndex = 11;
            this.labelWin.Text = "Správně!";
            // 
            // labelNapoveda
            // 
            this.labelNapoveda.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNapoveda.Location = new System.Drawing.Point(6, 55);
            this.labelNapoveda.Name = "labelNapoveda";
            this.labelNapoveda.Size = new System.Drawing.Size(231, 29);
            this.labelNapoveda.TabIndex = 10;
            this.labelNapoveda.Text = "labelNapoveda";
            this.labelNapoveda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Počet pokusů:";
            // 
            // textBoxPocetPokusu
            // 
            this.textBoxPocetPokusu.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPocetPokusu.Location = new System.Drawing.Point(90, 87);
            this.textBoxPocetPokusu.Name = "textBoxPocetPokusu";
            this.textBoxPocetPokusu.ReadOnly = true;
            this.textBoxPocetPokusu.Size = new System.Drawing.Size(100, 23);
            this.textBoxPocetPokusu.TabIndex = 8;
            // 
            // buttonPlayAgain
            // 
            this.buttonPlayAgain.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPlayAgain.Location = new System.Drawing.Point(9, 206);
            this.buttonPlayAgain.Name = "buttonPlayAgain";
            this.buttonPlayAgain.Size = new System.Drawing.Size(247, 29);
            this.buttonPlayAgain.TabIndex = 7;
            this.buttonPlayAgain.Text = "Hrát znovu";
            this.buttonPlayAgain.UseVisualStyleBackColor = true;
            this.buttonPlayAgain.Click += new System.EventHandler(this.buttonPlayAgain_Click);
            // 
            // buttonHadat
            // 
            this.buttonHadat.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonHadat.Location = new System.Drawing.Point(154, 29);
            this.buttonHadat.Name = "buttonHadat";
            this.buttonHadat.Size = new System.Drawing.Size(83, 23);
            this.buttonHadat.TabIndex = 6;
            this.buttonHadat.Text = "Hádat";
            this.buttonHadat.UseVisualStyleBackColor = true;
            this.buttonHadat.Click += new System.EventHandler(this.buttonHadat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Číslo:";
            // 
            // textBoxCislo
            // 
            this.textBoxCislo.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCislo.Location = new System.Drawing.Point(48, 29);
            this.textBoxCislo.Name = "textBoxCislo";
            this.textBoxCislo.Size = new System.Drawing.Size(100, 23);
            this.textBoxCislo.TabIndex = 5;
            // 
            // listBoxVysledky
            // 
            this.listBoxVysledky.FormattingEnabled = true;
            this.listBoxVysledky.Location = new System.Drawing.Point(280, 119);
            this.listBoxVysledky.Name = "listBoxVysledky";
            this.listBoxVysledky.Size = new System.Drawing.Size(242, 199);
            this.listBoxVysledky.TabIndex = 5;
            // 
            // buttonVysledky
            // 
            this.buttonVysledky.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonVysledky.Location = new System.Drawing.Point(280, 77);
            this.buttonVysledky.Name = "buttonVysledky";
            this.buttonVysledky.Size = new System.Drawing.Size(242, 36);
            this.buttonVysledky.TabIndex = 10;
            this.buttonVysledky.Text = "Zobrazit výsledky";
            this.buttonVysledky.UseVisualStyleBackColor = true;
            this.buttonVysledky.Click += new System.EventHandler(this.buttonVysledky_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 331);
            this.Controls.Add(this.buttonVysledky);
            this.Controls.Add(this.listBoxVysledky);
            this.Controls.Add(this.groupBoxHra);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxJmeno);
            this.Name = "Form1";
            this.Text = "Hra hádání čísel";
            this.groupBoxHra.ResumeLayout(false);
            this.groupBoxHra.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBoxJmeno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.GroupBox groupBoxHra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPocetPokusu;
        private System.Windows.Forms.Button buttonPlayAgain;
        private System.Windows.Forms.Button buttonHadat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCislo;
        private System.Windows.Forms.ListBox listBoxVysledky;
        private System.Windows.Forms.Label labelWin;
        private System.Windows.Forms.Label labelNapoveda;
        private System.Windows.Forms.Button buttonVysledky;
    }
}

