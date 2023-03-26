namespace hraci_pole
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
            this.listBoxZetony = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownSourX = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSourY = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.panelHraciPole = new System.Windows.Forms.Panel();
            this.buttonZadat = new System.Windows.Forms.Button();
            this.buttonPozice = new System.Windows.Forms.Button();
            this.comboBoxBarva = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSourX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSourY)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxZetony
            // 
            this.listBoxZetony.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBoxZetony.FormattingEnabled = true;
            this.listBoxZetony.ItemHeight = 16;
            this.listBoxZetony.Location = new System.Drawing.Point(12, 302);
            this.listBoxZetony.Name = "listBoxZetony";
            this.listBoxZetony.Size = new System.Drawing.Size(229, 100);
            this.listBoxZetony.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hrací pole";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Souřadnice X:";
            // 
            // numericUpDownSourX
            // 
            this.numericUpDownSourX.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDownSourX.Location = new System.Drawing.Point(118, 49);
            this.numericUpDownSourX.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            this.numericUpDownSourX.Name = "numericUpDownSourX";
            this.numericUpDownSourX.Size = new System.Drawing.Size(123, 30);
            this.numericUpDownSourX.TabIndex = 3;
            // 
            // numericUpDownSourY
            // 
            this.numericUpDownSourY.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDownSourY.Location = new System.Drawing.Point(118, 85);
            this.numericUpDownSourY.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            this.numericUpDownSourY.Name = "numericUpDownSourY";
            this.numericUpDownSourY.Size = new System.Drawing.Size(123, 30);
            this.numericUpDownSourY.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Souřadnice Y:";
            // 
            // panelHraciPole
            // 
            this.panelHraciPole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHraciPole.Location = new System.Drawing.Point(247, 52);
            this.panelHraciPole.Name = "panelHraciPole";
            this.panelHraciPole.Size = new System.Drawing.Size(501, 501);
            this.panelHraciPole.TabIndex = 6;
            this.panelHraciPole.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHraciPole_Paint);
            // 
            // buttonZadat
            // 
            this.buttonZadat.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonZadat.Location = new System.Drawing.Point(12, 148);
            this.buttonZadat.Name = "buttonZadat";
            this.buttonZadat.Size = new System.Drawing.Size(229, 39);
            this.buttonZadat.TabIndex = 7;
            this.buttonZadat.Text = "Zadat žetony:";
            this.buttonZadat.UseVisualStyleBackColor = true;
            this.buttonZadat.Click += new System.EventHandler(this.buttonZadat_Click);
            // 
            // buttonPozice
            // 
            this.buttonPozice.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPozice.Location = new System.Drawing.Point(12, 257);
            this.buttonPozice.Name = "buttonPozice";
            this.buttonPozice.Size = new System.Drawing.Size(229, 39);
            this.buttonPozice.TabIndex = 8;
            this.buttonPozice.Text = "Pozice černých";
            this.buttonPozice.UseVisualStyleBackColor = true;
            this.buttonPozice.Click += new System.EventHandler(this.buttonPozice_Click);
            // 
            // comboBoxBarva
            // 
            this.comboBoxBarva.FormattingEnabled = true;
            this.comboBoxBarva.Items.AddRange(new object[] { "Černá", "Modrá", "Červená", "Zelená" });
            this.comboBoxBarva.Location = new System.Drawing.Point(118, 121);
            this.comboBoxBarva.Name = "comboBoxBarva";
            this.comboBoxBarva.Size = new System.Drawing.Size(123, 21);
            this.comboBoxBarva.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(12, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Barva:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 565);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxBarva);
            this.Controls.Add(this.buttonPozice);
            this.Controls.Add(this.buttonZadat);
            this.Controls.Add(this.panelHraciPole);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownSourY);
            this.Controls.Add(this.numericUpDownSourX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxZetony);
            this.Name = "Form1";
            this.Text = "Hrací pole";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSourX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSourY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ComboBox comboBoxBarva;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Button buttonZadat;

        private System.Windows.Forms.Button buttonPozice;

        private System.Windows.Forms.Panel panelHraciPole;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.NumericUpDown numericUpDownSourY;

        private System.Windows.Forms.NumericUpDown numericUpDownSourX;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.ListBox listBoxZetony;

        #endregion
    }
}