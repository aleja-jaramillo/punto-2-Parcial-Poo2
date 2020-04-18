namespace Punto_10
{
    partial class Form2
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
            this.txtmultiplo = new System.Windows.Forms.TextBox();
            this.txtdesde = new System.Windows.Forms.NumericUpDown();
            this.txthasta = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnlistar = new System.Windows.Forms.Button();
            this.lista = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtdesde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txthasta)).BeginInit();
            this.SuspendLayout();
            // 
            // txtmultiplo
            // 
            this.txtmultiplo.Location = new System.Drawing.Point(13, 13);
            this.txtmultiplo.Name = "txtmultiplo";
            this.txtmultiplo.Size = new System.Drawing.Size(352, 22);
            this.txtmultiplo.TabIndex = 0;
            // 
            // txtdesde
            // 
            this.txtdesde.Location = new System.Drawing.Point(13, 50);
            this.txtdesde.Name = "txtdesde";
            this.txtdesde.Size = new System.Drawing.Size(120, 22);
            this.txtdesde.TabIndex = 1;
            // 
            // txthasta
            // 
            this.txthasta.Location = new System.Drawing.Point(245, 50);
            this.txthasta.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txthasta.Name = "txthasta";
            this.txthasta.Size = new System.Drawing.Size(120, 22);
            this.txthasta.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "HASTA";
            // 
            // btnlistar
            // 
            this.btnlistar.Location = new System.Drawing.Point(13, 78);
            this.btnlistar.Name = "btnlistar";
            this.btnlistar.Size = new System.Drawing.Size(352, 51);
            this.btnlistar.TabIndex = 4;
            this.btnlistar.Text = "LISTAR";
            this.btnlistar.UseVisualStyleBackColor = true;
            this.btnlistar.Click += new System.EventHandler(this.btnlistar_Click);
            // 
            // lista
            // 
            this.lista.FormattingEnabled = true;
            this.lista.ItemHeight = 16;
            this.lista.Location = new System.Drawing.Point(13, 136);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(352, 308);
            this.lista.TabIndex = 5;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 450);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.btnlistar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txthasta);
            this.Controls.Add(this.txtdesde);
            this.Controls.Add(this.txtmultiplo);
            this.Name = "Form2";
            this.Text = "MULTIPLO";
            ((System.ComponentModel.ISupportInitialize)(this.txtdesde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txthasta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtmultiplo;
        private System.Windows.Forms.NumericUpDown txtdesde;
        private System.Windows.Forms.NumericUpDown txthasta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnlistar;
        private System.Windows.Forms.ListBox lista;
    }
}