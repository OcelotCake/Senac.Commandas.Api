namespace Comandas.Api.Models
{
    public class ComandaIten
    {
        public int Id { get; set; }
        public int CardapioItenId { get; set; }

        public int ComandaItenId { get; set; }

        public int Quantidade { get; set; }

        public int Statusiten { get; set; }

        public enum StatusIten
        {
            Instock       = 1,
            Outofstock    = 2,
            ErrorNotFound = 3
        }


    }
}
