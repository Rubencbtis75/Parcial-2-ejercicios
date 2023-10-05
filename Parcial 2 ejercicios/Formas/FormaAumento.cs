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
    public partial class FormaAumento : Form
    {
        public FormaAumento()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try {   
            int Aumento = int.Parse(texpago.Text);
            double pago = Aumento * 0.25 + Aumento;
            textaumento.Text = pago.ToString();

                if (Aumento <= 0 )
                {
                    MessageBox.Show("Ingresa un numero positivo");

                }

            }
            catch (Exception error)
            {
                MessageBox.Show("Ingresa un numero Entero");
            }
        }
    }
}
