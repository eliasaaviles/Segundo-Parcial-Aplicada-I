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
    public partial class RegistroVehiculos : Form
    {
        public RegistroVehiculos()
        {
            InitializeComponent();
        }
        private Vehiculo Vaciar()
        {
            Vehiculo vehiculo = new Vehiculo();
            VehiculoIDNum.Value = 0;
            DescripcionBox.Clear();
            MantenimientoBox.Clear();

            return vehiculo;
           
          
        }
        private Vehiculo LlenarClase()
        {

            Vehiculo vehiculo = new Vehiculo();

            vehiculo.VehiculoID = Convert.ToInt32(VehiculoIDNum.Value);
            vehiculo.Descripcion = DescripcionBox.Text;
            vehiculo.MantenimientoTotal = Convert.ToInt32(VehiculoIDNum.Value);
            return vehiculo;
        }
        private bool Validar(int validar)
        {

            bool paso = false;

            if (validar == 0 && VehiculoIDNum.Value == 0)
            {
                errorProvider1.SetError(DescripcionBox, "Ingrese un ID");
                paso = true;

            }
            return paso;
        }
            private void RegistroVehiculos_Load(object sender, EventArgs e)
        {

        }

        private void NuevoBoton_Click(object sender, EventArgs e)
        {
            Vaciar();
        }

        private void GuardarBoton_Click(object sender, EventArgs e)
        {
            bool paso = false;
            if (Validar(1))
            {

                MessageBox.Show("Llenar todos los campos marcados");
                return;
            }

            errorProvider1.Clear();

            
            if (VehiculoIDNum.Value == 0)
                paso = BLL.VehiculoBLL.Guardar(LlenarClase());
            else
                paso = BLL.VehiculoBLL.Modificar(LlenarClase());

           
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

            int id = Convert.ToInt32(VehiculoIDNum.Value);

            if (BLL.VehiculoBLL.Eliminar(id))
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo eliminar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BuscarBoton_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (Validar(1))
            {
                MessageBox.Show("Ingrese un ID");
                return;
            }

            int id = Convert.ToInt32(VehiculoIDNum.Value);
            Vehiculo vehiculo = BLL.VehiculoBLL.Buscar(id);

            if (vehiculo != null)
            {

                DescripcionBox.Text = vehiculo.Descripcion;
                MantenimientoBox.Text = vehiculo.MantenimientoTotal.ToString();
               

            }
            else
                MessageBox.Show("No se encontro", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MantenimientoBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
