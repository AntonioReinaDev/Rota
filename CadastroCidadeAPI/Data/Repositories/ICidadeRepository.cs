using CadastroCidadeAPI.Model;
using System.Collections.Generic;

namespace CadastroCidadeAPI.Data.Repositories
{
    public interface ICidadeRepository
    {
        void Adicionar(Cidade Cidade);

        void Atualizar(string id, Cidade atualizarCidade);

        IEnumerable<Cidade> Buscar();

        Cidade Buscar(string id);

        void Remover(string id);
    }
}
