using SacAPI.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SacAPI.Service
{
    public interface IClienteStore<T>
    {
        Task<Cliente> ConsultaClienteAsync(T Cliente);
        Task<Cliente> ConsultaValidade(T Cliente);
        Task<bool> GeraSenha(T Cliente);

        Task<IEnumerable<T>> Get_ClientesAsync();
    }
}
