namespace kresleni_tvaru
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
            this.panelTvary = new System.Windows.Forms.Panel();
            this.buttonVykreslit = new System.Windows.Forms.Button();
            this.radioButtonKrizekX = new System.Windows.Forms.RadioButton();
            this.radioButtonTrojuhelnik = new System.Windows.Forms.RadioButton();
            this.radioButtonKrizekPlus = new System.Windows.Forms.RadioButton();
            this.textBoxStrana = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panelTvary
            // 
            this.panelTvary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTvary.Location = new System.Drawing.Point(132, 12);
            this.panelTvary.Name = "panelTvary";
            this.panelTvary.Size = new System.Drawing.Size(200, 200);
            this.panelTvary.TabIndex = 0;
            this.panelTvary.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTvary_Paint);
            // 
            // buttonVykreslit
            // 
            this.buttonVykreslit.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVykreslit.Location = new System.Drawing.Point(12, 175);
            this.buttonVykreslit.Name = "buttonVykreslit";
            this.buttonVykreslit.Size = new System.Drawing.Size(104, 37);
            this.buttonVykreslit.TabIndex = 1;
            this.buttonVykreslit.Text = "Vykreslit";
            this.buttonVykreslit.UseVisualStyleBackColor = true;
            this.buttonVykreslit.Click += new System.EventHandler(this.buttonVykreslit_Click);
            // 
            // radioButtonKrizekX
            // 
            this.radioButtonKrizekX.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonKrizekX.Location = new System.Drawing.Point(12, 85);
            this.radioButtonKrizekX.Name = "radioButtonKrizekX";
            this.radioButtonKrizekX.Size = new System.Drawing.Size(104, 24);
            this.radioButtonKrizekX.TabIndex = 2;
            this.radioButtonKrizekX.TabStop = true;
            this.radioButtonKrizekX.Text = "Křížek > X";
            this.radioButtonKrizekX.UseVisualStyleBackColor = true;
            // 
            // radioButtonTrojuhelnik
            // 
            this.radioButtonTrojuhelnik.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonTrojuhelnik.Location = new System.Drawing.Point(12, 115);
            this.radioButtonTrojuhelnik.Name = "radioButtonTrojuhelnik";
            this.radioButtonTrojuhelnik.Size = new System.Drawing.Size(104, 24);
            this.radioButtonTrojuhelnik.TabIndex = 3;
            this.radioButtonTrojuhelnik.TabStop = true;
            this.radioButtonTrojuhelnik.Text = "Trojúhelník";
            this.radioButtonTrojuhelnik.UseVisualStyleBackColor = true;
            // 
            // radioButtonKrizekPlus
            // 
            this.radioButtonKrizekPlus.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonKrizekPlus.Location = new System.Drawing.Point(12, 145);
            this.radioButtonKrizekPlus.Name = "radioButtonKrizekPlus";
            this.radioButtonKrizekPlus.Size = new System.Drawing.Size(104, 24);
            this.radioButtonKrizekPlus.TabIndex = 4;
            this.radioButtonKrizekPlus.TabStop = true;
            this.radioButtonKrizekPlus.Text = "Křížek > +";
            this.radioButtonKrizekPlus.UseVisualStyleBackColor = true;
            // 
            // textBoxStrana
            // 
            this.textBoxStrana.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxStrana.Location = new System.Drawing.Point(63, 56);
            this.textBoxStrana.Name = "textBoxStrana";
            this.textBoxStrana.Size = new System.Drawing.Size(53, 23);
            this.textBoxStrana.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Strana:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Kreslení tvarů";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 224);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxStrana);
            this.Controls.Add(this.radioButtonKrizekPlus);
            this.Controls.Add(this.radioButtonTrojuhelnik);
            this.Controls.Add(this.radioButtonKrizekX);
            this.Controls.Add(this.buttonVykreslit);
            this.Controls.Add(this.panelTvary);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.RadioButton radioButtonTrojuhelnik;
        private System.Windows.Forms.RadioButton radioButtonKrizekPlus;
        private System.Windows.Forms.TextBox textBoxStrana;

        private System.Windows.Forms.RadioButton radioButtonKrizekX;

        private System.Windows.Forms.Button buttonVykreslit;

        private System.Windows.Forms.Panel panelTvary;

        #endregion
    }
}