using SegundoParcial.UI.Registro;
using SegundoParcial.UI.Consulta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SegundoParcial
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void personaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroPersona registro = new RegistroPersona();
            registro.Show();
        }

        private void personasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaPersona consulta = new ConsultaPersona();
           
            consulta.Show();
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroProducto registro = new RegistroProducto();
          
            registro.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
          ConsutaProducto consulta = new ConsutaProducto();
            
            consulta.Show();
        }

        private void cotizacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroCotizacion registro = new RegistroCotizacion();
            
            registro.Show();
        }
    }
}
