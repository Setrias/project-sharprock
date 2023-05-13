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
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.AlwaysOnTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miniToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // miniToolStrip
            // 
            this.miniToolStrip.AutoSize = false;
            this.miniToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.toolStripMenuTyp, this.toolStripMenuItem1 });
            this.miniToolStrip.Location = new System.Drawing.Point(0, 0);
            this.miniToolStrip.Name = "miniToolStrip";
            this.miniToolStrip.Size = new System.Drawing.Size(244, 24);
            this.miniToolStrip.TabIndex = 0;
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
            this.klasickáToolStripMenuItem.Checked = true;
            this.klasickáToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
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
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.AlwaysOnTopToolStripMenuItem });
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(63, 20);
            this.toolStripMenuItem1.Text = "Chování";
            // 
            // AlwaysOnTopToolStripMenuItem
            // 
            this.AlwaysOnTopToolStripMenuItem.Name = "AlwaysOnTopToolStripMenuItem";
            this.AlwaysOnTopToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.AlwaysOnTopToolStripMenuItem.Text = "Vždy nahoře";
            this.AlwaysOnTopToolStripMenuItem.Click += new System.EventHandler(this.AlwaysOnTopToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(244, 361);
            this.Controls.Add(this.miniToolStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(15, 15);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Kalkulačka";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.miniToolStrip.ResumeLayout(false);
            this.miniToolStrip.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem AlwaysOnTopToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem toolStripMenuTyp;

        private System.Windows.Forms.ToolStripMenuItem klasickáToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem převodToolStripMenuItem;

        private System.Windows.Forms.MenuStrip miniToolStrip;

        #endregion
    }
}