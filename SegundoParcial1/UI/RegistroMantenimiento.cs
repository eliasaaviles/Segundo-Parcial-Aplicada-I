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
        decimal importe = 0;
        decimal Total = 0;
        decimal subtotal = 0;

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
            CantidadNum.Value=0;
            TotalBox.Clear();

            ImporteBox.Clear();
            SubBox.Text = 0.ToString();
            TotalBox.Text = 0.ToString();
            ItbisBox.Text = 0.ToString();
            MantenimientoData.DataSource = null;

            itbis = 0;
            importe = 0;
            Total = 0;
            subtotal = 0;

            
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
            mantenimiento.Subtotal = Convert.ToDecimal(SubBox.Text);
            mantenimiento.itbis = Convert.ToDecimal(ItbisBox.Text);
            mantenimiento.Total = Convert.ToDecimal(TotalBox.Text);

            MantenimientoData.Columns["MantenimientoId"].Visible = false;
            MantenimientoData.Columns["Id"].Visible = false;
            MantenimientoData.Columns["MantenimientoId"].Visible = false;
            MantenimientoData.Columns["TallerId"].Visible = false;
            MantenimientoData.Columns["ArticulosId"].Visible = false;
            MantenimientoData.Columns["articulo"].Visible = false;


            foreach (DataGridViewRow item in MantenimientoData.Rows)
            {

                mantenimiento.AgregarDetalle(ToInt(item.Cells["id"].Value),
                     mantenimiento.MantenimientoId, ToInt(item.Cells["tallerId"].Value),
                     ToInt(item.Cells["articulosId"].Value), Convert.ToString(item.Cells["articulo"].Value),
                       ToInt(item.Cells["cantidad"].Value), ToInt(item.Cells["precio"].Value),
                    ToInt(item.Cells["importe"].Value));
            }
            return mantenimiento;
        }
        private void LlenarCampos(Mantenimiento mantenimiento)
        {
            Vaciar();
            IDnumericUpDown1.Value = mantenimiento.MantenimientoId;
            FechadateTimePicker1.Value = mantenimiento.Fecha;
            ProxFechadateTimePicker1.Value = mantenimiento.ProxFecha;
            SubBox.Text = mantenimiento.Subtotal.ToString();
            ItbisBox.Text = mantenimiento.itbis.ToString();
            TotalBox.Text = mantenimiento.Total.ToString();

            foreach (var item in mantenimiento.Detalle)
            {
                subtotal += item.Importe;

            }
            SubBox.Text = subtotal.ToString();



            MantenimientoData.DataSource = mantenimiento.Detalle;

            
            MantenimientoData.Columns["Id"].Visible = false;
            MantenimientoData.Columns["MantenimientoId"].Visible = false;
            MantenimientoData.Columns["TallerId"].Visible = false;
            MantenimientoData.Columns["ArticulosId"].Visible = false;
            MantenimientoData.Columns["RegistrodeArticulos"].Visible = false;




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
                PrecioBox.Text = item.Precip.ToString();

            }
        }

        private void AnadirBoton_Click(object sender, EventArgs e)
        {
            List<MantenimientoDetalle> detalle = new List<MantenimientoDetalle>();
            Mantenimiento mantenimiento = new Mantenimiento();


            if (MantenimientoData.DataSource != null)
            {
                mantenimiento.Detalle = (List<MantenimientoDetalle>)MantenimientoData.DataSource;
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
                mantenimiento.Detalle.Add(
                    new MantenimientoDetalle(id: 0,
                    mantenimientoId: (int)Convert.ToInt32(IDnumericUpDown1.Value),
                    tallerId: (int)TallerBox.SelectedValue,
                       articulosId: (int)ArticuloCombo.SelectedValue,
                            articulo: (string)BLL.ArticuloBLL.RetornarDescripcion(ArticuloCombo.Text),
                        cantidad: Convert.ToInt32(CantidadNum.Value),
                        precio: Convert.ToInt32(PrecioBox.Text),
                        importe: Convert.ToInt32(ImporteBox.Text)));


                MantenimientoData.DataSource = null;
                MantenimientoData.DataSource = mantenimiento.Detalle;

               
                MantenimientoData.Columns["Id"].Visible = false;
               MantenimientoData.Columns["MantenimientoId"].Visible = false;
                MantenimientoData.Columns["TallerId"].Visible = false;
                MantenimientoData.Columns["ArticulosId"].Visible = false;
                MantenimientoData.Columns["articulo"].Visible = false;





            }


            importe += BLL.MantenimientoDetalleBLL.CalcularImporte(Convert.ToDecimal(PrecioBox.Text), Convert.ToInt32(CantidadNum.Value));

            if (IDnumericUpDown1.Value != 0)
            {

                subtotal += importe;
                SubBox.Text = subtotal.ToString();
            }
            else
            {

                subtotal = importe;
                SubBox.Text = subtotal.ToString();
            }

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



            MessageBox.Show("Favor Llenar Casilla!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);



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
            ImporteBox.Text = BLL.MantenimientoDetalleBLL.CalcularImporte(Convert.ToInt32(PrecioBox.Text), Convert.ToInt32(CantidadNum.Value)).ToString();
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
    }
    }



