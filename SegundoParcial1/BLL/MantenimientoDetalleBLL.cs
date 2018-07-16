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
            Vehiculo vehiculos = new Vehiculo();
            try
            {
                if (contexto.mantenimiento.Add(mantenimiento) != null)
                {

                    foreach (var item in mantenimiento.Detalle)
                    {
                        contexto.articulos.Find(item.ArticulosId).Inventario -= item.Cantidad;
                    }


                    contexto.vehiculos.Find(mantenimiento.VehiculoId).MantenimientoTotal += mantenimiento.Total;

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
                var Mantenimiento = BLL.MantenimientoDetalleBLL.Buscar(mantenimiento.MantenimientoId);


                if (Mantenimiento != null)
                {
                    
                    foreach (var item in Mantenimiento.Detalle)
                    {

                        contexto.articulos.Find(item.ArticulosId).Inventario += item.Cantidad;
                        
                        if (!mantenimiento.Detalle.ToList().Exists(si => si.Id == item.Id))
                        {
                            item.Articulo = null;
                            contexto.Entry(item).State = EntityState.Deleted;
                        }
                        

                    }


                    foreach (var item in mantenimiento.Detalle)
                    {
                        contexto.articulos.Find(item.ArticulosId).Inventario -= item.Cantidad;
                        
                        var estado = item.Id > 0 ? EntityState.Modified : EntityState.Added;
                        contexto.Entry(item).State = estado;
                    }
                    
                    Mantenimiento EntradaAnterior = BLL.MantenimientoDetalleBLL.Buscar(mantenimiento.MantenimientoId);
                                       
                    decimal diferencia;

                    diferencia = mantenimiento.Total - EntradaAnterior.Total;

                    Vehiculo vehiculos = BLL.VehiculoBLL.Buscar(mantenimiento.VehiculoId);
                    vehiculos.MantenimientoTotal += diferencia;
                    BLL.VehiculoBLL.Modificar(vehiculos);
                    
                    contexto.Entry(mantenimiento).State = EntityState.Modified;
                }



                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            { throw; }
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
                        contexto.articulos.Find(item.ArticulosId).Inventario += item.Cantidad;

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
