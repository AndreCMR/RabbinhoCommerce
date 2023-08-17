using System.ComponentModel.DataAnnotations.Schema;

namespace RabbinhoCommerce.Domain.Entities
{
    public class Produto
    {
        public Produto()
        {
            //
        }
        public Produto(int id, string nome, string descricao, decimal preco, string imagemUrl)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            Preco = preco;
            ImagemUrl = imagemUrl;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }

        [Column(TypeName = "VARCHAR(MAX)")]
        public string ImagemUrl { get; set; }




    }
}
