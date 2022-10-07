using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PDapperExample.Model;
using PDapperExample.Repository;

namespace PDapperExample.Services
{
    public class ClienteServices
    {
        private IClienteRepository _clienteRepository;

        public ClienteServices()
        {
            _clienteRepository = new ClienteRepository();
        }   

        public bool ADD(Cliente cliente)
        {
            return _clienteRepository.ADD(cliente);
        }

        public List<Cliente> GetAll()
        {
            return _clienteRepository.GetAll(); 
        }
    }
}
