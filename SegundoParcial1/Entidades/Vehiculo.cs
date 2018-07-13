using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace SegundoParcial1.Entidades
{
    public class Vehiculo
    {
        [Key]

        public int VehiculoID { get; set; }
        public string Descripcion { get; set; }
        public decimal MantenimientoTotal { get; set; }

        public Vehiculo()
        { }

        public override string ToString()
        {
            return this.Descripcion;
        }
    }

    
}
