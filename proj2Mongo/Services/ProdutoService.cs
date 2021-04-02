using System.Collections.Generic;
using MongoDB.Driver;
using Proj1_BancoDeDados_Mongo.Models;
using Proj1_BancoDeDados_Mongo.Utils;

namespace Proj1_BancoDeDados_Mongo.Services
{
    public class ProdutoService
    {
        private readonly IMongoCollection<Produto> _produtos;

        public ProdutoService(IProjMongoDotnetDatabaseSettings settings)
        {
            var produt = new MongoClient(settings.ConnectionString);
            var database = produt.GetDatabase(settings.DatabaseName);
            _produtos = database.GetCollection<Produto>(settings.ProdutoCollectionName);
        }

        public List<Produto> Get() =>
            _produtos.Find(produto => true).ToList();

        public Produto Get(int id) =>
            _produtos.Find<Produto>(produto => produto.Id == id).FirstOrDefault();

        public Produto Create(Produto produto)
        {
            _produtos.InsertOne(produto);
            return produto;
        }

        public void Update(int id, Produto produtoIn) =>
            _produtos.ReplaceOne(produto => produto.Id == id, produtoIn);

        public void Remove(Produto produtoIn) =>
            _produtos.DeleteOne(produto => produto.Id == produtoIn.Id);

        public void Remove(int id) => 
            _produtos.DeleteOne(produto => produto.Id == id);
    }
}