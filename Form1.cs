using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mULTIPLOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 Nuevo = new Form2();
            Nuevo.MdiParent = this;
            Nuevo.Show();
        }

        private void fACTORIALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 Nuevo = new Form3();
            Nuevo.MdiParent = this;
            Nuevo.Show();
        }

        private void fIBONACCIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 Nuevo = new Form4();
            Nuevo.MdiParent = this;
            Nuevo.Show();
        }
    }
}
