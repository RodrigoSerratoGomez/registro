using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace registro.Models
{
    public class Registro
    {
        public bool Matematica {get; set;}
        public bool Lenguaje {get; set;}
        public bool Historia {get; set;}
    }
}