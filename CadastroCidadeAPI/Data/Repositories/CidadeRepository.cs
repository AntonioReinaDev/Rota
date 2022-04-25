using CadastroCidadeAPI.Data.Configuration;
using CadastroCidadeAPI.Model;
using MongoDB.Driver;
using System.Collections.Generic;

namespace CadastroCidadeAPI.Data.Repositories
{
    public class CidadeRepository : ICidadeRepository
    {
        private readonly IMongoCollection<Cidade> _cidade;
        public CidadeRepository(IDatabaseConfig databaseConfig)
        {
            var client = new MongoClient(databaseConfig.ConnectionString);
            var database = client.GetDatabase(databaseConfig.DatabaseName);

            _cidade = database.GetCollection<Cidade>("Cidade");
        }
        public void Adicionar(Cidade cidade)
        {
            _cidade.InsertOne(cidade);
        }

        public void Atualizar(string id, Cidade atualizarCidade)
        {
            _cidade.ReplaceOne(cidade => cidade.Id == id, atualizarCidade);
        }

        public IEnumerable<Cidade> Buscar()
        {
            return _cidade.Find(cidade => true).ToList();
        }

        public Cidade Buscar(string id)
        {
            return _cidade.Find(cidade => cidade.Id == id).FirstOrDefault();
        }

        public void Remover(string id)
        {
            _cidade.DeleteOne(cidade => cidade.Id == id);
        }
    }
}
