
namespace Kalkulačka_v3
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
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.buttonVysledek = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonSci = new System.Windows.Forms.RadioButton();
            this.radioButtonOdc = new System.Windows.Forms.RadioButton();
            this.radioButtonNas = new System.Windows.Forms.RadioButton();
            this.radioButtonDel = new System.Windows.Forms.RadioButton();
            this.labelVysledek = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(61, 35);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(100, 20);
            this.textBoxA.TabIndex = 0;
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(61, 62);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(100, 20);
            this.textBoxB.TabIndex = 1;
            // 
            // buttonVysledek
            // 
            this.buttonVysledek.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVysledek.Location = new System.Drawing.Point(168, 35);
            this.buttonVysledek.Name = "buttonVysledek";
            this.buttonVysledek.Size = new System.Drawing.Size(75, 47);
            this.buttonVysledek.TabIndex = 2;
            this.buttonVysledek.Text = "Výsledek";
            this.buttonVysledek.UseVisualStyleBackColor = true;
            this.buttonVysledek.Click += new System.EventHandler(this.buttonVysledek_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Číslo A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Číslo B";
            // 
            // radioButtonSci
            // 
            this.radioButtonSci.AutoSize = true;
            this.radioButtonSci.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonSci.Location = new System.Drawing.Point(16, 88);
            this.radioButtonSci.Name = "radioButtonSci";
            this.radioButtonSci.Size = new System.Drawing.Size(61, 20);
            this.radioButtonSci.TabIndex = 5;
            this.radioButtonSci.TabStop = true;
            this.radioButtonSci.Text = "Sčítání";
            this.radioButtonSci.UseVisualStyleBackColor = true;
            // 
            // radioButtonOdc
            // 
            this.radioButtonOdc.AutoSize = true;
            this.radioButtonOdc.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonOdc.Location = new System.Drawing.Point(16, 114);
            this.radioButtonOdc.Name = "radioButtonOdc";
            this.radioButtonOdc.Size = new System.Drawing.Size(67, 20);
            this.radioButtonOdc.TabIndex = 6;
            this.radioButtonOdc.TabStop = true;
            this.radioButtonOdc.Text = "Odčítání";
            this.radioButtonOdc.UseVisualStyleBackColor = true;
            // 
            // radioButtonNas
            // 
            this.radioButtonNas.AutoSize = true;
            this.radioButtonNas.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonNas.Location = new System.Drawing.Point(16, 140);
            this.radioButtonNas.Name = "radioButtonNas";
            this.radioButtonNas.Size = new System.Drawing.Size(72, 20);
            this.radioButtonNas.TabIndex = 7;
            this.radioButtonNas.TabStop = true;
            this.radioButtonNas.Text = "Násobení";
            this.radioButtonNas.UseVisualStyleBackColor = true;
            // 
            // radioButtonDel
            // 
            this.radioButtonDel.AutoSize = true;
            this.radioButtonDel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonDel.Location = new System.Drawing.Point(16, 166);
            this.radioButtonDel.Name = "radioButtonDel";
            this.radioButtonDel.Size = new System.Drawing.Size(57, 20);
            this.radioButtonDel.TabIndex = 8;
            this.radioButtonDel.TabStop = true;
            this.radioButtonDel.Text = "Dělení";
            this.radioButtonDel.UseVisualStyleBackColor = true;
            // 
            // labelVysledek
            // 
            this.labelVysledek.AutoSize = true;
            this.labelVysledek.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelVysledek.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelVysledek.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVysledek.Location = new System.Drawing.Point(249, 47);
            this.labelVysledek.Name = "labelVysledek";
            this.labelVysledek.Size = new System.Drawing.Size(107, 25);
            this.labelVysledek.TabIndex = 9;
            this.labelVysledek.Text = "Zde výsledek";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Kalkulačka v3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 198);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelVysledek);
            this.Controls.Add(this.radioButtonDel);
            this.Controls.Add(this.radioButtonNas);
            this.Controls.Add(this.radioButtonOdc);
            this.Controls.Add(this.radioButtonSci);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonVysledek);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.Button buttonVysledek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButtonSci;
        private System.Windows.Forms.RadioButton radioButtonOdc;
        private System.Windows.Forms.RadioButton radioButtonNas;
        private System.Windows.Forms.RadioButton radioButtonDel;
        private System.Windows.Forms.Label labelVysledek;
        private System.Windows.Forms.Label label3;
    }
}

