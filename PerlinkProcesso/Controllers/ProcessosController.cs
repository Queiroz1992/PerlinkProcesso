using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PerlinkProcesso.Models;
using PerlinkProcesso.Repositorio;

namespace PerlinkProcesso.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ProcessosController : ControllerBase
    {
        private readonly IProcessoRepositorio _processoRepositorio;

        public ProcessosController(IProcessoRepositorio processoRep)
        {
            _processoRepositorio = processoRep;
        }

        [HttpGet]
        public IEnumerable<Processo> GetTodosProcessos()
        {
            return _processoRepositorio.ObterTodosProcessos();
        }

        [HttpGet("{id}", Name = "GetProcesso")]
        public IActionResult GetProcessoPorId(int id)
        {
            var processo = _processoRepositorio.ObterProcessoPorId(id);
            if (processo == null)
            {
                return NotFound();
            }
            return new ObjectResult(processo);
        }

        [HttpPost]
        public IActionResult InserirProcesso([FromBody] Processo processo)
        {
            if (processo == null)
            {
                return BadRequest();
            }
            _processoRepositorio.Inserir(processo);
            return CreatedAtRoute("GetProcesso", new { id = processo.ProcessoId }, processo);
        }

    }
}