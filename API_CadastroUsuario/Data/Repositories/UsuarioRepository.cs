using API_CadastroUsuario.Data.Configuration;
using Model;
using MongoDB.Driver;
using System.Collections.Generic;

namespace API_CadastroUsuario.Data.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly IMongoCollection<Usuario> _usuario;

        public UsuarioRepository(IDatabaseConfig databaseConfig)
        {
            var client = new MongoClient(databaseConfig.ConnectionString);
            var database = client.GetDatabase(databaseConfig.DatabaseName);
            _usuario = database.GetCollection<Usuario>("Usuarios");
        }

        public void Adicionar(Usuario usuario)
        {
            _usuario.InsertOne(usuario);
        }

        public void Atualizar(string id, Usuario atualizaSenhaUsuario)
        {
            _usuario.ReplaceOne(usuario => usuario.Id == id, atualizaSenhaUsuario);
        }

        public IEnumerable<Usuario> Buscar()
        {
            return _usuario.Find(usuario => true).ToList();
        }

        public Usuario Buscar(string id)
        {
            return _usuario.Find(usuario => usuario.Id == id).FirstOrDefault();
        }

        public void Remover(string id)
        {
            _usuario.DeleteOne(usuario => usuario.Id == id);
        }
    }
}
