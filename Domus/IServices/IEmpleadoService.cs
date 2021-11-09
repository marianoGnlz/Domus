using Domus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domus.IServices
{
    public interface IEmpleadoService
    {
        Request<IList<Empleado>> GetEmpleados();
        Request<Empleado> GetEmpleado(int id);
        Request<Empleado> Save(Empleado empleado);
        Request<Empleado> Update(Empleado empleado);
        Request<Empleado> Delete(int id);
    }
}
