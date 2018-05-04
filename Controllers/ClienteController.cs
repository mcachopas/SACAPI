using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SacAPI.ControllersViewModel;
using SacAPI.Service;
using SacAPI.Domain;

namespace SacAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/Cliente")]
    public class ClienteController : Controller
    {
        public IClienteStore<Cliente> Clientes_Store;

        [HttpGet]
        public IEnumerable<String> Get()
        {
            Cliente_VM teste = new Cliente_VM();
            //List<Cliente> clientes;
            var clientes = teste.GetclientesAsync();
            return new string[] { "value1", "value2", "value3", "value4" };
        }

        [HttpGet("{CNPJ}")]
        public IEnumerable<String> Get(String CNPJ)
        {
            return new string[] { "value1", "value2", "value3" };
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
    }
}