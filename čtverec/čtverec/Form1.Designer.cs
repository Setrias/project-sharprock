
namespace čtverec
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
            this.labelObvod = new System.Windows.Forms.Label();
            this.textBoxObvod = new System.Windows.Forms.TextBox();
            this.buttonObvod = new System.Windows.Forms.Button();
            this.labelVysledekObvod = new System.Windows.Forms.Label();
            this.labelVysledekObsah = new System.Windows.Forms.Label();
            this.buttonObsah = new System.Windows.Forms.Button();
            this.textBoxObsah = new System.Windows.Forms.TextBox();
            this.labelObsah = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(44, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Obvod a obsah čtverce";
            // 
            // labelObvod
            // 
            this.labelObvod.AutoSize = true;
            this.labelObvod.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelObvod.Location = new System.Drawing.Point(26, 73);
            this.labelObvod.Name = "labelObvod";
            this.labelObvod.Size = new System.Drawing.Size(70, 16);
            this.labelObvod.TabIndex = 1;
            this.labelObvod.Text = "délka strany";
            // 
            // textBoxObvod
            // 
            this.textBoxObvod.Location = new System.Drawing.Point(103, 73);
            this.textBoxObvod.Name = "textBoxObvod";
            this.textBoxObvod.Size = new System.Drawing.Size(100, 20);
            this.textBoxObvod.TabIndex = 2;
            // 
            // buttonObvod
            // 
            this.buttonObvod.Location = new System.Drawing.Point(208, 71);
            this.buttonObvod.Name = "buttonObvod";
            this.buttonObvod.Size = new System.Drawing.Size(100, 25);
            this.buttonObvod.TabIndex = 3;
            this.buttonObvod.Text = "obvod";
            this.buttonObvod.UseVisualStyleBackColor = true;
            this.buttonObvod.Click += new System.EventHandler(this.buttonObvod_Click);
            // 
            // labelVysledekObvod
            // 
            this.labelVysledekObvod.AutoSize = true;
            this.labelVysledekObvod.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelVysledekObvod.Location = new System.Drawing.Point(314, 76);
            this.labelVysledekObvod.Name = "labelVysledekObvod";
            this.labelVysledekObvod.Size = new System.Drawing.Size(0, 16);
            this.labelVysledekObvod.TabIndex = 4;
            // 
            // labelVysledekObsah
            // 
            this.labelVysledekObsah.AutoSize = true;
            this.labelVysledekObsah.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelVysledekObsah.Location = new System.Drawing.Point(314, 107);
            this.labelVysledekObsah.Name = "labelVysledekObsah";
            this.labelVysledekObsah.Size = new System.Drawing.Size(0, 16);
            this.labelVysledekObsah.TabIndex = 8;
            // 
            // buttonObsah
            // 
            this.buttonObsah.Location = new System.Drawing.Point(208, 102);
            this.buttonObsah.Name = "buttonObsah";
            this.buttonObsah.Size = new System.Drawing.Size(100, 25);
            this.buttonObsah.TabIndex = 7;
            this.buttonObsah.Text = "obsah";
            this.buttonObsah.UseVisualStyleBackColor = true;
            this.buttonObsah.Click += new System.EventHandler(this.buttonObsah_Click);
            // 
            // textBoxObsah
            // 
            this.textBoxObsah.Location = new System.Drawing.Point(103, 104);
            this.textBoxObsah.Name = "textBoxObsah";
            this.textBoxObsah.Size = new System.Drawing.Size(100, 20);
            this.textBoxObsah.TabIndex = 6;
            // 
            // labelObsah
            // 
            this.labelObsah.AutoSize = true;
            this.labelObsah.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelObsah.Location = new System.Drawing.Point(26, 104);
            this.labelObsah.Name = "labelObsah";
            this.labelObsah.Size = new System.Drawing.Size(79, 16);
            this.labelObsah.TabIndex = 5;
            this.labelObsah.Text = "obsah čtverce";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelVysledekObsah);
            this.Controls.Add(this.buttonObsah);
            this.Controls.Add(this.textBoxObsah);
            this.Controls.Add(this.labelObsah);
            this.Controls.Add(this.labelVysledekObvod);
            this.Controls.Add(this.buttonObvod);
            this.Controls.Add(this.textBoxObvod);
            this.Controls.Add(this.labelObvod);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelObvod;
        private System.Windows.Forms.TextBox textBoxObvod;
        private System.Windows.Forms.Button buttonObvod;
        private System.Windows.Forms.Label labelVysledekObvod;
        private System.Windows.Forms.Label labelVysledekObsah;
        private System.Windows.Forms.Button buttonObsah;
        private System.Windows.Forms.TextBox textBoxObsah;
        private System.Windows.Forms.Label labelObsah;
    }
}

