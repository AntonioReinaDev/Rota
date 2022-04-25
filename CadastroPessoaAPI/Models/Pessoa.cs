using Newtonsoft.Json;
using System;

namespace CadastroPessoaAPI.Models
{
    public class Pessoa
    {
        public string Id { get; private set; }

        [JsonProperty("Name")]
        public string NomePessoa { get; set; }
        public string DataCadastro { get; set; }

        public Pessoa(string nomePessoa)
        {
            Id = Guid.NewGuid().ToString();
            NomePessoa = nomePessoa;
            DataCadastro = DateTime.Now.ToString("MM/dd/yyyy");
        }

        public void AtualizarPessoa(string nomePessoa)
        {
            NomePessoa = nomePessoa;
        }
    }
}
