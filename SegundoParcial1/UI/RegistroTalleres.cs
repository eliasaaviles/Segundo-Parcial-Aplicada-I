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
    public partial class RegistroTalleres : Form
    {
        public RegistroTalleres()
        {
            InitializeComponent();
        }
        private Taller Vaciar()
        {
            Taller taller = new Taller();
            TallerIDNum.Value = 0;
            NombreTallerBox.Clear();


            return taller;


        }
        private Taller LlenarClase()
        {

            Taller taller = new Taller();

            taller.TallerID = Convert.ToInt32(TallerIDNum.Value);
            taller.Nombre = NombreTallerBox.Text;
            return taller;
        }
        private bool Validar(int validar)
        {

            bool paso = false;

            if (validar == 1 && TallerIDNum.Value == 0)
            {
                errorProvider1.SetError(NombreTallerBox, "Ingrese un ID");
                paso = true;

            }
            return paso;
        }

        private void BuscarBoton_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (Validar(1))
            {
                MessageBox.Show("Ingrese un ID");
                return;
            }

            int id = Convert.ToInt32(TallerIDNum.Value);
            Taller taller = BLL.TallerBLL.Buscar(id);

            if (taller != null)
            {

                NombreTallerBox.Text = taller.Nombre;



            }
            else
                MessageBox.Show("No se encontro", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void RegistroTalleres_Load(object sender, EventArgs e)
        {

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


            if (TallerIDNum.Value == 0)
                paso = BLL.TallerBLL.Guardar(LlenarClase());
            else
                paso = BLL.TallerBLL.Modificar(LlenarClase());


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

            int id = Convert.ToInt32(TallerIDNum.Value);

            if (BLL.TallerBLL.Eliminar(id))
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo eliminar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    }


     
        

