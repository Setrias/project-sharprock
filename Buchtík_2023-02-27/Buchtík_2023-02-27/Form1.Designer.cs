
namespace Buchtík_2023_02_27
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
            this.panelKresleni = new System.Windows.Forms.Panel();
            this.numericUpDownSirka = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownVyska = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonNakreslit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelUrceni = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSirka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVyska)).BeginInit();
            this.SuspendLayout();
            // 
            // panelKresleni
            // 
            this.panelKresleni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelKresleni.Location = new System.Drawing.Point(13, 114);
            this.panelKresleni.Name = "panelKresleni";
            this.panelKresleni.Size = new System.Drawing.Size(300, 300);
            this.panelKresleni.TabIndex = 0;
            this.panelKresleni.Paint += new System.Windows.Forms.PaintEventHandler(this.panelKresleni_Paint);
            // 
            // numericUpDownSirka
            // 
            this.numericUpDownSirka.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownSirka.Location = new System.Drawing.Point(56, 37);
            this.numericUpDownSirka.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownSirka.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownSirka.Name = "numericUpDownSirka";
            this.numericUpDownSirka.Size = new System.Drawing.Size(66, 30);
            this.numericUpDownSirka.TabIndex = 1;
            this.numericUpDownSirka.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numericUpDownVyska
            // 
            this.numericUpDownVyska.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownVyska.Location = new System.Drawing.Point(56, 74);
            this.numericUpDownVyska.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownVyska.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownVyska.Name = "numericUpDownVyska";
            this.numericUpDownVyska.Size = new System.Drawing.Size(66, 30);
            this.numericUpDownVyska.TabIndex = 2;
            this.numericUpDownVyska.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Šířka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Výška";
            // 
            // buttonNakreslit
            // 
            this.buttonNakreslit.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNakreslit.Location = new System.Drawing.Point(128, 45);
            this.buttonNakreslit.Name = "buttonNakreslit";
            this.buttonNakreslit.Size = new System.Drawing.Size(75, 53);
            this.buttonNakreslit.TabIndex = 5;
            this.buttonNakreslit.Text = "Nakreslit";
            this.buttonNakreslit.UseVisualStyleBackColor = true;
            this.buttonNakreslit.Click += new System.EventHandler(this.buttonNakreslit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kreslení čtyřúhelníku";
            // 
            // labelUrceni
            // 
            this.labelUrceni.AutoSize = true;
            this.labelUrceni.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUrceni.Location = new System.Drawing.Point(209, 65);
            this.labelUrceni.Name = "labelUrceni";
            this.labelUrceni.Size = new System.Drawing.Size(65, 16);
            this.labelUrceni.TabIndex = 7;
            this.labelUrceni.Text = "labelUrceni";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 426);
            this.Controls.Add(this.labelUrceni);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonNakreslit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownVyska);
            this.Controls.Add(this.numericUpDownSirka);
            this.Controls.Add(this.panelKresleni);
            this.Name = "Form1";
            this.Text = "kreslení";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSirka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVyska)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelKresleni;
        private System.Windows.Forms.NumericUpDown numericUpDownSirka;
        private System.Windows.Forms.NumericUpDown numericUpDownVyska;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonNakreslit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelUrceni;
    }
}

