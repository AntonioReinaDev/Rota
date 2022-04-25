using Model;
using System.Collections.Generic;

namespace CadastroUsuarioAPI.Data.Repositories
{
    public interface IUsuarioRepository
    {
        void Adicionar(Usuario usuario);

        void Atualizar(string id, Usuario atualzarSenhaUsuario);

        IEnumerable<Usuario> Buscar();

        Usuario Buscar(string id);

        void Remover(string id);
    }
}
