namespace API_CadastroPessoa.Data.Configuration
{
    public class DatabaseConfig : IDatabaseConfig
    {
        public string DatabaseName { get; set; }
        public string ConnectionString { get; set; }
    }
}
