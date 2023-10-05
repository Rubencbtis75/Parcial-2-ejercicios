using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_2_ejercicios.Formas
{
    public partial class FormaEcuacion : Form
    {
        public FormaEcuacion()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         try{ 
            double a, b, c, x1, x2;
            a = Convert.ToDouble(textA.Text);
            b = Convert.ToDouble(textB.Text);
            c = Convert.ToDouble(textC.Text);

            x1 = (-b+(Math.Sqrt((Math.Pow(b,2))-(4*a*c)))) / ( 2 * a);
            x2 = (-b - (Math.Sqrt((Math.Pow(b, 2)) - (4 * a * c)))) / (2 * a);

            texX1.Text=x2.ToString();
            texX2.Text = x1.ToString();
                if (a == 0 || b == 0 || b == 0)
                {
                    MessageBox.Show("Ingresa un numero mayor a 0");

                }

            }
            catch (Exception error)
            {
                MessageBox.Show("Ingresa un numero Entero");
            }

        }
    }
}
