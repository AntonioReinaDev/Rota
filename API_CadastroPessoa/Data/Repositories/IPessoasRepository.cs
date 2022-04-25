using Model;
using System.Collections.Generic;

namespace API_CadastroPessoa.Data.Repositories
{
    public interface IPessoasRepository
    {
        void Adicionar(Pessoa pessoa);

        void Atualizar(string id, Pessoa atualizaPessoa);

        IEnumerable<Pessoa> Buscar();

        Pessoa Buscar(string id);

        void Remover(string id);

    }
}
