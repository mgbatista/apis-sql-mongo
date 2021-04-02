namespace Proj1_BancoDeDados.Models
{
    public class Cliente
    {
        #region Propriedades

            public int Id  {get; set; }
            public string Nome { get; set; }
            public int Idade { get; set; }
            public string NomeMae { get; set; }
            public Endereco Endereco { get; set; }

        #endregion

    }
}