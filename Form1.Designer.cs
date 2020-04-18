namespace Punto_10
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cALCULARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mULTIPLOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fACTORIALToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fIBONACCIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cALCULARToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(430, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cALCULARToolStripMenuItem
            // 
            this.cALCULARToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mULTIPLOToolStripMenuItem,
            this.fACTORIALToolStripMenuItem,
            this.fIBONACCIToolStripMenuItem});
            this.cALCULARToolStripMenuItem.Name = "cALCULARToolStripMenuItem";
            this.cALCULARToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.cALCULARToolStripMenuItem.Text = "CALCULAR";
            // 
            // mULTIPLOToolStripMenuItem
            // 
            this.mULTIPLOToolStripMenuItem.Name = "mULTIPLOToolStripMenuItem";
            this.mULTIPLOToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.mULTIPLOToolStripMenuItem.Text = "MULTIPLO";
            this.mULTIPLOToolStripMenuItem.Click += new System.EventHandler(this.mULTIPLOToolStripMenuItem_Click);
            // 
            // fACTORIALToolStripMenuItem
            // 
            this.fACTORIALToolStripMenuItem.Name = "fACTORIALToolStripMenuItem";
            this.fACTORIALToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.fACTORIALToolStripMenuItem.Text = "FACTORIAL";
            this.fACTORIALToolStripMenuItem.Click += new System.EventHandler(this.fACTORIALToolStripMenuItem_Click);
            // 
            // fIBONACCIToolStripMenuItem
            // 
            this.fIBONACCIToolStripMenuItem.Name = "fIBONACCIToolStripMenuItem";
            this.fIBONACCIToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.fIBONACCIToolStripMenuItem.Text = "FIBONACCI";
            this.fIBONACCIToolStripMenuItem.Click += new System.EventHandler(this.fIBONACCIToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 369);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "CALCULAR";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cALCULARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mULTIPLOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fACTORIALToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fIBONACCIToolStripMenuItem;
    }
}

