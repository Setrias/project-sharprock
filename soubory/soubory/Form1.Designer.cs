
namespace soubory
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
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxVypis = new System.Windows.Forms.ListBox();
            this.textBoxJmeno = new System.Windows.Forms.TextBox();
            this.buttonUlozit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonVypis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Práce se soubory";
            // 
            // listBoxVypis
            // 
            this.listBoxVypis.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxVypis.FormattingEnabled = true;
            this.listBoxVypis.ItemHeight = 16;
            this.listBoxVypis.Location = new System.Drawing.Point(238, 73);
            this.listBoxVypis.Name = "listBoxVypis";
            this.listBoxVypis.Size = new System.Drawing.Size(120, 84);
            this.listBoxVypis.TabIndex = 1;
            // 
            // textBoxJmeno
            // 
            this.textBoxJmeno.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxJmeno.Location = new System.Drawing.Point(118, 44);
            this.textBoxJmeno.Name = "textBoxJmeno";
            this.textBoxJmeno.Size = new System.Drawing.Size(100, 23);
            this.textBoxJmeno.TabIndex = 2;
            // 
            // buttonUlozit
            // 
            this.buttonUlozit.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUlozit.Location = new System.Drawing.Point(118, 73);
            this.buttonUlozit.Name = "buttonUlozit";
            this.buttonUlozit.Size = new System.Drawing.Size(100, 23);
            this.buttonUlozit.TabIndex = 3;
            this.buttonUlozit.Text = "Uložit";
            this.buttonUlozit.UseVisualStyleBackColor = true;
            this.buttonUlozit.Click += new System.EventHandler(this.buttonUlozit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Jméno a příjmení:";
            // 
            // buttonVypis
            // 
            this.buttonVypis.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVypis.Location = new System.Drawing.Point(238, 44);
            this.buttonVypis.Name = "buttonVypis";
            this.buttonVypis.Size = new System.Drawing.Size(120, 23);
            this.buttonVypis.TabIndex = 6;
            this.buttonVypis.Text = "Vypsat";
            this.buttonVypis.UseVisualStyleBackColor = true;
            this.buttonVypis.Click += new System.EventHandler(this.buttonVypis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 171);
            this.Controls.Add(this.buttonVypis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonUlozit);
            this.Controls.Add(this.textBoxJmeno);
            this.Controls.Add(this.listBoxVypis);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Práce se soubory";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxVypis;
        private System.Windows.Forms.TextBox textBoxJmeno;
        private System.Windows.Forms.Button buttonUlozit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonVypis;
    }
}

