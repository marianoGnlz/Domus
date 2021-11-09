using Domus.IServices;
using Domus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domus.Services
{
    public class CalendarioService : ICalendarioService
    {
        public Request<Calendario> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Request<Calendario> GetCalendario(int id)
        {
            throw new NotImplementedException();
        }

        public Request<IList<Calendario>> GetCalendarios()
        {
            throw new NotImplementedException();
        }

        public Request<Calendario> Save(Calendario calendario)
        {
            throw new NotImplementedException();
        }

        public Request<Calendario> Update(Calendario calendario)
        {
            throw new NotImplementedException();
        }
    }
}
