using System;

namespace CadastroEquipeAPI.Model
{
    public class Equipe
    {
        public string Id { get; private set; }
        public string NomeEquipe { get; set; }

        public Equipe(string nomeEquipe)
        {
            Id = Guid.NewGuid().ToString();
            NomeEquipe = nomeEquipe;
        }

        public void AtualizarEquipe(string nomeEquipe)
        {
            NomeEquipe = nomeEquipe;
        }
    }
}
