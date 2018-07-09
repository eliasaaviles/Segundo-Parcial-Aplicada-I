using SegundoParcial1.UI;
using SegundoParcial1.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace SegundoParcial1
{
       public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistroVehiculos registro = new RegistroVehiculos();
          
            registro.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegistroTalleres registro = new RegistroTalleres();

            registro.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RegistroArticulos registro = new RegistroArticulos();

            registro.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RegistroEntradaArticulos registro = new RegistroEntradaArticulos();
            registro.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Buscar Articulo ID = 1 


            Articulo articulo = BLL.ArticuloBLL.Buscar(1);



            // igualar el inventario a 6

            articulo.Inventario += 1;

            // copiar codigo guardar para guardar instancia 

            BLL.ArticuloBLL.Modificar(articulo);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            RegistroMantenimiento mantenimiento = new RegistroMantenimiento();
            mantenimiento.Show();
        }
    }
}
