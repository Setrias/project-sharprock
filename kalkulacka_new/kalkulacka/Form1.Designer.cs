namespace kalkulacka
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
            this.radioButtonPlus = new System.Windows.Forms.RadioButton();
            this.radioButtonMinus = new System.Windows.Forms.RadioButton();
            this.radioButtonKrat = new System.Windows.Forms.RadioButton();
            this.radioButtonDeleno = new System.Windows.Forms.RadioButton();
            this.numericUpDownX = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxVysledek = new System.Windows.Forms.TextBox();
            this.numericUpDownY = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButtonPlus
            // 
            this.radioButtonPlus.AutoSize = true;
            this.radioButtonPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonPlus.Location = new System.Drawing.Point(248, 72);
            this.radioButtonPlus.Name = "radioButtonPlus";
            this.radioButtonPlus.Size = new System.Drawing.Size(42, 29);
            this.radioButtonPlus.TabIndex = 0;
            this.radioButtonPlus.TabStop = true;
            this.radioButtonPlus.Text = "+";
            this.radioButtonPlus.UseVisualStyleBackColor = true;
            this.radioButtonPlus.CheckedChanged += new System.EventHandler(this.radioButtonPlus_CheckedChanged);
            // 
            // radioButtonMinus
            // 
            this.radioButtonMinus.AutoSize = true;
            this.radioButtonMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonMinus.Location = new System.Drawing.Point(248, 107);
            this.radioButtonMinus.Name = "radioButtonMinus";
            this.radioButtonMinus.Size = new System.Drawing.Size(37, 29);
            this.radioButtonMinus.TabIndex = 1;
            this.radioButtonMinus.TabStop = true;
            this.radioButtonMinus.Text = "-";
            this.radioButtonMinus.UseVisualStyleBackColor = true;
            this.radioButtonMinus.CheckedChanged += new System.EventHandler(this.radioButtonPlus_CheckedChanged);
            // 
            // radioButtonKrat
            // 
            this.radioButtonKrat.AutoSize = true;
            this.radioButtonKrat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonKrat.Location = new System.Drawing.Point(248, 142);
            this.radioButtonKrat.Name = "radioButtonKrat";
            this.radioButtonKrat.Size = new System.Drawing.Size(38, 29);
            this.radioButtonKrat.TabIndex = 2;
            this.radioButtonKrat.TabStop = true;
            this.radioButtonKrat.Text = "*";
            this.radioButtonKrat.UseVisualStyleBackColor = true;
            this.radioButtonKrat.CheckedChanged += new System.EventHandler(this.radioButtonPlus_CheckedChanged);
            // 
            // radioButtonDeleno
            // 
            this.radioButtonDeleno.AutoSize = true;
            this.radioButtonDeleno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonDeleno.Location = new System.Drawing.Point(248, 177);
            this.radioButtonDeleno.Name = "radioButtonDeleno";
            this.radioButtonDeleno.Size = new System.Drawing.Size(36, 29);
            this.radioButtonDeleno.TabIndex = 3;
            this.radioButtonDeleno.TabStop = true;
            this.radioButtonDeleno.Text = ":";
            this.radioButtonDeleno.UseVisualStyleBackColor = true;
            this.radioButtonDeleno.CheckedChanged += new System.EventHandler(this.radioButtonPlus_CheckedChanged);
            // 
            // numericUpDownX
            // 
            this.numericUpDownX.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDownX.Location = new System.Drawing.Point(146, 118);
            this.numericUpDownX.Name = "numericUpDownX";
            this.numericUpDownX.Size = new System.Drawing.Size(67, 38);
            this.numericUpDownX.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(205, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kalkulačka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(408, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "=";
            // 
            // textBoxVysledek
            // 
            this.textBoxVysledek.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxVysledek.Location = new System.Drawing.Point(445, 118);
            this.textBoxVysledek.Name = "textBoxVysledek";
            this.textBoxVysledek.Size = new System.Drawing.Size(121, 38);
            this.textBoxVysledek.TabIndex = 8;
            // 
            // numericUpDownY
            // 
            this.numericUpDownY.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDownY.Location = new System.Drawing.Point(322, 118);
            this.numericUpDownY.Name = "numericUpDownY";
            this.numericUpDownY.Size = new System.Drawing.Size(67, 38);
            this.numericUpDownY.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numericUpDownY);
            this.Controls.Add(this.textBoxVysledek);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownX);
            this.Controls.Add(this.radioButtonDeleno);
            this.Controls.Add(this.radioButtonKrat);
            this.Controls.Add(this.radioButtonMinus);
            this.Controls.Add(this.radioButtonPlus);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonPlus;
        private System.Windows.Forms.RadioButton radioButtonMinus;
        private System.Windows.Forms.RadioButton radioButtonKrat;
        private System.Windows.Forms.RadioButton radioButtonDeleno;
        private System.Windows.Forms.NumericUpDown numericUpDownX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxVysledek;
        private System.Windows.Forms.NumericUpDown numericUpDownY;
    }
}

