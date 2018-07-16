using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace SegundoParcial1.Entidades
{
    public class Articulo
    {
        [Key]

        public int ArticuloID { get; set; }
        public string Descripcion { get; set; }
        public decimal Costo { get; set; }
        public int Ganancia { get; set; }
        public decimal Precio { get; set; }
        public decimal Inventario { get; set; }

        public Articulo()
        {
            ArticuloID = 0;
            Descripcion = string.Empty;
            Costo = 0;
            Ganancia = 0;
            Precio = 0;
            Inventario = 0;

        }

        public override string ToString()
        {
            return this.Descripcion;
        }
    }
}
