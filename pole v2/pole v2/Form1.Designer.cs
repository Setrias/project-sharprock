
namespace pole_v2
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
            this.listBoxPole = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonGenerace = new System.Windows.Forms.Button();
            this.buttonVypis = new System.Windows.Forms.Button();
            this.buttonVymaz = new System.Windows.Forms.Button();
            this.buttonSoucet = new System.Windows.Forms.Button();
            this.textBoxSoucet = new System.Windows.Forms.TextBox();
            this.buttonSoucetVetPad = new System.Windows.Forms.Button();
            this.textBoxSoucetVetPad = new System.Windows.Forms.TextBox();
            this.textBoxDolMez = new System.Windows.Forms.TextBox();
            this.textBoxHorMez = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxPole
            // 
            this.listBoxPole.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPole.FormattingEnabled = true;
            this.listBoxPole.ItemHeight = 16;
            this.listBoxPole.Location = new System.Drawing.Point(12, 35);
            this.listBoxPole.Name = "listBoxPole";
            this.listBoxPole.Size = new System.Drawing.Size(132, 180);
            this.listBoxPole.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pole";
            // 
            // buttonGenerace
            // 
            this.buttonGenerace.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenerace.Location = new System.Drawing.Point(150, 35);
            this.buttonGenerace.Name = "buttonGenerace";
            this.buttonGenerace.Size = new System.Drawing.Size(103, 23);
            this.buttonGenerace.TabIndex = 2;
            this.buttonGenerace.Text = "Generace pole";
            this.buttonGenerace.UseVisualStyleBackColor = true;
            this.buttonGenerace.Click += new System.EventHandler(this.buttonGenerace_Click);
            // 
            // buttonVypis
            // 
            this.buttonVypis.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVypis.Location = new System.Drawing.Point(150, 64);
            this.buttonVypis.Name = "buttonVypis";
            this.buttonVypis.Size = new System.Drawing.Size(103, 23);
            this.buttonVypis.TabIndex = 3;
            this.buttonVypis.Text = "Výpis čísel";
            this.buttonVypis.UseVisualStyleBackColor = true;
            this.buttonVypis.Click += new System.EventHandler(this.buttonVypis_Click);
            // 
            // buttonVymaz
            // 
            this.buttonVymaz.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVymaz.Location = new System.Drawing.Point(150, 93);
            this.buttonVymaz.Name = "buttonVymaz";
            this.buttonVymaz.Size = new System.Drawing.Size(103, 23);
            this.buttonVymaz.TabIndex = 4;
            this.buttonVymaz.Text = "Vymazat";
            this.buttonVymaz.UseVisualStyleBackColor = true;
            this.buttonVymaz.Click += new System.EventHandler(this.buttonVymaz_Click);
            // 
            // buttonSoucet
            // 
            this.buttonSoucet.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSoucet.Location = new System.Drawing.Point(150, 122);
            this.buttonSoucet.Name = "buttonSoucet";
            this.buttonSoucet.Size = new System.Drawing.Size(103, 23);
            this.buttonSoucet.TabIndex = 5;
            this.buttonSoucet.Text = "Součet";
            this.buttonSoucet.UseVisualStyleBackColor = true;
            this.buttonSoucet.Click += new System.EventHandler(this.buttonSoucet_Click);
            // 
            // textBoxSoucet
            // 
            this.textBoxSoucet.Location = new System.Drawing.Point(259, 124);
            this.textBoxSoucet.Name = "textBoxSoucet";
            this.textBoxSoucet.ReadOnly = true;
            this.textBoxSoucet.Size = new System.Drawing.Size(100, 20);
            this.textBoxSoucet.TabIndex = 7;
            // 
            // buttonSoucetVetPad
            // 
            this.buttonSoucetVetPad.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSoucetVetPad.Location = new System.Drawing.Point(150, 151);
            this.buttonSoucetVetPad.Name = "buttonSoucetVetPad";
            this.buttonSoucetVetPad.Size = new System.Drawing.Size(103, 23);
            this.buttonSoucetVetPad.TabIndex = 8;
            this.buttonSoucetVetPad.Text = "Součet cislo > 50";
            this.buttonSoucetVetPad.UseVisualStyleBackColor = true;
            this.buttonSoucetVetPad.Click += new System.EventHandler(this.buttonSoucetVetPad_Click);
            // 
            // textBoxSoucetVetPad
            // 
            this.textBoxSoucetVetPad.Location = new System.Drawing.Point(259, 153);
            this.textBoxSoucetVetPad.Name = "textBoxSoucetVetPad";
            this.textBoxSoucetVetPad.ReadOnly = true;
            this.textBoxSoucetVetPad.Size = new System.Drawing.Size(100, 20);
            this.textBoxSoucetVetPad.TabIndex = 9;
            // 
            // textBoxDolMez
            // 
            this.textBoxDolMez.Location = new System.Drawing.Point(259, 37);
            this.textBoxDolMez.Name = "textBoxDolMez";
            this.textBoxDolMez.Size = new System.Drawing.Size(54, 20);
            this.textBoxDolMez.TabIndex = 10;
            // 
            // textBoxHorMez
            // 
            this.textBoxHorMez.Location = new System.Drawing.Point(322, 37);
            this.textBoxHorMez.Name = "textBoxHorMez";
            this.textBoxHorMez.Size = new System.Drawing.Size(56, 20);
            this.textBoxHorMez.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(258, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Dolní mez";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(321, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Horní mez";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 228);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxHorMez);
            this.Controls.Add(this.textBoxDolMez);
            this.Controls.Add(this.textBoxSoucetVetPad);
            this.Controls.Add(this.buttonSoucetVetPad);
            this.Controls.Add(this.textBoxSoucet);
            this.Controls.Add(this.buttonSoucet);
            this.Controls.Add(this.buttonVymaz);
            this.Controls.Add(this.buttonVypis);
            this.Controls.Add(this.buttonGenerace);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxPole);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox textBoxDolMez;
        private System.Windows.Forms.TextBox textBoxHorMez;

        private System.Windows.Forms.Button buttonSoucetVetPad;
        private System.Windows.Forms.TextBox textBoxSoucetVetPad;

        #endregion

        private System.Windows.Forms.ListBox listBoxPole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonGenerace;
        private System.Windows.Forms.Button buttonVypis;
        private System.Windows.Forms.Button buttonVymaz;
        private System.Windows.Forms.Button buttonSoucet;
        private System.Windows.Forms.TextBox textBoxSoucet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

