
namespace Buchtík_2023_02_06_test
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
            this.textBoxPolomer = new System.Windows.Forms.TextBox();
            this.buttonZadat = new System.Windows.Forms.Button();
            this.textBoxObvod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxObsah = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonSourX = new System.Windows.Forms.Button();
            this.textBoxSourX = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonSourY = new System.Windows.Forms.Button();
            this.textBoxSourY = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Test - kružnice";
            // 
            // textBoxPolomer
            // 
            this.textBoxPolomer.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPolomer.Location = new System.Drawing.Point(71, 44);
            this.textBoxPolomer.Name = "textBoxPolomer";
            this.textBoxPolomer.Size = new System.Drawing.Size(100, 23);
            this.textBoxPolomer.TabIndex = 1;
            // 
            // buttonZadat
            // 
            this.buttonZadat.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonZadat.Location = new System.Drawing.Point(177, 44);
            this.buttonZadat.Name = "buttonZadat";
            this.buttonZadat.Size = new System.Drawing.Size(75, 23);
            this.buttonZadat.TabIndex = 2;
            this.buttonZadat.Text = "Zadat poloměr";
            this.buttonZadat.UseVisualStyleBackColor = true;
            this.buttonZadat.Click += new System.EventHandler(this.buttonZadat_Click);
            // 
            // textBoxObvod
            // 
            this.textBoxObvod.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxObvod.Location = new System.Drawing.Point(57, 161);
            this.textBoxObvod.Name = "textBoxObvod";
            this.textBoxObvod.ReadOnly = true;
            this.textBoxObvod.Size = new System.Drawing.Size(140, 23);
            this.textBoxObvod.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(13, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Obvod:";
            // 
            // textBoxObsah
            // 
            this.textBoxObsah.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxObsah.Location = new System.Drawing.Point(57, 190);
            this.textBoxObsah.Name = "textBoxObsah";
            this.textBoxObsah.ReadOnly = true;
            this.textBoxObsah.Size = new System.Drawing.Size(140, 23);
            this.textBoxObsah.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(13, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Obsah:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(13, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Poloměr:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(13, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Souřadnice x:";
            // 
            // buttonSourX
            // 
            this.buttonSourX.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSourX.Location = new System.Drawing.Point(202, 88);
            this.buttonSourX.Name = "buttonSourX";
            this.buttonSourX.Size = new System.Drawing.Size(75, 23);
            this.buttonSourX.TabIndex = 9;
            this.buttonSourX.Text = "Zadat poloměr";
            this.buttonSourX.UseVisualStyleBackColor = true;
            this.buttonSourX.Click += new System.EventHandler(this.buttonSourX_Click);
            // 
            // textBoxSourX
            // 
            this.textBoxSourX.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSourX.Location = new System.Drawing.Point(96, 88);
            this.textBoxSourX.Name = "textBoxSourX";
            this.textBoxSourX.Size = new System.Drawing.Size(100, 23);
            this.textBoxSourX.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(13, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Souřadnice y:";
            // 
            // buttonSourY
            // 
            this.buttonSourY.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSourY.Location = new System.Drawing.Point(202, 117);
            this.buttonSourY.Name = "buttonSourY";
            this.buttonSourY.Size = new System.Drawing.Size(75, 23);
            this.buttonSourY.TabIndex = 12;
            this.buttonSourY.Text = "Zadat poloměr";
            this.buttonSourY.UseVisualStyleBackColor = true;
            this.buttonSourY.Click += new System.EventHandler(this.buttonSourY_Click);
            // 
            // textBoxSourY
            // 
            this.textBoxSourY.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSourY.Location = new System.Drawing.Point(96, 117);
            this.textBoxSourY.Name = "textBoxSourY";
            this.textBoxSourY.Size = new System.Drawing.Size(100, 23);
            this.textBoxSourY.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 250);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonSourY);
            this.Controls.Add(this.textBoxSourY);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonSourX);
            this.Controls.Add(this.textBoxSourX);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxObsah);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxObvod);
            this.Controls.Add(this.buttonZadat);
            this.Controls.Add(this.textBoxPolomer);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPolomer;
        private System.Windows.Forms.Button buttonZadat;
        private System.Windows.Forms.TextBox textBoxObvod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxObsah;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonSourX;
        private System.Windows.Forms.TextBox textBoxSourX;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonSourY;
        private System.Windows.Forms.TextBox textBoxSourY;
    }
}

