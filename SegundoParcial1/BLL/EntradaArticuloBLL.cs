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
   public class EntradaArticuloBLL
    {
        public static bool Guardar(EntradaArticulos entrada)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                if (contexto.entradas.Add(entrada) != null)
                {
                    //todo: afectar el inventario
                    Articulo articulo = BLL.ArticuloBLL.Buscar(entrada.ArticuloID);
                    articulo.Inventario += entrada.Cantidad;
                    BLL.ArticuloBLL.Modificar(articulo);

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

        public static bool Modificar(EntradaArticulos entrada)
        {

            bool paso = false;

            Contexto contexto = new Contexto();
            //buscar entrada guardada
            EntradaArticulos EntradaAnterior = BLL.EntradaArticuloBLL.Buscar(entrada.EntradaID);

            //identificar la diferencia ya sea restada o sumada
            int diferencia;

            diferencia = entrada.Cantidad - EntradaAnterior.Cantidad; 

            //aplicar diferencia al inventario
            Articulo articulo = BLL.ArticuloBLL.Buscar(entrada.ArticuloID);
            articulo.Inventario += diferencia;
            BLL.ArticuloBLL.Modificar(articulo);

            try
            {
                contexto.Entry(entrada).State = EntityState.Modified;

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

                EntradaArticulos entrada = contexto.entradas.Find(id);
               
                Articulo articulo = BLL.ArticuloBLL.Buscar(entrada.ArticuloID);
                articulo.Inventario -= entrada.Cantidad;
                BLL.ArticuloBLL.Modificar(articulo);

                contexto.entradas.Remove(entrada);
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


        public static EntradaArticulos Buscar(int id)
        {

            EntradaArticulos entrada = new EntradaArticulos();
            Contexto contexto = new Contexto();

            try
            {
                entrada = contexto.entradas.Find(id);
                contexto.Dispose();

            }

            catch (Exception)
            {

                throw;

            }

            return entrada;

        }


        public static List<EntradaArticulos> GetList(Expression<Func<EntradaArticulos, bool>> expression)
        {

            List<EntradaArticulos> entrada = new List<EntradaArticulos>();
            Contexto contexto = new Contexto();

            try
            {

                entrada = contexto.entradas.Where(expression).ToList();
                contexto.Dispose();
            }
            catch (Exception)
            {

                throw;
            }

            return entrada;
        }
    }
}
