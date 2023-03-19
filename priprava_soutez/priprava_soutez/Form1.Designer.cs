namespace priprava_soutez
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonZobrazit = new System.Windows.Forms.Button();
            this.colorDialogVyplnit = new System.Windows.Forms.ColorDialog();
            this.panelKresleni = new System.Windows.Forms.Panel();
            this.buttonVyplnit = new System.Windows.Forms.Button();
            this.buttonVyberObrazku = new System.Windows.Forms.Button();
            this.pictureBoxVyberObrazku = new System.Windows.Forms.PictureBox();
            this.labelFileName = new System.Windows.Forms.Label();
            this.listBoxSlova = new System.Windows.Forms.ListBox();
            this.buttonVybratTxt = new System.Windows.Forms.Button();
            this.textBoxSlova = new System.Windows.Forms.TextBox();
            this.buttonPridatSlovo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVyberObrazku)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(376, 223);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonZobrazit
            // 
            this.buttonZobrazit.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonZobrazit.Location = new System.Drawing.Point(12, 241);
            this.buttonZobrazit.Name = "buttonZobrazit";
            this.buttonZobrazit.Size = new System.Drawing.Size(376, 52);
            this.buttonZobrazit.TabIndex = 1;
            this.buttonZobrazit.Text = "Zobrazit obrázek";
            this.buttonZobrazit.UseVisualStyleBackColor = true;
            this.buttonZobrazit.Click += new System.EventHandler(this.buttonZobrazit_Click);
            // 
            // panelKresleni
            // 
            this.panelKresleni.Location = new System.Drawing.Point(394, 12);
            this.panelKresleni.Name = "panelKresleni";
            this.panelKresleni.Size = new System.Drawing.Size(400, 300);
            this.panelKresleni.TabIndex = 2;
            this.panelKresleni.Paint += new System.Windows.Forms.PaintEventHandler(this.panelKresleni_Paint);
            // 
            // buttonVyplnit
            // 
            this.buttonVyplnit.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonVyplnit.Location = new System.Drawing.Point(394, 318);
            this.buttonVyplnit.Name = "buttonVyplnit";
            this.buttonVyplnit.Size = new System.Drawing.Size(400, 52);
            this.buttonVyplnit.TabIndex = 3;
            this.buttonVyplnit.Text = "Vyplnit barvou";
            this.buttonVyplnit.UseVisualStyleBackColor = true;
            this.buttonVyplnit.Click += new System.EventHandler(this.buttonVyplnit_Click);
            // 
            // buttonVyberObrazku
            // 
            this.buttonVyberObrazku.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonVyberObrazku.Location = new System.Drawing.Point(12, 528);
            this.buttonVyberObrazku.Name = "buttonVyberObrazku";
            this.buttonVyberObrazku.Size = new System.Drawing.Size(376, 52);
            this.buttonVyberObrazku.TabIndex = 5;
            this.buttonVyberObrazku.Text = "Vybrat obrázek";
            this.buttonVyberObrazku.UseVisualStyleBackColor = true;
            this.buttonVyberObrazku.Click += new System.EventHandler(this.buttonVyberObrazku_Click);
            // 
            // pictureBoxVyberObrazku
            // 
            this.pictureBoxVyberObrazku.Location = new System.Drawing.Point(12, 299);
            this.pictureBoxVyberObrazku.Name = "pictureBoxVyberObrazku";
            this.pictureBoxVyberObrazku.Size = new System.Drawing.Size(376, 223);
            this.pictureBoxVyberObrazku.TabIndex = 4;
            this.pictureBoxVyberObrazku.TabStop = false;
            // 
            // labelFileName
            // 
            this.labelFileName.AutoSize = true;
            this.labelFileName.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFileName.Location = new System.Drawing.Point(394, 650);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(145, 29);
            this.labelFileName.TabIndex = 6;
            this.labelFileName.Text = "labelFileName";
            // 
            // listBoxSlova
            // 
            this.listBoxSlova.FormattingEnabled = true;
            this.listBoxSlova.ItemHeight = 20;
            this.listBoxSlova.Location = new System.Drawing.Point(394, 376);
            this.listBoxSlova.Name = "listBoxSlova";
            this.listBoxSlova.Size = new System.Drawing.Size(399, 204);
            this.listBoxSlova.TabIndex = 7;
            // 
            // buttonVybratTxt
            // 
            this.buttonVybratTxt.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonVybratTxt.Location = new System.Drawing.Point(394, 586);
            this.buttonVybratTxt.Name = "buttonVybratTxt";
            this.buttonVybratTxt.Size = new System.Drawing.Size(399, 52);
            this.buttonVybratTxt.TabIndex = 8;
            this.buttonVybratTxt.Text = "Vybrat soubor";
            this.buttonVybratTxt.UseVisualStyleBackColor = true;
            this.buttonVybratTxt.Click += new System.EventHandler(this.buttonVybratTxt_Click);
            // 
            // textBoxSlova
            // 
            this.textBoxSlova.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxSlova.Location = new System.Drawing.Point(394, 682);
            this.textBoxSlova.Name = "textBoxSlova";
            this.textBoxSlova.Size = new System.Drawing.Size(255, 36);
            this.textBoxSlova.TabIndex = 9;
            // 
            // buttonPridatSlovo
            // 
            this.buttonPridatSlovo.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPridatSlovo.Location = new System.Drawing.Point(394, 724);
            this.buttonPridatSlovo.Name = "buttonPridatSlovo";
            this.buttonPridatSlovo.Size = new System.Drawing.Size(255, 43);
            this.buttonPridatSlovo.TabIndex = 10;
            this.buttonPridatSlovo.Text = "Přidat slovo do souboru";
            this.buttonPridatSlovo.UseVisualStyleBackColor = true;
            this.buttonPridatSlovo.Click += new System.EventHandler(this.buttonPridatSlovo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 818);
            this.Controls.Add(this.buttonPridatSlovo);
            this.Controls.Add(this.textBoxSlova);
            this.Controls.Add(this.buttonVybratTxt);
            this.Controls.Add(this.listBoxSlova);
            this.Controls.Add(this.labelFileName);
            this.Controls.Add(this.buttonVyberObrazku);
            this.Controls.Add(this.pictureBoxVyberObrazku);
            this.Controls.Add(this.buttonVyplnit);
            this.Controls.Add(this.panelKresleni);
            this.Controls.Add(this.buttonZobrazit);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Příprava na soutěž";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVyberObrazku)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button buttonPridatSlovo;

        private System.Windows.Forms.TextBox textBoxSlova;

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonZobrazit;
        private System.Windows.Forms.ColorDialog colorDialogVyplnit;
        private System.Windows.Forms.Panel panelKresleni;
        private System.Windows.Forms.Button buttonVyplnit;
        private System.Windows.Forms.Button buttonVyberObrazku;
        private System.Windows.Forms.PictureBox pictureBoxVyberObrazku;
        private System.Windows.Forms.Label labelFileName;
        private System.Windows.Forms.ListBox listBoxSlova;
        private System.Windows.Forms.Button buttonVybratTxt;
    }
}

