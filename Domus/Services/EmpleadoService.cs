using Domus.IServices;
using Domus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domus.Services
{
    public class EmpleadoService : IEmpleadoService
    {
        public Request<Empleado> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Request<Empleado> GetEmpleado(int id)
        {
            throw new NotImplementedException();
        }

        public Request<IList<Empleado>> GetEmpleados()
        {
            throw new NotImplementedException();
        }

        public Request<Empleado> Save(Empleado empleado)
        {
            throw new NotImplementedException();
        }

        public Request<Empleado> Update(Empleado empleado)
        {
            throw new NotImplementedException();
        }
    }
}
