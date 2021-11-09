using Domus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domus.IServices
{
    public interface ICalendarioService
    {
        Request<IList<Calendario>> GetCalendarios();
        Request<Calendario> GetCalendario(int id);
        Request<Calendario> GetCalendarioByFecha(DateTime date);
        Request<Calendario> Save(Calendario calendario);
        Request<Calendario> Update(Calendario calendario);
        Request<Calendario> Delete(int id);
    }
}
