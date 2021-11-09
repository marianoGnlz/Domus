using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domus.Models
{
    public abstract class Persona
    {
        private string nombre;
        private string apellido;
        private string dni;
        private string cuil;
        private DateTime fechaDeNacimiento;
        private string telefono;
        private string email;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public string DNI
        {
            get { return dni; }
            set { dni = value; }
        }
        public string CUIL
        {
            get { return cuil; }
            set { cuil = value; }
        }
        public DateTime FechaDeNacimiento
        {
            get { return fechaDeNacimiento; }
            set { fechaDeNacimiento = value; }
        }
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

    }
}
