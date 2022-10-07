using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using PDapperExample.Config;
using PDapperExample.Model;

namespace PDapperExample.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private string _conn;

        public ClienteRepository()
        {
            _conn = DataBaseConfig.Get();
        }
        public bool ADD(Cliente cliente)
        {
           bool result = false;

            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                db.Execute(Cliente.INSERT,cliente);
                result = true;
            }
            return result;
        }

        public List<Cliente> GetAll()
        {
            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                var clientes = db.Query<Cliente>(Cliente.SELECT);
                return (List<Cliente>)clientes;
            }
        }
    }
}
