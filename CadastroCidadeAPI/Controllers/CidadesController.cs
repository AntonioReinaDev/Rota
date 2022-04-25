using CadastroCidadeAPI.Data.Repositories;
using CadastroCidadeAPI.Model;
using Microsoft.AspNetCore.Mvc;

namespace CadastroCidadeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CidadesController : ControllerBase
    {
        private ICidadeRepository _cidadeRepository;

        public CidadesController(ICidadeRepository cidadeResitory)
        {
            _cidadeRepository = cidadeResitory;
        }

        // GET: api/<PessoasController>
        [HttpGet]
        public IActionResult Get()
        {
            var cidade = _cidadeRepository.Buscar();
            return Ok(cidade);
        }

        // GET api/<PessoasController>/{id}
        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            var cidade = _cidadeRepository.Buscar(id);

            if (cidade == null)
                return NotFound();

            return Ok(cidade);
        }

        // POST api/<PessoasController>
        [HttpPost]
        public IActionResult Post([FromBody] Cidade novaCidade)
        {
            var cidade = new Cidade(novaCidade.NomeCidade, novaCidade.EstadoCidade);

            _cidadeRepository.Adicionar(cidade);

            return Created("", cidade);
        }

        // PUT api/<PessoasController>/{id}
        [HttpPut("{id}")]
        public IActionResult Put(string id, [FromBody] Cidade atualizarCidade)
        {
            var cidade = _cidadeRepository.Buscar(id);

            if (cidade == null)
                return NotFound();

            cidade.AtualizarCidade(atualizarCidade.NomeCidade, atualizarCidade.EstadoCidade);

            _cidadeRepository.Atualizar(id, cidade);

            return Ok(cidade);
        }

        // DELETE api/<PessoasController>/{id}
        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            var pessoa = _cidadeRepository.Buscar(id);

            if (pessoa == null)
                return NotFound();

            _cidadeRepository.Remover(id);

            return NoContent();
        }
    }
}
