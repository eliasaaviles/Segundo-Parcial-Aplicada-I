using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SegundoParcial1.Entidades;
using SegundoParcial1.DAL;
using SegundoParcial1.BLL;

namespace SegundoParcial1.UI
{
    public partial class RegistroMantenimiento : Form
    {
        decimal itbis = 0;
        decimal Total = 0;


        public RegistroMantenimiento()
        {
            InitializeComponent();
            LlenarComboBox();
        }
        public void Vaciar()
        {
            IDnumericUpDown1.Value = 0;
            FechadateTimePicker1.Value = DateTime.Now;
            ProxFechadateTimePicker1.Value = DateTime.Now;
            CantidadNum.Value = 1;
            TotalBox.Clear();

            ImporteBox.Clear();
            SubBox.Text = 0.ToString();
            TotalBox.Text = 0.ToString();
            ItbisBox.Text = 0.ToString();
            MantenimientoData.DataSource = null;

            itbis = 0;

            Total = 0;



        }
        private decimal ToDecimal(object valor)
        {
            decimal retorno = 1;
            decimal.TryParse(valor.ToString(), out retorno);
            return retorno;

        }
        private int ToInt(object valor)
        {
            int retorno = 0;
            int.TryParse(valor.ToString(), out retorno);
            return retorno;

        }



        private Mantenimiento LlenaClase()
        {
            Mantenimiento mantenimiento = new Mantenimiento();

            mantenimiento.MantenimientoId = Convert.ToInt32(IDnumericUpDown1.Value);
            mantenimiento.VehiculoId = Convert.ToInt32(VehiculocomboBox.SelectedValue);
            mantenimiento.Fecha = FechadateTimePicker1.Value;
            mantenimiento.ProxFecha = ProxFechadateTimePicker1.Value;



            foreach (DataGridViewRow item in MantenimientoData.Rows)
            {

                mantenimiento.AgregarDetalle(ToInt(item.Cells["id"].Value),
                     mantenimiento.MantenimientoId,
                      ToInt(item.Cells["tallerId"].Value),
                      ToInt(item.Cells["articulosId"].Value),
                     Convert.ToString(item.Cells["articulo"].Value),
                       ToDecimal(item.Cells["cantidad"].Value),
                       ToDecimal(item.Cells["precio"].Value),
                    ToDecimal(item.Cells["importe"].Value));
            }
            return mantenimiento;
        }
        private void LlenarCampos(Mantenimiento mantenimiento)
        {
            Vaciar();
            IDnumericUpDown1.Value = mantenimiento.MantenimientoId;
            FechadateTimePicker1.Value = mantenimiento.Fecha;
            ProxFechadateTimePicker1.Value = mantenimiento.ProxFecha;



            MantenimientoData.DataSource = mantenimiento.Detalle;


            MantenimientoData.Columns["Id"].Visible = false;
            MantenimientoData.Columns["MantenimientoId"].Visible = false;
            MantenimientoData.Columns["TallerId"].Visible = false;
            MantenimientoData.Columns["ArticulosId"].Visible = false;
            MantenimientoData.Columns["Articulo"].Visible = false;




        }
        private void LlenarComboBox()
        {
            Repositorio<Vehiculo> vehiculo = new Repositorio<Vehiculo>(new Contexto());
            VehiculocomboBox.DataSource = vehiculo.GetList(c => true);
            VehiculocomboBox.ValueMember = "VehiculoID";
            VehiculocomboBox.DisplayMember = "Descripcion";

            Repositorio<Taller> talleres = new Repositorio<Taller>(new Contexto());
            TallerBox.DataSource = talleres.GetList(c => true);
            TallerBox.ValueMember = "TallerID";
            TallerBox.DisplayMember = "Nombre";

            Repositorio<Articulo> Entrada = new Repositorio<Articulo>(new Contexto());
            ArticuloCombo.DataSource = Entrada.GetList(c => true);
            ArticuloCombo.ValueMember = "ArticuloID";
            ArticuloCombo.DisplayMember = "Descripcion";
        }


        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void RegistroMantenimiento_Load(object sender, EventArgs e)
        {
            DateTime fecha = Convert.ToDateTime(ProxFechadateTimePicker1.Text);
            fecha = fecha.AddMonths(3);

            ProxFechadateTimePicker1.Text = fecha.ToString();
        }

        private void BuscarBoton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IDnumericUpDown1.Value);

            Mantenimiento mantenimiento = BLL.MantenimientoDetalleBLL.Buscar(id);


            if (mantenimiento != null)
            {
                LlenarCampos(mantenimiento);

            }
            else
                MessageBox.Show("No se encontro!", "Fallo",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ArticuloCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in BLL.ArticuloBLL.GetList(x => x.Descripcion == ArticuloCombo.Text))
            {
                PrecioBox.Text = item.Precio.ToString();

            }
        }

        private void AnadirBoton_Click(object sender, EventArgs e)
        {
            List<MantenimientoDetalle> detalle = new List<MantenimientoDetalle>();



            if (MantenimientoData.DataSource != null)
            {
                detalle = (List<MantenimientoDetalle>)MantenimientoData.DataSource;
            }


            foreach (var item in BLL.ArticuloBLL.GetList(x => x.Inventario < CantidadNum.Value))
            {

                MessageBox.Show("No hay existencia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(ImporteBox.Text))
            {
                MessageBox.Show("LLENAR CANTIDAD", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                detalle.Add(
                    new MantenimientoDetalle(id: 0,
                    mantenimientoId: (int)Convert.ToInt32(IDnumericUpDown1.Value),
                    tallerId: (int)TallerBox.SelectedValue,
                       articulosId: (int)ArticuloCombo.SelectedValue,
                            articulo: (string)BLL.ArticuloBLL.RetornarDescripcion(ArticuloCombo.Text),
                        cantidad: Convert.ToDecimal(CantidadNum.Value),
                        precio: Convert.ToDecimal(PrecioBox.Text),
                        importe: Convert.ToDecimal(ImporteBox.Text)));


                MantenimientoData.DataSource = null;
                MantenimientoData.DataSource = detalle;


                MantenimientoData.Columns["Id"].Visible = false;
                MantenimientoData.Columns["MantenimientoId"].Visible = false;
                MantenimientoData.Columns["TallerId"].Visible = false;
                MantenimientoData.Columns["ArticulosId"].Visible = false;
                MantenimientoData.Columns["articulo"].Visible = false;





            }


            decimal subtotal = 0;

            foreach (var item in detalle)
            {
                subtotal += item.Importe;

            }


            SubBox.Text = subtotal.ToString();

            itbis = BLL.MantenimientoDetalleBLL.CalcularItbis(Convert.ToDecimal(SubBox.Text));

            ItbisBox.Text = itbis.ToString();

            Total = BLL.MantenimientoDetalleBLL.Total(Convert.ToDecimal(SubBox.Text), Convert.ToDecimal(ItbisBox.Text));

            TotalBox.Text = Total.ToString();
        }

        private void CantidadBox_TextChanged(object sender, EventArgs e)
        {
            ImporteBox.Text = BLL.MantenimientoDetalleBLL.CalcularImporte(Convert.ToInt32(PrecioBox.Text), Convert.ToInt32(CantidadNum.Value)).ToString(); ;

        }

        private void ProxFechadateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            FechadateTimePicker1.Value = FechadateTimePicker1.Value;


            DateTime fecha = Convert.ToDateTime(FechadateTimePicker1.Text);
            fecha = fecha.AddMonths(3);

            ProxFechadateTimePicker1.Text = fecha.ToString();
        }

        private void EliminarBoton_Click(object sender, EventArgs e)
        {



            int id = Convert.ToInt32(IDnumericUpDown1.Value);
            if (BLL.MantenimientoDetalleBLL.Eliminar(id))
            {
                MessageBox.Show("Eliminado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Vaciar();
            }
            else
                MessageBox.Show("No se pudo eliminar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void NuevoBoton_Click(object sender, EventArgs e)
        {
            Vaciar();
        }

        private void CantidadNum_ValueChanged(object sender, EventArgs e)
        {
            ImporteBox.Text = BLL.MantenimientoDetalleBLL.CalcularImporte(Convert.ToDecimal(PrecioBox.Text), Convert.ToInt32(CantidadNum.Value)).ToString(); ;
        }

        private void GuardarBoton_Click(object sender, EventArgs e)
        {


            Mantenimiento mantenimiento = LlenaClase();
            bool Paso = false;

            if (IDnumericUpDown1.Value == 0)
            {
                Paso = BLL.MantenimientoDetalleBLL.Guardar(mantenimiento);

            }
            else
            {

                Paso = BLL.MantenimientoDetalleBLL.Modificar(mantenimiento);

            }

            if (Paso)
            {
                Vaciar();
                MessageBox.Show("Guardado!!", "Exito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No se pudo guardar!!", "Fallo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ImporteBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RemoverBoton_Click(object sender, EventArgs e)
        {
            Mantenimiento mantenimiento = new Mantenimiento();
            if (MantenimientoData.Rows.Count > 0 && MantenimientoData.CurrentRow != null)
            {

                List<MantenimientoDetalle> detalle = (List<MantenimientoDetalle>)MantenimientoData.DataSource;


                detalle.RemoveAt(MantenimientoData.CurrentRow.Index);

                decimal subtotal = 0;

                foreach (var item in detalle)
                {
                    subtotal -= item.Importe;
                }

                subtotal *= (-1);
                SubBox.Text = subtotal.ToString();

                itbis = BLL.MantenimientoDetalleBLL.CalcularItbis(Convert.ToDecimal(SubBox.Text));
                ItbisBox.Text = itbis.ToString();

                Total = BLL.MantenimientoDetalleBLL.Total(Convert.ToDecimal(SubBox.Text), Convert.ToDecimal(ItbisBox.Text));

                TotalBox.Text = Total.ToString();
                                
                MantenimientoData.DataSource = null;
                MantenimientoData.DataSource = detalle;

                MantenimientoData.Columns["Id"].Visible = false;
                MantenimientoData.Columns["MantenimientoId"].Visible = false;
                MantenimientoData.Columns["TallerId"].Visible = false;
                MantenimientoData.Columns["ArticulosId"].Visible = false;
                MantenimientoData.Columns["articulo"].Visible = false;
            }
        }

        private void MantenimientoData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}



