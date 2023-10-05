
namespace Parcial_2_ejercicios
{
    partial class Menu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.ejerciciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menucalculadora = new System.Windows.Forms.ToolStripMenuItem();
            this.gradosFahrenheitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.areaDeUnTrianguloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viajeroMexicanoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.latidosPorMinutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aumentoAunTrabajadorAl25ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ecuacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuSalir,
            this.ejerciciosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuSalir
            // 
            this.MenuSalir.Name = "MenuSalir";
            this.MenuSalir.Size = new System.Drawing.Size(56, 24);
            this.MenuSalir.Text = "Salir ";
            this.MenuSalir.Click += new System.EventHandler(this.MenuSalir_Click);
            // 
            // ejerciciosToolStripMenuItem
            // 
            this.ejerciciosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menucalculadora,
            this.gradosFahrenheitToolStripMenuItem,
            this.areaDeUnTrianguloToolStripMenuItem,
            this.viajeroMexicanoToolStripMenuItem,
            this.latidosPorMinutosToolStripMenuItem,
            this.aumentoAunTrabajadorAl25ToolStripMenuItem,
            this.ecuacionToolStripMenuItem});
            this.ejerciciosToolStripMenuItem.Name = "ejerciciosToolStripMenuItem";
            this.ejerciciosToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.ejerciciosToolStripMenuItem.Text = "Ejercicios";
            this.ejerciciosToolStripMenuItem.Click += new System.EventHandler(this.ejerciciosToolStripMenuItem_Click_1);
            // 
            // Menucalculadora
            // 
            this.Menucalculadora.Name = "Menucalculadora";
            this.Menucalculadora.Size = new System.Drawing.Size(303, 26);
            this.Menucalculadora.Text = "Calculadora";
            this.Menucalculadora.Click += new System.EventHandler(this.calculadora_Click);
            // 
            // gradosFahrenheitToolStripMenuItem
            // 
            this.gradosFahrenheitToolStripMenuItem.Name = "gradosFahrenheitToolStripMenuItem";
            this.gradosFahrenheitToolStripMenuItem.Size = new System.Drawing.Size(303, 26);
            this.gradosFahrenheitToolStripMenuItem.Text = "grados fahrenheit";
            this.gradosFahrenheitToolStripMenuItem.Click += new System.EventHandler(this.gradosFahrenheitToolStripMenuItem_Click);
            // 
            // areaDeUnTrianguloToolStripMenuItem
            // 
            this.areaDeUnTrianguloToolStripMenuItem.Name = "areaDeUnTrianguloToolStripMenuItem";
            this.areaDeUnTrianguloToolStripMenuItem.Size = new System.Drawing.Size(303, 26);
            this.areaDeUnTrianguloToolStripMenuItem.Text = "Area de un triangulo";
            this.areaDeUnTrianguloToolStripMenuItem.Click += new System.EventHandler(this.areaDeUnTrianguloToolStripMenuItem_Click);
            // 
            // viajeroMexicanoToolStripMenuItem
            // 
            this.viajeroMexicanoToolStripMenuItem.Name = "viajeroMexicanoToolStripMenuItem";
            this.viajeroMexicanoToolStripMenuItem.Size = new System.Drawing.Size(303, 26);
            this.viajeroMexicanoToolStripMenuItem.Text = "Viajero Mexicano";
            this.viajeroMexicanoToolStripMenuItem.Click += new System.EventHandler(this.viajeroMexicanoToolStripMenuItem_Click);
            // 
            // latidosPorMinutosToolStripMenuItem
            // 
            this.latidosPorMinutosToolStripMenuItem.Name = "latidosPorMinutosToolStripMenuItem";
            this.latidosPorMinutosToolStripMenuItem.Size = new System.Drawing.Size(303, 26);
            this.latidosPorMinutosToolStripMenuItem.Text = "Latidos por Minutos";
            this.latidosPorMinutosToolStripMenuItem.Click += new System.EventHandler(this.latidosPorMinutosToolStripMenuItem_Click);
            // 
            // aumentoAunTrabajadorAl25ToolStripMenuItem
            // 
            this.aumentoAunTrabajadorAl25ToolStripMenuItem.Name = "aumentoAunTrabajadorAl25ToolStripMenuItem";
            this.aumentoAunTrabajadorAl25ToolStripMenuItem.Size = new System.Drawing.Size(303, 26);
            this.aumentoAunTrabajadorAl25ToolStripMenuItem.Text = "Aumento aun trabajador al 25%";
            this.aumentoAunTrabajadorAl25ToolStripMenuItem.Click += new System.EventHandler(this.aumentoAunTrabajadorAl25ToolStripMenuItem_Click);
            // 
            // ecuacionToolStripMenuItem
            // 
            this.ecuacionToolStripMenuItem.Name = "ecuacionToolStripMenuItem";
            this.ecuacionToolStripMenuItem.Size = new System.Drawing.Size(303, 26);
            this.ecuacionToolStripMenuItem.Text = "Ecuacion";
            this.ecuacionToolStripMenuItem.Click += new System.EventHandler(this.ecuacionToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Parcial_2_ejercicios.Properties.Resources.descarga__13_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuSalir;
        private System.Windows.Forms.ToolStripMenuItem ejerciciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Menucalculadora;
        private System.Windows.Forms.ToolStripMenuItem gradosFahrenheitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem areaDeUnTrianguloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viajeroMexicanoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem latidosPorMinutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aumentoAunTrabajadorAl25ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ecuacionToolStripMenuItem;
    }
}

