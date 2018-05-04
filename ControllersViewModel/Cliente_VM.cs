using SacAPI.Data;
using SacAPI.Domain;
using SacAPI.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace SacAPI.ControllersViewModel
{
    public class Cliente_VM : Base_Cliente_VM
    {
        public List<Cliente> clientes;
        ClienteStore clientestore;

        public Cliente_VM()
        {
            //Load_Clientes_Command = new Command(() => Execute_Load_Command());
        }

        public async Task<IEnumerable<Cliente>> GetclientesAsync ()
        {
            clientestore = new ClienteStore();
            var cli = await clientestore.Get_ClientesAsync();
            //clientes = cli;
            return clientes;
        }

    }
}
