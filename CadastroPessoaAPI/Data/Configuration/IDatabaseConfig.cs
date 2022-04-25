namespace CadastroPessoaAPI.Data.Configuration
{
    public interface IDatabaseConfig
    {
        string DatabaseName { get; set; }
        string ConnectionString { get; set; }
    }
}
