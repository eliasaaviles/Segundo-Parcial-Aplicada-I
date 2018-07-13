using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace SegundoParcial1.Entidades
{
    public class MantenimientoDetalle
    {
        [Key]

        public int Id { get; set; }
        public int MantenimientoId { get; set; }
        public int TallerId { get; set; }
        public int ArticulosId { get; set; }
        public string Articulo { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal Importe { get; set; }

        [ForeignKey("ArticulosId")]
        public virtual Articulo articulo { get; set; }

        public MantenimientoDetalle()
        {
            Id = 0;
            MantenimientoId = 0;
        }

        public MantenimientoDetalle(int id, int mantenimientoId, int tallerId, int articulosId, string articulo, decimal cantidad, decimal precio, decimal importe)
        {
            Id = id;
            MantenimientoId = mantenimientoId;
            TallerId = tallerId;
            ArticulosId = articulosId;
            Articulo = articulo;
            Cantidad = cantidad;
            Precio = precio;
            Importe = importe;
        }
        
        public MantenimientoDetalle(int mantenimientoId, int articulosId, string articulo, decimal cantidad, decimal precio, decimal importe)
        {

            MantenimientoId = mantenimientoId;
            ArticulosId = articulosId;
            Articulo = articulo;
            Cantidad = cantidad;
            Precio = precio;
            Importe = importe;
        }

    }
}
