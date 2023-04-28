namespace kalkulacka_v4_graficka
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.miniToolStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuTyp = new System.Windows.Forms.ToolStripMenuItem();
            this.klasickáToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.převodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uiClassic = new System.Windows.Forms.Panel();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.miniToolStrip.SuspendLayout();
            this.uiClassic.SuspendLayout();
            this.SuspendLayout();
            // 
            // miniToolStrip
            // 
            this.miniToolStrip.AutoSize = false;
            this.miniToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.toolStripMenuTyp });
            this.miniToolStrip.Location = new System.Drawing.Point(0, 0);
            this.miniToolStrip.Name = "miniToolStrip";
            this.miniToolStrip.Size = new System.Drawing.Size(222, 24);
            this.miniToolStrip.TabIndex = 0;
            this.miniToolStrip.Visible = false;
            // 
            // toolStripMenuTyp
            // 
            this.toolStripMenuTyp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.klasickáToolStripMenuItem, this.převodToolStripMenuItem });
            this.toolStripMenuTyp.Name = "toolStripMenuTyp";
            this.toolStripMenuTyp.Size = new System.Drawing.Size(95, 20);
            this.toolStripMenuTyp.Text = "Typ kalkulačky";
            // 
            // klasickáToolStripMenuItem
            // 
            this.klasickáToolStripMenuItem.Name = "klasickáToolStripMenuItem";
            this.klasickáToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.klasickáToolStripMenuItem.Text = "Klasická";
            this.klasickáToolStripMenuItem.Click += new System.EventHandler(this.klasickáToolStripMenuItem_Click);
            // 
            // převodToolStripMenuItem
            // 
            this.převodToolStripMenuItem.Name = "převodToolStripMenuItem";
            this.převodToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.převodToolStripMenuItem.Text = "Převod";
            this.převodToolStripMenuItem.Click += new System.EventHandler(this.převodToolStripMenuItem_Click);
            // 
            // uiClassic
            // 
            this.uiClassic.Controls.Add(this.textBoxResult);
            this.uiClassic.Location = new System.Drawing.Point(12, 27);
            this.uiClassic.Name = "uiClassic";
            this.uiClassic.Size = new System.Drawing.Size(200, 300);
            this.uiClassic.TabIndex = 1;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxResult.Location = new System.Drawing.Point(3, 3);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(194, 52);
            this.textBoxResult.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(222, 336);
            this.Controls.Add(this.uiClassic);
            this.Controls.Add(this.miniToolStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Form1";
            this.miniToolStrip.ResumeLayout(false);
            this.miniToolStrip.PerformLayout();
            this.uiClassic.ResumeLayout(false);
            this.uiClassic.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.TextBox textBoxResult;

        private System.Windows.Forms.Panel uiClassic;

        private System.Windows.Forms.ToolStripMenuItem toolStripMenuTyp;

        private System.Windows.Forms.ToolStripMenuItem klasickáToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem převodToolStripMenuItem;

        private System.Windows.Forms.MenuStrip miniToolStrip;

        #endregion
    }
}