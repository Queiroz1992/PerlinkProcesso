using PerlinkProcesso.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PerlinkProcesso.Repositorio
{
    public interface IProcessoRepositorio
    {
        void Inserir(Processo processo);

        IEnumerable<Processo> ObterTodosProcessos();

        Processo ObterProcessoPorId(int id);
    }
}
