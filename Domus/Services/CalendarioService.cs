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
        private readonly TPIContext _context;   
        public CalendarioService(TPIContext context)
        {
            _context = context;
        }
        public Request<Calendario> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Request<Calendario> GetCalendario(int id)
        {
            throw new NotImplementedException();
        }

        public Request<Calendario> GetCalendarioByFecha(DateTime date)
        {
            Request<Calendario> req = new();
            try
            {
                req.Data = _context.Calendario.Include(x => x.Horarios).FirstOrDefault(x => x.Fecha == date);
            }
            catch (Exception ex)
            {
                req.Message = ex.Message;
                req.Success = false;
            }
            return req;
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
