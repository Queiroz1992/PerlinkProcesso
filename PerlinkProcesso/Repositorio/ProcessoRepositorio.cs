using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PerlinkProcesso.Models;

namespace PerlinkProcesso.Repositorio
{
    public class ProcessoRepositorio : IProcessoRepositorio
    {
        private readonly ProcessoDbContext _contexto;

        public ProcessoRepositorio(ProcessoDbContext ctx)
        {
            _contexto = ctx;
        }

        public void Inserir(Processo processo)
        {
            _contexto.Processos.Add(processo);
            _contexto.SaveChanges();
        }

        public Processo ObterProcessoPorId(int id)
        {
            return _contexto.Processos.FirstOrDefault(p => p.ProcessoId == id);
        }

        public IEnumerable<Processo> ObterTodosProcessos()
        {
            return _contexto.Processos.ToList();
        }
    }
}
