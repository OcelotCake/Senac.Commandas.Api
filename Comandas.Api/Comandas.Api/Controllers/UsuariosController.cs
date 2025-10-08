using Comandas.Api.DTOs;
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
        public IResult Post([FromBody] UsuarioCreateRequest usuariocreate)
        {

            { 
            if (usuariocreate.Senha.Length < 6)
                return Results.BadRequest("A senha deve ter pelo menos 6 caracteres.");
            if (usuariocreate.Nome.Length < 3)
                return Results.BadRequest("Email invalido");
            if (usuariocreate.Email.Length < 5 || !usuariocreate.Email.Contains("@"))
            return Results.BadRequest("O email deve ser valido.");
        }
                var usuario = new Usuario
               { Nome = usuariocreate.Nome,
                Email = usuariocreate.Email,
                Senha = usuariocreate.Senha,
                Status = usuariocreate.Status
            };
            usuarios.Add(usuario);
            return Results.Created($"/api/usuario/{usuario.Id}", usuario);
        }

















        // PUT api/<UsuariosController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] UsuarioUpdateRequest usuarioUpdate)
        {
           


        }

        // DELETE api/<UsuariosController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
