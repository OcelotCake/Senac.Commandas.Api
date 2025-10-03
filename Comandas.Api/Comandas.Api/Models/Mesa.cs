namespace Comandas.Api.Models
{
    public class Mesa
    {
        public int Id { get; set; }
        public int NumeroMesa { get; set; }

        public int SituacaoMesa { get; set; }
    }

        public enum SituacaoMesa
        {
            Disponivel = 1,
            Ocupada = 2,
            Reservada = 3
        }

    }

