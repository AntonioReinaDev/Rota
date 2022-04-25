using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace Model
{
    public class Usuario
    {
        //[BsonId]
        //[BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; private set; }
        public string NomeUsuario { get; private set; }
        public string SenhaUsuario { get; private set; }

        public Usuario(string nomePessoa, string senhaUsuario)
        {
            Id = Guid.NewGuid().ToString();
            NomeUsuario = nomePessoa;
            SenhaUsuario = senhaUsuario;
        }

        public void AtualizarSenhaUsuario(string senhaUsuario)
        {
            SenhaUsuario = senhaUsuario;
        }
    }
}
