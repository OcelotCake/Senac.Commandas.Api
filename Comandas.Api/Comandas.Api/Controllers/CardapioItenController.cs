using Comandas.Api.DTOs;
using Comandas.Api.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Comandas.Api.Controllers
{
    [Route("api/[controller]")]// Define a rota base para o controlador
    [ApiController] // Define que é um controlador de API
    public class CardapioItenController : ControllerBase // Herdar de ControllerBase para funcionalidades básicas de API
    {
        // GET: api/<CardapioItenController>
        [HttpGet]
        public IEnumerable<CardapioIten> GetCardapios()
        {
            return new CardapioIten[] // Retorna uma lista de itens do cardápio
            {
                new CardapioIten // Primeiro item do cardápio
                {
                Id = 1,
                Titulo = "Refrigerante",
                Descricao = "Cola Can",
                Preco = 5.00m,
                PossuiPreparo = true
                 },
                new CardapioIten
                {
                Id = 2,
                Titulo = "Xis",
                Descricao = "X-carne",
                Preco = 25.00m,
                PossuiPreparo = true
                    },

                };

        }

       public List<CardapioIten> cardapios = new List<CardapioIten>(){
        
            new CardapioIten 
            { Id = 1, Titulo = "Refrigerante", 
                Descricao = "Cola Can", 
                Preco = 5.00m, 
                PossuiPreparo = true },

            new CardapioIten 

            { Id = 2, Titulo = "Xis", 
                Descricao = "X-carne", 
                Preco = 25.00m, 
                PossuiPreparo = true },

            new CardapioIten

            { Id = 3, Titulo = "Suco",
                Descricao = "Laranja",
                Preco = 7.00m, 
                PossuiPreparo = false },

            new CardapioIten 

            { Id = 4, Titulo = "Salada",
                Descricao = "Salada verde",
                Preco = 15.00m, 
                PossuiPreparo = true }
        };
        // GET api/<CardapioItenController>/1
        [HttpGet("{id}")]
        public IResult Get(int id)
        {
            // Retorna um item do cardápio com base no ID fornecido
            var cardapio = cardapios.FirstOrDefault(c => c.Id == id);
            if (cardapio is null)
            {
                return Results.NotFound("Cardapio Nao encontrado");

            }
            return Results.Ok(cardapio);

        }

        // POST api/<CardapioItenController>
        [HttpPost]
        public void Post([FromBody] CardapioItemCreateRequest cardapio)
        {

        }

        // PUT api/<CardapioItenController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] CardapioItemUpdateRequest cardapio)
        {
        }

        // DELETE api/<CardapioItenController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
