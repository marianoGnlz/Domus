using Domus.Models.Types;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Domus.Models
{
    public class Cliente : PersonaJuridica
    {
        public Cliente()
        {
            Cita = new HashSet<Cita>();
        }
        [Key]
        public int IdCliente { get; set; }
        private int nroCuenta;
        private TipoCliente tipo;

        public TipoCliente Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        public int NroCuenta
        {
            get { return nroCuenta; }
            set { nroCuenta = value; }
        }

        public virtual ICollection<Cita> Cita { get; set; }
    }
}
