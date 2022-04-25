using System;

namespace CadastroCidadeAPI.Model
{
    public class Cidade
    {
        public string Id { get; private set; }
        public string NomeCidade { get; set; }
        public string EstadoCidade { get; set; }

        public Cidade(string nomeCidade, string estadoCidade)
        {
            Id = Guid.NewGuid().ToString();
            NomeCidade = nomeCidade;
            EstadoCidade = estadoCidade;
        }

        public void AtualizarCidade(string nomeCidade, string estadoCidade)
        {
            NomeCidade = nomeCidade;
            EstadoCidade = estadoCidade;
        }
    }
}
