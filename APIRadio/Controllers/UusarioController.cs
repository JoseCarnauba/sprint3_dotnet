using APIRadio.Model;
using APIRadio.Service;
using Microsoft.AspNetCore.Mvc;

namespace APIRadio.Controllers
{
    [ApiController]
[Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly UsuarioService _service;

        public UsuarioController(UsuarioService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Get() => Ok(await _service.GetAll());

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var usuario = await _service.GetById(id);
            if (usuario == null) return NotFound();
            return Ok(usuario);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Usuario usuario)
        {
            await _service.Add(usuario);
            return CreatedAtAction(nameof(Get), new { id = usuario.Id }, usuario);
        }

        [HttpPut("{id}")]
        public Task<IActionResult> Put(int id, [FromBody] Usuario usuario)
        {
            if (id != usuario.Id) return Task.FromResult<IActionResult>(BadRequest());
            _service.Update(usuario);
            return Task.FromResult<IActionResult>(NoContent());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.Delete(id);
            return NoContent();
        }
    }
}
