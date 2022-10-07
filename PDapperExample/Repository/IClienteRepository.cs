using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PDapperExample.Model;

namespace PDapperExample.Repository
{
    public interface IClienteRepository
    {
        bool ADD(Cliente cliente);
        List<Cliente> GetAll();

    }
}
