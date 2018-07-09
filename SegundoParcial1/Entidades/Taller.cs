using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace SegundoParcial1.Entidades
{
    public class Taller
    {
        [Key]

        public int TallerID { get; set; }
        public string Nombre { get; set; }
        

        public Taller()
        { }

        public override string ToString()
        {
            return this.Nombre;
        }
    }
}
