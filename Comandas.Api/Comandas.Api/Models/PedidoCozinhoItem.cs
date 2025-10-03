namespace Comandas.Api.Models
{
    public class PedidoCozinhoItem
    {
        public int Id { get; set; }
        public int PedidoCozinhaId { get; set; }

        public string NomeProduto{ get; set; }
        public int Quantidade { get; set; }
        public int Status{ get; set; }

        public int ComandaItenId { get; set; }


    }

}
