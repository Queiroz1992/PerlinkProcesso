using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PerlinkProcesso.Models
{
    public class ProcessoDbContext : DbContext
    {
        public ProcessoDbContext(DbContextOptions<ProcessoDbContext> options)
            :base(options)
        {

        }

        public DbSet<Processo> Processos { get; set; }
    }
}
