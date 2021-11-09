using Domus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domus.IServices
{
    public interface ICitaService
    {
        Request<IList<Cita>> GetCitas();
        Request<Cita> GetCita(int id);
        Request<Cita> Save(Cita cita);
        Request<Cita> Update(Cita cita);
        Request<Cita> Delete(int id);
    }
}
