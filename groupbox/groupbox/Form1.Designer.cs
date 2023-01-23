
namespace groupbox
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
            this.groupBoxTest = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonSkrytOdkryt = new System.Windows.Forms.Button();
            this.groupBoxTest.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTest
            // 
            this.groupBoxTest.Controls.Add(this.button2);
            this.groupBoxTest.Controls.Add(this.textBox1);
            this.groupBoxTest.Location = new System.Drawing.Point(12, 51);
            this.groupBoxTest.Name = "groupBoxTest";
            this.groupBoxTest.Size = new System.Drawing.Size(166, 103);
            this.groupBoxTest.TabIndex = 0;
            this.groupBoxTest.TabStop = false;
            this.groupBoxTest.Text = "groupBox1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(48, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(35, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // buttonSkrytOdkryt
            // 
            this.buttonSkrytOdkryt.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSkrytOdkryt.Location = new System.Drawing.Point(12, 12);
            this.buttonSkrytOdkryt.Name = "buttonSkrytOdkryt";
            this.buttonSkrytOdkryt.Size = new System.Drawing.Size(166, 33);
            this.buttonSkrytOdkryt.TabIndex = 1;
            this.buttonSkrytOdkryt.Text = "Skrýt / odkrýt";
            this.buttonSkrytOdkryt.UseVisualStyleBackColor = true;
            this.buttonSkrytOdkryt.Click += new System.EventHandler(this.buttonSkrytOdkryt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(190, 164);
            this.Controls.Add(this.buttonSkrytOdkryt);
            this.Controls.Add(this.groupBoxTest);
            this.Name = "Form1";
            this.Text = "Groupbox";
            this.groupBoxTest.ResumeLayout(false);
            this.groupBoxTest.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTest;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonSkrytOdkryt;
    }
}

