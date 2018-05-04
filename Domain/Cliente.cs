using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SacAPI.Domain
{
    public class Cliente
    {
            public int Id { get; set; }
            public String Codigo { get; set; }
            public String Nome { get; set; }
            public String Fantasia { get; set; }
            public String Endereco { get; set; }
            public String NumEnereco { get; set; }
            public String Bairro { get; set; }
            public String Cidade { get; set; }
            public String UF { get; set; }
            public String CodigoCidade { get; set; }
            public String Cnpj_Cpf { get; set; }
            public String Ie_Rg { get; set; }
            public String Telefone { get; set; }
            public String Celular { get; set; }
            public String Email { get; set; }
            public String AtivoCad { get; set; }
            public int VencimentoSistema { get; set; }
    }
}
