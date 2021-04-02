namespace proj3SqlMongo.Dto
{
    public class ProdutoDto
    {
            public int Id { get; set; }
            public string Descricao { get; set; }
            public decimal Preco { get; set; }
            public FornecedorDto Fornecedor { get; set; }
            
    }
}