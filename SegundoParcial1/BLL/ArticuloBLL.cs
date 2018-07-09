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
    public class ArticuloBLL
    {
        public static bool Guardar(Articulo articulo)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                if (contexto.articulos.Add(articulo) != null)
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

        public static bool Modificar(Articulo articulo)
        {

            bool paso = false;

            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(articulo).State = EntityState.Modified;
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

                Articulo articulo = contexto.articulos.Find(id);
                contexto.articulos.Remove(articulo);
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


        public static Articulo Buscar(int id)
        {

            Articulo articulo = new Articulo();
            Contexto contexto = new Contexto();

            try
            {
                articulo = contexto.articulos.Find(id);
                contexto.Dispose();

            }

            catch (Exception)
            {

                throw;

            }

            return articulo;

        }


        public static List<Articulo> GetList(Expression<Func<Articulo, bool>> expression)
        {

            List<Articulo> articulo = new List<Articulo>();
            Contexto contexto = new Contexto();

            try
            {

                articulo = contexto.articulos.Where(expression).ToList();
                contexto.Dispose();
            }
            catch (Exception)
            {

                throw;
            }

            return articulo;
        }

        public static string RetornarDescripcion(string Nombre)
        {
            string Descripcion = string.Empty;
            var lista = GetList(x => x.Descripcion.Equals(Nombre));
            foreach (var item in lista)
            {
                Descripcion = item.Descripcion;
            }

            return Descripcion;
        }
    }
}
