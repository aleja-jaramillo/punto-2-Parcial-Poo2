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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnlistar_Click(object sender, EventArgs e)
        {
            int desde = Convert.ToInt32(txtdesde.Value);
            int hasta = Convert.ToInt32(txthasta.Value);
            int multiplo = Convert.ToInt32(txtmultiplo.Text);

            for (int i = desde; i<= hasta; i++)
            {
                if (i % multiplo == 0)
                {
                    lista.Items.Add(i);
                }
            }
        }
    }
}
