namespace slunecni_soustava
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
            this.textBoxNazevPlanety = new System.Windows.Forms.TextBox();
            this.textBoxObeznaDoba = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxVzdalenostAu = new System.Windows.Forms.TextBox();
            this.textBoxVzdalenostKm = new System.Windows.Forms.TextBox();
            this.textBoxPrumernaRychlost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonVypocitat = new System.Windows.Forms.Button();
            this.listBoxVypis = new System.Windows.Forms.ListBox();
            this.buttonVypis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNazevPlanety
            // 
            this.textBoxNazevPlanety.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNazevPlanety.Location = new System.Drawing.Point(198, 12);
            this.textBoxNazevPlanety.Name = "textBoxNazevPlanety";
            this.textBoxNazevPlanety.Size = new System.Drawing.Size(117, 23);
            this.textBoxNazevPlanety.TabIndex = 0;
            // 
            // textBoxObeznaDoba
            // 
            this.textBoxObeznaDoba.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxObeznaDoba.Location = new System.Drawing.Point(198, 41);
            this.textBoxObeznaDoba.Name = "textBoxObeznaDoba";
            this.textBoxObeznaDoba.Size = new System.Drawing.Size(117, 23);
            this.textBoxObeznaDoba.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Název planety:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(14, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Oběžná doba [v letech]:";
            // 
            // textBoxVzdalenostAu
            // 
            this.textBoxVzdalenostAu.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxVzdalenostAu.Location = new System.Drawing.Point(198, 119);
            this.textBoxVzdalenostAu.Name = "textBoxVzdalenostAu";
            this.textBoxVzdalenostAu.ReadOnly = true;
            this.textBoxVzdalenostAu.Size = new System.Drawing.Size(117, 23);
            this.textBoxVzdalenostAu.TabIndex = 4;
            // 
            // textBoxVzdalenostKm
            // 
            this.textBoxVzdalenostKm.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxVzdalenostKm.Location = new System.Drawing.Point(198, 148);
            this.textBoxVzdalenostKm.Name = "textBoxVzdalenostKm";
            this.textBoxVzdalenostKm.ReadOnly = true;
            this.textBoxVzdalenostKm.Size = new System.Drawing.Size(117, 23);
            this.textBoxVzdalenostKm.TabIndex = 5;
            // 
            // textBoxPrumernaRychlost
            // 
            this.textBoxPrumernaRychlost.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrumernaRychlost.Location = new System.Drawing.Point(198, 177);
            this.textBoxPrumernaRychlost.Name = "textBoxPrumernaRychlost";
            this.textBoxPrumernaRychlost.ReadOnly = true;
            this.textBoxPrumernaRychlost.Size = new System.Drawing.Size(117, 23);
            this.textBoxPrumernaRychlost.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(14, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Vzdálenost tělesa v AU:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(14, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Vzdálenost tělesa v Km:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(14, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Průměrná rychlost tělesa [kms-1]:";
            // 
            // buttonVypocitat
            // 
            this.buttonVypocitat.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVypocitat.Location = new System.Drawing.Point(14, 70);
            this.buttonVypocitat.Name = "buttonVypocitat";
            this.buttonVypocitat.Size = new System.Drawing.Size(301, 38);
            this.buttonVypocitat.TabIndex = 10;
            this.buttonVypocitat.Text = "Vypočítat";
            this.buttonVypocitat.UseVisualStyleBackColor = true;
            this.buttonVypocitat.Click += new System.EventHandler(this.buttonVypocitat_Click);
            // 
            // listBoxVypis
            // 
            this.listBoxVypis.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxVypis.FormattingEnabled = true;
            this.listBoxVypis.ItemHeight = 16;
            this.listBoxVypis.Location = new System.Drawing.Point(339, 56);
            this.listBoxVypis.Name = "listBoxVypis";
            this.listBoxVypis.Size = new System.Drawing.Size(476, 148);
            this.listBoxVypis.TabIndex = 11;
            // 
            // buttonVypis
            // 
            this.buttonVypis.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVypis.Location = new System.Drawing.Point(339, 12);
            this.buttonVypis.Name = "buttonVypis";
            this.buttonVypis.Size = new System.Drawing.Size(476, 38);
            this.buttonVypis.TabIndex = 12;
            this.buttonVypis.Text = "Vypiš obsah souboru";
            this.buttonVypis.UseVisualStyleBackColor = true;
            this.buttonVypis.Click += new System.EventHandler(this.buttonVypis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 220);
            this.Controls.Add(this.buttonVypis);
            this.Controls.Add(this.listBoxVypis);
            this.Controls.Add(this.buttonVypocitat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPrumernaRychlost);
            this.Controls.Add(this.textBoxVzdalenostKm);
            this.Controls.Add(this.textBoxVzdalenostAu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxObeznaDoba);
            this.Controls.Add(this.textBoxNazevPlanety);
            this.Name = "Form1";
            this.Text = "Sluneční soustava";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button buttonVypis;

        private System.Windows.Forms.ListBox listBoxVypis;

        private System.Windows.Forms.TextBox textBoxVzdalenostKm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonVypocitat;

        private System.Windows.Forms.TextBox textBoxVzdalenostAu;
        private System.Windows.Forms.TextBox textBoxPrumernaRychlost;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.TextBox textBoxNazevPlanety;
        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.TextBox textBoxObeznaDoba;

        #endregion
    }
}