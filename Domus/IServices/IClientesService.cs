using Domus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domus.IServices
{
    public interface IClientesService
    {
        Request<IList<Cliente>> GetClientes();
        Request<Cliente> GetCliente(int id);
        Request<Cliente> Save(Cliente cliente);
        Request<Cliente> Delete(int id);
        Request<Cliente> Update(Cliente cliente);
    }
}
