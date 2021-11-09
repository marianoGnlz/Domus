using Domus.Models.Types;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Domus.Models
{
    public class Empleado : Persona
    {
        [Key]
        public int IdEmpleado { get; set; }
        private int nroCuenta;
        private TipoEmpleados tipo;


        public TipoEmpleados Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        public int NroCuenta
        {
            get { return nroCuenta; }
            set { nroCuenta = value; }
        }

        public virtual Agenda Agenda { get; set; }

    }
}
