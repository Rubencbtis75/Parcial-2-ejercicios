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
    public partial class FormaTriangulo : Form
    {
        public FormaTriangulo()
        {
            InitializeComponent();
        }

        private void CalcularArea_Click(object sender, EventArgs e)
        {
            try {
                int baseT = int.Parse(textBox1.Text);
                int AlturaT = int.Parse(textBox2.Text);
                int resultado = (baseT * AlturaT / 2);
                textBox3.Text = resultado.ToString();
           
             if (baseT <= 0 || AlturaT <= 0 )
            {
                MessageBox.Show("Ingresa un numero positivo");
                
            }
             
            }
            catch (Exception error)
            {
                MessageBox.Show("Ingresa un numero Entero");
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
