﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using SegundoParcial1.Entidades;
using SegundoParcial1.DAL;
using System.Data.Entity;
using System.Linq.Expressions;

namespace SegundoParcial1.BLL
{
    class VehiculoBLL
    {
        public static bool Guardar(Vehiculo vehiculo)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                if (contexto.vehiculos.Add(vehiculo) != null)
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
       
        public static bool Modificar(Vehiculo vehiculo)
        {

            bool paso = false;

            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(vehiculo).State = EntityState.Modified;
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

                Vehiculo vehiculo = contexto.vehiculos.Find(id);
                contexto.vehiculos.Remove(vehiculo);
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
        

        public static Vehiculo Buscar(int id)
        {

            Vehiculo vehiculo = new Vehiculo();
            Contexto contexto = new Contexto();

            try
            {
                vehiculo = contexto.vehiculos.Find(id);
                contexto.Dispose();

            }

            catch (Exception)
            {

                throw;

            }

            return vehiculo;

        }
       

        public static List<Vehiculo> GetList(Expression<Func<Vehiculo, bool>> expression)
        {

            List<Vehiculo> vehiculos = new List<Vehiculo>();
            Contexto contexto = new Contexto();

            try
            {

                vehiculos = contexto.vehiculos.Where(expression).ToList();
                contexto.Dispose();
            }
            catch (Exception)
            {

                throw;
            }

            return vehiculos;
        }
    }
}
