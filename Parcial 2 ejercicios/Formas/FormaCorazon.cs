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
    public partial class FormaCorazon : Form
    {
        public FormaCorazon()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            int edad = int.Parse(textedad.Text);
            int resultado = (220-edad);
            textminuto.Text = resultado.ToString();
                if (edad >=81 )
                {
                    MessageBox.Show("En mexico la esperanza de vida es hasta los 80");

                }

            }
            catch (Exception error)
            {
                MessageBox.Show("Ingresa un numero Entero");
            }

        }
    }
}
