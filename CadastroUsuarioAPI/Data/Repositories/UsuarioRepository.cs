using CadastroUsuarioAPI.Data.Configuration;
using Model;
using MongoDB.Driver;
using System.Collections.Generic;

namespace CadastroUsuarioAPI.Data.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly IMongoCollection<Usuario> _usuario;
        public UsuarioRepository(IDatabaseConfig databaseConfig)
        {
            var client = new MongoClient(databaseConfig.ConnectionString);
            var database = client.GetDatabase(databaseConfig.DatabaseName);

            _usuario = database.GetCollection<Usuario>("Usuario");
        }
        public void Adicionar(Usuario usuario)
        {
            _usuario.InsertOne(usuario);
        }

        public void Atualizar(string id, Usuario atualizarUsuario)
        {
            _usuario.ReplaceOne(tarefa => tarefa.Id == id, atualizarUsuario);
        }

        public IEnumerable<Usuario> Buscar()
        {
            return _usuario.Find(tarefa => true).ToList();
        }

        public Usuario Buscar(string id)
        {
            return _usuario.Find(tarefa => tarefa.Id == id).FirstOrDefault();
        }

        public void Remover(string id)
        {
            _usuario.DeleteOne(tarefa => tarefa.Id == id);
        }
    }
}
