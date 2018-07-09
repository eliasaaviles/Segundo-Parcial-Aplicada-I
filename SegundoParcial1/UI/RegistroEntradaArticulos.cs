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
    public partial class RegistroEntradaArticulos : Form
    {
        public RegistroEntradaArticulos()
        {
            InitializeComponent();
            LlenarComboBox();
        }
        private EntradaArticulos Vaciar()
        {
            EntradaArticulos entrada = new EntradaArticulos();
            EntradaIDNum.Value = 0;
            CantidadBox.Clear();
            


            return entrada;


        }
        private EntradaArticulos LlenarClase()
        {

            EntradaArticulos entrada = new EntradaArticulos();

            entrada.EntradaID = Convert.ToInt32(EntradaIDNum.Value);
            entrada.ArticuloID = (int) ArticuloComboBox.SelectedValue; 
            entrada.Fecha = FechaPicker.Text;
            entrada.Cantidad = Convert.ToInt32(CantidadBox.Text);
           
            return entrada;
        }

        private void LlenarComboBox()
        {
            Repositorio<Articulo> repositorio = new Repositorio<Articulo>(new Contexto());
            ArticuloComboBox.DataSource = repositorio.GetList(c => true);
            ArticuloComboBox.ValueMember = "ArticuloID";
            ArticuloComboBox.DisplayMember = "Descripcion";
        }
        
        private bool Validar(int validar)
                {

                    bool paso = false;

                    if (validar == 1 && EntradaIDNum.Value == 0)
                    {
                        errorProvider1.SetError(EntradaIDNum, "Ingrese un ID");
                        paso = true;

                    }
                    return paso;
                        }
            private void RegistroEntradaArticulos_Load(object sender, EventArgs e)
            {

            }

        private void ArticuloBox_SelectedIndexChanged(object sender, EventArgs e)
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


            if (EntradaIDNum.Value == 0)
                paso = BLL.EntradaArticuloBLL.Guardar (LlenarClase());
            else
                paso = BLL.EntradaArticuloBLL.Modificar (LlenarClase());


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

            int id = Convert.ToInt32(EntradaIDNum.Value);

            if (BLL.EntradaArticuloBLL.Eliminar(id))
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

            int id = Convert.ToInt32(EntradaIDNum.Value);
            EntradaArticulos entrada = BLL.EntradaArticuloBLL.Buscar(id);

            if (entrada != null)
            {

                FechaPicker.Text = entrada.Fecha;
                ArticuloComboBox.SelectedValue = entrada.ArticuloID;
                CantidadBox.Text = entrada.Cantidad.ToString();
               


            }
            else
                MessageBox.Show("No se encontro", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    }

