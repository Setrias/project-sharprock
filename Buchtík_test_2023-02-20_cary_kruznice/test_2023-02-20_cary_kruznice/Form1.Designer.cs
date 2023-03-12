
namespace test_2023_02_20_cary_kruznice
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
            this.panelTest = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelTest
            // 
            this.panelTest.Location = new System.Drawing.Point(12, 12);
            this.panelTest.Name = "panelTest";
            this.panelTest.Size = new System.Drawing.Size(300, 200);
            this.panelTest.TabIndex = 0;
            this.panelTest.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTest_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 219);
            this.Controls.Add(this.panelTest);
            this.Name = "Form1";
            this.Text = "Test";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTest;
    }
}

