
namespace kresleni_combobox
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
            this.comboBoxTvary = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelKresleni = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxTvary
            // 
            this.comboBoxTvary.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTvary.FormattingEnabled = true;
            this.comboBoxTvary.Items.AddRange(new object[] {
            "Soustředné kružnice",
            "Čtverce",
            "Náhodné kružnice",
            "Vlastní tvorba"});
            this.comboBoxTvary.Location = new System.Drawing.Point(74, 45);
            this.comboBoxTvary.Name = "comboBoxTvary";
            this.comboBoxTvary.Size = new System.Drawing.Size(148, 24);
            this.comboBoxTvary.TabIndex = 0;
            this.comboBoxTvary.SelectedIndexChanged += new System.EventHandler(this.comboBoxTvary_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kreslení / Combobox";
            // 
            // panelKresleni
            // 
            this.panelKresleni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelKresleni.Location = new System.Drawing.Point(228, 45);
            this.panelKresleni.Name = "panelKresleni";
            this.panelKresleni.Size = new System.Drawing.Size(600, 600);
            this.panelKresleni.TabIndex = 2;
            this.panelKresleni.Paint += new System.Windows.Forms.PaintEventHandler(this.panelKresleni_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Zvol tvar:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 663);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelKresleni);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxTvary);
            this.Name = "Form1";
            this.Text = "Kreslení / Combobox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTvary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelKresleni;
        private System.Windows.Forms.Label label2;
    }
}

