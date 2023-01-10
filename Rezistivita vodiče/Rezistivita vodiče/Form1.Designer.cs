
namespace Rezistivita_vodiče
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDelka = new System.Windows.Forms.TextBox();
            this.textBoxPrumer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelVysledek = new System.Windows.Forms.Label();
            this.buttonVysledek = new System.Windows.Forms.Button();
            this.radioButtonAl = new System.Windows.Forms.RadioButton();
            this.radioButtonCu = new System.Windows.Forms.RadioButton();
            this.radioButtonAg = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Odpor vodiče";
            // 
            // textBoxDelka
            // 
            this.textBoxDelka.Location = new System.Drawing.Point(128, 41);
            this.textBoxDelka.Name = "textBoxDelka";
            this.textBoxDelka.Size = new System.Drawing.Size(100, 20);
            this.textBoxDelka.TabIndex = 1;
            // 
            // textBoxPrumer
            // 
            this.textBoxPrumer.Location = new System.Drawing.Point(128, 68);
            this.textBoxPrumer.Name = "textBoxPrumer";
            this.textBoxPrumer.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrumer.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Délka vodiče [m]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Průměr vodiče [mm]";
            // 
            // labelVysledek
            // 
            this.labelVysledek.AutoSize = true;
            this.labelVysledek.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelVysledek.Location = new System.Drawing.Point(327, 53);
            this.labelVysledek.Name = "labelVysledek";
            this.labelVysledek.Size = new System.Drawing.Size(64, 19);
            this.labelVysledek.TabIndex = 5;
            this.labelVysledek.Text = "Výsledek";
            // 
            // buttonVysledek
            // 
            this.buttonVysledek.Location = new System.Drawing.Point(235, 41);
            this.buttonVysledek.Name = "buttonVysledek";
            this.buttonVysledek.Size = new System.Drawing.Size(86, 47);
            this.buttonVysledek.TabIndex = 6;
            this.buttonVysledek.Text = "Odpor vodiče";
            this.buttonVysledek.UseVisualStyleBackColor = true;
            this.buttonVysledek.Click += new System.EventHandler(this.buttonVysledek_Click);
            // 
            // radioButtonAl
            // 
            this.radioButtonAl.AutoSize = true;
            this.radioButtonAl.Checked = true;
            this.radioButtonAl.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAl.Location = new System.Drawing.Point(15, 94);
            this.radioButtonAl.Name = "radioButtonAl";
            this.radioButtonAl.Size = new System.Drawing.Size(181, 20);
            this.radioButtonAl.TabIndex = 7;
            this.radioButtonAl.TabStop = true;
            this.radioButtonAl.Text = "Aluminium (Hliník) 28 nOhm*m";
            this.radioButtonAl.UseVisualStyleBackColor = true;
            // 
            // radioButtonCu
            // 
            this.radioButtonCu.AutoSize = true;
            this.radioButtonCu.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCu.Location = new System.Drawing.Point(15, 120);
            this.radioButtonCu.Name = "radioButtonCu";
            this.radioButtonCu.Size = new System.Drawing.Size(155, 20);
            this.radioButtonCu.TabIndex = 8;
            this.radioButtonCu.Text = "Copper (Měď) 18 nOhm*m";
            this.radioButtonCu.UseVisualStyleBackColor = true;
            // 
            // radioButtonAg
            // 
            this.radioButtonAg.AutoSize = true;
            this.radioButtonAg.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAg.Location = new System.Drawing.Point(15, 146);
            this.radioButtonAg.Name = "radioButtonAg";
            this.radioButtonAg.Size = new System.Drawing.Size(183, 20);
            this.radioButtonAg.TabIndex = 9;
            this.radioButtonAg.Text = "Argentum (Stříbro) 17 nOhm*m";
            this.radioButtonAg.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 184);
            this.Controls.Add(this.radioButtonAg);
            this.Controls.Add(this.radioButtonCu);
            this.Controls.Add(this.radioButtonAl);
            this.Controls.Add(this.buttonVysledek);
            this.Controls.Add(this.labelVysledek);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPrumer);
            this.Controls.Add(this.textBoxDelka);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Výpočet odporu vodiče";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDelka;
        private System.Windows.Forms.TextBox textBoxPrumer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelVysledek;
        private System.Windows.Forms.Button buttonVysledek;
        private System.Windows.Forms.RadioButton radioButtonAl;
        private System.Windows.Forms.RadioButton radioButtonCu;
        private System.Windows.Forms.RadioButton radioButtonAg;
    }
}

