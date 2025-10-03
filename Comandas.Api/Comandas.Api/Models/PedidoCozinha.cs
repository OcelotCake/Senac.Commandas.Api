namespace Comandas.Api.Models
{
    public class PedidoCozinha
    {
        public int Id { get; set; }
        public int ComandaId { get; set; }
        public List<PedidoCozinhoItem> Itens { get; set; } = [];
    }
}
