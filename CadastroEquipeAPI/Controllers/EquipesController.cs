using CadastroEquipeAPI.Data.Repositories;
using CadastroEquipeAPI.Model;
using Microsoft.AspNetCore.Mvc;


namespace CadastroEquipeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EquipesController : ControllerBase
    {
        private IEquipeRepository _equipeRepository;

        public EquipesController(IEquipeRepository equipeRepository)
        {
            _equipeRepository = equipeRepository;
        }

        // GET: api/<PessoasController>
        [HttpGet]
        public IActionResult Get()
        {
            var equipe = _equipeRepository.Buscar();
            return Ok(equipe);
        }

        // GET api/<PessoasController>/{id}
        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            var equipe = _equipeRepository.Buscar(id);

            if (equipe == null)
                return NotFound();

            return Ok(equipe);
        }

        // POST api/<PessoasController>
        [HttpPost]
        public IActionResult Post([FromBody] Equipe novaEquipe)
        {
            var equipe = new Equipe(novaEquipe.NomeEquipe) ;

            _equipeRepository.Adicionar(equipe);

            return Created("", equipe);
        }

        // PUT api/<PessoasController>/{id}
        [HttpPut("{id}")]
        public IActionResult Put(string id, [FromBody] Equipe atualizarEquipe)
        {
            var equipe = _equipeRepository.Buscar(id);

            if (equipe == null)
                return NotFound();

            equipe.AtualizarEquipe(atualizarEquipe.NomeEquipe);

            _equipeRepository.Atualizar(id, equipe);

            return Ok(equipe);
        }

        // DELETE api/<PessoasController>/{id}
        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            var pessoa = _equipeRepository.Buscar(id);

            if (pessoa == null)
                return NotFound();

            _equipeRepository.Remover(id);

            return NoContent();
        }
    }
}
