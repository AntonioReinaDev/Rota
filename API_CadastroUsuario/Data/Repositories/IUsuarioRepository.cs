using Model;
using System.Collections.Generic;

namespace API_CadastroUsuario.Data.Repositories
{
    public interface IUsuarioRepository
    {
        void Adicionar(Usuario usuario);

        void Atualizar(string id, Usuario atualizaSenhaUsuario);

        IEnumerable<Usuario> Buscar();

        Usuario Buscar(string id);

        void Remover(string id);
    }
}
