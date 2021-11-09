using Domus.IServices;
using Domus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domus.Services
{
    public class ClientesService : IClientesService
    {
        private readonly TPIContext _context;

        public ClientesService(TPIContext context)
        {
            _context = context;
        }



        public Request<IList<Cliente>> GetClientes()
        {
            Request<IList<Cliente>> req = new();
            try
            {
                req.Data = _context.Clientes.ToList();
            }
            catch (Exception ex)
            {
                req.Message = ex.Message;
                req.Success = false;
            }
            return req;
        }

        public Request<Cliente> GetCliente(int id)
        {
            Request<Cliente> req = new();
            try
            {
                req.Data = _context.Clientes.FirstOrDefault(x => x.IdCliente == id);
            }
            catch (Exception ex)
            {
                req.Message = ex.Message;
                req.Success = false;
            }
            return req;
        }

        public Request<Cliente> Save(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public Request<Cliente> Delete(int id)
        {
            Request<Cliente> req = new();
            try
            {
                req.Data = _context.Clientes.FirstOrDefault(x => x.IdCliente == id);
                _context.Remove(req.Data);
                _context.SaveChanges();
                req.Message = "Cliente eliminado.";
            }
            catch (Exception ex)
            {
                req.Message = ex.Message;
                req.Success = false;
            }
            return req;
        }

        public Request<Cliente> Update(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public Request<Cliente> GetClienteByDNI(string dni)
        {
            Request<Cliente> req = new();
            try
            {
                req.Data = _context.Clientes.FirstOrDefault(x => x.DNI == dni);
            }
            catch (Exception ex)
            {
                req.Message = ex.Message;
                req.Success = false;
            }
            return req;
        }
    }
}
