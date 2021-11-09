using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domus.Models
{
    public abstract class PersonaJuridica : Persona
    {
        private string domicilio;
        private string nacionalidad;
        private string razonSocial;
        private string cuit;

        public string CUIT
        {
            get { return cuit; }
            set { cuit = value; }
        }
        public string RazonSocial
        {
            get { return razonSocial; }
            set { razonSocial = value; }
        }
        public string Nacionalidad
        {
            get { return nacionalidad; }
            set { nacionalidad = value; }
        }
        public string Domicilio
        {
            get { return domicilio; }
            set { domicilio = value; }
        }

    }
}
