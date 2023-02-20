
namespace kresleni_v_soustave_souradnic
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
            this.panelSoustava = new System.Windows.Forms.Panel();
            this.numericUpDownX = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownY = new System.Windows.Forms.NumericUpDown();
            this.buttonZadat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownPolomer = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPolomer)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSoustava
            // 
            this.panelSoustava.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSoustava.Location = new System.Drawing.Point(16, 145);
            this.panelSoustava.Name = "panelSoustava";
            this.panelSoustava.Size = new System.Drawing.Size(600, 600);
            this.panelSoustava.TabIndex = 0;
            this.panelSoustava.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSoustava_Paint);
            // 
            // numericUpDownX
            // 
            this.numericUpDownX.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownX.Location = new System.Drawing.Point(77, 46);
            this.numericUpDownX.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            this.numericUpDownX.Minimum = new decimal(new int[] { 300, 0, 0, -2147483648 });
            this.numericUpDownX.Name = "numericUpDownX";
            this.numericUpDownX.Size = new System.Drawing.Size(70, 27);
            this.numericUpDownX.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kreslení v soustavě souřadnic";
            // 
            // numericUpDownY
            // 
            this.numericUpDownY.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownY.Location = new System.Drawing.Point(77, 79);
            this.numericUpDownY.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            this.numericUpDownY.Minimum = new decimal(new int[] { 300, 0, 0, -2147483648 });
            this.numericUpDownY.Name = "numericUpDownY";
            this.numericUpDownY.Size = new System.Drawing.Size(70, 27);
            this.numericUpDownY.TabIndex = 2;
            // 
            // buttonZadat
            // 
            this.buttonZadat.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonZadat.Location = new System.Drawing.Point(153, 66);
            this.buttonZadat.Name = "buttonZadat";
            this.buttonZadat.Size = new System.Drawing.Size(107, 52);
            this.buttonZadat.TabIndex = 3;
            this.buttonZadat.Text = "Nakreslit kružnici";
            this.buttonZadat.UseVisualStyleBackColor = true;
            this.buttonZadat.Click += new System.EventHandler(this.buttonZadat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Y";
            // 
            // numericUpDownPolomer
            // 
            this.numericUpDownPolomer.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownPolomer.Location = new System.Drawing.Point(77, 112);
            this.numericUpDownPolomer.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            this.numericUpDownPolomer.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numericUpDownPolomer.Name = "numericUpDownPolomer";
            this.numericUpDownPolomer.Size = new System.Drawing.Size(70, 27);
            this.numericUpDownPolomer.TabIndex = 6;
            this.numericUpDownPolomer.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(12, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Poloměr";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 762);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDownPolomer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonZadat);
            this.Controls.Add(this.numericUpDownY);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownX);
            this.Controls.Add(this.panelSoustava);
            this.Name = "Form1";
            this.Text = "Kreslení";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPolomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panelSoustava;
        private System.Windows.Forms.NumericUpDown numericUpDownX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownY;
        private System.Windows.Forms.Button buttonZadat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownPolomer;
        private System.Windows.Forms.Label label4;
    }
}

