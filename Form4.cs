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
    public partial class Form4 : Form
    {

        public Form4()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            if (txtN.Text == " ")
            {
                MessageBox.Show("Debe ingresar un valor", "Error");
                txtN.Focus();
                return; 
            }
            int n;
            try
            {
                n = Convert.ToInt32(txtN.Text);

            }
            catch (Exception)
            {
                n = 0; 
            }
            if (n < 2)
            {
                MessageBox.Show("Debe ingresar un valor mayor o igual a 2", "Error");
                txtN.Text = " ";
                txtN.Focus();
                return;
            }
            String fibo = Fibonacci(n);
            txtresultado.Text = fibo; 
        }

        private string Fibonacci(int n)
        {
            double a=0, b=1, c, s = 1;
            String fibo = String.Format("{0:N0}\t{1:N0}\t", a, b);
            for(int i=3; i<=n; i++)
            {
                c = a + b;
                fibo += String.Format("{0:N0}\t", c);
                s += c;
                a = b;
                b = c; 
            }

            fibo += String.Format("\t La sumatoria es: {0:N0}", s);
            return fibo; 

        }
    }
}


