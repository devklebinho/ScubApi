using Microsoft.AspNetCore.Mvc;
using ScubApi.Data;
using ScubApi.Models;

namespace ScubApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuariosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public UsuariosController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult CriarUsuario([FromBody] Usuario usuario)
        {
            usuario.DataCadastro = DateTime.Now;

            _context.Usuarios.Add(usuario);
            _context.SaveChanges();

            return CreatedAtAction(nameof(CriarUsuario), new { id = usuario.Id }, usuario);
        }
    }
}