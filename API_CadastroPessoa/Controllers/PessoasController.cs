using API_CadastroPessoa.Data.Repositories;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace API_CadastroPessoa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoasController : ControllerBase
    {
        
        private IPessoasRepository _pessoaRepository;

        public PessoasController(IPessoasRepository pessoasRepository)
        {
            _pessoaRepository = pessoasRepository;
        }

        // GET: api/<PessoasController>
        [HttpGet]
        public IActionResult Get()
        {
            var pessoas = _pessoaRepository.Buscar();
            return Ok(pessoas);
        }

        // GET api/<PessoasController>/{id}
        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            var pessoa = _pessoaRepository.Buscar(id);
            if (pessoa == null)
            {
                return NotFound();
            }
            return Ok(pessoa);
        }

        // POST api/pessoas
        [HttpPost]
        public IActionResult Post([FromBody] string novaPessoa)
        {
            var nova_Pessoa = new Pessoa(novaPessoa);
            _pessoaRepository.Adicionar(nova_Pessoa);
            return Created("", nova_Pessoa);
        }

        // PUT api/<PessoasController>/{id}
        [HttpPut("{id}")]
        public IActionResult Put(string id, [FromBody] Pessoa pessoaAtualizada)
        {
            var pessoa = _pessoaRepository.Buscar(id);
            if (pessoa == null)
            {
                return NotFound();
            }
            pessoa.AtualizarPessoa(pessoaAtualizada.NomePessoa);
            _pessoaRepository.Atualizar(id, pessoa);
            
            return Ok(pessoa);
        }

        // DELETE api/<PessoasController>/{id}
        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            var pessoa = _pessoaRepository.Buscar(id);
            if (pessoa == null)
            {
                return NotFound();
            }
            _pessoaRepository.Remover(id);
            //testar com NoContent
            return Ok();
        }
    }
}
