namespace Punto_10
{
    partial class Form3
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
            this.txtnumfact = new System.Windows.Forms.TextBox();
            this.txtfactorial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtnumfact
            // 
            this.txtnumfact.Location = new System.Drawing.Point(13, 13);
            this.txtnumfact.Name = "txtnumfact";
            this.txtnumfact.Size = new System.Drawing.Size(267, 22);
            this.txtnumfact.TabIndex = 0;
            // 
            // txtfactorial
            // 
            this.txtfactorial.Location = new System.Drawing.Point(13, 53);
            this.txtfactorial.Name = "txtfactorial";
            this.txtfactorial.Size = new System.Drawing.Size(267, 60);
            this.txtfactorial.TabIndex = 2;
            this.txtfactorial.Text = "FACTORIAL";
            this.txtfactorial.UseVisualStyleBackColor = true;
            this.txtfactorial.Click += new System.EventHandler(this.txtfactorial_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 158);
            this.Controls.Add(this.txtfactorial);
            this.Controls.Add(this.txtnumfact);
            this.Name = "Form3";
            this.Text = "FACTORIAL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnumfact;
        private System.Windows.Forms.Button txtfactorial;
    }
}