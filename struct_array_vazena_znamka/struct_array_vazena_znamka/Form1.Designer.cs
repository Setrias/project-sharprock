
namespace struct_array_vazena_znamka
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
            this.numericUpDownZnamka = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownVaha = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonZadat = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPocetZadanych = new System.Windows.Forms.TextBox();
            this.listBoxPrehled = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPrumer = new System.Windows.Forms.TextBox();
            this.buttonKonec = new System.Windows.Forms.Button();
            this.comboBoxPredmet = new System.Windows.Forms.ComboBox();
            this.buttonPredmetVypis = new System.Windows.Forms.Button();
            this.comboBoxPredmetVypis = new System.Windows.Forms.ComboBox();
            this.comboBoxVahaVypis = new System.Windows.Forms.ComboBox();
            this.buttonVahaVypis = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPrumerPredmet = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZnamka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVaha)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownZnamka
            // 
            this.numericUpDownZnamka.DecimalPlaces = 1;
            this.numericUpDownZnamka.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownZnamka.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDownZnamka.Location = new System.Drawing.Point(70, 77);
            this.numericUpDownZnamka.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownZnamka.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownZnamka.Name = "numericUpDownZnamka";
            this.numericUpDownZnamka.Size = new System.Drawing.Size(57, 27);
            this.numericUpDownZnamka.TabIndex = 0;
            this.numericUpDownZnamka.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Struct Array - Vážená známka";
            // 
            // numericUpDownVaha
            // 
            this.numericUpDownVaha.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownVaha.Location = new System.Drawing.Point(70, 110);
            this.numericUpDownVaha.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownVaha.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownVaha.Name = "numericUpDownVaha";
            this.numericUpDownVaha.Size = new System.Drawing.Size(57, 27);
            this.numericUpDownVaha.TabIndex = 2;
            this.numericUpDownVaha.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(13, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Známka:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(29, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Váha:";
            // 
            // buttonZadat
            // 
            this.buttonZadat.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonZadat.Location = new System.Drawing.Point(133, 77);
            this.buttonZadat.Name = "buttonZadat";
            this.buttonZadat.Size = new System.Drawing.Size(112, 27);
            this.buttonZadat.TabIndex = 5;
            this.buttonZadat.Text = "Zadat";
            this.buttonZadat.UseVisualStyleBackColor = true;
            this.buttonZadat.Click += new System.EventHandler(this.buttonZadat_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(13, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Počet zadaných známek:";
            // 
            // textBoxPocetZadanych
            // 
            this.textBoxPocetZadanych.Location = new System.Drawing.Point(152, 148);
            this.textBoxPocetZadanych.Name = "textBoxPocetZadanych";
            this.textBoxPocetZadanych.ReadOnly = true;
            this.textBoxPocetZadanych.Size = new System.Drawing.Size(47, 20);
            this.textBoxPocetZadanych.TabIndex = 7;
            // 
            // listBoxPrehled
            // 
            this.listBoxPrehled.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPrehled.FormattingEnabled = true;
            this.listBoxPrehled.ItemHeight = 16;
            this.listBoxPrehled.Location = new System.Drawing.Point(294, 9);
            this.listBoxPrehled.Name = "listBoxPrehled";
            this.listBoxPrehled.Size = new System.Drawing.Size(173, 244);
            this.listBoxPrehled.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(97, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Průměr:";
            // 
            // textBoxPrumer
            // 
            this.textBoxPrumer.Location = new System.Drawing.Point(152, 174);
            this.textBoxPrumer.Name = "textBoxPrumer";
            this.textBoxPrumer.ReadOnly = true;
            this.textBoxPrumer.Size = new System.Drawing.Size(47, 20);
            this.textBoxPrumer.TabIndex = 10;
            // 
            // buttonKonec
            // 
            this.buttonKonec.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKonec.Location = new System.Drawing.Point(133, 110);
            this.buttonKonec.Name = "buttonKonec";
            this.buttonKonec.Size = new System.Drawing.Size(112, 27);
            this.buttonKonec.TabIndex = 11;
            this.buttonKonec.Text = "Konec";
            this.buttonKonec.UseVisualStyleBackColor = true;
            this.buttonKonec.Click += new System.EventHandler(this.buttonKonec_Click);
            // 
            // comboBoxPredmet
            // 
            this.comboBoxPredmet.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPredmet.FormattingEnabled = true;
            this.comboBoxPredmet.Items.AddRange(new object[] {
            "ANJ",
            "CJL",
            "MAT",
            "ELN",
            "ELM"});
            this.comboBoxPredmet.Location = new System.Drawing.Point(16, 44);
            this.comboBoxPredmet.Name = "comboBoxPredmet";
            this.comboBoxPredmet.Size = new System.Drawing.Size(121, 24);
            this.comboBoxPredmet.TabIndex = 12;
            // 
            // buttonPredmetVypis
            // 
            this.buttonPredmetVypis.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPredmetVypis.Location = new System.Drawing.Point(16, 200);
            this.buttonPredmetVypis.Name = "buttonPredmetVypis";
            this.buttonPredmetVypis.Size = new System.Drawing.Size(145, 23);
            this.buttonPredmetVypis.TabIndex = 13;
            this.buttonPredmetVypis.Text = "Piš známky z předmětu: ";
            this.buttonPredmetVypis.UseVisualStyleBackColor = true;
            this.buttonPredmetVypis.Click += new System.EventHandler(this.buttonPredmetVypis_Click);
            // 
            // comboBoxPredmetVypis
            // 
            this.comboBoxPredmetVypis.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPredmetVypis.FormattingEnabled = true;
            this.comboBoxPredmetVypis.Items.AddRange(new object[] {
            "ANJ",
            "CJL",
            "MAT",
            "ELN",
            "ELM"});
            this.comboBoxPredmetVypis.Location = new System.Drawing.Point(167, 200);
            this.comboBoxPredmetVypis.Name = "comboBoxPredmetVypis";
            this.comboBoxPredmetVypis.Size = new System.Drawing.Size(121, 24);
            this.comboBoxPredmetVypis.TabIndex = 14;
            // 
            // comboBoxVahaVypis
            // 
            this.comboBoxVahaVypis.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxVahaVypis.FormattingEnabled = true;
            this.comboBoxVahaVypis.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.comboBoxVahaVypis.Location = new System.Drawing.Point(167, 256);
            this.comboBoxVahaVypis.Name = "comboBoxVahaVypis";
            this.comboBoxVahaVypis.Size = new System.Drawing.Size(121, 24);
            this.comboBoxVahaVypis.TabIndex = 16;
            // 
            // buttonVahaVypis
            // 
            this.buttonVahaVypis.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonVahaVypis.Location = new System.Drawing.Point(16, 256);
            this.buttonVahaVypis.Name = "buttonVahaVypis";
            this.buttonVahaVypis.Size = new System.Drawing.Size(145, 24);
            this.buttonVahaVypis.TabIndex = 15;
            this.buttonVahaVypis.Text = "Piš známky stejné váhy: ";
            this.buttonVahaVypis.UseVisualStyleBackColor = true;
            this.buttonVahaVypis.Click += new System.EventHandler(this.buttonVahaVypis_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(13, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Průměr vybraného předmětu:";
            // 
            // textBoxPrumerPredmet
            // 
            this.textBoxPrumerPredmet.Location = new System.Drawing.Point(177, 230);
            this.textBoxPrumerPredmet.Name = "textBoxPrumerPredmet";
            this.textBoxPrumerPredmet.ReadOnly = true;
            this.textBoxPrumerPredmet.Size = new System.Drawing.Size(47, 20);
            this.textBoxPrumerPredmet.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 297);
            this.Controls.Add(this.textBoxPrumerPredmet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxVahaVypis);
            this.Controls.Add(this.buttonVahaVypis);
            this.Controls.Add(this.comboBoxPredmetVypis);
            this.Controls.Add(this.buttonPredmetVypis);
            this.Controls.Add(this.comboBoxPredmet);
            this.Controls.Add(this.buttonKonec);
            this.Controls.Add(this.textBoxPrumer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBoxPrehled);
            this.Controls.Add(this.textBoxPocetZadanych);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonZadat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownVaha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownZnamka);
            this.Name = "Form1";
            this.Text = "Vážená známka";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZnamka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVaha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownZnamka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownVaha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonZadat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPocetZadanych;
        private System.Windows.Forms.ListBox listBoxPrehled;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPrumer;
        private System.Windows.Forms.Button buttonKonec;
        private System.Windows.Forms.ComboBox comboBoxPredmet;
        private System.Windows.Forms.Button buttonPredmetVypis;
        private System.Windows.Forms.ComboBox comboBoxPredmetVypis;
        private System.Windows.Forms.ComboBox comboBoxVahaVypis;
        private System.Windows.Forms.Button buttonVahaVypis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxPrumerPredmet;
    }
}

