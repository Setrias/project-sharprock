
namespace Botek_hraci_pole
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
            this.numericUpDownX = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownY = new System.Windows.Forms.NumericUpDown();
            this.labelSourX = new System.Windows.Forms.Label();
            this.labelSourY = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxVypis = new System.Windows.Forms.ListBox();
            this.textBoxBarva = new System.Windows.Forms.TextBox();
            this.buttonPozice = new System.Windows.Forms.Button();
            this.buttonUloz = new System.Windows.Forms.Button();
            this.panelKresleni = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownX
            // 
            this.numericUpDownX.Location = new System.Drawing.Point(117, 38);
            this.numericUpDownX.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownX.Name = "numericUpDownX";
            this.numericUpDownX.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownX.TabIndex = 0;
            this.numericUpDownX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownY
            // 
            this.numericUpDownY.Location = new System.Drawing.Point(117, 64);
            this.numericUpDownY.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownY.Name = "numericUpDownY";
            this.numericUpDownY.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownY.TabIndex = 1;
            this.numericUpDownY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelSourX
            // 
            this.labelSourX.AutoSize = true;
            this.labelSourX.Location = new System.Drawing.Point(38, 40);
            this.labelSourX.Name = "labelSourX";
            this.labelSourX.Size = new System.Drawing.Size(73, 13);
            this.labelSourX.TabIndex = 2;
            this.labelSourX.Text = "souřadnice X:";
            // 
            // labelSourY
            // 
            this.labelSourY.AutoSize = true;
            this.labelSourY.Location = new System.Drawing.Point(38, 66);
            this.labelSourY.Name = "labelSourY";
            this.labelSourY.Size = new System.Drawing.Size(73, 13);
            this.labelSourY.TabIndex = 3;
            this.labelSourY.Text = "souřadnice Y:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "barva:";
            // 
            // listBoxVypis
            // 
            this.listBoxVypis.FormattingEnabled = true;
            this.listBoxVypis.Location = new System.Drawing.Point(265, 213);
            this.listBoxVypis.Name = "listBoxVypis";
            this.listBoxVypis.Size = new System.Drawing.Size(207, 199);
            this.listBoxVypis.TabIndex = 6;
            // 
            // textBoxBarva
            // 
            this.textBoxBarva.Location = new System.Drawing.Point(117, 110);
            this.textBoxBarva.Name = "textBoxBarva";
            this.textBoxBarva.Size = new System.Drawing.Size(100, 20);
            this.textBoxBarva.TabIndex = 8;
            // 
            // buttonPozice
            // 
            this.buttonPozice.Location = new System.Drawing.Point(68, 248);
            this.buttonPozice.Name = "buttonPozice";
            this.buttonPozice.Size = new System.Drawing.Size(129, 114);
            this.buttonPozice.TabIndex = 9;
            this.buttonPozice.Text = "POZICE ČERNÝCH ŽETONŮ";
            this.buttonPozice.UseVisualStyleBackColor = true;
            this.buttonPozice.Click += new System.EventHandler(this.buttonPozice_Click);
            // 
            // buttonUloz
            // 
            this.buttonUloz.Location = new System.Drawing.Point(282, 56);
            this.buttonUloz.Name = "buttonUloz";
            this.buttonUloz.Size = new System.Drawing.Size(75, 23);
            this.buttonUloz.TabIndex = 10;
            this.buttonUloz.Text = "ulož";
            this.buttonUloz.UseVisualStyleBackColor = true;
            this.buttonUloz.Click += new System.EventHandler(this.buttonUloz_Click);
            // 
            // panelKresleni
            // 
            this.panelKresleni.Location = new System.Drawing.Point(660, 38);
            this.panelKresleni.Name = "panelKresleni";
            this.panelKresleni.Size = new System.Drawing.Size(501, 501);
            this.panelKresleni.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 601);
            this.Controls.Add(this.panelKresleni);
            this.Controls.Add(this.buttonUloz);
            this.Controls.Add(this.buttonPozice);
            this.Controls.Add(this.textBoxBarva);
            this.Controls.Add(this.listBoxVypis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelSourY);
            this.Controls.Add(this.labelSourX);
            this.Controls.Add(this.numericUpDownY);
            this.Controls.Add(this.numericUpDownX);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownX;
        private System.Windows.Forms.NumericUpDown numericUpDownY;
        private System.Windows.Forms.Label labelSourX;
        private System.Windows.Forms.Label labelSourY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxVypis;
        private System.Windows.Forms.TextBox textBoxBarva;
        private System.Windows.Forms.Button buttonPozice;
        private System.Windows.Forms.Button buttonUloz;
        private System.Windows.Forms.Panel panelKresleni;
    }
}

