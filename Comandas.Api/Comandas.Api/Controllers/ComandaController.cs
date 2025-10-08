using Comandas.Api.DTOs;
using Comandas.Api.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Comandas.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComandaController : ControllerBase
    {
        public List<Comanda> comandas = new List<Comanda>()
        {
             new Comanda
             { 
                Id = 1,
               NomeCliente = "Joao",
               NumeroMesa = 1
             },

              new Comanda
             { Id = 2,
               NomeCliente = "Joao",
               NumeroMesa = 2,
             }

        };
        // GET: api/<ComandaController>
        [HttpGet]
        public IResult Get()
        {
            return Results.Ok(comandas);
        }

        // GET api/<ComandaController>/5
        [HttpGet("{id}")]
        public IResult Get(int id)
        {
            var comanda = comandas
                .FirstOrDefault(c => c.Id == id);
            if (comanda is null)
            
                return Results.NotFound("Comanda nao encontrada");
                        return Results.Ok(comanda);
        }

        // POST api/<ComandaController>
        [HttpPost]
        public IResult Post([FromBody] ComandaCreateRequest ComandaCreate)
        {
            
            if (ComandaCreate.NomeCliente.Length < 3)
                return Results.BadRequest("O nome do cliente deve ter pelo menos 3 caracteres.");
            if (ComandaCreate.NumeroMesa <= 0)
                return Results.BadRequest("O numero da mesa deve ser maior que zero.");
            if (ComandaCreate.CardapioItemsIds.Length == 0)
                return Results.BadRequest("A comanda deve ter pelo menos um item do cardapio.");
            var novaComanda = new Comanda
            {
                Id = comandas.Count + 1,
                NomeCliente = ComandaCreate.NomeCliente,
                NumeroMesa = ComandaCreate.NumeroMesa,
          
            };
            comandas.Add(novaComanda);
            return Results.Created($"/api/comanda/{novaComanda.Id}", novaComanda);
        }

        // PUT api/<ComandaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<ComandaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
