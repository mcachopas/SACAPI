using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SacAPI.Domain
{
    public class Atendimento
    {

        public int Id { get; set; }
        public int ChamadoId { get; set; }
        public int ClienteId { get; set; }
        public String ClienteCodigo { get; set; }
        public int Atendente { get; set; }
        public DateTime AberturaData { get; set; }
        public DateTime FechamentoData { get; set; }
        public String Solucao { get; set; }
        public String Problema { get; set; }
        public String Historico { get; set; }
        public String Situacao { get; set; }
        public String Presencial { get; set; }
        public int Motivo { get; set; }
        public int BancoId { get; set; }

    }
}
