using API_CadastroPessoa.Data.Configuration;
using Model;
using MongoDB.Driver;
using System.Collections.Generic;

namespace API_CadastroPessoa.Data.Repositories
{
    public class PessoaRepository : IPessoasRepository
    {

        private readonly IMongoCollection<Pessoa> _pessoas;

        public PessoaRepository(IDatabaseConfig databaseConfig)
        {
            var client = new MongoClient(databaseConfig.ConnectionString);
            var database = client.GetDatabase(databaseConfig.DatabaseName);
            _pessoas = database.GetCollection<Pessoa>("Pessoas");
        }

        public void Adicionar(Pessoa pessoa)
        {
            _pessoas.InsertOne(pessoa);
        }

        public void Atualizar(string id, Pessoa atualizaPessoa)
        {
            _pessoas.ReplaceOne(pessoa => pessoa.Id == id, atualizaPessoa);
        }

        public IEnumerable<Pessoa> Buscar()
        {
            return _pessoas.Find(pessoa => true).ToList();
        }

        public Pessoa Buscar(string id)
        {
            return _pessoas.Find(pessoa => pessoa.Id == id).FirstOrDefault();
        }

        public void Remover(string id)
        {
            _pessoas.DeleteOne(pessoa => pessoa.Id == id);
        }
    }
}
