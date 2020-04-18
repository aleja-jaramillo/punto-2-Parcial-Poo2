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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void txtfactorial_Click(object sender, EventArgs e)
        {
            float cantidad, resultado = 1, i;
            cantidad = float.Parse(txtnumfact.Text);

            for (i = 1; i <= cantidad; i++)
            {
                resultado = i * resultado;
            }
            txtnumfact.Text = resultado.ToString();
        }
    }
}
