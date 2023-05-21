namespace mereni_indukcnosti_civky
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxNapeti = new System.Windows.Forms.TextBox();
            this.textBoxProud = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonVypocitat = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.listBoxVypocty = new System.Windows.Forms.ListBox();
            this.textBoxPrumernaIndukcnost = new System.Windows.Forms.TextBox();
            this.textBoxMaxIndukcnost = new System.Windows.Forms.TextBox();
            this.textBoxPocetMereniNad5V = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxOdporCivky = new System.Windows.Forms.TextBox();
            this.textBoxFrekvence = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxNapeti
            // 
            this.textBoxNapeti.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNapeti.Location = new System.Drawing.Point(219, 52);
            this.textBoxNapeti.Name = "textBoxNapeti";
            this.textBoxNapeti.Size = new System.Drawing.Size(100, 23);
            this.textBoxNapeti.TabIndex = 0;
            // 
            // textBoxProud
            // 
            this.textBoxProud.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProud.Location = new System.Drawing.Point(219, 81);
            this.textBoxProud.Name = "textBoxProud";
            this.textBoxProud.Size = new System.Drawing.Size(100, 23);
            this.textBoxProud.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Napětí [V]:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Proud [mA]:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Měření indukčnosti cívky";
            // 
            // buttonVypocitat
            // 
            this.buttonVypocitat.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVypocitat.Location = new System.Drawing.Point(12, 168);
            this.buttonVypocitat.Name = "buttonVypocitat";
            this.buttonVypocitat.Size = new System.Drawing.Size(307, 40);
            this.buttonVypocitat.TabIndex = 5;
            this.buttonVypocitat.Text = "Vypočítat";
            this.buttonVypocitat.UseVisualStyleBackColor = true;
            this.buttonVypocitat.Click += new System.EventHandler(this.buttonVypocitat_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.Location = new System.Drawing.Point(12, 240);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(86, 30);
            this.buttonReset.TabIndex = 6;
            this.buttonReset.Text = "RESET";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // listBoxVypocty
            // 
            this.listBoxVypocty.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxVypocty.FormattingEnabled = true;
            this.listBoxVypocty.ItemHeight = 16;
            this.listBoxVypocty.Location = new System.Drawing.Point(325, 12);
            this.listBoxVypocty.Name = "listBoxVypocty";
            this.listBoxVypocty.Size = new System.Drawing.Size(307, 164);
            this.listBoxVypocty.TabIndex = 7;
            // 
            // textBoxPrumernaIndukcnost
            // 
            this.textBoxPrumernaIndukcnost.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrumernaIndukcnost.Location = new System.Drawing.Point(532, 182);
            this.textBoxPrumernaIndukcnost.Name = "textBoxPrumernaIndukcnost";
            this.textBoxPrumernaIndukcnost.ReadOnly = true;
            this.textBoxPrumernaIndukcnost.Size = new System.Drawing.Size(100, 23);
            this.textBoxPrumernaIndukcnost.TabIndex = 8;
            // 
            // textBoxMaxIndukcnost
            // 
            this.textBoxMaxIndukcnost.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMaxIndukcnost.Location = new System.Drawing.Point(532, 211);
            this.textBoxMaxIndukcnost.Name = "textBoxMaxIndukcnost";
            this.textBoxMaxIndukcnost.ReadOnly = true;
            this.textBoxMaxIndukcnost.Size = new System.Drawing.Size(100, 23);
            this.textBoxMaxIndukcnost.TabIndex = 9;
            // 
            // textBoxPocetMereniNad5V
            // 
            this.textBoxPocetMereniNad5V.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPocetMereniNad5V.Location = new System.Drawing.Point(532, 240);
            this.textBoxPocetMereniNad5V.Name = "textBoxPocetMereniNad5V";
            this.textBoxPocetMereniNad5V.ReadOnly = true;
            this.textBoxPocetMereniNad5V.Size = new System.Drawing.Size(100, 23);
            this.textBoxPocetMereniNad5V.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(325, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Průmerná indukčnost:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(325, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Maximální indukčnost:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(325, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Počet měření nad 5V:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(12, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Odpor cívky [Ohm]:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(12, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Frekvence [Hz]:";
            // 
            // textBoxOdporCivky
            // 
            this.textBoxOdporCivky.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOdporCivky.Location = new System.Drawing.Point(219, 110);
            this.textBoxOdporCivky.Name = "textBoxOdporCivky";
            this.textBoxOdporCivky.Size = new System.Drawing.Size(100, 23);
            this.textBoxOdporCivky.TabIndex = 3;
            // 
            // textBoxFrekvence
            // 
            this.textBoxFrekvence.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFrekvence.Location = new System.Drawing.Point(219, 139);
            this.textBoxFrekvence.Name = "textBoxFrekvence";
            this.textBoxFrekvence.Size = new System.Drawing.Size(100, 23);
            this.textBoxFrekvence.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 284);
            this.Controls.Add(this.textBoxFrekvence);
            this.Controls.Add(this.textBoxOdporCivky);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPocetMereniNad5V);
            this.Controls.Add(this.textBoxMaxIndukcnost);
            this.Controls.Add(this.textBoxPrumernaIndukcnost);
            this.Controls.Add(this.listBoxVypocty);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonVypocitat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxProud);
            this.Controls.Add(this.textBoxNapeti);
            this.Name = "Form1";
            this.Text = "Měření indukčnosti cívky";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxOdporCivky;
        private System.Windows.Forms.TextBox textBoxFrekvence;

        private System.Windows.Forms.TextBox textBoxPrumernaIndukcnost;
        private System.Windows.Forms.TextBox textBoxMaxIndukcnost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.TextBox textBoxPocetMereniNad5V;

        private System.Windows.Forms.ListBox listBoxVypocty;

        private System.Windows.Forms.Button buttonReset;

        private System.Windows.Forms.Button buttonVypocitat;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNapeti;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.TextBox textBoxProud;

        #endregion
    }
}