﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace SegundoParcial1.Entidades
{ 
         public class Mantenimiento
        {
            [Key]
            public int MantenimientoId { get; set; }
            public int VehiculoId { get; set; }
            public DateTime Fecha { get; set; }
            public DateTime ProxFecha { get; set; }
            public decimal Subtotal { get; set; }
            public decimal itbis { get; set; }
            public decimal Total { get; set; }
            public decimal Cantidad { get; set; }


        public virtual ICollection<MantenimientoDetalle> Detalle { get; set; }

            public Mantenimiento()
            {
                this.Detalle = new List<MantenimientoDetalle>();

                MantenimientoId = 0;
                Fecha = DateTime.Now;
                Subtotal = 0;
                itbis = 0;
                Total = 0;
                Cantidad = 1;

            }

            public void AgregarDetalle(int id, int mantenimientoId, int tallerId, int articulosId, string articulo, decimal cantidad, decimal precio, decimal importe)
            {
                this.Detalle.Add(new MantenimientoDetalle(id, mantenimientoId, tallerId, articulosId, articulo, cantidad, precio, importe));
            }
        }
    }

