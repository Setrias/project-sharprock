namespace string_username
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxJmeno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPrijmeni = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.buttonVytvorit = new System.Windows.Forms.Button();
            this.buttonOpenSoubor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxJmeno
            // 
            this.textBoxJmeno.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxJmeno.Location = new System.Drawing.Point(72, 41);
            this.textBoxJmeno.Name = "textBoxJmeno";
            this.textBoxJmeno.Size = new System.Drawing.Size(144, 23);
            this.textBoxJmeno.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Jméno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Přijmení:";
            // 
            // textBoxPrijmeni
            // 
            this.textBoxPrijmeni.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrijmeni.Location = new System.Drawing.Point(72, 70);
            this.textBoxPrijmeni.Name = "textBoxPrijmeni";
            this.textBoxPrijmeni.Size = new System.Drawing.Size(144, 23);
            this.textBoxPrijmeni.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Vytvoření uživatelského jména:";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.Location = new System.Drawing.Point(12, 145);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.ReadOnly = true;
            this.textBoxUsername.Size = new System.Drawing.Size(204, 23);
            this.textBoxUsername.TabIndex = 3;
            // 
            // buttonVytvorit
            // 
            this.buttonVytvorit.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVytvorit.Location = new System.Drawing.Point(12, 99);
            this.buttonVytvorit.Name = "buttonVytvorit";
            this.buttonVytvorit.Size = new System.Drawing.Size(204, 40);
            this.buttonVytvorit.TabIndex = 2;
            this.buttonVytvorit.Text = "Vytvořit";
            this.buttonVytvorit.UseVisualStyleBackColor = true;
            this.buttonVytvorit.Click += new System.EventHandler(this.buttonVytvorit_Click);
            // 
            // buttonOpenSoubor
            // 
            this.buttonOpenSoubor.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpenSoubor.Location = new System.Drawing.Point(12, 174);
            this.buttonOpenSoubor.Name = "buttonOpenSoubor";
            this.buttonOpenSoubor.Size = new System.Drawing.Size(204, 40);
            this.buttonOpenSoubor.TabIndex = 5;
            this.buttonOpenSoubor.Text = "Otevřít soubor";
            this.buttonOpenSoubor.UseVisualStyleBackColor = true;
            this.buttonOpenSoubor.Click += new System.EventHandler(this.buttonOpenSoubor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 225);
            this.Controls.Add(this.buttonOpenSoubor);
            this.Controls.Add(this.buttonVytvorit);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPrijmeni);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxJmeno);
            this.Name = "Form1";
            this.Text = "Vytváření uživatelského jména";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button buttonOpenSoubor;

        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Button buttonVytvorit;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPrijmeni;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.TextBox textBoxJmeno;

        #endregion
    }
}