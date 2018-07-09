using SegundoParcial1.DAL;
using SegundoParcial1.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SegundoParcial1.UI
{
    public partial class RegistroArticulos : Form
    {
        public RegistroArticulos()
        {
            InitializeComponent();
        }
        private Articulo Vaciar()
        {
            Articulo vehiculo = new Articulo();
           ArticuloIDNum.Value = 0;
            DescripcionBox.Clear();
            CostoBox.Clear();
            PrecioBox.Clear();
            GananciaBox.Clear();
            InventarioBox.Clear();


            return vehiculo;


        }
        private Articulo LlenarClase()
        {

            Articulo articulo = new Articulo();

            articulo.ArticuloID = Convert.ToInt32(ArticuloIDNum.Value);
            articulo.Descripcion = DescripcionBox.Text;
            articulo.Costo = Convert.ToInt32(CostoBox.Text);
            articulo.Ganancia = Convert.ToInt32(GananciaBox.Text);
            articulo.Precip = Convert.ToInt32(PrecioBox.Text);
            articulo.Inventario = 0;
            return articulo;
        }
        private bool Validar(int validar)
        {

            bool paso = false;

            if (validar == 1 && ArticuloIDNum.Value == 0)
            {
                errorProvider1.SetError(ArticuloIDNum, "Ingrese un ID");
                paso = true;

            }
            return paso;
        }
      
        private void RegistroArticulos_Load(object sender, EventArgs e)
            {

            }

            private void textBox1_TextChanged(object sender, EventArgs e)
            {

            }

            private void label3_Click(object sender, EventArgs e)
            {

            }

            private void BuscarBoton_Click(object sender, EventArgs e)
            {
            errorProvider1.Clear();

            if (Validar(1))
            {
                MessageBox.Show("Ingrese un ID");
                return;
            }

            int id = Convert.ToInt32(ArticuloIDNum.Value);
            Articulo articulo = BLL.ArticuloBLL.Buscar(id);

            if (articulo != null)
            {

                DescripcionBox.Text = articulo.Descripcion;
                CostoBox.Text = articulo.Costo.ToString();
                GananciaBox.Text = articulo.Ganancia.ToString();
                PrecioBox.Text = articulo.Precip.ToString();
                InventarioBox.Text = articulo.Inventario.ToString();


            }
            else
                MessageBox.Show("No se encontro", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void NuevoBoton_Click(object sender, EventArgs e)
        {
            Vaciar();
        }

        private void GuardarBoton_Click(object sender, EventArgs e)
        {
            bool paso = false;
            if (Validar(2))
            {

                MessageBox.Show("Llenar todos los campos marcados");
                return;
            }

            errorProvider1.Clear();


            if (ArticuloIDNum.Value == 0)
                paso = BLL.ArticuloBLL.Guardar(LlenarClase());
            else
                paso = BLL.ArticuloBLL.Modificar(LlenarClase());


            if (paso)

                MessageBox.Show("Guardado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo guardar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Vaciar();
        }

        private void EliminarBoton_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (Validar(1))
            {
                MessageBox.Show("Ingrese un ID");
                return;
            }

            int id = Convert.ToInt32(ArticuloIDNum.Value);

            if (BLL.ArticuloBLL.Eliminar(id))
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo eliminar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    }


