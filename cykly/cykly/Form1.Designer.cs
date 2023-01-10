
namespace cykly
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
            this.labelSuda = new System.Windows.Forms.Label();
            this.buttonSuda = new System.Windows.Forms.Button();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cykly";
            // 
            // labelSuda
            // 
            this.labelSuda.AutoSize = true;
            this.labelSuda.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSuda.Location = new System.Drawing.Point(13, 77);
            this.labelSuda.Name = "labelSuda";
            this.labelSuda.Size = new System.Drawing.Size(33, 16);
            this.labelSuda.TabIndex = 1;
            this.labelSuda.Text = "Sudá";
            // 
            // buttonSuda
            // 
            this.buttonSuda.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSuda.Location = new System.Drawing.Point(122, 44);
            this.buttonSuda.Name = "buttonSuda";
            this.buttonSuda.Size = new System.Drawing.Size(75, 23);
            this.buttonSuda.TabIndex = 2;
            this.buttonSuda.Text = "Aktivace";
            this.buttonSuda.UseVisualStyleBackColor = true;
            this.buttonSuda.Click += new System.EventHandler(this.buttonSuda_Click);
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(16, 45);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(100, 20);
            this.textBoxA.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.buttonSuda);
            this.Controls.Add(this.labelSuda);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSuda;
        private System.Windows.Forms.Button buttonSuda;
        private System.Windows.Forms.TextBox textBoxA;
    }
}

