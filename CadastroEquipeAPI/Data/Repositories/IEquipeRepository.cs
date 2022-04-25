using CadastroEquipeAPI.Model;
using System.Collections.Generic;

namespace CadastroEquipeAPI.Data.Repositories
{
    public interface IEquipeRepository
    {
        void Adicionar(Equipe Equipe);

        void Atualizar(string id, Equipe atualizarEquipe);

        IEnumerable<Equipe> Buscar();

        Equipe Buscar(string id);

        void Remover(string id);
    }
}
