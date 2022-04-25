using System;

namespace Model
{
    public class Pessoa
    {
        public string Id { get; private set; }
        public string NomePessoa { get; private set; }
        public string DataCadastro { get; private set; }

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
