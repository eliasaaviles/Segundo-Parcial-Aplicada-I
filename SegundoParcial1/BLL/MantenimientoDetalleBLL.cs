using SegundoParcial1.DAL;
using SegundoParcial1.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace SegundoParcial1.BLL
{
    public class MantenimientoDetalleBLL
    {
        public static bool Guardar(Mantenimiento mantenimiento)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                if (contexto.mantenimiento.Add(mantenimiento) != null)
                {
                    contexto.SaveChanges();
                    paso = true;
                }

                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public static bool Modificar(Mantenimiento mantenimiento)
        {

            bool paso = false;

            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(mantenimiento).State = EntityState.Modified;
                if (contexto.SaveChanges() > 0)
                {
                    paso = true;

                }

                contexto.Dispose();

            }

            catch (Exception)
            {

                throw;

            }

            return paso;



        }

    



        public static bool Eliminar(int id)
        {

            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                Mantenimiento mantenimiento = contexto.mantenimiento.Find(id);


                if (mantenimiento != null)
                {
                    foreach (var item in mantenimiento.Detalle)
                    {
                        contexto.mantenimiento.Find(item.ArticulosId).Cantidad += item.Cantidad;

                    }

                    contexto.vehiculos.Find(mantenimiento.VehiculoId).MantenimientoTotal -= mantenimiento.Total;

                    mantenimiento.Detalle.Count();
                    contexto.mantenimiento.Remove(mantenimiento);



                }




                if (contexto.SaveChanges() > 0)
                {

                    paso = true;
                }
                contexto.Dispose();


            }
            catch (Exception) { throw; }
            return paso;

        }


        public static Mantenimiento Buscar(int id)
        {

            Mantenimiento mantenimiento = new Mantenimiento();
            Contexto contexto = new Contexto();

            try
            {
                mantenimiento = contexto.mantenimiento.Find(id);
                if (mantenimiento != null)
                {
                    mantenimiento.Detalle.Count();

                    foreach (var item in mantenimiento.Detalle)
                    {

                        string s = item.articulo.Descripcion;
                    }

                }
                contexto.Dispose();
            }
            catch (Exception) { throw; }
            return mantenimiento;
        }


        public static List<MantenimientoDetalle> GetList(Expression<Func<MantenimientoDetalle, bool>> expression)
        {

            List<MantenimientoDetalle> mantenimientos = new List<MantenimientoDetalle>();
            Contexto contexto = new Contexto();

            try
            {

                mantenimientos = contexto.mantenimientos.Where(expression).ToList();
                contexto.Dispose();
            }
            catch (Exception)
            {

                throw;
            }

            return mantenimientos;
        }
        public static decimal CalcularImporte(decimal precio, int cantidad)
        {
            return Convert.ToDecimal(precio) * Convert.ToInt32(cantidad);
        }

        public static decimal CalcularItbis(decimal subtotal)
        {
            return Convert.ToDecimal(subtotal) * Convert.ToDecimal(0.18);
        }

        public static decimal Total(decimal subtotal, decimal itbis)
        {
            return Convert.ToDecimal(subtotal) + Convert.ToDecimal(itbis);
        }

       
    }
}
