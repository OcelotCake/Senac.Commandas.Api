using Comandas.Api.Models;
using Microsoft.AspNetCore.Mvc;
using static Comandas.Api.Models.Usuario;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Comandas.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        static List<Usuario> usuarios = new List<Usuario>() {
            new Usuario
            {
                Id = 1,
                Nome = "Admin",
                Email = "admin@admin.com",
                Senha = "admin123",
                Status = (int)StatusUsuario.Admin
                },
            };
        // GET: api/<UsuariosController>
        [HttpGet]
        public IResult Get()
        {
            return Results.Ok(usuarios);
        }

        // GET api/<UsuariosController>/5
        [HttpGet("{id}")]
        public IResult Get(int id)
        {
            var usuario = usuarios.
                FirstOrDefault(u => u.Id == id);
            if (usuario is null)
            return Results.NotFound("Usuario Nao encontrado");
            

                return Results.Ok(usuario);
        }
                
        













        // POST api/<UsuariosController>
        [HttpPost]
        public IResult Post([FromBody] Usuario usuario)
        {
            usuarios.Add(usuario);
            return Results.Created($"/api/usuario/{usuario.Id}", usuario);
        }

















        // PUT api/<UsuariosController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            

        }

        // DELETE api/<UsuariosController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
