using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SacAPI.Domain;
using SacAPI.Data;

namespace SacAPI.Service
{
    public class ClienteStore : IClienteStore<Cliente>
    {
        List<Cliente> clientes;
        DadosBanco DB = new DadosBanco();

        public ClienteStore ()
        {
            //ClienteStore.AddMVC();
        }

        public async Task<Cliente> ConsultaClienteAsync(Cliente Cliente)
        {
            return await Task.FromResult(Cliente);
        }

        public Task<Cliente> ConsultaValidade(Cliente Cliente)
        {
            throw new NotImplementedException();
        }

        public Task<bool> GeraSenha(Cliente Cliente)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Cliente>> Get_ClientesAsync()
        {
            DB.Command.CommandText = @"Select * from clientes";
            return await Task.FromResult(clientes);
        }
    }
}
