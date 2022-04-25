using CadastroEquipeAPI.Data.Configuration;
using CadastroEquipeAPI.Model;
using MongoDB.Driver;
using System.Collections.Generic;

namespace CadastroEquipeAPI.Data.Repositories
{
    public class EquipeRepository : IEquipeRepository
    {
        private readonly IMongoCollection<Equipe> _equipe;
        public EquipeRepository(IDatabaseConfig databaseConfig)
        {
            var client = new MongoClient(databaseConfig.ConnectionString);
            var database = client.GetDatabase(databaseConfig.DatabaseName);

            _equipe = database.GetCollection<Equipe>("Equipe");
        }
        public void Adicionar(Equipe equipe)
        {
            _equipe.InsertOne(equipe);
        }

        public void Atualizar(string id, Equipe atualizarPessoa)
        {
            _equipe.ReplaceOne(tarefa => tarefa.Id == id, atualizarPessoa);
        }

        public IEnumerable<Equipe> Buscar()
        {
            return _equipe.Find(equipe => true).ToList();
        }

        public Equipe Buscar(string id)
        {
            return _equipe.Find(equipe => equipe.Id == id).FirstOrDefault();
        }

        public void Remover(string id)
        {
            _equipe.DeleteOne(equipe => equipe.Id == id);
        }
    }
}
