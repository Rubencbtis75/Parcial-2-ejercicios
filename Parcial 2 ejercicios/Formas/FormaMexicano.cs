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
    public partial class FormaMexicano : Form
    {
        public FormaMexicano()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {  
                int dolares = int.Parse(textpesos.Text);
                double cambio1 = dolares / 18.4 / 2;
                texdolares.Text = cambio1.ToString();

                int euros = int.Parse(textpesos.Text);
                double cambio2 = euros / 18.9 / 2;
                texteuros.Text = cambio2.ToString();
            if (dolares <= 0 || euros <= 0)
            {
                MessageBox.Show("Ingresa un numero Positivo");

            }

        }
            catch (Exception error)
            {
                MessageBox.Show("Ingresa un numero Entero");
            }
}
            
        }
    }

