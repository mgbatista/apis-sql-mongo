namespace Proj1_BancoDeDados_Mongo.Utils
{
    public class ProjMongoDotnetDatabaseSettings : IProjMongoDotnetDatabaseSettings
    {
        public string ProdutoCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}