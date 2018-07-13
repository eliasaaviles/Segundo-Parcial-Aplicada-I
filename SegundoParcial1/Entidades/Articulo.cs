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
        public decimal Ganancia { get; set; }
        public decimal Precip { get; set; }
        public int Inventario { get; set; }

        public Articulo()
        { }

        public override string ToString()
        {
            return this.Descripcion;
        }
    }
}
