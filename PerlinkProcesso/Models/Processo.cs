using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PerlinkProcesso.Models
{
    public class Processo
    {
        public int ProcessoId { get; set; }
        public string NumeroDoProcesso { get; set; }
        public DateTime DataDeCriacaoDoProcesso { get; set; }
        public decimal Valor { get; set; }
        public string Escritorio { get; set; }
    }
}
