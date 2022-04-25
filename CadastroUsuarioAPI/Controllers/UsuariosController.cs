using CadastroUsuarioAPI.Data.Repositories;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace CadastroUsuarioAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private IUsuarioRepository _usuarioResitory;

        public UsuariosController(IUsuarioRepository usuarioResitory)
        {
            _usuarioResitory = usuarioResitory;
        }

        // GET: api/<PessoasController>
        [HttpGet]
        public IActionResult Get()
        {
            var usuario = _usuarioResitory.Buscar();
            return Ok(usuario);
        }

        // GET api/<PessoasController>/{id}
        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            var usuario = _usuarioResitory.Buscar(id);

            if (usuario == null)
                return NotFound();

            return Ok(usuario);
        }

        // POST api/<PessoasController>
        [HttpPost]
        public IActionResult Post([FromBody] Usuario novoUsuario)
        {
            //passar como paramentro novoUsuario ==
            var usuario = new Usuario(novoUsuario.NomeUsuario, novoUsuario.SenhaUsuario);
            _usuarioResitory.Adicionar(usuario);
            return Created("", usuario);
        }

        // PUT api/<PessoasController>/{id}
        [HttpPut("{id}")]
        public IActionResult Put(string id, [FromBody] Usuario atualizarUsuario)
        {
            var usuario = _usuarioResitory.Buscar(id);

            if (usuario == null)
                return NotFound();

            usuario.AtualizarSenhaUsuario(atualizarUsuario.SenhaUsuario);

            _usuarioResitory.Atualizar(id, usuario);

            return Ok(usuario);
        }

        // DELETE api/<PessoasController>/{id}
        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            var usuario = _usuarioResitory.Buscar(id);

            if (usuario == null)
                return NotFound();

            _usuarioResitory.Remover(id);

            return NoContent();
        }
    }
}
