using System;

namespace Model
{
    public class Usuario
    {
        public string Id { get; private set; }
        public string NomeUsuario { get; set; }
        public string SenhaUsuario { get; set; }

        public Usuario(string nomeUsuario, string senhaUsuario)
        {
            Id = Guid.NewGuid().ToString();
            NomeUsuario = nomeUsuario;
            SenhaUsuario = senhaUsuario;
        }

        public void AtualizarSenhaUsuario(string senhaUsuario)
        {
            SenhaUsuario = senhaUsuario;
        }
    }
}
