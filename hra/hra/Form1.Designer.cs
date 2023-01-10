
namespace hra
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
            this.textBoxZadat = new System.Windows.Forms.TextBox();
            this.buttonZacit = new System.Windows.Forms.Button();
            this.buttonZadat = new System.Windows.Forms.Button();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.labelNapoveda = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelPocetPokusu = new System.Windows.Forms.Label();
            this.pictureBoxWin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWin)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hra - Hádání čísel";
            // 
            // textBoxZadat
            // 
            this.textBoxZadat.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxZadat.Location = new System.Drawing.Point(12, 80);
            this.textBoxZadat.Name = "textBoxZadat";
            this.textBoxZadat.Size = new System.Drawing.Size(37, 23);
            this.textBoxZadat.TabIndex = 1;
            // 
            // buttonZacit
            // 
            this.buttonZacit.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonZacit.Location = new System.Drawing.Point(12, 35);
            this.buttonZacit.Name = "buttonZacit";
            this.buttonZacit.Size = new System.Drawing.Size(140, 23);
            this.buttonZacit.TabIndex = 2;
            this.buttonZacit.Text = "Začít hru";
            this.buttonZacit.UseVisualStyleBackColor = true;
            this.buttonZacit.Click += new System.EventHandler(this.buttonZacit_Click);
            // 
            // buttonZadat
            // 
            this.buttonZadat.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonZadat.Location = new System.Drawing.Point(55, 80);
            this.buttonZadat.Name = "buttonZadat";
            this.buttonZadat.Size = new System.Drawing.Size(97, 23);
            this.buttonZadat.TabIndex = 3;
            this.buttonZadat.Text = "Zadat číslo";
            this.buttonZadat.UseVisualStyleBackColor = true;
            this.buttonZadat.Click += new System.EventHandler(this.buttonZadat_Click);
            // 
            // buttonRestart
            // 
            this.buttonRestart.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRestart.Location = new System.Drawing.Point(12, 128);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(140, 23);
            this.buttonRestart.TabIndex = 4;
            this.buttonRestart.Text = "Restart hry";
            this.buttonRestart.UseVisualStyleBackColor = true;
            this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // labelNapoveda
            // 
            this.labelNapoveda.AutoSize = true;
            this.labelNapoveda.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNapoveda.Location = new System.Drawing.Point(29, 106);
            this.labelNapoveda.Name = "labelNapoveda";
            this.labelNapoveda.Size = new System.Drawing.Size(102, 19);
            this.labelNapoveda.TabIndex = 5;
            this.labelNapoveda.Text = "labelNapoveda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(13, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Počet pokusů:";
            // 
            // labelPocetPokusu
            // 
            this.labelPocetPokusu.AutoSize = true;
            this.labelPocetPokusu.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPocetPokusu.Location = new System.Drawing.Point(93, 61);
            this.labelPocetPokusu.Name = "labelPocetPokusu";
            this.labelPocetPokusu.Size = new System.Drawing.Size(37, 16);
            this.labelPocetPokusu.TabIndex = 7;
            this.labelPocetPokusu.Text = "pokus";
            // 
            // pictureBoxWin
            // 
            this.pictureBoxWin.Image = global::hra.Properties.Resources.you_win__250x141_;
            this.pictureBoxWin.InitialImage = null;
            this.pictureBoxWin.Location = new System.Drawing.Point(158, 12);
            this.pictureBoxWin.Name = "pictureBoxWin";
            this.pictureBoxWin.Size = new System.Drawing.Size(247, 138);
            this.pictureBoxWin.TabIndex = 8;
            this.pictureBoxWin.TabStop = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.buttonZadat;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(417, 162);
            this.Controls.Add(this.pictureBoxWin);
            this.Controls.Add(this.labelPocetPokusu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelNapoveda);
            this.Controls.Add(this.buttonRestart);
            this.Controls.Add(this.buttonZadat);
            this.Controls.Add(this.buttonZacit);
            this.Controls.Add(this.textBoxZadat);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Hádání čísel";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxZadat;
        private System.Windows.Forms.Button buttonZacit;
        private System.Windows.Forms.Button buttonZadat;
        private System.Windows.Forms.Button buttonRestart;
        private System.Windows.Forms.Label labelNapoveda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelPocetPokusu;
        private System.Windows.Forms.PictureBox pictureBoxWin;
    }
}

