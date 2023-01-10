
namespace Buchtík_hmotnost_kvádru
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
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonVysledek = new System.Windows.Forms.Button();
            this.labelVysledek = new System.Windows.Forms.Label();
            this.radioButtonLed = new System.Windows.Forms.RadioButton();
            this.radioButtonHlinik = new System.Windows.Forms.RadioButton();
            this.radioButtonZelezo = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hmotnost kvádru";
            // 
            // textBoxA
            // 
            this.textBoxA.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxA.Location = new System.Drawing.Point(55, 61);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(100, 23);
            this.textBoxA.TabIndex = 1;
            // 
            // textBoxB
            // 
            this.textBoxB.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxB.Location = new System.Drawing.Point(55, 90);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(100, 23);
            this.textBoxB.TabIndex = 2;
            // 
            // textBoxC
            // 
            this.textBoxC.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxC.Location = new System.Drawing.Point(55, 119);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(100, 23);
            this.textBoxC.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Délka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Výška";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Šířka";
            // 
            // buttonVysledek
            // 
            this.buttonVysledek.Location = new System.Drawing.Point(161, 61);
            this.buttonVysledek.Name = "buttonVysledek";
            this.buttonVysledek.Size = new System.Drawing.Size(124, 45);
            this.buttonVysledek.TabIndex = 7;
            this.buttonVysledek.Text = "Vypočítej";
            this.buttonVysledek.UseVisualStyleBackColor = true;
            this.buttonVysledek.Click += new System.EventHandler(this.buttonVysledek_Click);
            // 
            // labelVysledek
            // 
            this.labelVysledek.AutoSize = true;
            this.labelVysledek.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelVysledek.Location = new System.Drawing.Point(161, 119);
            this.labelVysledek.Name = "labelVysledek";
            this.labelVysledek.Size = new System.Drawing.Size(64, 19);
            this.labelVysledek.TabIndex = 8;
            this.labelVysledek.Text = "Výsledek";
            // 
            // radioButtonLed
            // 
            this.radioButtonLed.AutoSize = true;
            this.radioButtonLed.Checked = true;
            this.radioButtonLed.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonLed.Location = new System.Drawing.Point(16, 148);
            this.radioButtonLed.Name = "radioButtonLed";
            this.radioButtonLed.Size = new System.Drawing.Size(101, 20);
            this.radioButtonLed.TabIndex = 9;
            this.radioButtonLed.TabStop = true;
            this.radioButtonLed.Text = "Led 970 kg*m3";
            this.radioButtonLed.UseVisualStyleBackColor = true;
            // 
            // radioButtonHlinik
            // 
            this.radioButtonHlinik.AutoSize = true;
            this.radioButtonHlinik.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonHlinik.Location = new System.Drawing.Point(16, 174);
            this.radioButtonHlinik.Name = "radioButtonHlinik";
            this.radioButtonHlinik.Size = new System.Drawing.Size(117, 20);
            this.radioButtonHlinik.TabIndex = 10;
            this.radioButtonHlinik.TabStop = true;
            this.radioButtonHlinik.Text = "Hliník 2700 kg*m3";
            this.radioButtonHlinik.UseVisualStyleBackColor = true;
            // 
            // radioButtonZelezo
            // 
            this.radioButtonZelezo.AutoSize = true;
            this.radioButtonZelezo.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonZelezo.Location = new System.Drawing.Point(16, 200);
            this.radioButtonZelezo.Name = "radioButtonZelezo";
            this.radioButtonZelezo.Size = new System.Drawing.Size(122, 20);
            this.radioButtonZelezo.TabIndex = 11;
            this.radioButtonZelezo.TabStop = true;
            this.radioButtonZelezo.Text = "Železo 7800 kg*m3";
            this.radioButtonZelezo.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Hodnoty rozměru se zadávají v metrech.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 233);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.radioButtonZelezo);
            this.Controls.Add(this.radioButtonHlinik);
            this.Controls.Add(this.radioButtonLed);
            this.Controls.Add(this.labelVysledek);
            this.Controls.Add(this.buttonVysledek);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxC);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonVysledek;
        private System.Windows.Forms.Label labelVysledek;
        private System.Windows.Forms.RadioButton radioButtonLed;
        private System.Windows.Forms.RadioButton radioButtonHlinik;
        private System.Windows.Forms.RadioButton radioButtonZelezo;
        private System.Windows.Forms.Label label5;
    }
}

