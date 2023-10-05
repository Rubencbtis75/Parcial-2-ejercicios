using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parcial_2_ejercicios.Formas;

namespace Parcial_2_ejercicios
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void ejerciciosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void calculadora_Click(object sender, EventArgs e)
        {
            Forma_Calculadora calculadora = new Forma_Calculadora();
            calculadora.Show();
        }

        private void ejerciciosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void gradosFahrenheitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaGrados grados = new FormaGrados();
            grados.Show();

        }

        private void areaDeUnTrianguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaTriangulo triangulo = new FormaTriangulo();
            triangulo.Show();
        }

        private void viajeroMexicanoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaMexicano mexicano = new FormaMexicano();
            mexicano.Show();
        }

        private void latidosPorMinutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaCorazon corazon = new FormaCorazon();
            corazon.Show();
        }

        private void aumentoAunTrabajadorAl25ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaAumento aumento = new FormaAumento();
            aumento.Show();
        }

        private void ecuacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaEcuacion ecuacion = new FormaEcuacion();
            ecuacion.Show();
        }

        private void MenuSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
