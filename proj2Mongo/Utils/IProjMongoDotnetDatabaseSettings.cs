namespace Proj1_BancoDeDados_Mongo.Utils
{
    public interface IProjMongoDotnetDatabaseSettings
    {
         string ProdutoCollectionName { get; set; }
         string ConnectionString { get; set; }
         string DatabaseName { get; set; }
    }
}